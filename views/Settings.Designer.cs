namespace tatoo_CRM.views
{
    partial class Settings
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
            this.nud_price_one_hoer = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_bonus = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_dop_ = new System.Windows.Forms.NumericUpDown();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_price_one_hoer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_bonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dop_)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_price_one_hoer
            // 
            this.nud_price_one_hoer.Location = new System.Drawing.Point(180, 45);
            this.nud_price_one_hoer.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_price_one_hoer.Name = "nud_price_one_hoer";
            this.nud_price_one_hoer.Size = new System.Drawing.Size(85, 20);
            this.nud_price_one_hoer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Стоимость 1 часа работы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Бонус на расходники";
            // 
            // nud_bonus
            // 
            this.nud_bonus.Location = new System.Drawing.Point(180, 76);
            this.nud_bonus.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_bonus.Name = "nud_bonus";
            this.nud_bonus.Size = new System.Drawing.Size(85, 20);
            this.nud_bonus.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Доп расходы";
            // 
            // nud_dop_
            // 
            this.nud_dop_.Location = new System.Drawing.Point(180, 105);
            this.nud_dop_.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_dop_.Name = "nud_dop_";
            this.nud_dop_.Size = new System.Drawing.Size(85, 20);
            this.nud_dop_.TabIndex = 5;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(180, 151);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 196);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.nud_dop_);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nud_bonus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_price_one_hoer);
            this.Name = "Settings";
            this.Text = "Настройки";
            ((System.ComponentModel.ISupportInitialize)(this.nud_price_one_hoer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_bonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dop_)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_price_one_hoer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_bonus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_dop_;
        private System.Windows.Forms.Button btn_save;
    }
}