<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="factorypatten._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <table>
       <tr>
           <td>
               <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
           </td>
           <td>
               <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
           </td>
          
       </tr>
       <tr>
           <td>
               <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
           </td>
           <td>
               <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
           </td>
           
       </tr>
       <tr>
           <td colspan="2">
               <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
               
           </td>
           <td>
               <asp:Label ID="Label3" runat="server"></asp:Label>
           </td>
       </tr>
   </table>

</asp:Content>
