<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Project.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            height: 44px;
        }
        .auto-style5 {
            width: 270px;
            margin-bottom: 0px;
            height: 63px;
        }
        .auto-style9 {
            height: 44px;
            width: 395px;
        }
        .auto-style10 {
            width: 395px;
            height: 50px;
        }
        .auto-style12 {
            height: 50px;
        }
        .auto-style13 {
            height: 49px;
            width: 395px;
        }
        .auto-style15 {
            height: 49px;
        }
        .auto-style16 {
            height: 46px;
        }
        .auto-style17 {
            height: 46px;
            width: 395px;
        }
        .auto-style18 {
            width: 395px;
        }
        .auto-style19 {
            width: 259px;
            height: 50px;
        }
        .auto-style20 {
            height: 44px;
            width: 259px;
        }
        .auto-style21 {
            height: 49px;
            width: 259px;
        }
        .auto-style22 {
            height: 46px;
            width: 259px;
        }
        .auto-style23 {
            width: 259px;
        }
        .textbox 
        {
            display: block;
            width: 100%;
            height: calc(1.5em + .75rem + 2px);
            font-size: 1rem;
            font-weight: 400;
            line-height: 1.5;
            color: #495057;
            background-clip: padding-box;
            border-radius: .25rem;
            transition: none;
            border: 1px solid #ced4da;
            background-color: #fff;
        }
        </style>

    <meta charset="utf-8" />
    <link href="css/bootstrap.css" rel="stylesheet" />
    <script src="js/jquery-3.3.1.min.js"></script>
    <script src="css/bootstrap.min.css"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <script type = "text/javascript">
        function functionx(evt) {
            if (evt.charCode > 31 && (evt.charCode < 48 || evt.charCode > 57)) {
                return false;
            }
        }
        function isCharacterKeyPress(evt) {
            if ((event.charCode >= 48 && event.charCode <= 57) || (event.charCode >= 65 && event.charCode <= 90) || (event.charCode >= 97 && event.charCode <= 122))
                return true;
            return false;
        }
        function openModal() {
            $("#OTP").modal("show");
        }
    </script>

    <div class="modal" id="OTP" tabindex="-1">
                    <div class="modal-dialog">
                        <div class="modal-content">
                            <div class="modal-header" style="align-items:center;">
                                <asp:Label runat="server" ID="label6">กรอกรหัสยืนยัน</asp:Label>
                            </div>
                            <div class="modal-body">
                                <div class="form-group" style="align-items:center;">
                                    <label>ระบบได้ทำการส่งรหัสยืนยันไปที่ Email ที่ท่านได้กรอกแล้ว</label>
                                </div>
                                <div class="form-group" style="align-items:center;">
                                    <label>รหัส OTP </label>
                                    <asp:TextBox runat="server" ID="OTP_Input"></asp:TextBox>
                                </div>
                                <div class="form-group" style="align-items:center;">
                                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="OTP_Resent_Click">ส่งรหัสอีกครั้ง</asp:LinkButton>
                                </div>
                            </div>
                            <div class="modal-footer" style="text-align:center;">
                                <asp:Button ID="OTP_confirm" runat="server" Text="ยืนยัน" CssClass="btn btn-primary" OnClick="OTP_confirm_Click" />

                            </div>
                        </div>
                </div>
        </div>
    
    <asp:ScriptManager ID="ScriptManager1" runat="server">
        
    </asp:ScriptManager>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="false">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="name_input" EventName="TextChanged" />
            <asp:AsyncPostBackTrigger ControlID="surname_input" EventName="TextChanged" />
            <asp:AsyncPostBackTrigger ControlID="User_input" EventName="TextChanged" />
            <asp:AsyncPostBackTrigger ControlID="pwd_input" EventName="TextChanged" />
            <asp:AsyncPostBackTrigger ControlID="pwdcon_input" EventName="TextChanged" />
            <asp:AsyncPostBackTrigger ControlID="Email_input" EventName="TextChanged" />
        </Triggers>
        <ContentTemplate>
            <table class="w-100">
        <tr>
            <td class="auto-style10"></td>
            <td class="auto-style19">
                <h1 class="auto-style5" style="text-align:center;">ลงทะเบียน</h1>
            </td>
            <td class="auto-style12"></td>
        </tr>
        <tr>
            <td class="auto-style9" style="text-align:right;">
                <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="Red">*</asp:Label>
                ชื่อ&nbsp;&nbsp;</td>
            <td class="auto-style20">
                
                <asp:TextBox ID="name_input" runat="server" OnTextChanged="Name_Checked" AutoPostBack="true" CssClass="textbox" Width="270px"></asp:TextBox>
                
            </td>
            <td class="auto-style4">
                
                <asp:Label ID="NameEmpty" runat="server" ForeColor="Red" Text="Label" Visible="false" AutoPostBack="true">*กรุณากรอกข้อมูล</asp:Label>
                
                </td>
        </tr>
        <tr>
            <td class="auto-style13" style="text-align:right;">
                <asp:Label ID="Label2" runat="server" Text="Label" ForeColor="Red">*</asp:Label>
                นามสกุล&nbsp;&nbsp; </td>
            <td class="auto-style21">
                <asp:TextBox ID="surname_input" runat="server" AutoPostBack="true"  OnTextChanged="surname_input_TextChanged" Width="271px" CssClass="textbox"></asp:TextBox>
            </td>
            <td class="auto-style15">
                
                <asp:Label ID="SurnameEmpty" runat="server" ForeColor="Red" Text="Label" Visible="false">*กรุณากรอกข้อมูล</asp:Label>
                
                </td>
        </tr>
        <tr>
            <td class="auto-style17" style="text-align:right;"> 
                <asp:Label ID="Label3" runat="server" Text="Label" ForeColor="Red">*</asp:Label>
                ชื่อผู้ใช้&nbsp;&nbsp; </td>
            <td class="auto-style22">
                <asp:TextBox ID="User_input" OnTextChanged="User_input_TextChanged" AutoPostBack="true" runat="server" CssClass="textbox" Width="268px"></asp:TextBox>
            </td>
            <td class="auto-style16">
                <asp:Label ID="UserEmpty" runat="server" ForeColor="Red" Text="*กรุณากรอกเป็นภาษาอังกฤษและต้องมีตัวอักษรตั้งแต่ 4 ตัวขึ้นไป" Visible="False"></asp:Label>
                <asp:Label ID="UserExist" runat="server" ForeColor="Red" Text="Label" Visible="false">*ชื่อผู้ใช้งานนี้มีคนใช้งานแล้ว</asp:Label>
                
                <asp:Label ID="SurnameEmpty0" runat="server" ForeColor="Red" Text="Label" Visible="false">*กรุณากรอกข้อมูล</asp:Label>
                
            </td>
        </tr>
        <tr>
            <td class="auto-style17" style="text-align:right;">
                <asp:Label ID="Label4" runat="server" Text="Label" ForeColor="Red">*</asp:Label>
                รหัสผ่าน&nbsp;&nbsp; </td>
            <td class="auto-style22">
                <asp:TextBox ID="pwd_input" runat="server" Width="271px" CssClass="textbox" AutoPostBack="true"  TextMode="Password" OnTextChanged="pwd_input_TextChanged" onkeypress="isCharacterKeyPress(event)"></asp:TextBox>
            </td>
            <td class="auto-style16">
                <asp:Label ID="PwdEmpty" runat="server" ForeColor="Red" Text="Label" Visible="false" >*กรุณากรอกเป็นตัวเลขกับภาษาอังกฤษและต้องมีตัวอักษร 6 ตัวขึ้นไป</asp:Label>
                
                <asp:Label ID="PwdCondition" runat="server" ForeColor="Red" Text="Label" Visible="false">*กรุณากรอกรหัสผ่าน</asp:Label>
                
                </td>
        </tr>
        <tr>
            <td class="auto-style17" style="text-align:right;">
                <asp:Label ID="Label5" runat="server" Text="Label" ForeColor="Red">*</asp:Label>
                ยืนยันรหัสผ่าน&nbsp;&nbsp; </td>
            <td class="auto-style22">
                <asp:TextBox ID="pwdcon_input" runat="server" Width="271px" CssClass="textbox" TextMode="Password" AutoPostBack="true" OnTextChanged="pwdcon_input_TextChanged" onkeypress="isCharacterKeyPress(event)"></asp:TextBox>
            </td>
            <td class="auto-style16">
                
                <asp:Label ID="PwdconCondition" runat="server" ForeColor="Red" Text="Label" Visible="false">*รหัสผ่านไม่ตรงกัน</asp:Label>
                
                <asp:Label ID="PwdconEmpty" runat="server" ForeColor="Red" Text="Label" Visible="false">*กรุณากรอกรหัสผ่าน</asp:Label>
                
                </td>
        </tr>
        <tr>
            <td class="auto-style17" style="text-align:right;">
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label7" runat="server" Text="Label" ForeColor="Red">*</asp:Label>
                อีเมล&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style22">
                
                <asp:TextBox ID="Email_input" TextMode="Email" runat="server" Width="271px" CssClass="textbox" AutoPostBack="true" OnTextChanged="Email_input_TextChanged"></asp:TextBox>
            </td>
            <td class="auto-style16">
                
                <asp:Label ID="EmailCondition" runat="server" ForeColor="Red" Text="*กรุณากรอก E-mail ให้ถูกต้อง" Visible="False"></asp:Label>
                
                <asp:Label ID="EmailCheck" runat="server" ForeColor="Red" Text="Label" Visible="false">*E-mail นี้ถูกใช้งานแล้ว</asp:Label>
                
                </td>
        </tr>
        <tr>
            <td class="auto-style17" style="text-align:right;">
                <asp:Label ID="Label8" runat="server" Text="Label" ForeColor="Red">*</asp:Label>
                สถานะ&nbsp;&nbsp; </td>
            <td class="auto-style22">
                
                <asp:DropDownList ID="DropDownList1" runat="server" Width="175px" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem Selected="True" Text="กรุณาเลือกสถานะ" Value="0"></asp:ListItem>
                    <asp:ListItem Text="ผู้ปกครอง" Value="ผู้ปกครอง"></asp:ListItem>
                    <asp:ListItem Text="ครู" Value="ครู"></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style16">
                
                <asp:Label ID="StatusCheck" runat="server" ForeColor="Red" Text="*กรุณาระบุสถานะของท่าน" Visible="False"></asp:Label>
                
                </td>
        </tr>
        <tr>
            <td class="auto-style17" style="text-align:right;">
                <asp:Label ID="Label9" runat="server" Text="Label" ForeColor="Red" Visible="false">*</asp:Label>
                <asp:Label ID="schoolTag" runat="server" Text="โรงเรียน" ForeColor="Black" Visible="false"></asp:Label>
                &nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style22">
                <asp:TextBox ID="SchoolIp" runat="server" Width="271px" CssClass="textbox" Enabled="False" Visible="false"></asp:TextBox>
            </td>
            <td class="auto-style16">
                
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style17" style="text-align:right;">
                &nbsp;&nbsp; </td>
            <td class="auto-style22">
                <asp:Button ID="RegConfirm" runat="server" Text="ลงทะเบียน" CssClass="btn btn-lg btn-primary btn-block" Width="270px" OnClick="RegConfirm_Click"/></td>
            <td class="auto-style16"></td>
        </tr>
        <tr>
            <td class="auto-style18">&nbsp;</td>
            <td class="auto-style23">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
        </ContentTemplate>
    </asp:UpdatePanel>
    

    <script src="https://ajax.googleapis.com/apax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script src="js/bootstrap.js"></script>

</asp:Content>
