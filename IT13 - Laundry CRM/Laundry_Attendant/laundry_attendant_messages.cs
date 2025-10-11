using IT13___Laundry_CRM.Models;
using IT13___Laundry_CRM.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static IT13___Laundry_CRM.Models.User;
using Message = IT13___Laundry_CRM.Models.Message;

namespace IT13___Laundry_CRM.Laundry_Attendant
{
    public partial class laundry_attendant_messages : Laundry_Attendant_Template
    {

        private readonly UserRepository userRepository = new UserRepository();
        private readonly MessageRepository messageRepository = new MessageRepository();

        private List<Message> currentConversation = new List<Message>();
        private List<User> allUsers = new List<User>();
        private User selectedUser = null;
        private List<User> filteredUsers = new List<User>();

        public laundry_attendant_messages()
        {
            InitializeComponent();
            LoadAllUsers();

            listbox_messages.DrawMode = DrawMode.OwnerDrawVariable;
            listbox_messages.MeasureItem += listbox_messages_MeasureItem;
            listbox_messages.DrawItem += listbox_messages_DrawItem;


            textbox_searchUser.TextChanged += textbox_searchUser_TextChanged;
            listbox_users.SelectedIndexChanged += listbox_users_SelectedIndexChanged;

            MakeRounded(textbox_message);
            MakeRounded(listbox_messages);
            MakeRounded(textbox_searchUser);
            MakeRounded(listbox_users);
            MakeRounded(button_send);
            MakeRounded(panel3);

            listbox_users.DrawMode = DrawMode.OwnerDrawFixed;
            listbox_users.ItemHeight = 60;
            listbox_users.DrawItem += listbox_users_DrawItem;
        }

        private void MakeRounded(Control control, int radius = 20)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90); // Top-left
            path.AddArc(new Rectangle(control.Width - radius, 0, radius, radius), 270, 90); // Top-right
            path.AddArc(new Rectangle(control.Width - radius, control.Height - radius, radius, radius), 0, 90); // Bottom-right
            path.AddArc(new Rectangle(0, control.Height - radius, radius, radius), 90, 90); // Bottom-left
            path.CloseFigure();

            control.Region = new Region(path);

            // Optional: handle resizing to keep corners rounded
            control.SizeChanged += (s, e) => MakeRounded(control, radius);
        }

        private void LoadAllUsers()
        {
            try
            {
                // Get all relevant users
                allUsers = userRepository.GetUsers()
                    .Where(u => u.role == "customer" || u.role == "admin")
                    .ToList();

                // Get the latest message datetime per user
                var userLatestMessage = allUsers.Select(u =>
                {
                    var latestMsg = messageRepository.GetConversation(CurrentUser.UserId, u.user_id)
                                                     .OrderByDescending(m => m.created_at)
                                                     .FirstOrDefault();
                    return new { User = u, LastMessageTime = latestMsg?.created_at ?? DateTime.MinValue };
                });

                // Sort users by latest message datetime descending
                allUsers = userLatestMessage
                           .OrderByDescending(x => x.LastMessageTime)
                           .Select(x => x.User)
                           .ToList();

                UpdateUserList(allUsers);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        private void UpdateUserList(List<User> users)
        {
            filteredUsers = users; // save filtered list
            listbox_users.Items.Clear();
            foreach (var u in users)
            {
                listbox_users.Items.Add($"{u.first_name} {(string.IsNullOrEmpty(u.middle_name) ? "" : u.middle_name + " ")}{u.last_name} ({u.role})");
            }
        }

        private void LoadMessages()
        {
            try
            {
                if (selectedUser == null)
                {
                    listbox_messages.Items.Clear();
                    return;
                }

                currentConversation = messageRepository.GetConversation(CurrentUser.UserId, selectedUser.user_id);
                listbox_messages.Items.Clear();

                // Preload users for name lookup
                var userDict = allUsers.ToDictionary(u => u.user_id,
                    u => $"{u.first_name} {(string.IsNullOrEmpty(u.middle_name) ? "" : u.middle_name + " ")}{u.last_name}");

                foreach (var msg in currentConversation)
                {
                    string senderName = msg.sender_id == CurrentUser.UserId
                        ? "You"
                        : (userDict.ContainsKey(msg.sender_id) ? userDict[msg.sender_id] : $"User {msg.sender_id}");

                    listbox_messages.Items.Add(new
                    {
                        SenderId = msg.sender_id,
                        SenderName = senderName,
                        Text = msg.message,
                        DateTimeDisplay = msg.created_at.ToString("MMM dd, yyyy hh:mm tt")
                    });
                }

                listbox_messages.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading conversation: " + ex.Message);
            }
        }





        private void button_send_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    // Ensure a user is selected
            //    if (combobox_users.SelectedIndex == -1)
            //    {
            //        MessageBox.Show("Please select a user to send the message to.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }

            //    // Get the receiver ID from the combo box
            //    int receiverId = (int)combobox_users.SelectedValue;

            //    // Get the message text
            //    string messageText = textbox_message.Text.Trim(); // Make sure you have a TextBox named 'textbox_message'

            //    if (string.IsNullOrEmpty(messageText))
            //    {
            //        MessageBox.Show("Please enter a message before sending.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }

            //    // Create the Message object
            //    Message message = new Message
            //    {
            //        sender_id = CurrentUser.UserId, // Replace with your current logged-in user logic
            //        receiver_id = receiverId,
            //        message = messageText,
            //        created_at = DateTime.Now
            //    };

            //    // Save the message
            //    bool success = messageRepository.AddMessage(message);

            //    if (success)
            //    {
            //        //MessageBox.Show("Message sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        textbox_message.Clear();
            //        LoadMessages();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Failed to send the message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error sending message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void laundry_attendant_messages_Load(object sender, EventArgs e)
        {

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
                //MessageBox.Show("Message updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        //MessageBox.Show("Message deleted successfully!", "Success",
                        //                MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void listbox_messages_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index < 0) return;

            dynamic item = listbox_messages.Items[e.Index];
            using (var g = listbox_messages.CreateGraphics())
            {
                SizeF textSize = g.MeasureString(item.Text, listbox_messages.Font, 300);
                e.ItemHeight = (int)textSize.Height + 25; // padding
            }
        }

        private void listbox_messages_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();
            dynamic item = listbox_messages.Items[e.Index];
            bool isCurrentUser = item.SenderId == CurrentUser.UserId;

            // Chat bubble bounds
            int bubbleWidth = 300;
            int margin = 10;
            int x = isCurrentUser ? e.Bounds.Right - bubbleWidth - margin : margin;
            int y = e.Bounds.Top + 5;

            // Bubble color
            Color bubbleColor = isCurrentUser ? Color.LightBlue : Color.LightGray;
            Color textColor = Color.Black;

            using (SolidBrush brush = new SolidBrush(bubbleColor))
            using (SolidBrush textBrush = new SolidBrush(textColor))
            using (Font timeFont = new Font("Segoe UI", 8, FontStyle.Italic))
            {
                Rectangle bubbleRect = new Rectangle(x, y, bubbleWidth, e.Bounds.Height - 5);
                e.Graphics.FillRoundedRectangle(brush, bubbleRect, 10);

                // Draw text
                e.Graphics.DrawString(item.Text, listbox_messages.Font, textBrush, bubbleRect);

                // Draw timestamp
                string time = item.DateTimeDisplay;
                SizeF timeSize = e.Graphics.MeasureString(time, timeFont);
                e.Graphics.DrawString(time, timeFont, Brushes.Gray,
                    isCurrentUser ? bubbleRect.Right - timeSize.Width - 5 : bubbleRect.Left + 5,
                    bubbleRect.Bottom - timeSize.Height - 5);
            }

            e.DrawFocusRectangle();
        }

        private void button_send_Click_1(object sender, EventArgs e)
        {
            if (selectedUser == null)
            {
                MessageBox.Show("Please select a user first.");
                return;
            }

            string messageText = textbox_message.Text.Trim();
            if (string.IsNullOrEmpty(messageText)) return;

            Message message = new Message
            {
                sender_id = CurrentUser.UserId,
                receiver_id = selectedUser.user_id,
                message = messageText,
                created_at = DateTime.Now
            };

            if (messageRepository.AddMessage(message))
            {
                textbox_message.Clear();
                LoadMessages();
            }
            else
            {
                MessageBox.Show("Failed to send message.");
            }
        }

        private void listbox_messages_DrawItem_1(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();
            dynamic item = listbox_messages.Items[e.Index];
            bool isCurrentUser = item.SenderId == CurrentUser.UserId;

            // Chat bubble bounds
            int bubbleWidth = 300;
            int margin = 10;
            int x = isCurrentUser ? e.Bounds.Right - bubbleWidth - margin : margin;
            int y = e.Bounds.Top + 5;

            // Bubble color
            Color bubbleColor = isCurrentUser ? Color.LightBlue : Color.LightGray;
            Color textColor = Color.Black;

            using (SolidBrush brush = new SolidBrush(bubbleColor))
            using (SolidBrush textBrush = new SolidBrush(textColor))
            using (Font timeFont = new Font("Segoe UI", 8, FontStyle.Italic))
            {
                Rectangle bubbleRect = new Rectangle(x, y, bubbleWidth, e.Bounds.Height - 5);
                e.Graphics.FillRoundedRectangle(brush, bubbleRect, 10);

                // Draw text
                e.Graphics.DrawString(item.Text, listbox_messages.Font, textBrush, bubbleRect);

                // Draw timestamp
                string time = item.DateTimeDisplay;
                SizeF timeSize = e.Graphics.MeasureString(time, timeFont);
                e.Graphics.DrawString(time, timeFont, Brushes.Gray,
                    isCurrentUser ? bubbleRect.Right - timeSize.Width - 5 : bubbleRect.Left + 5,
                    bubbleRect.Bottom - timeSize.Height - 5);
            }

            e.DrawFocusRectangle();
        }

        private void listbox_messages_MeasureItem_1(object sender, MeasureItemEventArgs e)
        {
            if (e.Index < 0) return;

            dynamic item = listbox_messages.Items[e.Index];
            using (var g = listbox_messages.CreateGraphics())
            {
                SizeF textSize = g.MeasureString(item.Text, listbox_messages.Font, 300);
                e.ItemHeight = (int)textSize.Height + 25; // padding
            }
        }

        private void textbox_searchUser_TextChanged(object sender, EventArgs e)
        {
            string search = textbox_searchUser.Text.Trim().ToLower();
            var filtered = allUsers
                .Where(u => u.first_name.ToLower().Contains(search) ||
                            (u.middle_name != null && u.middle_name.ToLower().Contains(search)) ||
                            u.last_name.ToLower().Contains(search) ||
                            u.role.ToLower().Contains(search))
                .ToList();
            UpdateUserList(filtered);
        }

        private void listbox_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox_users.SelectedIndex == -1) return;

            selectedUser = filteredUsers[listbox_users.SelectedIndex]; // use filteredUsers, not allUsers
            LoadMessages();
        }

        private void listbox_users_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();
            User user = filteredUsers[e.Index];

            Graphics g = e.Graphics;
            Rectangle bounds = e.Bounds;
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            // Background
            Color backColor = isSelected ? Color.AliceBlue : SystemColors.GradientInactiveCaption;
            using (SolidBrush bgBrush = new SolidBrush(backColor))
            {
                g.FillRectangle(bgBrush, bounds);
            }

            // Rounded avatar placeholder
            int avatarSize = 40;
            int padding = 10;
            Rectangle avatarRect = new Rectangle(bounds.Left + padding, bounds.Top + (bounds.Height - avatarSize) / 2, avatarSize, avatarSize);
            using (SolidBrush avatarBrush = new SolidBrush(Color.Gray))
            {
                GraphicsPath avatarPath = new GraphicsPath();
                avatarPath.AddEllipse(avatarRect);
                g.FillPath(avatarBrush, avatarPath);
            }

            // Name
            string displayName = $"{user.first_name} {(string.IsNullOrEmpty(user.middle_name) ? "" : user.middle_name + " ")}{user.last_name}";
            using (Font nameFont = new Font("Gadugi", 10, FontStyle.Bold))
            using (SolidBrush nameBrush = new SolidBrush(Color.Black))
            {
                g.DrawString(displayName, nameFont, nameBrush, avatarRect.Right + padding, bounds.Top + 10);
            }

            // Role
            using (Font roleFont = new Font("Gadugi", 8, FontStyle.Italic))
            using (SolidBrush roleBrush = new SolidBrush(Color.DarkGray))
            {
                g.DrawString(user.role, roleFont, roleBrush, avatarRect.Right + padding, bounds.Top + 30);
            }

            // --- Add border around the item ---
            using (Pen borderPen = new Pen(Color.LightGray, 1))
            {
                Rectangle borderRect = new Rectangle(bounds.Left, bounds.Top, bounds.Width - 1, bounds.Height - 1);
                g.DrawRectangle(borderPen, borderRect);
            }

            e.DrawFocusRectangle();
        }
    }
}


public static class GraphicsExtensions
{
    public static void FillRoundedRectangle(this Graphics g, Brush brush, Rectangle bounds, int cornerRadius)
    {
        using (var path = new System.Drawing.Drawing2D.GraphicsPath())
        {
            path.AddArc(bounds.X, bounds.Y, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(bounds.Right - cornerRadius, bounds.Y, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(bounds.Right - cornerRadius, bounds.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseFigure();
            g.FillPath(brush, path);
        }
    }
}