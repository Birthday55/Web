using OptimizeDB1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OptimizeDB1.Controllers
{
    public class EmpController : ApiController
    {
        private SqlConnection _conn;
        private SqlDataAdapter adapter;

        int id1 = 34;
        // GET: api/Emp
        public IEnumerable<Emp> Get()
        {
            _conn = new SqlConnection("data source=DESKTOP-SG17T9T;Integrated Security=True;Initial catalog=DF1;");
            DataTable dt =new DataTable();
            string query =  "SELECT * FROM Employees where Id=" +id1;

            adapter = new SqlDataAdapter(query, _conn);
            adapter.Fill(dt);
            List<Emp> emp = new List<Models.Emp>(dt.Rows.Count);
            if(dt.Rows.Count>0)
            {
                foreach(DataRow er in dt.Rows)
                {
                    emp.Add(new ReadEmp(er));
                }
            }
            
            return emp;
            
        }

       
        // GET: api/Emp/5
       

        // POST: api/Emp
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Emp/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Emp/5
        public void Delete(int id)
        {
        }
    }
}
