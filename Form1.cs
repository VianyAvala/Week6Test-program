using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace Week6Test_program
{
    public partial class Form1 : Form
    { private SqlConnection conObj = null;
        private SqlCommand cmdObj = null;
        string EmployeeTpye = "";


       

        public Form1()
        {
            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["vinayAcon"].ConnectionString))
            {
                using (cmdObj = new SqlCommand("usp_InsertEmployees", conObj))
                {
                    cmdObj.CommandType = CommandType.StoredProcedure;
                    cmdObj.Parameters.AddWithValue("@EmployeeId", TxtEmployeeId.Text);
                    cmdObj.Parameters.AddWithValue("@EmployeeName", TxtEmployeeName.Text);
                    cmdObj.Parameters.AddWithValue("@EmployeeSalary", TxtEmployeeSalary.Text);
                    cmdObj.Parameters.AddWithValue("@EmployeeType", TxtEmployeeType);



              


                    if (conObj.State == ConnectionState.Closed)
                    {
                        conObj.Open();
                    }

                    int res = cmdObj.ExecuteNonQuery();
                    if (res > 0)
                    {
                        LblMessage4.Text = "Employee created sucessfully";
                    }
                }
            }
            
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetControls();
        }


        public void ResetControls()
        {
            TxtEmployeeId.Text = "";
            TxtEmployeeName.Text = "";
            TxtEmployeeSalary.Text = "";
            TxtEmployeeType.Tag = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeTpye = "p";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeTpye = "c";
        }
    }
}
