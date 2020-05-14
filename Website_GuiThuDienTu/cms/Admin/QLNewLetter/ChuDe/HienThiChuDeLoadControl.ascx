<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HienThiChuDeLoadControl.ascx.cs" Inherits="Website_GuiThuDienTu.cms.Admin.QLNewLetter.ChuDe.HienThiChuDeLoadControl" %>
<div class="contaner">
    <div class ="head">
    Danh sách các chủ đề đã tạo
  
        <a class="btThemMoi" href="Adminn.aspx?modul=QLNewLetter&&modulphu=ChuDe&&thaotac=ThemMoiChuDe" style="text-decoration:none; color:#b57e0c"><img src="../../../../Images/icons8-add-10.png" />Thêm mới</a>
    
        
</div>

<%--    <asp:Repeater ID="rpChuDe" runat="server">
        <HeaderTemplate>
          <table border="1" cellspacing="0" rules="all" width="400px" style="text-align:center">
                <tr>
                  <th colspan="3" style="font-size:large; color:#0a976c"><strong>DANH SÁCH CHỦ ĐỀ</strong></th>
              </tr>
          <tr>
              <th>Mã Chủ Đề</th>
              <th>Tên Chủ Đề</th>
          </tr>
      </HeaderTemplate>
          <ItemTemplate>
              <tr>
                  <td>
                      <asp:Label ID="MaCD" runat="server" Text='<%# Eval("iPK_MaCD") %>'></asp:Label>
                  </td>
                   <td>
                      <asp:Label ID="TenCD" runat="server" Text='<%# Eval("sTenCD") %>'></asp:Label>
                  </td>
                  <td>
                      <asp:Label ID="TrangThai" runat="server" Text='<%# Eval("sCondition") %>'></asp:Label>
                  </td>
                  <td>
                      <a href="Adminn.aspx?modul=ChuDe&&thaotac=ChinhSuaChDe&&id='"+data+"'"></a>
                  </td>
              </tr>
          </ItemTemplate>
             <FooterTemplate>
        </table>

    </FooterTemplate>
    </asp:Repeater>
<div >
    <span style="font-weight: bold">Danh sách tài khoản theo chủ đề</span>
    <asp:Literal ID="ltrDanhSachTaiKhoan" runat="server"> </asp:Literal>

</div>--%>
    <div class="khungChuaBang">
    <table class="tbChuDe">
        <tr>
            <th class="cotMa">Mã</th>
            <th class="cotTen">Tên Chủ Đề</th>
            <th class="cotCongCu">Cột Công Cụ</th>
        </tr>
        <asp:Literal ID="ltrChuDe" runat="server"></asp:Literal>
    </table>
</div>

</div>