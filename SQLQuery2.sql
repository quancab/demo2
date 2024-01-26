CREATE TABLE HocSinh (
Ten varchar(100),
Diachi varchar(255),
Cmnd varchar(100),
ngaysinh DATE
);
INSERT INTO HocSinh (Ten, Diachi, Cmnd,ngaysinh)
VALUES ('nva', 'hcm', '1','2003-2-2');
INSERT INTO HocSinh (Ten, Diachi, Cmnd)
VALUES ('nva2', 'hcm', '2');
INSERT INTO HocSinh (Ten, Diachi, Cmnd)
VALUES ('nva3', 'hcm', '3');
INSERT INTO HocSinh (Ten, Diachi, Cmnd)
VALUES ('nva4', 'hcm', '4');
INSERT INTO HocSinh (Ten, Diachi, Cmnd)
VALUES ('nva5', 'hcm', '5');

select * from HocSinh
drop table HocSinh;

