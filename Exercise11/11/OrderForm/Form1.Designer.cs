
namespace OrderForm
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
            this.QueryWay = new System.Windows.Forms.ComboBox();
            this.QueryKey = new System.Windows.Forms.TextBox();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddOrder = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddOrderDetails = new System.Windows.Forms.Button();
            this.AddCargoAmount = new System.Windows.Forms.TextBox();
            this.AddCargoName = new System.Windows.Forms.ComboBox();
            this.AddCustomerName = new System.Windows.Forms.TextBox();
            this.AddCustomerID = new System.Windows.Forms.TextBox();
            this.AddOrderID = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.ModifyOrderID = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.NewOrderID = new System.Windows.Forms.TextBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.ModifyCustomerID = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.NewCustomerID = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.NewCustomerName = new System.Windows.Forms.TextBox();
            this.ModifyCustomerName = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.NewCargo = new System.Windows.Forms.ComboBox();
            this.ModifiedCargo = new System.Windows.Forms.ComboBox();
            this.ModifyCargoAmount = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.NewCargoAmount = new System.Windows.Forms.TextBox();
            this.ModifyCargo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.AddNewOrderDetails = new System.Windows.Forms.Button();
            this.AddNewCargoAmount = new System.Windows.Forms.TextBox();
            this.AddNewCargoName = new System.Windows.Forms.ComboBox();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.DeleteOrderDetails = new System.Windows.Forms.Button();
            this.DeleteCargoName = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ModifiedOrderID = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.DeleteOrder = new System.Windows.Forms.Button();
            this.DeleteOrderID = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ExportOrder = new System.Windows.Forms.Button();
            this.ImportOrder = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // QueryWay
            // 
            this.QueryWay.FormattingEnabled = true;
            this.QueryWay.Items.AddRange(new object[] {
            "订单编号",
            "商品名称",
            "客户姓名",
            "订单金额"});
            this.QueryWay.Location = new System.Drawing.Point(12, 12);
            this.QueryWay.Name = "QueryWay";
            this.QueryWay.Size = new System.Drawing.Size(121, 20);
            this.QueryWay.TabIndex = 0;
            // 
            // QueryKey
            // 
            this.QueryKey.Location = new System.Drawing.Point(166, 12);
            this.QueryKey.Name = "QueryKey";
            this.QueryKey.Size = new System.Drawing.Size(214, 21);
            this.QueryKey.TabIndex = 1;
            // 
            // buttonQuery
            // 
            this.buttonQuery.BackColor = System.Drawing.SystemColors.Control;
            this.buttonQuery.Location = new System.Drawing.Point(419, 9);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonQuery.TabIndex = 2;
            this.buttonQuery.Text = "查找";
            this.buttonQuery.UseVisualStyleBackColor = false;
            this.buttonQuery.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 367);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.customerDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(295, 370);
            this.dataGridView1.TabIndex = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(_11.Order);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(319, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 367);
            this.panel2.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.DataMember = "orderDetails";
            this.dataGridView2.DataSource = this.bindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(246, 367);
            this.dataGridView2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Location = new System.Drawing.Point(582, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 366);
            this.panel3.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(5, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(198, 362);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.CausesValidation = false;
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.AddOrder);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.AddCustomerName);
            this.tabPage1.Controls.Add(this.AddCustomerID);
            this.tabPage1.Controls.Add(this.AddOrderID);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(190, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "添加订单";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "客户姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "客户编号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "订单号";
            // 
            // AddOrder
            // 
            this.AddOrder.Location = new System.Drawing.Point(85, 307);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(75, 23);
            this.AddOrder.TabIndex = 5;
            this.AddOrder.Text = "保存订单";
            this.AddOrder.UseVisualStyleBackColor = true;
            this.AddOrder.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.AddOrderDetails);
            this.panel4.Controls.Add(this.AddCargoAmount);
            this.panel4.Controls.Add(this.AddCargoName);
            this.panel4.Location = new System.Drawing.Point(6, 147);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(178, 144);
            this.panel4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "货物数量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "货物名称";
            // 
            // AddOrderDetails
            // 
            this.AddOrderDetails.Location = new System.Drawing.Point(76, 108);
            this.AddOrderDetails.Name = "AddOrderDetails";
            this.AddOrderDetails.Size = new System.Drawing.Size(75, 23);
            this.AddOrderDetails.TabIndex = 5;
            this.AddOrderDetails.Text = "添加明细";
            this.AddOrderDetails.UseVisualStyleBackColor = true;
            this.AddOrderDetails.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddCargoAmount
            // 
            this.AddCargoAmount.Location = new System.Drawing.Point(51, 68);
            this.AddCargoAmount.Name = "AddCargoAmount";
            this.AddCargoAmount.Size = new System.Drawing.Size(100, 21);
            this.AddCargoAmount.TabIndex = 4;
            // 
            // AddCargoName
            // 
            this.AddCargoName.FormattingEnabled = true;
            this.AddCargoName.Items.AddRange(new object[] {
            "苹果",
            "大米",
            "铁矿石"});
            this.AddCargoName.Location = new System.Drawing.Point(51, 17);
            this.AddCargoName.Name = "AddCargoName";
            this.AddCargoName.Size = new System.Drawing.Size(121, 20);
            this.AddCargoName.TabIndex = 3;
            // 
            // AddCustomerName
            // 
            this.AddCustomerName.Location = new System.Drawing.Point(60, 111);
            this.AddCustomerName.Name = "AddCustomerName";
            this.AddCustomerName.Size = new System.Drawing.Size(100, 21);
            this.AddCustomerName.TabIndex = 2;
            // 
            // AddCustomerID
            // 
            this.AddCustomerID.Location = new System.Drawing.Point(60, 63);
            this.AddCustomerID.Name = "AddCustomerID";
            this.AddCustomerID.Size = new System.Drawing.Size(100, 21);
            this.AddCustomerID.TabIndex = 1;
            // 
            // AddOrderID
            // 
            this.AddOrderID.Location = new System.Drawing.Point(60, 20);
            this.AddOrderID.Name = "AddOrderID";
            this.AddOrderID.Size = new System.Drawing.Size(100, 21);
            this.AddOrderID.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Controls.Add(this.ModifiedOrderID);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(190, 336);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "修改订单";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "订单号：";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage9);
            this.tabControl2.Controls.Add(this.tabPage10);
            this.tabControl2.Location = new System.Drawing.Point(7, 65);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(177, 268);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.ModifyOrderID);
            this.tabPage7.Controls.Add(this.label7);
            this.tabPage7.Controls.Add(this.NewOrderID);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(169, 242);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "订单号";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // ModifyOrderID
            // 
            this.ModifyOrderID.Location = new System.Drawing.Point(59, 80);
            this.ModifyOrderID.Name = "ModifyOrderID";
            this.ModifyOrderID.Size = new System.Drawing.Size(75, 23);
            this.ModifyOrderID.TabIndex = 2;
            this.ModifyOrderID.Text = "修改";
            this.ModifyOrderID.UseVisualStyleBackColor = true;
            this.ModifyOrderID.Click += new System.EventHandler(this.button7_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "新订单号：";
            // 
            // NewOrderID
            // 
            this.NewOrderID.Location = new System.Drawing.Point(59, 25);
            this.NewOrderID.Name = "NewOrderID";
            this.NewOrderID.Size = new System.Drawing.Size(100, 21);
            this.NewOrderID.TabIndex = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.ModifyCustomerID);
            this.tabPage8.Controls.Add(this.label8);
            this.tabPage8.Controls.Add(this.NewCustomerID);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(169, 242);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "顾客编号";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // ModifyCustomerID
            // 
            this.ModifyCustomerID.Location = new System.Drawing.Point(59, 95);
            this.ModifyCustomerID.Name = "ModifyCustomerID";
            this.ModifyCustomerID.Size = new System.Drawing.Size(75, 23);
            this.ModifyCustomerID.TabIndex = 2;
            this.ModifyCustomerID.Text = "修改";
            this.ModifyCustomerID.UseVisualStyleBackColor = true;
            this.ModifyCustomerID.Click += new System.EventHandler(this.button8_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "新顾客编号";
            // 
            // NewCustomerID
            // 
            this.NewCustomerID.Location = new System.Drawing.Point(59, 34);
            this.NewCustomerID.Name = "NewCustomerID";
            this.NewCustomerID.Size = new System.Drawing.Size(100, 21);
            this.NewCustomerID.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.NewCustomerName);
            this.tabPage5.Controls.Add(this.ModifyCustomerName);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(169, 242);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "顾客姓名";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "新顾客姓名";
            // 
            // NewCustomerName
            // 
            this.NewCustomerName.Location = new System.Drawing.Point(59, 28);
            this.NewCustomerName.Name = "NewCustomerName";
            this.NewCustomerName.Size = new System.Drawing.Size(100, 21);
            this.NewCustomerName.TabIndex = 1;
            // 
            // ModifyCustomerName
            // 
            this.ModifyCustomerName.Location = new System.Drawing.Point(59, 87);
            this.ModifyCustomerName.Name = "ModifyCustomerName";
            this.ModifyCustomerName.Size = new System.Drawing.Size(75, 23);
            this.ModifyCustomerName.TabIndex = 0;
            this.ModifyCustomerName.Text = "修改";
            this.ModifyCustomerName.UseVisualStyleBackColor = true;
            this.ModifyCustomerName.Click += new System.EventHandler(this.button9_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.NewCargo);
            this.tabPage6.Controls.Add(this.ModifiedCargo);
            this.tabPage6.Controls.Add(this.ModifyCargoAmount);
            this.tabPage6.Controls.Add(this.label13);
            this.tabPage6.Controls.Add(this.NewCargoAmount);
            this.tabPage6.Controls.Add(this.ModifyCargo);
            this.tabPage6.Controls.Add(this.label12);
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(169, 242);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "修改明细";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // NewCargo
            // 
            this.NewCargo.FormattingEnabled = true;
            this.NewCargo.Items.AddRange(new object[] {
            "苹果",
            "大米",
            "铁矿石"});
            this.NewCargo.Location = new System.Drawing.Point(59, 92);
            this.NewCargo.Name = "NewCargo";
            this.NewCargo.Size = new System.Drawing.Size(100, 20);
            this.NewCargo.TabIndex = 9;
            // 
            // ModifiedCargo
            // 
            this.ModifiedCargo.FormattingEnabled = true;
            this.ModifiedCargo.Items.AddRange(new object[] {
            "苹果",
            "大米",
            "铁矿石"});
            this.ModifiedCargo.Location = new System.Drawing.Point(59, 41);
            this.ModifiedCargo.Name = "ModifiedCargo";
            this.ModifiedCargo.Size = new System.Drawing.Size(100, 20);
            this.ModifiedCargo.TabIndex = 8;
            // 
            // ModifyCargoAmount
            // 
            this.ModifyCargoAmount.Location = new System.Drawing.Point(77, 211);
            this.ModifyCargoAmount.Name = "ModifyCargoAmount";
            this.ModifyCargoAmount.Size = new System.Drawing.Size(75, 23);
            this.ModifyCargoAmount.TabIndex = 7;
            this.ModifyCargoAmount.Text = "修改";
            this.ModifyCargoAmount.UseVisualStyleBackColor = true;
            this.ModifyCargoAmount.Click += new System.EventHandler(this.button11_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 6;
            this.label13.Text = "新货物数量";
            // 
            // NewCargoAmount
            // 
            this.NewCargoAmount.Location = new System.Drawing.Point(59, 172);
            this.NewCargoAmount.Name = "NewCargoAmount";
            this.NewCargoAmount.Size = new System.Drawing.Size(100, 21);
            this.NewCargoAmount.TabIndex = 5;
            // 
            // ModifyCargo
            // 
            this.ModifyCargo.Location = new System.Drawing.Point(77, 131);
            this.ModifyCargo.Name = "ModifyCargo";
            this.ModifyCargo.Size = new System.Drawing.Size(75, 23);
            this.ModifyCargo.TabIndex = 4;
            this.ModifyCargo.Text = "修改";
            this.ModifyCargo.UseVisualStyleBackColor = true;
            this.ModifyCargo.Click += new System.EventHandler(this.button10_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 3;
            this.label12.Text = "新货物名称";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "货物名称";
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.panel5);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(169, 242);
            this.tabPage9.TabIndex = 4;
            this.tabPage9.Text = "添加明细";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.AddNewOrderDetails);
            this.panel5.Controls.Add(this.AddNewCargoAmount);
            this.panel5.Controls.Add(this.AddNewCargoName);
            this.panel5.Location = new System.Drawing.Point(3, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(178, 144);
            this.panel5.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 7;
            this.label14.Text = "货物数量";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 6;
            this.label15.Text = "货物名称";
            // 
            // AddNewOrderDetails
            // 
            this.AddNewOrderDetails.Location = new System.Drawing.Point(76, 108);
            this.AddNewOrderDetails.Name = "AddNewOrderDetails";
            this.AddNewOrderDetails.Size = new System.Drawing.Size(75, 23);
            this.AddNewOrderDetails.TabIndex = 5;
            this.AddNewOrderDetails.Text = "添加明细";
            this.AddNewOrderDetails.UseVisualStyleBackColor = true;
            this.AddNewOrderDetails.Click += new System.EventHandler(this.button12_Click);
            // 
            // AddNewCargoAmount
            // 
            this.AddNewCargoAmount.Location = new System.Drawing.Point(64, 73);
            this.AddNewCargoAmount.Name = "AddNewCargoAmount";
            this.AddNewCargoAmount.Size = new System.Drawing.Size(100, 21);
            this.AddNewCargoAmount.TabIndex = 4;
            // 
            // AddNewCargoName
            // 
            this.AddNewCargoName.FormattingEnabled = true;
            this.AddNewCargoName.Location = new System.Drawing.Point(64, 21);
            this.AddNewCargoName.Name = "AddNewCargoName";
            this.AddNewCargoName.Size = new System.Drawing.Size(100, 20);
            this.AddNewCargoName.TabIndex = 3;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.DeleteOrderDetails);
            this.tabPage10.Controls.Add(this.DeleteCargoName);
            this.tabPage10.Controls.Add(this.label16);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(169, 242);
            this.tabPage10.TabIndex = 5;
            this.tabPage10.Text = "删除明细";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // DeleteOrderDetails
            // 
            this.DeleteOrderDetails.Location = new System.Drawing.Point(59, 71);
            this.DeleteOrderDetails.Name = "DeleteOrderDetails";
            this.DeleteOrderDetails.Size = new System.Drawing.Size(75, 23);
            this.DeleteOrderDetails.TabIndex = 5;
            this.DeleteOrderDetails.Text = "删除";
            this.DeleteOrderDetails.UseVisualStyleBackColor = true;
            this.DeleteOrderDetails.Click += new System.EventHandler(this.button13_Click);
            // 
            // DeleteCargoName
            // 
            this.DeleteCargoName.FormattingEnabled = true;
            this.DeleteCargoName.Location = new System.Drawing.Point(59, 27);
            this.DeleteCargoName.Name = "DeleteCargoName";
            this.DeleteCargoName.Size = new System.Drawing.Size(100, 20);
            this.DeleteCargoName.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(-2, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 0;
            this.label16.Text = "货物名称";
            // 
            // ModifiedOrderID
            // 
            this.ModifiedOrderID.Location = new System.Drawing.Point(70, 23);
            this.ModifiedOrderID.Name = "ModifiedOrderID";
            this.ModifiedOrderID.Size = new System.Drawing.Size(100, 21);
            this.ModifiedOrderID.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.DeleteOrder);
            this.tabPage3.Controls.Add(this.DeleteOrderID);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(190, 336);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "删除订单";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "订单号：";
            // 
            // DeleteOrder
            // 
            this.DeleteOrder.Location = new System.Drawing.Point(68, 87);
            this.DeleteOrder.Name = "DeleteOrder";
            this.DeleteOrder.Size = new System.Drawing.Size(75, 23);
            this.DeleteOrder.TabIndex = 1;
            this.DeleteOrder.Text = "删除";
            this.DeleteOrder.UseVisualStyleBackColor = true;
            this.DeleteOrder.Click += new System.EventHandler(this.button6_Click);
            // 
            // DeleteOrderID
            // 
            this.DeleteOrderID.Location = new System.Drawing.Point(68, 41);
            this.DeleteOrderID.Name = "DeleteOrderID";
            this.DeleteOrderID.Size = new System.Drawing.Size(100, 21);
            this.DeleteOrderID.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ExportOrder);
            this.tabPage4.Controls.Add(this.ImportOrder);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(190, 336);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "导入/导出订单";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ExportOrder
            // 
            this.ExportOrder.Location = new System.Drawing.Point(51, 106);
            this.ExportOrder.Name = "ExportOrder";
            this.ExportOrder.Size = new System.Drawing.Size(75, 23);
            this.ExportOrder.TabIndex = 1;
            this.ExportOrder.Text = "导出订单";
            this.ExportOrder.UseVisualStyleBackColor = true;
            this.ExportOrder.Click += new System.EventHandler(this.button5_Click);
            // 
            // ImportOrder
            // 
            this.ImportOrder.Location = new System.Drawing.Point(51, 47);
            this.ImportOrder.Name = "ImportOrder";
            this.ImportOrder.Size = new System.Drawing.Size(75, 23);
            this.ImportOrder.TabIndex = 0;
            this.ImportOrder.Text = "导入订单";
            this.ImportOrder.UseVisualStyleBackColor = true;
            this.ImportOrder.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "customer";
            this.dataGridViewTextBoxColumn1.HeaderText = "客户信息";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "customer";
            this.dataGridViewTextBoxColumn2.HeaderText = "客户信息";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "orderId";
            this.dataGridViewTextBoxColumn6.HeaderText = "订单号";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // customerDataGridViewTextBoxColumn1
            // 
            this.customerDataGridViewTextBoxColumn1.DataPropertyName = "customer";
            this.customerDataGridViewTextBoxColumn1.HeaderText = "顾客信息";
            this.customerDataGridViewTextBoxColumn1.Name = "customerDataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "totalPrice";
            this.dataGridViewTextBoxColumn5.HeaderText = "订单总价";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cargo";
            this.dataGridViewTextBoxColumn3.HeaderText = "货物信息";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "amount";
            this.dataGridViewTextBoxColumn4.HeaderText = "货物数量";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonQuery);
            this.Controls.Add(this.QueryKey);
            this.Controls.Add(this.QueryWay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox QueryWay;
        private System.Windows.Forms.TextBox QueryKey;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddOrder;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddOrderDetails;
        private System.Windows.Forms.TextBox AddCargoAmount;
        private System.Windows.Forms.ComboBox AddCargoName;
        private System.Windows.Forms.TextBox AddCustomerName;
        private System.Windows.Forms.TextBox AddCustomerID;
        private System.Windows.Forms.TextBox AddOrderID;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TextBox ModifiedOrderID;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button DeleteOrder;
        private System.Windows.Forms.TextBox DeleteOrderID;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button ExportOrder;
        private System.Windows.Forms.Button ImportOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ModifyOrderID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NewOrderID;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.Button ModifyCustomerID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NewCustomerID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NewCustomerName;
        private System.Windows.Forms.Button ModifyCustomerName;
        private System.Windows.Forms.ComboBox NewCargo;
        private System.Windows.Forms.ComboBox ModifiedCargo;
        private System.Windows.Forms.Button ModifyCargoAmount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox NewCargoAmount;
        private System.Windows.Forms.Button ModifyCargo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button AddNewOrderDetails;
        private System.Windows.Forms.TextBox AddNewCargoAmount;
        private System.Windows.Forms.ComboBox AddNewCargoName;
        private System.Windows.Forms.Button DeleteOrderDetails;
        private System.Windows.Forms.ComboBox DeleteCargoName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

