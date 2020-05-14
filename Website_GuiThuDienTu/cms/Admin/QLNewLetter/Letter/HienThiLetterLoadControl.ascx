<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HienThiLetterLoadControl.ascx.cs" Inherits="Website_GuiThuDienTu.cms.Admin.QLNewLetter.Letter.HienThiLetterLoadControl" %>

<%--<div class="contaner">
    <div>
         <table class="style1">
              
            <tr>
                <td class="style2">
                    Mã Letters
                </td>
                <td>
                    <asp:TextBox ID="txtMaLetter" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
             
                <td class="style2">
                    Subject:
                </td>
                <td>
                    <asp:TextBox ID="txtSubj" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Ngày Tạo:
                </td>
                <td>
                    <asp:TextBox ID="txtNgayTao" runat="server"></asp:TextBox>
                </td>
          </tr>
            <tr>
                <td colspan="2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" Height="23px"
                        Width="46px" />
                    &nbsp;
                    <asp:Button ID="btncancel" runat="server" Text="Cancel" Height="23px" Width="49px"
                        OnClick="btncancel_Click" />
                    &nbsp;
                </td>
            </tr>
        </table>
    </div>--%>
  <%--  <div>
         <asp:Repeater ID="rpLetters" runat="server" OnItemCommand="rpLetters_ItemCommand">
        <HeaderTemplate>
          <table border="1" cellspacing="0" rules="all">
                <tr>
                  <th colspan="4" style="font-size:large; color:#0a976c"><strong>DANH SÁCH LETTERS</strong></th>
              </tr>
          <tr>
              <th>Mã Letters</th>
              <th>Chủ Đề</th>
              <th>Ngày Tạo</th>
              <th>Công Cụ</th>
          </tr>
      </HeaderTemplate>
          <ItemTemplate>
              <tr>
                   <td>
                        <asp:Label ID="lbMa" Visible="false" runat="server" Text='<%#Eval("id") %>'></asp:Label>
                      <asp:Label ID="maLetter" runat="server" Text='<%# Eval("iPK_LetterID") %>'></asp:Label>
                   <asp:TextBox ID="lbltxtmaLetter" runat="server" Visible="false" Text='<%#Bind("iPK_LetterID") %>'></asp:TextBox>
                        </td>
                  <td>
                      <asp:Label ID="TenLetter" runat="server" Text='<%# Eval("sSubject ") %>'></asp:Label>
                    <asp:TextBox ID="lbtxtTenLetter" runat="server" Visible="false" Text='<%#Bind("sSubject") %>'></asp:TextBox>
                  </td>
                     <td>
                      <asp:Label ID="NgayTao" runat="server" Text='<%# Eval("dNgayTao") %>'></asp:Label>
                    <asp:TextBox ID="lbtxtNgayTao" runat="server" Visible="false" Text='<%#Bind("dNgayTao") %>'></asp:TextBox>
                     </td>
          <td>
                        <asp:ImageButton ID="imgedit" runat="server" CommandName="Edit" ImageUrl="../../../../Images/icons8-erase-25.png"
                            Height="25" Width="25"  />
                 <asp:ImageButton ID="imgdelete" runat="server" CommandName="Delete" ImageUrl="../../../../Images/icons8-waste-25.png"
                            Height="25" Width="25" />
              
                    </td>
              </tr>
          </ItemTemplate>
             <FooterTemplate>
        </table>

    </FooterTemplate>
    </asp:Repeater>
    </div>
</div>--%>


<div class="head">
    Danh sách các Email đã tạo <a href="Adminn.aspx?modul=QLyLetter&&modulphu=Letter&&thaotac=ThemMoiLetter" style="text-decoration:none; color:#b47f14" ><img src="../../../../Images/icons8-add-10.png" /> Thêm Mới</a>
</div>



<div class="khungChuaBang">
    <table class="tbLetters">
        <tr>
            <th class="cotMa">Mã</th>
            <th class="cotSubject">Subject</th>
            <th class="cotNgayTao">Ngày tạo</th>
            <th class="cotCongCu">Cột công cụ</th>
        </tr>
        <asp:Literal ID="ltrEmail" runat="server"></asp:Literal>
    </table>
</div>