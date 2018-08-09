using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WCFServiceDemo;
using System.Data;
using System.Data.SqlClient;

namespace WinformHello
{
    public class HelloService:WCFServiceDemo.IHelloService   //alt+shift+f10 快速實現接口
    {

        public DateTime getSysdate()
        {
            return DateTime.Now;
        }

        public System.Data.DataTable GetUserInfo()
        {
            String connString = "Data Source=172.16.245.14;Initial Catalog=CCM;User ID=sa;Password=foxlinkccm";
            SqlConnection conn = new SqlConnection(connString);
            SqlDataAdapter sda = new SqlDataAdapter("select * from userInfo", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;

        }
    }
}
