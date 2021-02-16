<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Report_Parent.aspx.cs" Inherits="Project.Report_Parent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            height: 31px;
        }
        .auto-style5 {
            width: 322px;
        }
        .auto-style6 {
            height: 31px;
            width: 322px;
        }
        .auto-style7 {
            height: 33px;
        }
        .auto-style8 {
            height: 32px;
        }
        .auto-style9 {
            width: 322px;
            height: 28px;
        }
        .auto-style10 {
            height: 28px;
        }
        .auto-style11 {
            width: 164px;
        }
        .auto-style12 {
            height: 31px;
            width: 164px;
        }
        .auto-style13 {
            height: 28px;
            width: 164px;
        }
        .auto-style14 {
            width: 125px;
        }
        .auto-style15 {
            width: 754px;
        }
        .auto-style16 {
            width: 170px;
        }
        .auto-style17 {
            width: 755px;
        }
        .auto-style18 {
            width: 170px;
            height: 138px;
        }
        .auto-style19 {
            width: 755px;
            height: 138px;
        }
        .auto-style20 {
            height: 138px;
        }
        .Risk{
            background-color : #CD5C5C;
        }
        .Safe{
            background-color : lightgreen;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <table style="width:100%;">
        <tr>
            <td>&nbsp;</td>
            <td><h1 class="h3 mb-3 font-weight-normal" style="text-align:center;">ผลคะแนน</h1> </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style17">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style18"></td>
                        <td class="auto-style19">
                            <table style="width:100%;" border="1">
                                <tr>
                                    <td style="text-align:center;" class="auto-style5">หมวดประเมินสำหรับผู้ปกครอง</td>
                                    <td style="text-align:center;">คะแนนสูงสุด</td>
                                    <td style="text-align:center;" class="auto-style11">คะแนนมาตรฐาน</td>
                                    <td style="text-align:center;">คะแนนที่ได้</td>
                                </tr>
                                <tr>
                                    <td class="auto-style6" style="text-align:left;">อาการขาดสมาธิ</td>
                                    <td class="auto-style2" style="text-align:center;">27</td>
                                    <td class="auto-style12" style="text-align:center;">
                                        16</td>
                                    <td style="text-align:center;" class="auto-style2">
                                        <asp:Panel ID="Panel1" runat="server">
                                            <asp:Label ID="Label1" runat="server"></asp:Label>
                                            </asp:Panel>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="text-align:left;" class="auto-style9">อาการซนอยู่ไม่นิ่ง / หุนหันพลันแล่น</td>
                                    <td style="text-align:center;" class="auto-style10">27</td>
                                    <td style="text-align:center;" class="auto-style13">
                                        13</td>
                                    <td style="text-align:center;">
                                        <asp:Panel ID="Panel2" runat="server">
                                            <asp:Label ID="Label2" runat="server"></asp:Label>
                                            </asp:Panel>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="text-align:left;" class="auto-style5">อาการดื้อ/ต่อต้าน</td>
                                    <td style="text-align:center;">24</td>
                                    <td style="text-align:center;" class="auto-style11">
                                        15</td>
                                    <td style="text-align:center;">
                                        <asp:Panel ID="Panel3" runat="server">
                                            <asp:Label ID="Label3" runat="server"></asp:Label>
                                        </asp:Panel>
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td class="auto-style20"></td>
                    </tr>
                    <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style17">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <table style="width: 100%;">
        <tr>
            <td class="auto-style7"></td>
            <td class="auto-style7">
                <table style="width: 100%;">
                    <tr>
                        <td></td>
                        <td><tr>
                        <td></td>
                        <td>
                            <asp:Label ID="Label6" runat="server"></asp:Label>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td class="auto-style14">&nbsp;</td>
                        <td class="auto-style15">
                            <asp:Label ID="Label4" runat="server"></asp:Label>
                        &nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style14">&nbsp;</td>
                        <td class="auto-style15">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label5" runat="server"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr></td>
                        
                        <td></td>
                    </tr>

                </table>
            </td>
            <td class="auto-style7"></td>
        </tr>
        <tr>
            <td class="auto-style8"></td>
            <td class="auto-style8">
                </td>
            <td class="auto-style8"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <table style="width:100%;">
                    <tr>
                        <td style="text-align:center;">
                            <asp:Button ID="Button1" runat="server" Text="ประวัติผลคะแนน" OnClick="Button1_Click" CssClass="btn btn-primary" Width="169px" />
                        </td>
                        <td style="text-align:center;">
                            <asp:Button ID="Button2" runat="server" Text="หน้าหลัก" CssClass="btn btn-primary" Width="171px" OnClick="Button2_Click" />
                        </td>
                    </tr>
                </table>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>
