namespace GradingSystem
{
    partial class FrmLogin
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
            this.LoginGbx = new System.Windows.Forms.GroupBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxLoginName = new System.Windows.Forms.ComboBox();
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblMsg = new System.Windows.Forms.Label();
            this.LoginGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginGbx
            // 
            this.LoginGbx.Controls.Add(this.lblMsg);
            this.LoginGbx.Controls.Add(this.btnLogIn);
            this.LoginGbx.Controls.Add(this.textBox1);
            this.LoginGbx.Controls.Add(this.label2);
            this.LoginGbx.Controls.Add(this.label1);
            this.LoginGbx.Controls.Add(this.cbxLoginName);
            this.LoginGbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginGbx.Location = new System.Drawing.Point(0, 0);
            this.LoginGbx.Name = "LoginGbx";
            this.LoginGbx.Size = new System.Drawing.Size(373, 179);
            this.LoginGbx.TabIndex = 0;
            this.LoginGbx.TabStop = false;
            this.LoginGbx.Text = "Login";
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(263, 138);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(105, 34);
            this.btnLogIn.TabIndex = 5;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 96);
            this.textBox1.MaxLength = 14;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login Name";
            // 
            // cbxLoginName
            // 
            this.cbxLoginName.DisplayMember = "Username";
            this.cbxLoginName.FormattingEnabled = true;
            this.cbxLoginName.Location = new System.Drawing.Point(145, 46);
            this.cbxLoginName.Name = "cbxLoginName";
            this.cbxLoginName.Size = new System.Drawing.Size(121, 21);
            this.cbxLoginName.TabIndex = 0;
            this.cbxLoginName.ValueMember = "Professor_id";
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataSource = typeof(GradingSystem.Professor);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(7, 160);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(152, 13);
            this.lblMsg.TabIndex = 6;
            this.lblMsg.Text = "Invalid Username or Password";
            this.lblMsg.Visible = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 179);
            this.Controls.Add(this.LoginGbx);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.LoginGbx.ResumeLayout(false);
            this.LoginGbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LoginGbx;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxLoginName;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.BindingSource professorBindingSource;
        private System.Windows.Forms.Label lblMsg;
    }
}