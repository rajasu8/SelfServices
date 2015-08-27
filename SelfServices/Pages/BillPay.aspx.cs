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
           
           // Session["customerId"] = 208;
            customerBill = Bill.GetUserBill((string)Session["customerId"]);
            
            if (customerBill != null)
            {
                if (!IsPostBack)
                    Session.Add("customerBill", customerBill);
                Bill temp = (Bill)Session["customerBill"];
                

                lblPhone.Text = temp.PrimaryPhone;
                lblAccount.Text = temp.AccountNumber;
                lblDate.Text = temp.BillDate;

                lblPreviousBalance.Text = temp.Account_Summary.Previous_Period.PreviousBalance;
                lblPaymentReceived.Text = temp.Account_Summary.Previous_Period.PaymentReceived;
                lblBalanceForward.Text = temp.Account_Summary.Previous_Period.BalanceForward;
                //foreach (var service in temp.Account_Summary.CurrentCharges.Services)
                //{
                //    ServicesName.Text += service.name+" ";
                //}
                lblFIOS.Text = temp.Account_Summary.CurrentCharges.subtotal;

                //foreach (var service in temp.Account_Summary.AdditionalCharges.AdditionalServices)
                //{
                //    AdditionalServivesName.Text  += service.name + " ";
                //}
               
                lblAddService.Text = temp.Account_Summary.AdditionalCharges.subtotal;
                lblFees.Text = temp.taxes;
                lblTotalDue1.Text = temp.totalAmount;
                if(DataAccessHelper.IsBillPaid((string)Session["customerId"],temp.BillDate))
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
           ServiceJsonHelper.PayBill((string)Session["customerId"], ((Bill)Session["customerBill"]).totalAmount);
           Pay.Visible = false;
           LabelPay.Visible = true;
           LabelPay.Text = "Thank you for online payment";
        }

        protected void LabelPay_Click(object sender, EventArgs e)
        {
            //Response.Redirect("BillView.aspx");
        }
    }
}