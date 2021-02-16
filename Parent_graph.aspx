<%@ Page Title="" Language="C#" MaintainScrollPositionOnPostback="true" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Parent_graph.aspx.cs" Inherits="Project.Parent_graph" %>
<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="aspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            height: 30px;
        }
        .auto-style3 {
            width: 124px;
        }
        .auto-style4 {
            height: 30px;
            width: 124px;
        }
        .auto-style5 {
            width: 865px;
        }
        .auto-style6 {
            height: 30px;
            width: 865px;
        }
        .auto-style7 {
            width: 124px;
            height: 32px;
        }
        .auto-style8 {
            height: 32px;
        }
        .auto-style9 {
            height: 32px;
            width: 865px;
        }
        .auto-style10 {
            height: 127px;
        }
        .auto-style11 {
            height: 127px;
            width: 288px;
        }
        .auto-style12 {
            height: 127px;
            width: 313px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style3">
                <asp:Button ID="Button2" runat="server" Text="ย้อนกลับ" OnClick="Button2_Click" CssClass="btn btn-primary" /></td>
            <td class="auto-style5">
                <div><h1 class="h3 mb-3 font-weight-normal" style="text-align:center;">ประวัติผลคะแนน</h1> </div>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style5">&nbsp;</td>
            <td></td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">
                <asp:Label ID="Label2" runat="server" Text="ชื่อผู้ที่รับการประเมิน : "></asp:Label>
                <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7"></td>
            <td class="auto-style9"></td>
            <td class="auto-style8"></td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style6">
                <asp:Label ID="Label4" runat="server" Text="*" ForeColor="Red"></asp:Label>
                การประเมินจากกราฟสามารถประเมินได้ดังนี้
                <br />
&nbsp;&nbsp; - ตลอดการประเมิน กราฟคะแนนทั้ง 2 ฝั่งยังเท่ากับเส้นคะแนนมาตรฐานหรือมากกว่า ควรปรึกษาแพทย์เพราะมีความเสี่ยงที่จะมีอาการในด้านนั้น ๆ
                <br />
&nbsp;&nbsp; - ตลอดการประเมิน กราฟคะแนนทั้ง 2 ฝั่งน้อยกว่าเส้นคะแนนมาตรฐาน แสดงว่าปกติไม่มีความเสี่ยงที่จะเกิดอาการ <br />
&nbsp;&nbsp; - ตลอดการประเมิน กราฟคะแนนทั้ง 2 ฝั่งมีคะแนนที่ต่างกันเช่น ฝั่งผู้ปกครองคะแนนสูงกว่าคะแนน&nbsp; มาตรฐานแต่ฝั่งครูต่ำกว่ามาตรฐาน แสดงว่าปกติแต่เด็กที่ถูกประเมินอาจจะซนกว่าปกติเมื่ออยู่ในอีกสถานที่</td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style5">&nbsp;</td>
            <td></td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style6">
               
                <table class="w-100" style="table-layout:fixed; width:auto;">
                    <tr>
                        <td style="text-align:center;">

                            <h4>หมวด อาการขาดสมาธิ</h4></td>
                    </tr>
                    <tr>
                        <td>
                            <aspx:Chart ID="Chart1" runat="server" Width="859px">
                                <ChartAreas>
                                    <aspx:ChartArea Name="ChartArea1">
                                        <AxisX>
                                            <MajorGrid LineColor="LightGray"/>
                                        </AxisX>
                                        <AxisY>
                                            <MajorGrid LineColor="LightGray"/>
                                        </AxisY>
                                    </aspx:ChartArea>
                                </ChartAreas>
                                <Legends>
                                    <aspx:Legend Name="Legend1" Docking="Bottom"></aspx:Legend>
                                </Legends>
                            </aspx:Chart>
                        </td>
                       </tr>
                    <tr>
                        <td>
                            <table style="width: 100%;">
                                <tr>
                                    <td class="auto-style11">
                            <asp:Panel ID="Panel1" runat="server" Height="120px" Width="221px">
        <asp:RadioButton ID="all" runat="server" Checked="true" GroupName="Select" Text="ทั้งหมด" AutoPostBack="true"/>
        <br />
        
        </asp:Panel>
                        </td>
                        <td class="auto-style12">
                            <asp:Panel ID="Panel2" runat="server">
                                <asp:RadioButton ID="ParentRadio" runat="server" GroupName="Select" Text="ผู้ปกครอง" AutoPostBack="true"/>
        <br />
        <asp:CheckBox ID="P1" runat="server" Enabled="false" Visible="false" Checked="true" AutoPostBack="true"/>
        <br />
        <asp:CheckBox ID="P2" runat="server" Enabled="false" Visible="false" AutoPostBack="true"/>
        <br />
        <asp:CheckBox ID="P3" runat="server" Enabled="false" Visible="false" AutoPostBack="true"/>
        <br />
                            </asp:Panel>
                        </td>
                        <td class="auto-style10">
                            <asp:Panel ID="Panel3" runat="server" Height="125px">
                                <asp:RadioButton ID="TeacherRadio" runat="server" GroupName="Select" Text="ครู" AutoPostBack="true" />
        <br />
        <asp:CheckBox ID="T1" runat="server" Enabled="false" Visible="false" AutoPostBack="true" Checked="true" />
        <br />
        <asp:CheckBox ID="T2" runat="server" Enabled="false" Visible="false" AutoPostBack="true"/>
                                <br />
                                <asp:CheckBox ID="T3" runat="server" AutoPostBack="true" Enabled="false" Visible="false" />
    </asp:Panel>
                        </td>
                                </tr>

                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>

                        </td>
                    </tr>
                    <tr>
                        <td>

                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>

                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:center;">
                            <h4>หมวด อาการซนอยู่ไม่นิ่ง / หุนหันพลันแล่น</h4>
                    </tr>
                    <tr>
                        <td>
                            <aspx:Chart ID="Chart2" runat="server" Width="860px">
                                <ChartAreas>
                                    <aspx:ChartArea Name="ChartArea1">
                                        <AxisX>
                                            <MajorGrid LineColor="LightGray"/>
                                        </AxisX>
                                        <AxisY>
                                            <MajorGrid LineColor="LightGray"/>
                                        </AxisY>
                                    </aspx:ChartArea>
                                </ChartAreas>
                                <Legends>
                                    <aspx:Legend Name="Legend1" Docking="Bottom"></aspx:Legend>
                                </Legends>
                            </aspx:Chart>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table class="w-100">
                                <tr>
                                    <td class="auto-style11">
                                        <asp:Panel ID="Panel4" runat="server" Height="120px" Width="221px">
                                            <asp:RadioButton ID="all2" runat="server" AutoPostBack="true" Checked="true" GroupName="Select2" Text="ทั้งหมด" />
        <br />
        
                                        </asp:Panel>
                                    </td>
                                    <td class="auto-style12">
                                        <asp:Panel ID="Panel5" runat="server">
                                            <asp:RadioButton ID="ParentRadio2" runat="server" AutoPostBack="true" GroupName="Select2" Text="ผู้ปกครอง" />
        <br />
                                            <asp:CheckBox ID="P4" runat="server" AutoPostBack="true" Checked="true" Enabled="false" Visible="false" />
        <br />
                                            <asp:CheckBox ID="P5" runat="server" AutoPostBack="true" Enabled="false" Visible="false" />
        <br />
                                            <asp:CheckBox ID="P6" runat="server" AutoPostBack="true" Enabled="false" Visible="false" />
        <br />
                                        </asp:Panel>
                                    </td>
                                    <td class="auto-style10">
                                        <asp:Panel ID="Panel6" runat="server" Height="125px">
                                            <asp:RadioButton ID="TeacherRadio2" runat="server" AutoPostBack="true" GroupName="Select2" Text="ครู" />
        <br />
                                            <asp:CheckBox ID="T4" runat="server" AutoPostBack="true" Enabled="false" Visible="false" Checked="true" />
        <br />
                                            <asp:CheckBox ID="T5" runat="server" AutoPostBack="true" Enabled="false" Visible="false" />
                                            <br />
                                            <asp:CheckBox ID="T6" runat="server" AutoPostBack="true" Enabled="false" Visible="false" />
                                        </asp:Panel>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>

                        </td>
                    </tr>
                    <tr>
                        <td>

                        </td>
                    </tr>
                    <tr>
                        <td>

                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:center;">
                            <h4>หมวด อาการดื้อ/ต่อต้าน</h4></td>
                    </tr>
                    <tr>
                        <td>
                            <aspx:Chart ID="Chart3" runat="server" Width="859px">
                                <ChartAreas>
                                    <aspx:ChartArea Name="ChartArea1">
                                        <AxisX>
                                            <MajorGrid LineColor="LightGray"/>
                                        </AxisX>
                                        <AxisY>
                                            <MajorGrid LineColor="LightGray"/>
                                        </AxisY>
                                    </aspx:ChartArea>
                                </ChartAreas>
                                <Legends>
                                    <aspx:Legend Name="Legend1" Docking="Bottom"></aspx:Legend>
                                </Legends>
                            </aspx:Chart>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table style="width: 100%;">
                                <tr>
                                    <td class="auto-style11">
                                        <asp:Panel ID="Panel7" runat="server" Height="120px" Width="221px">
                                            <asp:RadioButton ID="all3" runat="server" AutoPostBack="true" Checked="true" GroupName="Select3" Text="ทั้งหมด" />
        <br />
        
                                        </asp:Panel>
                                    </td>
                                    <td class="auto-style12">
                                        <asp:Panel ID="Panel8" runat="server">
                                            <asp:RadioButton ID="ParentRadio3" runat="server" AutoPostBack="true" GroupName="Select3" Text="ผู้ปกครอง" />
        <br />
                                            <asp:CheckBox ID="P7" runat="server" AutoPostBack="true" Checked="true" Enabled="false" Visible="false" />
        <br />
                                            <asp:CheckBox ID="P8" runat="server" AutoPostBack="true" Enabled="false" Visible="false" />
        <br />
                                            <asp:CheckBox ID="P9" runat="server" AutoPostBack="true" Enabled="false" Visible="false" />
        <br />
                                        </asp:Panel>
                                    </td>
                                    <td class="auto-style10">
                                        <asp:Panel ID="Panel9" runat="server" Height="125px">
                                            <asp:RadioButton ID="TeacherRadio3" runat="server" AutoPostBack="true" GroupName="Select3" Text="ครู" />
        <br />
                                            <asp:CheckBox ID="T7" runat="server" AutoPostBack="true" Enabled="false" Visible="false" Checked="true" />
        <br />
                                            <asp:CheckBox ID="T8" runat="server" AutoPostBack="true" Enabled="false" Visible="false" />
                                            <br />
                                            <asp:CheckBox ID="T9" runat="server" AutoPostBack="true" Enabled="false" Visible="false" />
                                        </asp:Panel>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">
                        </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
