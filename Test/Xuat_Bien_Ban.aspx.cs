using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Test
{
    public partial class Xuat_Bien_Ban : System.Web.UI.Page
    {
        Print_doc_service print_Doc_Service = new Print_doc_service();
        ReportFunction ReportFunction = new ReportFunction();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Page.IsPostBack))
            {
                lblDate.Text = Session["DATE"].ToString();
               
                lblTYPE_BB.Text = Session["Type_BB"].ToString();
                lblSoBB.Text = Session["So_BB"].ToString();
                lblReason.Text = Session["Reason"].ToString();
                lblNote.Text = Session["Note"].ToString();

                lblID_dlv.Text = Session["ID_dlv"].ToString();
                lblName_dlv.Text = Session["Name_dlv"].ToString();
                lblPhone_dlv.Text = Session["Phone_dlv"].ToString();
                lblMail_dlv.Text = Session["Mail_dlv"].ToString();
                lblDept_dlv.Text = Session["Dept"].ToString();

                lblID_Rcv.Text = Session["ID_rcv"].ToString();
                lblName_Rcv.Text = Session["Name_rcv"].ToString();
                lblPhone_Rcv.Text = Session["Phone_rcv"].ToString();
                lblMail_Rcv.Text = Session["Mail_rcv"].ToString();
                lblDept_Rcv.Text = Session["Dept_rcv"].ToString();

                dgvDevice.DataSource = (DataTable)Session["dtDevice"];
                dgvDevice.DataBind();

                dgvMaterial.DataSource = (DataTable)Session["dtMaterial"];
                dgvMaterial.DataBind();

            }
        }
    }
    
}