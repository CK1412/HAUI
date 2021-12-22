## CSDL QLBanHang:
```
CREATE DATABASE QLBanHang
GO
USE QLBanHang
GO
CREATE TABLE LoaiSP(
MaLoai char(3) PRIMARY KEY,
TenLoai nvarchar(20) )
GO
INSERT INTO LoaiSP VALUES('L01',N'Điện lạnh')
INSERT INTO LoaiSP VALUES('L02',N'Điện tử')
INSERT INTO LoaiSP VALUES('L03',N'Gia dụng')
GO
CREATE TABLE SanPham
(
MaSP char(3) PRIMARY KEY,
TenSP nvarchar(30),
DonGia int,
SoLuongCo int,
MaLoai char(3) FOREIGN KEY REFERENCES LoaiSP(MaLoai))
GO
INSERT INTO SanPham VALUES('S01',N'Tủ lạnh',2000,100,'L01')
INSERT INTO SanPham VALUES('S02',N'Điều hòa',3000,200,'L01')
INSERT INTO SanPham VALUES('S03',N'Ti vi',1000,300,'L02')
GO
CREATE TABLE HoaDonChiTiet
(MaHD char(3),
MaSP char(3) FOREIGN KEY REFERENCES SanPham(MaSP),
NgayBan date,
SoLuongMua int,
PRIMARY KEY(MaHD,MaSP),
)
GO
INSERT INTO HoaDonChiTiet VALUES('H01','S01','2021/09/20',10)
INSERT INTO HoaDonChiTiet VALUES('H01','S02','2021/09/20',20)
INSERT INTO HoaDonChiTiet VALUES('H02','S01','2021/09/20',30)
INSERT INTO HoaDonChiTiet VALUES('H03','S02','2021/09/20',40)


SELECT * FROM LoaiSP
SELECT * FROM SanPham
SELECT * FROM HoaDonChiTiet
```
## Tạo và cập nhật model
### 1. Tạo model từ database
  `Scaffold-Dbcontext "Data Source=COOL-KID\SQLEXPRESS;Initial Catalog=QLBanHang;Integrated Security=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir model`
### 2. cập nhật model khi database thay đổi
  `Scaffold-Dbcontext "Data Source=COOL-KID\SQLEXPRESS;Initial Catalog=QLBanHang;Integrated Security=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir models -Force`
  
## Có thể tạo giao diện dạng lưới ở tệp MainWindow.xaml như sau:
```
<Grid Margin="10">
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="auto"></ColumnDefinition>
            <ColumnDefinition Width="*"></ColumnDefinition>
        </Grid.ColumnDefinitions>
        <Grid.RowDefinitions>
            <RowDefinition Height="auto"></RowDefinition>
            <RowDefinition Height="auto"></RowDefinition>
            <RowDefinition Height="auto"></RowDefinition>
            <RowDefinition Height="auto"></RowDefinition>
            <RowDefinition Height="auto"></RowDefinition>
            <RowDefinition Height="*"></RowDefinition>
            <RowDefinition Height="auto"></RowDefinition>
            <RowDefinition Height="auto"></RowDefinition>
        </Grid.RowDefinitions>
        <Label Content="Mã sản phẩm" Grid.Row="0" Grid.Column="0" Width="150" Margin="10"/>
        <Label Content="Tên sản phẩm" Grid.Row="1" Grid.Column="0" Width="150" Margin="10"/>
        <Label Content="Loại sản phẩm" Grid.Row="2" Grid.Column="0" Width="150" Margin="10"/>
        <Label Content="Đơn giá" Grid.Row="3" Grid.Column="0" Width="150" Margin="10"/>
        <Label Content="Số lượng có" Grid.Row="4" Grid.Column="0" Width="150" Margin="10"/>

        <TextBox x:Name="textBoxMaSP" Grid.Row="0" Grid.Column="1" Width="200" Margin="10" HorizontalAlignment="Left"></TextBox>
        <TextBox x:Name="textBoxTenSP" Grid.Row="1" Grid.Column="1" Width="200" Margin="10" HorizontalAlignment="Left"></TextBox>
        <ComboBox x:Name="comboBoxLoaiSP" Grid.Row="2" Grid.Column="1" Width="200" Margin="10" HorizontalAlignment="Left"></ComboBox>
        <TextBox x:Name="textBoxDonGia" Grid.Row="3" Grid.Column="1" Width="200" Margin="10" HorizontalAlignment="Left"></TextBox>
        <TextBox x:Name="textBoxSLCo" Grid.Row="4" Grid.Column="1" Width="200" Margin="10" HorizontalAlignment="Left"></TextBox>

        <DataGrid x:Name="dataGrid" Grid.Row="5" Grid.Column="0" Grid.ColumnSpan="2" 
                  AutoGenerateColumns="False" IsReadOnly="True"
                  EnableRowVirtualization="False"
                  SelectedCellsChanged="dataGrid_SelectedCellsChanged">
            <DataGrid.Columns>
                <DataGridTextColumn Header="Mã sản phẩm" Binding="{Binding MaSp}" Width=".2*" HeaderStyle="{StaticResource WrappedColumnHeaderStyle}"></DataGridTextColumn>
                <DataGridTextColumn Header="Tên sản phẩm" Binding="{Binding TenSp}" Width=".2*" HeaderStyle="{StaticResource WrappedColumnHeaderStyle}"></DataGridTextColumn>
                <DataGridTextColumn Header="Mã loại" Binding="{Binding MaLoai}" Width=".2*" HeaderStyle="{StaticResource WrappedColumnHeaderStyle}"></DataGridTextColumn>
                <DataGridTextColumn Header="Số lượng có" Binding="{Binding SoLuongCo}" Width=".2*" HeaderStyle="{StaticResource WrappedColumnHeaderStyle}"></DataGridTextColumn>
                <DataGridTextColumn Header="Đơn giá" Binding="{Binding DonGia}" Width=".2*" HeaderStyle="{StaticResource WrappedColumnHeaderStyle}"></DataGridTextColumn>
                <DataGridTextColumn Header="Thành tiền" Binding="{Binding ThanhTien}" Width=".2*" HeaderStyle="{StaticResource WrappedColumnHeaderStyle}" CellStyle="{StaticResource CellStyle}"></DataGridTextColumn>
            </DataGrid.Columns>
        </DataGrid>

        <WrapPanel Grid.Row="6" Grid.Column="0" Grid.ColumnSpan="2" HorizontalAlignment="Center">
            <Button x:Name="buttonThem" Content="Thêm" Width="100" Margin="10" Click="buttonThem_Click"></Button>
            <Button x:Name="buttonSua" Content="Sửa" Width="100" Margin="10" Click="buttonSua_Click"></Button>
            <Button x:Name="buttonXoa" Content="Xoá" Width="100" Margin="10" Click="buttonXoa_Click"></Button>
            <Button x:Name="buttonTim" Content="Tìm" Width="100" Margin="10" Click="buttonTim_Click"></Button>
        </WrapPanel>

        <Label x:Name="labelMaLoi" Foreground="Red" HorizontalContentAlignment="Center" Grid.Row="7" Grid.Column="0" Grid.ColumnSpan="2" Width="auto" Margin="10"/>

    </Grid>
```
