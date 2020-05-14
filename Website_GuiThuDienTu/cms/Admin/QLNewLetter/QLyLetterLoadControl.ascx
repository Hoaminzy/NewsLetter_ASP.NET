<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="QLyLetterLoadControl.ascx.cs" Inherits="Website_GuiThuDienTu.cms.Admin.QLNewLetter.QLyLetterLoadControl" %>


<div class="container">
    <div class="cottrai"">
        <div class="head">Danh Sách</div>
         <ul>
            <li><a class="<%=DanhDau("QLyLetter","ChuDe","") %>"  href="Adminn.aspx?modul=QLyLetter&&modulphu=ChuDe">Danh Sách Chủ Đề</a></li>
         <%--    <li><a class="<%=DanhDau("QLyLetter","Letter","") %>"  href="Adminn.aspx?modul=QLyLetter&&modulphu=Letter">Danh Sách Letter</a></li>--%>
        </ul>
        <div class="head">Chức Năng</div>
          <ul>
            <li><a class="<%=DanhDau("QLyLetter","ChuDe","ThemMoiChuDe") %>" href="Adminn.aspx?modul=QLyLetter&&modulphu=ChuDe&&thaotac=ThemMoiChuDe">Thêm Mới Chủ Đề</a></li>
          <%--   <li><a class="<%=DanhDau("QLyLetter","Letter","ThemMoiLetter") %>" href="Adminn.aspx?modul=QLyLetter&&modulphu=Letter&&thaotac=ThemMoiLetter">Thêm Mới Letter</a></li>--%>
        </ul>
    </div>
    <div class="cotphai" >
       
    <asp:PlaceHolder ID="plLetterLoadControl" runat="server"></asp:PlaceHolder>
    </div>
    <div class="cb"></div>
</div>