﻿<%@ Control Language="VB" AutoEventWireup="False" CodeFile="countryDashboard.ascx.vb" Inherits="DotNetNuke.Modules.AgapeConnect.countryDashboard" %>
<%@ Register Src="~/controls/labelcontrol.ascx" TagName="labelcontrol" TagPrefix="uc1" %>
<link href="/Portals/_default/Skins/AgapeBlue/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
<script src="/Portals/_default/Skins/AgapeBlue/bootstrap/js/bootstrap.min.js"></script>
<script type="text/javascript" src="https://www.google.com/jsapi"></script>
<script type="text/javascript">
    google.load("visualization", "1", { packages: ["corechart"] });

    google.setOnLoadCallback(drawChart);



    function drawChart() {


        var data2 = google.visualization.arrayToDataTable([
 ['Support Level', 'Percentage Raised'], <%= jsonPI %>
        ]);

        var options2 = {
            title: 'Staff MPD Health',
            pieHole: 0.4, reverseCategories: true,
            chartArea: { left: 40, top: 20, width: "120%", height: "100%" },
            slices: [{ color: 'green' }, { color: '#7e870d' }, { color: '#ff9b00' }, { color: '#ff5f08' }, { color: 'red' }, { color: 'grey', offset: 0.1 }]
        };

        var chart2 = new google.visualization.PieChart(document.getElementById('donutchart'));


        function selectHandler() {
            var selectedItem = chart2.getSelection()[0];
            if (selectedItem) {
                var section = data2.getValue(selectedItem.row, 0);
                $('.listDetail').hide();
                if (section.indexOf('<50%') > -1) $('#d_lessthan50').show();

                if (section.indexOf('50-75%') > -1) $('#d_low').show();
                if (section.indexOf('75-90%') > -1) $('#d_medium').show();
                if (section.indexOf('90-100%') > -1) $('#d_high').show();
                if (section.indexOf('>100%') > -1) $('#d_full').show();
                if (section.indexOf('No Budget') > -1) $('#d_none').show();

            }
        }
        google.visualization.events.addListener(chart2, 'select', selectHandler);

        chart2.draw(data2, options2);


        var data = google.visualization.arrayToDataTable([
          ['Period', 'Average Support Level', 'Staff with more than 90%'],
          <%= jsonLi %>
        ]);
        var formatter = new google.visualization.NumberFormat({
            pattern: '#%',
            fractionDigits: 2
        });
        formatter.format(data, 1);
        formatter.format(data, 2);
        var options = {
            title: 'Average Support Progress', vAxis: { format: '#,###%' }
        };

        var chart = new google.visualization.LineChart(document.getElementById('chart_div'));
        chart.draw(data, options);



    }
</script>

<style type="text/css">
    .listDetail {
        display: none;
    }
</style>

<h1>
    <asp:Label ID="lblCountryTitle" runat="server" Text="Label"></asp:Label>
</h1>


<div class="row-fluid">
    <div class="span7">
        <div id="donutchart" style="width: 100%; height: 600px;"></div>
        <div id="chart_div" style="width: 100%; height: 300px;"></div>
    </div>
    <div class="span5">

        <table cellpadding="7" class="well">
            <tr style="vertical-align: top;">
                <td style="font-weight: bold; white-space: nowrap;">Average Support</td>
                <td>
                    <asp:Label ID="lblAvgSupport" runat="server" Text="Label" Font-Size="X-Large" Font-Bold="true"></asp:Label>
                </td>
            </tr>
            <tr style="vertical-align: top;">
                <td style="font-weight: bold; white-space: nowrap; font-size: small;">Actual vs Budget</td>
                <td>
                    <asp:Label ID="lblBdgVsAct" runat="server" Text="Label"></asp:Label>
                    <asp:Label ID="lblBdgVsActLabel" runat="server" Style="font-size: x-small; color: gray;" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>

        <div class="well listDetail" id="d_lessthan50">


            <asp:Repeater ID="rpLessThan50" runat="server" >
                <HeaderTemplate>
                    <h4>Less than 50% Raised:</h4>
                </HeaderTemplate>
                <ItemTemplate>
                    <div>
                    <asp:Hyperlink runat="server"  ID="Hyperlink1"  NavigateUrl='<%# EditUrl("staffDashboard") & "?staffId=" & Eval("staffId") & "&country=" & Request.QueryString("country")%>'    Text='<%# GetStaffName(Eval("staffId"))%>' ></asp:Hyperlink>
                         <asp:Hyperlink runat="server"  ID="Label2"  NavigateUrl='<%# EditUrl("staffDashboard") & "?staffId=" & Eval("staffId") & "&country=" & Request.QueryString("country")%>'   Text='<%# (CDbl(Eval("SupLev")) * 100).ToString("0.00") & "%"%>'  ></asp:Hyperlink>
                        </div>
                </ItemTemplate>

            </asp:Repeater>
        </div>
        <div class="well listDetail" id="d_low">
            <asp:Repeater ID="rpLow" runat="server">
                <HeaderTemplate>
                    <h4>50-75% Raised</h4>
                </HeaderTemplate>
                <ItemTemplate>
                    <div>
                        <asp:Hyperlink runat="server"  ID="Hyperlink1"  NavigateUrl='<%# EditUrl("staffDashboard") & "?staffId=" & Eval("staffId") & "&country=" & Request.QueryString("country")%>'    Text='<%# GetStaffName(Eval("staffId"))%>' ></asp:Hyperlink>
                         <asp:Hyperlink runat="server"  ID="Label2"  NavigateUrl='<%# EditUrl("staffDashboard") & "?staffId=" & Eval("staffId") & "&country=" & Request.QueryString("country")%>'   Text='<%# (CDbl(Eval("SupLev")) * 100).ToString("0.00") & "%"%>'  ></asp:Hyperlink>
                    </div>
                </ItemTemplate>

            </asp:Repeater>
        </div>
        <div class="well listDetail" id="d_medium">
            <asp:Repeater ID="rpMedium" runat="server">
                <HeaderTemplate>
                    <h4>75-90% Raised</h4>
                </HeaderTemplate>
                <ItemTemplate>
                    <div>
                        <asp:Hyperlink runat="server"  ID="Hyperlink1"  NavigateUrl='<%# EditUrl("staffDashboard") & "?staffId=" & Eval("staffId") & "&country=" & Request.QueryString("country")%>'    Text='<%# GetStaffName(Eval("staffId"))%>' ></asp:Hyperlink>
                         <asp:Hyperlink runat="server"  ID="Label2"  NavigateUrl='<%# EditUrl("staffDashboard") & "?staffId=" & Eval("staffId") & "&country=" & Request.QueryString("country")%>'   Text='<%# (CDbl(Eval("SupLev")) * 100).ToString("0.00") & "%"%>'  ></asp:Hyperlink>
                    </div>
                </ItemTemplate>

            </asp:Repeater>
        </div>
        <div class="well listDetail" id="d_high">
            <asp:Repeater ID="rpHigh" runat="server">
                <HeaderTemplate>
                    <h4>90-100% Raised</h4>
                </HeaderTemplate>
                <ItemTemplate>
                    <div>
                        <asp:Hyperlink runat="server"  ID="Hyperlink1"  NavigateUrl='<%# EditUrl("staffDashboard") & "?staffId=" & Eval("staffId") & "&country=" & Request.QueryString("country")%>'    Text='<%# GetStaffName(Eval("staffId"))%>' ></asp:Hyperlink>
                         <asp:Hyperlink runat="server"  ID="Label2"  NavigateUrl='<%# EditUrl("staffDashboard") & "?staffId=" & Eval("staffId") & "&country=" & Request.QueryString("country")%>'   Text='<%# (CDbl(Eval("SupLev")) * 100).ToString("0.00") & "%"%>'  ></asp:Hyperlink>
                    </div>
                </ItemTemplate>

            </asp:Repeater>
        </div>
        <div class="well listDetail" id="d_full">
            <asp:Repeater ID="rpFull" runat="server">
                <HeaderTemplate>
                    <h4>>100% Raised</h4>
                </HeaderTemplate>
                <ItemTemplate>
                    <div>
                      
                          <asp:Hyperlink runat="server"  ID="Hyperlink1"  NavigateUrl='<%# EditUrl("staffDashboard") & "?staffId=" & Eval("staffId") & "&country=" & Request.QueryString("country")%>'    Text='<%# GetStaffName(Eval("staffId"))%>' ></asp:Hyperlink>
                         <asp:Hyperlink runat="server"  ID="Label2"  NavigateUrl='<%# EditUrl("staffDashboard") & "?staffId=" & Eval("staffId") & "&country=" & Request.QueryString("country")%>'   Text='<%# (CDbl(Eval("SupLev")) * 100).ToString("0.00") & "%"%>'  ></asp:Hyperlink>
                    </div>
                </ItemTemplate>

            </asp:Repeater>
        </div>
        <div class="well listDetail" id="d_none">
            <asp:Repeater ID="rpNone" runat="server">
                <HeaderTemplate>
                    <h4>No Budget</h4>
                </HeaderTemplate>
                <ItemTemplate>
                    <div>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("Value")%>'></asp:Label></div>

                </ItemTemplate>

            </asp:Repeater>
        </div>
    </div>
</div>



<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>