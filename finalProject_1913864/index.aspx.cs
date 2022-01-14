using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace finalProject_1913864
{
    public partial class index : System.Web.UI.Page
    {
        static OleDbConnection myCon;
        OleDbCommand myCmd;
        OleDbDataReader readEmployees;


        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                
                myCon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source =" + Server.MapPath("~/App_Data/finalProjDB.mdb"));
                myCon.Open();
                myCmd = new OleDbCommand("SELECT [EmployeeId], FirstName, LastName, Email, JobTitle FROM Employees WHERE JobTitle='Teacher'",myCon);

                readEmployees = myCmd.ExecuteReader();
                lstTeacher.DataTextField = "FirstName";
                lstTeacher.DataValueField = "EmployeeId";
                lstTeacher.DataSource = readEmployees;
                lstTeacher.DataBind();

                btnSave.Enabled = false;
                btnCancel.Enabled = false;

            }

        }

        protected void lstTeacher_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            myCmd = new OleDbCommand("SELECT * FROM Employees where FirstName =@ref", myCon);
            myCmd.Parameters.AddWithValue("ref", lstTeacher.SelectedItem.Value);
            readEmployees = myCmd.ExecuteReader();
            readEmployees.Close();
            myCmd.CommandText = "SELECT CourseCode as [Course Code], GroupNumber as [Group Number], AssignedDate as [Assigned Date] from CourseAssignments where EmployeeId =@ref";
            readEmployees = myCmd.ExecuteReader();
            gridresults.DataSource = readEmployees;
            gridresults.DataBind();
            txtEmployeeId.Text = lstTeacher.SelectedItem.Value;
        }

        protected void btnAdd_Click(object sender,EventArgs e)
        {

            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnAdd.Enabled = false;

            txtCourseCode.ReadOnly = false;
            txtGroupNumber.ReadOnly = false;
            txtAssignedDate.ReadOnly = false;
      
        }

        protected void btnSave_Click(object sender,EventArgs e)
        {
            if (gridresults.Rows.Count >= 3)
            {

                txtEmployeeId.Text = "";
                txtGroupNumber.Text = "";
                txtCourseCode.Text = "";
                txtAssignedDate.Text = "";

                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                btnAdd.Enabled = true;

                //Error handle
                Response.Write("<script>alert(\"Please assign less than 3 courses\");</script>");
            }
            else
            {

                txtEmployeeId.Text = "";
                txtGroupNumber.Text = "";
                txtCourseCode.Text = "";
                txtAssignedDate.Text = "";

                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                btnAdd.Enabled = false;

                int EID = Convert.ToInt32(lstTeacher.SelectedItem.Value);
                txtCourseCode.ReadOnly = true;
                txtGroupNumber.ReadOnly = true;
                txtAssignedDate.ReadOnly = true;

                string sqlite = "INSERT INTO CourseAssignments VALUES(" + EID + ",@cCode,@gNum,@aDate)";
                OleDbCommand myCmd = new OleDbCommand(sqlite, myCon);
                myCmd.Parameters.AddWithValue("eCode", txtCourseCode.Text);
                myCmd.Parameters.AddWithValue("gNum", Convert.ToInt32(txtGroupNumber.Text.ToString()));
                myCmd.Parameters.AddWithValue("aDate", txtAssignedDate.Text);

                int ResultValue = myCmd.ExecuteNonQuery();

                //Message for adding
                Response.Write("<script>alert(\"Added!\");</script>");

            }
        }

        protected void btnCancel_Click(object sender,EventArgs e)
        {
            txtEmployeeId.Text = "";
            txtGroupNumber.Text = "";
            txtCourseCode.Text = "";
            txtAssignedDate.Text = "";

            btnSave.Enabled = true;
            btnCancel.Enabled = false;
            btnAdd.Enabled = false;

            txtCourseCode.ReadOnly = true;
            txtGroupNumber.ReadOnly = true;
            txtAssignedDate.ReadOnly = true;
        }
    }
}