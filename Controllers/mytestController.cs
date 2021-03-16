using monifirstwebapi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace monifirstwebapi.Controllers
{
    public class mytestController : ApiController
    {
        public List<test1> Get()
        {

            SqlConnection con = new SqlConnection("data source =MKT-AJAYOLD\\ASLAM;database=salim; user=sa;password=power@123");
            string query = "select * from employee";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();


            List<test1> emplist = new List<test1>();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                test1 emp = new test1();
                emp.empid = string.IsNullOrEmpty(dr["empid"].ToString()) ? (int?)null : Convert.ToInt32(dr["empiD"].ToString());

                emp.empname = dr["empname"].ToString();


                emp.salary = string.IsNullOrEmpty(dr["empsallery"].ToString()) ? (int?)null : Convert.ToInt32(dr["empsallery"].ToString());


                emplist.Add(emp);


            }
            dr.Close();

            con.Close();
            return emplist;


            //return new string[] { "value1", "value2" };
        }

        //public void post([FromBody]test1 value)
        //{
        //    SqlConnection con = new SqlConnection("data source = MKT-AJAYOLD\\ASLAM; database=salim; user=sa;password=power@123");
        //    string query = "insert into employee(empid,empname,empsallery) values('" + value.empid + "','" + value.empname + "','" + value.salary + "')";
        //    SqlCommand cmd = new SqlCommand(query, con);
        //    con.Open();
        //    cmd.ExecuteNonQuery();
        //    con.Close();

        //}


        public void post([FromBody]test1 value)
        {
            //SqlConnection con = new SqlConnection("data source = MKT-AJAYOLD\\ASLAM; database=salim; user=sa;password=power@123");
            //string query = "insert into employee(empid,empname,empsallery) values('" + empid + "','" + empname + "','" + salary + "')";
            //SqlCommand cmd = new SqlCommand(query, con);
            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();
            SqlConnection con = new SqlConnection("data source =MKT-AJAYOLD\\ASLAM;database=test; user=sa;password=power@123");
            //string query = "select *  from abctest";
            string qry = "NAME";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = value.empid;
            cmd.Parameters.Add("@name", SqlDbType.VarChar,50).Value = value.empname;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void put([FromBody]test1 value)
        {
            //SqlConnection con = new SqlConnection("data source = MKT-AJAYOLD\\ASLAM; database=salim; user=sa;password=power@123");
            //string query = "insert into employee(empid,empname,empsallery) values('" + empid + "','" + empname + "','" + salary + "')";
            //SqlCommand cmd = new SqlCommand(query, con);
            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();
            SqlConnection con = new SqlConnection("data source =MKT-AJAYOLD\\ASLAM;database=test; user=sa;password=power@123");
            //string query = "select *  from abctest";
            string qry = "NAMEupd";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = value.empid;
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = value.empname;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}
