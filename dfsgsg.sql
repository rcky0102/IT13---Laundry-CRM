CREATE TABLE [dbo].[StatusHistory] (
    history_id INT IDENTITY(1,1) PRIMARY KEY,
    status_id INT NULL,          
    user_id INT NOT NULL,
    status NVARCHAR(50) NULL,
    created_at DATETIME DEFAULT GETDATE() NOT NULL,
    FOREIGN KEY (user_id) REFERENCES [dbo].[Users](user_id),
    FOREIGN KEY (status_id) REFERENCES [dbo].[Status](status_id)
);
