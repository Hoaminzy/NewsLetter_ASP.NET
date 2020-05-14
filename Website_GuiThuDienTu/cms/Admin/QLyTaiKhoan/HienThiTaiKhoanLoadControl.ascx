<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HienThiTaiKhoanLoadControl.ascx.cs" Inherits="Website_GuiThuDienTu.cms.Admin.QLTaiKhoan.HienThiTaiKhoanLoadControl" %>
<div class="head">
    Danh sách các tài khoản đã tạo
    
        <a class="btThemMoi" href="Adminn.aspx?modul=QLyTaiKhoan&thaotac=ThemMoiTaiKhoan" style="color:#b26007"><img src="../../../../Images/icons8-add-10.png" />Thêm mới tài khoản</a>
   
    <div class="cb"></div>
</div>
<div class="khungChuaBang">
    <table class="tbTaiKhoan">
        <tr>
            <th class="cotMa">Mã</th>
            <th class="cotTen">Tên tài khoản</th>
            <th class="cotEmail">Email</th>
              <th class="cotPass">Password</th>
              <th class="cotTinhtrang">Tình Trạng</th>
              <th class="cotQuyen">Quyền</th>
            <th class="cotCongCu">Cột công cụ</th>
        </tr>
        <asp:Literal ID="ltrTaiKhoan" runat="server"></asp:Literal>
    </table>
</div>