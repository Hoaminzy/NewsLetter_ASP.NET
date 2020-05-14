<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ThemMoiSendLetterControl.ascx.cs" Inherits="Website_GuiThuDienTu.cms.Admin.SendLetter.ThemMoiSendLetterControl" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>


 
<div class="khungchuabang">
            <center>
                <table class="tbLetters">
                <tr>
                <td colspan="2">GỬI THƯ</td>
                </tr>
                <tr class="">
                    <td>Tới</td>
                    <td><asp:ListBox ID="lstbEmail" runat="server" SelectionMode="Multiple" Width="300px"></asp:ListBox></td>
                </tr>
                    <tr>
                    <td>CC</td>
                    <td><asp:TextBox ID="txtCC" runat="server" Width="300px" ></asp:TextBox></td>
                </tr>
                    <tr>
                    <td>BCC</td>
                    <td><asp:TextBox ID="txtBCC" runat="server" Width="300px"></asp:TextBox></td>
                </tr>
                    <tr>
                    <td>Tiêu đề</td>
                    <td><asp:TextBox ID="txtSubject" runat="server" Width="300px"></asp:TextBox></td>
                </tr>
                    <tr>
                    <td>Nội dung</td>
                    <td><asp:TextBox ID="txtBody" runat="server" TextMode="MultiLine" Width="300px"></asp:TextBox></td>
        <%--    <CKEditor:CKEditorControl ID="txtBody" runat="server"></CKEditor:CKEditorControl>--%>
                            </tr>
                    <tr>
                    <td>Tệp đính kèm</td>
                    <td><asp:FileUpload runat="server" ID="flAttachment" AllowMultiple="true" Width="300px"/></td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align: right">
                        <asp:Button ID="btnSend" runat="server" Text="Gửi" OnClick="btnSend_Click" Width="80px" BackColor="#006666" Font-Bold="True" ForeColor="White" Height="30px" />
                        <asp:Button ID="btnCancel" runat="server" Text="Huỷ" Width="80px" BackColor="#336699" Font-Bold="True" ForeColor="White" Height="30px" />
                    </td>
                </tr>
            </table>
        </center>
        </div>
