<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="QLTaiKhoanLoadControl.ascx.cs" Inherits="Website_GuiThuDienTu.cms.Admin.QLyTaiKhoan.QLTaiKhoanLoadControl" %>
<div class="container">
    <div style="clear:both; height: 20px;"></div>
    <div class="cottrai">
        <div class="head">
            Quản lý
        </div>
        <ul>
            <li><a class="<%=DanhDau("QLyTaiKhoan","HienThiTaiKhoan") %>" href="Adminn.aspx?modul=QLyTaiKhoan&&thaotac=HienThiTaiKhoan">Danh Sách tài khoản</a></li>
        </ul>
       <div class="head">
            Thêm mới
        </div>
        <ul>
            <li><a class =<%=DanhDau("QLyTaiKhoan", "ThemMoiTaiKhoan") %> href="Adminn.aspx?modul=QLyTaiKhoan&&thaotac=ThemMoiTaiKhoan">Thêm mới tài khoản</a></li>
        </ul>
    </div>

    <div class="cotphai">
        <asp:PlaceHolder ID="plContent" runat="server"></asp:PlaceHolder>
    </div>
    <div class="cb">
        <!---->
    </div>
</div>
 
