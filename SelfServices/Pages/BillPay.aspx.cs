using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SelfServices.Models;
using SelfServices.Utilities;

namespace SelfServices.Pages
{
    public partial class BillPay : System.Web.UI.Page
    {
        Bill customerBill;
        protected void Page_Load(object sender, EventArgs e)
        {

            //Session["customerId"] = 208;
            customerBill = Bill.GetUserBill((string)Session["customerId"]);

            if (customerBill != null)
            {
                if (!IsPostBack)
                    Session.Add("customerBill", customerBill);
                Bill temp = (Bill)Session["customerBill"];

                //Bill temp = Bill.GetUserBill();
                lblPhone.Text = temp.currentBill.PrimaryPhone;
                lblAccount.Text = temp.currentBill.AccountNumber;
                lblDate.Text = temp.currentBill.BillDate;

                lblPreviousBalance.Text = temp.currentBill.Account_Summary.Previous_Period.PreviousBalance;
                lblPaymentReceived.Text = temp.currentBill.Account_Summary.Previous_Period.PaymentReceived;
                lblBalanceForward.Text = temp.currentBill.Account_Summary.Previous_Period.BalanceForward;
                //foreach (var service in temp.Account_Summary.CurrentCharges.Services)
                //{
                //    ServicesName.Text += service.name+" ";
                //}
                lblFIOS.Text = temp.currentBill.Account_Summary.Current_Charges.Subtotal.ToString();

                //foreach (var service in temp.Account_Summary.AdditionalCharges.AdditionalServices)
                //{
                //    AdditionalServivesName.Text  += service.name + " ";
                //}

                lblAddService.Text = temp.currentBill.Account_Summary.Additional_Charges.Subtotal;
                lblFees.Text = temp.currentBill.Taxes;
                lblTotalDue1.Text = temp.currentBill.Total_Amount;
                if (DataAccessHelper.IsBillPaid((string)Session["customerId"], temp.currentBill.BillDate))
                {
                    Pay.Visible = false;
                    LabelPay.Visible = true;
                    LabelPay.Text = "Thank you for online payment";
                }
                else
                {
                    Pay.Visible = true;
                }
            }
        }


        protected void Pay_Click(object sender, EventArgs e)
        {
            ServiceJsonHelper.PayBill((string)Session["customerId"], ((Bill)Session["customerBill"]).currentBill.BillDate);
            Pay.Visible = false;
            LabelPay.Visible = true;
            LabelPay.Text = "Thank you for online payment";
        }

        protected void LabelPay_Click(object sender, EventArgs e)
        {
            Response.Redirect("BillView.aspx");
        }
    }
}