USE [GradingSystem]
GO
/****** Object:  Table [dbo].[Semester]    Script Date: 01/12/2013 00:19:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Semester](
	[Semester_code] [int] IDENTITY(1,1) NOT NULL,
	[Semester_name] [varchar](50) NULL,
 CONSTRAINT [PK_Semester] PRIMARY KEY CLUSTERED 
(
	[Semester_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Department]    Script Date: 01/12/2013 00:19:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Department](
	[Dept_no] [int] IDENTITY(1,1) NOT NULL,
	[Dept_name] [varchar](50) NULL,
	[location] [varchar](50) NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[Dept_no] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Course]    Script Date: 01/12/2013 00:19:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Course](
	[Course_code] [int] NOT NULL,
	[Course_name] [varchar](50) NULL,
	[Credit_hours] [int] NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[Course_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Professor]    Script Date: 01/12/2013 00:19:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Professor](
	[Professor_id] [int] IDENTITY(1,1) NOT NULL,
	[First_name] [varchar](50) NULL,
	[Last_name] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[DOB] [date] NULL,
	[Dept_no] [int] NULL,
	[Username] [varchar](20) NULL,
	[Password] [varchar](20) NULL,
 CONSTRAINT [PK_Professor] PRIMARY KEY CLUSTERED 
(
	[Professor_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Student]    Script Date: 01/12/2013 00:19:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Student](
	[Student_id] [int] IDENTITY(1,1) NOT NULL,
	[First_name] [varchar](50) NULL,
	[Last_name] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[DOB] [date] NULL,
	[Gender] [bit] NULL,
	[Dept_no] [int] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[Student_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Semester_Year]    Script Date: 01/12/2013 00:19:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Semester_Year](
	[Semester_id] [int] IDENTITY(1,1) NOT NULL,
	[Semester_code] [int] NULL,
	[Year] [varchar](4) NULL,
 CONSTRAINT [PK_Semester_Year] PRIMARY KEY CLUSTERED 
(
	[Semester_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Student_Phones]    Script Date: 01/12/2013 00:19:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Student_Phones](
	[Serial] [int] IDENTITY(1,1) NOT NULL,
	[Student_id] [int] NOT NULL,
	[Phone_no] [varchar](20) NULL,
 CONSTRAINT [PK_Student_Phones_1] PRIMARY KEY CLUSTERED 
(
	[Serial] ASC,
	[Student_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Professor_Phones]    Script Date: 01/12/2013 00:19:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Professor_Phones](
	[Serial] [int] IDENTITY(1,1) NOT NULL,
	[Professor_id] [int] NOT NULL,
	[Phone_no] [varchar](20) NULL,
 CONSTRAINT [PK_Professor_Phones] PRIMARY KEY CLUSTERED 
(
	[Serial] ASC,
	[Professor_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Class]    Script Date: 01/12/2013 00:19:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[Course_code] [int] NOT NULL,
	[Semester_id] [int] NOT NULL,
	[Max_enrollment] [int] NULL,
	[Enrollment] [int] NULL,
	[Class_time] [datetime] NULL,
	[Professor_id] [int] NULL,
 CONSTRAINT [PK_Class] PRIMARY KEY CLUSTERED 
(
	[Course_code] ASC,
	[Semester_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Enrollment]    Script Date: 01/12/2013 00:19:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enrollment](
	[Course_code] [int] NOT NULL,
	[Semester_id] [int] NOT NULL,
	[Student_id] [int] NOT NULL,
	[Year_work] [decimal](5, 2) NULL,
	[Project_marks] [decimal](5, 2) NULL,
	[Final_exam] [decimal](5, 2) NULL,
	[Total_marks] [decimal](5, 0) NULL,
 CONSTRAINT [PK_Enrollment] PRIMARY KEY CLUSTERED 
(
	[Course_code] ASC,
	[Semester_id] ASC,
	[Student_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Class_Course]    Script Date: 01/12/2013 00:19:39 ******/
ALTER TABLE [dbo].[Class]  WITH CHECK ADD  CONSTRAINT [FK_Class_Course] FOREIGN KEY([Course_code])
REFERENCES [dbo].[Course] ([Course_code])
GO
ALTER TABLE [dbo].[Class] CHECK CONSTRAINT [FK_Class_Course]
GO
/****** Object:  ForeignKey [FK_Class_Professor]    Script Date: 01/12/2013 00:19:39 ******/
ALTER TABLE [dbo].[Class]  WITH CHECK ADD  CONSTRAINT [FK_Class_Professor] FOREIGN KEY([Professor_id])
REFERENCES [dbo].[Professor] ([Professor_id])
GO
ALTER TABLE [dbo].[Class] CHECK CONSTRAINT [FK_Class_Professor]
GO
/****** Object:  ForeignKey [FK_Class_Semester_Year]    Script Date: 01/12/2013 00:19:39 ******/
ALTER TABLE [dbo].[Class]  WITH CHECK ADD  CONSTRAINT [FK_Class_Semester_Year] FOREIGN KEY([Semester_id])
REFERENCES [dbo].[Semester_Year] ([Semester_id])
GO
ALTER TABLE [dbo].[Class] CHECK CONSTRAINT [FK_Class_Semester_Year]
GO
/****** Object:  ForeignKey [FK_Enrollment_Class]    Script Date: 01/12/2013 00:19:39 ******/
ALTER TABLE [dbo].[Enrollment]  WITH CHECK ADD  CONSTRAINT [FK_Enrollment_Class] FOREIGN KEY([Course_code], [Semester_id])
REFERENCES [dbo].[Class] ([Course_code], [Semester_id])
GO
ALTER TABLE [dbo].[Enrollment] CHECK CONSTRAINT [FK_Enrollment_Class]
GO
/****** Object:  ForeignKey [FK_Enrollment_Student]    Script Date: 01/12/2013 00:19:39 ******/
ALTER TABLE [dbo].[Enrollment]  WITH CHECK ADD  CONSTRAINT [FK_Enrollment_Student] FOREIGN KEY([Student_id])
REFERENCES [dbo].[Student] ([Student_id])
GO
ALTER TABLE [dbo].[Enrollment] CHECK CONSTRAINT [FK_Enrollment_Student]
GO
/****** Object:  ForeignKey [FK_Professor_Department]    Script Date: 01/12/2013 00:19:39 ******/
ALTER TABLE [dbo].[Professor]  WITH CHECK ADD  CONSTRAINT [FK_Professor_Department] FOREIGN KEY([Dept_no])
REFERENCES [dbo].[Department] ([Dept_no])
GO
ALTER TABLE [dbo].[Professor] CHECK CONSTRAINT [FK_Professor_Department]
GO
/****** Object:  ForeignKey [FK_Professor_Phones_Professor]    Script Date: 01/12/2013 00:19:39 ******/
ALTER TABLE [dbo].[Professor_Phones]  WITH CHECK ADD  CONSTRAINT [FK_Professor_Phones_Professor] FOREIGN KEY([Professor_id])
REFERENCES [dbo].[Professor] ([Professor_id])
GO
ALTER TABLE [dbo].[Professor_Phones] CHECK CONSTRAINT [FK_Professor_Phones_Professor]
GO
/****** Object:  ForeignKey [FK_Semester_Year_Semester]    Script Date: 01/12/2013 00:19:39 ******/
ALTER TABLE [dbo].[Semester_Year]  WITH CHECK ADD  CONSTRAINT [FK_Semester_Year_Semester] FOREIGN KEY([Semester_code])
REFERENCES [dbo].[Semester] ([Semester_code])
GO
ALTER TABLE [dbo].[Semester_Year] CHECK CONSTRAINT [FK_Semester_Year_Semester]
GO
/****** Object:  ForeignKey [FK_Student_Department]    Script Date: 01/12/2013 00:19:39 ******/
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Department] FOREIGN KEY([Dept_no])
REFERENCES [dbo].[Department] ([Dept_no])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Department]
GO
/****** Object:  ForeignKey [FK_Student_Phones_Student]    Script Date: 01/12/2013 00:19:39 ******/
ALTER TABLE [dbo].[Student_Phones]  WITH CHECK ADD  CONSTRAINT [FK_Student_Phones_Student] FOREIGN KEY([Student_id])
REFERENCES [dbo].[Student] ([Student_id])
GO
ALTER TABLE [dbo].[Student_Phones] CHECK CONSTRAINT [FK_Student_Phones_Student]
GO
