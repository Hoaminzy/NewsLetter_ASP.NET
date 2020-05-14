<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Website_GuiThuDienTu.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Style/css/login.css" rel="stylesheet" />
<%--    <script src="Style/js/login.js"></script>--%>
 
</head>
<body>
    <form id="form1" runat="server" onsubmit="return validate(this)">
   <div>
       <center>
           <h1>Đăng Nhập</h1>
       </center>
   </div>
  <div class="container">
    <label for="uname"><b>Tên Đăng Nhập</b></label>
    <asp:TextBox ID="txtEmail" runat="server"   placeholder="Nhập Email" CssClass="text" Width="400px"></asp:TextBox>
   
       <label for="psw"><b>
      <br />
      Mật Khẩu</b></label>&nbsp;
      <asp:TextBox ID="txtPass" runat="server"   placeholder="Nhập Mật Khẩu" CssClass="password text" TextMode="Password" Width="400px"></asp:TextBox> 
      <asp:Button ID="btnLogin" runat="server"  OnClick="btnDangNhap" Text="Đăng Nhập" Width="400px" Height="40px" BackColor="#006666" Font-Bold="True" Font-Size="Medium" ForeColor="White" />
      <label>
      <input type="checkbox" checked="checked" name="remember"/> Remember me<br />
      <asp:Literal ID="lbThongBao"  runat="server"></asp:Literal>
    </label>
  </div>

    </form>
      
</body>
</html>
