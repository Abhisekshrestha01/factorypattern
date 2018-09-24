<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="factorypatten._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <table>
       <tr>
           <td>
               <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
           </td>
           <td>
               <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
           </td>
            <td>

           </td>
       </tr>
       <tr>
           <td>
               <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
           </td>
           <td>
               <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
           </td>
            <td>

           </td>
       </tr>
       <tr>
           <td colspan="2">
               <asp:Button ID="Button1" runat="server" Text="Button" />
           </td>
           <td>

           </td>
       </tr>
   </table>

</asp:Content>
