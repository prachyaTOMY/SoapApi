using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using SoapDataApi.Model;

namespace SoapDataApi.Service
{
    public static class DataService
    {
        private static readonly MySqlConnection cnx = new MySqlConnection();

        public static void OpenConnection()
        {
            cnx.ConnectionString = "Server=127.0.0.1;Uid=root;Pwd=;Database=infromdata;";
            cnx.Open();
        }

        public static So GetLastData()
        {
            OpenConnection();
            var target = new So();
            var cmd = new MySqlCommand();
      
            cmd.CommandText = "SELECT * FROM so";
            cmd.Connection = cnx;
   
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                target.SO_No = dr.GetInt16("SO_No");
                target.Status_Rec = dr.GetString("Status_Rec");
                target.SAP_No = dr.GetInt16("SAP_No");
                target.Status = dr.GetString("Status");
                target.Level_Impact = dr.GetString("Level_Impact");
                target.Service_Type = dr.GetString("Service_Type");
                target.CheckCosts = dr.GetInt16("CheckCosts");
                target.D_System = dr.GetDateTime("D_System");
                target.T_System = dr.GetDateTime("T_System");
                target.D_Open = dr.GetDateTime("D_Open");
                target.T_Open = dr.GetDateTime("T_Open");
                target.Network_Type = dr.GetString("Network_Type");
                target.Eqt_Type = dr.GetString("Eqt_Type");
                target.Node_ID = dr.GetInt16("Node_ID");
                target.Node_Name = dr.GetString("Node_Name");
                target.Sub_Area = dr.GetString("Sub_Area");
                target.Remark = dr.GetString("Remark");
                target.Open_By = dr.GetString("Open_By");

            }

            CloseConnection();

            return target;
        }

        public static Impact GetLastImpactData()
        {
            OpenConnection();
            var target = new Impact();
            var cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM impact";
            cmd.Connection = cnx;

            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                target.Id = dr.GetInt16("Id");
                target.Impact_ID = dr.GetInt32("Impact_ID");
                target.SO_No = dr.GetString("SO_No");
                target.D_Down = dr.GetDateTime("D_Down");
                target.T_Down = dr.GetDateTime("T_Down");
                target.D_Ins = dr.GetString("D_Ins");
                target.T_Ins = dr.GetString("T_Ins");
                target.Node_ID = dr.GetString("Node_ID");
                target.Trunk_ID = dr.GetString("Trunk_ID");
                target.Trunk_Name = dr.GetString("Trunk_Name");
                target.Cust_ID = dr.GetInt32("Cust_ID");
                target.Circuit_ID = dr.GetInt32("Circuit_ID");
                target.Circuit_Name = dr.GetString("Circuit_Name");
                target.Customer_Name = dr.GetString("Customer_Name");
                target.Slave = dr.GetString("Slave");
                target.Unit = dr.GetInt32("Unit");
                target.Interface = dr.GetString("Interface");
                target.Card_Type = dr.GetString("Card_Type");
                target.Alarm = dr.GetString("Alarm");
            }

            CloseConnection();

            return target;
        }

        public static So Save(int SO_No,
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
             string Open_By)
        {
            OpenConnection();
            var target = new So();
            var cmd = new MySqlCommand();

            cmd.CommandText = @"INSERT INTO so (SO_No,Status_Rec,SAP_No,Status,Level_Impact,Service_Type,CheckCosts,D_System,T_System,D_Open,T_Open,Network_Type,Eqt_Type,Node_ID,Node_Name,Sub_Area,Remark,Open_By)
                                VALUES
                                (
                                    @SO_No,
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

            MySqlDataReader dr = cmd.ExecuteReader();
            cmd.Parameters.AddWithValue("@SO_No", SO_No);
            cmd.Parameters.AddWithValue("@Status_Rec", Status_Rec);
            cmd.Parameters.AddWithValue("@SAP_No", SAP_No);
            cmd.Parameters.AddWithValue("@Status", Status);
            cmd.Parameters.AddWithValue("@Level_Impact", Level_Impact);
            cmd.Parameters.AddWithValue("@Service_Type", Service_Type);
            cmd.Parameters.AddWithValue("@CheckCosts", CheckCosts);
            cmd.Parameters.AddWithValue("@D_System", D_System);
            cmd.Parameters.AddWithValue("@T_System", T_System);
            cmd.Parameters.AddWithValue("@Network_Type", Network_Type);
            cmd.Parameters.AddWithValue("@Eqt_Type", Eqt_Type);
            cmd.Parameters.AddWithValue("@Node_ID", Node_ID);
            cmd.Parameters.AddWithValue("@Node_Name", Node_Name);
            cmd.Parameters.AddWithValue("@Sub_Area", Sub_Area);
            cmd.Parameters.AddWithValue("@Remark", Remark);
            cmd.Parameters.AddWithValue("@Open_By", Open_By);
            cmd.ExecuteNonQuery();

            CloseConnection();

            return target;
        }

        private static void CloseConnection()
        {
            cnx.Close();
        }
    }
}