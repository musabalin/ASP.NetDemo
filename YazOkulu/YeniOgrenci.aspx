<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="YeniOgrenci.aspx.cs" Inherits="YazOkulu.Ogrenciler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <strong>
            <asp:Label for="Textbox1" ID="Label1" runat="server" Text="Öğrenci Adı:"></asp:Label>
            </strong>
            <asp:TextBox ID="TxtAd" runat="server" CssClass="form-control"></asp:TextBox>

        </div>
        <br />
        <div class="form-group">
            <strong>
            <asp:Label for="Textbox2" ID="Label2" runat="server" Text="Öğrenci Soyadı:"></asp:Label>
            </strong>
            <asp:TextBox ID="TxtSoyad" runat="server" CssClass="form-control"></asp:TextBox>

        </div>
        <br />
        <div class="form-group">
            <strong>
            <asp:Label for="Textbox3" ID="Label3" runat="server" Text="Öğrenci Numara:"></asp:Label>
            </strong>
            <asp:TextBox ID="TxtNo" runat="server" CssClass="form-control"></asp:TextBox>

        </div>
        <br />
        <div class="form-group">
            <strong>
            <asp:Label for="Textbox4" ID="Label4" runat="server" Text="Öğrenci Şifre:"></asp:Label>
            </strong>
            <asp:TextBox ID="TxtSifre" runat="server" CssClass="form-control"></asp:TextBox>

        </div>
        <br />
        <div class="form-group">
            <strong>
            <asp:Label for="Textbox5" ID="Label5" runat="server" Text="Öğrenci Fotoğraf"></asp:Label>
            </strong>
            <asp:TextBox ID="TxtFoto" runat="server" CssClass="form-control"></asp:TextBox>

        </div>






        <asp:Button ID="Button1" runat="server" Text="Ekle" CssClass="btn bg-success" OnClick="Button1_Click" />
    </form>
</asp:Content>
