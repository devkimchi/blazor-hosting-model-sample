<%@ Page Title="Weather forecast" Async="true" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FetchData.aspx.cs" Inherits="WebForm.FetchData" %>
<%@ Register TagPrefix="uc" TagName="FetchDataControl" Src="~/Controls/FetchDataControl.ascx" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Weather forecast &ndash; WebForm App</h2>
    
    <uc:FetchDataControl runat="server" />
</asp:Content>
