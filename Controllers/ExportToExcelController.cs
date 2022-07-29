//using Microsoft.AspNetCore.Mvc;
//using TravelProject.app.db;

//namespace TravelProject.Controllers
//{
//    public class ExportToExcelController : Controller
//    {
//        Public ActionResult Index()
//        {
//            String constring = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
//            SqlConnection con = newSqlConnection(constring);
//            string query = "select * From Parks";
//            DataTabledt = newDataTable();
//            con.Open();
//            SqlDataAdapter da = newSqlDataAdapter(query, con);
//            da.Fill(dt);
//            Con.Close();
//            IList<ExportToExcelModel> model = newList<ExportToExcelModel>();
//            for (int i = 0; i < dt.Rows.Count; i++)
//            {
//                model.Add(newExportToExcelModel()
//                {
//                    Id = Convert.ToInt32(dt.Rows[i]["Id"]),    
//             Parkname = dt.Rows[i]["Parkname"].ToString(),    
//             Fee = dt.Rows[i]["Fee"].ToString(),    
//             City = dt.Rows[i]["City"].ToString(),    
//        });
//        }    
//    return View(model);
//    }
//}
//}
