<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="DangKy.aspx.cs" Inherits="Website_GuiThuDienTu.DangKy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <link href="Style/css/DangNhap.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style3 {
            text-align: center;
            font-size: xx-large;
            height: 60px;
        }
        
     
        .auto-style4 {
            height: 500px;
            width: 1190px;
        }
        
     
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="top">
           
            <div class="wrapper">
                <div class="menu">
                    <ul>
                       <%-- <li><a href="TrangChu.aspx">Trang chủ</a></li>--%>
                        <li><a href="DangNhap.aspx">Đăng nhập</a></li>
                        <li><a href="DangKy.aspx">Đăng ký</a></li>
                     
                    </ul>
                </div>
            </div>
        </div>
    <div class="auto-style4">
            <div class="auto-style3" style="height: 100px; line-height: 100px; text-align: center; vertical-align: middle;">
           
                <strong>Tạo Tài Khoản</strong>
            </div>
         <div style=" width:350px; margin:auto ">
          
             <div class="row">
                 <div>Tên Tài Khoản</div>
                 <asp:TextBox ID="txtTenTK" runat="server" Height="35px" Width="345px" ToolTip="Nhập Tên Tài Khoản"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="ReFeiTK" ControlToValidate="txtTenTK" runat="server" SetFocusOnError="true" ErrorMessage=" Vui lòng điền!" Display="Dynamic" ForeColor="Red" Text="*">*</asp:RequiredFieldValidator>
                  </div>
               <div class="row">
                 <div>Email</div>
                 <asp:TextBox ID="txtEmail" runat="server" Height="35px" Width="345px" TabIndex="1" ToolTip="Nhập Email"></asp:TextBox>
                   <asp:RegularExpressionValidator ID="RegexEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email không đúng định dạng!" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="ReFeiEmail" ControlToValidate="txtEmail" runat="server" ErrorMessage="Vui lòng điền!" Display="Dynamic" ForeColor="Red" Text="*"></asp:RequiredFieldValidator>
                  </div>
             <div class="row">
                 <div>Mật Khẩu</div>
                 <asp:TextBox ID="txtMK" runat="server" Height="35px" Width="345px" TabIndex="2" ToolTip="Nhập Mật Khẩu"></asp:TextBox>
                 <asp:RegularExpressionValidator ID="RegexMK" runat="server" ControlToValidate="txtMK" ErrorMessage="Mật Khẩu không đúng định dạng" ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$" Display="Dynamic" ForeColor="Red" Text="*"></asp:RegularExpressionValidator>
                  <asp:RequiredFieldValidator ID="ReFeiMK" ControlToValidate="txtMK" runat="server" ErrorMessage="Vui lòng điền!" Display="Dynamic" ForeColor="Red" Text="*"></asp:RequiredFieldValidator>
                  </div>
             <div  class="row">
                 <div>Nhập Lại Mật Khẩu</div>
                 <asp:TextBox ID="txtMK2" runat="server" Height="35px"  Width="345px" TabIndex="3" ToolTip="Nhập Lại Mật Khẩu"></asp:TextBox>
                 <asp:CompareValidator ID="CompaMK2" runat="server" ControlToValidate="txtMK2" ControlToCompare="txtMK" ErrorMessage="Mật Khẩu không khớp!" ForeColor="Red" Display="Dynamic" Text="*"></asp:CompareValidator><br />
                  <asp:RequiredFieldValidator ID="ReqFeiMK2" ControlToValidate="txtMK2" runat="server" ErrorMessage="Vui lòng điền!" Display="Dynamic" ForeColor="Red" Text="*"></asp:RequiredFieldValidator>
                 
                  </div>
              <div  class="row">
                  <asp:Button ID="btnDK" runat="server" Text="Đăng kí" Width="345px"  Height="40px" BackColor="#006666" ForeColor="White" TabIndex="4" OnClick="btnDK_Click" /> <br />
              </div>
        </div>
        
    </div>
</asp:Content>
