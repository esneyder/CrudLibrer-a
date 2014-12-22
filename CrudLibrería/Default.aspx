<%@ Page Title="Persona" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CrudLibrería._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <br />
  
     
    <table class="nav-justified">
        <tr>
            <td style="width: 79px">Cédula *</td>
            <td>
                <asp:TextBox ID="txtcedula" runat="server" Width="206px" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtcedula" ErrorMessage="Ingrese la cédula" ForeColor="#993333"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 79px">Nombres *</td>
            <td>
                <asp:TextBox ID="txtnombres" runat="server" Width="305px" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtnombres" ErrorMessage="Ingrese los nombres" ForeColor="#990033"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 79px">Apellidos *</td>
            <td>
                <asp:TextBox ID="txtapellidos" runat="server" Width="306px" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtapellidos" ErrorMessage="Ingrese los apellidos" ForeColor="#990033"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 79px">Genero *</td>
            <td>
                <asp:TextBox ID="txtgenero" runat="server" CssClass="form-control" Width="567px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtgenero" ErrorMessage="Ingrese el genero" ForeColor="#990033"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 79px">Ciudad *</td>
            <td>
                <asp:TextBox ID="txtciudad" runat="server" Width="304px"  CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtciudad" ErrorMessage="Ingrese la ciudad" ForeColor="#990033"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 79px">Dirección *</td>
            <td>
                <asp:TextBox ID="txtdireccion" runat="server" Width="301px"  CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtdireccion" ErrorMessage="Ingrese la dirección" ForeColor="#990033"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 79px">Telefono *</td>
            <td>
                <asp:TextBox ID="txttelefono" runat="server" CssClass="form-control" Width="561px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txttelefono" ErrorMessage="Ingrese el teléfono" ForeColor="#990033"></asp:RequiredFieldValidator>
            </td>
        </tr>
    </table>
  
      <asp:Button ID="btnSave" runat="server" Text="Save"  CssClass="btn btn-primary" OnClick="btnSave_Click"/>
      <asp:Button ID="btnSelect" runat="server" Text="Select" CssClass="btn btn-info" CausesValidation="False" OnClick="btnSelect_Click"/>
      <asp:Button ID="btnUpdate" runat="server" Text="Update"  CssClass="btn btn-success" OnClick="btnUpdate_Click"/>    
      <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="btn btn-danger" CausesValidation="False" OnClick="btnDelete_Click" />
     <asp:Button ID="btnList" runat="server" Text="List" CssClass="btn btn-default" CausesValidation="False" OnClick="btnList_Click" PostBackUrl="~/ListadoPersonas.aspx" />
    <asp:Label ID="msg" runat="server" Enabled="False" Text="mensaje"></asp:Label>
</asp:Content>
