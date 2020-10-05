using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using ICONEXT.Models;

namespace ICONEXT.Controllers
{
    public class Project_TaskController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Results"] = TablesColumnsDisplay();
            return View();
        }

        public static List<Project_Task> TablesColumnsDisplay()
        {
            List<Project_Task> PT = new List<Project_Task>();
            string connection = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=ICONEXTContext-1;Integrated Security=True";

            using(SqlConnection sqlconn = new SqlConnection(connection))
            {
                using(SqlCommand sqlcomm = new SqlCommand("select project.Name, TaskProject.Tasks from project full join TaskProject on project.ProjID=TaskProject.ProjID"))
                {
                    using(SqlDataAdapter SDA = new SqlDataAdapter())
                    {
                        sqlcomm.Connection = sqlconn;
                        sqlconn.Open();
                        SDA.SelectCommand = sqlcomm;

                        SqlDataReader SDR = sqlcomm.ExecuteReader();
                        while(SDR.Read())
                        {
                            Project_Task PTOBJ = new Project_Task();
                            PTOBJ.Name = SDR["Name"].ToString();
                            PTOBJ.Tasks = SDR["Tasks"].ToString();
                            PT.Add(PTOBJ);

                        }
                    }
                    return PT;
                }
            }
        }
    }
}
