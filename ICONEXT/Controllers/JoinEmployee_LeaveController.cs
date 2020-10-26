using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using ICONEXT.Models;

using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ICONEXT.Data;
using System.Collections;
using Microsoft.AspNetCore.Builder;


namespace ICONEXT.Controllers
{
    public class JoinEmployee_LeaveController : Controller
    {
        private readonly ICONEXTContext _context;

        public JoinEmployee_LeaveController(ICONEXTContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["Results"] = TablesColumnsDisplay();
            return View();
        }


        public IActionResult Details()
        {
            ViewData["Results"] = TablesColumnsDisplay();
            return View();
        }


        [HttpPost]

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details([Bind("StartDate,EndDate,note,Days")] JoinEmployee_Leave JoinEmployee_Leave)
        {
            if (ModelState.IsValid)
            {
                _context.Add(JoinEmployee_Leave);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(JoinEmployee_Leave);
        }




        public static List<JoinEmployee_Leave> TablesColumnsDisplay()
        {
            List<JoinEmployee_Leave> EL = new List<JoinEmployee_Leave>();
            string connection = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=ICONEXTContext-1;Integrated Security=True";

            using (SqlConnection sqlconn = new SqlConnection(connection))
            {
                using (SqlCommand sqlcomm = new SqlCommand("select employee.Title,employee.Name,employee.Surname,employee.Nickname,employee.Position,employee.Tel,employee.Email,employee.Active, Leave.StartDate,Leave.EndDate,Leave.note,Leave.Days from employee full join Leave on employee.ID=Leave.ID"))
                {
                    using (SqlDataAdapter SDA = new SqlDataAdapter())
                    {
                        sqlcomm.Connection = sqlconn;
                        sqlconn.Open();
                        SDA.SelectCommand = sqlcomm;

                        SqlDataReader SDR = sqlcomm.ExecuteReader();
                        while (SDR.Read())
                        {
                            JoinEmployee_Leave ELOBJ = new JoinEmployee_Leave();
                            ELOBJ.Title = SDR["Title"].ToString();
                            ELOBJ.Name = SDR["Name"].ToString();
                            ELOBJ.Surname = SDR["Surname"].ToString();
                            ELOBJ.Nickname = SDR["Nickname"].ToString();
                            ELOBJ.Position = SDR["Position"].ToString();
                            ELOBJ.Tel = SDR["Tel"].ToString();
                            ELOBJ.Email = SDR["Email"].ToString();
                            ELOBJ.Active = SDR["Active"].ToString();
                            ELOBJ.StartDate = SDR["StartDate"].ToString();
                            ELOBJ.EndDate = SDR["EndDate"].ToString();
                            ELOBJ.note = SDR["note"].ToString();
                            ELOBJ.Days = SDR["Days"].ToString();
                            EL.Add(ELOBJ);

                        }
                    }
                    return EL;
                }
            }
        }

    }
}
