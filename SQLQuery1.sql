IF EXISTS (SELECT 1 FROM sys.databases WHERE name = 'QuanLyDiem')
	DROP DATABASE QuanLyDiem
GO

CREATE DATABASE QuanLyDiem;
GO
use QuanLyDiem
GO
CREATE TABLE HocSinh(
	ma CHAR(10) PRIMARY KEY,
	ten NVARCHAR(255),
	ngay_sinh DATE,
	ma_lop_on_dinh CHAR(10),
	so_dien_thoai VARCHAR(20),
	email VARCHAR(255),
	url_anh VARCHAR(255),
	ngay_nhap_hoc DATE
)

CREATE TABLE GiaoVien(
	ma CHAR(10) PRIMARY KEY,
	ten NVARCHAR(255),
	ngay_sinh DATE,
	url_anh VARCHAR(255),
	so_dien_thoai VARCHAR(20),
	email VARCHAR(255),
	ngay_vao_truong DATE
)
CREATE TABLE TaiKhoan(
	tai_khoan CHAR(10) PRIMARY KEY,
	mat_khau VARCHAR(255),
	ten_hien_thi NVARCHAR(255),
	url_anh VARCHAR(255),
	la_admin BIT -- 1:admin
)

CREATE TABLE LopOnDinh(
	ma CHAR(10) PRIMARY KEY,
	ten NVARCHAR(255),
	ma_khoa CHAR(10),
	ma_gv_chu_nhiem CHAR(10)
)

CREATE TABLE MonHoc(
	ma CHAR(10) PRIMARY KEY,
	ten NVARCHAR(255)
)

CREATE TABLE KyHoc(
	ma CHAR(10) PRIMARY KEY,
	ky_hoc NVARCHAR(10),
	bat_dau DATE,
	ket_thuc DATE
)

CREATE TABLE LopHoc(
	ma CHAR(10) PRIMARY KEY,
	ma_mon_hoc CHAR(10),
	ma_ky_hoc CHAR(10),
	ma_giao_vien CHAR(10),
	ma_lop_on_dinh CHAR(10)
)

CREATE TABLE LopHocHocSinh(
	ma_lop CHAR(10),
	ma_hoc_sinh CHAR(10),
	diemTrenLop FLOAT, -- điểm trên lớp
	diemThi FLOAT, -- điểm thi
	-- điểm tổng kết khi hiển thị sẽ tính theo 2 điểm trên
	PRIMARY KEY(ma_lop, ma_hoc_sinh)
)

--CREATE TABLE Diem(
--	ma_lop CHAR(10),
--	ma_sinh_vien CHAR(10),
--	diem FLOAT,
--	he_so INT,
--  loai_diem INT	-- ly thuyet:0 , thuc hanh: 1
--)


CREATE TABLE BaiViet(
	ma INT IDENTITY PRIMARY KEY,
	noi_dung NVARCHAR(MAX),
	tieu_de NVARCHAR(255),
	do_uu_tien INT, -- độ ưu tiên hiển thị
	tai_khoan CHAR(10),
	hinh_anh VARCHAR(255),
	ma_danh_muc CHAR(10)
	--thoi_gian DATETIME : pro
)
GO

CREATE TABLE DanhMuc(
	ma CHAR(10) PRIMARY KEY,
	ten NVARCHAR(255)
)

--CREATE TABLE BinhLuan(
--	ma CHAR(10) PRIMARY KEY,
--	ma_bai_viet CHAR(10),
--	noi_dung VARCHAR(255),
--	tai_khoan CHAR(10)
--	--,thoi_gian DATETIME : pro
--)

ALTER TABLE LopOnDinh
ADD FOREIGN KEY(ma_gv_chu_nhiem) REFERENCES GiaoVien(ma)


ALTER TABLE LopHoc
ADD FOREIGN KEY(ma_mon_hoc) REFERENCES MonHoc(ma)
ALTER TABLE LopHoc
ADD FOREIGN KEY(ma_ky_hoc) REFERENCES KyHoc(ma)
ALTER TABLE LopHoc
ADD FOREIGN KEY(ma_giao_vien) REFERENCES GiaoVien(ma)
ALTER TABLE LopHoc
ADD FOREIGN KEY(ma_lop_on_dinh) REFERENCES LopOnDinh(ma)



ALTER TABLE TaiKhoan
ADD FOREIGN KEY(tai_khoan) REFERENCES GiaoVien(ma)

ALTER TABLE LopHocHocSinh
ADD FOREIGN KEY(ma_lop) REFERENCES LopHoc(ma)
ALTER TABLE LopHocHocSinh
ADD FOREIGN KEY(ma_hoc_sinh) REFERENCES HocSinh(ma)

ALTER TABLE BaiViet
ADD FOREIGN KEY(tai_khoan) REFERENCES TaiKhoan(tai_khoan)

ALTER TABLE BaiViet
ADD FOREIGN KEY(ma_danh_muc) REFERENCES DanhMuc(ma)

ALTER TABLE HocSinh
ADD FOREIGN KEY(ma_lop_on_dinh) REFERENCES LopOnDinh(ma)
--ALTER TABLE BinhLuan
--ADD FOREIGN KEY(ma_bai_viet) REFERENCES BaiViet(ma)
--ALTER TABLE BinhLuan
--ADD FOREIGN KEY(tai_khoan) REFERENCES TaiKhoan(tai_khoan)

