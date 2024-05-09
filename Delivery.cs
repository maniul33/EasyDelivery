using System;
using System.Net.Sockets;

namespace EasyDelivery
{
    public class Delivery
    {
        internal string d_id { get; set; }
        internal string cus_name { get; set; }
        internal long cus_phone { get; set; }
        internal string cus_district { get; set; }
        internal string cus_area { get; set; }
        internal string cus_street { get; set; }
        internal string cus_zip { get; set; }
        internal float AmountToCollect { get; set; }
        internal string DeliveryStatus { get; set; }
        internal string rider_id { get; set; }
        internal string rider_name { get; set; }
        internal string store_name {  get; set; }
        internal string store_id { get; set; }

        public Delivery(string d_id, string cus_name, long cus_phone, float AmountToCollect, string DeliveryStatus, string rider_id, string rider_name)
        {
            this.d_id = d_id;
            this.cus_name = cus_name;
            this.cus_phone = cus_phone;
            this.AmountToCollect = AmountToCollect;
            this.DeliveryStatus = DeliveryStatus;
            this.rider_id = rider_id;
            this.rider_name = rider_name;
        }

        public Delivery(string d_id, string cus_name, long cus_phone, string cus_district, string cus_area, string cus_street, string cus_zip, float AmountToCollect, string DeliveryStatus, string rider_id, string rider_name, string store_name, string store_id)
        {
            this.d_id = d_id;
            this.cus_name = cus_name;
            this.cus_phone = cus_phone;
            this.cus_district = cus_district;
            this.cus_area = cus_area;
            this.AmountToCollect = AmountToCollect;
            this.DeliveryStatus = DeliveryStatus;
            this.rider_id = rider_id;
            this.rider_name = rider_name;
            this.store_name = store_name;
            this.store_id = store_id;
            this.cus_street = cus_street;
            this.cus_zip = cus_zip;
        }
    }
}

