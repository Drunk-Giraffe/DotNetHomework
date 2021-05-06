
namespace _9
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AbsoluteUri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.downloadedPagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostFilterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileFilterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.htmlEncodingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 364);
            this.panel1.TabIndex = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(_9.Crawler);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AbsoluteUri,
            this.downloadedPagesDataGridViewTextBoxColumn,
            this.hostFilterDataGridViewTextBoxColumn,
            this.fileFilterDataGridViewTextBoxColumn,
            this.htmlEncodingDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(383, 358);
            this.dataGridView1.TabIndex = 0;
            // 
            // AbsoluteUri
            // 
            this.AbsoluteUri.DataPropertyName = "AbsoluteUri";
            this.AbsoluteUri.HeaderText = "AbsoluteUri";
            this.AbsoluteUri.Name = "AbsoluteUri";
            this.AbsoluteUri.ReadOnly = true;
            this.AbsoluteUri.Width = 380;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(425, 21);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "爬取";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "网站地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "正确结果";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "错误结果";
            // 
            // downloadedPagesDataGridViewTextBoxColumn
            // 
            this.downloadedPagesDataGridViewTextBoxColumn.DataPropertyName = "DownloadedPages";
            this.downloadedPagesDataGridViewTextBoxColumn.HeaderText = "DownloadedPages";
            this.downloadedPagesDataGridViewTextBoxColumn.Name = "downloadedPagesDataGridViewTextBoxColumn";
            this.downloadedPagesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hostFilterDataGridViewTextBoxColumn
            // 
            this.hostFilterDataGridViewTextBoxColumn.DataPropertyName = "HostFilter";
            this.hostFilterDataGridViewTextBoxColumn.HeaderText = "HostFilter";
            this.hostFilterDataGridViewTextBoxColumn.Name = "hostFilterDataGridViewTextBoxColumn";
            // 
            // fileFilterDataGridViewTextBoxColumn
            // 
            this.fileFilterDataGridViewTextBoxColumn.DataPropertyName = "FileFilter";
            this.fileFilterDataGridViewTextBoxColumn.HeaderText = "FileFilter";
            this.fileFilterDataGridViewTextBoxColumn.Name = "fileFilterDataGridViewTextBoxColumn";
            // 
            // htmlEncodingDataGridViewTextBoxColumn
            // 
            this.htmlEncodingDataGridViewTextBoxColumn.DataPropertyName = "HtmlEncoding";
            this.htmlEncodingDataGridViewTextBoxColumn.HeaderText = "HtmlEncoding";
            this.htmlEncodingDataGridViewTextBoxColumn.Name = "htmlEncodingDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbsoluteUri;
        private System.Windows.Forms.DataGridViewTextBoxColumn downloadedPagesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostFilterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileFilterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn htmlEncodingDataGridViewTextBoxColumn;
    }
}

