create table [dbo].[Feedback] 
(
[feedback_id] int identity(1,1) primary key not null,
[user_id] int not null,
[subject] nvarchar(100) null,
[feedback] nvarchar(max) null,
[created_at] datetime default getdate(),
[updated_at] datetime default getdate(),

constraint FK_Feedback_Users foreign key ([user_id]) references [dbo].[Users]([user_id])

);