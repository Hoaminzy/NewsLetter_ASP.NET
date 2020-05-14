<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adminn.aspx.cs" Inherits="Website_GuiThuDienTu.Adminn" %>

<%@ Register Src="~/cms/Admin/AdminLoadControl.ascx" TagPrefix="uc1" TagName="AdminLoadControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang Quản Trị </title>
    <link href="Style/css/admin.css" rel="stylesheet" />
    <script src="ckeditor/ckeditor.js"></script>
    
</head>
<body>
 <form id="form1" runat="server">
   
        <%--header--%>
        <div class="contaner">
                <div class="header">
        <div class="logo">
            <img src="Images/icons8-letterbox-100.png" />
        </div>
        <div class="thongtinkhac">
            
                <asp:Literal ID="ltThongBaoAcc" runat="server"></asp:Literal>|
             <asp:LinkButton ID="btnDX" runat="server" OnClick="ltDangXuat_click">Đăng Xuất</asp:LinkButton>
        </div>
    </div>
        </div>
       <%--menu--%>
    <div id="menu">
         <div class="contaner">
            <ul>
                <li><a class="<%=DanhDau("QLyLetter") %>" href="Adminn.aspx?modul=QLyLetter">Chủ Đề</a></li>
                 <li><a class="<%=DanhDau("QLyTaiKhoan") %>" href="Adminn.aspx?modul=QLyTaiKhoan">Tài Khoản</a></li>
                 <li><a class="<%=DanhDau("SendLetter") %>" href="Adminn.aspx?modul=SendLetter">SendLetter</a></li>
               <%--    <li><a href="Adminn.aspx?modul=DangXuat">Đăng Xuất</a></li>--%>
            </ul>
       </div>
        </div>
      <div class="cb"></div>
    <%-- Phần hiển thị  nội dung chính--%>
        <div id="body">
            <uc1:AdminLoadControl runat="server" id="AdminLoadControl" />
       </div>
     <div id="footer">
           <img style="width:1333px;" src="Images/footer.png" />
     </div>
    </form>
</body>
</html>
