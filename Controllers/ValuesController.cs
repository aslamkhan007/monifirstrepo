using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using monifirstwebapi.Models;

namespace monifirstwebapi.Controllers
{
    public class ValuesController : ApiController
    {
        //// GET api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}


        // GET api/values
        public List<employee> Get()
        {

            
                //List<Employee> lstemployee = new List<Employee>();

                //using (SqlConnection con = new SqlConnection(connectionString))
                //{
                //    SqlCommand cmd = new SqlCommand("spGetAllEmployees", con);
                //    cmd.CommandType = CommandType.StoredProcedure;

                //    con.Open();
                //    SqlDataReader rdr = cmd.ExecuteReader();

                //    while (rdr.Read())
                //    {
                //        Employee employee = new Employee();

                //        employee.ID = Convert.ToInt32(rdr["EmployeeID"]);
                //        employee.Name = rdr["Name"].ToString();
                //        employee.Gender = rdr["Gender"].ToString();
                //        employee.Department = rdr["Department"].ToString();
                //        employee.City = rdr["City"].ToString();

                //        lstemployee.Add(employee);
                //    }
                //    con.Close();
                //}
                //return lstemployee;
         

            SqlConnection con = new SqlConnection("data source =MKT-AJAYOLD\\ASLAM;database=salim; user=sa;password=power@123");
            string query = "select * from employee";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();


            List<employee> emplist = new List<employee>();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                employee emp = new employee();
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

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }



        // POST api/values
        //public void Post([FromBody]string value)
        //{
        //}



        public void Post([FromBody]employee value)
        {

            SqlConnection con = new SqlConnection("data source = MKT-AJAYOLD\\ASLAM; database=salim; user=sa;password=power@123");
            string query = "insert into employee(empid,empname,empsallery) values('" + value.empid + "','" + value.empname + "','" + value.salary + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            //SqlConnection con = new SqlConnection("data source =MKT-AJAYOLD\\ASLAM;database=salim; user=sa;password=power@123");
            //string query = "byy";
            //SqlCommand cmd = new SqlCommand(query, con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@id", SqlDbType.Int).Value = TextBox2.Text;
            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();
        }

        //public void Post([FromBody]int value)
        //{

        //    SqlConnection con = new SqlConnection("data source = MKT-AJAYOLD\\ASLAM; database=salim; user=sa;password=power@123");
        //    string query = "insert into employee(empid) values('" + value + "')";
        //    SqlCommand cmd = new SqlCommand(query, con);
        //    con.Open();
        //    cmd.ExecuteNonQuery();
        //    con.Close();

        //    //SqlConnection con = new SqlConnection("data source =MKT-AJAYOLD\\ASLAM;database=salim; user=sa;password=power@123");
        //    //string query = "byy";
        //    //SqlCommand cmd = new SqlCommand(query, con);
        //    //cmd.CommandType = CommandType.StoredProcedure;
        //    //cmd.Parameters.Add("@id", SqlDbType.Int).Value = TextBox2.Text;
        //    //con.Open();
        //    //cmd.ExecuteNonQuery();
        //    //con.Close();
        //}


        // PUT api/values/5
        public void Put(int id, [FromBody]employee value)
        {

            //SqlConnection con = new SqlConnection("data source = MKT-AJAYOLD\\ASLAM; database=salim; user=sa;password=power@123");
            //string query = "update employee set empname = '" + value.empname + "',empsallery = '" + value.salary + "' where empid = '" + id+ "'";
            //SqlCommand cmd = new SqlCommand(query, con);
            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            SqlConnection con = new SqlConnection("data source = MKT-AJAYOLD\\ASLAM; database=salim; user=sa;password=power@123");
            string query = "delete from  employee where empid = '"+ id +"' ";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
