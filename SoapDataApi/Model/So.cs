using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapDataApi.Model
{
    public class So
    {
        public int SO_No { get; set; }
        public string Status_Rec { get; set; }
        public int SAP_No { get; set; }
        public string Status { get; set; }
        public string Level_Impact { get; set; }
        public string Service_Type { get; set; }
        public int CheckCosts { get; set; }
        public DateTime D_System { get; set; }
        public DateTime T_System { get; set; }
        public DateTime D_Open { get; set; }
        public DateTime T_Open { get; set; }
        public string Network_Type { get; set; }
        public string Eqt_Type { get; set; }
        public int Node_ID { get; set; }
        public string Node_Name { get; set; }
        public string Sub_Area { get; set; }
        public string Remark { get; set; }
        public string Open_By { get; set; }

        public So()
        {
            this.SO_No = 0;
            this.Status_Rec = "";
	        this.SAP_No = 0;
            this.Status = "";
            this.Level_Impact = "";
            this.Service_Type = "";
            this.CheckCosts = 0;
            this.D_System = new DateTime();
            this.T_System = new DateTime();
            this.D_Open = new DateTime();
            this.T_Open = new DateTime();
            this.Network_Type = "";
            this.Eqt_Type = "";
            this.Node_ID = 0;
            this.Node_Name = "";
            this.Sub_Area = "";
            this.Remark = "";
            this.Open_By = "";
        }

        public So(
             int SO_No,
             string Status_Rec,
             int SAP_No,
             string Status,
             string Level_Impact,
             string Service_Type,
             int CheckCosts,
             DateTime D_System,
             DateTime T_System,
             DateTime D_Open,
             DateTime T_Open,
             string Network_Type,
             string Eqt_Type,
             int Node_ID,
             string Node_Name,
             string Sub_Area,
             string Remark,
             string Open_By
        )
        {
            this.SO_No = SO_No;
            this.Status_Rec = Status_Rec;
            this.SAP_No = SAP_No;
            this.Status = Status;
            this.Level_Impact = Level_Impact;
            this.Service_Type = Service_Type;
            this.CheckCosts = CheckCosts;
            this.D_System = D_System;
            this.T_System = T_System;
            this.D_Open = D_Open;
            this.T_Open = T_Open;
            this.Network_Type = Network_Type;
            this.Eqt_Type = Eqt_Type;
            this.Node_ID = Node_ID; ;
            this.Node_Name = Node_Name;
            this.Sub_Area = Sub_Area;
            this.Remark = Remark;
            this.Open_By = Open_By;
        }
    }

    
}