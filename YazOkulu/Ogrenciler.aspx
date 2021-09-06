<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Ogrenciler.aspx.cs" Inherits="YazOkulu.Ogrenciler1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table-bordered table table-hover">
        <tr>
            <th>Öğrenci ID</th>
            <th>Öğrenci Adı</th>
            <th>Öğrenci Soyadı</th>
            <th>Öğrenci Numarası</th>
            <th>Öğrenci Fotoğrafı</th>
            <th>Öğrenci Bakiyesi</th>
            <th>İşlemler</th>
        </tr>

        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("Id1") %></td>
                        <%--Entitydeki propertiler yazılır--%>
                        <td><%#Eval("Ad1") %></td>
                        <td><%#Eval("Soyad1") %></td>
                        <td><%#Eval("Numara1") %></td>
                        <td><%#Eval("Fotograf1") %></td>
                        <td><%#Eval("Bakiye1") %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%#"~/OgrenciSil.aspx?OgrID="+Eval("Id1") %>' ID="HyperLink1" CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                            <asp:HyperLink  NavigateUrl='<%#"~/OgrenciGuncelle.aspx?OgrId="+Eval("Id1") %>' ID="HyperLink2" CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>

                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>


    </table>
</asp:Content>
