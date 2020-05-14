<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ThemMoiLetterLoadControl.ascx.cs" Inherits="Website_GuiThuDienTu.cms.Admin.QLNewLetter.Letter.ThemMoiLetterLoadControl" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<div class="head">
    Soạn Email mới
</div>
<div class ="FormThemMoi">
    <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
    <div class="thongTin">
        <div class="tenTruong">Chủ Đề</div>
        <div class="oNhap">
            <asp:DropDownList ID="ddlChuDe" runat="server"></asp:DropDownList>
        </div>
    </div>

    <div class="thongTin">
        <div class="tenTruong">Subject</div>
        <div class="oNhap">
            <asp:TextBox ID="tbSubject" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Ngày viết</div>
        <div class="oNhap">
            <asp:TextBox ID="tbNgayViet" runat="server" CssClass="date" TextMode="Date"></asp:TextBox>
        </div>
    </div>
      <div class="thongTin">
        <div class="tenTruong">Người viết</div>
        <div class="oNhap">
            <asp:DropDownList ID="ddlNguoiViet" runat="server"></asp:DropDownList>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Nội dung</div>
        <div class="oNhap">
  <%--          <CKEditor:CKEditorControl ID="tbBody" runat="server">
</CKEditor:CKEditorControl>--%>
<%--              <CKEditor:CKEditorControl ID="tbBody" runat="server" FilebrowserImageBrowseUrl="ckeditor/ckfinder/ckfinder.aspx?type=Images&path=Images"></CKEditor:CKEditorControl>--%>
            <asp:textbox id="tbBody" runat="server" textmode="multiline" height="150px"></asp:textbox>
             </div>
    </div>

    <div class="thongTin">
        <div class="tenTruong">&nbsp</div>
        <div class="oNhap">
            <asp:CheckBox ID="cbThemNhieuEmail" runat="server" Text="Tiếp tục tạo Email mới sau tạo email" />
        </div>
    </div>

    <div class="thongTin">
        <div class="tenTruong">&nbsp</div>
        <div class="oNhap">
            <asp:Button ID="btnThemMoi" runat="server" Text="Thêm Mới" OnClick="btnThemMoi_Click" CssClass="btnThemMoi"/>
            <asp:Button ID="btnHuy" runat="server" Text="Hủy" OnClick="btnHuy_Click" CssClass="btnHuy"/>
        </div>
    </div>
</div>
