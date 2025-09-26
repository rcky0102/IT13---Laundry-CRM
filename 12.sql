create table [dbo].[Status] (
[status_id] int identity(1,1) primary key not null,
[user_id] int not null,
[status] nvarchar(50) null,
created_at datetime default getdate(),

constraint FK_Status_Users foreign key (user_id) references [dbo].[Users](user_id)

);