using SoapVideoApi.DAO;
using SoapVideoApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SoapVideoApi
{
    /// <summary>
    /// Summary description for SoapVideo
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SoapVideo : System.Web.Services.WebService
    {

        [WebMethod]
        public CatalogVideo GetAll()
        {
            return VideoDao.GetAll();
        }

        [WebMethod]
        public Video GetById(string id)
        {
            return VideoDao.GetById(id);
        }
    }
}
