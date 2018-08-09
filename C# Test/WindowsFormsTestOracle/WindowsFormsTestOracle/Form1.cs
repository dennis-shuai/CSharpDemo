using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBHelper;
using System.Configuration;


namespace WindowsFormsTestOracle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select emp_Name,emp_no,update_time from sajet.sys_emp where emp_no =:empno ";
            string connstring = ConfigurationManager.AppSettings["OraConnString"];
            DBHelper.DbUtility db = new DBHelper.DbUtility(connstring, DBHelper.DbProviderType.Oracle);
  
            DbParameter emp_param = db.CreateDbParameter("empno", txtEmpNo.Text);
            IList<DbParameter> lst_pram = new List<DbParameter>();
            lst_pram.Add(emp_param);

            DataTable dt = new DataTable();
            dt = db.ExecuteDataTable(sql, lst_pram);
     
            dataGridView1.DataSource = dt; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //
            string connstring = ConfigurationManager.AppSettings["OraConnString"];
            DBHelper.DbUtility db = new DBHelper.DbUtility(connstring, DBHelper.DbProviderType.Oracle);
            string sTerminalId = "10013948";
            string sSN = "28210092T13";
            DbParameter TerminalId = db.CreateDbParameter("TERMINALID", sTerminalId);
            DbParameter SN = db.CreateDbParameter("TSN", sSN);
            //StringBuilder  tresValue = new StringBuilder();
            DbParameter TRes = db.CreateDbParameter("TRES", ParameterDirection.Output, null);
            IList<DbParameter> lst_pram = new List<DbParameter>();
            lst_pram.Add(TerminalId);
            lst_pram.Add(SN);
            lst_pram.Add(TRes);
            int result = db.ExecuteNonQuery( txtProcudure.Text, lst_pram, CommandType.StoredProcedure);
            txtMsg.Text = TRes.Value.ToString() +"/" + Convert.ToString(result) + " count";

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
               txtMsg.Text ="";
               txtProcudure.Text = "sajet.sj_ckrt_route";
        }
    }
}
