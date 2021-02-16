<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="questionnaire.aspx.cs" Inherits="Project.questionnaire" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style7 {
            width: 108px;
            height: 32px;
        }
        .auto-style8 {
            width: 465px;
            height: 32px;
        }
        .auto-style9 {
            width: 90px;
            height: 32px;
        }
        .auto-style12 {
            width: 414px;
            height: 73px;
        }
        .auto-style13 {
            width: 90px;
            height: 73px;
        }
        .auto-style16 {
            width: 414px;
            height: 72px;
        }
        .auto-style17 {
            width: 90px;
            height: 72px;
        }
        .auto-style20 {
            width: 414px;
            height: 40px;
        }
        .auto-style21 {
            width: 90px;
            height: 40px;
        }
        .radio {
  border: 4px solid white;
  border-radius: 100%;
  background-color : red;
        }
        .auto-style23 {
            width: 163%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <script type="text/javascript">
        function Confirm() {
            var confirm_value = document.createElement("INPUT");

            confirm_value.type = "hidden";
            confirm_value.name = "confirm_value";

            if (confirm("โปรดยืนยันการส่งคำตอบ")) {
                confirm_value.value = "Yes";
            }
            else {
                confirm_value.value = "No";
            }

            document.forms[0].appendChild(confirm_value);
        }
    </script>
    <table class="w-100">
        <tr>
            <td class="auto-style7"></td>
            <td class="auto-style8">ชื่อของผู้ที่รับการประเมิน :
                <asp:Label ID="name1" runat="server"></asp:Label>
            &nbsp;<br />
                ประวัติการทำแบบประเมินของวันที่ :
                <asp:Label ID="date1" runat="server"></asp:Label>
            </td>
            <td class="auto-style9"></td>
        </tr>
        
                <tr>
            <td class="auto-style7"></td>
            <td class="auto-style8">
                <table class="auto-style23" border="1" style="width:auto;">
                    <tr>
            
            <td class="auto-style20" style="text-align:center;background-color:lightgray">
                <asp:Label ID="Label6" runat="server" Text="หมวดอาการขาดสมาธิ"></asp:Label>
            </td>
            <td class="auto-style21" style="text-align:center;background-color:lightgray">
                <asp:Label ID="Label2" runat="server" Text="ไม่เคย"></asp:Label>
            </td>
            <td class="auto-style21" style="text-align:center;background-color:lightgray">
                <asp:Label ID="Label3" runat="server" Text="เล็กน้อย"></asp:Label>
            </td>
            <td class="auto-style21" style="text-align:center;background-color:lightgray">
                <asp:Label ID="Label4" runat="server" Text="ปานกลาง"></asp:Label>
            </td>
            <td class="auto-style21" style="text-align:center;background-color:lightgray">
                <asp:Label ID="Label5" runat="server" Text="มาก"></asp:Label>
            </td>
        </tr>
        <tr>
            
            <td class="auto-style12" style="vertical-align:middle;">
                <asp:Label ID="Label1" runat="server" Text="1.มักไม่ละเอียดรอบคอบหรือสะเพร่าในการทำงานต่างๆ เช่น การบ้าน"></asp:Label>
            </td>
            <td class="auto-style13" style="text-align:center;">
                <asp:RadioButton ID="Q111" runat="server" Text=" " GroupName="Q11" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style13" style="text-align:center;">
                <asp:RadioButton ID="Q112" runat="server" Text=" " GroupName="Q11" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style13" style="text-align:center;">
                <asp:RadioButton ID="Q113" runat="server" Text=" " GroupName="Q11" Width="30px" Height="30px"/> 
            </td>
            <td class="auto-style13" style="text-align:center;">
                <asp:RadioButton ID="Q114" runat="server" Text=" " GroupName="Q11" Width="30px" Height="30px"/>
            </td>
            
        </tr>
        <tr>
           
            <td class="auto-style16" style="vertical-align:middle;">
                <asp:Label ID="Label7" runat="server" Text="2.ทำอะไรนาน ๆ ไม่ได้"></asp:Label>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q121" runat="server" Text=" " GroupName="Q12" Height="30px" Width="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q122" runat="server" Text=" " GroupName="Q12" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q123" runat="server" Text=" " GroupName="Q12" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q124" runat="server" Text=" " GroupName="Q12" Width="30px" Height="30px"/>
            </td>
            
        </tr>
        <tr>
            
            <td class="auto-style16" style="vertical-align:middle;">
                <asp:Label ID="Label8" runat="server" Text="3.ดูเหมือนไม่ค่อยฟังเวลามีคนพูดด้วย"></asp:Label>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q131" runat="server" Text=" " GroupName="Q13" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q132" runat="server" Text=" " GroupName="Q13" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q133" runat="server" Text=" " GroupName="Q13" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q134" runat="server" Text=" " GroupName="Q13" Width="30px" Height="30px"/>
            </td>
            
        </tr>
        <tr>
            
            <td class="auto-style16" style="vertical-align:middle;">
                <asp:Label ID="Label9" runat="server" Text="4.มักทำการบ้านไม่เสร็จ หรือทำงานที่ได้รับมอบหมายไม่สำเร็จ"></asp:Label>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q141" runat="server" Text=" " GroupName="Q14" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q142" runat="server" Text=" " GroupName="Q14" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q143" runat="server" Text=" " GroupName="Q14" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q144" runat="server" Text=" " GroupName="Q14" Width="30px" Height="30px"/>
            </td>
            
        </tr>
        <tr>
            
            <td class="auto-style16" style="vertical-align:middle;">
                <asp:Label ID="Label10" runat="server" Text="5.จัดระเบียบงานและกิจกรรมต่างๆ ไม่เป็น"></asp:Label>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q151" runat="server" Text=" " GroupName="Q15" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q152" runat="server" Text=" " GroupName="Q15" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q153" runat="server" Text=" " GroupName="Q15" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q154" runat="server" Text=" " GroupName="Q15" Width="30px" Height="30px"/>
            </td>
            
        </tr>
        <tr>
            
            <td class="auto-style16" style="vertical-align:middle;">
                <asp:Label ID="Label11" runat="server" Text="6.มักหลีกเลี่ยงกิจกรรมที่ต้องใช้ความอดทนในการทำให้สำเร็จ"></asp:Label>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q161" runat="server" Text=" " GroupName="Q16" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q162" runat="server" Text=" " GroupName="Q16" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q163" runat="server" Text=" " GroupName="Q16" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q164" runat="server" Text=" " GroupName="Q16" Width="30px" Height="30px"/>
            </td>
            
        </tr>
        <tr>
            
            <td class="auto-style16" style="vertical-align:middle;">
                <asp:Label ID="Label12" runat="server" Text="7.ทำของหายบ่อย ๆ เช่น ของเล่น สมุดจดงาน เครื่องเขียน"></asp:Label>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q171" runat="server" Text=" " GroupName="Q17" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q172" runat="server" Text=" " GroupName="Q17" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q173" runat="server" Text=" " GroupName="Q17" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q174" runat="server" Text=" " GroupName="Q17" Width="30px" Height="30px"/>
            </td>
            
        </tr>
        <tr>
            
            <td class="auto-style16" style="vertical-align:middle;">
                <asp:Label ID="Label13" runat="server" Text="8.วอกแวกง่าย"></asp:Label>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q181" runat="server" Text=" " GroupName="Q18" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q182" runat="server" Text=" " GroupName="Q18" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q183" runat="server" Text=" " GroupName="Q18" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q184" runat="server" Text=" " GroupName="Q18" Width="30px" Height="30px"/>
            </td>
            
        </tr>
        <tr>
            
            <td class="auto-style16" style="vertical-align:middle;">
                <asp:Label ID="Label14" runat="server" Text="9.ขี้ลืม"></asp:Label>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q191" runat="server" Text=" " GroupName="Q19" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q192" runat="server" Text=" " GroupName="Q19" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q193" runat="server" Text=" " GroupName="Q19" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q194" runat="server" Text=" " GroupName="Q19" Width="30px" Height="30px"/>
            </td>
            
        </tr>
                </table>

            </td>
            <td class="auto-style9"></td>
        </tr>
        <tr>
            <td class="auto-style7"></td>
            <td class="auto-style8"></td>
            <td class="auto-style9"></td>
        </tr>

        
                <tr>
            <td class="auto-style7"></td>
            <td class="auto-style8">ชื่อของผู้ที่รับการประเมิน :
                <asp:Label ID="name2" runat="server"></asp:Label>
                    &nbsp;<br />
                ประวัติการทำแบบประเมินของวันที่ : <asp:Label ID="date2" runat="server"></asp:Label>
                    </td>
            <td class="auto-style9"></td>
        </tr>
                <tr>
            <td class="auto-style7"></td>
            <td class="auto-style8">
                <table class="auto-style23"  border="1" style="width:auto;">
                    <tr>
            <td class="auto-style20" style="text-align:center;background-color:lightgray">
                <asp:Label ID="Label15" runat="server" Text="หมวดอาการซน อยู่ไม่นิ่ง/หุนหันพลันแล่น"></asp:Label>
            </td>
            <td class="auto-style21" style="text-align:center;background-color:lightgray">
                <asp:Label ID="Label16" runat="server" Text="ไม่เคย"></asp:Label>
            </td>
            <td class="auto-style21" style="text-align:center;background-color:lightgray">
                <asp:Label ID="Label17" runat="server" Text="เล็กน้อย"></asp:Label>
            </td>
            <td class="auto-style21" style="text-align:center;background-color:lightgray">
                <asp:Label ID="Label18" runat="server" Text="ปานกลาง"></asp:Label>
            </td>
            <td class="auto-style21" style="text-align:center;background-color:lightgray">
                <asp:Label ID="Label19" runat="server" Text="มาก"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style12" style="vertical-align:middle;">
                <asp:Label ID="Label20" runat="server" Text="1.มือเท้ายุกยิก นั่งบิดไปมา"></asp:Label>
            </td>
            <td class="auto-style13" style="text-align:center;">
                <asp:RadioButton ID="Q211" runat="server" Text=" " GroupName="Q21" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style13" style="text-align:center;">
                <asp:RadioButton ID="Q212" runat="server" Text=" " GroupName="Q21" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style13" style="text-align:center;">
                <asp:RadioButton ID="Q213" runat="server" Text=" " GroupName="Q21" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style13" style="text-align:center;">
                <asp:RadioButton ID="Q214" runat="server" Text=" " GroupName="Q21" Width="30px" Height="30px"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style16" style="vertical-align:middle;">
                <asp:Label ID="Label21" runat="server" Text="2.นั่งไม่ติดที่ชอบลุกจากที่นั่งในชั้นเรียน หรือจากที่ที่ ควรจะนั่งเรียบร้อย"></asp:Label>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q221" runat="server" Text=" " GroupName="Q22" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q222" runat="server" Text=" " GroupName="Q22" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q223" runat="server" Text=" " GroupName="Q22" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q224" runat="server" Text=" " GroupName="Q22" Width="30px" Height="30px"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style16" style="vertical-align:middle;">
                <asp:Label ID="Label22" runat="server" Text="3.วิ่งหรือปีนป่ายมากเกินควรอย่างไม่รู้กาลเทศะ"></asp:Label>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q231" runat="server" Text=" " GroupName="Q23" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q232" runat="server" Text=" " GroupName="Q23" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q233" runat="server" Text=" " GroupName="Q23" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q234" runat="server" Text=" " GroupName="Q23" Width="30px" Height="30px"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style16" style="vertical-align:middle;">
                <asp:Label ID="Label23" runat="server" Text="4.เล่นหรือทำกิจกรรมเงียบ ๆ ไม่เป็น"></asp:Label>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q241" runat="server" Text=" " GroupName="Q24" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q242" runat="server" Text=" " GroupName="Q24" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q243" runat="server" Text=" " GroupName="Q24" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q244" runat="server" Text=" " GroupName="Q24" Width="30px" Height="30px"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style16" style="vertical-align:middle;">
                <asp:Label ID="Label24" runat="server" Text="5.พร้อมจะเคลื่อนไหวอยู่เสมอเหมือนติดเครื่องอยู่ ตลอดเวลา"></asp:Label>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q251" runat="server" Text=" " GroupName="Q25" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q252" runat="server" Text=" " GroupName="Q25" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q253" runat="server" Text=" " GroupName="Q25" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q254" runat="server" Text=" " GroupName="Q25" Width="30px" Height="30px"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style16" style="vertical-align:middle;">
                <asp:Label ID="Label25" runat="server" Text="6.พูดมาก"></asp:Label>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q261" runat="server" Text=" " GroupName="Q26" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q262" runat="server" Text=" " GroupName="Q26" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q263" runat="server" Text=" " GroupName="Q26" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q264" runat="server" Text=" " GroupName="Q26" Width="30px" Height="30px"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style16" style="vertical-align:middle;">
                <asp:Label ID="Label26" runat="server" Text="7.มักโพล่งคำตอบออกมาก่อนจะฟังคำถามจบ"></asp:Label>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q271" runat="server" Text=" " GroupName="Q27" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q272" runat="server" Text=" " GroupName="Q27" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q273" runat="server" Text=" " GroupName="Q27" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q274" runat="server" Text=" " GroupName="Q27" Width="30px" Height="30px"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style16" style="vertical-align:middle;">
                <asp:Label ID="Label27" runat="server" Text="8.ไม่ชอบรอคิว"></asp:Label>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q281" runat="server" Text=" " GroupName="Q28" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q282" runat="server" Text=" " GroupName="Q28" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q283" runat="server" Text=" " GroupName="Q28" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q284" runat="server" Text=" " GroupName="Q28" Width="30px" Height="30px"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style16" style="vertical-align:middle;">
                <asp:Label ID="Label28" runat="server" Text="9.ชอบสอดแทรกผู้อื่น เช่น ชอบพูดแทรกขณะผู้ใหญ่กำลังสนทนากัน"></asp:Label>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q291" runat="server" Text=" " GroupName="Q29" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q292" runat="server" Text=" " GroupName="Q29" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q293" runat="server" Text=" " GroupName="Q29" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q294" runat="server" Text=" " GroupName="Q29" Width="30px" Height="30px"/>
            </td>
        </tr>

                </table>

            </td>
            <td class="auto-style9"></td>
        </tr>
         <tr>
            <td class="auto-style7"></td>
            <td class="auto-style8"></td>
            <td class="auto-style9"></td>
        </tr>
        <tr>
            <td class="auto-style7"></td>
            <td class="auto-style8">ชื่อของผู้ที่รับการประเมิน :
                <asp:Label ID="name3" runat="server"></asp:Label>
            &nbsp;<br />
                ประวัติการทำแบบประเมินของวันที่ : <asp:Label ID="date3" runat="server"></asp:Label>
            </td>
            <td class="auto-style9"></td>
        </tr>
                <tr>
            <td class="auto-style7"></td>
            <td class="auto-style8">
                <table class="auto-style23" border="1" style="width:auto;">
                    <tr>
            <td class="auto-style20" style="text-align:center;background-color:lightgray">
                <asp:Label ID="Label29" runat="server" Text="อาการดื้อ / ต่อต้าน"></asp:Label>
            </td>
            <td class="auto-style21" style="text-align:center;background-color:lightgray">
                <asp:Label ID="Label30" runat="server" Text="ไม่เคย"></asp:Label>
            </td>
            <td class="auto-style21" style="text-align:center;background-color:lightgray">
                <asp:Label ID="Label31" runat="server" Text="เล็กน้อย"></asp:Label>
            </td>
            <td class="auto-style21" style="text-align:center;background-color:lightgray">
                <asp:Label ID="Label32" runat="server" Text="ปานกลาง"></asp:Label>
            </td>
            <td class="auto-style21" style="text-align:center;background-color:lightgray">
                <asp:Label ID="Label33" runat="server" Text="มาก"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style12" style="vertical-align:middle;">
                <asp:Label ID="Label34" runat="server" Text="1.อารมณ์เสียง่าย"></asp:Label>
            </td>
            <td class="auto-style13" style="text-align:center;">
                <asp:RadioButton ID="Q311" runat="server" Text=" " GroupName="Q31" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style13" style="text-align:center;">
                <asp:RadioButton ID="Q312" runat="server" Text=" " GroupName="Q31" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style13" style="text-align:center;">
                <asp:RadioButton ID="Q313" runat="server" Text=" " GroupName="Q31" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style13" style="text-align:center;">
                <asp:RadioButton ID="Q314" runat="server" Text=" " GroupName="Q31" Width="30px" Height="30px"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style16" style="vertical-align:middle;">
                <asp:Label ID="Label35" runat="server" Text="2.ชอบโต้เถียงกับผู้ใหญ่"></asp:Label>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q321" runat="server" Text=" " GroupName="Q32" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q322" runat="server" Text=" " GroupName="Q32" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q323" runat="server" Text=" " GroupName="Q32" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q324" runat="server" Text=" " GroupName="Q32" Width="30px" Height="30px"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style16" style="vertical-align:middle;">
                <asp:Label ID="Label36" runat="server" Text="3.ไม่ยอมทำตามสิ่งที่ผู้ใหญ่สั่งหรือวางกฎเกณฑ์ไว้"></asp:Label>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q331" runat="server" Text=" " GroupName="Q33" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q332" runat="server" Text=" " GroupName="Q33" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q333" runat="server" Text=" " GroupName="Q33" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q334" runat="server" Text=" " GroupName="Q33" Width="30px" Height="30px"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style16" style="vertical-align:middle;">
                <asp:Label ID="Label37" runat="server" Text="4.จงใจก่อกวนผู้อื่น"></asp:Label>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q341" runat="server" Text=" " GroupName="Q34" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q342" runat="server" Text=" " GroupName="Q34" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q343" runat="server" Text=" " GroupName="Q34" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q344" runat="server" Text=" " GroupName="Q34" Width="30px" Height="30px"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style16" style="vertical-align:middle;">
                <asp:Label ID="Label38" runat="server" Text="5.มักตำหนิผู้อื่นในสิ่งที่ตนเองทำผิด"></asp:Label>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q351" runat="server" Text=" " GroupName="Q35" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q352" runat="server" Text=" " GroupName="Q35" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q353" runat="server" Text=" " GroupName="Q35" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q354" runat="server" Text=" " GroupName="Q35" Width="30px" Height="30px"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style16" style="vertical-align:middle;">
                <asp:Label ID="Label39" runat="server" Text="6.ขี้รำคาญ"></asp:Label>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q361" runat="server" Text=" " GroupName="Q36" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q362" runat="server" Text=" " GroupName="Q36" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q363" runat="server" Text=" " GroupName="Q36" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q364" runat="server" Text=" " GroupName="Q36" Width="30px" Height="30px"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style16" style="vertical-align:middle;">
                <asp:Label ID="Label40" runat="server" Text="7.โกรธบึ้งตึงเป็นประจำ"></asp:Label>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q371" runat="server" Text=" " GroupName="Q37" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q372" runat="server" Text=" " GroupName="Q37" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q373" runat="server" Text=" " GroupName="Q37" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q374" runat="server" Text=" " GroupName="Q37" Width="30px" Height="30px"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style16" style="vertical-align:middle;">
                <asp:Label ID="Label41" runat="server" Text="8.เจ้าคิดเจ้าแค้น"></asp:Label>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q381" runat="server" Text=" " GroupName="Q38" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q382" runat="server" Text=" " GroupName="Q38" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q383" runat="server" Text=" " GroupName="Q38" Width="30px" Height="30px"/>
            </td>
            <td class="auto-style17" style="text-align:center;">
                <asp:RadioButton ID="Q384" runat="server" Text=" " GroupName="Q38" Width="30px" Height="30px"/>
            </td>
        </tr>
                </table>
            </td>
            <td class="auto-style9"></td>
        </tr>
                <tr>
            <td class="auto-style7"></td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style9">
                &nbsp;</td>
        </tr>
         <tr>
            <td class="auto-style7"></td>
            <td class="auto-style8"></td>
            <td class="auto-style9">
                <asp:Button ID="ConfirmBtn" runat="server" CssClass="btn btn-primary btn-block" Text="ยืนยัน" OnClick="ConfirmBtn_Click" OnClientClick="Confirm()"/>
                    </td>
        </tr>
    </table>

</asp:Content>
