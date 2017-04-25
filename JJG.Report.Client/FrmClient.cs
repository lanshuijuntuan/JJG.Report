using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrmClient
{
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
          
            using(ReportServiceReference.ReportServiceSoapClient client = new ReportServiceReference.ReportServiceSoapClient())
            {
                this.filelistview.Items.Clear();
                var filelst= client.GetTemplateList();
                foreach(var  item in filelst)
                {
                    this.filelistview.Items.Add(new ListViewItem(item));
                }
            }
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog mDialog = new OpenFileDialog();
            mDialog.Filter = "RDL报表文件(*.rdlx)|*.rdlx";
            if(mDialog.ShowDialog()==DialogResult.OK)
            {
                string filename = mDialog.FileName;
                using(FileStream fs=File.OpenRead(filename))
                {
                    byte[] filebyte =new byte[fs.Length];
                    fs.Read(filebyte, 0, filebyte.Length);
                    using(ReportServiceReference.ReportServiceSoapClient client=new ReportServiceReference.ReportServiceSoapClient())
                    {
                        if (client.Upload(filebyte, mDialog.SafeFileName))
                        {
                            MessageBox.Show(string.Format("上传文件{0}到服务器成功！", mDialog.SafeFileName), "提示");
                        }
                        else
                        {
                            MessageBox.Show(string.Format("上传文件{0}到服务器失败！", mDialog.SafeFileName), "提示");
                        }
                    }
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(this.filelistview.SelectedItems.Count==0)
            {
                MessageBox.Show("请选择下载文件！", "提示");
                return;
            }
            SaveFileDialog mDialog = new SaveFileDialog();
            mDialog.Filter = "RDL报表文件(*.rdlx)|*.rdlx";
             if (mDialog.ShowDialog() == DialogResult.OK)
             {
                 string filename = mDialog.FileName;
                 using(FileStream fs=File.Create(filename))
                 {
                     using(ReportServiceReference.ReportServiceSoapClient client=new ReportServiceReference.ReportServiceSoapClient())
                     {
                         string downloadfile = this.filelistview.SelectedItems[0].Text;
                         var filebytes=client.DownLoad(downloadfile);
                         fs.Write(filebytes, 0, filebytes.Length);
                     }
                 }
             }
        }

       
    }
}
