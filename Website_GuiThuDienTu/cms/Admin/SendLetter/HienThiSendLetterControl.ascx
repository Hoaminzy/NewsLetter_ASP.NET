<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HienThiSendLetterControl.ascx.cs" Inherits="Website_GuiThuDienTu.cms.Admin.SendLetter.HienThiSendLetterControl" %>
   
 <div style="width: 400px; float: left; text-align: center;">
        <p style="font-weight:bold; color:#034e32">Chọn Chủ Đề Bạn Muốn Gửi</p>
       <%--  <asp:Button runat="server" ID="btnSendEmail" Text="Chọn chủ đề" OnClick="btnSendEmail_Click"/>--%>
      <asp:ListBox runat="server" ID="lstbSubject" OnSelectedIndexChanged="lstbSubject_SelectedIndexChanged" Width="350px" AutoPostBack="true" Visible="true"></asp:ListBox>
    </div>


   