using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WebApplication.DbHelper;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {static long t22 = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //登陆
        public string Login(string name, string Password)
        {
            long t22 = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
            long t221 = (DateTime.Parse("2022 - 03 - 25 09:36:30").ToUniversalTime().Ticks - 621355968000000000) / 10000000;
            
            string queryStr = "select * from userInfo where userName='" + name + "' and password='" + Password + "'";
            //SQLHelper dbHelper = new SQLHelper();
            //获取数据
            //var dataQueryDataSet = dbHelper.Query(queryStr);
            DataTable dataQueryDataTable = SQLHelper.GetDataTable(queryStr);
             string dataQueryDataTableStr = DTtoJSON(dataQueryDataTable);
            System.Web.HttpContext.Current.Session["userName"] = name;
            return dataQueryDataTableStr;

        }
        /// <summary>
        /// 将table转换成json
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public string DTtoJSON(DataTable dt)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            ArrayList dic = new ArrayList();
            foreach (DataRow row in dt.Rows)
            {
                Dictionary<string, object> drow = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    drow.Add(col.Ordinal.ToString(), row[col.ColumnName]);
                }
                dic.Add(drow);
            }
            return jss.Serialize(dic);
        }
    }
}