# Car garage Management
Đồ án môn Công Nghệ Phần Mền_SE104.J21.PMCL
Đồ án bao gồm 3 thành viên:
1. Châu Thị Bích Đào_16520181
2. Nguyễn Thị Thu Hiền_16520367
3. Huỳnh Quang Minh_17520749

1. Đặt vấn đề
 - Công nghệ càng ngày càng phát triễn như vũ bão , việc ứng dụng công nghệ thông tin 4.0 không còn mới trong cuộc sông hiện đại , mọi ngành nghề đều có thể ứng dụng và đạt được các thành quả rất lớn . 
Hiện nay, với sự phát triển nhanh chóng của xã hội hiện đại thì đời sống con người ngày một được nâng cao hơn rất nhiều , nhiều gia đình đã sắm cho mình được ô tô để di chuyển thuận tiện hơn . Vì vậy việc bảo trì , sửa chữa ô tô là việc rất cần thiết hơn ,phần mềm được xây dựng  để phục vụ cho nhu cầu thiết yếu của con người hiện nay .
Vì vậy phải tạo ra được 1 phần mềm dễ sử dụng , trực quan , thân thiện với người sử dụng và đầu đủ tất cả các chức năng cần thiết .
2. Giải pháp
Các Garage lại cần phải có 1 hệ thống quản lí chặt chẽ, hiệu quả , hiểu được nhu cầu đó , nhóm chúng em chọn đề tài này để đáp ứng nhu cầu rất lớn từ thị trường này , đây là 1 thị trường khá béo bở hiện nay . Ý tưởng không mới nhưng chắc chắn sẽ thành công và đem lại lợi nhuận thật lớn.
Xây dựng phần mềm với các chức năng lưu các thông tin khách hàng , giá , quản lý nhập kho , thống kê chi tiêu ,…nhờ việc kết nối với cơ sỡ dữ liệu một cách rõ ràng nhất . Sử dụng thật toán tối ưu nhất để kiệm thời gian , chi phí . Để đảm bảo tính phân quyền cho hệ thống , người quản lý đăng nhập để quản lý tất cả mọi việc đang diễn ra trong quán cũng như để phân cấp tài khoản cho nhân viên .


3. Mục tiêu 
Xây dựng được phần mềm quản lý Garage đáp ứng được những yêu cầu :
- Đăng nhập vào phần mền ( quản lý , nhân viên ) .
- Quản lý bán hàng .
- Quản lý nhân viên .
- Quản lý kho .
- Quản lý khách hàng .
- Quản lý giá bán .
- Thống kê doanh thu .
4. Phạm vi
Nhóm sẽ tập trung vào mảng thiết kế , xây dựng phần mền với các chức năng chính : quản lý nhân viên , quản lý kho , quản lý khách hàng , giá bán , thống kê doanh thu do thời gian có hạn và nhóm chỉ mới đang xây dựng phần mền cho garage vừa và nhỏ .
5. Công cụ sử dụng
Trong quá trình thực hiện đồ án, nhóm đã sử dụng một số phần mềm phục vụ cho việc tìm hiểu và xây dựng đề tài bao gồm: 
- Microsoft SQL Server 2012: Hệ quản trị CSDL quan hệ .
- Visual Studio 2015 : Hỗ trợ lập trình Winform C# .
- StarUML , Microsoft Visio 2013 , Rational Rose , Paint : Phục vụ việc vẽ các sơ đồ dữ liệu .

2. Phân tích chi tiết các chức năng
2.1 Tiếp nhận thông tin khách hàng và thông tin xe
DFD
 
D1 : Thông tin khách hàng : họ tên, điện thoại, địa chỉ, Hiệu xe, Biển số xe
D2 : Không có
D3 : Danh sách khách hàng, danh sách xe tiếp nhận trong ngày, danh sách hiệu xe
D4 : D1
D5 : D4
D6 : không có
 Các bước xử lý:
1.	Kết nối cơ sở dữ liệu
2.	Đọc D3 từ bộ nhớ phụ
3.	Nhận D1 từ người dùng
4.	Kiểm tra loại xe có thuộc danh sách loại xe hay không
5.	Kiểm tra quy định nhận xe trong 1 ngày
6.	Kiểm tra thông tin D1 nhận có trong CSDL hay chưa
7.	Không thỏa 1 trong các điều kiện đi tới bước 10
8.	Lưu D5 xuống bộ nhớ phụ
9.	Xuất D6 ra máy in
10.	Đóng kết nối cơ sở dữ liệu
11.	Kết thúc.
ERD
 
ClassDiagram
 







RD 
 
2.2 Tra cứu xe
 
D1 : Thông tin cần tra cứu
D2 : không có
D3 : Danh sách xe đã tiếp nhận, danh sách khách hàng, danh sách hiệu xe
D4 : D1
D5 : D4
D6 : Danh sách xe và các thông tin liên quan

Các bước xử lý:
1.	Kết nối cơ sở dữ liệu
2.	Đọc D3 từ bộ nhớ phụ
3.	Nhận D1 từ người dùng
4.	Kiểm tra các thông tin người dùng nhập vào
5.	Không thỏa 1 thông tin đi tới bước 8
6.	Lưu D1 xuống bộ nhớ
7.	Xuất D5 ra máy in
8.	Đóng kết nối cơ sở dữ liệu
9.	Kết thúc.

2.3 Xác định dịch vụ sữa chữa

 
D1 : Thông tin dịch vụ khách hàng muốn sửa chữa
D2 : Không có
D3 : Danh sách dịch vụ , danh sách khách hàng 
D4 : D1
D5 : D4
D6 : Dịch vụ khách hàng chọn sửa chữa 
Các bước xử lý:
1. Kết nối cơ sở dữ liệu
2. Đọc D3 từ bộ nhớ phụ
3. Nhận D1 từ người dùng
4. Kiểm tra các thông tin , dịch vụ người dùng nhập vào
5. Không thỏa 1 thông tin đi tới bước 8
6. Lưu D1 xuống bộ nhớ
7. Xuất D5 ra máy in
8. Đóng kết nối cơ sở dữ liệu
9. Kết thúc.

2.4 Lập phiếu dịch vụ
 

D1: Biển số xe, nội dung, loại vật tư phụ tùng, số lượng
D2:Không có.
D3:Danh sách phiếu tiếp nhận, danh sách phụ tùng, danh sách khách hàng.
D4:D1
D5:D4.
D6:D5

Các bước xử lý :
1.	Nhận D1 từ người dùng.
2.	Kết nối cơ sở dữ liệu.
3.	Đọc D3 từ bộ nhớ phụ.
4.	Tìm “phiếu tiếp nhận”(D3) có thông tin trùng khớp với “biển số xe”(D1). Nếu không có thì tới bước 11
5.	Kiểm tra “phiếu tiếp nhận” tìm được đã được lập phiếu sửa chữa hay chưa. Nếu chưa thì tới bước 11
6.	Kiểm tra “loại vật tư phụ tùng”(D1) có trong “danh sách phụ tùng” (D3) hay ko.
7.	Nếu không thỏa một trong các bước trên thì tới bước 12
8.	Lưu D4 xuống bộ nhớ phụ.
9.	Xuất D5 ra máy in nếu có yêu cầu.
10.	Trả D6 cho người sử dụng.
11.	Đóng kết nối cơ sở dữ liệu.
12.	Kết thúc.

ERD
 
RD
 


2.5 Thanh toán
 
D1: Biển số xe, Loại tiền công, loại vật tư phụ tùng, số lượng
D2:Không có.
D3:Danh sách phiếu dịch vụ ,danh sách phụ tùng, danh sách khách hàng, danh sách tiền công
D4:D1
D5:D4.
D6:D5
Các bước xử lý :
1.	Nhận D1 từ người dùng.
2.	Kết nối cơ sở dữ liệu.
3.	Đọc D3 từ bộ nhớ phụ.
4.	Tìm “phiếu dịch vụ”(D3) có thông tin trùng khớp với “biển số xe”(D1). Nếu không có thì tới bước 13
5.	Kiểm tra “loại tiền công” (D1) có trong “danh sách tiền công” hay không.
6.	Nếu không thỏa một trong các bước trên thì tới bước 13
7.	Đối chiếu “loại vật tư phụ tùng” (D1) để lấy giá trị “đơn giá” từ  “danh sách phụ tùng” (D3).
8.	Đối chiếu “loại tiền công”(D1) để lấy giá trị “tiền công” từ “danh sách tiền công” (D3).
9.	“Thành tiền” = “số lượng * đơn giá + tiền công”.
10.	Lưu D4 xuống bộ nhớ phụ.
11.	Xuất D5 ra máy in nếu có yêu cầu.
12.	Trả D6 cho người sử dụng.
13.	Đóng kết nối cơ sở dữ liệu.
14.	Kết thúc.












ERD
 

2.6 Xuất hóa đơn
 




D1:Họ tên chủ xe, biển số, số tiền thu, ngày thu tiền.
D2: Không có.
D3: Danh sách khách hàng, danh sách thông tin xe.
D4: Ngày thu tiền, số tiền thu.
D5: D1 + địa chỉ, điện thoại.
D6:D5.
Các bước xử lý :
1.	Nhận D1 từ người dùng.
2.	Kết nối cơ sở dữ liệu.
3.	Đọc D3 từ bộ nhớ phụ.
4.	Đối chiếu “tên chủ xe” (D1) có tồn tại trong “danh sách khách hàng” (D3) không.
5.	Đối chiếu “biển số” (D1) có tồn tại trong “danh sách thông tin xe”(D3) không.
6.	Nếu không thỏa một trong các bước trên thì tới bước 12
7.	Dựa vào “biển số xe” để tìm tiền cần trả của khách hàng tương ứng trong danh sách khách hàng.
8.	Cập nhật lại giá trị “tiền nợ” của khách hàng.
9.	Lưu D4 xuống bộ nhớ phụ.
10.	Xuất D5 ra máy in nếu có yêu cầu.
11.	Trả D6 về cho người dùng.
12.	Đóng kết nối cơ sở dữ liệu.
13.	Kết thúc







2.7 Nhập phụ tùng
 
D1: Tên phụ tùng.
D2: Không có.
D3: Danh sách phụ tùng.
D4: Không có.
D5: Không có.
D6: Không có.

1.	Nhận D1 từ người dùng.
2.	Kết nối cơ sở dữ liệu.
3.	Đọc D3 từ bộ nhớ phụ.
4.	Kiểm tra “Tên phụ tùng” (D1) có trong danh sách phụ tùng hay không. Nếu không thì tới bước 7.
5.	Nhập số lượng phụ tùng cần thêm vào kho
6.	Đóng kết nối cơ sở dữ liệu.
7.	Kết thúc





2.8 Xuất phụ tùng
 
D1: Tên phụ tùng.
D2: Không có.
D3: Danh sách phụ tùng.
D4: Không có.
D5: Không có.
D6: Không có.

1.	Nhận D1 từ người dùng.
2.	Kết nối cơ sở dữ liệu.
3.	Đọc D3 từ bộ nhớ phụ.
4.	Kiểm tra “Tên phụ tùng” (D1) có trong danh sách phụ tùng hay không. Nếu không thì tới bước 7.
5.	Nhập số lượng phụ tùng đã xuất ra khỏi kho
6.	Đóng kết nối cơ sở dữ liệu.
7.	Kết thúc




2.9 Cập nhập phụ tùng
 
D1: Tên phụ tùng.
D2: Không có.
D3: Danh sách phụ tùng.
D4: Không có.
D5: Không có.
D6: Không có.

1.	Nhận D1 từ người dùng.
2.	Kết nối cơ sở dữ liệu.
3.	Đọc D3 từ bộ nhớ phụ.
4.	Kiểm tra “Tên phụ tùng” (D1) có trong danh sách phụ tùng hay không. Nếu không thì tới bước 7.
5.	Cập nhật số lượng, tên phụ tùng .
6.	Đóng kết nối cơ sở dữ liệu.
7.	Kết thúc



2.10 Lập báo cáo
 
D1: Tháng.
D2: Không có.
D3:Danh sách hiệu xe, danh sách phiếu sửa chữa, danh sách thông tin phiếu sửa chữa, danh sách báo cáo doanh số.
D4: D1 + tổng doanh thu, hiệu xe, số lượt sửa, thành tiền
D5: D4.
D6: D5.
1.	Nhận D1 từ người dùng.
2.	Kết nối cơ sở dữ liệu.
3.	Đọc D3 từ bộ nhớ phụ.
4.	Kiểm tra “tháng” (D1) có vượt quá tháng hiện tại không. Nếu vượt quá tháng hiện tại thì tới bước 12.
5.	Tổng doanh thu = tổng số tiền của tất cả các phiếu dịch vụ trong tháng đã nhập.
6.	Tính tổng số lượt sửa của tất cả các hiệu xe =  tổng số phiếu dịch vụ trong tháng đã nhập.
7.	Số lượt sửa của 1 hiệu xe = tổng số phiếu dịch vụ của hiệu xe đó.
8.	Thành tiền của1 hiệu xe = tổng số tiền ở các phiếu thanh toán của hiệu xe đó.
9.	Xuất D5 ra máy in nếu có yêu cầu.
10.	Trả D6 về cho người sử dụng.
11.	Lưu D4 xuống bộ nhớ phụ.
12.	Đóng kết nối cơ sở dữ liệu.
13.	Kết thúc.

2.11 Xuất báo cáo

 
D1 : Thống kê doanh thu tuần , tháng hoặc năm
D2 : Không có
D3 : Danh sách thống kê doanh thu của garage 
D4 : D1
D5 : D4
D6 : Báo cáo thống kê doanh thu
Các bước xử lý:
10. Kết nối cơ sở dữ liệu
11. Đọc D3 từ bộ nhớ phụ
12. Nhận D1 từ người dùng
13. Kiểm tra các thông tin , doanh thu của garage
14. Không thỏa 1 thông tin đi tới bước 8
15. Lưu D1 xuống bộ nhớ
16. Xuất D5 ra máy in
17. Đóng kết nối cơ sở dữ liệu
18. Kết thúc.
2.12 Cập nhật , thay đổi thông tin dịch vụ
 
D1:Tên loại dịch vụ, mức tiền
D2: Không có.
D3: Danh sách dịch vụ
D4: D1.
D5: D4.
D6: Không có.

1.	Nhận D1 từ người dùng.
2.	Kết nối cơ sở dữ liệu.
3.	Đọc D3 từ bộ nhớ phụ.
4.	Kiểm tra “tên loại dịch vụ” (D1) có trong danh sách dịch vụ hay không. Nếu đã có thì cập nhật giá trị mức tiền.
5.	Xuất D5 (máy in …) nếu có yêu cầu.
6.	Lưu D4 xuống bộ nhớ phụ.
7.	Đóng kết nối cơ sở dữ liệu.
8.	Kết thúc.
2.13 Cập nhật , thay đổi thông tin tiền công
 
D1:Tên loại tiền công, mức tiền.
D2: Không có.
D3: Danh sách tiền công.
D4: D1.
D5: D4.
D6: Không có.

9.	Nhận D1 từ người dùng.
10.	Kết nối cơ sở dữ liệu.
11.	Đọc D3 từ bộ nhớ phụ.
12.	Kiểm tra “tên loại tiền công” (D1) có trong danh sách tiền công hay không. Nếu đã có thì cập nhật giá trị mức tiền.
13.	Xuất D5 (máy in …) nếu có yêu cầu.
14.	Lưu D4 xuống bộ nhớ phụ.
15.	Đóng kết nối cơ sở dữ liệu.
16.	Kết thúc.
