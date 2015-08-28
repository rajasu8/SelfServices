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


                //old bill 1

                p1lblPhone.Text = temp.P1.PrimaryPhone;
                p1lblAccount.Text = temp.P1.AccountNumber;
                p1lblDate.Text = temp.P1.BillDate;
                 obj = new List<string>();

                foreach (var service in temp.P1.Account_Summary.Current_Charges.Services)
                {
                    obj.Add(service.name);
                }
                p1GridViewServiceName.DataSource = obj;
                p1GridViewServiceName.DataBind();

                obj = new List<string>();
                foreach (var service in temp.P1.Account_Summary.Current_Charges.Services)
                {
                    obj.Add(service.price.ToString());
                }
                p1GridViewServiceAmount.DataSource = obj;
                p1GridViewServiceAmount.DataBind();

                obj = new List<string>();
                foreach (var service in temp.P1.Account_Summary.Additional_Charges.Additional_Services)
                {
                    obj.Add(service.name);
                }
                p1GridViewAddServiceName.DataSource = obj;
                p1GridViewAddServiceName.DataBind();

                obj = new List<string>();

                foreach (var service in temp.P1.Account_Summary.Additional_Charges.Additional_Services)
                {
                    obj.Add(service.price.ToString());
                }
                p1GridViewAddServiceAmount.DataSource = obj;
                p1GridViewAddServiceAmount.DataBind();



                p1lblSubTotal1.Text = temp.P1.Account_Summary.Current_Charges.Subtotal.ToString();
                p1lblSubTotal2.Text = temp.P1.Account_Summary.Additional_Charges.Subtotal;

                p1lblFederalTax.Text = temp.P1.Taxes;

                p1lblTotalDue.Text = temp.P1.Total_Amount;


                //old bill 2

                p2lblPhone.Text = temp.P2.PrimaryPhone;
                p2lblAccount.Text = temp.P2.AccountNumber;
                p2lblDate.Text = temp.P2.BillDate;
                obj = new List<string>();

                foreach (var service in temp.P2.Account_Summary.Current_Charges.Services)
                {
                    obj.Add(service.name);
                }
                p2GridViewServiceName.DataSource = obj;
                p2GridViewServiceName.DataBind();

                obj = new List<string>();
                foreach (var service in temp.P2.Account_Summary.Current_Charges.Services)
                {
                    obj.Add(service.price.ToString());
                }
                p2GridViewServiceAmount.DataSource = obj;
                p2GridViewServiceAmount.DataBind();

                obj = new List<string>();
                foreach (var service in temp.P2.Account_Summary.Additional_Charges.Additional_Services)
                {
                    obj.Add(service.name);
                }
                p2GridViewAddServiceName.DataSource = obj;
                p2GridViewAddServiceName.DataBind();

                obj = new List<string>();

                foreach (var service in temp.P2.Account_Summary.Additional_Charges.Additional_Services)
                {
                    obj.Add(service.price.ToString());
                }
                p2GridViewAddServiceAmount.DataSource = obj;
                p2GridViewAddServiceAmount.DataBind();



                p2lblSubTotal1.Text = temp.P2.Account_Summary.Current_Charges.Subtotal.ToString();
                p2lblSubTotal2.Text = temp.P2.Account_Summary.Additional_Charges.Subtotal;

                p2lblFederalTax.Text = temp.P2.Taxes;

                p2lblTotalDue.Text = temp.P2.Total_Amount;
            }
        }
    }
}
