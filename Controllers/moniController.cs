using monifirstwebapi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace monifirstwebapi.Controllers
{
    public class moniController : ApiController

    {
        public List<code> Get()
        {
            SqlConnection con = new SqlConnection("data source =MKT-AJAYOLD\\ASLAM;database=test; user=sa;password=power@123");
            string query = "select *  from abctest";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            List<code> emplist = new List<code>();


            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                code emp = new code();

                emp.id = string.IsNullOrEmpty(dr["id"].ToString()) ? (int?)null : Convert.ToInt32(dr["iD"].ToString());
                emp.name = dr["name"].ToString();



                emplist.Add(emp);


            }
            dr.Close();

            con.Close();
            return emplist;

        }

        public List<code> Get(int value)
        {
            SqlConnection con = new SqlConnection("data source =MKT-AJAYOLD\\ASLAM;database=test; user=sa;password=power@123");
            //string query = "select *  from abctest";
            string qry = "Fetchabc";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = value;
            con.Open();

            List<code> emplist = new List<code>();


            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                code emp = new code();

                emp.id = string.IsNullOrEmpty(dr["id"].ToString()) ? (int?)null : Convert.ToInt32(dr["iD"].ToString());
                emp.name = dr["name"].ToString();



                emplist.Add(emp);


            }
            dr.Close();

            con.Close();
            return emplist;

        }

        //public List<code> POST(int value, string C)
        //{
        //    SqlConnection con = new SqlConnection("data source =MKT-AJAYOLD\\ASLAM;database=test; user=sa;password=power@123");
        //    //string query = "select *  from abctest";
        //    string qry = "NAME";
        //    SqlCommand cmd = new SqlCommand(qry, con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add("@id", SqlDbType.Int).Value = value;
        //    cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = value;
        //    con.Open();

        //    List<code> emplist = new List<code>();


        //    SqlDataReader dr = cmd.ExecuteReader();

        //    while (dr.Read())
        //    {
        //        code emp = new code();

        //        emp.id = string.IsNullOrEmpty(dr["id"].ToString()) ? (int?)null : Convert.ToInt32(dr["iD"].ToString());
        //        emp.name = dr["name"].ToString();



        //        emplist.Add(emp);


        //    }
        //    dr.Close();

        //    con.Close();
        //    return emplist;

        //}

        //public code Get(int id)
        //{

        //    SqlConnection con = new SqlConnection("data source =MKT-AJAYOLD\\ASLAM;database=test; user=sa;password=power@123");
        //    string query = "select *  from abctest where id ='" + id + "'";
        //    SqlCommand cmd = new SqlCommand(query, con);
        //    con.Open();


        //    code emp = new code();
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        emp.id = string.IsNullOrEmpty(dr["id"].ToString()) ? (int?)null : Convert.ToInt32(dr["iD"].ToString());
        //        emp.name = dr["name"].ToString();

        //    }
        //    dr.Close();


        //    con.Close();
        //    return emp;
        }
    }

