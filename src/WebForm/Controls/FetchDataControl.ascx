<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FetchDataControl.ascx.cs" Inherits="WebForm.Controls.FetchDataControl" %>

<p>This component demonstrates fetching data from a service.</p>

<table class="table">
    <thead>
        <tr>
            <th>Date</th>
            <th>Temp. (C)</th>
            <th>Temp. (F)</th>
            <th>Summary</th>
        </tr>
    </thead>
    <tbody>
        <% foreach (var forecast in Forecasts)
            { %>
            <tr>
                <td><%= forecast.Date.ToString("yyyy-MM-dd") %></td>
                <td><%= forecast.TemperatureC %></td>
                <td><%= forecast.TemperatureF %></td>
                <td><%= forecast.Summary %></td>
            </tr>
        <% } %>
    </tbody>
</table>
