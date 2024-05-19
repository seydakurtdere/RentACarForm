namespace RentACarForm
{
    partial class Login_Form
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
            this.tbx_userName = new System.Windows.Forms.TextBox();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_userName
            // 
            this.tbx_userName.Location = new System.Drawing.Point(198, 119);
            this.tbx_userName.Name = "tbx_userName";
            this.tbx_userName.Size = new System.Drawing.Size(192, 20);
            this.tbx_userName.TabIndex = 0;
            this.tbx_userName.TextChanged += new System.EventHandler(this.tbx_userName_TextChanged);
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new System.Drawing.Point(198, 199);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.PasswordChar = '*';
            this.tbx_password.Size = new System.Drawing.Size(192, 20);
            this.tbx_password.TabIndex = 1;
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(225, 268);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(114, 44);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Log In";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(619, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.tbx_userName);
            this.Name = "Login_Form";
            this.Text = "Giriş Formu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_userName;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}