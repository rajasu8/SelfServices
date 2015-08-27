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
                lblPhone.Text = temp.PrimaryPhone;
                lblAccount.Text = temp.AccountNumber;
                lblDate.Text = temp.BillDate;
                List<string> obj = new List<string>();

                foreach (var service in temp.Account_Summary.CurrentCharges.Services)
                {
                    obj.Add(service.name);
                }
                GridViewService.DataSource = obj;
                GridViewService.DataBind();

                obj = new List<string>();
                foreach (var service in temp.Account_Summary.CurrentCharges.Services)
                {
                    obj.Add(service.price);
                }
                GridViewServiceAmount.DataSource = obj;
                GridViewServiceAmount.DataBind();

                obj = new List<string>();
                foreach (var service in temp.Account_Summary.AdditionalCharges.AdditionalServices)
                {
                    obj.Add(service.name);
                }
                GridViewAddService.DataSource = obj;
                GridViewAddService.DataBind();

                obj = new List<string>();

                foreach (var service in temp.Account_Summary.AdditionalCharges.AdditionalServices)
                {
                    obj.Add(service.price);
                }
                GridViewAddServiceAmount.DataSource = obj;
                GridViewAddServiceAmount.DataBind();



                lblSubTotal1.Text = temp.Account_Summary.CurrentCharges.subtotal;
                lblSubTotal2.Text = temp.Account_Summary.AdditionalCharges.subtotal;

                lblFederalTax.Text = temp.taxes;

                lblTotalDue.Text = temp.totalAmount;
            }
        }
    }
}
