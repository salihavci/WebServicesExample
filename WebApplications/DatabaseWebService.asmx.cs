using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebApplications.Models;

namespace WebApplications
{
    /// <summary>
    /// DatabaseWebService için özet açıklama
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Bu Web Hizmeti'nin, ASP.NET AJAX kullanılarak komut dosyasından çağrılmasına, aşağıdaki satırı açıklamadan kaldırmasına olanak vermek için.
    [System.Web.Script.Services.ScriptService]
    public class DatabaseWebService : System.Web.Services.WebService
    {


        [WebMethod]
        public Students GetStudentById(int id)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("upGetStudentsByID", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parameter = new SqlParameter("@ID", id);
                cmd.Parameters.Add(parameter);
                Students students = new Students();
                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    students.ID = Convert.ToInt32(dr["ID"]);
                    students.TotalMarks = Convert.ToInt32(dr["TotalMarks"]);
                    students.Name = dr["Name"].ToString();
                    students.Gender = dr["Gender"].ToString();
                }
                con.Close();

                return students;
            }
        }
    }
}
