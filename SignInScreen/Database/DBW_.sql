CREATE DATABASE DBW
GO
USE DBW
GO

CREATE TABLE THISINH
(
	SBD VARCHAR(10) NOT NULL PRIMARY KEY,
	HOTEN NVARCHAR(50) NOT NULL,
	NGAYSINH DATETIME NOT NULL, 
	USERNAME VARCHAR(10) NOT NULL,
	_PASSWORD VARCHAR(20) NOT NULL,
)
INSERT THISINH (SBD, HOTEN, NGAYSINH, USERNAME, _PASSWORD) 
VALUES 
(4501104127, N'Trần Thị Tứ Linh', 2000-11-28, 'linhttt', '127'), 
(4501104218, N'Võ Thị Phương Thắm', 2001-06-14, 'thamvtp', '218'),
(4501104276, N'Trịnh Thị Phương Vi', 2001-01-01, 'vittp', '276'),
(4501104064, N'Phan Thị Thu Hà', 2001-08-21, 'haptt', '064'),
(4501104009, N'Nguyễn Thị Vân Anh', 2001-01-29, 'anhntv', '009'),
(4501104163, N'Phạm Nguyễn Hồng Nguyên', 2001-05-25, 'nguyenpnh', '163'),
(4501104249, N'Sầm Thị Hoàng Trang', 2001-10-18, 'trangsth', '249')

--DROP TABLE DETHI
CREATE TABLE DETHI
(
	MADE VARCHAR(10) NOT NULL PRIMARY KEY,
	MACAU INT NOT NULL,
	MAKYTHI VARCHAR(10) NOT NULL,
	NGAYTHI DATETIME NOT NULL,
	THOILUONG DATETIME NOT NULL,
	NOIDUNGBT NVARCHAR(MAX) NOT NULL,
	TEPDT NVARCHAR(MAX) NOT NULL,
	--_PASSWORD NVARCHAR(50) NOT NULL,
	GIOITHIEU NVARCHAR(100),
)
 --

INSERT DETHI (MADE, MACAU, MAKYTHI, NGAYTHI, THOILUONG, NOIDUNGBT, TEPDT, GIOITHIEU) 
VALUES 
('MD01', 001, 'KT01', 2021-11-21, '01:30:00', N'Nội dung đề 01', N'F:\Study\3rdyrs_1st\C#Windows\MSW\Database\DeThi\01.docx', N'Giới thiệu MD01'),
('MD01', 002, 'KT01', 2021-11-21, '01:30:00', N'Nội dung đề 01', N'F:\Study\3rdyrs_1st\C#Windows\MSW\Database\DeThi\01.docx', N'Giới thiệu MD01'),
('MD01', 003, 'KT01', 2021-11-21, '01:30:00', N'Nội dung đề 01', N'F:\Study\3rdyrs_1st\C#Windows\MSW\Database\DeThi\01.docx', N'Giới thiệu MD01'),
 --('MD02', 002, 'KT02', 2021-11-22, '01:30:00', N'Nội dung đề 02', N'F:\Study\3rdyrs_1st\C#Windows\MSW\Database\DeThi\02.docx', N'Giới thiệu MD02'),
 --('MD03', 003, 'KT03', 2021-11-23, '01:30:00', N'Nội dung đề 03', N'F:\Study\3rdyrs_1st\C#Windows\MSW\Database\DeThi\03.docx', N'Giới thiệu MD03'),
 --('MD04', 004, 'KT04', 2021-11-24, '01:30:00', N'Nội dung đề 04', N'F:\Study\3rdyrs_1st\C#Windows\MSW\Database\DeThi\04.docx', N'Giới thiệu MD04'),
 --('MD05', 005, 'KT05', 2021-11-25, '01:30:00', N'Nội dung đề 05', N'F:\Study\3rdyrs_1st\C#Windows\MSW\Database\DeThi\05.docx', N'Giới thiệu MD05'),
 --('MD06', 006, 'KT01', 2021-11-26, '01:30:00', N'Nội dung đề 06', N'F:\Study\3rdyrs_1st\C#Windows\MSW\Database\DeThi\06.docx', N'Giới thiệu MD06'),
 --('MD07', 007, 'KT07', 2021-11-27, '01:30:00', N'Nội dung đề 07', N'F:\Study\3rdyrs_1st\C#Windows\MSW\Database\DeThi\07.docx', N'Giới thiệu MD07'),
 --('MD08', 008, 'KT08', 2021-11-28, '01:30:00', N'Nội dung đề 08', N'F:\Study\3rdyrs_1st\C#Windows\MSW\Database\DeThi\08.docx', N'Giới thiệu MD08'),
--('MD09', 009, 'KT09', 2021-11-29, '01:30:00', N'Nội dung đề 09', N'F:\Study\3rdyrs_1st\C#Windows\MSW\Database\DeThi\09.docx', N'Giới thiệu MD09'),
--('MD10', 010, 'KT01', 2021-11-30, '01:30:00', N'Nội dung đề 10', N'F:\Study\3rdyrs_1st\C#Windows\MSW\Database\DeThi\10.docx', N'Giới thiệu MD10')

CREATE TABLE BAIGIAI
(
	MABG VARCHAR(10) NOT NULL PRIMARY KEY,
	MADE VARCHAR(10) NOT NULL,
	TEPBG NVARCHAR(MAX) NOT NULL
)
INSERT BAIGIAI(MABG, MADE, TEPBG)
VALUE
('BG01', 'MD01', N'F:\Study\3rdyrs_1st\C#Windows\MSW\Database\BaiGiai\01.docx'),
('BG02', 'MD02', N'F:\Study\3rdyrs_1st\C#Windows\MSW\Database\BaiGiai\02.docx'),
('BG03', 'MD03', N'F:\Study\3rdyrs_1st\C#Windows\MSW\Database\BaiGiai\03.docx'),
('BG04', 'MD04', N'F:\Study\3rdyrs_1st\C#Windows\MSW\Database\BaiGiai\04.docx'),
('BG05', 'MD05', N'F:\Study\3rdyrs_1st\C#Windows\MSW\Database\BaiGiai\05.docx'),
('BG06', 'MD06', N'F:\Study\3rdyrs_1st\C#Windows\MSW\Database\BaiGiai\06.docx'),
('BG07', 'MD07', N'F:\Study\3rdyrs_1st\C#Windows\MSW\Database\BaiGiai\07.docx'),
('BG08', 'MD08', N'F:\Study\3rdyrs_1st\C#Windows\MSW\Database\BaiGiai\08.docx'),
('BG09', 'MD09', N'F:\Study\3rdyrs_1st\C#Windows\MSW\Database\BaiGiai\09.docx'),
('BG10', 'MD10', N'F:\Study\3rdyrs_1st\C#Windows\MSW\Database\BaiGiai\10.docx')


GO
SELECT COUNT(*) FROM DETHI
SELECT NOIDUNGBT FROM DETHI