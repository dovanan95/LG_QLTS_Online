using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.IO;
using System.Data.SqlClient;
using System.Data;


namespace Test
{
    public partial class Bien_Ban : System.Web.UI.Page
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["QLTSConnectionString"].ConnectionString;
        OracleConnection con = new OracleConnection(connectionString);

        OracleConnection connect = new OracleConnection(connectionString);
        ReportFunction Report = new ReportFunction();
        Xuat_Bien_Ban Xuat_Bien_Ban = new Xuat_Bien_Ban();

        /*private string Export = "Xuat_Kho";
        private string Repair = "Sua_chua";
        private string Borrow = "Muon_vat_tu";
        private string Revoke = "Nhan_tra_TS";

        private string Report_type = "";
        private string Report_type_private = "";

        private string strGridviewTransferData = "";
        private string strGridviewTransferDataForAdditional = "";
        private string strGridviewTransferDataforAdditionalofRepair = "";*/
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(this.IsPostBack))
            {
                string SoBB = Request.QueryString["So_BB"];
                if (SoBB != null)
                {
                    txtSoBB.Text = SoBB.ToString();
                    //btnExport_Click(this, new EventArgs());
                }
                else if(SoBB == null)
                {
                    txtSoBB.Text = "";
                }
            }
        }

        protected void btnExport_Click(object sender, EventArgs e)
        {
            /*string SoBB = txtSoBB.Text.ToString();
            Session["SoBB"] = SoBB;
           
            if(Report.CheckApproved(SoBB) == true)
            {
                Report.Export_Func(SoBB);
                Session["DATE"] = Report.DATE;
                Session["Type_BB"] = Report.Type_BB;
                Session["So_BB"] = Report.SoBBBG;
                Session["Note"] = Report.Note;
                Session["Reason"] = Report.Reason;

                Session["dtDevice"] = Report.dtDeviceBB;
                Session["dtMaterial"] = Report.dtMaterialBB;

                Session["ID_dlv"] = Report.ID_Dlv;
                Session["Name_dlv"] = Report.Name_Dlv;
                Session["Mail_dlv"] = Report.Mail_Dlv;
                Session["Phone_dlv"] = Report.Phone_Dlv;
                Session["Dept"] = Report.Dept_Dlv;

                Session["ID_rcv"] = Report.ID_Rcv;
                Session["Name_rcv"] = Report.Name_Rcv;
                Session["Mail_rcv"] = Report.Mail_Rcv;
                Session["Phone_rcv"] = Report.Phone_Rcv;
                Session["Dept_rcv"] = Report.Dept_Rcv;

                Response.Redirect("Xuat_Bien_Ban.aspx");

            }
            else if(Report.CheckApproved(SoBB) == false)
            {
                Response.Write("<script>alert('Yêu cầu xác nhận từ phía Ms.Nhung');</script>");
            }*/

            Export_function(txtSoBB.Text.ToString());

        }
        public void Export_function(string SoBB)
        {

            if (Report.CheckApproved(SoBB) == true)
            {
                Report.Export_Func(SoBB);
                Session["SoBB"] = SoBB;
                Session["DATE"] = Report.DATE;
                Session["Type_BB"] = Report.Type_BB;
                Session["So_BB"] = Report.SoBBBG;
                Session["Note"] = Report.Note;
                Session["Reason"] = Report.Reason;

                Session["dtDevice"] = Report.dtDeviceBB;
                Session["dtMaterial"] = Report.dtMaterialBB;

                Session["ID_dlv"] = Report.ID_Dlv;
                Session["Name_dlv"] = Report.Name_Dlv;
                Session["Mail_dlv"] = Report.Mail_Dlv;
                Session["Phone_dlv"] = Report.Phone_Dlv;
                Session["Dept"] = Report.Dept_Dlv;

                Session["ID_rcv"] = Report.ID_Rcv;
                Session["Name_rcv"] = Report.Name_Rcv;
                Session["Mail_rcv"] = Report.Mail_Rcv;
                Session["Phone_rcv"] = Report.Phone_Rcv;
                Session["Dept_rcv"] = Report.Dept_Rcv;

                Response.Redirect("Xuat_Bien_Ban.aspx");

            }
            else if (Report.CheckApproved(SoBB) == false)
            {
                Response.Write("<script>alert('Yêu cầu xác nhận từ phía Ms.Nhung');</script>");
            }
        }



        protected void txtSoBB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}