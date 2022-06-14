namespace Prettybike
{
    partial class Pieces_builder
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
            this.piece1 = new System.Windows.Forms.Label();
            this.btn_Back_Builderhome = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.title1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // piece1
            // 
            this.piece1.AutoSize = true;
            this.piece1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.piece1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.piece1.Location = new System.Drawing.Point(299, 130);
            this.piece1.Name = "piece1";
            this.piece1.Size = new System.Drawing.Size(78, 32);
            this.piece1.TabIndex = 0;
            this.piece1.Text = "label1";
            this.piece1.Click += new System.EventHandler(this.Piece1_Click);
            // 
            // btn_Back_Builderhome
            // 
            this.btn_Back_Builderhome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Back_Builderhome.ForeColor = System.Drawing.Color.Salmon;
            this.btn_Back_Builderhome.Location = new System.Drawing.Point(30, 329);
            this.btn_Back_Builderhome.Name = "btn_Back_Builderhome";
            this.btn_Back_Builderhome.Size = new System.Drawing.Size(107, 56);
            this.btn_Back_Builderhome.TabIndex = 1;
            this.btn_Back_Builderhome.Text = "BACK";
            this.btn_Back_Builderhome.UseVisualStyleBackColor = true;
            this.btn_Back_Builderhome.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(299, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(299, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.Label1_Click_2);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(299, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(299, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            this.label5.Click += new System.EventHandler(this.Label1_Click_3);
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title1.Location = new System.Drawing.Point(195, 36);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(303, 67);
            this.title1.TabIndex = 6;
            this.title1.Text = "BIKES PARTS";
            this.title1.Click += new System.EventHandler(this.Label1_Click_4);
            // 
            // Pieces_builder
            // 
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(737, 406);
            this.Controls.Add(this.title1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Back_Builderhome);
            this.Controls.Add(this.piece1);
            this.Name = "Pieces_builder";
            this.Text = "Parts";
            this.Load += new System.EventHandler(this.Pieces_builder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private Button button1;
        public Label piece1;
        private Button btn_Back_Builderhome;
        public Label label2;
        public Label label3;
        public Label label4;
        public Label label5;
        private Label title1;
    }
}