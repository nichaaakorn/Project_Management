using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using ICONEXT.Models;

using System.Collections.Generic;
using System.Web;




namespace ICONEXT.Controllers
{
    public class Project_PhaseController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Results"] = TablesColumnsDisplay();
            return View();
        }


        // GET: /TreeGridKeyNavigation/

        public IActionResult Project_Phase()
        {
            var data = this.ViewData["Results"];
            ViewBag.datasource = data;
            return View();
        }

        public static List<Project_Phase> TablesColumnsDisplay()
        {
            List<Project_Phase> PP = new List<Project_Phase>();
            string connection = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=ICONEXTContext-1;Integrated Security=True";

            using (SqlConnection sqlconn = new SqlConnection(connection))
            {
                using (SqlCommand sqlcomm = new SqlCommand("select project.Name, TaskProject.Tasks, PhaseProject.Phase, PhaseProject.FromDate, PhaseProject.EndDate, PhaseProject.Usage from project full join TaskProject on project.ProjID=TaskProject.ProjID full join PhaseProject on TaskProject.TID=PhaseProject.TID "))
                {
                    using (SqlDataAdapter SDA = new SqlDataAdapter())
                    {
                        sqlcomm.Connection = sqlconn;
                        sqlconn.Open();
                        SDA.SelectCommand = sqlcomm;

                        SqlDataReader SDR = sqlcomm.ExecuteReader();
                        while (SDR.Read())
                        {
                            Project_Phase PPOBJ = new Project_Phase();
                            PPOBJ.Name = SDR["Name"].ToString();
                            PPOBJ.Tasks = SDR["Tasks"].ToString();
                            PPOBJ.Phase = SDR["Phase"].ToString();
                            PPOBJ.FromDate = SDR["FromDate"].ToString();
                            PPOBJ.EndDate = SDR["EndDate"].ToString();
                            PPOBJ.Usage = SDR["Usage"].ToString();

                            PP.Add(PPOBJ);

                        }
                    }
                    return PP;
                }
            }
        }
    }
}
