namespace Prettybike
{
    partial class Builder_home
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
            this.btn_piecies = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_Builder = new System.Windows.Forms.Label();
            this.btn_backlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_piecies
            // 
            this.btn_piecies.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_piecies.ForeColor = System.Drawing.Color.Salmon;
            this.btn_piecies.Location = new System.Drawing.Point(607, 83);
            this.btn_piecies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_piecies.Name = "btn_piecies";
            this.btn_piecies.Size = new System.Drawing.Size(161, 60);
            this.btn_piecies.TabIndex = 9;
            this.btn_piecies.Text = "Show parts";
            this.btn_piecies.UseVisualStyleBackColor = true;
            this.btn_piecies.Click += new System.EventHandler(this.btn_piecies_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkedListBox1.ForeColor = System.Drawing.Color.Salmon;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(199, 83);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(380, 256);
            this.checkedListBox1.TabIndex = 8;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_title.Location = new System.Drawing.Point(199, -2);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(409, 81);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "TO DO TODAY";
            this.lbl_title.Click += new System.EventHandler(this.lbl_title_Click);
            // 
            // lbl_Builder
            // 
            this.lbl_Builder.AutoSize = true;
            this.lbl_Builder.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Builder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Builder.Location = new System.Drawing.Point(13, 8);
            this.lbl_Builder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Builder.Name = "lbl_Builder";
            this.lbl_Builder.Size = new System.Drawing.Size(136, 41);
            this.lbl_Builder.TabIndex = 6;
            this.lbl_Builder.Text = "Builder :";
            this.lbl_Builder.Click += new System.EventHandler(this.lbl_Builder_Click);
            // 
            // btn_backlogin
            // 
            this.btn_backlogin.ForeColor = System.Drawing.Color.Salmon;
            this.btn_backlogin.Location = new System.Drawing.Point(17, 370);
            this.btn_backlogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_backlogin.Name = "btn_backlogin";
            this.btn_backlogin.Size = new System.Drawing.Size(121, 60);
            this.btn_backlogin.TabIndex = 10;
            this.btn_backlogin.Text = "BACK";
            this.btn_backlogin.UseVisualStyleBackColor = true;
            this.btn_backlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // Builder_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_backlogin);
            this.Controls.Add(this.btn_piecies);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_Builder);
            this.Name = "Builder_home";
            this.Text = "Builder Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_piecies;
        public CheckedListBox checkedListBox1;
        private Label lbl_title;
        public Label lbl_Builder;
        private Button btn_backlogin;
    }
}