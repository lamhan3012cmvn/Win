
CREATE DATABASE win0613
GO
USE win0613
GO
/****** Object:  Table [dbo].[Academic]    Script Date: 6/26/2020 12:53:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Academic](
	[academicLevelID] [nchar](20) NOT NULL,
	[name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Academic] PRIMARY KEY CLUSTERED 
(
	[academicLevelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Acount]    Script Date: 6/26/2020 12:53:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Acount](
	[userName] [nchar](20) NOT NULL,
	[pass] [nchar](20) NULL,
 CONSTRAINT [PK_Acount] PRIMARY KEY CLUSTERED 
(
	[userName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Faculty]    Script Date: 6/26/2020 12:53:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faculty](
	[FacultyID] [nchar](100) NOT NULL,
	[FacultyName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Faculty] PRIMARY KEY CLUSTERED 
(
	[FacultyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KindOfTopic]    Script Date: 6/26/2020 12:53:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KindOfTopic](
	[KotID] [nchar](20) NOT NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_KindOfTopic] PRIMARY KEY CLUSTERED 
(
	[KotID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Position]    Script Date: 6/26/2020 12:53:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Position](
	[PositionID] [nchar](20) NOT NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Position] PRIMARY KEY CLUSTERED 
(
	[PositionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Process]    Script Date: 6/26/2020 12:53:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Process](
	[processID] [nchar](20) NOT NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Process] PRIMARY KEY CLUSTERED 
(
	[processID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProcessTopic]    Script Date: 6/26/2020 12:53:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProcessTopic](
	[isPass] [bit] NULL,
	[processID] [nchar](20) NOT NULL,
	[topicID] [nchar](20) NOT NULL,
 CONSTRAINT [PK_ProcessTopic] PRIMARY KEY CLUSTERED 
(
	[processID] ASC,
	[topicID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Student]    Script Date: 6/26/2020 12:53:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[studentID] [nchar](20) NOT NULL,
	[name] [nvarchar](max) NULL,
	[birth] [datetime] NULL,
	[phone] [nchar](100) NULL,
	[mail] [nchar](100) NULL,
	[facultyID] [nchar](100) NULL,
	[userName] [nchar](20) NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[studentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 6/26/2020 12:53:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[teacherID] [nchar](20) NOT NULL,
	[name] [nvarchar](max) NULL,
	[birth] [datetime] NULL,
	[mail] [nchar](100) NULL,
	[phone] [nchar](100) NULL,
	[userName] [nchar](20) NULL,
	[facultyID] [nchar](100) NULL,
	[academicID] [nchar](20) NULL,
	[positionID] [nchar](20) NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[teacherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Team]    Script Date: 6/26/2020 12:53:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Team](
	[teamID] [nchar](20) NOT NULL,
	[studentID] [nchar](20) NOT NULL,
 CONSTRAINT [PK_Team] PRIMARY KEY CLUSTERED 
(
	[teamID] ASC,
	[studentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TeamWork]    Script Date: 6/26/2020 12:53:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TeamWork](
	[teamID] [nchar](20) NOT NULL,
	[link] [nchar](10) NULL,
	[point] [nchar](10) NULL,
	[topicID] [nchar](20) NULL,
	[name] [nchar](100) NULL,
 CONSTRAINT [PK_TeamWork] PRIMARY KEY CLUSTERED 
(
	[teamID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Topic]    Script Date: 6/26/2020 12:53:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Topic](
	[TopicID] [nchar](20) NOT NULL,
	[name] [nvarchar](max) NULL,
	[teacherID] [nchar](20) NULL,
	[kotID] [nchar](20) NULL,
	[facultyID] [nchar](100) NULL,
	[dateForm] [datetime] NULL,
	[dateTo] [datetime] NULL,
 CONSTRAINT [PK_Topic] PRIMARY KEY CLUSTERED 
(
	[TopicID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[Academic] ([academicLevelID], [name]) VALUES (N'AD1                 ', N'Thạc Sĩ')
INSERT [dbo].[Academic] ([academicLevelID], [name]) VALUES (N'AD2                 ', N'Tiến Sĩ')
INSERT [dbo].[Academic] ([academicLevelID], [name]) VALUES (N'AD3                 ', N'Giáo Sư')
INSERT [dbo].[Acount] ([userName], [pass]) VALUES (N'admin               ', N'admin               ')
INSERT [dbo].[Acount] ([userName], [pass]) VALUES (N'GSPK1               ', N'1                   ')
INSERT [dbo].[Acount] ([userName], [pass]) VALUES (N'GSPK2               ', N'1                   ')
INSERT [dbo].[Acount] ([userName], [pass]) VALUES (N'GSPK3               ', N'1                   ')
INSERT [dbo].[Acount] ([userName], [pass]) VALUES (N'GSPK4               ', N'1                   ')
INSERT [dbo].[Acount] ([userName], [pass]) VALUES (N'GSPK5               ', N'1                   ')
INSERT [dbo].[Acount] ([userName], [pass]) VALUES (N'GSPK6               ', N'1                   ')
INSERT [dbo].[Acount] ([userName], [pass]) VALUES (N'GSPK7               ', N'1                   ')
INSERT [dbo].[Acount] ([userName], [pass]) VALUES (N'GSPK8               ', N'1                   ')
INSERT [dbo].[Acount] ([userName], [pass]) VALUES (N'SPK1                ', N'1                   ')
INSERT [dbo].[Acount] ([userName], [pass]) VALUES (N'SPK10               ', N'1                   ')
INSERT [dbo].[Acount] ([userName], [pass]) VALUES (N'SPK11               ', N'1                   ')
INSERT [dbo].[Acount] ([userName], [pass]) VALUES (N'SPK2                ', N'1                   ')
INSERT [dbo].[Acount] ([userName], [pass]) VALUES (N'SPK3                ', N'1                   ')
INSERT [dbo].[Acount] ([userName], [pass]) VALUES (N'SPK4                ', N'1                   ')
INSERT [dbo].[Acount] ([userName], [pass]) VALUES (N'SPK5                ', N'1                   ')
INSERT [dbo].[Acount] ([userName], [pass]) VALUES (N'SPK6                ', N'1                   ')
INSERT [dbo].[Acount] ([userName], [pass]) VALUES (N'SPK7                ', N'1                   ')
INSERT [dbo].[Acount] ([userName], [pass]) VALUES (N'SPK8                ', N'1                   ')
INSERT [dbo].[Acount] ([userName], [pass]) VALUES (N'SPK9                ', N'1                   ')
INSERT [dbo].[Faculty] ([FacultyID], [FacultyName]) VALUES (N'110                                                                                                 ', N'Công Nghệ Thông Tin')
INSERT [dbo].[Faculty] ([FacultyID], [FacultyName]) VALUES (N'111                                                                                                 ', N'Điện-Điện Tử')
INSERT [dbo].[Faculty] ([FacultyID], [FacultyName]) VALUES (N'112                                                                                                 ', N'Cơ Khí Máy')
INSERT [dbo].[Faculty] ([FacultyID], [FacultyName]) VALUES (N'113                                                                                                 ', N'Khoa Học Ứng Dụng')
INSERT [dbo].[Faculty] ([FacultyID], [FacultyName]) VALUES (N'114                                                                                                 ', N'Khoa In')
INSERT [dbo].[Faculty] ([FacultyID], [FacultyName]) VALUES (N'115                                                                                                 ', N'Xây Dựng')
INSERT [dbo].[Faculty] ([FacultyID], [FacultyName]) VALUES (N'116                                                                                                 ', N'Hóa Học')
INSERT [dbo].[KindOfTopic] ([KotID], [name]) VALUES (N'K1                  ', N'Đồ Án Môn Học')
INSERT [dbo].[KindOfTopic] ([KotID], [name]) VALUES (N'K2                  ', N'Đồ Án Tiểu Luận')
INSERT [dbo].[KindOfTopic] ([KotID], [name]) VALUES (N'K3                  ', N'Đồ Án Tốt Nghiệp')
INSERT [dbo].[KindOfTopic] ([KotID], [name]) VALUES (N'K4                  ', N'Đồ Án Chuyên Ngành')
INSERT [dbo].[Position] ([PositionID], [name]) VALUES (N'PS1                 ', N'Trưởng Phòng')
INSERT [dbo].[Position] ([PositionID], [name]) VALUES (N'PS2                 ', N'Phó Phòng')
INSERT [dbo].[Position] ([PositionID], [name]) VALUES (N'PS3                 ', N'Trưởng Khoa')
INSERT [dbo].[Position] ([PositionID], [name]) VALUES (N'PS4                 ', N'Trưởng Phòng Tài Chính')
INSERT [dbo].[Position] ([PositionID], [name]) VALUES (N'PS5                 ', N'Phó Hiệu Trưởng')
INSERT [dbo].[Process] ([processID], [name]) VALUES (N'P1                  ', N'Giai Đoạn 1')
INSERT [dbo].[Process] ([processID], [name]) VALUES (N'P2                  ', N'Giai Đoạn 2')
INSERT [dbo].[Process] ([processID], [name]) VALUES (N'P3                  ', N'Giai Đoạn 3')
INSERT [dbo].[Process] ([processID], [name]) VALUES (N'P4                  ', N'Giai Đoạn 4')
INSERT [dbo].[Process] ([processID], [name]) VALUES (N'P5                  ', N'Giai Đoạn 5')
INSERT [dbo].[Process] ([processID], [name]) VALUES (N'P6                  ', N'Giai Đoạn 6')
INSERT [dbo].[ProcessTopic] ([isPass], [processID], [topicID]) VALUES (1, N'P1                  ', N'TP1                 ')
INSERT [dbo].[ProcessTopic] ([isPass], [processID], [topicID]) VALUES (1, N'P1                  ', N'TP2                 ')
INSERT [dbo].[ProcessTopic] ([isPass], [processID], [topicID]) VALUES (1, N'P1                  ', N'TP3                 ')
INSERT [dbo].[ProcessTopic] ([isPass], [processID], [topicID]) VALUES (1, N'P1                  ', N'TP4                 ')
INSERT [dbo].[ProcessTopic] ([isPass], [processID], [topicID]) VALUES (1, N'P1                  ', N'TP5                 ')
INSERT [dbo].[ProcessTopic] ([isPass], [processID], [topicID]) VALUES (1, N'P1                  ', N'TP6                 ')
INSERT [dbo].[ProcessTopic] ([isPass], [processID], [topicID]) VALUES (1, N'P1                  ', N'TP7                 ')
INSERT [dbo].[ProcessTopic] ([isPass], [processID], [topicID]) VALUES (1, N'P1                  ', N'TP8                 ')
INSERT [dbo].[ProcessTopic] ([isPass], [processID], [topicID]) VALUES (0, N'P2                  ', N'TP1                 ')
INSERT [dbo].[ProcessTopic] ([isPass], [processID], [topicID]) VALUES (1, N'P2                  ', N'TP2                 ')
INSERT [dbo].[ProcessTopic] ([isPass], [processID], [topicID]) VALUES (0, N'P2                  ', N'TP3                 ')
INSERT [dbo].[ProcessTopic] ([isPass], [processID], [topicID]) VALUES (1, N'P2                  ', N'TP4                 ')
INSERT [dbo].[ProcessTopic] ([isPass], [processID], [topicID]) VALUES (1, N'P2                  ', N'TP5                 ')
INSERT [dbo].[ProcessTopic] ([isPass], [processID], [topicID]) VALUES (0, N'P2                  ', N'TP6                 ')
INSERT [dbo].[ProcessTopic] ([isPass], [processID], [topicID]) VALUES (0, N'P2                  ', N'TP7                 ')
INSERT [dbo].[ProcessTopic] ([isPass], [processID], [topicID]) VALUES (0, N'P2                  ', N'TP8                 ')
INSERT [dbo].[ProcessTopic] ([isPass], [processID], [topicID]) VALUES (0, N'P3                  ', N'TP3                 ')
INSERT [dbo].[ProcessTopic] ([isPass], [processID], [topicID]) VALUES (1, N'P3                  ', N'TP4                 ')
INSERT [dbo].[ProcessTopic] ([isPass], [processID], [topicID]) VALUES (1, N'P3                  ', N'TP5                 ')
INSERT [dbo].[ProcessTopic] ([isPass], [processID], [topicID]) VALUES (1, N'P4                  ', N'TP4                 ')
INSERT [dbo].[ProcessTopic] ([isPass], [processID], [topicID]) VALUES (1, N'P5                  ', N'TP4                 ')
INSERT [dbo].[ProcessTopic] ([isPass], [processID], [topicID]) VALUES (0, N'P6                  ', N'TP4                 ')
INSERT [dbo].[Student] ([studentID], [name], [birth], [phone], [mail], [facultyID], [userName]) VALUES (N'SV1                 ', N'Hồ Đức Thiện', CAST(N'2000-07-12 00:00:00.000' AS DateTime), N'0396084832                                                                                          ', N'ThienH@gmail.com                                                                                    ', N'110                                                                                                 ', N'SPK1                ')
INSERT [dbo].[Student] ([studentID], [name], [birth], [phone], [mail], [facultyID], [userName]) VALUES (N'SV10                ', N'Nguyễn Hoài Nam', CAST(N'2000-09-24 00:00:00.000' AS DateTime), N'098748445                                                                                           ', N'NamNH@gmail.com                                                                                     ', N'115                                                                                                 ', N'SPK10               ')
INSERT [dbo].[Student] ([studentID], [name], [birth], [phone], [mail], [facultyID], [userName]) VALUES (N'SV11                ', N'Tấn Lợi', CAST(N'2000-03-27 00:00:00.000' AS DateTime), N'087485414                                                                                           ', N'LoiT@gmail.com                                                                                      ', N'116                                                                                                 ', N'SPK11               ')
INSERT [dbo].[Student] ([studentID], [name], [birth], [phone], [mail], [facultyID], [userName]) VALUES (N'SV2                 ', N'Nguyễn Thúy Hà', CAST(N'2000-03-25 00:00:00.000' AS DateTime), N'096847454                                                                                           ', N'HaNT@gmail.com                                                                                      ', N'110                                                                                                 ', N'SPK2                ')
INSERT [dbo].[Student] ([studentID], [name], [birth], [phone], [mail], [facultyID], [userName]) VALUES (N'SV3                 ', N'Hà Nam Anh', CAST(N'2000-08-26 00:00:00.000' AS DateTime), N'028748464                                                                                           ', N'AnhHN@gmail.com                                                                                     ', N'113                                                                                                 ', N'SPK3                ')
INSERT [dbo].[Student] ([studentID], [name], [birth], [phone], [mail], [facultyID], [userName]) VALUES (N'SV4                 ', N'Phạm Hoài Thanh', CAST(N'2000-08-15 00:00:00.000' AS DateTime), N'082354457                                                                                           ', N'ThanhPH@gmail.com                                                                                   ', N'112                                                                                                 ', N'SPK4                ')
INSERT [dbo].[Student] ([studentID], [name], [birth], [phone], [mail], [facultyID], [userName]) VALUES (N'SV5                 ', N'Lê Hữu Phước', CAST(N'2000-09-25 00:00:00.000' AS DateTime), N'093645871                                                                                           ', N'PhuocLH@gmail.com                                                                                   ', N'112                                                                                                 ', N'SPK5                ')
INSERT [dbo].[Student] ([studentID], [name], [birth], [phone], [mail], [facultyID], [userName]) VALUES (N'SV6                 ', N'Nguyễn Thúy Nga', CAST(N'2000-10-30 00:00:00.000' AS DateTime), N'098487451                                                                                           ', N'NgaNT@gmail.com                                                                                     ', N'111                                                                                                 ', N'SPK6                ')
INSERT [dbo].[Student] ([studentID], [name], [birth], [phone], [mail], [facultyID], [userName]) VALUES (N'SV7                 ', N'Hồ Hạnh Dung', CAST(N'2000-01-28 00:00:00.000' AS DateTime), N'096848874                                                                                           ', N'DungHH@gmail.com                                                                                    ', N'114                                                                                                 ', N'SPK7                ')
INSERT [dbo].[Student] ([studentID], [name], [birth], [phone], [mail], [facultyID], [userName]) VALUES (N'SV8                 ', N'Trần Quốc Việt', CAST(N'2000-07-14 00:00:00.000' AS DateTime), N'098748477                                                                                           ', N'VietTQ@gmail.com                                                                                    ', N'111                                                                                                 ', N'SPK8                ')
INSERT [dbo].[Student] ([studentID], [name], [birth], [phone], [mail], [facultyID], [userName]) VALUES (N'SV9                 ', N'Ngô Anh Tuấn', CAST(N'1999-08-24 00:00:00.000' AS DateTime), N'098748544                                                                                           ', N'TuanNA@gmail.com                                                                                    ', N'113                                                                                                 ', N'SPK9                ')
INSERT [dbo].[Teacher] ([teacherID], [name], [birth], [mail], [phone], [userName], [facultyID], [academicID], [positionID]) VALUES (N'GV1                 ', N'Nguyễn Trọng Hoàn', CAST(N'1980-05-14 00:00:00.000' AS DateTime), N'TinNT@gmail.com                                                                                     ', N'0932541559                                                                                          ', N'GSPK1               ', N'110                                                                                                 ', N'AD1                 ', N'PS3                 ')
INSERT [dbo].[Teacher] ([teacherID], [name], [birth], [mail], [phone], [userName], [facultyID], [academicID], [positionID]) VALUES (N'GV2                 ', N'Bùi Thế Khải', CAST(N'1982-02-21 00:00:00.000' AS DateTime), N'KhaiBT@gmail.com                                                                                    ', N'0984584415                                                                                          ', N'GSPK2               ', N'110                                                                                                 ', N'AD2                 ', N'PS2                 ')
INSERT [dbo].[Teacher] ([teacherID], [name], [birth], [mail], [phone], [userName], [facultyID], [academicID], [positionID]) VALUES (N'GV3                 ', N'Huỳnh Hạnh Dung', CAST(N'1976-09-26 00:00:00.000' AS DateTime), N'DungHH@gmail.com                                                                                    ', N'09878561420                                                                                         ', N'GSPK3               ', N'111                                                                                                 ', N'AD3                 ', N'PS3                 ')
INSERT [dbo].[Teacher] ([teacherID], [name], [birth], [mail], [phone], [userName], [facultyID], [academicID], [positionID]) VALUES (N'GV4                 ', N'Hồ Tấn Hiệp', CAST(N'1986-09-21 00:00:00.000' AS DateTime), N'HiepHT@gmail.com                                                                                    ', N'2984156741                                                                                          ', N'GSPK4               ', N'112                                                                                                 ', N'AD2                 ', N'PS1                 ')
INSERT [dbo].[Teacher] ([teacherID], [name], [birth], [mail], [phone], [userName], [facultyID], [academicID], [positionID]) VALUES (N'GV5                 ', N'Phan Quốc Vương', CAST(N'1980-03-05 21:18:00.000' AS DateTime), N'MoiGV@gmail.com                                                                                     ', N'0222222222                                                                                          ', N'GSPK5               ', N'113                                                                                                 ', N'AD1                 ', N'PS2                 ')
INSERT [dbo].[Teacher] ([teacherID], [name], [birth], [mail], [phone], [userName], [facultyID], [academicID], [positionID]) VALUES (N'GV6                 ', N'Đào Hồng Vinh', CAST(N'1980-06-02 21:18:00.000' AS DateTime), N'A@gmail.com                                                                                         ', N'0987548587                                                                                          ', N'GSPK6               ', N'116                                                                                                 ', N'AD1                 ', N'PS2                 ')
INSERT [dbo].[Teacher] ([teacherID], [name], [birth], [mail], [phone], [userName], [facultyID], [academicID], [positionID]) VALUES (N'GV7                 ', N'Nguyễn Quang Khải', CAST(N'1979-05-03 00:00:00.000' AS DateTime), N'Quang@gmail.com                                                                                     ', N'0987544874                                                                                          ', N'GSPK7               ', N'114                                                                                                 ', N'AD1                 ', N'PS4                 ')
INSERT [dbo].[Teacher] ([teacherID], [name], [birth], [mail], [phone], [userName], [facultyID], [academicID], [positionID]) VALUES (N'GV8                 ', N'Hồ Nam', CAST(N'1982-06-12 00:00:00.000' AS DateTime), N'Nam@gmail.com                                                                                       ', N'0587488744                                                                                          ', N'GSPK8               ', N'115                                                                                                 ', N'AD2                 ', N'PS5                 ')
INSERT [dbo].[Team] ([teamID], [studentID]) VALUES (N'TW1                 ', N'SV11                ')
INSERT [dbo].[Team] ([teamID], [studentID]) VALUES (N'TW2                 ', N'SV10                ')
INSERT [dbo].[Team] ([teamID], [studentID]) VALUES (N'TW3                 ', N'SV1                 ')
INSERT [dbo].[Team] ([teamID], [studentID]) VALUES (N'TW3                 ', N'SV2                 ')
INSERT [dbo].[Team] ([teamID], [studentID]) VALUES (N'TW4                 ', N'SV1                 ')
INSERT [dbo].[Team] ([teamID], [studentID]) VALUES (N'TW4                 ', N'SV2                 ')
INSERT [dbo].[Team] ([teamID], [studentID]) VALUES (N'TW5                 ', N'SV4                 ')
INSERT [dbo].[Team] ([teamID], [studentID]) VALUES (N'TW5                 ', N'SV5                 ')
INSERT [dbo].[Team] ([teamID], [studentID]) VALUES (N'TW6                 ', N'SV6                 ')
INSERT [dbo].[Team] ([teamID], [studentID]) VALUES (N'TW6                 ', N'SV8                 ')
INSERT [dbo].[Team] ([teamID], [studentID]) VALUES (N'TW7                 ', N'SV3                 ')
INSERT [dbo].[Team] ([teamID], [studentID]) VALUES (N'TW7                 ', N'SV9                 ')
INSERT [dbo].[Team] ([teamID], [studentID]) VALUES (N'TW8                 ', N'SV7                 ')
INSERT [dbo].[TeamWork] ([teamID], [link], [point], [topicID], [name]) VALUES (N'TW1                 ', N'html12    ', N'8         ', N'TP1                 ', N'HaNoi                                                                                               ')
INSERT [dbo].[TeamWork] ([teamID], [link], [point], [topicID], [name]) VALUES (N'TW2                 ', N'html13    ', N'9         ', N'TP2                 ', N'SaiGon                                                                                              ')
INSERT [dbo].[TeamWork] ([teamID], [link], [point], [topicID], [name]) VALUES (N'TW3                 ', N'edf       ', N'8         ', N'TP3                 ', N'Badboy                                                                                              ')
INSERT [dbo].[TeamWork] ([teamID], [link], [point], [topicID], [name]) VALUES (N'TW4                 ', N'htlm11    ', N'10        ', N'TP5                 ', N'TeamMoi                                                                                             ')
INSERT [dbo].[TeamWork] ([teamID], [link], [point], [topicID], [name]) VALUES (N'TW5                 ', N'html14    ', N'8         ', N'TP4                 ', N'BinhDuong                                                                                           ')
INSERT [dbo].[TeamWork] ([teamID], [link], [point], [topicID], [name]) VALUES (N'TW6                 ', N'html15    ', N'9         ', N'TP6                 ', N'HaiPhong                                                                                            ')
INSERT [dbo].[TeamWork] ([teamID], [link], [point], [topicID], [name]) VALUES (N'TW7                 ', N'html16    ', N'10        ', N'TP7                 ', N'BinhThuan                                                                                           ')
INSERT [dbo].[TeamWork] ([teamID], [link], [point], [topicID], [name]) VALUES (N'TW8                 ', N'html17    ', N'8         ', N'TP8                 ', N'VinhLong                                                                                            ')
INSERT [dbo].[Topic] ([TopicID], [name], [teacherID], [kotID], [facultyID], [dateForm], [dateTo]) VALUES (N'TP1                 ', N'An Toàn Thực Phẩm', N'GV6                 ', N'K2                  ', N'116                                                                                                 ', CAST(N'2020-07-16 00:00:00.000' AS DateTime), CAST(N'2020-11-18 00:00:00.000' AS DateTime))
INSERT [dbo].[Topic] ([TopicID], [name], [teacherID], [kotID], [facultyID], [dateForm], [dateTo]) VALUES (N'TP2                 ', N'An Toàn Xây Dựng', N'GV8                 ', N'K1                  ', N'115                                                                                                 ', CAST(N'2020-07-14 00:00:00.000' AS DateTime), CAST(N'2020-11-19 00:00:00.000' AS DateTime))
INSERT [dbo].[Topic] ([TopicID], [name], [teacherID], [kotID], [facultyID], [dateForm], [dateTo]) VALUES (N'TP3                 ', N'Máy Điện', N'GV2                 ', N'K3                  ', N'110                                                                                                 ', CAST(N'2020-02-11 00:00:00.000' AS DateTime), CAST(N'2020-06-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Topic] ([TopicID], [name], [teacherID], [kotID], [facultyID], [dateForm], [dateTo]) VALUES (N'TP4                 ', N'Động Cơ Đốt Trong', N'GV4                 ', N'K3                  ', N'112                                                                                                 ', CAST(N'2020-01-20 00:00:00.000' AS DateTime), CAST(N'2020-05-24 00:00:00.000' AS DateTime))
INSERT [dbo].[Topic] ([TopicID], [name], [teacherID], [kotID], [facultyID], [dateForm], [dateTo]) VALUES (N'TP5                 ', N'Khoa Học', N'GV1                 ', N'K1                  ', N'110                                                                                                 ', CAST(N'2020-07-15 13:15:08.000' AS DateTime), CAST(N'2020-11-17 13:15:08.000' AS DateTime))
INSERT [dbo].[Topic] ([TopicID], [name], [teacherID], [kotID], [facultyID], [dateForm], [dateTo]) VALUES (N'TP6                 ', N'Điện Dân Dụng', N'GV3                 ', N'K2                  ', N'111                                                                                                 ', CAST(N'2020-07-01 00:00:00.000' AS DateTime), CAST(N'2020-11-28 00:00:00.000' AS DateTime))
INSERT [dbo].[Topic] ([TopicID], [name], [teacherID], [kotID], [facultyID], [dateForm], [dateTo]) VALUES (N'TP7                 ', N'Tự Động Hóa', N'GV5                 ', N'K3                  ', N'113                                                                                                 ', CAST(N'2020-07-02 00:00:00.000' AS DateTime), CAST(N'2020-11-26 00:00:00.000' AS DateTime))
INSERT [dbo].[Topic] ([TopicID], [name], [teacherID], [kotID], [facultyID], [dateForm], [dateTo]) VALUES (N'TP8                 ', N'Kỹ Thuật In', N'GV7                 ', N'K1                  ', N'114                                                                                                 ', CAST(N'2020-07-11 00:00:00.000' AS DateTime), CAST(N'2020-11-28 00:00:00.000' AS DateTime))
ALTER TABLE [dbo].[ProcessTopic]  WITH CHECK ADD  CONSTRAINT [FK_ProcessTopic_Process] FOREIGN KEY([processID])
REFERENCES [dbo].[Process] ([processID])
GO
ALTER TABLE [dbo].[ProcessTopic] CHECK CONSTRAINT [FK_ProcessTopic_Process]
GO
ALTER TABLE [dbo].[ProcessTopic]  WITH CHECK ADD  CONSTRAINT [FK_ProcessTopic_Topic] FOREIGN KEY([topicID])
REFERENCES [dbo].[Topic] ([TopicID])
GO
ALTER TABLE [dbo].[ProcessTopic] CHECK CONSTRAINT [FK_ProcessTopic_Topic]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Acount] FOREIGN KEY([userName])
REFERENCES [dbo].[Acount] ([userName])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Acount]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Faculty] FOREIGN KEY([facultyID])
REFERENCES [dbo].[Faculty] ([FacultyID])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Faculty]
GO
ALTER TABLE [dbo].[Teacher]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_Academic] FOREIGN KEY([academicID])
REFERENCES [dbo].[Academic] ([academicLevelID])
GO
ALTER TABLE [dbo].[Teacher] CHECK CONSTRAINT [FK_Teacher_Academic]
GO
ALTER TABLE [dbo].[Teacher]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_Acount] FOREIGN KEY([userName])
REFERENCES [dbo].[Acount] ([userName])
GO
ALTER TABLE [dbo].[Teacher] CHECK CONSTRAINT [FK_Teacher_Acount]
GO
ALTER TABLE [dbo].[Teacher]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_Faculty] FOREIGN KEY([facultyID])
REFERENCES [dbo].[Faculty] ([FacultyID])
GO
ALTER TABLE [dbo].[Teacher] CHECK CONSTRAINT [FK_Teacher_Faculty]
GO
ALTER TABLE [dbo].[Teacher]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_Position] FOREIGN KEY([positionID])
REFERENCES [dbo].[Position] ([PositionID])
GO
ALTER TABLE [dbo].[Teacher] CHECK CONSTRAINT [FK_Teacher_Position]
GO
ALTER TABLE [dbo].[Team]  WITH CHECK ADD  CONSTRAINT [FK_Team_Student] FOREIGN KEY([studentID])
REFERENCES [dbo].[Student] ([studentID])
GO
ALTER TABLE [dbo].[Team] CHECK CONSTRAINT [FK_Team_Student]
GO
ALTER TABLE [dbo].[Team]  WITH CHECK ADD  CONSTRAINT [FK_Team_TeamWork] FOREIGN KEY([teamID])
REFERENCES [dbo].[TeamWork] ([teamID])
GO
ALTER TABLE [dbo].[Team] CHECK CONSTRAINT [FK_Team_TeamWork]
GO
ALTER TABLE [dbo].[TeamWork]  WITH CHECK ADD  CONSTRAINT [FK_TeamWork_Topic] FOREIGN KEY([topicID])
REFERENCES [dbo].[Topic] ([TopicID])
GO
ALTER TABLE [dbo].[TeamWork] CHECK CONSTRAINT [FK_TeamWork_Topic]
GO
ALTER TABLE [dbo].[Topic]  WITH CHECK ADD  CONSTRAINT [FK_Topic_Faculty] FOREIGN KEY([facultyID])
REFERENCES [dbo].[Faculty] ([FacultyID])
GO
ALTER TABLE [dbo].[Topic] CHECK CONSTRAINT [FK_Topic_Faculty]
GO
ALTER TABLE [dbo].[Topic]  WITH CHECK ADD  CONSTRAINT [FK_Topic_KindOfTopic] FOREIGN KEY([kotID])
REFERENCES [dbo].[KindOfTopic] ([KotID])
GO
ALTER TABLE [dbo].[Topic] CHECK CONSTRAINT [FK_Topic_KindOfTopic]
GO
ALTER TABLE [dbo].[Topic]  WITH CHECK ADD  CONSTRAINT [FK_Topic_Teacher] FOREIGN KEY([teacherID])
REFERENCES [dbo].[Teacher] ([teacherID])
GO
ALTER TABLE [dbo].[Topic] CHECK CONSTRAINT [FK_Topic_Teacher]
GO
