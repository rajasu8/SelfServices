using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SelfServices.Models;
namespace SelfServices.Pages
{
    public partial class BillViewPage : System.Web.UI.Page
    {
        Bill customerBill;
        protected void Page_Load(object sender, EventArgs e)
        {
            string customerid = "208";
            customerBill = Bill.GetUserBill(customerid);

            lblPhone.Text = customerBill.PrimaryPhone.ToString();
            lblAccount.Text = customerBill.AccountNumber.ToString();
            lblDate.Text = customerBill.BillDate.ToString();

            lblBundlePrice.Text = customerBill.Details_of_Current_Charges.Fios_TV_Internet_and_Phone_Bundle.BundlePrice.ToString();
            //string service_from = customerBill.Details_of_Current_Charges.Fios_TV_Internet_and_Phone_Bundle.BundlePrice.Service_from.value.ToString();
            //string service_to = customerBill.Details_of_Current_Charges.Fios_TV_Internet_and_Phone_Bundle.BundlePrice.Service_to.value.ToString();
            //lblBundleDate.Text = service_from + "-" + service_to;

            lblOnlineBackup.Text = customerBill.Details_of_Current_Charges.Additional_Services_and_Equipment.Services.Online_Backup_and_Sharing.Price.ToString();
            //lblOnlineBackupDate.Text = customerBill.Details_of_Current_Charges.Additional_Services_and_Equipment.Services.Online_Backup_and_Sharing.Service_from.value.ToString() + "-" + customerBill.Details_of_Current_Charges.Additional_Services_and_Equipment.Services.Online_Backup_and_Sharing.Service_to.value.ToString();

            lblSetTop.Text = customerBill.Details_of_Current_Charges.Additional_Services_and_Equipment.Equipment.Set_Top_Box.Price.ToString();
            //lblSetTopDate.Text = customerBill.Details_of_Current_Charges.Additional_Services_and_Equipment.Equipment.Set_Top_Box.Service_from.value.ToString() + "-" + customerBill.Details_of_Current_Charges.Additional_Services_and_Equipment.Equipment.Set_Top_Box.Service_to.value.ToString();


            lblHD.Text = customerBill.Details_of_Current_Charges.Additional_Services_and_Equipment.Equipment.HD_MultiRoom_DVR.Price.ToString();
            //lblHDDate.Text = customerBill.Details_of_Current_Charges.Additional_Services_and_Equipment.Equipment.HD_MultiRoom_DVR.Service_from.value.ToString() + "-" + customerBill.Details_of_Current_Charges.Additional_Services_and_Equipment.Equipment.HD_MultiRoom_DVR.Service_to.value.ToString();

            lblSubTotal.Text = customerBill.Details_of_Current_Charges.Additional_Services_and_Equipment.Subtotal.ToString();


            lblFederalTax.Text = customerBill.Details_of_Current_Charges.Fees_and_other_charges.Taxes_and_Governmental_fees_and_Surcharges.Federal_exciseTax.value.ToString();
            lblStateSales.Text = customerBill.Details_of_Current_Charges.Fees_and_other_charges.Taxes_and_Governmental_fees_and_Surcharges.State_sales_tax.value.ToString();
            lblEmergFee.Text = customerBill.Details_of_Current_Charges.Fees_and_other_charges.Taxes_and_Governmental_fees_and_Surcharges._911_system_emerg_resp_fee.value.ToString();

            lblUniversalFee.Text = customerBill.Details_of_Current_Charges.Fees_and_other_charges.Verizon_surcharges_and_fees.Federal_Universal_Service.value.ToString();
            lblRegulatory.Text = customerBill.Details_of_Current_Charges.Fees_and_other_charges.Verizon_surcharges_and_fees.Regularity_recovery_fee.value.ToString();
            lblVLDCarrier.Text = customerBill.Details_of_Current_Charges.Fees_and_other_charges.Verizon_surcharges_and_fees.VLD_CCRC.value.ToString();

            lblFederalSubscriber.Text = customerBill.Details_of_Current_Charges.Fees_and_other_charges.Verizon_surcharges_and_fees.Federal_Subscriber_line_and_access.value.ToString();

            lblVideo.Text = customerBill.Details_of_Current_Charges.Fees_and_other_charges.Verizon_surcharges_and_fees.Video_Franchise_fee.value.ToString();

            lblVLDLong.Text = customerBill.Details_of_Current_Charges.Fees_and_other_charges.Verizon_surcharges_and_fees.VLD_long_distance_Administrative_charge.value.ToString();

            lblCATVAccess.Text = customerBill.Details_of_Current_Charges.Fees_and_other_charges.Verizon_surcharges_and_fees.CATV_Universal_access_fund.value.ToString();
            lblRegionalSports.Text = customerBill.Details_of_Current_Charges.Fees_and_other_charges.Verizon_surcharges_and_fees.Regional_Sports_Network_fee.value.ToString();
            lblFIOSBroardcast.Text = customerBill.Details_of_Current_Charges.Fees_and_other_charges.Verizon_surcharges_and_fees.FIOS_TV_Broadcast_fee.value.ToString();


            lblSubTotalFees.Text = customerBill.Details_of_Current_Charges.Fees_and_other_charges.Subtotal.value.ToString();

            lblTotalDue.Text = customerBill.Total_Due.ToString();
        }
    }
}