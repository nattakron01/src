<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Reg_Complete.aspx.cs" Inherits="Project.Reg_Complete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
    <table style="width: 100%;">
        <tr>
            <td>&nbsp;</td>
            <td><h1 class="auto-style5" style="text-align:center;">ลงทะเบียนเสร็จสิ้น</h1></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="text-align:center;">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
<ContentTemplate>ระบบกำลังจะกลับสู่หน้า Login ภายใน
                <asp:Label ID="Label1" runat="server" Text="5"></asp:Label>
                &nbsp;วินาที . . .
                <asp:Timer ID="Timer1" runat="server" Interval="1000" 
        ontick="Timer1_Tick">
    </asp:Timer>
    </ContentTemplate>
</asp:UpdatePanel>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    
    
    



    </asp:Content>
