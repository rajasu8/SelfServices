using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SelfServices.Models;

namespace SelfServices.Pages
{
    public partial class BillPay : System.Web.UI.Page
    {
        Bill customerBill;
        protected void Page_Load(object sender, EventArgs e)
        {
            // string json = System.IO.File.ReadAllText(@"D:\bill.json");
            //using (WebClient webClient = new System.Net.WebClient())
            //{
            //    WebClient n = new WebClient();
            //    var json = n.DownloadString("http://192.168.1.35:4782/BillingSystem/rest/selfservice");
            //    string valueOriginal = Convert.ToString(json);
            //Session["customerId"]= 208;
            //customerBill= Bill.GetUserBill(Session["customerId"].ToString());
            string customerid = "208";
            customerBill = Bill.GetUserBill(customerid);
            if (customerBill != null)
            {
                //Session.Add("customerBill", customerBill);
                //Bill temp = (Bill)Session["customerBill"];
                ////lblPhone.Text =.PrimaryPhone.ToString();

                lblPhone.Text = customerBill.PrimaryPhone;
                lblAccount.Text = customerBill.AccountNumber;
                lblDate.Text = customerBill.BillDate;

                lblPreviousBalance.Text = customerBill.Account_Summary.Previous_Period.PreviousBalance;
                lblPaymentReceived.Text = customerBill.Account_Summary.Previous_Period.PaymentReceived;
                //  lblPaymentDate.Text = customerBill.Account_Summary.Previous_Period.PaymentDate.value;
                lblBalanceForward.Text = customerBill.Account_Summary.Previous_Period.BalanceForward;

                lblFIOS.Text = customerBill.Account_Summary.Current_Charges.FIOSTV_Internet_and_Phone_Bundle;
                //string servicefrom = customerBill.Account_Summary.Current_Charges.FIOSTV_Internet_and_Phone_Bundle.Servicefrom.value.ToString();
                //string serviceto = customerBill.Account_Summary.Current_Charges.FIOSTV_Internet_and_Phone_Bundle.Serviceto.value.ToString();
                //lblCCFIOSDate.Text = servicefrom + "-" + serviceto;


                lblAddService.Text = customerBill.Account_Summary.Current_Charges.Additional_Services_and_Equipment;
                lblFees.Text = customerBill.Account_Summary.Current_Charges.Fees_and_Other_Charges;

                lblDueDate1.Text = customerBill.Total_Due_by_Date;
                lblDueDate2.Text = customerBill.Total_Due_by_Date;

                lblTotalDue1.Text = customerBill.Total_Due.ToString();

            }
            //}
        }

        protected void Pay_Click(object sender, EventArgs e)
        {
            Pay.Visible = false;
            LabelPay.Visible = true;
            LabelPay.Text = "Thank you for online payment";


            //DateTime thisDay = DateTime.Now;
            //  Response.Write(temp.Total_Due.value.ToString());
            //Response.Write(thisDay.ToString("d")); (On button click send custID,date,amount due)


        }

        protected void LabelPay_Click(object sender, EventArgs e)
        {
            //Response.Redirect("Default.aspx");
        }
    }
}