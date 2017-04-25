using JJG.Report.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace JJG.Report.Server
{
    /// <summary>
    /// ProductsService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class ProductsService : System.Web.Services.WebService
    {

        [WebMethod]
        public Products GetModel(int productId)
        {
            using (JJG.Report.Models.NorthwndDataContext mDataContext = new Models.NorthwndDataContext())
            {
                return mDataContext.Products.FirstOrDefault(p => p.ProductID == productId);
            }
        }
          [WebMethod]
        public void Insert(Products products)
        {
            
          
            using (JJG.Report.Models.NorthwndDataContext mDataContext = new Models.NorthwndDataContext())
            {
               mDataContext.Products.InsertOnSubmit(products);
            }
        }

          [WebMethod]
          public void Update(Products products)
          {

              using (JJG.Report.Models.NorthwndDataContext mDataContext = new Models.NorthwndDataContext())
              {
                  
              }
          }
    }
}
