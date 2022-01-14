using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace finalProject_1913864
{
    public partial class LogIn : System.Web.UI.Page
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
            }
        }

        protected void btnLogin_Click(object sender,EventArgs e)
        {
            myCmd = new OleDbCommand("SELECT [Username], Password from Users WHERE Username=@user AND Password=@pas", myCon);
            myCmd.Parameters.AddWithValue("user", txtUsername.Text);
            myCmd.Parameters.AddWithValue("pas", txtPassword.Text);

            readEmployees = myCmd.ExecuteReader();

            if(readEmployees.HasRows)
            {
                readEmployees.Close();

                myCmd = new OleDbCommand("SELECT * FROM Employees WHERE EmployeeId=@user AND JobTitle=@jobtitle", myCon);
                myCmd.Parameters.AddWithValue("user", txtUsername.Text);
                myCmd.Parameters.AddWithValue("jobtitle", "Coordinator");

                readEmployees = myCmd.ExecuteReader();
                if (readEmployees.HasRows)
                {
                    Response.Redirect("index.aspx");
                    readEmployees.Close();
                }
                else
                {
                    Response.Write("<script>alert(\"Incorrect Username or Password\");</script>");
                    readEmployees.Close();
                }

            }
            else
            {
                Response.Write("<script>alert(\"Incorrect Username or Password\");</script>");
                readEmployees.Close();
            }
            
        }
    }
}