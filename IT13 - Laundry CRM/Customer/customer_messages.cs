using IT13___Laundry_CRM.Repositories;
using IT13___Laundry_CRM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static IT13___Laundry_CRM.Models.User;
using Message = IT13___Laundry_CRM.Models.Message;

namespace IT13___Laundry_CRM.Customer
{
    public partial class customer_messages : customer_template
    {

        private readonly UserRepository userRepository = new UserRepository();
        private readonly MessageRepository messageRepository = new MessageRepository();

        private List<Message> currentConversation = new List<Message>();

        public customer_messages()
        {
            InitializeComponent();
            LoadMessages();
        }

        private void customer_messages_Load(object sender, EventArgs e)
        {
            LoadUsersToComboBox();

            combobox_users.SelectedIndexChanged += combobox_users_SelectedIndexChanged;
        }

        private void LoadUsersToComboBox()
        {
            try
            {
                var users = userRepository.GetUsers();

                var filteredUsers = users
                    .Where(u => u.role == "laundry_attendant" || u.role == "admin")
                    .Select(u => new UserComboItem
                    {
                        user_id = u.user_id,
                        FullName = $"{u.first_name} {(string.IsNullOrEmpty(u.middle_name) ? "" : u.middle_name + " ")}{u.last_name} ({u.role})"
                    })
                    .ToList();

                combobox_users.DisplayMember = "FullName";
                combobox_users.ValueMember = "user_id";
                combobox_users.DataSource = filteredUsers;
                combobox_users.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMessages()
        {
            try
            {
                if (combobox_users.SelectedIndex == -1)
                {
                    listbox_messages.Items.Clear();
                    return;
                }

                int selectedUserId = (int)combobox_users.SelectedValue;

                currentConversation = messageRepository.GetConversation(CurrentUser.UserId, selectedUserId);

                // Fetch only conversation between current user and selected user
                var messages = messageRepository.GetConversation(CurrentUser.UserId, selectedUserId);

                listbox_messages.Items.Clear();

                foreach (var msg in messages)
                {
                    string sender = msg.sender_id == CurrentUser.UserId ? "You" : $"User {msg.sender_id}";
                    string receiver = msg.receiver_id == CurrentUser.UserId ? "You" : $"User {msg.receiver_id}";

                    listbox_messages.Items.Add(
                        $"[{msg.created_at:MM/dd/yyyy HH:mm}] {sender} → {receiver}: {msg.message}"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading conversation: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a user is selected
                if (combobox_users.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a user to send the message to.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the receiver ID from the combo box
                int receiverId = (int)combobox_users.SelectedValue;

                // Get the message text
                string messageText = textbox_message.Text.Trim(); // Make sure you have a TextBox named 'textbox_message'

                if (string.IsNullOrEmpty(messageText))
                {
                    MessageBox.Show("Please enter a message before sending.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create the Message object
                Message message = new Message
                {
                    sender_id = CurrentUser.UserId, // Replace with your current logged-in user logic
                    receiver_id = receiverId,
                    message = messageText,
                    created_at = DateTime.Now
                };

                // Save the message
                bool success = messageRepository.AddMessage(message);

                if (success)
                {
                    MessageBox.Show("Message sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textbox_message.Clear();
                    LoadMessages();
                }
                else
                {
                    MessageBox.Show("Failed to send the message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (listbox_messages.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a message to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected message
            var selectedMessage = currentConversation[listbox_messages.SelectedIndex];

            // Only allow editing if the current user is the sender
            if (selectedMessage.sender_id != CurrentUser.UserId)
            {
                MessageBox.Show("You can only edit your own messages.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Show input dialog to edit the text
            string newText = Microsoft.VisualBasic.Interaction.InputBox(
                "Edit your message:",
                "Edit Message",
                selectedMessage.message
            );

            if (string.IsNullOrWhiteSpace(newText)) return;

            // Update in DB
            bool success = messageRepository.UpdateMessage(selectedMessage.message_id, newText);

            if (success)
            {
                MessageBox.Show("Message updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMessages();
            }
            else
            {
                MessageBox.Show("Failed to update message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if user selected a message
                if (listbox_messages.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a message to delete.", "Warning",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the selected message object
                var selectedMessage = currentConversation[listbox_messages.SelectedIndex];

                // Confirm delete
                var confirm = MessageBox.Show("Are you sure you want to delete this message?",
                                              "Confirm Delete",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    bool success = messageRepository.DeleteMessage(selectedMessage.message_id);

                    if (success)
                    {
                        MessageBox.Show("Message deleted successfully!", "Success",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadMessages(); // Refresh messages after delete
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the message.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting message: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void combobox_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMessages();
        }
    }
}
