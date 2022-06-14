namespace Prettybike
{
    partial class Login
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
            this.lbl_Connection = new System.Windows.Forms.Label();
            this.btn_login_manager = new System.Windows.Forms.Button();
            this.lbl_Identif = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_login_builder = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Connection
            // 
            this.lbl_Connection.AutoSize = true;
            this.lbl_Connection.Location = new System.Drawing.Point(619, 252);
            this.lbl_Connection.Name = "lbl_Connection";
            this.lbl_Connection.Size = new System.Drawing.Size(0, 25);
            this.lbl_Connection.TabIndex = 14;
            // 
            // btn_login_manager
            // 
            this.btn_login_manager.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_login_manager.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_login_manager.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_login_manager.Location = new System.Drawing.Point(151, 252);
            this.btn_login_manager.Name = "btn_login_manager";
            this.btn_login_manager.Size = new System.Drawing.Size(111, 47);
            this.btn_login_manager.TabIndex = 9;
            this.btn_login_manager.Text = "LOG IN";
            this.btn_login_manager.UseVisualStyleBackColor = false;
            this.btn_login_manager.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_Identif
            // 
            this.lbl_Identif.AutoSize = true;
            this.lbl_Identif.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Identif.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Identif.Location = new System.Drawing.Point(151, 57);
            this.lbl_Identif.Name = "lbl_Identif";
            this.lbl_Identif.Size = new System.Drawing.Size(497, 96);
            this.lbl_Identif.TabIndex = 8;
            this.lbl_Identif.Text = "Identification";
            this.lbl_Identif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Identif.Click += new System.EventHandler(this.lbl_Identif_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(146, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Manager";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(501, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Builder";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_login_builder
            // 
            this.btn_login_builder.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_login_builder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_login_builder.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_login_builder.Location = new System.Drawing.Point(501, 252);
            this.btn_login_builder.Name = "btn_login_builder";
            this.btn_login_builder.Size = new System.Drawing.Size(111, 47);
            this.btn_login_builder.TabIndex = 17;
            this.btn_login_builder.Text = "LOG IN";
            this.btn_login_builder.UseVisualStyleBackColor = false;
            this.btn_login_builder.Click += new System.EventHandler(this.btn_login_builder_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(477, 211);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 33);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_back.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_back.Location = new System.Drawing.Point(43, 355);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(112, 50);
            this.btn_back.TabIndex = 19;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_login_builder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Connection);
            this.Controls.Add(this.btn_login_manager);
            this.Controls.Add(this.lbl_Identif);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Connection;
        private Button btn_login_manager;
        private Label lbl_Identif;
        private Label label1;
        private Label label2;
        private Button btn_login_builder;
        public ComboBox comboBox1;
        private EventHandler comboBox1_SelectedIndexChanged;
        private Button btn_back;
    }
}