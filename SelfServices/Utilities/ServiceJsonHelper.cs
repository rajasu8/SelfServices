﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.IO;
using SelfServices.Models;
using System.Net;

namespace SelfServices.Utilities
{
    public class ServiceJsonHelper
    {
        private static string PROFILE_PULL_URL = "";

        private static string CHANGE_DUE_DATE_URL = "";

        private static string CANCEL_ORDER_URL = "";

        private static string BILL_PULL_URL = "http://192.168.1.42:8080/BillingSystem/rest/selfservice?accountNumber=";

        private static string BILL_PAY_URL = "";

        public static Profile PullProfile(string customerId)
        {
            Profile customProfile = null;
            //string profileJson = GetJsonFromUrl(String.Format(@"{0}/{1}", PROFILE_PULL_URL, customerId));
            string profileJson = File.ReadAllText("");//give json file path here
            if(!String.IsNullOrWhiteSpace(profileJson))
            {
                ProfilePull fullProfile = GetObjectFromJson<ProfilePull>(profileJson);
                customProfile = fullProfile.GetCustomProfile();
            }
            
            return customProfile;
        }

        public static void ChangeDueDate(string orderId, string newDate)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                    client.UploadString(CHANGE_DUE_DATE_URL, new JavaScriptSerializer().Serialize(new { orderId = orderId, newDate = newDate }));
                }
            }
            catch (Exception e)
            {

            }

        }

        public static void CancelOrder(string orderId)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                    client.UploadString(CANCEL_ORDER_URL, new JavaScriptSerializer().Serialize(new { orderId = orderId }));
                }
            }
            catch(Exception e)
            {

            }
            
        }

        public static Bill GetBill(string customerId)
        {
            Bill bill = null;
            string url = BILL_PULL_URL + customerId;
            string billJson = GetJsonFromUrl(url);
            if (!String.IsNullOrWhiteSpace(billJson))
            {
                bill = GetObjectFromJson<Bill>(billJson);
            }

            return bill;
        }

        public static void PayBill(string customerId, string amountPaid)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                    client.UploadString(BILL_PAY_URL, new JavaScriptSerializer().Serialize(new { customerId = customerId, amountPaid = amountPaid, paidDate = DateTime.Today.ToShortDateString() }));
                }
            }
            catch (Exception e)
            {

            }
        }        

        public static T GetObjectFromJson<T>(string json)
        {
            JavaScriptSerializer convertor = new JavaScriptSerializer();
            T temp= convertor.Deserialize<T>(json);
            return temp;
        }

        public static string GetJsonFromUrl(string url)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    return client.DownloadString(url);
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

    }
}