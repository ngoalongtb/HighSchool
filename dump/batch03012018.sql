USE QuanLyDiem
GO

CREATE TRIGGER utg_add_student
ON HocSinh
FOR INSERT
AS
BEGIN
	declare @maLopOnDinh char(10) = (select ma_lop_on_dinh from inserted)
	declare @ma char(10) = (select ma from inserted)

	insert into LopHocHocSinh(ma_lop, ma_hoc_sinh)
	select ma, @ma
	from LopHoc
	 where ma_lop_on_dinh = @maLopOnDinh
END
GO