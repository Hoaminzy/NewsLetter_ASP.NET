create database NEWSLETTER
use NEWSLETTER
CREATE TABLE LETTERS (
iPK_LetterID int identity primary key,
sSubject nvarchar(max),
sBody nvarchar (max),
dNgayTao datetime,
iPK_AdminID int foreign key references ADMIN (iPK_AdminID),
iPK_ChuDeID int foreign key references CHUDE (iPK_MaCD)
)
go
 create table TAIKHOAN (
 iPK_TaiKhoanID int identity primary key, 
sEmail nvarchar(50),
sPassword nvarchar(50),
 sName nvarchar(50)
)

create table ADMIN(
 iPK_AdminID int identity primary key,
sEmail nvarchar(50) unique,
sPassword nvarchar(50),
sName nvarchar(50),
iPKQuyenID int foreign key references QUYEN ( iPK_QuyenID )
)

create table QUYEN(
 iPK_QuyenID int identity primary key,
sQuyen nvarchar(50)
)

create table CHUDE(
iPK_MaCD int identity primary key,
sTenCD nvarchar(200)
)
create table TAIKHOAN_CHUDE(
 iFK_TaiKhoanID int foreign key references TAIKHOAN (iPK_TaiKhoanID),
 iFK_MaCD int  foreign key references CHUDE (iPK_MaCD)
)

/*Truy vấn Quyền*/
CREATE PROC ThongTin_Quyen
as
begin
	select * from QUYEN
end
Go

/*Truy vấn TaiKhoan*/

CREATE PROC ThongTin_TaiKhoan
AS
BEGIN
	select * from TAIKHOAN
END
GO

CREATE PROC ThongTin_TaiKhoan_by_Email_MatKhau
@sEmail nvarchar(50),
@sPassword nvarchar(50)
AS
BEGIN
	SELECT * FROM TAIKHOAN WHERE sEmail = @sEmail and sPassword= @sPassword
END
GO

CREATE PROC ThongTin_TaiKhoan_by_Email
@sEmail nvarchar(50)
AS
BEGIN
	SELECT * FROM TAIKHOAN WHERE sEmail = @sEmail
END
GO

CREATE PROC ThongTin_TaiKhoan_by_ID
@iPK_TaiKhoanID int
AS
BEGIN 
	SELECT * FROM TAIKHOAN WHERE iPK_TaiKhoanID = @iPK_TaiKhoanID
END
GO


CREATE PROC TaiKhoan_Insert
@sEmail nvarchar(50),
@sPassword nvarchar(50),
@sName nvarchar(50)
AS
BEGIN
	insert into TAIKHOAN(sEmail, sPassword, sName) values (@sEmail, @sPassword, @sName)
END
GO
/*Update tai khoan*/
CREATE PROC TaiKhoan_Update
@iPK_TaiKhoanID int,
@sEmail nvarchar(50),
@sPassword nvarchar(50),
@sName nvarchar(50)
AS
BEGIN
	update TAIKHOAN set sEmail = @sEmail, sPassword = @sPassword, sName = @sName
			where iPK_TaiKhoanID = @iPK_TaiKhoanID
END
GO



CREATE PROC TaiKhoan_Delete
@iPK_TaiKhoanID int
AS
Begin
	delete TAIKHOAN where iPK_TaiKhoanID = @iPK_TaiKhoanID
End
Go

/*Truy van admin*/
CREATE PROC ThongTin_Admin
AS
BEGIN
	SELECT * FROM ADMIN
END
GO

CREATE PROC ThongTin_Admin_by_ID
@iPK_AdminID int
AS
BEGIN
	SELECT * FROM ADMIN WHERE iPK_AdminID = @iPK_AdminID
END
GO

CREATE PROC ThongTin_Admin_by_Email_MatKhau
@sEmail nvarchar(50),
@sPassword nvarchar(50)
AS
BEGIN
	SELECT * FROM ADMIN WHERE sEmail = @sEmail and  sPassword = @sPassword
END
GO

CREATE PROC Admin_Insert
@sEmail nvarchar(50),
@sPassword nvarchar(50),
@sName nvarchar(50),
@iPKQuyenID int
AS
BEGIN
	INSERT INTO ADMIN (sEmail, sPassword, sName, iPKQuyenID) values (@sEmail, @sPassword, @sName, @iPKQuyenID)
END
GO

CREATE PROC Admin_Update
@iPK_AdminID int,
@sEmail nvarchar(50),
@sPassword nvarchar(50),
@sName nvarchar(50),
@iPKQuyenID int
AS
BEGIN
	Update ADMIN SET sEmail = @sEmail, sPassword = @sPassword, sName = @sName, iPKQuyenID = @iPKQuyenID
		WHERE iPK_AdminID = @iPK_AdminID
END
GO

CREATE PROC Admin_Delete
@iPK_AdminID int
AS
BEGIN
	DELETE ADMIN WHERE iPK_AdminID = @iPK_AdminID
END
GO

/*TRUY VAN BANG CHUDE*/
CREATE PROC ThongTin_ChuDe
AS
BEGIN
	SELECT * FROM CHUDE
END
GO

CREATE PROC ThongTin_ChuDe_by_ID
@iPK_MaCD int
AS
BEGIN
	SELECT * FROM CHUDE WHERE iPK_MaCD = @iPK_MaCD
END
GO

CREATE PROC ChuDe_Insert
@sTenCD nvarchar(200)
AS
BEGIN
	INSERT INTO CHUDE (sTenCD) VALUES(@sTenCD)
END
GO

CREATE PROC ChuDe_Update
@iPK_MaCD int,
@sTenCD nvarchar(200)
AS
BEGIN
	UPDATE CHUDE SET sTenCD = @sTenCD WHERE iPK_MaCD = @iPK_MaCD
END
GO

CREATE PROC ChuDe_Delete
@iPK_MaCD int
AS
BEGIN
	DELETE CHUDE WHERE iPK_MaCD = @iPK_MaCD
END
GO

/*TRUY VAN BANG LETTER*/

CREATE PROC ThongTin_Letter
AS
BEGIN
	SELECT * FROM LETTERS
END
GO

CREATE PROC ThongTin_Letter_by_ID
@iPK_LetterID int
AS
BEGIN
	SELECT * FROM LETTERS WHERE iPK_LetterID = @iPK_LetterID
END
GO

CREATE PROC ThongTin_Letter_by_Admin
@iPK_AdminID int
AS
BEGIN
	SELECT * FROM LETTERS WHERE iPK_AdminID= @iPK_AdminID
END
GO

CREATE PROC ThongTin_Letter_by_ChuDe
@iPK_ChuDeID int
AS
BEGIN
	SELECT * FROM LETTERS WHERE iPK_ChuDeID = @iPK_ChuDeID
END
GO

CREATE PROC Letter_Insert
@sSubject nvarchar(max),
@sBody nvarchar(max),
@iPK_AdminID int,
@iPK_ChuDeID int,
@dNgayTao datetime
AS
BEGIN
	INSERT INTO LETTERS (sSubject,sBody, iPK_AdminID, iPK_ChuDeID, dNgayTao) VALUES (@sSubject, @sBody, @iPK_AdminID, @iPK_ChuDeID, @dNgayTao)
END
GO

CREATE PROC Letter_Update
@iPK_LetterID int,
@sSubject nvarchar(max),
@sBody nvarchar(max),
@iPK_AdminID int,
@iPK_ChuDeID int,
@dNgayTao datetime
AS
BEGIN
	UPDATE LETTERS SET sSubject = @sSubject, sBody = @sBody, iPK_AdminID = @iPK_AdminID, iPK_ChuDeID = @iPK_ChuDeID, dNgayTao = @dNgayTao
		WHERE iPK_LetterID = @iPK_LetterID
END



create PROC [dbo].[Letter_Delete]
@iPK_LetterID int
AS
Begin
	delete LETTERS  where iPK_LetterID = @iPK_LetterID
End


/*TRUY VAN BANG TAIKHOAN_CHUDE*/
CREATE PROC ThongTin_TK_CD
AS
BEGIN
	SELECT * FROM TAIKHOAN_CHUDE
END
GO

CREATE PROC ThongTin_TKCD_by_TK
@iFK_TaiKhoanID  int
AS
BEGIN
	SELECT * FROM TAIKHOAN_CHUDE WHERE iFK_TaiKhoanID  = @iFK_TaiKhoanID 
END
GO

CREATE PROC ThongTin_TKCD_by_CD
@iFK_MaCD int
AS
BEGIN
	SELECT * FROM TAIKHOAN_CHUDE WHERE iFK_MaCD = @iFK_MaCD
END
GO

CREATE PROC TK_CD_INSERT
@iFK_TaiKhoanID  int,
@iFK_MaCD int
AS
BEGIN
	INSERT INTO TAIKHOAN_CHUDE(iFK_TaiKhoanID, iFK_MaCD) VALUES (@iFK_TaiKhoanID, @iFK_MaCD)
END
GO

CREATE PROC TK_CD_UPDATE
@iFK_TaiKhoanID int,
@iFK_MaCD int
AS
BEGIN
	UPDATE TAIKHOAN_CHUDE SET iFK_TaiKhoanID = @iFK_TaiKhoanID, iFK_MaCD = @iFK_MaCD WHERE iFK_TaiKhoanID = @iFK_TaiKhoanID AND iFK_MaCD = @iFK_MaCD
END
GO

CREATE PROC TK_CD_DELETE
@iFK_TaiKhoanID  int,
@iFK_MaCD int
AS
BEGIN
	DELETE TAIKHOAN_CHUDE  WHERE iFK_TaiKhoanID= @iFK_TaiKhoanID AND iFK_MaCD = @iFK_MaCD
END
GO

CREATE PROC TK_CD_SELCT_MA
@iFK_TaiKhoanID  int
AS
BEGIN
	Select iFK_TaiKhoanID, sTenCD FROM TAIKHOAN_CHUDE inner join CHUDE	
	ON TAIKHOAN_CHUDE.iFK_MaCD = CHUDE.iPK_MaCD
END
GO
alter PROC TK_CD_ID
@iFK_TaiKhoanID  int
AS
BEGIN
	Select iFK_MaCD, sTenCD FROM TAIKHOAN_CHUDE inner join CHUDE	
	ON TAIKHOAN_CHUDE.iFK_MaCD = CHUDE.iPK_MaCD where @iFK_TaiKhoanID=iFK_TaiKhoanID
END
GO
select * from chude
create PROC Tim_Email1
@iPK_LettersID int
AS
BEGIN
SELECT iPK_TaiKhoanID, sEmail, iPK_ChuDeID 
FROM TAIKHOAN  as TK inner join TAIKHOAN_CHUDE as TK_CD
ON TK.iPK_TaiKhoanID= TK_CD.iFK_TaiKhoanID inner join LETTERS as LT ON TK_CD.iFK_MaCD= LT.iPK_ChuDeID
where iPK_LetterID = @iPK_LettersID
END


CREATE PROC TAIKHOAN_BY_CHUDE
@iFK_MaCD int
AS
BEGIN 
SELECT  iPK_TaiKhoanID, sEmail, sName, iFK_MaCD FROM TAIKHOAN_CHUDE AS TK_CD INNER JOIN TAIKHOAN AS TK
ON TK_CD.iFK_TaiKhoanID = TK.iPK_TaiKhoanID
WHERE TK_CD.iFK_MaCD = @iFK_MaCD
END
GO

 select TAIKHOAN.sEMail, CHUDE.sTenCD from TAIKHOAN_CHUDE, TAIKHOAN, CHUDE where TAIKHOAN_CHUDE.iFK_TaiKhoanID=TAIKHOAN.iPK_TaiKhoanID and TAIKHOAN_CHUDE.iFK_MaCD=CHUDE.iPK_MaCD


 select 

 TRUNCATE TABLE TaiKhoan_ChuDe


 select * from TaiKhoan
 select * from CHUDE
select * from TaiKhoan_ChuDe
select * from Admin





