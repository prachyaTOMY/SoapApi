using MySql.Data.MySqlClient;
using SoapDataApi.Model;
using SoapDataApi.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SoapDataApi
{

    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class SoapData : System.Web.Services.WebService
    {
        private static readonly MySqlConnection cnx = new MySqlConnection();

        public static void OpenConnection()
        {
            cnx.ConnectionString = "Server=127.0.0.1;Uid=root;Pwd=;Database=infromdata;";
            cnx.Open();
        }

        [WebMethod]
        public So GetLastRequest()
        {
            return DataService.GetLastData();
        }

        [WebMethod]
        public So SaveData(
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
            OpenConnection();
            var target = new So();
            var cmd = new MySqlCommand();

            cmd.CommandText = @"INSERT INTO so (Status_Rec,SAP_No,Status,Level_Impact,Service_Type,CheckCosts,D_System,T_System,D_Open,T_Open,Network_Type,Eqt_Type,Node_ID,Node_Name,Sub_Area,Remark,Open_By)
                                VALUES
                                (
                                    @Status_Rec,
                                    @SAP_No,
                                    @Status,
                                    @Level_Impact,
                                    @Service_Type,
                                    @CheckCosts,
                                    @D_System,
                                    @T_System,
                                    @D_Open,
                                    @T_Open,
                                    @Network_Type,
                                    @Eqt_Type,
                                    @Node_ID,
                                    @Node_Name,
                                    @Sub_Area,
                                    @Remark,
                                    @Open_By 
                                );";
            cmd.Connection = cnx;
            cmd.Parameters.AddWithValue("@Status_Rec", Status_Rec);
            cmd.Parameters.AddWithValue("@SAP_No", SAP_No);
            cmd.Parameters.AddWithValue("@Status", Status);
            cmd.Parameters.AddWithValue("@Level_Impact", Level_Impact);
            cmd.Parameters.AddWithValue("@Service_Type", Service_Type);
            cmd.Parameters.AddWithValue("@CheckCosts", CheckCosts);
            cmd.Parameters.AddWithValue("@D_System", D_System);
            cmd.Parameters.AddWithValue("@T_System", T_System);
            cmd.Parameters.AddWithValue("@D_Open", D_Open);
            cmd.Parameters.AddWithValue("@T_Open", T_Open);
            cmd.Parameters.AddWithValue("@Network_Type", Network_Type);
            cmd.Parameters.AddWithValue("@Eqt_Type", Eqt_Type);
            cmd.Parameters.AddWithValue("@Node_ID", Node_ID);
            cmd.Parameters.AddWithValue("@Node_Name", Node_Name);
            cmd.Parameters.AddWithValue("@Sub_Area", Sub_Area);
            cmd.Parameters.AddWithValue("@Remark", Remark);
            cmd.Parameters.AddWithValue("@Open_By", Open_By);
            cmd.ExecuteNonQuery();
            //MySqlDataReader dr = cmd.ExecuteReader();
            CloseConnection();

            return GetLastRequest();
        }

        [WebMethod]
        public Impact LastDataImpact()
        {
            return DataService.GetLastImpactData();
        }

        [WebMethod]
        public Impact SaveImpactData(
             int Impact_ID,
             string SO_No,
             DateTime D_Down,
             DateTime T_Down,
             string D_Ins,
             string T_Ins,
             string Node_ID,
             string Trunk_ID,
             string Trunk_Name,
             int Cust_ID,
             int Circuit_ID,
             string Circuit_Name,
             string Customer_Name,
             string Slave,
             int Unit,
             string Interface,
             string Card_Type,
             string Alarm
        )
        {
            OpenConnection();
            var target = new Impact();
            var cmd = new MySqlCommand();
            cmd.CommandText = @"INSERT INTO impact(Impact_ID, SO_No, D_Down, T_Down, D_Ins, T_Ins, Node_ID, Trunk_ID, Trunk_Name, Cust_ID, Circuit_ID, Circuit_Name, Customer_Name, Slave, Unit, Interface, Card_Type, Alarm) 
                                VALUES(
                                    @Impact_ID,
                                    @SO_No,
                                    @D_Down,
                                    @T_Down,
                                    @D_Ins,
                                    @T_Ins,
                                    @Node_ID,
                                    @Trunk_ID,
                                    @Trunk_Name,
                                    @Cust_ID,
                                    @Circuit_ID,
                                    @Circuit_Name,
                                    @Customer_Name,
                                    @Slave,
                                    @Unit,
                                    @Interface,
                                    @Card_Type,
                                    @Alarm
                                ); ";
            cmd.Connection = cnx;
            cmd.Parameters.AddWithValue("@Impact_ID", Impact_ID);
            cmd.Parameters.AddWithValue("@SO_No", SO_No);
            cmd.Parameters.AddWithValue("@D_Down", D_Down);
            cmd.Parameters.AddWithValue("@T_Down", T_Down);
            cmd.Parameters.AddWithValue("@D_Ins", D_Ins);
            cmd.Parameters.AddWithValue("@T_Ins", T_Ins);
            cmd.Parameters.AddWithValue("@Node_ID", Node_ID);
            cmd.Parameters.AddWithValue("@Trunk_ID", Trunk_ID);
            cmd.Parameters.AddWithValue("@Trunk_Name", Trunk_Name);
            cmd.Parameters.AddWithValue("@Cust_ID", Cust_ID);
            cmd.Parameters.AddWithValue("@Circuit_ID", Circuit_ID);
            cmd.Parameters.AddWithValue("@Circuit_Name", Circuit_Name);
            cmd.Parameters.AddWithValue("@Customer_Name", Customer_Name);
            cmd.Parameters.AddWithValue("@Slave", Slave);
            cmd.Parameters.AddWithValue("@Unit", Unit);
            cmd.Parameters.AddWithValue("@Interface", Interface);
            cmd.Parameters.AddWithValue("@Card_Type", Card_Type);
            cmd.Parameters.AddWithValue("@Alarm", Alarm);
            cmd.ExecuteNonQuery();

            CloseConnection();

            return LastDataImpact();
        }

        private static void CloseConnection()
        {
            cnx.Close();
        }
    }
}
