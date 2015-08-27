<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPage.master" AutoEventWireup="true" CodeBehind="BillView.aspx.cs" Inherits="SelfServices.Pages.BillViewPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <form id="form1" runat="server">
    <table class="style1" style="width: 734px; font-family: 'Times New Roman';" left="300px" top="760px" height="468px" align="center">
    <tr>
        <td colspan="3" align="center" bgcolor="White" style="height: 20px">
            Masked Customer Name</td>
    </tr>
        <tr>
        <td bgcolor="White" colspan="3" align="center" style="font-size: large; font-weight: bold">
            Primary Number : <asp:Label ID="lblPhone" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td  class="style5" colspan="3" bgcolor="White" style="height: 20px; font-size: large; font-weight: bold;" align="center">
            Account Number : <asp:Label ID="lblAccount" runat="server"></asp:Label></td>
    </tr>
        <tr>
        <td class="modal-sm" bgcolor="White" style="width: 243px">
            &nbsp;</td>
        <td bgcolor="White" style="width: 245px">
            &nbsp;</td>
        <td class="style10" style="width: 245px" bgcolor="White">
            &nbsp;</td>
    </tr>
    <tr>
        <td align="center" class="style5" colspan="3" bgcolor="White" style="height: 23px; font-size: large; font-weight: bold;">
            Bill Date : <asp:Label ID="lblDate" runat="server"></asp:Label></td>
    </tr>
        <tr>
        <td class="modal-sm" bgcolor="White" style="width: 243px">
            &nbsp;</td>
        <td bgcolor="White" style="width: 245px">
            &nbsp;</td>
        <td class="style10" style="width: 245px" bgcolor="White">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style7" colspan="3" bgcolor="Red" style="color: #FFFFFF; font-size: xx-large; font-style: normal;">
            Details of Current Charges</td>
    </tr>
    <tr>
        <td class="style7" colspan="3" bgcolor="White" style="color: #FFFFFF">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style7" colspan="3" bgcolor="Red" style="color: #FFFFFF; font-size: x-large;">
            Fios TV, Internet &amp; Phone Bundle</td>
    </tr>
        <tr>
        <td bgcolor="White" colspan="3">
            Your bundle includes Fios TV Prime HD which includes $12.99 for basic services , Fios internet 50/50 and Twenty Fifteen Freedom Essentials</td>
    </tr>
    <tr>
        <td bgcolor="White" colspan="3">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="modal-sm" bgcolor="White" style="border-color: #FFFFFF; border-bottom-style: outset;">
            Bundle Price</td>
        <td align="right" bgcolor="White" style="border-color: #FFFFFF; border-bottom-style: outset;">
          <asp:Label ID="lblBundlePrice" runat="server"></asp:Label></td>
        <td class="style10" style="border-color: #FFFFFF; border-bottom-style: outset;" bgcolor="White" align="center">
            <asp:Label ID="lblBundleDate" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td bgcolor="White" colspan="3">
            <br />
        </td>
    </tr>
    <tr>
        <td class="style12" colspan="3" bgcolor="Red" style="color: #FFFFFF; font-size: x-large;">
            Additional Services &amp; Equipment</td>
    </tr>
        <tr>
        <td class="modal-sm" bgcolor="White" style="width: 243px; font-size: medium; font-style: italic;">
            &nbsp;</td>
        <td bgcolor="White" style="width: 245px">
            &nbsp;</td>
        <td class="style10" style="width: 245px" bgcolor="White">
            &nbsp;</td>
        </tr>
        <tr>
        <td class="modal-sm" bgcolor="White" style="width: 243px; font-size: medium; font-style: italic; font-weight: bold; color: #FF0000;">
            Services</td>
        <td bgcolor="White" style="width: 245px">
            &nbsp;</td>
        <td class="style10" style="width: 245px" bgcolor="White">
            &nbsp;</td>
    </tr>
        <tr>
        <td class="modal-sm" bgcolor="White" style="width: 243px; font-size: medium; font-style: italic;">
            &nbsp;</td>
        <td bgcolor="White" style="width: 245px">
            &nbsp;</td>
        <td class="style10" style="width: 245px" bgcolor="White">
            &nbsp;</td>
        </tr>
    <tr>
        <td class="modal-sm" bgcolor="White" style="border-bottom-style: outset; border-top-color: #FFFFFF;">
            Online Equipment and Sharing/10 GB</td>
        <td align="right" bgcolor="White" style="border-bottom-style: outset; border-top-color: #FFFFFF;">
           <asp:Label ID="lblOnlineBackup" runat="server"></asp:Label></td>
        <td class="style10" align="center" style="border-bottom-style: outset; border-top-color: #FFFFFF;" bgcolor="White">
            <asp:Label ID="lblOnlineBackupDate" runat="server"></asp:Label></td>
    </tr>
        <tr>
        <td class="modal-sm" bgcolor="White" style="width: 243px; font-size: medium; font-style: italic;">
            &nbsp;</td>
        <td bgcolor="White" style="width: 245px">
            &nbsp;</td>
        <td class="style10" style="width: 245px" bgcolor="White">
            &nbsp;</td>
        </tr>
    <tr>
        <td bgcolor="White" style="font-size: medium; font-style: italic; font-weight: bold; color: #FF0000;" colspan="3">
            Equipment</td>
    </tr>
        <tr>
        <td class="modal-sm" bgcolor="White" style="width: 243px; font-size: medium; font-style: italic;">
            &nbsp;</td>
        <td bgcolor="White" style="width: 245px">
            &nbsp;</td>
        <td class="style10" style="width: 245px" bgcolor="White">
            &nbsp;</td>
        </tr>
    <tr>
        <td class="modal-sm" bgcolor="White" style="border-bottom-style: outset; border-top-color: #FFFFFF;">
            (Rent):Set Top Box</td>
        <td align="right" bgcolor="White" style="border-bottom-style: outset; border-top-color: #FFFFFF;">
           <asp:Label ID="lblSetTop" runat="server"></asp:Label></td>
        <td class="style10" style="border-bottom-style: outset; border-top-color: #FFFFFF;" bgcolor="White" align="center">
            <asp:Label ID="lblSetTopDate" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td class="modal-sm" bgcolor="White" style="width: 243px; height: 23px;">
            (Rent):HD Multi-Room DVR</td>
        <td align="right" bgcolor="White" style="width: 245px; height: 23px;">
           <asp:Label ID="lblHD" runat="server"></asp:Label></td>
        <td class="style10" style="width: 245px; height: 23px;" bgcolor="White" align="center">
           <asp:Label ID="lblHDDate" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td class="modal-sm" bgcolor="White" style="width: 243px; font-size: large; font-weight: bold;">
            <br />
            SubTotal</td>
        <td align="right" bgcolor="White" style="width: 245px"><hr />
            <asp:Label ID="lblSubTotal" runat="server" Font-Bold="True" Font-Size="Large"></asp:Label></td>
        <td class="style10" style="width: 245px" bgcolor="White"><br />
            &nbsp;</td>
    </tr>
    <tr>
        <td class="modal-sm" bgcolor="White" style="width: 243px">
            &nbsp;</td>
        <td bgcolor="White" style="width: 245px">
            &nbsp;</td>
        <td class="style10" style="width: 245px" bgcolor="White">
            &nbsp;</td>
    </tr>
    <tr>
        <td bgcolor="White" colspan="3">
            &nbsp;</td>
    </tr>
         <tr>
        <td class="style12" colspan="3" bgcolor="Red" style="color: #FFFFFF; font-size: x-large;">
            Fees &amp; Other Charges</td>
        </tr>
        <tr>
        <td class="modal-sm" bgcolor="White" style="width: 243px; font-size: medium; font-style: italic;">
            &nbsp;</td>
        <td bgcolor="White" style="width: 245px">
            &nbsp;</td>
        <td class="style10" style="width: 245px" bgcolor="White">
            &nbsp;</td>
        </tr>
        <tr>
        <td bgcolor="White" style="font-size: medium; font-style: italic; font-weight: bold; color: #FF0000;" colspan="3">
            Taxes, Governmental Fees &amp; surcharges</td>
        </tr>
        <tr>
        <td class="modal-sm" bgcolor="White" style="width: 243px; font-size: medium; font-style: italic;">
            &nbsp;</td>
        <td bgcolor="White" style="width: 245px">
            &nbsp;</td>
        <td class="style10" style="width: 245px" bgcolor="White">
            &nbsp;</td>
        </tr>
        <tr>
        <td class="modal-sm" bgcolor="White" style="border-bottom-style: outset; border-top-color: #FFFFFF;">
            Federal Excise Tax</td>
        <td align="right" bgcolor="White" style="border-bottom-style: outset; border-top-color: #FFFFFF;">
           <asp:Label ID="lblFederalTax" runat="server"></asp:Label></td>
        <td class="style10" align="center" style="border-bottom-style: outset; border-top-color: #FFFFFF;" bgcolor="White">
            &nbsp;</td>
        </tr>
        <tr>
        <td class="modal-sm" bgcolor="White" style="border-bottom-style: outset; border-top-color: #FFFFFF;">
            NJ State Sales Tax</td>
        <td align="right" bgcolor="White" style="border-bottom-style: outset; border-top-color: #FFFFFF;">
           <asp:Label ID="lblStateSales" runat="server"></asp:Label></td>
        <td class="style10" align="center" style="border-bottom-style: outset; border-top-color: #FFFFFF;" bgcolor="White">
            &nbsp;</td>
        </tr>
        <tr>
        <td class="modal-sm" bgcolor="White" style="width: 243px; height: 23px;">
            911 System/Emerg Resp Fee</td>
        <td align="right" bgcolor="White" style="width: 245px; height: 23px;">
           <asp:Label ID="lblEmergFee" runat="server"></asp:Label></td>
        <td class="style10" align="center" style="width: 245px; height: 23px;" bgcolor="White">
            &nbsp;</td>
        </tr>
        <tr>
        <td class="modal-sm" bgcolor="White" style="width: 243px; font-size: medium; font-style: italic;">
            &nbsp;</td>
        <td bgcolor="White" style="width: 245px">
            &nbsp;</td>
        <td class="style10" style="width: 245px" bgcolor="White">
            &nbsp;</td>
        </tr>
        <tr>
        <td bgcolor="White" style="font-size: medium; font-style: italic; font-weight: bold; color: #FF0000;" colspan="3">
            Twenty Fifteen Surcharges &amp; Fees</td>
        </tr>
        <tr>
        <td class="modal-sm" bgcolor="White" style="width: 243px; font-size: medium; font-style: italic;">
            &nbsp;</td>
        <td bgcolor="White" style="width: 245px">
            &nbsp;</td>
        <td class="style10" style="width: 245px" bgcolor="White" spellcheck="false">
            &nbsp;</td>
        </tr>
        <tr>
        <td class="modal-sm" bgcolor="White" style="border-bottom-style: outset; border-top-color: #FFFFFF;">
            Federal Universal Service Fee</td>
        <td align="right" bgcolor="White" style="border-bottom-style: outset; border-top-color: #FFFFFF;">
           <asp:Label ID="lblUniversalFee" runat="server"></asp:Label></td>
        <td class="style10" align="center" style="border-bottom-style: outset; border-top-color: #FFFFFF;" bgcolor="White">
            &nbsp;</td>
        </tr>
        <tr>
        <td class="modal-sm" bgcolor="White" style="border-bottom-style: outset; border-top-color: #FFFFFF;">
            Regulatory Recover Fee-Federal</td>
        <td align="right" bgcolor="White" style="border-bottom-style: outset; border-top-color: #FFFFFF;">
           <asp:Label ID="lblRegulatory" runat="server"></asp:Label></td>
        <td class="style10" align="center" style="border-bottom-style: outset; border-top-color: #FFFFFF;" bgcolor="White">
            &nbsp;</td>
        </tr>
        <tr>
        <td class="modal-sm" bgcolor="White" style="border-bottom-style: outset; border-top-color: #FFFFFF;">
            VLD Carrier Cost Recovery Charge</td>
        <td align="right" bgcolor="White" style="border-bottom-style: outset; border-top-color: #FFFFFF;">
           <asp:Label ID="lblVLDCarrier" runat="server"></asp:Label></td>
        <td class="style10" align="center" style="border-bottom-style: outset; border-top-color: #FFFFFF;" bgcolor="White">
            &nbsp;</td>
        </tr>
        <tr>
        <td class="modal-sm" bgcolor="White" style="border-bottom-style: outset; border-top-color: #FFFFFF;">
            Federal Subscriber Line and Access Recovery Charge</td>
        <td align="right" bgcolor="White" style="border-bottom-style: outset; border-top-color: #FFFFFF;">
           <asp:Label ID="lblFederalSubscriber" runat="server"></asp:Label></td>
        <td class="style10" align="center" style="border-bottom-style: outset; border-top-color: #FFFFFF;" bgcolor="White">
            &nbsp;</td>
        </tr>
        <tr>
        <td class="modal-sm" bgcolor="White" style="border-bottom-style: outset; border-top-color: #FFFFFF;">
            Video Franchise Fee</td>
        <td align="right" bgcolor="White" style="border-bottom-style: outset; border-top-color: #FFFFFF;">
           <asp:Label ID="lblVideo" runat="server"></asp:Label></td>
        <td class="style10" align="center" style="border-bottom-style: outset; border-top-color: #FFFFFF;" bgcolor="White">
            &nbsp;</td>
        </tr>
        <tr>
        <td class="modal-sm" bgcolor="White" style="border-bottom-style: outset; border-top-color: #FFFFFF;">
            VLD Long Distance Administrative Charge</td>
        <td align="right" bgcolor="White" style="border-bottom-style: outset; border-top-color: #FFFFFF;">
           <asp:Label ID="lblVLDLong" runat="server"></asp:Label></td>
        <td class="style10" align="center" style="border-bottom-style: outset; border-top-color: #FFFFFF;" bgcolor="White">
            &nbsp;</td>
        </tr>
        <tr>
        <td class="modal-sm" bgcolor="White" style="border-bottom-style: outset; border-top-color: #FFFFFF;">
            CATV Universal Access Fund</td>
        <td align="right" bgcolor="White" style="border-bottom-style: outset; border-top-color: #FFFFFF;">
           <asp:Label ID="lblCATVAccess" runat="server"></asp:Label></td>
        <td class="style10" align="center" style="border-bottom-style: outset; border-top-color: #FFFFFF;" bgcolor="White">
            &nbsp;</td>
        </tr>
        <tr>
        <td class="modal-sm" bgcolor="White" style="border-bottom-style: outset; border-top-color: #FFFFFF;">
            Regional Sports Network Fee</td>
        <td align="right" bgcolor="White" style="border-bottom-style: outset; border-top-color: #FFFFFF;">
           <asp:Label ID="lblRegionalSports" runat="server"></asp:Label></td>
        <td class="style10" align="center" style="border-bottom-style: outset; border-top-color: #FFFFFF;" bgcolor="White">
            &nbsp;</td>
        </tr>
        <tr>
        <td class="modal-sm" bgcolor="White" style="width: 243px; height: 23px;">
            FiOS TV Broadcast Fee</td>
        <td align="right" bgcolor="White" style="width: 245px; height: 23px;">
           <asp:Label ID="lblFIOSBroardcast" runat="server"></asp:Label></td>
        <td class="style10" align="center" style="width: 245px; height: 23px;" bgcolor="White">
            &nbsp;</td>
        </tr>
        <tr>
        <td class="modal-sm" bgcolor="White" style="width: 243px; font-size: large; font-weight: bold;">
            <br />
            SubTotal</td>
        <td align="right" bgcolor="White" style="width: 245px"><hr />
            <asp:Label ID="lblSubTotalFees" runat="server" Font-Bold="True" Font-Size="Large"></asp:Label></td>
        <td class="style10" style="width: 245px" bgcolor="White"><br />
            &nbsp;</td>
        </tr>
        <tr>
        <td class="modal-sm" bgcolor="White" style="width: 243px; height: 23px;">
            &nbsp;</td>
        <td align="right" bgcolor="White" style="width: 245px; height: 23px;">
            &nbsp;</td>
        <td class="style10" align="center" style="width: 245px; height: 23px;" bgcolor="White">
            &nbsp;</td>
        </tr>
         <tr>
        <td class="modal-sm" bgcolor="White" style="width: 243px; font-size: large; font-weight: bold;">
            <br />
            Total Due</td>
        <td align="right" bgcolor="White" style="width: 245px"><hr />
            <asp:Label ID="lblTotalDue" runat="server" Font-Bold="True" Font-Size="Large"></asp:Label></td>
        <td class="style10" style="width: 245px" bgcolor="White"><br />
            &nbsp;</td>
        </tr>
         <tr>
        <td class="modal-sm" bgcolor="White" style="width: 243px; height: 23px;">
             </td>
        <td bgcolor="White" style="width: 245px; height: 23px;">
             </td>
        <td class="style10" style="width: 245px; height: 23px;" bgcolor="White">
             </td>
    </tr>
         <tr>
        <td bgcolor="White" align="center" colspan="3" style="height: 30px">
            &nbsp;</td> </tr>
         <tr>
        <td class="modal-sm" bgcolor="White" style="width: 243px">
            &nbsp;</td>
        <td bgcolor="White" style="width: 245px">
            &nbsp;</td>
        <td class="style10" style="width: 245px" bgcolor="White">
            &nbsp;</td>
    </tr>
         <tr>
        <td class="modal-sm" bgcolor="White" style="width: 243px">
            &nbsp;</td>
        <td bgcolor="White" style="width: 245px">
            &nbsp;</td>
        <td class="style10" style="width: 245px" bgcolor="White">
            &nbsp;</td>
    </tr>
         <tr>
        <td class="modal-sm" bgcolor="White" style="width: 243px">
            &nbsp;</td>
        <td bgcolor="White" style="width: 245px">
            &nbsp;</td>
        <td class="style10" style="width: 245px" bgcolor="White">
            &nbsp;</td>
    </tr>

</table>

    </form>
</asp:Content>
