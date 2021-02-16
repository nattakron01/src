<%@ Page Title="" Language="C#" Culture="th-TH" UICulture="th-TH" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Child_List.aspx.cs" Inherits="Project.Child_List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .modalpopup{
            background-color : #ffffff;
            width: 800px;
            border: 3px solid #000000;
            height: 450px;
        }
        .modalpopup.header{
            background-color : #ffffff;
        }
        .auto-style3 {
            width: 133px;
        }
        .auto-style4 {
            margin-left: 0px;
        }
        .auto-style5 {
            width: 855px;
        }
    </style>

    <meta charset="utf-8" />
    <link href="css/bootstrap.css" rel="stylesheet" />
    <script src="js/jquery-3.3.1.min.js"></script>
    <script src="css/bootstrap.min.css"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <div><h1 class="h3 mb-3 font-weight-normal" style="text-align:center;">รายชื่อเด็ก</h1> </div>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Project_Senior %>" SelectCommand="SELECT name, surname, birthday, gender, child_activation_invitecode FROM child WHERE (child_id IN (SELECT child_child_id FROM guardian_child WHERE (guardian_email = @email))) AND (status = '1')">
        <SelectParameters>
            <asp:SessionParameter Name="email" SessionField="User_Email" />
        </SelectParameters>
    </asp:SqlDataSource>
    <script type="text/javascript">
        function ShowPopup() {
            $("#Select").modal("show");
        }

        function Confirm() {
            var confirm_value = document.createElement("INPUT");

            confirm_value.type = "hidden";
            confirm_value.name = "confirm_value";

            if (confirm("การเพิกถอนจะทำให้ท่านไม่สามารถประเมินหรือดูผลคะแนนเด็กคนนี้ได้อีกแต่จะเก็บข้อมูลของท่านไว้ ยืนยันจะเพิกถอนหรือไม่")) {
                confirm_value.value = "Yes";
            }
            else {
                confirm_value.value = "No";
            }

            document.forms[0].appendChild(confirm_value);
        }
    </script>
    <div class="modal" id="Child_Create" tabindex="-1">
                    <div class="modal-dialog">
                        <div class="modal-content">
                            <div class="modal-header" style="align-items:center;">
                                <asp:Label runat="server" ID="label1">เพิ่มรายชื่อเด็ก</asp:Label>
                            </div>
                            <div class="modal-body">
                                <div class="form-group">
                                    <label>ชื่อ </label>
                                    <asp:TextBox runat="server" ID="Child_nameIp"></asp:TextBox>
                                    <label>  นามสกุล</label>
                                    <asp:TextBox runat="server" ID="Child_SurnameIp"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label>วันเกิด : ปี</label>
                                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>&nbsp;เดือน
                                    <asp:DropDownList ID="DropDownList2" runat="server" Enabled="false" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>&nbsp;วัน
                                    <asp:DropDownList ID="DropDownList3" runat="server" Enabled="false"></asp:DropDownList>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="Label2" runat="server" Text="Label">เพศ :</asp:Label>&nbsp;
                                    <asp:RadioButton ID="RadioMale" runat="server" Text="&nbsp;ชาย" GroupName="gender"/>&nbsp;
                                    <asp:RadioButton ID="RadioFemale" runat="server" Text="&nbsp;หญิง" GroupName="gender" />
                                </div>
                            </div>
                            <div class="modal-footer" style="align-items:center;">
                                <asp:Button runat="server" ID="Create" Text="เพิ่มข้อมูล" OnClick="Create_Click"/>
                            </div>
                        </div>
                    </div>
                </div>

    <div class="modal" id="Child_Create_Invite" tabindex="-1">
                    <div class="modal-dialog">
                        <div class="modal-content">
                            <div class="modal-header" style="align-items:center;">
                                <asp:Label runat="server" ID="label4">เพิ่มรายชื่อเด็ก</asp:Label>
                            </div>
                            <div class="modal-body">
                                <div class="form-group">
                                    <label>ระบุ Invite Code </label>
                                    <asp:TextBox runat="server" ID="TextBox1"></asp:TextBox>
                                </div>
                            </div>
                            <div class="modal-footer" style="align-items:center;">
                                <asp:Button runat="server" ID="Create2" Text="เพิ่มข้อมูล" OnClick="Create2_Click"/>
                            </div>
                        </div>
                    </div>
                </div>
                
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td class="auto-style5"><button type="button" class="btn btn-primary" data-target="#Child_Create" data-toggle="modal">เพิ่มรายชื่อเด็ก</button>&nbsp;<button type="button" class="btn btn-primary" data-target="#Child_Create_Invite" data-toggle="modal" style="width: 250px">เพิ่มรายชื่อผ่าน Invite Code</button>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td class="auto-style5">
                
    <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" Width="852px" CssClass="auto-style4" OnItemCommand="DataList1_ItemCommand">
                    <HeaderTemplate>
                    <table border="1">
                            <th style="text-align:center;">ลำดับ</th>
                            <th style="text-align:center;">ชื่อ</th>
                            <th style="text-align:center;">นามสกุล</th>
                            <th style="text-align:center;">วันเกิด</th>
                            <th style="text-align:center;">เพศ</th>
                            <th style="text-align:center;">Invite Code</th>
                            <th></th>
                            <th></th>
                            <th></th>
                            <th></th>

                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td style="text-align:center;">
                            <div><asp:Label ID="noLabel" runat="server" Text='<%#Container.ItemIndex + 1 %> ' /></div>
                        </td>
                        <td>
                            <div><asp:Label ID="nameLabel" runat="server" Text='<%# Eval("name") %>' /></div>
                        </td>
                        <td>
                            <div><asp:Label ID="surnameLabel" runat="server" Text='<%# Eval("surname") %>' /></div>
                        </td>
                        <td style="text-align:center;">
                            <div><asp:Label ID="birthdayLabel" runat="server" Text='<%# Convert.ToDateTime(Eval("birthday")).ToString("dd MMMM yyyy") %>' /></div>
                        </td>
						<td style="text-align:center;">
                            <div><asp:Label ID="genderLabel" runat="server" Text='<%# Eval("gender") %>' /></div>
                        </td>
                        <td style="text-align:center;">
                            <div><asp:Label ID="invitecodeLabel" runat="server" Text='<%# Eval("child_activation_invitecode") %>' /></div>
                        </td>
                        <td style="text-align:center;">
                            <div><asp:LinkButton ID="Codegen" runat="server" CommandName="Gen">สร้าง Code</asp:LinkButton></div>
                        </td>
                        <td style="text-align:center;">
                            <div><asp:LinkButton ID="QuestionSelect" runat="server" CommandName="Question">ทำแบบประเมิน</asp:LinkButton></div>
                        </td>
                        <td style="text-align:center;">
                            <asp:LinkButton ID="ScoreSelect" runat="server" CommandName="Score">ประวัติผลคะแนน</asp:LinkButton></div>
                        </td>
                        <td style="text-align:center;">
                            <div><asp:LinkButton ID="DeleteSelect" runat="server" CommandName="Disable" OnClientClick="Confirm()">เพิกถอน</asp:LinkButton></div>
                        </td>
                    </tr>
                </ItemTemplate>
                </asp:DataList>

                        </td>
                        <td>&nbsp;</td>
                    </tr>
    </table>
                
    <br />

                
    
    <script src="https://ajax.googleapis.com/apax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script src="js/bootstrap.js"></script>
</asp:Content>
