using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapDataApi.Model
{
    public class Impact
    {
        public int Id { get; set; }
        public int Impact_ID { get; set; }
        public string SO_No { get; set; }
        public DateTime D_Down { get; set; }
        public DateTime T_Down { get; set; }
        public string D_Ins { get; set; }
        public string T_Ins { get; set; }
        public string Node_ID { get; set; }
        public string Trunk_ID { get; set; }
        public string Trunk_Name { get; set; }
        public int Cust_ID { get; set; }
        public int Circuit_ID { get; set; }
        public string Circuit_Name { get; set; }
        public string Customer_Name { get; set; }
        public string Slave { get; set; }
        public int Unit { get; set; }
        public string Interface { get; set; }
        public string Card_Type { get; set; }
        public string Alarm { get; set; }
    }
}