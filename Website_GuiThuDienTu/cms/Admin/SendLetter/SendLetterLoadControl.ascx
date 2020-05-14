<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SendLetterLoadControl.ascx.cs" Inherits="Website_GuiThuDienTu.cms.Admin.SendLetter.SendLetterLoadControl" %>
<div class="container">
    <div style="clear:both; height: 20px;"></div>
    <div class="cottrai">
        <div class="head">
            Send Letter
        </div>
        <ul>
            <li><a class="<%=DanhDau("SendLetter","HienThiSend") %>" href="Adminn.aspx?modul=SendLetter&&thaotac=HienThiSend">Chọn Chủ Đề</a></li>
        </ul>
        </div>
    <div class="cotphai">
     <asp:PlaceHolder ID="plSendLetters" runat="server"></asp:PlaceHolder> 
    </div>
    <div class="cb">
        <!---->
    </div>
  </div>
   