<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Website_GuiThuDienTu.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<%--<div style="width:90%; min-height:500px; border: 1px solid red; margin:auto; padding: 20px" >
<div id="dauTrang" >
            <div id="dangXuat">
                    <ul>
                        <li><asp:Literal ID="ltrTenNguoiDung" runat="server"></asp:Literal> </li>
                        <li >/<asp:LinkButton ID="lbtDangXuat" runat="server" CausesValidation="false" OnClick="lbnDangXuat_Click">Đăng Xuất</asp:LinkButton></li>

                    </ul>
            </div>
         </div>
        <div id="thanTrang">
            <div><h1>THÔNG TIN CỦA BẠN</h1></div>
            <div id="BangThongTin">
                <div class="ThongTin">
                    Tên của bạn: <asp:Literal ID="ltrTenTK" runat="server"></asp:Literal>
                </div>
                <div class="ThongTin">
                    Email của bạn: <asp:Literal ID="ltrEmail" runat="server"></asp:Literal>
                </div>
                <div class="ThongTin">
                    Chủ đề bạn quan tâm:
                   <!--<asp:TextBox ID="tbChuDeQuanTam" runat="server"></asp:TextBox>-->
                    <table class="tbChuDeDangKy">
                        <tr>
                            <th class="cotMa">Mã Chủ Đề</th>
                            <th class="cotTen">Tên Chủ Đề</th>
                        </tr>
                        <asp:Literal ID="ltrChuDeDangKy" runat="server"></asp:Literal>
                    </table>
                    
                </div>
                <div class="ThongTin">
                    Chọn chủ dề bạn muốn nhận tại đây:
                        <div class="row">
                            <div class="left">Tên Chủ Đề</div>
                            <div class="right">
                                <asp:ListBox ID="lbChuDe" runat="server" SelectionMode="Multiple" Width="203px"></asp:ListBox>
                            </div>
                        </div>
                    
                        <div class="row">
                            <div class="left">&nbsp;</div>
                            <div class="right">
                                <asp:LinkButton ID="lbtCapNhat" runat="server" CssClass="btDangNhap" OnClick="lbtCapNhat_Click">Cập nhật</asp:LinkButton>
                            </div>
                        </div>
                </div>

                 <div class="ThongTin">
                    Hủy chủ đề muốn nhận
                        <div class="row">
                            <div class="left">Tên Chủ Đề</div>
                            <div class="right">
                                <asp:ListBox ID="lbChuDeHuy" runat="server" SelectionMode="Multiple" Width="193px"></asp:ListBox>
                            </div>
                        </div>
                    
                        <div class="row">
                            <div class="left">&nbsp;</div>
                            <div class="right">
                                <asp:LinkButton ID="lbtHuy" runat="server" CssClass="btHuy" OnClick="lbtHuy_Click" >Hủy</asp:LinkButton>
                            </div>
                        </div>
                     <asp:Literal ID="ltrThongBao" runat="server">dfgfgf</asp:Literal>
                </div>
                <div class="ThongTin">
                     <div style="width: 400px; float: left; text-align: center;">
                        <table>
                            <tr>
                                <td colspan="2">ĐỔI MẬT KHẨU</td>
                            </tr>
                            <tr>
                                <td>Mật khẩu cũ</td>
                                <td><asp:TextBox ID="txtOldPassword" Width="285px" runat="server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>Mật khẩu mới</td>
                                <td><asp:TextBox ID="txtNewPassword1" Width="285px" runat="server" Height="19px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>Mật khẩu mới</td>
                                <td><asp:TextBox ID="txtNewPassword2" Width="285px" runat="server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td></td>
                                <td>
                                    <asp:Button ID="btnChange" runat="server" Text="Xác nhận" Width="80px" OnClick="btnChange_Click" />
                                    <asp:Button ID="btnUserManage" runat="server" Text="Huỷ bỏ" Width="80px" />
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
            </div>    
        </div>
    </div>--%>

  
           
            <div class="main">
                <center>
                    <div style="width: 400px; float: left; text-align: center;">
                        <p>CHỌN CHỦ ĐỀ</p>
                        <asp:DropDownList runat="server" ID="drdnSubject1"></asp:DropDownList>
                        <asp:Button runat="server" ID="btnAddSubject" Text="Đăng ký" Width="80px" OnClick="btnAddSubject_Click"/>
                    </div>
                    <div style="width: 400px; float: left; text-align: center;">
                        <p>HUỶ CHỦ ĐỀ</p>
                        <asp:DropDownList runat="server" ID="drdnSubject2"></asp:DropDownList>
                        <asp:Button runat="server" ID="btnDeleteSubject" Text="Huỷ bỏ" Width="80px" OnClick="btnDeleteSubject_Click"/>
                    </div>
                    <div style="width: 400px; float: left; text-align: center;">
                        <table>
                            <tr>
                                <td colspan="2">ĐỔI MẬT KHẨU</td>
                            </tr>
                            <tr>
                                <td>Mật khẩu cũ</td>
                                <td><asp:TextBox ID="txtOldPassword" Width="160px" runat="server"  CssClass="password" TextMode="Password"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>Mật khẩu mới</td>
                                <td><asp:TextBox ID="txtNewPassword1" Width="160px" CssClass="password" TextMode="Password" runat="server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>Mật khẩu mới</td>
                                <td><asp:TextBox ID="txtNewPassword2" Width="160px" runat="server"  CssClass="password" TextMode="Password" ></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td></td>
                                <td>
                                    <asp:Button ID="btnChange" runat="server" Text="Xác nhận" Width="80px" OnClick="btnChange_Click" />
                                    <asp:Button ID="btnUserManage" runat="server" Text="Huỷ bỏ" Width="80px" />
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div style="width: 1200px; height: 100px; background: #efefef"></div>
                </center>
            </div>
            <div class="bottom">
                <center>
                    <img src="Images/footer.png"
                </center>
            </div>
        
</asp:Content>
