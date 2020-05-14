<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ThemMoiTaiKhoanLoadControl.ascx.cs" Inherits="Website_GuiThuDienTu.cms.Admin.QLTaiKhoan.ThemMoiTaiKhoanLoadControl" %>
  <div class="khungchuabang">
        <center>
            <table class="tbTaiKhoan">
                <tr>
                    <td colspan="2" style="align-content:center; text-align: center;">THÔNG TIN</td>
                </tr>
                
                <tr>
                    <td>
                        Email
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" Width="200px" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        Mật khẩu
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" Width="200px" CssClass="password" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        Họ tên
                    </td>
                    <td>
                        <asp:TextBox ID="txtUserName" runat="server" Width="200px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        Trạng thái
                    </td>
                    <td>
                        <asp:DropDownList ID="drdnCondition" runat="server"  Width="200px"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td>
                        Quyền
                    </td>
                    <td>
                        <asp:DropDownList ID="drdnRole" runat="server"  Width="200px"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td style="text-align: right">
                        <asp:Button ID="btnUpdate" runat="server" Text="Thêm Mới" Width="80px" OnClick="btnUpdate_Click"/>
                        <asp:Button ID="btnCancel" runat="server" Text="Huỷ" Width="80px" OnClick="btnCancel_Click"/>
                    </td>
                </tr>
            </table>
        </center>
    </div>