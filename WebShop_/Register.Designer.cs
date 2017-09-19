namespace WebShop_
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_nameR = new System.Windows.Forms.TextBox();
            this.tb_pwd1R = new System.Windows.Forms.TextBox();
            this.tb_pwd2R = new System.Windows.Forms.TextBox();
            this.btn_registerCheck = new System.Windows.Forms.Button();
            this.btn_registerBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(79, -9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 80);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WebShop_.Properties.Resources.register_5;
            this.pictureBox1.Location = new System.Drawing.Point(36, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 135);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // tb_nameR
            // 
            this.tb_nameR.Location = new System.Drawing.Point(171, 92);
            this.tb_nameR.Name = "tb_nameR";
            this.tb_nameR.Size = new System.Drawing.Size(132, 21);
            this.tb_nameR.TabIndex = 13;
            // 
            // tb_pwd1R
            // 
            this.tb_pwd1R.Location = new System.Drawing.Point(171, 138);
            this.tb_pwd1R.Name = "tb_pwd1R";
            this.tb_pwd1R.PasswordChar = '*';
            this.tb_pwd1R.Size = new System.Drawing.Size(132, 21);
            this.tb_pwd1R.TabIndex = 14;
            // 
            // tb_pwd2R
            // 
            this.tb_pwd2R.Location = new System.Drawing.Point(171, 187);
            this.tb_pwd2R.Name = "tb_pwd2R";
            this.tb_pwd2R.PasswordChar = '*';
            this.tb_pwd2R.Size = new System.Drawing.Size(132, 21);
            this.tb_pwd2R.TabIndex = 15;
            // 
            // btn_registerCheck
            // 
            this.btn_registerCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_registerCheck.BackgroundImage")));
            this.btn_registerCheck.FlatAppearance.BorderSize = 0;
            this.btn_registerCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registerCheck.Location = new System.Drawing.Point(36, 218);
            this.btn_registerCheck.Name = "btn_registerCheck";
            this.btn_registerCheck.Size = new System.Drawing.Size(121, 50);
            this.btn_registerCheck.TabIndex = 16;
            this.btn_registerCheck.UseVisualStyleBackColor = true;
            this.btn_registerCheck.Click += new System.EventHandler(this.btn_registerCheck_Click);
            this.btn_registerCheck.MouseEnter += new System.EventHandler(this.btn_registerCheck_MouseEnter);
            this.btn_registerCheck.MouseLeave += new System.EventHandler(this.btn_registerCheck_MouseLeave);
            // 
            // btn_registerBack
            // 
            this.btn_registerBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_registerBack.BackgroundImage")));
            this.btn_registerBack.FlatAppearance.BorderSize = 0;
            this.btn_registerBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registerBack.Location = new System.Drawing.Point(180, 217);
            this.btn_registerBack.Name = "btn_registerBack";
            this.btn_registerBack.Size = new System.Drawing.Size(123, 53);
            this.btn_registerBack.TabIndex = 17;
            this.btn_registerBack.UseVisualStyleBackColor = true;
            this.btn_registerBack.MouseEnter += new System.EventHandler(this.btn_registerBack_MouseEnter);
            this.btn_registerBack.MouseLeave += new System.EventHandler(this.btn_registerBack_MouseLeave);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WebShop_.Properties.Resources.backgroud;
            this.ClientSize = new System.Drawing.Size(344, 293);
            this.Controls.Add(this.btn_registerBack);
            this.Controls.Add(this.btn_registerCheck);
            this.Controls.Add(this.tb_pwd2R);
            this.Controls.Add(this.tb_pwd1R);
            this.Controls.Add(this.tb_nameR);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_nameR;
        private System.Windows.Forms.TextBox tb_pwd1R;
        private System.Windows.Forms.TextBox tb_pwd2R;
        private System.Windows.Forms.Button btn_registerCheck;
        private System.Windows.Forms.Button btn_registerBack;
    }
}