create table [dbo].[Messages] (
[message_id] int identity(1,1) primary key not null,
[sender_id] int not null,
[receiver_id] int not null, 
[message] nvarchar(max) null, 
[created_at] datetime default getdate(),

constraint [FK_Sender] foreign key ([sender_id]) references [dbo].[Users]([user_id]),
constraint [FK_Receiver] foreign key ([receiver_id]) references [dbo].[Users]([user_id])
);