﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="grants.aspx.cs" Inherits="InternTestProject.grants" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:HyperLink NavigateUrl="~/AddGrant" Text="Add New Grant" runat="server"></asp:HyperLink>
    <asp:GridView runat="server" ID="grantsGrid"
        ItemType="InternTestProject.Models.Grant"
        DataKeyNames="GrantNum"
        SelectMethod="grantsGrid_GetData"
        UpdateMethod="grantsGrid_UpdateItem" DeleteMethod="grantsGrid_DeleteItem"
        AutoGenerateEditButton="true" AutoGenerateDeleteButton="true"
        AutoGenerateColumns="false">
        <Columns>
            <asp:DynamicField DataField="GrantNum" />
            <asp:DynamicField DataField="FundedResrch" />
            <asp:DynamicField DataField="PrincInvest" />
        </Columns>
    </asp:GridView>
</asp:Content>

