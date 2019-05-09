select * from HocPhan
select * from LopHocPhan
go
alter proc Update_HocPhan(@macu varchar(10), @ten nvarchar(200), @tc int, @mahk varchar(10))
as
begin
	update HocPhan 
	set TenHocPhan= @ten, SoTC=@tc, IDHocKy=@mahk
	where IDHocPhan= @macu
end	
go
exec [dbo].[Update_HocPhan] 1,'hoc phan moi',10,2
go 
create proc Delete_HocPhan( @ma varchar(10))
as
begin
	--delete from LopHocPhan where IDHocPhan=@ma;
	delete from HocPhan where IDHocPhan=@ma;
end
go 
exec [dbo].[Delete_HocPhan] 1
go
create proc Tim_HocKy( @ma varchar(10))
as
begin
	select * from HocKy where IDHocKy=@ma
end
go
exec [dbo].[Tim_HocKy] 1
go
create proc Insert_LopHP( @malop varchar(10), @mahk varchar(10), @ten nvarchar(200))
as
begin
	insert into LopHocPhan values (@malop, @mahk,@ten)
end 
go 
exec [dbo].[Insert_LopHP] 1233,'abc',' lop hoc phan 1'
go
select * from LopHocPhan
go
create proc select_Ten_HocPhan(@ten nvarchar(200))
as
begin
	select * from HocPhan where TenHocPhan=@ten
end
go
exec [dbo].[select_Ten_HocPhan] 'TOAN CHUYEN DE 2'
go
-- hien thi ra tat ca lop hoc phan theo hoc ky duoc chon 
go

create proc Select_LopHP_Hk(@mahk varchar(10))
as
begin
	select * from LopHocPhan 
	where LopHocPhan.IDHocPhan in (
	select HocPhan.IDHocPhan from HocPhan where HocPhan.IDHocKy = @mahk)
	
end
go
exec [dbo].[Select_LopHP_Hk] 1
go
select * from HocKy,HocPhan,LopHocPhan where HocKy.IDHocKy=HocPhan.IDHocKy and HocPhan.IDHocPhan=LopHocPhan.IDHocPhan
go
create proc select_Lop
as
begin
	select * from Lop
end 
go 
exec [dbo].[select_Lop]
go
create proc insert_Lop (@malop varchar(10), @tenlop nvarchar(200), @maNienkhoa varchar(10))
as
begin
	insert into Lop values (@malop, @tenlop,@maNienkhoa)
end 
exec [dbo].[insert_Lop] 123,' hu hu', 1
go
alter proc delete_Lop( @Tenlop nvarchar(200))
as
begin
	delete from Lop where TenLop=@Tenlop
end	
go
exec [dbo].[delete_Lop] 1
go
create proc delete_LopHP( @ten nvarchar(200))
as
begin
	delete from LopHocPhan where TenLopHocPhan=@ten
end
go
exec [dbo].[delete_LopHP] 'werty'
select * from LopHocPhan 
go
create proc update_LopCN(