namespace FrmClient
{
    partial class FrmClient
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_upload = new System.Windows.Forms.Button();
            this.filelistview = new System.Windows.Forms.ListView();
            this.col_filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(26, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "保存模板";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(107, 12);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(75, 23);
            this.btn_read.TabIndex = 1;
            this.btn_read.Text = "读取模板";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(188, 12);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(75, 23);
            this.btn_upload.TabIndex = 2;
            this.btn_upload.Text = "上传模板";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // filelistview
            // 
            this.filelistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_filename});
            this.filelistview.Location = new System.Drawing.Point(26, 55);
            this.filelistview.Name = "filelistview";
            this.filelistview.Size = new System.Drawing.Size(237, 97);
            this.filelistview.TabIndex = 3;
            this.filelistview.UseCompatibleStateImageBehavior = false;
            this.filelistview.View = System.Windows.Forms.View.Details;
            // 
            // col_filename
            // 
            this.col_filename.Text = "文件名称";
            // 
            // FrmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 208);
            this.Controls.Add(this.filelistview);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.btn_save);
            this.Name = "FrmClient";
            this.Text = "测试打印模板";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.ListView filelistview;
        private System.Windows.Forms.ColumnHeader col_filename;
    }
}

