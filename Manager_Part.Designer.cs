namespace Prettybike
{
    partial class Manager_Part
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
            this.lbl_finished = new System.Windows.Forms.Label();
            this.lbl_amt_left = new System.Windows.Forms.Label();
            this.btn_newOrder = new System.Windows.Forms.Button();
            this.lbl_order_review = new System.Windows.Forms.Label();
            this.lbl_ordercomfirm = new System.Windows.Forms.Label();
            this.lbl_From = new System.Windows.Forms.Label();
            this.dateTP_Manager_from = new System.Windows.Forms.DateTimePicker();
            this.lbl_ManagerName = new System.Windows.Forms.Label();
            this.txtbox_amount = new System.Windows.Forms.TextBox();
            this.combobox_Builders = new System.Windows.Forms.ComboBox();
            this.lbl_Manager = new System.Windows.Forms.Label();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.lbl_builder = new System.Windows.Forms.Label();
            this.lbl_orders = new System.Windows.Forms.Label();
            this.lbl_customer = new System.Windows.Forms.Label();
            this.lbl_representative = new System.Windows.Forms.Label();
            this.lbl_model = new System.Windows.Forms.Label();
            this.lbl_TotalAmount_Generate = new System.Windows.Forms.Label();
            this.lbl_Totalamount_display = new System.Windows.Forms.Label();
            this.lbl_orderdate = new System.Windows.Forms.Label();
            this.lbl_orderdate_display = new System.Windows.Forms.Label();
            this.lbl_size = new System.Windows.Forms.Label();
            this.lbl_color = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_amount_left_display = new System.Windows.Forms.Label();
            this.lbl_amount_left_generate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_finished
            // 
            this.lbl_finished.AutoSize = true;
            this.lbl_finished.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_finished.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_finished.Location = new System.Drawing.Point(565, 400);
            this.lbl_finished.Name = "lbl_finished";
            this.lbl_finished.Size = new System.Drawing.Size(0, 28);
            this.lbl_finished.TabIndex = 38;
            // 
            // lbl_amt_left
            // 
            this.lbl_amt_left.AutoSize = true;
            this.lbl_amt_left.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_amt_left.Location = new System.Drawing.Point(87, 129);
            this.lbl_amt_left.Name = "lbl_amt_left";
            this.lbl_amt_left.Size = new System.Drawing.Size(0, 25);
            this.lbl_amt_left.TabIndex = 37;
            // 
            // btn_newOrder
            // 
            this.btn_newOrder.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_newOrder.Location = new System.Drawing.Point(571, 313);
            this.btn_newOrder.Name = "btn_newOrder";
            this.btn_newOrder.Size = new System.Drawing.Size(203, 94);
            this.btn_newOrder.TabIndex = 36;
            this.btn_newOrder.Text = "Validate";
            this.btn_newOrder.UseVisualStyleBackColor = true;
            this.btn_newOrder.Click += new System.EventHandler(this.btn_newOrder_Click);
            // 
            // lbl_order_review
            // 
            this.lbl_order_review.AutoSize = true;
            this.lbl_order_review.Location = new System.Drawing.Point(172, 403);
            this.lbl_order_review.Name = "lbl_order_review";
            this.lbl_order_review.Size = new System.Drawing.Size(0, 25);
            this.lbl_order_review.TabIndex = 35;
            // 
            // lbl_ordercomfirm
            // 
            this.lbl_ordercomfirm.AutoSize = true;
            this.lbl_ordercomfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ordercomfirm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_ordercomfirm.Location = new System.Drawing.Point(605, 278);
            this.lbl_ordercomfirm.Name = "lbl_ordercomfirm";
            this.lbl_ordercomfirm.Size = new System.Drawing.Size(0, 32);
            this.lbl_ordercomfirm.TabIndex = 34;
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_From.Location = new System.Drawing.Point(172, 261);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(53, 25);
            this.lbl_From.TabIndex = 32;
            this.lbl_From.Text = "ON  :";
            // 
            // dateTP_Manager_from
            // 
            this.dateTP_Manager_from.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTP_Manager_from.CustomFormat = "dd-MM-yyyy";
            this.dateTP_Manager_from.Location = new System.Drawing.Point(115, 321);
            this.dateTP_Manager_from.Name = "dateTP_Manager_from";
            this.dateTP_Manager_from.Size = new System.Drawing.Size(300, 31);
            this.dateTP_Manager_from.TabIndex = 30;
            this.dateTP_Manager_from.ValueChanged += new System.EventHandler(this.dateTP_Manager_from_ValueChanged);
            // 
            // lbl_ManagerName
            // 
            this.lbl_ManagerName.AutoSize = true;
            this.lbl_ManagerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_ManagerName.Location = new System.Drawing.Point(345, 45);
            this.lbl_ManagerName.Name = "lbl_ManagerName";
            this.lbl_ManagerName.Size = new System.Drawing.Size(0, 32);
            this.lbl_ManagerName.TabIndex = 29;
            // 
            // txtbox_amount
            // 
            this.txtbox_amount.Location = new System.Drawing.Point(785, 132);
            this.txtbox_amount.Name = "txtbox_amount";
            this.txtbox_amount.Size = new System.Drawing.Size(77, 31);
            this.txtbox_amount.TabIndex = 27;
            this.txtbox_amount.TextChanged += new System.EventHandler(this.txtbox_amount_TextChanged);
            // 
            // combobox_Builders
            // 
            this.combobox_Builders.FormattingEnabled = true;
            this.combobox_Builders.Location = new System.Drawing.Point(506, 130);
            this.combobox_Builders.Name = "combobox_Builders";
            this.combobox_Builders.Size = new System.Drawing.Size(246, 33);
            this.combobox_Builders.TabIndex = 26;
            // 
            // lbl_Manager
            // 
            this.lbl_Manager.AutoSize = true;
            this.lbl_Manager.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Manager.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Manager.Location = new System.Drawing.Point(103, 22);
            this.lbl_Manager.Name = "lbl_Manager";
            this.lbl_Manager.Size = new System.Drawing.Size(200, 48);
            this.lbl_Manager.TabIndex = 24;
            this.lbl_Manager.Text = "Manager :";
            this.lbl_Manager.Click += new System.EventHandler(this.lbl_Manager_Click);
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Amount.Location = new System.Drawing.Point(785, 84);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(77, 25);
            this.lbl_Amount.TabIndex = 23;
            this.lbl_Amount.Text = "Amount";
            // 
            // lbl_builder
            // 
            this.lbl_builder.AutoSize = true;
            this.lbl_builder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_builder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_builder.Location = new System.Drawing.Point(588, 77);
            this.lbl_builder.Name = "lbl_builder";
            this.lbl_builder.Size = new System.Drawing.Size(101, 32);
            this.lbl_builder.TabIndex = 22;
            this.lbl_builder.Text = "Builders";
            // 
            // lbl_orders
            // 
            this.lbl_orders.AutoSize = true;
            this.lbl_orders.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_orders.Location = new System.Drawing.Point(189, 84);
            this.lbl_orders.Name = "lbl_orders";
            this.lbl_orders.Size = new System.Drawing.Size(121, 25);
            this.lbl_orders.TabIndex = 21;
            this.lbl_orders.Text = "Current Order";
            // 
            // lbl_customer
            // 
            this.lbl_customer.AutoSize = true;
            this.lbl_customer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_customer.Location = new System.Drawing.Point(39, 84);
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(102, 25);
            this.lbl_customer.TabIndex = 39;
            this.lbl_customer.Text = "Customer :";
            // 
            // lbl_representative
            // 
            this.lbl_representative.AutoSize = true;
            this.lbl_representative.Location = new System.Drawing.Point(51, 124);
            this.lbl_representative.Name = "lbl_representative";
            this.lbl_representative.Size = new System.Drawing.Size(0, 25);
            this.lbl_representative.TabIndex = 40;
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Location = new System.Drawing.Point(212, 138);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(0, 25);
            this.lbl_model.TabIndex = 41;
            this.lbl_model.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_TotalAmount_Generate
            // 
            this.lbl_TotalAmount_Generate.AutoSize = true;
            this.lbl_TotalAmount_Generate.Location = new System.Drawing.Point(938, 52);
            this.lbl_TotalAmount_Generate.Name = "lbl_TotalAmount_Generate";
            this.lbl_TotalAmount_Generate.Size = new System.Drawing.Size(0, 25);
            this.lbl_TotalAmount_Generate.TabIndex = 42;
            // 
            // lbl_Totalamount_display
            // 
            this.lbl_Totalamount_display.AutoSize = true;
            this.lbl_Totalamount_display.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Totalamount_display.Location = new System.Drawing.Point(894, 22);
            this.lbl_Totalamount_display.Name = "lbl_Totalamount_display";
            this.lbl_Totalamount_display.Size = new System.Drawing.Size(135, 28);
            this.lbl_Totalamount_display.TabIndex = 43;
            this.lbl_Totalamount_display.Text = "Total Amount";
            // 
            // lbl_orderdate
            // 
            this.lbl_orderdate.AutoSize = true;
            this.lbl_orderdate.Location = new System.Drawing.Point(661, 41);
            this.lbl_orderdate.Name = "lbl_orderdate";
            this.lbl_orderdate.Size = new System.Drawing.Size(0, 25);
            this.lbl_orderdate.TabIndex = 44;
            // 
            // lbl_orderdate_display
            // 
            this.lbl_orderdate_display.AutoSize = true;
            this.lbl_orderdate_display.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_orderdate_display.Location = new System.Drawing.Point(369, 41);
            this.lbl_orderdate_display.Name = "lbl_orderdate_display";
            this.lbl_orderdate_display.Size = new System.Drawing.Size(165, 25);
            this.lbl_orderdate_display.TabIndex = 45;
            this.lbl_orderdate_display.Text = "Date of the order :";
            // 
            // lbl_size
            // 
            this.lbl_size.AutoSize = true;
            this.lbl_size.Location = new System.Drawing.Point(396, 138);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(0, 25);
            this.lbl_size.TabIndex = 46;
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Location = new System.Drawing.Point(303, 138);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(0, 25);
            this.lbl_color.TabIndex = 47;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_back.Location = new System.Drawing.Point(172, 458);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(173, 109);
            this.btn_back.TabIndex = 48;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_amount_left_display
            // 
            this.lbl_amount_left_display.AutoSize = true;
            this.lbl_amount_left_display.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_amount_left_display.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_amount_left_display.Location = new System.Drawing.Point(897, 84);
            this.lbl_amount_left_display.Name = "lbl_amount_left_display";
            this.lbl_amount_left_display.Size = new System.Drawing.Size(133, 28);
            this.lbl_amount_left_display.TabIndex = 49;
            this.lbl_amount_left_display.Text = "Amount left :";
            // 
            // lbl_amount_left_generate
            // 
            this.lbl_amount_left_generate.AutoSize = true;
            this.lbl_amount_left_generate.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_amount_left_generate.Location = new System.Drawing.Point(949, 137);
            this.lbl_amount_left_generate.Name = "lbl_amount_left_generate";
            this.lbl_amount_left_generate.Size = new System.Drawing.Size(0, 25);
            this.lbl_amount_left_generate.TabIndex = 50;
            // 
            // Manager_Part
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1622, 956);
            this.Controls.Add(this.lbl_amount_left_generate);
            this.Controls.Add(this.lbl_amount_left_display);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_color);
            this.Controls.Add(this.lbl_size);
            this.Controls.Add(this.lbl_orderdate_display);
            this.Controls.Add(this.lbl_orderdate);
            this.Controls.Add(this.lbl_Totalamount_display);
            this.Controls.Add(this.lbl_TotalAmount_Generate);
            this.Controls.Add(this.lbl_model);
            this.Controls.Add(this.lbl_representative);
            this.Controls.Add(this.lbl_customer);
            this.Controls.Add(this.lbl_finished);
            this.Controls.Add(this.lbl_amt_left);
            this.Controls.Add(this.btn_newOrder);
            this.Controls.Add(this.lbl_order_review);
            this.Controls.Add(this.lbl_ordercomfirm);
            this.Controls.Add(this.lbl_From);
            this.Controls.Add(this.dateTP_Manager_from);
            this.Controls.Add(this.lbl_ManagerName);
            this.Controls.Add(this.txtbox_amount);
            this.Controls.Add(this.combobox_Builders);
            this.Controls.Add(this.lbl_Manager);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.lbl_builder);
            this.Controls.Add(this.lbl_orders);
            this.Name = "Manager_Part";
            this.Text = "Amount Left :";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_finished;
        public Label lbl_amt_left;
        private Button btn_newOrder;
        private Label lbl_order_review;
        private Label lbl_ordercomfirm;
        private Label lbl_From;
        public DateTimePicker dateTP_Manager_from;
        public Label lbl_ManagerName;
        private TextBox txtbox_amount;
        public ComboBox combobox_Builders;
        private Label lbl_Manager;
        private Label lbl_Amount;
        private Label lbl_builder;
        private Label lbl_orders;
        private Label lbl_customer;
        public Label lbl_representative;
        public Label lbl_model;
        public Label lbl_TotalAmount_Generate;
        private Label lbl_Totalamount_display;
        public Label lbl_orderdate;
        private Label lbl_orderdate_display;
        public Label lbl_size;
        public Label lbl_color;
        private Button btn_back;
        private Label lbl_amount_left_display;
        private Label lbl_amount_left_generate;
    }
}