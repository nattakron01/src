<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Report_Teacher.aspx.cs" Inherits="Project.Report_Teacher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            height: 31px;
        }
        .auto-style3 {
            width: 170px;
        }
        .auto-style4 {
            width: 754px;
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
        .auto-style12 {
            width: 170px;
            height: 138px;
        }
        .auto-style13 {
            width: 754px;
            height: 138px;
        }
        .auto-style14 {
            height: 138px;
        }
        .auto-style16 {
            height: 37px;
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
                <table class="w-100">
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td class="auto-style4">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style12"></td>
                        <td class="auto-style13">
                            <table style="width:100%;" border="1">
                                <tr>
                                    <td style="text-align:center;" class="auto-style5">หมวดประเมินสำหรับครู</td>
                                    <td style="text-align:center;">คะแนนสูงสุด</td>
                                    <td style="text-align:center;">คะแนนมาตรฐาน</td>
                                    <td style="text-align:center;">คะแนนที่ได้</td>
                                </tr>
                                <tr>
                                    <td class="auto-style6" style="text-align:left;">อาการขาดสมาธิ</td>
                                    <td class="auto-style2" style="text-align:center;">27</td>
                                    <td class="auto-style2" style="text-align:center;">
                                        23</td>
                                    <td style="text-align:center;">
                                        <asp:Panel ID="Panel1" runat="server">
                                            <asp:Label ID="Label1" runat="server"></asp:Label>
                                        </asp:Panel>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="text-align:left;" class="auto-style9">อาการซนอยู่ไม่นิ่ง / หุนหันพลันแล่น</td>
                                    <td style="text-align:center;" class="auto-style10">27</td>
                                    <td style="text-align:center;" class="auto-style10">
                                        16</td>
                                    <td style="text-align:center;">
                                        <asp:Panel ID="Panel2" runat="server">
                                            <asp:Label ID="Label2" runat="server"></asp:Label>
                                        </asp:Panel>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="text-align:left;" class="auto-style5">อาการดื้อ/ต่อต้าน</td>
                                    <td style="text-align:center;">24</td>
                                    <td style="text-align:center;">
                                        11</td>
                                    <td style="text-align:center;">
                                        <asp:Panel ID="Panel3" runat="server">
                                            <asp:Label ID="Label3" runat="server"></asp:Label>
                                        </asp:Panel>
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td class="auto-style14"></td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td class="auto-style4">&nbsp;</td>
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
                        <td>
                            <tr>
                                <td></td>
                                <td>
                                    <asp:Label ID="Label6" runat="server"></asp:Label>
                                </td>
                            <td></td>
                    </tr>
                    <tr>
                        <td class="auto-style16"></td>
                        <td class="auto-style16">
                            <asp:Label ID="Label4" runat="server"></asp:Label>
                        &nbsp;</td>
                        <td class="auto-style16"></td>
                    </tr>
                    <tr>
                        <td class="auto-style7"></td>
                        <td class="auto-style7">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label5" runat="server"></asp:Label>
                        </td>
                        <td class="auto-style7"></td>
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

