<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Project.Login" %>
<asp:Content runat="server" ContentPlaceHolderID="BodyContent">
    <table class="w-100">
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style7"><h1 class="h3 mb-3 font-weight-normal" style="text-align:center;">กรุณาเข้าสู่ระบบ</h1></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5"></td>
            <td class="auto-style8"><label for="inputUser" class="auto-style10">ชื่อผู้ใช้</label>
            <input type="text" ID="inputUser" class="auto-style9" placeholder="ชื่อผู้ใช้" runat="server">
            </td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style5"></td>
            <td class="auto-style8"><label for="inputPassword" class="sr-only">รหัสผ่าน</label>
                <input type="password" ID="inputPwd" class="auto-style9" placeholder="รหัสผ่าน" runat="server">
            </td>
            
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style11"></td>
            <td class="auto-style12"><asp:Button ID="Signin_btn" runat="server" Text="เข้าสู่ระบบ" CssClass="btn btn-lg btn-primary btn-block" OnClick="Signin_btn_Click" />
            </td>
            <td class="auto-style13"></td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="SignUp_btn" runat="server" Text="ลงทะเบียน" CssClass="btn btn-lg btn-primary btn-block" OnClick="SignUp_btn_Click" /></td>
            <td></td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style3 {
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
        .auto-style4 {
            width: 387px;
        }
        .auto-style5 {
            width: 387px;
            height: 51px;
        }
        .auto-style6 {
            height: 51px;
        }
        .auto-style7 {
            width: 288px;
        }
        .auto-style8 {
            width: 288px;
            height: 51px;
        }
        .auto-style9 {
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
            margin-left: 0;
        }
        .auto-style10 {
            border-style: none;
            border-color: inherit;
            border-width: 0;
            position: absolute;
            width: 1px;
            height: 1px;
            padding: 0;
            margin: -1px;
            overflow: hidden;
            clip: rect(0,0,0,0);
            white-space: nowrap;
            bottom: 423px;
        }
        .auto-style11 {
            width: 387px;
            height: 62px;
        }
        .auto-style12 {
            width: 288px;
            height: 62px;
        }
        .auto-style13 {
            height: 62px;
        }
    </style>
</asp:Content>