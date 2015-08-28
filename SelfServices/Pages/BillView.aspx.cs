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
            customerBill = Bill.GetUserBill((string)Session["customerId"]);

            if (customerBill != null)
            {
                if (!IsPostBack)
                    Session.Add("customerBill", customerBill);
                Bill temp = (Bill)Session["customerBill"];

                //Bill temp = customerBill;
                lblPhone.Text = temp.currentBill.PrimaryPhone;
                lblAccount.Text = temp.currentBill.AccountNumber;
                lblDate.Text = temp.currentBill.BillDate;
                List<string> obj = new List<string>();

                foreach (var service in temp.currentBill.Account_Summary.Current_Charges.Services)
                {
                    obj.Add(service.name);
                }
                GridViewService.DataSource = obj;
                GridViewService.DataBind();

                obj = new List<string>();
                foreach (var service in temp.currentBill.Account_Summary.Current_Charges.Services)
                {
                    obj.Add(service.price.ToString());
                }
                GridViewServiceAmount.DataSource = obj;
                GridViewServiceAmount.DataBind();

                obj = new List<string>();
                foreach (var service in temp.currentBill.Account_Summary.Additional_Charges.Additional_Services)
                {
                    obj.Add(service.name);
                }
                GridViewAddService.DataSource = obj;
                GridViewAddService.DataBind();

                obj = new List<string>();

                foreach (var service in temp.currentBill.Account_Summary.Additional_Charges.Additional_Services)
                {
                    obj.Add(service.price.ToString());
                }
                GridViewAddServiceAmount.DataSource = obj;
                GridViewAddServiceAmount.DataBind();



                lblSubTotal1.Text = temp.currentBill.Account_Summary.Current_Charges.Subtotal.ToString();
                lblSubTotal2.Text = temp.currentBill.Account_Summary.Additional_Charges.Subtotal;

                lblFederalTax.Text = temp.currentBill.Taxes;

                lblTotalDue.Text = temp.currentBill.Total_Amount;
            }
        }
    }
}
