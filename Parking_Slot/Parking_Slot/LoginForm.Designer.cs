
namespace Parking_Slot
{
    partial class LoginForm
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
            this.login_lb = new System.Windows.Forms.Label();
            this.user_name_lb = new System.Windows.Forms.Label();
            this.pw_lb = new System.Windows.Forms.Label();
            this.user_name_tb = new System.Windows.Forms.TextBox();
            this.pw_tb = new System.Windows.Forms.TextBox();
            this.sign_in_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_lb
            // 
            this.login_lb.AutoSize = true;
            this.login_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_lb.Location = new System.Drawing.Point(355, 51);
            this.login_lb.Name = "login_lb";
            this.login_lb.Size = new System.Drawing.Size(90, 36);
            this.login_lb.TabIndex = 0;
            this.login_lb.Text = "Login";
            // 
            // user_name_lb
            // 
            this.user_name_lb.AutoSize = true;
            this.user_name_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name_lb.Location = new System.Drawing.Point(48, 126);
            this.user_name_lb.Name = "user_name_lb";
            this.user_name_lb.Size = new System.Drawing.Size(130, 29);
            this.user_name_lb.TabIndex = 1;
            this.user_name_lb.Text = "User name";
            // 
            // pw_lb
            // 
            this.pw_lb.AutoSize = true;
            this.pw_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pw_lb.Location = new System.Drawing.Point(48, 232);
            this.pw_lb.Name = "pw_lb";
            this.pw_lb.Size = new System.Drawing.Size(120, 29);
            this.pw_lb.TabIndex = 2;
            this.pw_lb.Text = "Password";
            // 
            // user_name_tb
            // 
            this.user_name_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name_tb.Location = new System.Drawing.Point(184, 119);
            this.user_name_tb.Name = "user_name_tb";
            this.user_name_tb.Size = new System.Drawing.Size(478, 35);
            this.user_name_tb.TabIndex = 3;
            this.user_name_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.user_name_tb_KeyDown);
            // 
            // pw_tb
            // 
            this.pw_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pw_tb.Location = new System.Drawing.Point(184, 225);
            this.pw_tb.Name = "pw_tb";
            this.pw_tb.Size = new System.Drawing.Size(478, 35);
            this.pw_tb.TabIndex = 4;
            this.pw_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pw_tb_KeyDown);
            // 
            // sign_in_bt
            // 
            this.sign_in_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_in_bt.Location = new System.Drawing.Point(313, 318);
            this.sign_in_bt.Name = "sign_in_bt";
            this.sign_in_bt.Size = new System.Drawing.Size(168, 50);
            this.sign_in_bt.TabIndex = 5;
            this.sign_in_bt.Text = "SIGN IN";
            this.sign_in_bt.UseVisualStyleBackColor = true;
            this.sign_in_bt.Click += new System.EventHandler(this.sign_in_bt_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sign_in_bt);
            this.Controls.Add(this.pw_tb);
            this.Controls.Add(this.user_name_tb);
            this.Controls.Add(this.pw_lb);
            this.Controls.Add(this.user_name_lb);
            this.Controls.Add(this.login_lb);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_lb;
        private System.Windows.Forms.Label user_name_lb;
        private System.Windows.Forms.Label pw_lb;
        private System.Windows.Forms.TextBox user_name_tb;
        private System.Windows.Forms.TextBox pw_tb;
        private System.Windows.Forms.Button sign_in_bt;
    }
}

