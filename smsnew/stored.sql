USE [sms]

CREATE proc [dbo].[DanhSachThi]
	@idlop int
as
begin
	with tmp as(
		select sv.ID
		from SinhVien sv
		join DiemDanh b on (sv.ID=b.SinhVienID)
		where b.LopHocPhanID=@idlop
		group by sv.id
		having sum(b.TinhTrang)<4
	) 
	select sv.HoTen as N'Họ và tên', sv.id N'Mã sinh viên',l.IDView N'Lớp', sv.NgaySinh N'Ngày sinh',
	Case 
		when GioiTinh=1 Then N'Nam'
		when GioiTinh=0 Then N'Nữ'
	end as N'Giới tính' , Diem1 N'Điểm CC', Diem2 N'Điểm TX', Case 
		when Diem3=0 Then null
		when Diem3!=0 Then Diem3
	end N'Thi', NULL as N'Tổng'
	from SinhVien sv
	join Lop l on sv.LopID = l.ID
	join SV_LHP a on (sv.ID=a.SinhVienID)
	left join tmp on (tmp.ID=sv.ID)
	 where a.LopHocPhanID=@idlop and Diem1>=4 and Diem2>=4  

end


CREATE proc [dbo].[ListSVLHP] 
	@idLop int
as
begin
with tmp as(
		select sv.ID, sum(b.TinhTrang) nghi
		from SinhVien sv
		join DiemDanh b on (sv.ID=b.SinhVienID)
		where b.LopHocPhanID=@idLop
		group by sv.id
	)
	select sv.HoTen as N'Họ và tên', sv.id N'Mã sinh viên',l.IDView N'Lớp', sv.NgaySinh N'Ngày sinh',
	Case 
		when GioiTinh=1 Then N'Nam'
		when GioiTinh=0 Then N'Nữ'
	end as N'Giới tính' , Diem1 N'Điểm CC', Diem2 N'Điểm TX', Diem3 N'Thi',(dd.nghi) N'Số buổi nghỉ'
	from SinhVien sv
	join Lop l on sv.LopID = l.ID
	join SV_LHP a on (sv.ID=a.SinhVienID)
	left join tmp dd on (dd.ID=sv.ID)
	
	 where a.LopHocPhanID=@idlop 
end


