using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SelfServices.Utilities;

namespace SelfServices.Models
{


    public class Bill
    {
        public string Name { get; set; }
        public string PrimaryPhone { get; set; }
        public string Address { get; set; }
        public string AccountNumber { get; set; }
        public string BillDate { get; set; }
        public Account_Summary Account_Summary { get; set; }
        public string Total_Due_by_Date { get; set; }
        public Details_Of_Current_Charges Details_of_Current_Charges { get; set; }
        public string Total_Due { get; set; }

        public static Bill GetUserBill(string customerId)
        {
            return ServiceJsonHelper.GetBill(customerId);
        }
    }

    public class Account_Summary
    {
        public Previous_Period Previous_Period { get; set; }
        public Current_Charges Current_Charges { get; set; }
    }

    public class Previous_Period
    {
        public string PreviousBalance { get; set; }
        public string PaymentReceived { get; set; }
        public string BalanceForward { get; set; }
    }

    public class Current_Charges
    {
        public string FIOSTV_Internet_and_Phone_Bundle { get; set; }
        public string Additional_Services_and_Equipment { get; set; }
        public string Fees_and_Other_Charges { get; set; }
    }

    public class Details_Of_Current_Charges
    {
        public Fios_TV_Internet_And_Phone_Bundle Fios_TV_Internet_and_Phone_Bundle { get; set; }
        public Additional_Services_And_Equipment Additional_Services_and_Equipment { get; set; }
        public Fees_And_Other_Charges Fees_and_other_charges { get; set; }
    }

    public class Fios_TV_Internet_And_Phone_Bundle
    {
        public string BundlePrice { get; set; }
    }

    public class Additional_Services_And_Equipment
    {
        public Services Services { get; set; }
        public Equipment Equipment { get; set; }
        public string Subtotal { get; set; }
    }

    public class Services
    {
        public Online_Backup_And_Sharing Online_Backup_and_Sharing { get; set; }
    }

    public class Online_Backup_And_Sharing
    {
        public string Price { get; set; }
    }

    public class Equipment
    {
        public Set_Top_Box Set_Top_Box { get; set; }
        public HD_Multiroom_DVR HD_MultiRoom_DVR { get; set; }
    }

    public class Set_Top_Box
    {
        public string Price { get; set; }
    }

    public class HD_Multiroom_DVR
    {
        public string Price { get; set; }
    }

    public class Fees_And_Other_Charges
    {
        public string Tax { get; set; }
    }


}