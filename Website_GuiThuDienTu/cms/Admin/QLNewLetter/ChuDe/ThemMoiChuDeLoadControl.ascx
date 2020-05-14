<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ThemMoiChuDeLoadControl.ascx.cs" Inherits="Website_GuiThuDienTu.cms.Admin.QLNewLetter.ChuDe.ThemMoiChuDeLoadControl" %>
<div class="head">
    Thêm mới, chỉnh sửa chủ đề
</div>
<div class="FormThemMoi">
    <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>

    <div class="thongTin">
        <div class="tenTruong">Tên chủ đề</div>
        <div class="oNhap">
            <asp:TextBox ID="tbTenChuDe" runat="server" Width="150px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1"  Width="160px" runat="server" ErrorMessage="*" ControlToValidate="tbTenChuDe" Display="Dynamic" SetFocusOnError="true"></asp:RequiredFieldValidator>
        </div>
         <div class="tenTruong">Trạng Thái</div>
         <div  class="oNhap">
        <asp:DropDownList ID="drdnCondition" runat="server" Width="160px"></asp:DropDownList>
       </div>
    </div>

    <div class="thongTin">
        <div class="tenTruong">&nbsp</div>
        <div class="oNhap">
            <asp:CheckBox ID="cbThemNhieuChuDe" runat="server" Text="Tiếp tục tạo chủ đề khác sau khi tạo chủ đề" />
        </div>
       
             </div>
        <div class="thongTin">
        <div class="tenTruong">&nbsp</div>
        <div class="oNhap">
            <asp:Button ID="btnThemMoi" runat="server" Text="Thêm mới" CssClass="btnThemMoi" OnClick="btnThemMoi_Click"/>
            <asp:Button ID="btnHuy" runat="server" Text="Hủy" CssClass="btnHuy" OnClick="btnHuy_Click" CausesValidation="false" />
        </div>
    </div>
</div>