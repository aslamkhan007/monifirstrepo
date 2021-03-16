using monifirstwebapi.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace monifirstwebapi.Controllers
{
    public class MyController : ApiController
    {
        public List<Myclass> Get()
        {
             
            SqlConnection con = new SqlConnection("data source =MKT-AJAYOLD\\ASLAM;database=salim; user=sa;password=power@123");
            string query = "select * from employee";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            List<Myclass> emplist = new List<Myclass>();


            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                Myclass emp = new Myclass();
                emp.empid = string.IsNullOrEmpty(dr["empid"].ToString()) ? (int?)null : Convert.ToInt32(dr["empiD"].ToString());

                emp.empname = dr["empname"].ToString();


                emp.salary = string.IsNullOrEmpty(dr["empsallery"].ToString()) ? (int?)null : Convert.ToInt32(dr["empsallery"].ToString());


                emplist.Add(emp);

                 
            }
            dr.Close();

            con.Close();
            return emplist;


        }
        //public void Post([FromBody]Myclass value)
        public void Post([FromBody]string value)
        {

            //SqlConnection con = new SqlConnection("data source = MKT-AJAYOLD\\ASLAM; database=salim; user=sa;password=power@123");
            //string query = "insert into employee(empid,empname,empsallery) values('" + value.empid + "','" + value.empname + "','" + value.salary + "')";
            //SqlCommand cmd = new SqlCommand(query, con);
            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();

            SqlConnection con = new SqlConnection("data source = MKT-AJAYOLD\\ASLAM; database=salim; user=sa;password=power@123");
            string query = "insert into employee(empname) values('" + value + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public Myclass Get(int id )
         {

            SqlConnection con = new SqlConnection("data source =MKT-AJAYOLD\\ASLAM;database=salim; user=sa;password=power@123");
            string query = "select * from employee where empid = '"+ id +"'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

             

            Myclass emp = new Myclass();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

               
                emp.empid = string.IsNullOrEmpty(dr["empid"].ToString()) ? (int?)null : Convert.ToInt32(dr["empiD"].ToString());

                emp.empname = dr["empname"].ToString();


                emp.salary = string.IsNullOrEmpty(dr["empsallery"].ToString()) ? (int?)null : Convert.ToInt32(dr["empsallery"].ToString());


            


            }
            dr.Close();


            con.Close();
            return emp;


        }
    }
}



