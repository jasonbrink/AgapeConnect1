﻿<%@ Control Language="VB" AutoEventWireup="False" CodeFile="mpdCalc.ascx.vb" Inherits="DotNetNuke.Modules.AgapeConnect.mpdCalc" %>
<%@ Register Src="~/controls/labelcontrol.ascx" TagName="labelcontrol" TagPrefix="uc1" %>
<%@ Register Src="~/DesktopModules/AgapeConnect/mpdCalc/controls/mpdItem.ascx" TagPrefix="uc1" TagName="mpdItem" %>
<%@ Register Src="~/DesktopModules/AgapeConnect/mpdCalc/controls/mpdTotal.ascx" TagPrefix="uc1" TagName="mpdTotal" %>

<script src="/js/jquery.numeric.js" type="text/javascript"></script>
<link href="/Portals/_default/Skins/AgapeBlue/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
<script src="/Portals/_default/Skins/AgapeBlue/bootstrap/js/bootstrap.min.js"></script>

<script type="text/javascript">



    (function ($, Sys) {



        $(document).ready(function () {
            $('.numeric').numeric();


            $('.aButton').button();




            $('.monthly').keyup(function () {
                if ($(this).val().length > 0)
                    $(this).parent().parent().siblings().find('.yearly').val((parseFloat($(this).val()) * 12).toFixed(0));



                handleFormulas();
                if ($(this).hasClass('net')) {
                    var f = $(this).siblings("input['type'='hidden']").val();

                    f = f.replace("{NET}", $(this).val());

                    $(this).parent().find(".net-tax-month").text(eval(f).toFixed(0));

                    $(this).parent().parent().siblings().find('.net-tax-year').text((eval(f) * 12.0).toFixed(0));


                }
                calculateSectionTotal($(this).parent().parent().parent().parent().parent());
            });





            $('.yearly').keyup(function () {
                var monthly = $(this).parent().parent().siblings().find('.monthly');
                if ($(this).val().length > 0)
                    $(monthly).val((parseFloat($(this).val()) / 12).toFixed(0));


                if ($(this).hasClass('net')) {
                    var f = $(monthly).siblings("input['type'='hidden']").val();

                    f = f.replace("{NET}", $(monthly).val());

                    $(monthly).parent().find(".net-tax-month").text(eval(f).toFixed(0));

                    $(this).parent().find(".net-tax-year").text((eval(f) * 12.0).toFixed(0));


                }
                calculateSectionTotal($(this).parent().parent().parent().parent().parent());

            });
            $('.sectionTotal').each(function () {
                calculateSectionTotal($(this).parent().parent().parent().parent());
            });
            $('#<%= cbCompliance.ClientID%>').change(function () {

                if (this.checked)
                    $('#<%= btnSubmit.ClientID%>').removeAttr("disabled");
                else
                    $('#<%= btnSubmit.ClientID%>').attr("disabled", "disabled");
            });



            $('.btn-edit').click(function () {
                
                $('.mpd-edit').hide("slow");
                $(this).parent().siblings('.mpd-edit').show("slow");
                $('.btn-edit').show();
                $(this).hide();
            });

            handleFormulas();

        });
    }(jQuery, window.Sys));
    function calculateSectionTotal(section) {
        var sum = 0.0;
        section.find('.yearly').each(function (i, n) {
            if ($(n).val().length > 0)
                sum += parseFloat($(n).val().replace(/\,/g, ''))

        });

        section.find('.section-total-yearly').text(sum.toFixed(0));
        section.find('.section-total-monthly').text((sum / 12).toFixed(0));
        sum = 0.0;
        $('.sectionTotal').each(function (i, n) {
            if ($(n).text().length > 0)
                sum += parseFloat($(n).text().replace(/\,/g, ''))

        });
        var st = (sum / 12)
        $('.subtotal').text(st.toFixed(0));

        var a = parseFloat($('#<%= hfAssessment.ClientId %>').val()) / 100;
        var a1 = (st * a / (1 - a));

        $('.assessment').text(a1.toFixed(0));
        var g = st + a1
        $('.mpdGoal').text(g.toFixed(0));
        var current = parseFloat($('.currentSupport').val().replace(/\,/g, ''));

        var rem = g - current
        $('.remaining').text(rem.toFixed(0));

        var p = current * 100 / g;
        if (p < 5000)
            $('.percentage').text(p.toFixed(1) + '%');
        else
            $('.percentage').text('');
    }


    function handleFormulas() {
        $('.calculated').each(function () {
            //Go through each formula and refresh the values
            var f = $(this).siblings("input['type'='hidden']").val();

            $('.version-number').each(function () {
                var v = $(this).parent().find('.monthly').val();
                v = v == '' ? 0 : v;


                f = f.replace('{' + $(this).text() + '}', v);


            });
            $(this).val(eval(f).toFixed(0));



            if ($(this).val().length > 0)
                $(this).parent().parent().siblings().find('.yearly').val((parseFloat($(this).val()) * 12).toFixed(0));

            calculateSectionTotal($(this).parent().parent().parent().parent().parent());

        });


    }


</script>
<style type="text/css">
    .mpdInput {
        width: 70px;
    }

    .mpdColumn {
        text-align: right;
    }

    .mpd-help {
        padding-left: 10px;
    }

    .btn-edit {
        position: absolute;
        right: 8px;
    }

    .version-number {
        width: 20px;
        float: left;
        font-size: small;
        font-weight: bold;
        color: lightgray;
    }

    .form-horizontal .control-label {
        width: 200px;
    }

        .form-horizontal .control-label.conf {
            width: 180px;
            margin-left: 8px;
        }

    .checkbox label {
        display: inline-block;
    }

    .checkboxOuter {
        padding: 20px 80px 20px 80px;
    }

    .form-horizontal .control-group.mpdTotal {
        margin-bottom: 0px;
    }

    .percentage {
        float: right;
        font-size: 56pt;
        margin: 55px 100px 15px 15px;
        font-weight: bold;
        position: absolute;
        right: 50px;
    }

    .net-tax {
        font-size: small;
        color: gray;
        font-style: italic;
    }
</style>

<asp:HiddenField ID="hfAssessment" runat="server" Value="0.0" />







<div id="formRoot" class="form-horizontal">

    <asp:Repeater ID="rpSections" runat="server">

        <ItemTemplate>
            <h3>
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("Name")%>'></asp:Label>
            </h3>
            <div class="well">

                <asp:Repeater ID="rpItems" runat="server" DataSource='<%# CType(Eval("AP_mpdCalc_Questions"), System.Data.Linq.EntitySet(Of MPD.AP_mpdCalc_Question)).OrderBy(Function (c) c.QuestionNumber)%>'>

                    <ItemTemplate>
                        <uc1:mpdItem runat="server" ID="mpdItem14" Mode='<%# Eval("Type")%>' Formula='<%# Eval("Formula")%>' ItemName='<%# Eval("Name")%>' Help='<%# Eval("Help")%>' ItemId='<%# Eval("AP_mpdCalc_Section.Number") & "." & Eval("QuestionNumber")%>' />
                    </ItemTemplate>
                </asp:Repeater>

                <uc1:mpdTotal runat="server" ID="totSection1" ItemName="Total Salary & Payroll" Bold="True" IsSectionTotal="True" />
            </div>
        </ItemTemplate>

    </asp:Repeater>


    <div class="well">
        <asp:Label ID="lblPercentage" runat="server" class="percentage" Text=""></asp:Label>
        <uc1:mpdTotal runat="server" ID="totSubTotal" ItemName="SubTotal" Bold="false" Mode="monthly" IsSubtotal="True" />
        <uc1:mpdTotal runat="server" ID="totAssessment" ItemName="Assessment (12%)" Bold="false" Mode="monthly" IsAssessment="True" />
        <uc1:mpdTotal runat="server" ID="totGoal" ItemName="MPD Goal" Bold="True" Mode="monthly" IsMPDGoal="True" />
        <uc1:mpdItem runat="server" ID="itemCurrent" ItemName="Current Support Level" ItemId="" Help="" Mode="BASIC_MONTH" IsCurrentSupport="True" />

        <uc1:mpdTotal runat="server" ID="totRemaining" ItemName="Amount to discover" Bold="false" Mode="monthly" IsRemaining="True" />
        <div style="clear: both" />
        <div class="checkboxOuter">

            <asp:CheckBox ID="cbCompliance" runat="server" CssClass="checkbox" Text="Optional Complience Statement  - e.g. All donaitons that I have received have been forwarded to the National Office." />
        </div>
        <div style="width: 100%; text-align: center;">
            <asp:Button ID="btnSave" runat="server" Text="Save" Font-Size="X-Large" CssClass="btn" />
            &nbsp;&nbsp;
     <asp:Button ID="btnSubmit" runat="server" Text="Submit" Font-Size="X-Large" CssClass="btn btn-primary" Enabled="false" />
        </div>
    </div>

</div>
