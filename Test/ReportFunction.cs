using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.SessionState;


namespace Test
{
    public class ReportFunction
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["QLTSConnectionString"].ConnectionString;
        
        OracleConnection con = new OracleConnection(connectionString);
        OracleConnection connect = new OracleConnection(connectionString);
        OracleConnection con2 = new OracleConnection(connectionString);


        //Xuat_Bien_Ban Export_Report = new Xuat_Bien_Ban();

        private string Export = "Xuat_Kho";
        private string Repair = "Sua_chua";
        private string Borrow = "Muon_vat_tu";
        private string Revoke = "Nhan_tra_TS";

        private string Report_type = "";
        private string Report_type_private = "";

        private string strGridviewTransferData = "";
        private string strGridviewTransferDataForAdditional = "";
        private string strGridviewTransferDataforAdditionalofRepair = "";

        public string SoBBBG { get; set; }
        public DataTable dtDeviceBB { get; set; }
        public DataTable dtMaterialBB { get; set; }

        public GridView gridView { get; set; }
        public string Name_Rcv { get; set; }
        public string ID_Rcv { get; set; }
        public string Mail_Rcv { get; set; }
        public string Dept_Rcv { get; set; }
        public string Phone_Rcv { get; set; }
        public string ID_Dlv { get; set; }
        public string Name_Dlv { get; set; }
        public string Mail_Dlv { get; set; }
        public string Dept_Dlv { get; set; }
        public string Phone_Dlv { get; set; }

        public string Type_BB { get; set; }
        public string DATE { get; set; }
        public string Reason { get; set; }
        public string Note { get; set; }


        public void Export_Func(string SoBB)
        {
            try
            {

                string strTypeBB = "select b.Ten_loai, a.Reason, a.CL_DATE from Loai_Bien_ban b inner join Bien_Ban a on b.Ma_loai = a.Ma_loai_BB where a.So_Bien_ban = '" + SoBB + "'";
                OracleDataAdapter daTypeBB = new OracleDataAdapter(strTypeBB, con);
                DataTable dtTypeBB = new DataTable();
                daTypeBB.Fill(dtTypeBB);

                string Receiver = "select * from TB_User a inner join Bien_Ban b on a.ID = b.User_ID where b.So_Bien_ban = '" + SoBB + "'";

                OracleDataAdapter daRcv = new OracleDataAdapter(Receiver, con);
                DataTable dtRcv = new DataTable();
                daRcv.Fill(dtRcv);

                string Deliver = "select * from TB_User a inner join Bien_Ban b on a.ID = b.IT_OP where b.So_Bien_ban = '" + SoBB + "'";
                OracleDataAdapter daDlv = new OracleDataAdapter(Deliver, con2);
                DataTable dtDlv = new DataTable();
                daDlv.Fill(dtDlv);


                string TypeReport = dtTypeBB.Rows[0]["Ten_loai"].ToString().Trim();
                if (TypeReport == "IN_STORAGE")
                {
                    Report_type = Revoke;
                    Report_type_private = "So_BB_nhan";
                    Note = "................................";
                }
                else if (TypeReport == "OUT_STORAGE")
                {
                    Report_type = Export;
                    Report_type_private = "So_BB_xuat";
                    Note = "................................";
                }
                else if (TypeReport == "REPAIR")
                {
                    Report_type = Repair;
                    Report_type_private = "BB_sua";
                    Note = "................................";

                }
                else if (TypeReport == "TEMP_OUT_STORAGE")
                {
                    Report_type = Borrow;
                    Report_type_private = "So_BB";
                    string DueDate = "select Due_date from Muon_vat_tu where So_BB = '" + SoBB + "'";
                    OracleDataAdapter daExpired = new OracleDataAdapter(DueDate, con);
                    DataTable dtExpired = new DataTable();
                    daExpired.Fill(dtExpired);
                    string Due_date = dtExpired.Rows[0][0].ToString();
                    Note = "Return Date:" + Due_date;
                }

                strGridviewTransferData =
                        "select a.Ma_TS, a.Ten_TS, c.Ten_loai, a.SN, a.FA_Tag, a.IT_Tag, a.Model, d.unit_name, e.Ten_tinh_trang " +
                        "from Tai_san a " +
                        "inner join " + Report_type + " b on a.Ma_TS = b.Ma_TS " +
                        "inner join Loai_TS_cap2 c on a.Ma_Loai_TS_cap2 = c.Ma_loai " +
                        "inner join Unit d on d.unit_id = a.Unit " +
                        "inner join Status e on e.Ma_tinh_Trang  = a.Ma_tinh_trang " +
                        "where b." + Report_type_private + "= '" + SoBB + "' and a.Ma_Loai_TS_cap1 = 'DE' and b.APPROVED = 1";

                strGridviewTransferDataForAdditional =
                        "select a.Ma_TS, a.Ten_TS, c.Ten_loai, a.SN, a.Model, d.unit_name, e.Ten_tinh_trang " +
                        "from Tai_san a " +
                        "inner join " + Report_type + " b on a.Ma_TS = b.Ma_TS " +
                        "inner join Loai_TS_cap2 c on a.Ma_Loai_TS_cap2 = c.Ma_loai " +
                        "inner join Unit d on d.unit_id = a.Unit " +
                        "inner join Status e on e.Ma_tinh_Trang  = a.Ma_tinh_trang " +
                        "where not a.Ma_Loai_TS_cap1 = 'DE' and b." + Report_type_private + " = '" + SoBB + "' and b.APPROVED = 1";

                strGridviewTransferDataforAdditionalofRepair =
                        "select a.Ma_TS, a.Ten_TS, c.Ten_loai, a.SN, a.Model, d.unit_name, e.Ten_tinh_trang " +
                        "from Tai_san a " +
                        "inner join " + Report_type + " b on a.Ma_TS = b.Vat_tu_xuat " +
                        "inner join Loai_TS_cap2 c on a.Ma_Loai_TS_cap2 = c.Ma_loai " +
                        "inner join Unit d on d.unit_id = a.Unit " +
                        "inner join Status e on e.Ma_tinh_Trang  = a.Ma_tinh_trang " +
                        "where not a.Ma_Loai_TS_cap1 = 'DE' and b." + Report_type_private + " = '" + SoBB + "' and b.APPROVED = 1";

                SqlCommand cmdGTD = new SqlCommand();

                OracleDataAdapter daDevice = new OracleDataAdapter(strGridviewTransferData, con);
                DataTable dtDevice = new DataTable();
                daDevice.Fill(dtDevice);
                //DataGridView gridView = new DataGridView();
                //gridView.DataSource = dtTest;

                OracleDataAdapter daMaterial = new OracleDataAdapter();
                if (TypeReport == "REPAIR")
                {
                    daMaterial = new OracleDataAdapter(strGridviewTransferDataforAdditionalofRepair, con2);
                }
                else if (TypeReport != "REPAIR")
                {
                    daMaterial = new OracleDataAdapter(strGridviewTransferDataForAdditional, con2);
                }
                DataTable dtMaterial = new DataTable();
                daMaterial.Fill(dtMaterial);



                SoBBBG = SoBB;
                Type_BB = dtTypeBB.Rows[0]["Ten_loai"].ToString();
                Reason = dtTypeBB.Rows[0]["Reason"].ToString();
                DATE = dtTypeBB.Rows[0]["CL_DATE"].ToString();


                dtDeviceBB = dtDevice;
                dtMaterialBB = dtMaterial;

                Name_Rcv = dtRcv.Rows[0]["Name"].ToString();
                ID_Rcv = dtRcv.Rows[0]["ID"].ToString();
                Phone_Rcv = dtRcv.Rows[0]["Phone"].ToString();
                Mail_Rcv = dtRcv.Rows[0]["Mail"].ToString();
                Dept_Rcv = dtRcv.Rows[0]["Dept"].ToString();

                ID_Dlv = dtDlv.Rows[0]["ID"].ToString();
                Name_Dlv = dtDlv.Rows[0]["Name"].ToString();
                Phone_Dlv = dtDlv.Rows[0]["Phone"].ToString();
                Mail_Dlv = dtDlv.Rows[0]["Mail"].ToString();
                Dept_Dlv = dtDlv.Rows[0]["Dept"].ToString();




                //Export_Report.WindowState = FormWindowState.Maximized;
                //Export_Report.FormBorderStyle = FormBorderStyle.FixedDialog;
                //Export_Report.TopMost = true;

            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public bool CheckApproved(string SoBB)
        {
            bool flag = true;
            string CheckApp = "select APPROVED from BIEN_BAN where so_bien_ban = '" + SoBB + "'";
            OracleDataAdapter daCheckApp = new OracleDataAdapter(CheckApp, connect);
            DataTable dtcheck = new DataTable();
            daCheckApp.Fill(dtcheck);
            if (dtcheck.Rows[0][0].ToString() == "N")
            {
                flag = false;
            }
            else if (dtcheck.Rows[0][0].ToString() == "Y")
            {
                flag = true;
            }

            return flag;
        }
    }
}