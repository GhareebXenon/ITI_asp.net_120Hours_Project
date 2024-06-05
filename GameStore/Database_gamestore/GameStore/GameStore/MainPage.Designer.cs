namespace GameStore
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label product_codeLabel;
            System.Windows.Forms.Label product_nameLabel;
            System.Windows.Forms.Label product_priceLabel;
            System.Windows.Forms.Label publisher_IDLabel;
            System.Windows.Forms.Label categoryLabel;
<<<<<<< HEAD:Database_gamestore/GameStore/GameStore/MainPage.Designer.cs
            System.Windows.Forms.Label publisher_IDLabel1;
            System.Windows.Forms.Label order_idLabel;
            System.Windows.Forms.Label date_orderLabel;
            System.Windows.Forms.Label productLabel;
            System.Windows.Forms.Label product_countLabel;
            System.Windows.Forms.Label customerLabel;
            System.Windows.Forms.Label order_statusLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
=======
>>>>>>> parent of 26607a0 (update2):Database_gamestore/GameStore/GameStore/Form1.Designer.cs
            this.Side_Panel = new System.Windows.Forms.Panel();
            this.Product_panel = new System.Windows.Forms.Panel();
            this.product_btn = new System.Windows.Forms.Button();
            this.order_btn = new System.Windows.Forms.Button();
            this.Publisher_btn = new System.Windows.Forms.Button();
            this.Customer_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gameStoreDataSet = new GameStore.GameStoreDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new GameStore.GameStoreDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new GameStore.GameStoreDataSetTableAdapters.TableAdapterManager();
<<<<<<< HEAD:Database_gamestore/GameStore/GameStore/MainPage.Designer.cs
            this.publisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publisherTableAdapter = new GameStore.GameStoreDataSetTableAdapters.PublisherTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.publisherid_textbox = new System.Windows.Forms.TextBox();
            this.publisheremail_textbox = new System.Windows.Forms.TextBox();
            this.del_supplier_btn = new System.Windows.Forms.Button();
            this.update_supplier_btn = new System.Windows.Forms.Button();
            this.publishername_textBox = new System.Windows.Forms.TextBox();
            this.publisherDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher_panel = new System.Windows.Forms.Panel();
            this.Add_supplier_btn = new System.Windows.Forms.Button();
            this.Customer_panel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerFNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Customer_address_textBox = new System.Windows.Forms.TextBox();
            this.Customer_lname_textBox = new System.Windows.Forms.TextBox();
            this.Add_customer_btn = new System.Windows.Forms.Button();
            this.Customer_phone_textBox = new System.Windows.Forms.TextBox();
            this.Update_customere_btn = new System.Windows.Forms.Button();
            this.del_customer_btn = new System.Windows.Forms.Button();
            this.Customerid_textBox = new System.Windows.Forms.TextBox();
            this.customer_Fname_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.customerTableAdapter = new GameStore.GameStoreDataSetTableAdapters.CustomerTableAdapter();
            this.customer_OrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customer_OrderTableAdapter = new GameStore.GameStoreDataSetTableAdapters.Customer_OrderTableAdapter();
            this.Product_panel = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.productcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Addproduct_btn = new System.Windows.Forms.Button();
            this.Category_comboBox = new System.Windows.Forms.ComboBox();
            this.prprice_textBox = new System.Windows.Forms.TextBox();
            this.prpublisherid_textBox = new System.Windows.Forms.TextBox();
            this.update_product_btn = new System.Windows.Forms.Button();
            this.del_product_btn = new System.Windows.Forms.Button();
            this.prcode_textBox = new System.Windows.Forms.TextBox();
            this.prname_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Orders_panel = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerFNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerLNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatus_comboBox = new System.Windows.Forms.ComboBox();
            this.date_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.order_product_textbox = new System.Windows.Forms.TextBox();
            this.ProductQTY_textbox = new System.Windows.Forms.TextBox();
            this.Co_Customer_textbox = new System.Windows.Forms.TextBox();
            this.orderid_textbox = new System.Windows.Forms.TextBox();
            this.Addneworder_btn = new System.Windows.Forms.Button();
            this.updateorder_btn = new System.Windows.Forms.Button();
            this.deleteorder_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Search_publisher_textBox = new System.Windows.Forms.TextBox();
            this.Search_publisher_btn = new System.Windows.Forms.Button();
            publisher_EmailLabel = new System.Windows.Forms.Label();
            publisher_NameLabel = new System.Windows.Forms.Label();
            publisher_IDLabel = new System.Windows.Forms.Label();
            customer_IDLabel = new System.Windows.Forms.Label();
            customer_FNameLabel = new System.Windows.Forms.Label();
            customer_LNameLabel = new System.Windows.Forms.Label();
            customer_PhoneLabel = new System.Windows.Forms.Label();
            customer_AddressLabel = new System.Windows.Forms.Label();
=======
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRcode_textBox = new System.Windows.Forms.TextBox();
            this.PR_Publisherid_textBox = new System.Windows.Forms.TextBox();
            this.PR_price_textBox = new System.Windows.Forms.TextBox();
            this.PR_name_textBox = new System.Windows.Forms.TextBox();
            this.Category_comboBox = new System.Windows.Forms.ComboBox();
            this.ADD_product_btn = new System.Windows.Forms.Button();
            this.Delete_product_btn = new System.Windows.Forms.Button();
            this.Update_product_btn = new System.Windows.Forms.Button();
            this.Close_btn = new System.Windows.Forms.Button();
>>>>>>> parent of 26607a0 (update2):Database_gamestore/GameStore/GameStore/Form1.Designer.cs
            product_codeLabel = new System.Windows.Forms.Label();
            product_nameLabel = new System.Windows.Forms.Label();
            product_priceLabel = new System.Windows.Forms.Label();
            publisher_IDLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            this.Side_Panel.SuspendLayout();
<<<<<<< HEAD:Database_gamestore/GameStore/GameStore/MainPage.Designer.cs
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherDataGridView)).BeginInit();
            this.Publisher_panel.SuspendLayout();
            this.Customer_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_OrderBindingSource)).BeginInit();
            this.Product_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Orders_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // publisher_EmailLabel
            // 
            publisher_EmailLabel.AutoSize = true;
            publisher_EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            publisher_EmailLabel.ForeColor = System.Drawing.SystemColors.Control;
            publisher_EmailLabel.Location = new System.Drawing.Point(43, 176);
            publisher_EmailLabel.Name = "publisher_EmailLabel";
            publisher_EmailLabel.Size = new System.Drawing.Size(188, 29);
            publisher_EmailLabel.TabIndex = 27;
            publisher_EmailLabel.Text = "Publisher Email:";
            // 
            // publisher_NameLabel
            // 
            publisher_NameLabel.AutoSize = true;
            publisher_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            publisher_NameLabel.ForeColor = System.Drawing.SystemColors.Control;
            publisher_NameLabel.Location = new System.Drawing.Point(457, 135);
            publisher_NameLabel.Name = "publisher_NameLabel";
            publisher_NameLabel.Size = new System.Drawing.Size(192, 29);
            publisher_NameLabel.TabIndex = 25;
            publisher_NameLabel.Text = "Publisher Name:";
            // 
            // publisher_IDLabel
            // 
            publisher_IDLabel.AutoSize = true;
            publisher_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            publisher_IDLabel.ForeColor = System.Drawing.SystemColors.Control;
            publisher_IDLabel.Location = new System.Drawing.Point(43, 138);
            publisher_IDLabel.Name = "publisher_IDLabel";
            publisher_IDLabel.Size = new System.Drawing.Size(150, 29);
            publisher_IDLabel.TabIndex = 23;
            publisher_IDLabel.Text = "Publisher ID:";
            // 
            // customer_IDLabel
            // 
            customer_IDLabel.AutoSize = true;
            customer_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customer_IDLabel.ForeColor = System.Drawing.SystemColors.Control;
            customer_IDLabel.Location = new System.Drawing.Point(23, 141);
            customer_IDLabel.Name = "customer_IDLabel";
            customer_IDLabel.Size = new System.Drawing.Size(127, 25);
            customer_IDLabel.TabIndex = 28;
            customer_IDLabel.Text = "Customer ID:";
            // 
            // customer_FNameLabel
            // 
            customer_FNameLabel.AutoSize = true;
            customer_FNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customer_FNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            customer_FNameLabel.Location = new System.Drawing.Point(23, 179);
            customer_FNameLabel.Name = "customer_FNameLabel";
            customer_FNameLabel.Size = new System.Drawing.Size(202, 25);
            customer_FNameLabel.TabIndex = 30;
            customer_FNameLabel.Text = "Customer Fisrt Name:";
            // 
            // customer_LNameLabel
            // 
            customer_LNameLabel.AutoSize = true;
            customer_LNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customer_LNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            customer_LNameLabel.Location = new System.Drawing.Point(475, 178);
            customer_LNameLabel.Name = "customer_LNameLabel";
            customer_LNameLabel.Size = new System.Drawing.Size(202, 25);
            customer_LNameLabel.TabIndex = 32;
            customer_LNameLabel.Text = "Customer Last Name:";
            // 
            // customer_PhoneLabel
            // 
            customer_PhoneLabel.AutoSize = true;
            customer_PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customer_PhoneLabel.ForeColor = System.Drawing.SystemColors.Control;
            customer_PhoneLabel.Location = new System.Drawing.Point(474, 138);
            customer_PhoneLabel.Name = "customer_PhoneLabel";
            customer_PhoneLabel.Size = new System.Drawing.Size(165, 25);
            customer_PhoneLabel.TabIndex = 34;
            customer_PhoneLabel.Text = "Customer Phone:";
            // 
            // customer_AddressLabel
            // 
            customer_AddressLabel.AutoSize = true;
            customer_AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customer_AddressLabel.ForeColor = System.Drawing.SystemColors.Control;
            customer_AddressLabel.Location = new System.Drawing.Point(23, 221);
            customer_AddressLabel.Name = "customer_AddressLabel";
            customer_AddressLabel.Size = new System.Drawing.Size(181, 25);
            customer_AddressLabel.TabIndex = 36;
            customer_AddressLabel.Text = "Customer Address:";
            // 
            // product_codeLabel
            // 
            product_codeLabel.AutoSize = true;
            product_codeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            product_codeLabel.Location = new System.Drawing.Point(51, 147);
            product_codeLabel.Name = "product_codeLabel";
            product_codeLabel.Size = new System.Drawing.Size(133, 25);
            product_codeLabel.TabIndex = 38;
            product_codeLabel.Text = "Product code:";
            // 
            // product_nameLabel
            // 
            product_nameLabel.AutoSize = true;
            product_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            product_nameLabel.Location = new System.Drawing.Point(51, 181);
            product_nameLabel.Name = "product_nameLabel";
            product_nameLabel.Size = new System.Drawing.Size(139, 25);
            product_nameLabel.TabIndex = 40;
            product_nameLabel.Text = "Product name:";
            // 
            // product_priceLabel
            // 
            product_priceLabel.AutoSize = true;
            product_priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            product_priceLabel.Location = new System.Drawing.Point(51, 220);
            product_priceLabel.Name = "product_priceLabel";
            product_priceLabel.Size = new System.Drawing.Size(132, 25);
            product_priceLabel.TabIndex = 42;
            product_priceLabel.Text = "Product price:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoryLabel.Location = new System.Drawing.Point(544, 181);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(98, 25);
            categoryLabel.TabIndex = 46;
            categoryLabel.Text = "Category:";
            // 
            // publisher_IDLabel1
            // 
            publisher_IDLabel1.AutoSize = true;
            publisher_IDLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            publisher_IDLabel1.Location = new System.Drawing.Point(541, 144);
            publisher_IDLabel1.Name = "publisher_IDLabel1";
            publisher_IDLabel1.Size = new System.Drawing.Size(123, 25);
            publisher_IDLabel1.TabIndex = 48;
            publisher_IDLabel1.Text = "Publisher ID:";
            // 
            // order_idLabel
            // 
            order_idLabel.AutoSize = true;
            order_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            order_idLabel.Location = new System.Drawing.Point(47, 141);
            order_idLabel.Name = "order_idLabel";
            order_idLabel.Size = new System.Drawing.Size(92, 25);
            order_idLabel.TabIndex = 28;
            order_idLabel.Text = "Order ID:";
            // 
            // date_orderLabel
            // 
            date_orderLabel.AutoSize = true;
            date_orderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            date_orderLabel.Location = new System.Drawing.Point(47, 176);
            date_orderLabel.Name = "date_orderLabel";
            date_orderLabel.Size = new System.Drawing.Size(59, 25);
            date_orderLabel.TabIndex = 30;
            date_orderLabel.Text = "Date:";
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productLabel.Location = new System.Drawing.Point(47, 210);
            productLabel.Name = "productLabel";
            productLabel.Size = new System.Drawing.Size(85, 25);
            productLabel.TabIndex = 32;
            productLabel.Text = "Product:";
            // 
            // product_countLabel
            // 
            product_countLabel.AutoSize = true;
            product_countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            product_countLabel.Location = new System.Drawing.Point(420, 141);
            product_countLabel.Name = "product_countLabel";
            product_countLabel.Size = new System.Drawing.Size(163, 25);
            product_countLabel.TabIndex = 34;
            product_countLabel.Text = "Product Quentity:";
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerLabel.Location = new System.Drawing.Point(420, 175);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new System.Drawing.Size(103, 25);
            customerLabel.TabIndex = 36;
            customerLabel.Text = "Customer:";
            // 
            // order_statusLabel
            // 
            order_statusLabel.AutoSize = true;
            order_statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            order_statusLabel.Location = new System.Drawing.Point(420, 209);
            order_statusLabel.Name = "order_statusLabel";
            order_statusLabel.Size = new System.Drawing.Size(129, 25);
            order_statusLabel.TabIndex = 38;
            order_statusLabel.Text = "Order Status:";
            // 
=======
            this.Product_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
>>>>>>> parent of 26607a0 (update2):Database_gamestore/GameStore/GameStore/Form1.Designer.cs
            // Side_Panel
            // 
            this.Side_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.Side_Panel.Controls.Add(this.Close_btn);
            this.Side_Panel.Controls.Add(this.Customer_btn);
            this.Side_Panel.Controls.Add(this.Publisher_btn);
            this.Side_Panel.Controls.Add(this.order_btn);
            this.Side_Panel.Controls.Add(this.product_btn);
<<<<<<< HEAD:Database_gamestore/GameStore/GameStore/MainPage.Designer.cs
            this.Side_Panel.Location = new System.Drawing.Point(-4, 1);
            this.Side_Panel.Name = "Side_Panel";
            this.Side_Panel.Size = new System.Drawing.Size(286, 664);
            this.Side_Panel.TabIndex = 0;
            // 
            // Close_btn
            // 
            this.Close_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Close_btn.BackColor = System.Drawing.Color.White;
            this.Close_btn.FlatAppearance.BorderSize = 0;
            this.Close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.Close_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Close_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Close_btn.Location = new System.Drawing.Point(24, 577);
            this.Close_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(235, 51);
            this.Close_btn.TabIndex = 10;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseVisualStyleBackColor = false;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // Customer_btn
            // 
            this.Customer_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Customer_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.Customer_btn.FlatAppearance.BorderSize = 0;
            this.Customer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Customer_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Customer_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Customer_btn.Location = new System.Drawing.Point(6, 207);
            this.Customer_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Customer_btn.Name = "Customer_btn";
            this.Customer_btn.Size = new System.Drawing.Size(280, 80);
            this.Customer_btn.TabIndex = 9;
            this.Customer_btn.Text = "Customer";
            this.Customer_btn.UseVisualStyleBackColor = false;
            this.Customer_btn.Click += new System.EventHandler(this.Customer_btn_Click);
            // 
            // Publisher_btn
            // 
            this.Publisher_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Publisher_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.Publisher_btn.FlatAppearance.BorderSize = 0;
            this.Publisher_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Publisher_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publisher_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Publisher_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Publisher_btn.Location = new System.Drawing.Point(6, 365);
            this.Publisher_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Publisher_btn.Name = "Publisher_btn";
            this.Publisher_btn.Size = new System.Drawing.Size(280, 80);
            this.Publisher_btn.TabIndex = 8;
            this.Publisher_btn.Text = "Publisher";
            this.Publisher_btn.UseVisualStyleBackColor = false;
            this.Publisher_btn.Click += new System.EventHandler(this.Publisher_btn_Click);
            // 
            // order_btn
            // 
            this.order_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.order_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.order_btn.FlatAppearance.BorderSize = 0;
            this.order_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.order_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.order_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.order_btn.Location = new System.Drawing.Point(6, 286);
            this.order_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.order_btn.Name = "order_btn";
            this.order_btn.Size = new System.Drawing.Size(280, 80);
            this.order_btn.TabIndex = 7;
            this.order_btn.Text = "Orders";
            this.order_btn.UseVisualStyleBackColor = false;
            this.order_btn.Click += new System.EventHandler(this.order_btn_Click);
=======
            this.Side_Panel.Location = new System.Drawing.Point(1, 1);
            this.Side_Panel.Name = "Side_Panel";
            this.Side_Panel.Size = new System.Drawing.Size(281, 655);
            this.Side_Panel.TabIndex = 0;
            // 
            // Product_panel
            // 
            this.Product_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.Product_panel.Controls.Add(this.Update_product_btn);
            this.Product_panel.Controls.Add(this.Delete_product_btn);
            this.Product_panel.Controls.Add(this.ADD_product_btn);
            this.Product_panel.Controls.Add(this.Category_comboBox);
            this.Product_panel.Controls.Add(this.PR_name_textBox);
            this.Product_panel.Controls.Add(this.PR_price_textBox);
            this.Product_panel.Controls.Add(this.PR_Publisherid_textBox);
            this.Product_panel.Controls.Add(this.PRcode_textBox);
            this.Product_panel.Controls.Add(product_codeLabel);
            this.Product_panel.Controls.Add(product_nameLabel);
            this.Product_panel.Controls.Add(product_priceLabel);
            this.Product_panel.Controls.Add(publisher_IDLabel);
            this.Product_panel.Controls.Add(categoryLabel);
            this.Product_panel.Controls.Add(this.productDataGridView);
            this.Product_panel.Controls.Add(this.label1);
            this.Product_panel.Location = new System.Drawing.Point(279, 1);
            this.Product_panel.Name = "Product_panel";
            this.Product_panel.Size = new System.Drawing.Size(941, 652);
            this.Product_panel.TabIndex = 1;
>>>>>>> parent of 26607a0 (update2):Database_gamestore/GameStore/GameStore/Form1.Designer.cs
            // 
            // product_btn
            // 
            this.product_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
<<<<<<< HEAD:Database_gamestore/GameStore/GameStore/MainPage.Designer.cs
            this.product_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.product_btn.FlatAppearance.BorderSize = 0;
            this.product_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.product_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.product_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.product_btn.Location = new System.Drawing.Point(6, 128);
            this.product_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.product_btn.Name = "product_btn";
            this.product_btn.Size = new System.Drawing.Size(280, 80);
=======
            this.product_btn.BackColor = System.Drawing.Color.White;
            this.product_btn.FlatAppearance.BorderSize = 0;
            this.product_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.product_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.product_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.product_btn.Location = new System.Drawing.Point(24, 153);
            this.product_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.product_btn.Name = "product_btn";
            this.product_btn.Size = new System.Drawing.Size(235, 56);
>>>>>>> parent of 26607a0 (update2):Database_gamestore/GameStore/GameStore/Form1.Designer.cs
            this.product_btn.TabIndex = 6;
            this.product_btn.Text = "Product ";
            this.product_btn.UseVisualStyleBackColor = false;
            this.product_btn.Click += new System.EventHandler(this.product_btn_Click);
            // 
<<<<<<< HEAD:Database_gamestore/GameStore/GameStore/MainPage.Designer.cs
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.gameStoreDataSet;
=======
            // order_btn
            // 
            this.order_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.order_btn.BackColor = System.Drawing.Color.White;
            this.order_btn.FlatAppearance.BorderSize = 0;
            this.order_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.order_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.order_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.order_btn.Location = new System.Drawing.Point(24, 308);
            this.order_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.order_btn.Name = "order_btn";
            this.order_btn.Size = new System.Drawing.Size(235, 56);
            this.order_btn.TabIndex = 7;
            this.order_btn.Text = "Orders";
            this.order_btn.UseVisualStyleBackColor = false;
            // 
            // Publisher_btn
            // 
            this.Publisher_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Publisher_btn.BackColor = System.Drawing.Color.White;
            this.Publisher_btn.FlatAppearance.BorderSize = 0;
            this.Publisher_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.Publisher_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Publisher_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Publisher_btn.Location = new System.Drawing.Point(24, 387);
            this.Publisher_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Publisher_btn.Name = "Publisher_btn";
            this.Publisher_btn.Size = new System.Drawing.Size(235, 56);
            this.Publisher_btn.TabIndex = 8;
            this.Publisher_btn.Text = "Publisher";
            this.Publisher_btn.UseVisualStyleBackColor = false;
            // 
            // Customer_btn
            // 
            this.Customer_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Customer_btn.BackColor = System.Drawing.Color.White;
            this.Customer_btn.FlatAppearance.BorderSize = 0;
            this.Customer_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.Customer_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Customer_btn.Location = new System.Drawing.Point(24, 230);
            this.Customer_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Customer_btn.Name = "Customer_btn";
            this.Customer_btn.Size = new System.Drawing.Size(235, 56);
            this.Customer_btn.TabIndex = 9;
            this.Customer_btn.Text = "Customer";
            this.Customer_btn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(102, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Info";
>>>>>>> parent of 26607a0 (update2):Database_gamestore/GameStore/GameStore/Form1.Designer.cs
            // 
            // gameStoreDataSet
            // 
            this.gameStoreDataSet.DataSetName = "GameStoreDataSet";
            this.gameStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
<<<<<<< HEAD:Database_gamestore/GameStore/GameStore/MainPage.Designer.cs
=======
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.gameStoreDataSet;
            // 
>>>>>>> parent of 26607a0 (update2):Database_gamestore/GameStore/GameStore/Form1.Designer.cs
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Customer_OrderTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.PublisherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GameStore.GameStoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
<<<<<<< HEAD:Database_gamestore/GameStore/GameStore/MainPage.Designer.cs
            // publisherBindingSource
            // 
            this.publisherBindingSource.DataMember = "Publisher";
            this.publisherBindingSource.DataSource = this.gameStoreDataSet;
            // 
            // publisherTableAdapter
            // 
            this.publisherTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(21, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(308, 54);
            this.label8.TabIndex = 0;
            this.label8.Text = "Publisher Info";
            // 
            // publisherid_textbox
            // 
            this.publisherid_textbox.Location = new System.Drawing.Point(243, 137);
            this.publisherid_textbox.Multiline = true;
            this.publisherid_textbox.Name = "publisherid_textbox";
            this.publisherid_textbox.Size = new System.Drawing.Size(195, 30);
            this.publisherid_textbox.TabIndex = 11;
            this.publisherid_textbox.TextChanged += new System.EventHandler(this.publisherid_textbox_TextChanged);
            // 
            // publisheremail_textbox
            // 
            this.publisheremail_textbox.Location = new System.Drawing.Point(243, 178);
            this.publisheremail_textbox.Multiline = true;
            this.publisheremail_textbox.Name = "publisheremail_textbox";
            this.publisheremail_textbox.Size = new System.Drawing.Size(195, 30);
            this.publisheremail_textbox.TabIndex = 15;
            // 
            // del_supplier_btn
            // 
            this.del_supplier_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.del_supplier_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.del_supplier_btn.Location = new System.Drawing.Point(365, 275);
            this.del_supplier_btn.Name = "del_supplier_btn";
            this.del_supplier_btn.Size = new System.Drawing.Size(144, 42);
            this.del_supplier_btn.TabIndex = 18;
            this.del_supplier_btn.Text = "Delete";
            this.del_supplier_btn.UseVisualStyleBackColor = true;
            this.del_supplier_btn.Click += new System.EventHandler(this.del_supplier_btn_Click);
            // 
            // update_supplier_btn
            // 
            this.update_supplier_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.update_supplier_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.update_supplier_btn.Location = new System.Drawing.Point(535, 275);
            this.update_supplier_btn.Name = "update_supplier_btn";
            this.update_supplier_btn.Size = new System.Drawing.Size(144, 42);
            this.update_supplier_btn.TabIndex = 21;
            this.update_supplier_btn.Text = "Update";
            this.update_supplier_btn.UseVisualStyleBackColor = true;
            this.update_supplier_btn.Click += new System.EventHandler(this.update_supplier_btn_Click);
            // 
            // publishername_textBox
            // 
            this.publishername_textBox.Location = new System.Drawing.Point(673, 135);
            this.publishername_textBox.Multiline = true;
            this.publishername_textBox.Name = "publishername_textBox";
            this.publishername_textBox.Size = new System.Drawing.Size(195, 30);
            this.publishername_textBox.TabIndex = 23;
            // 
            // publisherDataGridView
            // 
            this.publisherDataGridView.AutoGenerateColumns = false;
            this.publisherDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.publisherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publisherDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.publisherDataGridView.DataSource = this.publisherBindingSource;
            this.publisherDataGridView.Location = new System.Drawing.Point(59, 381);
            this.publisherDataGridView.Name = "publisherDataGridView";
            this.publisherDataGridView.RowHeadersWidth = 51;
            this.publisherDataGridView.RowTemplate.Height = 24;
            this.publisherDataGridView.Size = new System.Drawing.Size(841, 220);
            this.publisherDataGridView.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Publisher_ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "Publisher_ID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Publisher_Name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Publisher_Name";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Publisher_Email";
            this.dataGridViewTextBoxColumn8.HeaderText = "Publisher_Email";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // Publisher_panel
            // 
            this.Publisher_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.Publisher_panel.Controls.Add(this.Search_publisher_btn);
            this.Publisher_panel.Controls.Add(this.Search_publisher_textBox);
            this.Publisher_panel.Controls.Add(this.Add_supplier_btn);
            this.Publisher_panel.Controls.Add(publisher_IDLabel);
            this.Publisher_panel.Controls.Add(publisher_NameLabel);
            this.Publisher_panel.Controls.Add(publisher_EmailLabel);
            this.Publisher_panel.Controls.Add(this.publisherDataGridView);
            this.Publisher_panel.Controls.Add(this.publishername_textBox);
            this.Publisher_panel.Controls.Add(this.update_supplier_btn);
            this.Publisher_panel.Controls.Add(this.del_supplier_btn);
            this.Publisher_panel.Controls.Add(this.publisheremail_textbox);
            this.Publisher_panel.Controls.Add(this.publisherid_textbox);
            this.Publisher_panel.Controls.Add(this.label8);
            this.Publisher_panel.Location = new System.Drawing.Point(282, 4);
            this.Publisher_panel.Name = "Publisher_panel";
            this.Publisher_panel.Size = new System.Drawing.Size(958, 661);
            this.Publisher_panel.TabIndex = 24;
            // 
            // Add_supplier_btn
            // 
            this.Add_supplier_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Add_supplier_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Add_supplier_btn.Location = new System.Drawing.Point(206, 275);
            this.Add_supplier_btn.Name = "Add_supplier_btn";
            this.Add_supplier_btn.Size = new System.Drawing.Size(144, 42);
            this.Add_supplier_btn.TabIndex = 28;
            this.Add_supplier_btn.Text = "ADD";
            this.Add_supplier_btn.UseVisualStyleBackColor = true;
            this.Add_supplier_btn.Click += new System.EventHandler(this.Add_supplier_btn_Click);
            // 
            // Customer_panel
            // 
            this.Customer_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.Customer_panel.Controls.Add(this.dataGridView1);
            this.Customer_panel.Controls.Add(this.Customer_address_textBox);
            this.Customer_panel.Controls.Add(this.Customer_lname_textBox);
            this.Customer_panel.Controls.Add(customer_IDLabel);
            this.Customer_panel.Controls.Add(customer_FNameLabel);
            this.Customer_panel.Controls.Add(customer_LNameLabel);
            this.Customer_panel.Controls.Add(customer_PhoneLabel);
            this.Customer_panel.Controls.Add(customer_AddressLabel);
            this.Customer_panel.Controls.Add(this.Add_customer_btn);
            this.Customer_panel.Controls.Add(this.Customer_phone_textBox);
            this.Customer_panel.Controls.Add(this.Update_customere_btn);
            this.Customer_panel.Controls.Add(this.del_customer_btn);
            this.Customer_panel.Controls.Add(this.Customerid_textBox);
            this.Customer_panel.Controls.Add(this.customer_Fname_textBox);
            this.Customer_panel.Controls.Add(this.label6);
            this.Customer_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_panel.ForeColor = System.Drawing.SystemColors.Control;
            this.Customer_panel.Location = new System.Drawing.Point(284, 3);
            this.Customer_panel.Name = "Customer_panel";
            this.Customer_panel.Size = new System.Drawing.Size(958, 655);
            this.Customer_panel.TabIndex = 29;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.customerFNameDataGridViewTextBoxColumn,
            this.customerLNameDataGridViewTextBoxColumn,
            this.customerPhoneDataGridViewTextBoxColumn,
            this.customerAddressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 382);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 10;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(891, 243);
            this.dataGridView1.TabIndex = 39;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerFNameDataGridViewTextBoxColumn
            // 
            this.customerFNameDataGridViewTextBoxColumn.DataPropertyName = "Customer_FName";
            this.customerFNameDataGridViewTextBoxColumn.HeaderText = "Customer_FName";
            this.customerFNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerFNameDataGridViewTextBoxColumn.Name = "customerFNameDataGridViewTextBoxColumn";
            // 
            // customerLNameDataGridViewTextBoxColumn
            // 
            this.customerLNameDataGridViewTextBoxColumn.DataPropertyName = "Customer_LName";
            this.customerLNameDataGridViewTextBoxColumn.HeaderText = "Customer_LName";
            this.customerLNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerLNameDataGridViewTextBoxColumn.Name = "customerLNameDataGridViewTextBoxColumn";
            // 
            // customerPhoneDataGridViewTextBoxColumn
            // 
            this.customerPhoneDataGridViewTextBoxColumn.DataPropertyName = "Customer_Phone";
            this.customerPhoneDataGridViewTextBoxColumn.HeaderText = "Customer_Phone";
            this.customerPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerPhoneDataGridViewTextBoxColumn.Name = "customerPhoneDataGridViewTextBoxColumn";
            // 
            // customerAddressDataGridViewTextBoxColumn
            // 
            this.customerAddressDataGridViewTextBoxColumn.DataPropertyName = "Customer_Address";
            this.customerAddressDataGridViewTextBoxColumn.HeaderText = "Customer_Address";
            this.customerAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerAddressDataGridViewTextBoxColumn.Name = "customerAddressDataGridViewTextBoxColumn";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.gameStoreDataSet;
            // 
            // Customer_address_textBox
            // 
            this.Customer_address_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_address_textBox.Location = new System.Drawing.Point(247, 220);
            this.Customer_address_textBox.Multiline = true;
            this.Customer_address_textBox.Name = "Customer_address_textBox";
            this.Customer_address_textBox.Size = new System.Drawing.Size(322, 64);
            this.Customer_address_textBox.TabIndex = 38;
            // 
            // Customer_lname_textBox
            // 
            this.Customer_lname_textBox.Location = new System.Drawing.Point(703, 178);
            this.Customer_lname_textBox.Multiline = true;
            this.Customer_lname_textBox.Name = "Customer_lname_textBox";
            this.Customer_lname_textBox.Size = new System.Drawing.Size(195, 30);
            this.Customer_lname_textBox.TabIndex = 37;
            // 
            // Add_customer_btn
            // 
            this.Add_customer_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Add_customer_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Add_customer_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Add_customer_btn.Location = new System.Drawing.Point(151, 320);
            this.Add_customer_btn.Name = "Add_customer_btn";
            this.Add_customer_btn.Size = new System.Drawing.Size(144, 42);
            this.Add_customer_btn.TabIndex = 28;
            this.Add_customer_btn.Text = "ADD";
            this.Add_customer_btn.UseVisualStyleBackColor = true;
            this.Add_customer_btn.Click += new System.EventHandler(this.Add_customer_btn_Click);
            // 
            // Customer_phone_textBox
            // 
            this.Customer_phone_textBox.Location = new System.Drawing.Point(703, 137);
            this.Customer_phone_textBox.Multiline = true;
            this.Customer_phone_textBox.Name = "Customer_phone_textBox";
            this.Customer_phone_textBox.Size = new System.Drawing.Size(195, 30);
            this.Customer_phone_textBox.TabIndex = 23;
            // 
            // Update_customere_btn
            // 
            this.Update_customere_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Update_customere_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Update_customere_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Update_customere_btn.Location = new System.Drawing.Point(480, 320);
            this.Update_customere_btn.Name = "Update_customere_btn";
            this.Update_customere_btn.Size = new System.Drawing.Size(144, 42);
            this.Update_customere_btn.TabIndex = 21;
            this.Update_customere_btn.Text = "Update";
            this.Update_customere_btn.UseVisualStyleBackColor = true;
            this.Update_customere_btn.Click += new System.EventHandler(this.Update_customere_btn_Click);
            // 
            // del_customer_btn
            // 
            this.del_customer_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.del_customer_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.del_customer_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.del_customer_btn.Location = new System.Drawing.Point(310, 320);
            this.del_customer_btn.Name = "del_customer_btn";
            this.del_customer_btn.Size = new System.Drawing.Size(144, 42);
            this.del_customer_btn.TabIndex = 18;
            this.del_customer_btn.Text = "Delete";
            this.del_customer_btn.UseVisualStyleBackColor = true;
            this.del_customer_btn.Click += new System.EventHandler(this.del_customer_btn_Click);
            // 
            // Customerid_textBox
            // 
            this.Customerid_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customerid_textBox.Location = new System.Drawing.Point(247, 140);
            this.Customerid_textBox.Multiline = true;
            this.Customerid_textBox.Name = "Customerid_textBox";
            this.Customerid_textBox.Size = new System.Drawing.Size(195, 30);
            this.Customerid_textBox.TabIndex = 15;
            // 
            // customer_Fname_textBox
            // 
            this.customer_Fname_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_Fname_textBox.Location = new System.Drawing.Point(247, 180);
            this.customer_Fname_textBox.Multiline = true;
            this.customer_Fname_textBox.Name = "customer_Fname_textBox";
            this.customer_Fname_textBox.Size = new System.Drawing.Size(195, 30);
            this.customer_Fname_textBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(102, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(317, 54);
            this.label6.TabIndex = 0;
            this.label6.Text = "Customer Info";
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // customer_OrderBindingSource
            // 
            this.customer_OrderBindingSource.DataMember = "Customer_Order";
            this.customer_OrderBindingSource.DataSource = this.gameStoreDataSet;
            // 
            // customer_OrderTableAdapter
            // 
            this.customer_OrderTableAdapter.ClearBeforeFill = true;
            // 
            // Product_panel
            // 
            this.Product_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.Product_panel.Controls.Add(this.dataGridView2);
            this.Product_panel.Controls.Add(this.Addproduct_btn);
            this.Product_panel.Controls.Add(publisher_IDLabel1);
            this.Product_panel.Controls.Add(this.Category_comboBox);
            this.Product_panel.Controls.Add(product_codeLabel);
            this.Product_panel.Controls.Add(product_nameLabel);
            this.Product_panel.Controls.Add(product_priceLabel);
            this.Product_panel.Controls.Add(categoryLabel);
            this.Product_panel.Controls.Add(this.prprice_textBox);
            this.Product_panel.Controls.Add(this.prpublisherid_textBox);
            this.Product_panel.Controls.Add(this.update_product_btn);
            this.Product_panel.Controls.Add(this.del_product_btn);
            this.Product_panel.Controls.Add(this.prcode_textBox);
            this.Product_panel.Controls.Add(this.prname_textBox);
            this.Product_panel.Controls.Add(this.label7);
            this.Product_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_panel.ForeColor = System.Drawing.SystemColors.Control;
            this.Product_panel.Location = new System.Drawing.Point(285, 1);
            this.Product_panel.Name = "Product_panel";
            this.Product_panel.Size = new System.Drawing.Size(958, 664);
            this.Product_panel.TabIndex = 39;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productcodeDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.productpriceDataGridViewTextBoxColumn,
            this.publisherIDDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.productBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(45, 384);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 10;
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(865, 228);
            this.dataGridView2.TabIndex = 50;
=======
            // productDataGridView
            // 
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(59, 365);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.RowHeadersWidth = 51;
            this.productDataGridView.RowTemplate.Height = 24;
            this.productDataGridView.Size = new System.Drawing.Size(807, 220);
            this.productDataGridView.TabIndex = 1;
>>>>>>> parent of 26607a0 (update2):Database_gamestore/GameStore/GameStore/Form1.Designer.cs
            // 
            // productcodeDataGridViewTextBoxColumn
            // 
<<<<<<< HEAD:Database_gamestore/GameStore/GameStore/MainPage.Designer.cs
            this.productcodeDataGridViewTextBoxColumn.DataPropertyName = "Product_code";
            this.productcodeDataGridViewTextBoxColumn.HeaderText = "Product_code";
            this.productcodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productcodeDataGridViewTextBoxColumn.Name = "productcodeDataGridViewTextBoxColumn";
            this.productcodeDataGridViewTextBoxColumn.ReadOnly = true;
=======
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Product_code";
            this.dataGridViewTextBoxColumn1.HeaderText = "Product_code";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
>>>>>>> parent of 26607a0 (update2):Database_gamestore/GameStore/GameStore/Form1.Designer.cs
            // 
            // productnameDataGridViewTextBoxColumn
            // 
<<<<<<< HEAD:Database_gamestore/GameStore/GameStore/MainPage.Designer.cs
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "Product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "Product_name";
            this.productnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
=======
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Product_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Product_name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
>>>>>>> parent of 26607a0 (update2):Database_gamestore/GameStore/GameStore/Form1.Designer.cs
            // 
            // productpriceDataGridViewTextBoxColumn
            // 
<<<<<<< HEAD:Database_gamestore/GameStore/GameStore/MainPage.Designer.cs
            this.productpriceDataGridViewTextBoxColumn.DataPropertyName = "Product_price";
            this.productpriceDataGridViewTextBoxColumn.HeaderText = "Product_price";
            this.productpriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productpriceDataGridViewTextBoxColumn.Name = "productpriceDataGridViewTextBoxColumn";
=======
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Product_price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Product_price";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
>>>>>>> parent of 26607a0 (update2):Database_gamestore/GameStore/GameStore/Form1.Designer.cs
            // 
            // publisherIDDataGridViewTextBoxColumn
            // 
<<<<<<< HEAD:Database_gamestore/GameStore/GameStore/MainPage.Designer.cs
            this.publisherIDDataGridViewTextBoxColumn.DataPropertyName = "Publisher_ID";
            this.publisherIDDataGridViewTextBoxColumn.HeaderText = "Publisher_ID";
            this.publisherIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.publisherIDDataGridViewTextBoxColumn.Name = "publisherIDDataGridViewTextBoxColumn";
=======
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Publisher_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "Publisher_ID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
>>>>>>> parent of 26607a0 (update2):Database_gamestore/GameStore/GameStore/Form1.Designer.cs
            // 
            // categoryDataGridViewTextBoxColumn
            // 
<<<<<<< HEAD:Database_gamestore/GameStore/GameStore/MainPage.Designer.cs
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // Addproduct_btn
            // 
            this.Addproduct_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Addproduct_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Addproduct_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Addproduct_btn.Location = new System.Drawing.Point(202, 293);
            this.Addproduct_btn.Name = "Addproduct_btn";
            this.Addproduct_btn.Size = new System.Drawing.Size(144, 42);
            this.Addproduct_btn.TabIndex = 49;
            this.Addproduct_btn.Text = "ADD";
            this.Addproduct_btn.UseVisualStyleBackColor = true;
            this.Addproduct_btn.Click += new System.EventHandler(this.ADD_product_btn_Click);
            // 
            // Category_comboBox
            // 
            this.Category_comboBox.FormattingEnabled = true;
            this.Category_comboBox.Items.AddRange(new object[] {
            "Game",
            "Accessories",
            "Consols",
            ""});
            this.Category_comboBox.Location = new System.Drawing.Point(690, 176);
            this.Category_comboBox.Name = "Category_comboBox";
            this.Category_comboBox.Size = new System.Drawing.Size(195, 30);
            this.Category_comboBox.TabIndex = 47;
            // 
            // prprice_textBox
            // 
            this.prprice_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prprice_textBox.Location = new System.Drawing.Point(247, 217);
            this.prprice_textBox.Multiline = true;
            this.prprice_textBox.Name = "prprice_textBox";
            this.prprice_textBox.Size = new System.Drawing.Size(195, 30);
            this.prprice_textBox.TabIndex = 38;
            // 
            // prpublisherid_textBox
            // 
            this.prpublisherid_textBox.Location = new System.Drawing.Point(691, 137);
            this.prpublisherid_textBox.Multiline = true;
            this.prpublisherid_textBox.Name = "prpublisherid_textBox";
            this.prpublisherid_textBox.Size = new System.Drawing.Size(195, 30);
            this.prpublisherid_textBox.TabIndex = 23;
            // 
            // update_product_btn
            // 
            this.update_product_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.update_product_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.update_product_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.update_product_btn.Location = new System.Drawing.Point(532, 293);
            this.update_product_btn.Name = "update_product_btn";
            this.update_product_btn.Size = new System.Drawing.Size(144, 42);
            this.update_product_btn.TabIndex = 21;
            this.update_product_btn.Text = "Update";
            this.update_product_btn.UseVisualStyleBackColor = true;
            this.update_product_btn.Click += new System.EventHandler(this.productBindingNavigatorSaveItem_Click);
            // 
            // del_product_btn
            // 
            this.del_product_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.del_product_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.del_product_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.del_product_btn.Location = new System.Drawing.Point(367, 293);
            this.del_product_btn.Name = "del_product_btn";
            this.del_product_btn.Size = new System.Drawing.Size(144, 42);
            this.del_product_btn.TabIndex = 18;
            this.del_product_btn.Text = "Delete";
            this.del_product_btn.UseVisualStyleBackColor = true;
            this.del_product_btn.Click += new System.EventHandler(this.Delete_product_btn_Click);
            // 
            // prcode_textBox
            // 
            this.prcode_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prcode_textBox.Location = new System.Drawing.Point(247, 140);
            this.prcode_textBox.Multiline = true;
            this.prcode_textBox.Name = "prcode_textBox";
            this.prcode_textBox.Size = new System.Drawing.Size(195, 30);
            this.prcode_textBox.TabIndex = 15;
            // 
            // prname_textBox
            // 
            this.prname_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prname_textBox.Location = new System.Drawing.Point(247, 177);
            this.prname_textBox.Multiline = true;
            this.prname_textBox.Name = "prname_textBox";
            this.prname_textBox.Size = new System.Drawing.Size(195, 30);
            this.prname_textBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(102, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(366, 54);
            this.label7.TabIndex = 0;
            this.label7.Text = "Manage Product";
            // 
            // Orders_panel
            // 
            this.Orders_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.Orders_panel.Controls.Add(this.dataGridView3);
            this.Orders_panel.Controls.Add(this.OrderStatus_comboBox);
            this.Orders_panel.Controls.Add(this.date_dateTimePicker);
            this.Orders_panel.Controls.Add(this.order_product_textbox);
            this.Orders_panel.Controls.Add(this.ProductQTY_textbox);
            this.Orders_panel.Controls.Add(this.Co_Customer_textbox);
            this.Orders_panel.Controls.Add(this.orderid_textbox);
            this.Orders_panel.Controls.Add(order_idLabel);
            this.Orders_panel.Controls.Add(date_orderLabel);
            this.Orders_panel.Controls.Add(productLabel);
            this.Orders_panel.Controls.Add(product_countLabel);
            this.Orders_panel.Controls.Add(customerLabel);
            this.Orders_panel.Controls.Add(order_statusLabel);
            this.Orders_panel.Controls.Add(this.Addneworder_btn);
            this.Orders_panel.Controls.Add(this.updateorder_btn);
            this.Orders_panel.Controls.Add(this.deleteorder_btn);
            this.Orders_panel.Controls.Add(this.label9);
            this.Orders_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orders_panel.ForeColor = System.Drawing.SystemColors.Control;
            this.Orders_panel.Location = new System.Drawing.Point(284, 3);
            this.Orders_panel.Name = "Orders_panel";
            this.Orders_panel.Size = new System.Drawing.Size(958, 655);
            this.Orders_panel.TabIndex = 39;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn1,
            this.customerFNameDataGridViewTextBoxColumn1,
            this.customerLNameDataGridViewTextBoxColumn1,
            this.customerPhoneDataGridViewTextBoxColumn1,
            this.customerAddressDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.customerBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView3.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView3.Location = new System.Drawing.Point(46, 374);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 10;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(857, 251);
            this.dataGridView3.TabIndex = 47;
            // 
            // customerIDDataGridViewTextBoxColumn1
            // 
            this.customerIDDataGridViewTextBoxColumn1.DataPropertyName = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn1.HeaderText = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn1.Name = "customerIDDataGridViewTextBoxColumn1";
            this.customerIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // customerFNameDataGridViewTextBoxColumn1
            // 
            this.customerFNameDataGridViewTextBoxColumn1.DataPropertyName = "Customer_FName";
            this.customerFNameDataGridViewTextBoxColumn1.HeaderText = "Customer_FName";
            this.customerFNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.customerFNameDataGridViewTextBoxColumn1.Name = "customerFNameDataGridViewTextBoxColumn1";
            // 
            // customerLNameDataGridViewTextBoxColumn1
            // 
            this.customerLNameDataGridViewTextBoxColumn1.DataPropertyName = "Customer_LName";
            this.customerLNameDataGridViewTextBoxColumn1.HeaderText = "Customer_LName";
            this.customerLNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.customerLNameDataGridViewTextBoxColumn1.Name = "customerLNameDataGridViewTextBoxColumn1";
            // 
            // customerPhoneDataGridViewTextBoxColumn1
            // 
            this.customerPhoneDataGridViewTextBoxColumn1.DataPropertyName = "Customer_Phone";
            this.customerPhoneDataGridViewTextBoxColumn1.HeaderText = "Customer_Phone";
            this.customerPhoneDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.customerPhoneDataGridViewTextBoxColumn1.Name = "customerPhoneDataGridViewTextBoxColumn1";
            // 
            // customerAddressDataGridViewTextBoxColumn1
            // 
            this.customerAddressDataGridViewTextBoxColumn1.DataPropertyName = "Customer_Address";
            this.customerAddressDataGridViewTextBoxColumn1.HeaderText = "Customer_Address";
            this.customerAddressDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.customerAddressDataGridViewTextBoxColumn1.Name = "customerAddressDataGridViewTextBoxColumn1";
            // 
            // OrderStatus_comboBox
            // 
            this.OrderStatus_comboBox.FormattingEnabled = true;
            this.OrderStatus_comboBox.Items.AddRange(new object[] {
            "In Queue",
            "Delivering",
            "Deliverd"});
            this.OrderStatus_comboBox.Location = new System.Drawing.Point(607, 205);
            this.OrderStatus_comboBox.Name = "OrderStatus_comboBox";
            this.OrderStatus_comboBox.Size = new System.Drawing.Size(207, 30);
            this.OrderStatus_comboBox.TabIndex = 46;
            // 
            // date_dateTimePicker
            // 
            this.date_dateTimePicker.Location = new System.Drawing.Point(171, 173);
            this.date_dateTimePicker.Name = "date_dateTimePicker";
            this.date_dateTimePicker.Size = new System.Drawing.Size(207, 28);
            this.date_dateTimePicker.TabIndex = 45;
            // 
            // order_product_textbox
            // 
            this.order_product_textbox.Location = new System.Drawing.Point(171, 208);
            this.order_product_textbox.Name = "order_product_textbox";
            this.order_product_textbox.Size = new System.Drawing.Size(207, 28);
            this.order_product_textbox.TabIndex = 43;
            // 
            // ProductQTY_textbox
            // 
            this.ProductQTY_textbox.Location = new System.Drawing.Point(607, 134);
            this.ProductQTY_textbox.Name = "ProductQTY_textbox";
            this.ProductQTY_textbox.Size = new System.Drawing.Size(207, 28);
            this.ProductQTY_textbox.TabIndex = 42;
            // 
            // Co_Customer_textbox
            // 
            this.Co_Customer_textbox.Location = new System.Drawing.Point(607, 172);
            this.Co_Customer_textbox.Name = "Co_Customer_textbox";
            this.Co_Customer_textbox.Size = new System.Drawing.Size(207, 28);
            this.Co_Customer_textbox.TabIndex = 41;
            // 
            // orderid_textbox
            // 
            this.orderid_textbox.Location = new System.Drawing.Point(171, 137);
            this.orderid_textbox.Name = "orderid_textbox";
            this.orderid_textbox.Size = new System.Drawing.Size(207, 28);
            this.orderid_textbox.TabIndex = 40;
            // 
            // Addneworder_btn
            // 
            this.Addneworder_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Addneworder_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Addneworder_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Addneworder_btn.Location = new System.Drawing.Point(204, 300);
            this.Addneworder_btn.Name = "Addneworder_btn";
            this.Addneworder_btn.Size = new System.Drawing.Size(144, 42);
            this.Addneworder_btn.TabIndex = 28;
            this.Addneworder_btn.Text = "ADD";
            this.Addneworder_btn.UseVisualStyleBackColor = true;
            this.Addneworder_btn.Click += new System.EventHandler(this.Addneworder_btn_Click);
            // 
            // updateorder_btn
            // 
            this.updateorder_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.updateorder_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateorder_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.updateorder_btn.Location = new System.Drawing.Point(533, 300);
            this.updateorder_btn.Name = "updateorder_btn";
            this.updateorder_btn.Size = new System.Drawing.Size(144, 42);
            this.updateorder_btn.TabIndex = 21;
            this.updateorder_btn.Text = "Update";
            this.updateorder_btn.UseVisualStyleBackColor = true;
            this.updateorder_btn.Click += new System.EventHandler(this.updateorder_btn_Click);
            // 
            // deleteorder_btn
            // 
            this.deleteorder_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deleteorder_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteorder_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.deleteorder_btn.Location = new System.Drawing.Point(363, 300);
            this.deleteorder_btn.Name = "deleteorder_btn";
            this.deleteorder_btn.Size = new System.Drawing.Size(144, 42);
            this.deleteorder_btn.TabIndex = 18;
            this.deleteorder_btn.Text = "Delete";
            this.deleteorder_btn.UseVisualStyleBackColor = true;
            this.deleteorder_btn.Click += new System.EventHandler(this.deleteorder_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(102, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(384, 54);
            this.label9.TabIndex = 0;
            this.label9.Text = "Customers Order";
            // 
            // Search_publisher_textBox
            // 
            this.Search_publisher_textBox.Location = new System.Drawing.Point(521, 48);
            this.Search_publisher_textBox.Multiline = true;
            this.Search_publisher_textBox.Name = "Search_publisher_textBox";
            this.Search_publisher_textBox.Size = new System.Drawing.Size(256, 38);
            this.Search_publisher_textBox.TabIndex = 29;
            // 
            // Search_publisher_btn
            // 
            this.Search_publisher_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_publisher_btn.Image = ((System.Drawing.Image)(resources.GetObject("Search_publisher_btn.Image")));
            this.Search_publisher_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Search_publisher_btn.Location = new System.Drawing.Point(783, 48);
            this.Search_publisher_btn.Name = "Search_publisher_btn";
            this.Search_publisher_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Search_publisher_btn.Size = new System.Drawing.Size(40, 38);
            this.Search_publisher_btn.TabIndex = 30;
            this.Search_publisher_btn.TabStop = false;
            this.Search_publisher_btn.UseVisualStyleBackColor = true;
=======
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn5.HeaderText = "Category";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // product_codeLabel
            // 
            product_codeLabel.AutoSize = true;
            product_codeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            product_codeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            product_codeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            product_codeLabel.Location = new System.Drawing.Point(43, 139);
            product_codeLabel.Name = "product_codeLabel";
            product_codeLabel.Size = new System.Drawing.Size(162, 29);
            product_codeLabel.TabIndex = 2;
            product_codeLabel.Text = "Product code:";
            // 
            // product_nameLabel
            // 
            product_nameLabel.AutoSize = true;
            product_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            product_nameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            product_nameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            product_nameLabel.Location = new System.Drawing.Point(43, 180);
            product_nameLabel.Name = "product_nameLabel";
            product_nameLabel.Size = new System.Drawing.Size(168, 29);
            product_nameLabel.TabIndex = 4;
            product_nameLabel.Text = "Product name:";
            // 
            // product_priceLabel
            // 
            product_priceLabel.AutoSize = true;
            product_priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            product_priceLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            product_priceLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            product_priceLabel.Location = new System.Drawing.Point(43, 221);
            product_priceLabel.Name = "product_priceLabel";
            product_priceLabel.Size = new System.Drawing.Size(162, 29);
            product_priceLabel.TabIndex = 6;
            product_priceLabel.Text = "Product price:";
            // 
            // publisher_IDLabel
            // 
            publisher_IDLabel.AutoSize = true;
            publisher_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            publisher_IDLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            publisher_IDLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            publisher_IDLabel.Location = new System.Drawing.Point(462, 139);
            publisher_IDLabel.Name = "publisher_IDLabel";
            publisher_IDLabel.Size = new System.Drawing.Size(150, 29);
            publisher_IDLabel.TabIndex = 8;
            publisher_IDLabel.Text = "Publisher ID:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            categoryLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            categoryLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            categoryLabel.Location = new System.Drawing.Point(462, 181);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(116, 29);
            categoryLabel.TabIndex = 10;
            categoryLabel.Text = "Category:";
            // 
            // PRcode_textBox
            // 
            this.PRcode_textBox.Location = new System.Drawing.Point(217, 138);
            this.PRcode_textBox.Multiline = true;
            this.PRcode_textBox.Name = "PRcode_textBox";
            this.PRcode_textBox.Size = new System.Drawing.Size(195, 30);
            this.PRcode_textBox.TabIndex = 11;
            // 
            // PR_Publisherid_textBox
            // 
            this.PR_Publisherid_textBox.Location = new System.Drawing.Point(618, 138);
            this.PR_Publisherid_textBox.Multiline = true;
            this.PR_Publisherid_textBox.Name = "PR_Publisherid_textBox";
            this.PR_Publisherid_textBox.Size = new System.Drawing.Size(195, 30);
            this.PR_Publisherid_textBox.TabIndex = 13;
            // 
            // PR_price_textBox
            // 
            this.PR_price_textBox.Location = new System.Drawing.Point(217, 220);
            this.PR_price_textBox.Multiline = true;
            this.PR_price_textBox.Name = "PR_price_textBox";
            this.PR_price_textBox.Size = new System.Drawing.Size(195, 30);
            this.PR_price_textBox.TabIndex = 14;
            // 
            // PR_name_textBox
            // 
            this.PR_name_textBox.Location = new System.Drawing.Point(217, 179);
            this.PR_name_textBox.Multiline = true;
            this.PR_name_textBox.Name = "PR_name_textBox";
            this.PR_name_textBox.Size = new System.Drawing.Size(195, 30);
            this.PR_name_textBox.TabIndex = 15;
            // 
            // Category_comboBox
            // 
            this.Category_comboBox.FormattingEnabled = true;
            this.Category_comboBox.Items.AddRange(new object[] {
            "Game",
            "Console",
            "Accessories"});
            this.Category_comboBox.Location = new System.Drawing.Point(618, 180);
            this.Category_comboBox.Name = "Category_comboBox";
            this.Category_comboBox.Size = new System.Drawing.Size(195, 24);
            this.Category_comboBox.TabIndex = 16;
            // 
            // ADD_product_btn
            // 
            this.ADD_product_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ADD_product_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ADD_product_btn.Location = new System.Drawing.Point(126, 291);
            this.ADD_product_btn.Name = "ADD_product_btn";
            this.ADD_product_btn.Size = new System.Drawing.Size(144, 42);
            this.ADD_product_btn.TabIndex = 17;
            this.ADD_product_btn.Text = "ADD";
            this.ADD_product_btn.UseVisualStyleBackColor = true;
            this.ADD_product_btn.Click += new System.EventHandler(this.ADD_product_btn_Click);
            // 
            // Delete_product_btn
            // 
            this.Delete_product_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Delete_product_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Delete_product_btn.Location = new System.Drawing.Point(297, 291);
            this.Delete_product_btn.Name = "Delete_product_btn";
            this.Delete_product_btn.Size = new System.Drawing.Size(144, 42);
            this.Delete_product_btn.TabIndex = 18;
            this.Delete_product_btn.Text = "Delete";
            this.Delete_product_btn.UseVisualStyleBackColor = true;
            this.Delete_product_btn.Click += new System.EventHandler(this.Delete_product_btn_Click);
            // 
            // Update_product_btn
            // 
            this.Update_product_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Update_product_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Update_product_btn.Location = new System.Drawing.Point(467, 291);
            this.Update_product_btn.Name = "Update_product_btn";
            this.Update_product_btn.Size = new System.Drawing.Size(144, 42);
            this.Update_product_btn.TabIndex = 21;
            this.Update_product_btn.Text = "Update";
            this.Update_product_btn.UseVisualStyleBackColor = true;
            this.Update_product_btn.Click += new System.EventHandler(this.productBindingNavigatorSaveItem_Click);
            // 
            // Close_btn
            // 
            this.Close_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Close_btn.BackColor = System.Drawing.Color.White;
            this.Close_btn.FlatAppearance.BorderSize = 0;
            this.Close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.Close_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Close_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Close_btn.Location = new System.Drawing.Point(24, 542);
            this.Close_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(235, 56);
            this.Close_btn.TabIndex = 10;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseVisualStyleBackColor = false;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
>>>>>>> parent of 26607a0 (update2):Database_gamestore/GameStore/GameStore/Form1.Designer.cs
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
<<<<<<< HEAD:Database_gamestore/GameStore/GameStore/MainPage.Designer.cs
            this.ClientSize = new System.Drawing.Size(1243, 665);
            this.Controls.Add(this.Product_panel);
            this.Controls.Add(this.Publisher_panel);
            this.Controls.Add(this.Orders_panel);
            this.Controls.Add(this.Customer_panel);
=======
            this.ClientSize = new System.Drawing.Size(1222, 656);
            this.Controls.Add(this.Product_panel);
>>>>>>> parent of 26607a0 (update2):Database_gamestore/GameStore/GameStore/Form1.Designer.cs
            this.Controls.Add(this.Side_Panel);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Side_Panel.ResumeLayout(false);
<<<<<<< HEAD:Database_gamestore/GameStore/GameStore/MainPage.Designer.cs
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherDataGridView)).EndInit();
            this.Publisher_panel.ResumeLayout(false);
            this.Publisher_panel.PerformLayout();
            this.Customer_panel.ResumeLayout(false);
            this.Customer_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_OrderBindingSource)).EndInit();
            this.Product_panel.ResumeLayout(false);
            this.Product_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Orders_panel.ResumeLayout(false);
            this.Orders_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
=======
            this.Product_panel.ResumeLayout(false);
            this.Product_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
>>>>>>> parent of 26607a0 (update2):Database_gamestore/GameStore/GameStore/Form1.Designer.cs
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Side_Panel;
        private System.Windows.Forms.Button Customer_btn;
        private System.Windows.Forms.Button Publisher_btn;
        private System.Windows.Forms.Button order_btn;
        private System.Windows.Forms.Button product_btn;
        private System.Windows.Forms.Panel Product_panel;
        private System.Windows.Forms.Label label1;
        private GameStoreDataSet gameStoreDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private GameStoreDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private GameStoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
<<<<<<< HEAD:Database_gamestore/GameStore/GameStore/MainPage.Designer.cs
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.BindingSource publisherBindingSource;
        private GameStoreDataSetTableAdapters.PublisherTableAdapter publisherTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox publisherid_textbox;
        private System.Windows.Forms.TextBox publisheremail_textbox;
        private System.Windows.Forms.Button del_supplier_btn;
        private System.Windows.Forms.Button update_supplier_btn;
        private System.Windows.Forms.TextBox publishername_textBox;
        private System.Windows.Forms.DataGridView publisherDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Panel Publisher_panel;
        private System.Windows.Forms.Button Add_supplier_btn;
        private System.Windows.Forms.Panel Customer_panel;
        private System.Windows.Forms.Button Add_customer_btn;
        private System.Windows.Forms.TextBox Customer_phone_textBox;
        private System.Windows.Forms.Button Update_customere_btn;
        private System.Windows.Forms.Button del_customer_btn;
        private System.Windows.Forms.TextBox Customerid_textBox;
        private System.Windows.Forms.TextBox customer_Fname_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private GameStoreDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.TextBox Customer_address_textBox;
        private System.Windows.Forms.TextBox Customer_lname_textBox;
        private System.Windows.Forms.BindingSource customer_OrderBindingSource;
        private GameStoreDataSetTableAdapters.Customer_OrderTableAdapter customer_OrderTableAdapter;
        private System.Windows.Forms.Panel Product_panel;
        private System.Windows.Forms.ComboBox Category_comboBox;
        private System.Windows.Forms.TextBox prprice_textBox;
        private System.Windows.Forms.TextBox prpublisherid_textBox;
        private System.Windows.Forms.Button update_product_btn;
        private System.Windows.Forms.Button del_product_btn;
        private System.Windows.Forms.TextBox prcode_textBox;
        private System.Windows.Forms.TextBox prname_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Addproduct_btn;
        private System.Windows.Forms.Panel Orders_panel;
        private System.Windows.Forms.Button Addneworder_btn;
        private System.Windows.Forms.Button updateorder_btn;
        private System.Windows.Forms.Button deleteorder_btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker date_dateTimePicker;
        private System.Windows.Forms.TextBox order_product_textbox;
        private System.Windows.Forms.TextBox ProductQTY_textbox;
        private System.Windows.Forms.TextBox Co_Customer_textbox;
        private System.Windows.Forms.TextBox orderid_textbox;
        private System.Windows.Forms.ComboBox OrderStatus_comboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn productcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerLNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button Search_publisher_btn;
        private System.Windows.Forms.TextBox Search_publisher_textBox;
=======
        private System.Windows.Forms.Button Update_product_btn;
        private System.Windows.Forms.Button Delete_product_btn;
        private System.Windows.Forms.Button ADD_product_btn;
        private System.Windows.Forms.ComboBox Category_comboBox;
        private System.Windows.Forms.TextBox PR_name_textBox;
        private System.Windows.Forms.TextBox PR_price_textBox;
        private System.Windows.Forms.TextBox PR_Publisherid_textBox;
        private System.Windows.Forms.TextBox PRcode_textBox;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button Close_btn;
>>>>>>> parent of 26607a0 (update2):Database_gamestore/GameStore/GameStore/Form1.Designer.cs
    }
}

