namespace WebShop_
{
    partial class xgmm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xgmm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_editCheck = new System.Windows.Forms.Button();
            this.btn_editBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WebShop_.Properties.Resources.editText;
            this.pictureBox1.Location = new System.Drawing.Point(70, -23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 92);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::WebShop_.Properties.Resources.edit_01;
            this.pictureBox2.Location = new System.Drawing.Point(34, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 189);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 21);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(159, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 21);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(159, 187);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(123, 21);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(159, 243);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(123, 21);
            this.textBox4.TabIndex = 5;
            // 
            // btn_editCheck
            // 
            this.btn_editCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_editCheck.BackgroundImage")));
            this.btn_editCheck.FlatAppearance.BorderSize = 0;
            this.btn_editCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editCheck.Location = new System.Drawing.Point(32, 278);
            this.btn_editCheck.Name = "btn_editCheck";
            this.btn_editCheck.Size = new System.Drawing.Size(121, 50);
            this.btn_editCheck.TabIndex = 17;
            this.btn_editCheck.UseVisualStyleBackColor = true;
            // 
            // btn_editBack
            // 
            this.btn_editBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_editBack.BackgroundImage")));
            this.btn_editBack.FlatAppearance.BorderSize = 0;
            this.btn_editBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editBack.Location = new System.Drawing.Point(172, 277);
            this.btn_editBack.Name = "btn_editBack";
            this.btn_editBack.Size = new System.Drawing.Size(123, 53);
            this.btn_editBack.TabIndex = 18;
            this.btn_editBack.UseVisualStyleBackColor = true;
            // 
            // xgmm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WebShop_.Properties.Resources.backgroud;
            this.ClientSize = new System.Drawing.Size(331, 340);
            this.Controls.Add(this.btn_editBack);
            this.Controls.Add(this.btn_editCheck);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "xgmm";
            this.Text = "信息修改";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_editCheck;
        private System.Windows.Forms.Button btn_editBack;
    }
}