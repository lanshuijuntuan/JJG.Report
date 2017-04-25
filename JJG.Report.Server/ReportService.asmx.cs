using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace JJG.Report.Server
{
    /// <summary>
    /// ReportService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class ReportService : System.Web.Services.WebService
    {
        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="filebytes">上传的文件流</param>
        /// <param name="filename">上传的文件名称</param>
        /// <returns>是否上传成功</returns>
        [WebMethod]
        public bool Upload(byte[] filebytes, string filename)
        {
            bool reuslt = false;
            string reportfile = Server.MapPath(string.Format(@"~/ReportRDL/{0}", filename));
            string tmpreportFile = reportfile + ".tmp";
            try
            {
                if (File.Exists(tmpreportFile))
                {
                    File.Delete(tmpreportFile);
                }
                using (FileStream fs = File.Create(tmpreportFile))
                {

                    fs.Write(filebytes, 0, filebytes.Length);
                    fs.Close();
                }
                File.Copy(tmpreportFile, reportfile, true);
                reuslt= true;
            }
            catch(Exception ex)
            {
             
            }
            finally
            {
                if(File.Exists(tmpreportFile))
                {
                    File.Delete(tmpreportFile);
                }
            }
            return reuslt;

        }
        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="filename">文件的名称</param>
        /// <returns>文件的流</returns>
        [WebMethod]
        public byte[] DownLoad(string filename)
        {
            byte[] filebytes=null;
            string reportfile = Server.MapPath(string.Format(@"~/ReportRDL/{0}", filename));
            if(File.Exists(reportfile))
            {
                using(FileStream fs=File.OpenRead(reportfile))
                {
                    filebytes=new byte[fs.Length];
                    fs.Read(filebytes, 0, filebytes.Length);
                }
                if(filebytes==null)
                {
                    filebytes= new byte[0];
                }
            }
            else
            {
                filebytes = new byte[0]; 
            }
            return filebytes;
        }

        /// <summary>
        /// 获取服务器的文件列表
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public List<string> GetTemplateList()
        {
            List<string> filelst = new List<string>();
            string dirpath=Server.MapPath(@"~/ReportRDL/");
            if(Directory.Exists(dirpath))
            {
                DirectoryInfo mDirectoryInfo = new DirectoryInfo(dirpath);
                mDirectoryInfo.GetFiles();

                foreach(var item in mDirectoryInfo.GetFiles())
                {
                    filelst.Add(item.Name);
                }
            }
            else
            {
                Directory.CreateDirectory(dirpath);
               
            }
            return filelst;
            
        }

    }
}
