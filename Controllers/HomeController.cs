using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;


namespace WebApplication2
{

    public class HomeController : Controller
    {

        public async Task<ActionResult> Index()
        {
            List<DVD> list = new List<DVD>();
            List<string> titles = new List<string>();
            using (MySqlConnection con = new MySqlConnection("server=dvdkiosk.mysql.database.azure.com;UserID=odhran;Database=kiosk;Password=azureDatabase!!"))
            {
                con.Open();
                await callAzureFunction();
                MySqlCommand cmd = new MySqlCommand("SELECT title FROM dvd", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DVD dvd = new DVD();
                    dvd.Title = reader["title"].ToString();
                    titles.Add(dvd.Title);
                    //System.Diagnostics.Trace.WriteLine(dvd.Title);
                }
                reader.Close();
            }

            string json = JsonConvert.SerializeObject(titles.ToArray());

            //write string to file
            //System.IO.File.WriteAllText(@"..\Resources\path.txt", json);
            System.IO.File.WriteAllText(Server.MapPath("~") + @"\Resources\path.txt", json);
            return View();
        }

        public ActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

        public static async Task callAzureFunction()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://connecttodatabasesearch.azurewebsites.net/api/HttpTrigger2?code=reYzp8T02VdlOrpisOn9Mq4YaIXHg5lnOxLJ/bd2or4RLSDCOQ4Omg==");
            string responseString = await response.Content.ReadAsStringAsync();
            System.Diagnostics.Trace.WriteLine(responseString);
        }




    }
}