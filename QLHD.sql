create database QLHD
go
use QLHD
--drop database QLHD
create table Account(
	Id_staff varchar(5) unique,

	Account_name varchar(50) not null,
	Password varchar(50) not null,

	constraint PK_Id_Account_name primary key (Account_name)
)
create table Staff(
	Id_staff varchar(5) not null,
	Name_staff Nvarchar(50) not null,
	Phone int unique,
	Id_position varchar(5),

	constraint PK_Id_staff primary key (Id_staff)
)
create table Position(
	Id_position varchar(5),
	Name_position Nvarchar(50),

	constraint PK_Id_position primary key (Id_position)
)
create table Product(
	Id_product varchar(5) not null,
	Name_product Nvarchar(100) not null,
	Fare money not null,
	Id_Type_product varchar(5),
	Note Ntext,
	Img_product image,

	constraint PK_Id_product primary key (Id_product)
)
create table Type_product(
	Id_Type_product varchar(5) not null,
	Name_type_product Nvarchar(100) not null,
	Describe Ntext,
	Img_type_product image,

	constraint PK_Id_type_product primary key (Id_Type_product)
)
create table Discount(
	Id_discount int,
	Name_discount Nvarchar(50),

	constraint PK_Id_discount primary key (Id_discount)
)
create table Bill(
	Id_bill int identity(1,1) not null,
	Date_bill date not null,
	Id_staff varchar(5) not null,
	total money,

	constraint PK_Id_bill primary key (Id_bill)
)
create table Detail_bill(
	Id_detail_bill int identity(1,1) not null,
	Id_bill int not null,
	Id_product varchar(5),
	Quantity int not null,
	Id_discount int,
	Total money,

	constraint PK_Id_detail_bill primary key (Id_detail_bill)
)
create table Return_bill(
	Id_return_bill int  identity(1,1) not null,
	Id_bill int not null,
	Id_product varchar(5),
	Quantity int not null,
	Id_discount int,
	Total money,

	constraint PK_Id_return_bill primary key (Id_return_bill)
)
alter table Account add constraint FK_Id_staff foreign key (Id_staff) references Staff (Id_staff)
alter table Staff add constraint FK_Id_position foreign key (Id_position) references Position (Id_position)
alter table Product add constraint FK_Id_type_product foreign key (Id_Type_product) references Type_product (Id_Type_product)
alter table Bill add constraint FK_Id_staff_bill foreign key (Id_staff) references Staff (Id_staff)

alter table Detail_bill add constraint FK_Id_bill_Detail_bill foreign key (Id_bill) references Bill (Id_bill)
alter table Detail_bill add constraint FK_Id_product_Detail_bill foreign key (Id_product) references Product (Id_product)
alter table Detail_bill add constraint FK_Id_discount_Detail_bill foreign key (Id_discount) references Discount (Id_discount)

alter table Return_bill add constraint FK_Id_bill_Return_bill foreign key (Id_bill) references Bill (Id_bill)
alter table Return_bill add constraint FK_Id_product_Return_bill foreign key (Id_product) references Product (Id_product)
alter table Return_bill add constraint FK_Id_discount_Return_bill foreign key (Id_discount) references Discount (Id_discount)

--Thêm khóa ngoại khi chỉnh sửa và xóa ở bảng này thí nó sẽ xử lý các bảng mà lấy khóa chính thành khóa ngoại của nó
alter table Detail_bill add constraint FK_Id_bill_update_delete_1 foreign key (Id_bill) references Bill (Id_bill)
on update cascade on delete cascade

alter table Return_bill add constraint FK_Id_bill_update_delete_2 foreign key (Id_bill) references Bill (Id_bill)
on update cascade on delete cascade

--Function thống kê
create function [dbo].[Fun_ThongKe_Bill_TheoNgay](
@ngaybd date,
@ngaykt date)
returns table as return
select date_bill,sum(total) as total from Bill
where Date_bill>=@ngaybd and Date_bill<=@ngaykt
group by date_bill

select * from Fun_ThongKe_Bill_TheoNgay('2023-01-01','2023-06-01')


create function [dbo].[Fun_ThongKe_Bill_TheoThang](
@ngaybd date,
@ngaykt date)
returns table as return
select MONTH(date_bill) as month,sum(total) as total from Bill
where Date_bill>=@ngaybd and Date_bill<=@ngaykt
group by MONTH(date_bill)

create function [dbo].[Fun_ThongKe_Bill_TheoThang_Tong](
@ngaybd date,
@ngaykt date)
returns table as return
select  Format(sum(h.total),'#,##0') as total
from (select MONTH(date_bill) as month,sum(total) as total from Bill
where Date_bill>=@ngaybd and Date_bill<=@ngaykt
group by MONTH(date_bill)) h
--drop function [dbo].[Fun_ThongKe_Bill_TheoThang_Tong] 
select * from Fun_ThongKe_Bill_TheoThang_Tong('2023-01-01','2023-06-01')

select  Format(sum(Bill.total),'#,##0') as total
from (select MONTH(date_bill) as month,sum(total) as total from Bill
where Date_bill>='2023-01-01' and Date_bill<='2023-06-01'
group by MONTH(date_bill)) as Bill

--drop function [dbo].[Fun_ThongKe_Bill_TheoNgay]

--Function thống kê theo sản phẩm
create function [dbo].[Fun_ThongKe_Bill_TheoSP](
@ngaybd date,
@ngaykt date)
returns table as return
select Type_product.id_type_product,Type_product.name_type_product,sum(Detail_bill.total)as total from Bill, Detail_bill,Type_product,Product
where Bill.Id_bill=Detail_bill.Id_bill and
Detail_bill.Id_product=Product.Id_product and
Product.Id_Type_product=Type_product.Id_Type_product and
Bill.Date_bill>=@ngaybd and
Bill.Date_bill<=@ngaykt
group by Type_product.Id_Type_product,Type_product.Name_type_product

select * from Fun_ThongKe_Bill_TheoSP('2023-04-29','2023-05-02')


--Position
insert into Position values('macv1',N'Quản lý')
insert into Position values('macv2',N'Nhân viên')

--Staff
insert into Staff values('ma001',N'Huỳnh Hồng Huân','0123456789','macv1')
insert into Staff values('ma002',N'Bành Thị Dân Tường','0987654321','macv2')

--update Staff set Name_staff=N'Bành Thị Dân Tường' where Id_staff='ma002'
--Account
insert into Account values('ma001','quanly','1')
insert into Account values('ma002','nhanvien','1')

--Type product 
insert into Type_product values('TS',N'Trà sữa',N'Trà sữa là sự kết hợp trà, sữa và topping lại với nhau. Tạo thành hương vị tuyệt vời!',null)
insert into Type_product values('NC',N'Trà nguyên chất',N'Trà là thức uống phổ biến thứ 2 trên thế giới, chỉ sau nước. Tất cả các loại trà trên thế giới đều được làm từ một loại cây, gọi là cây trà (Cemellia Senensis), mọc trên các cao nguyên vùng nhiệt đới. Mặc dù là loài thân gỗ nhưng khi canh tác người ta thường trồng trà thành luống và liên tục đốn cắt để cây chỉ thấp ngang bụng, dễ thu hoạch búp và cho năng suất cao.',null)
insert into Type_product values('TC',N'Trà trái cây',N'Trà trái cây (trà hoa quả) để chỉ một loại đồ uống giải khát đặc biệt phù hợp vào những ngày hè oi bức. Nó được làm từ lá trà khô kết hợp với các loại trái cây nhiệt đới như đào, xoài, dứa,vải và các loại quả khác thành thứ nước uống thanh khiết, mát rất tốt cho sức khỏe.',null)
insert into Type_product values('DX',N'Đá xây',N'Đá xay là dòng thức uống kết hợp sữa tươi, đá viên với nhiều nguyên liệu khác . Đặc điểm “nhận dạng” dòng công thức này chính là phần kem tươi má hồng bên trên.',null)
insert into Type_product values('TP',N'Topping',N'Với trà sữa, topping được gọi chung là các loại thạch, trân châu, pudding, phô mai … ăn kèm trong ly trà sữa. Topping không chỉ là thạch đi kèm theo công thức này mà còn là “linh hồn” góp phần tăng thêm hương vị thơm ngon hoàn hảo, đúng điệu của ly trà sữa.',null)

--Product
--Trà sữa
insert into Product values('TS001',N'Trà sữa truyền thống',20000,'TS',
N'Trà sữa truyền thống là sự kết hợp giữa 3 nguyên liệu cơ bản gồm trà, sữa và các loại topping. Nói về trà sữa thì cũng có rất nhiều hương vị với các cách pha chế khác nhau. Chúng ta có thể nhắc đến những hương vị như: trà sữa trân châu đường đen, trà sữa matcha.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\TRA_SUA(TS001)\Truyen_thong.jpg', SINGLE_BLOB) AS X))

insert into Product values('TS002',N'Trà sữa socola',22000,'TS',
N'Trà sữa Socola đúng chuẩn là món dễ gây nghiện và dễ uống cực kỳ. Hội fan yêu thích vị nhẫn và mùi thơm đắng đặc trưng của chất caffein thì không thể nào bỏ qua món này. Sự lôi cuốn mà người dùng tìm đến nó nằm hết trong độ béo nhẹ và vị của socola. Đương nhiên, với mức độ yêu thích này thì bạn vô tư cho vào menu mà không sợ ế.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\TRA_SUA(TS001)\Socola.jpg', SINGLE_BLOB) AS X))

insert into Product values('TS003',N'Trà sữa matcha',22000,'TS',
N'Với team sợ ngọt nhưng thích uống trà sữa thì Matcha là một lựa chọn tối ưu. Hương Matcha “Fresh” cực kỳ, cực hợp với những bạn nghiện béo sợ ngọt. Dù hiện tại có nổi lên các món kết hợp với trà xanh nhưng không thể phủ nhận rằng “nhiệt” của món này vẫn không giảm cho đến hiện nay. Đặc biệt, khi kết hợp với đậu đỏ cực “bùi miệng”.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\TRA_SUA(TS001)\Matcha.jpg', SINGLE_BLOB) AS X))

insert into Product values('TS004',N'Trà sữa kem cheese',25000,'TS',
N'Vị béo mặn của kem cheese không còn quá xa lạ đối với dân mộ điệu trà sữa. Độ mặn vừa phải trung hòa vị béo của kem cheese, điều này giúp cho món thức uống trở nên đặc sắc và thu hút người dùng.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\TRA_SUA(TS001)\Kem_cheese.jpg', SINGLE_BLOB) AS X))

insert into Product values('TS005',N'Trà sữa hoa đậu biết',25000,'TS',
N'Một màu xanh xanh, chấm theo trắng trắng, trộn màu cùng nhau tạo nên lớp màu tự nhiên. Một chất tạo màu vừa tốt cho sức khỏe vừa thay đổi màu thuần sắc của trà sữa bằng cách hay ho.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\TRA_SUA(TS001)\Hoa_dau_biet.jpg', SINGLE_BLOB) AS X))

insert into Product values('TS006',N'Trà sữa sương sáo',20000,'TS',
N'Thực chất của trà sữa sương sáo là thêm topping sương sáo. Sương sáo không ảnh hưởng đến vị, mà làm ta thấy ngon miệng hơn. Món topping ngọt thanh, mềm mịn, bỏ vào miệng mát lạnh như nước, cảm giác tan như không tan cuốn không thể tả.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\TRA_SUA(TS001)\Suong_sao.jpg', SINGLE_BLOB) AS X))

insert into Product values('TS007',N'Trà sữa trân châu trắng',22000,'TS',
N'Trân châu trắng là loại topping ra đời sau nhưng nó nhanh chóng trở nên phổ biến tương tự trân châu đen vậy. Được làm từ bột rau câu dẻo, bột rau câu giòn và các phụ gia đặc biệt nên trân châu có mùi thơm, ngọt dịu, giòn giòn chứ không dẻo.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\TRA_SUA(TS001)\Tran_chau_trang.jpg', SINGLE_BLOB) AS X))

insert into Product values('TS008',N'Trà sữa trân châu đen',22000,'TS',
N'Trà sữa trân châu đen được xem như là biểu tượng của trà sữa đời đầu. Với những hạt trân châu đen mềm và dẻo kết hợp với hương vị trà và sữa đã tạo nên thức uống được nhiều người ưa thích.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\TRA_SUA(TS001)\Tran_chau_den.jpg', SINGLE_BLOB) AS X))

insert into Product values('TS009',N'Trà sữa matcha đậu đỏ',25000,'TS',
N'Trà sữa matcha đậu đỏ có vị chát dịu của bột trà xanh, hòa quyện cùng vị ngọt của đậu đỏ, tạo nên hương vị rất ấn tượng. Đậu đỏ không chỉ có hương vị bùi thơm hấp dẫn mà còn mang lại nhiều lợi ích cho sức khỏe: Cung cấp protein cho cơ thể Giàu carbohydrate nhưng là carb tốt, không gây béo.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\TRA_SUA(TS001)\Matcha_dau_do.jpg', SINGLE_BLOB) AS X))

insert into Product values('TS010',N'Trà sữa thái xanh - đỏ',20000,'TS',
N'Cũng là một trong những loại trà sữa được yêu thích không hề kém trà sữa thạch phô mai, trà sữa Thái từng trở thành cơn bão cực hot trong một thời gian dài tại Sài Gòn. Trà sữa Thái có 2 loại phổ biến: Trà sữa Thái xanh, trà sữa Thái đỏ với hương vị đậm đà, vừa thơm vừa béo sẽ làm bạn nghiện ngay từ lần đầu tiên thưởng thức nó.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\TRA_SUA(TS001)\Thai.jpg', SINGLE_BLOB) AS X))

insert into Product values('TS011',N'Trà sữa thạch củ năng',25000,'TS',
N'Khi nhắc đến tên các loại trà sữa ngon thì chắc chắn bạn không thể bỏ qua loại trà sữa thạch củ năng. Hẳn là ít ai nghĩ rằng trà sữa khi kết hợp với thạch củ năng lại có thể ngon đến vậy, không chỉ ngọt mát tuyệt vời của vị trà sữa mà vị dai, dẻo của thạch củ năng cũng thu hút không kém. ',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\TRA_SUA(TS001)\Thach_cu_nang.jpg', SINGLE_BLOB) AS X))

insert into Product values('TS012',N'Trà sữa thạch phô mai',25000,'TS',
N'Trà sữa thạch phô mai với hương vị thơm ngon, mát lạnh ăn kèm với những miếng thạch beo béo là một trong những loại thức uống ngon, yêu thích của nhiều người.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\TRA_SUA(TS001)\Thach_pho_mai.jpg', SINGLE_BLOB) AS X))

insert into Product values('TS013',N'Sữa tươi trân châu đường đen',22000,'TS',
N'Không nằm trong dòng trà sữa nhưng lại xây dựng được đế chế cho riêng mình thì chỉ có thể là sữa tươi trân châu đường đen. Một thời hoàng kim của thức uống này vô cùng mạnh mẽ, vị béo đậm của sữa tươi kết hợp với độ dai mềm của trân châu đen thì quấn miệng còn gì bằng.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\TRA_SUA(TS001)\Tran_chau_duong_den.jpg', SINGLE_BLOB) AS X))

insert into Product values('TS014',N'Hồng trà sữa',20000,'TS',
N'Hồng trà sữa có vị đậm đà, vị trà thanh ngọt, một trong số những loại đang được ưa chuộng là hồng trà sữa trân châu và hồng trà sữa phô mai. Ngoài ra, cũng có thêm hương mint, socola, matcha, khoai môn... hoặc các hương trái cây như dâu, nho, cam, táo, kiwi,.. Để tăng thêm hương vị cho thức uống.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\TRA_SUA(TS001)\Hong_tra_sua.jpg', SINGLE_BLOB) AS X))

--Trà nguyên chất
insert into Product values('NC001',N'Trà bí đao',15000,'NC',
N'Trà bí đao là loại trà được nấu từ quả bí đao cùng với đường phó . Đây là thức uống rất được ưa chuộng ở nhiều nước. Đặc biệt là Trung Quốc, Đài Loan và Việt Nam. Trà bí đao được tin là thức uống có khả năng giải nhiệt rất tốt.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\TRA_NGUYEN_CHAT(NC001)\Bi_dao.jpeg', SINGLE_BLOB) AS X))

insert into Product values('NC002',N'Trà Oolong',17000,'NC',
N'Trà Ô Long được cả thế giới đánh giá cao về phẩm chất rất tốt của nó: trà thơm, giàu mùi vị, hậu vị kéo dài, nước dày…  Tất cả đều rất tinh tế, có thể pha được rất nhiều lần nước.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\TRA_NGUYEN_CHAT(NC001)\Oolong.jpg', SINGLE_BLOB) AS X))

insert into Product values('NC003',N'Trà xanh',15000,'NC',
N'Trà xanh hay còn được gọi với cái tên chè xanh là lá của cây trà chưa trải qua các công đoạn làm héo và oxi hóa giống như cách chế biến các loại trà Ô long, trà đen hay trà pha hàng ngày.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\TRA_NGUYEN_CHAT(NC001)\Xanh.jpg', SINGLE_BLOB) AS X))

insert into Product values('NC004',N'Trà đen',18000,'NC',
N'Hồng trà hay Trà Đen là một loại trà. Thông thường, nó có vị trí mạnh hơn so với các loại trà khác như trà xanh. Nó cũng có nhiều caffein hơn. Tên gọi hồng trà bắt nguồn từ màu sắc của nước trà, được sử dụng phổ biến ở các nước Đông Á và một số nơi khác trên thế giới.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\TRA_NGUYEN_CHAT(NC001)\Den.jpg', SINGLE_BLOB) AS X))

insert into Product values('NC005',N'Trà thảo mộc',18000,'NC',
N'Trà thảo mộc là 1 loại thức uống được chế biến từ rễ, hoa, lá, thân thậm chí là hạt của những loài cây cỏ thiên nhiên có công dụng tốt cho sức khỏe. Khác với trà thông thường, trà thảo mộc tuy được gọi là Trà nhưng trong thành phần tạo nên nó không hề có sự xuất hiện của lá trà và thường được để nguyên chứ không nghiền nát để đảm bảo được chất lượng cũng như công dụng vốn có của thảo mộc.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\TRA_NGUYEN_CHAT(NC001)\Thao_moc.jpg', SINGLE_BLOB) AS X))

insert into Product values('NC006',N'Trà Atiso',17000,'NC',
N'Trà atiso là trà được làm từ nụ hoa hoặc lá của cây atiso . Atiso (tên khoa học Cynara scolymus) thuộc họ hoa hướng dương. Hoa atiso bề ngoài có vẻ gần giống với hoa sen, tuy nhiên hoa atiso có màu xanh đậm và hơi đỏ ở tàn hoa.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\TRA_NGUYEN_CHAT(NC001)\Atiso.jpg', SINGLE_BLOB) AS X))

insert into Product values('NC007',N'Trà hoa cúc',15000,'NC',
N'Trà hoa cúc hay trà bông cúc là loại nước sắc làm từ hoa Chrysanthemum morifolium hoặc Chrysanthemum indicum, phổ biến nhất ở Đông Á. Người ta ngâm hoa cúc vào nước nóng ở khoảng nhiệt độ 90-95 °C, có thể thêm đường phản hồi hoặc thỉnh thoảng là khởi động. Nước trà trong suốt và có màu từ vàng nhạt đến vàng tươi.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\TRA_NGUYEN_CHAT(NC001)\Hoa_cuc.jpg', SINGLE_BLOB) AS X))

--Trà trái cây
insert into Product values('TC001',N'Trà xanh vải',22000,'TC',
N'Và trà vải cũng thế nó là một loại trà trái cây tự nhiên có trà, quả vải thiều ngâm, mật ong, nước lạnh . Một số nơi còn biến tấu món trà này thành trà cùng nước ép trái cây, chiết suất của vải,… để dễ uống hơn với những người không thích vị đậm đà của trà.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\TRA_TRAI_CAY(CT001)\Xanh_vai.jpg', SINGLE_BLOB) AS X))

insert into Product values('TC002',N'Trà đen đào',25000,'TC',
N'Trà đào nổi lên như một hiện tượng bắt nguồn từ thương hiệu Phúc Long, sự kết hợp hoàn hảo giữa vị ngọt thanh dịu của trà đen (hồng trà), sự hài hòa lấy vị chua chua đầu của siro đào, thêm đôi ba miếng đào tươi giòn rụm phía trên đủ khiến người ta một khi đã thưởng thức khó lòng mà quên được.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\TRA_TRAI_CAY(CT001)\Den_dao.jpg', SINGLE_BLOB) AS X))

insert into Product values('TC003',N'Trà Oolong vải',22000,'TC',
N'Trà vải là gì? Trà vải được pha chế từ hồng trà hoặc trà oolong kết hợp với các nguyên liệu như vải, syrup đường, chanh… Một số nơi xay nhuyễn quả vải hoặc lấy nước quả vải pha trộn vào đồ uống để tạo vị thơm tự nhiên.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\TRA_TRAI_CAY(CT001)\Oolong_vai.jpg', SINGLE_BLOB) AS X))

insert into Product values('TC004',N'Trà dâu',24000,'TC',
N'Trà dâu là một loại trà dược liệu hữu cơ được ủ bằng lá dâu tây, hoặc có thể được pha từ trà hoặc trà xanh đen ghép với quả dâu tây.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\TRA_TRAI_CAY(CT001)\Dau.jpg', SINGLE_BLOB) AS X))

insert into Product values('TC005',N'Trà chanh dây',22000,'TC',
N'Ly trà chanh dây trái không hề đơn điệu. Phần trái cây bên trên tạo nên cảm giác tươi mới, sắc trà quyện cùng màu vàng tươi của chanh dây sẽ làm bạn không thể cưỡng lại. Thức uống này vừa thanh mát vừa thơm ngon, vừa chua chua ngọt ngọt, lại thơm vị trà, kết hợp với táo và thanh long tươi mát.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\TRA_TRAI_CAY(CT001)\Chanh_day.jpg', SINGLE_BLOB) AS X))

insert into Product values('TC006',N'Trà dưa hấu',20000,'TC',
N'Trà dưa hấu với thành phần chính là nước ép nguyên chất từ ​​dưa hấu, kèm theo đó là một số nguyên liệu như trà, xi-rô, nước đường và đá viên . Sự kết hợp này không những giúp thanh nhiệt, sảng khoái mà còn cung cấp nhiều dưỡng chất tốt cho sức khỏe và làm đẹp da.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\TRA_TRAI_CAY(CT001)\Dua_hau.jpg', SINGLE_BLOB) AS X))

insert into Product values('TC007',N'Trà táo',24000,'TC',
N'Trà táo là thức uống chứa nhiều chất chống oxy hóa, vitamin C, chất xơ, cùng nhiều vitamin và chất có lợi cho sức khỏe . Một số công dụng nổi bật của thức uống này là: Tăng cường khả năng miễn dịch nhờ chứa axit betulinic có đặc tính kháng viêm và kháng thuốc. Giảm lượng đường trong máu.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\TRA_TRAI_CAY(CT001)\Tao.png', SINGLE_BLOB) AS X))

insert into Product values('TC008',N'Trà thanh long',20000,'TC',
N'Trà thanh long là món thức uống thơm ngon, thanh mát và có tính hạ nhiệt rất cao, chắc hẳn cả nhà bạn sẽ yêu thích khi thưởng thức đó. Hôm nay cùng chị Thu Xuân bắt tay vào bếp làm ngay món giải khát này để chiêu đãi mọi người sau mỗi bữa ăn nha.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\TRA_TRAI_CAY(CT001)\Thanh_long.jpg', SINGLE_BLOB) AS X))

--Đá xây
insert into Product values('DX001',N'Cafe sữa đá xây',25000,'DX',
N'Cafe sữa đá xay là tên gọi của thức uống dưới dạng cafe xay kèm sữa và đá , chúng được thế giới gọi chung là coffe ice blended (riêng Starbucks đã đăng ký độc quyền riêng trên thế giới các tên Frappuccino để chỉ món đồ uống cafe đá xay của hãng này).',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\DA_XAY(DX001)\CF_sua_da_xay.jpg', SINGLE_BLOB) AS X))

insert into Product values('DX002',N'Trà xanh đá xây',27000,'DX',
N'Trà xanh đá xay (Matcha Ice Blended) là một trong những thức uống giữ độ “hot” trong thực đơn của các cửa hàng thức uống . Hương vị trà xanh đặc trưng hòa cùng vị sữa, kem béo ngậy tạo nên một thức uống thơm ngon, béo béo. Cách pha trà xanh đá xay dưới đây giúp bạn làm được một ly đá xay mịn và đậm vị.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\DA_XAY(DX001)\Xanh_da_xay.jpg', SINGLE_BLOB) AS X))

insert into Product values('DX003',N'Chocolate đá xây',28000,'DX',
N'Chocolate đá xay (Chocolate Ice Blended) là thức uống xen lẫn chút đắng lẫn chút ngọt ngào đặc trưng của nguyên liệu chính trong thức uống. Sự hòa quyện giữa cacao và đá xay nhuyễn mát lạnh, nhâm nhi chút kem tươi béo béo ở trên khiến cho nhiều người yêu thích món đồ uống “đầy ắp” này.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\DA_XAY(DX001)\Chocolate_da_xay.jpg', SINGLE_BLOB) AS X))

insert into Product values('DX004',N'Trà sữa cookie đá xây',25000,'DX',
N'Trà sữa cookie đá xay là sự kết hợp hương vị hoàn hảo của những chiếc bánh cookie truyền thống với đá xay mát lạnh. Thêm vào đó là lớp kem phủ trắng mịn, béo phì bên trên . Nhờ đó mà công thức thức ăn này đã chinh phục được toàn bộ vị trí của bất kỳ khách hàng nào.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\DA_XAY(DX001)\Cookie_da_xay.jpg', SINGLE_BLOB) AS X))

--Topping 
insert into Product values('TP001',N'Thạch nâu',5000,'TP',
N'Thạch trân châu đường nâu là loại Topping được dùng để trang trí lên bề mặt ly trà sữa bổ sung bắt mắt hấp dẫn hơn, đồng thời cũng góp phần tăng hương vị cho ly trà sữa . Những hạt châu âu ngọt dịu hương đường nâu đặc trưng, ​​khi nhai bạn sẽ có cảm giác giác dai dai khó chịu giúp bạn buồn nôn không chán.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\Topping(TP001)\Thach_nau.png', SINGLE_BLOB) AS X))

insert into Product values('TP002',N'Thạch cafe',4000,'TP',
N'Thạch cafe là sự kết hợp thạch với hương vị cafe làm tăng hương vị topping khi kết hợp với nhiều thức uống khác nhau.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\Topping(TP001)\Thach_cf.png', SINGLE_BLOB) AS X))

insert into Product values('TP003',N'Trân châu trắng',3000,'TP',
N'Đối với trà sữa, topping là tên gọi chung của các loại thạch ăn kèm được cho vào ly trà sữa như: trân châu, thạch, pudding, bánh flan,… Pudding, thạch sau khi làm xong bảo quản bằng cách cho vào ngăn mát. tủ lạnh, sẽ được giữ từ 2 – 3 ngày.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\Topping(TP001)\Tran_chau_trang.png', SINGLE_BLOB) AS X))

insert into Product values('TP004',N'Trân châu đen',3000,'TP',
N'Trân châu đen là loại topping truyền thống ra đời sớm nhất trong các loại topping . Trân châu đen được làm từ bột sắn, hình tròn, nhỏ hơn viên bi, vị trí dai. Trân châu đen được pha trộn với nhiều nguyên liệu khác như: cà phê, ca cao, hương đào… để tạo nên các loại chân trâu đa dạng về màu sắc và hương vị.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\Topping(TP001)\Tran_chau_den.png', SINGLE_BLOB) AS X))

insert into Product values('TP005',N'Thạch trái cây',5000,'TP',
N'Thạch trái cây là loại Topping dai dai, bùi bùi được thêm lên trên nhiều món ăn, đồ uống vừa mang tính chất làm cho món ăn đồ uống lại thêm phần hấp dẫn vừa được xem là “linh hồn” cho món ăn, tăng hương vị trái cây cây tươi mát cho món ăn, đồ uống.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\Topping(TP001)\Thach_trai_cay.png', SINGLE_BLOB) AS X))

insert into Product values('TP006',N'Đậu đỏ',5000,'TP',
N'Đậu đỏ: chọn hạt to vừa phải, tròn mẩy, loại bỏ các hạt lép, hạt mốc trước khi nấu. Hạt đậu đỏ ngon sẽ tạo vị ngọt bùi tự nhiên cho topping. Nếu không tự nấu trà sữa, có rất nhiều loại topping đậu đỏ đóng hộp sẵn trên thị trường để bạn lựa chọn. Tuy nhiên nếu bạn tự nấu thì hương vị topping sẽ có vị tự nhiên và tươi ngon hơn.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\Topping(TP001)\Dau_do.png', SINGLE_BLOB) AS X))

insert into Product values('TP007',N'Sương sáo',5000,'TP',
N'Ôi hoàng tử Sương sáo! Trông Ngài thật ngầu và đầy uy nghiêm với bộ long phục màu đen tuyền nhưng thần biết đâu đó vẫn đọng lại hương thơm ngào ngạt, vị ngọt thanh thoát của Sương Sáo từ Ngài.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\Topping(TP001)\Suong_sao.png', SINGLE_BLOB) AS X))

insert into Product values('TP008',N'Thạch dừa',5000,'TP',
N'Thạch dừa được xem là một món topping không thể thiếu trong món trà sữa. Ngày hè nóng bức được cắn một miếng thạch dừa tươi mát thì cảm giác “phê” cực kỳ.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\Topping(TP001)\Thach_dua.png', SINGLE_BLOB) AS X))

insert into Product values('TP009',N'Flan',5000,'TP',
N'Bánh Flan còn có tên gọi khác là Caramen. Đây là Một loại bánh vừa thơm ngon; mềm xốp; lại hấp dẫn được rất nhiều người từ nhiều lứa tuổi. Bánh được hấp chín từ các nguyên liệu chính là trứng và sữa; nước caramen. Đây là một loại bánh có lẽ xuất xứ từ nền ẩm thực châu Âu; tuy hiện nay đã phổ biến tại nhiều nơi trên thế giới.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\Topping(TP001)\Flan.png', SINGLE_BLOB) AS X))

insert into Product values('TP010',N'Vải',5000,'TP',
N'Thạch vải là món tráng miệng phổ biến được tạo ra từ các loại nguyên liệu phổ biến như vải thiều tươi, nước, đường và bột gelatin . Với hương vị ngọt ngào, mát lạnh, thạch rau câu vải thích hợp dùng làm đồ ăn vặt hay pha trà vải mát lạnh, giải nhiệt cho mùa hè.',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\Topping(TP001)\Tran_chau_vai.png', SINGLE_BLOB) AS X))

insert into Product values('TP011',N'Pudding',5000,'TP',
N'Thạch Pudding được làm từ thành phần chính là bột flan trứng. Điểm hấp dẫn của thạch Pudding so với các loại Topping khác chính là lớp bột sẽ mềm tan từ từ trong miệng chứ không dòn dai. Hiện nay, thạch Pudding cũng có rất nhiều loại: Pudding trứng, đậu đỏ, trà xanh, trái cây,…',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\Topping(TP001)\Pudding.png', SINGLE_BLOB) AS X))

--Discount
insert into Discount values('0',N'Giảm 0%')
insert into Discount values('1',N'Giảm 1%')
insert into Discount values('2',N'Giảm 2%')
insert into Discount values('3',N'Giảm 3%')
insert into Discount values('4',N'Giảm 4%')
insert into Discount values('5',N'Giảm 5%')
insert into Discount values('6',N'Giảm 6%')
insert into Discount values('7',N'Giảm 7%')
insert into Discount values('8',N'Giảm 8%')
insert into Discount values('9',N'Giảm 9%')
insert into Discount values('10',N'Giảm 10%')
insert into Discount values('11',N'Giảm 11%')
insert into Discount values('12',N'Giảm 12%')
insert into Discount values('13',N'Giảm 13%')
insert into Discount values('14',N'Giảm 14%')
insert into Discount values('15',N'Giảm 15%')
insert into Discount values('16',N'Giảm 16%')
insert into Discount values('17',N'Giảm 17%')
insert into Discount values('18',N'Giảm 18%')
insert into Discount values('19',N'Giảm 19%')
insert into Discount values('20',N'Giảm 20%')
insert into Discount values('21',N'Giảm 21%')
insert into Discount values('22',N'Giảm 22%')
insert into Discount values('23',N'Giảm 23%')
insert into Discount values('24',N'Giảm 24%')
insert into Discount values('25',N'Giảm 25%')
insert into Discount values('26',N'Giảm 26%')
insert into Discount values('27',N'Giảm 27%')
insert into Discount values('28',N'Giảm 28%')
insert into Discount values('29',N'Giảm 29%')
insert into Discount values('30',N'Giảm 30%')
insert into Discount values('31',N'Giảm 31%')
insert into Discount values('32',N'Giảm 32%')
insert into Discount values('33',N'Giảm 33%')
insert into Discount values('34',N'Giảm 34%')
insert into Discount values('35',N'Giảm 35%')
insert into Discount values('36',N'Giảm 36%')
insert into Discount values('37',N'Giảm 37%')
insert into Discount values('38',N'Giảm 38%')
insert into Discount values('39',N'Giảm 39%')
insert into Discount values('40',N'Giảm 40%')
insert into Discount values('41',N'Giảm 41%')
insert into Discount values('42',N'Giảm 42%')
insert into Discount values('43',N'Giảm 43%')
insert into Discount values('44',N'Giảm 44%')
insert into Discount values('45',N'Giảm 45%')
insert into Discount values('46',N'Giảm 46%')
insert into Discount values('47',N'Giảm 47%')
insert into Discount values('48',N'Giảm 48%')
insert into Discount values('49',N'Giảm 49%')
insert into Discount values('50',N'Giảm 50%')
insert into Discount values('51',N'Giảm 51%')
insert into Discount values('52',N'Giảm 52%')
insert into Discount values('53',N'Giảm 53%')
insert into Discount values('54',N'Giảm 54%')
insert into Discount values('55',N'Giảm 55%')
insert into Discount values('56',N'Giảm 56%')
insert into Discount values('57',N'Giảm 57%')
insert into Discount values('58',N'Giảm 58%')
insert into Discount values('59',N'Giảm 59%')
insert into Discount values('60',N'Giảm 60%')
insert into Discount values('61',N'Giảm 61%')
insert into Discount values('62',N'Giảm 62%')
insert into Discount values('63',N'Giảm 63%')
insert into Discount values('64',N'Giảm 64%')
insert into Discount values('65',N'Giảm 65%')
insert into Discount values('66',N'Giảm 66%')
insert into Discount values('67',N'Giảm 67%')
insert into Discount values('68',N'Giảm 68%')
insert into Discount values('69',N'Giảm 69%')
insert into Discount values('70',N'Giảm 70%')
insert into Discount values('71',N'Giảm 71%')
insert into Discount values('72',N'Giảm 72%')
insert into Discount values('73',N'Giảm 73%')
insert into Discount values('74',N'Giảm 74%')
insert into Discount values('75',N'Giảm 75%')
insert into Discount values('76',N'Giảm 76%')
insert into Discount values('77',N'Giảm 77%')
insert into Discount values('78',N'Giảm 78%')
insert into Discount values('79',N'Giảm 79%')
insert into Discount values('80',N'Giảm 80%')
insert into Discount values('81',N'Giảm 81%')
insert into Discount values('82',N'Giảm 82%')
insert into Discount values('83',N'Giảm 83%')
insert into Discount values('84',N'Giảm 84%')
insert into Discount values('85',N'Giảm 85%')
insert into Discount values('86',N'Giảm 86%')
insert into Discount values('87',N'Giảm 87%')
insert into Discount values('88',N'Giảm 88%')
insert into Discount values('89',N'Giảm 89%')
insert into Discount values('90',N'Giảm 90%')
insert into Discount values('91',N'Giảm 91%')
insert into Discount values('92',N'Giảm 92%')
insert into Discount values('93',N'Giảm 93%')
insert into Discount values('94',N'Giảm 94%')
insert into Discount values('95',N'Giảm 95%')
insert into Discount values('96',N'Giảm 96%')
insert into Discount values('97',N'Giảm 97%')
insert into Discount values('98',N'Giảm 98%')
insert into Discount values('99',N'Giảm 99%')
insert into Discount values('100',N'Giảm 100%')

--Bill
insert into Bill values('4/19/2023','ma001',42000)

--Detail bill
insert into Detail_bill values(1,'TS001',1,null,20000)
insert into Detail_bill values(1,'TS002',1,null,22000)

--Return bill
insert into Return_bill values(1,'TS001',1,null,20000)

insert into Product (Id_product,Name_product,Fare,Id_Type_product,Note,Img_product)
values('TS100',N'Trà sữa truyền thống',20000,'TS',N'Trà sữa truyền thống',
(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\TRA_SUA(TS001)\Thai.jpg', SINGLE_BLOB) AS X))

update Product set Img_product=(SELECT * FROM OPENROWSET(BULK  N'D:\HK6\LTQL\Lamdoan\image\Topping(TP001)\Flan.png', SINGLE_BLOB) AS X)
where id_product ='TP009'

select Max(id_bill) from Bill group by id_bill



select Sum(Total) as total from Detail_bill where Id_bill=(select Max(id_bill) from Bill)

insert into bill values('4/25/2023','ma001',0)
insert into detail_bill values((select Max(id_bill) from Bill),'TS001', 1,0,20000)
update bill set total = (
		select Sum((Total - (id_discount*total/100))*Quantity) as total 
		from Detail_bill 
		where Id_bill=(select Max(id_bill) from Bill)) 
where Id_bill=(select Max(id_bill) from Bill)


select sum(id_discount*total/100) as total1
from detail_bill
where Id_bill=(select Max(id_bill) from Bill)

select IDENTITY(int, 1,1) as stt,* from Bill where Date_bill ='04/27/2023 12:00:00 AM'

SELECT Bill.Id_bill, Bill.Date_bill, Staff.Name_staff, Product.Name_product, Product.Fare, Detail_bill.Quantity, Detail_bill.Id_discount, Detail_bill.Total
FROM     Bill INNER JOIN
                  Detail_bill ON Bill.Id_bill = Detail_bill.Id_bill AND Bill.Id_bill = Detail_bill.Id_bill INNER JOIN
                  Product ON Detail_bill.Id_product = Product.Id_product INNER JOIN
                  Staff ON Bill.Id_staff = Staff.Id_staff
where Bill.Id_bill = 2

select COALESCE(sum(Bill.total),0) as total,count(Bill.Id_bill) as quantity_bill,
	(select count(Detail_bill.Id_detail_bill)
	from Bill, Detail_bill 
	where Bill.Id_bill=Detail_bill.Id_bill
	and Bill.Date_bill='2023-05-07') as quantity_product
from Bill
where Bill.Date_bill='2023-05-07'

select Account_name from Account where Id_staff='ma001'
update Account set Password='1' where Password='1' and Account_name=(select Account_name from Account where Id_staff='ma001') and '11'='1'

select Max(id_bill) as id_bill from Bill

select COALESCE(sum(Bill.total),0) as total,count(Bill.Id_bill) as quantity_bill,
(select count(Detail_bill.Id_detail_bill)
from Bill, Detail_bill 
where Bill.Id_bill=Detail_bill.Id_bill
and Bill.Date_bill between '2023-05-20'
and '2023-05-22') as quantity_product
from Bill
where Bill.Date_bill between '2023-05-20'
and '2023-05-22'

SELECT ROW_NUMBER() OVER (ORDER BY id) AS rownum, * FROM my_table