
namespace MyWinform01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TXTIN_ID = new System.Windows.Forms.TextBox();
            this.TXTIN_PW = new System.Windows.Forms.TextBox();
            this.BT_LOGIN = new System.Windows.Forms.Button();
            this.BT_CK_IDPW = new System.Windows.Forms.Button();
            this.BT_REGISTER = new System.Windows.Forms.Button();
            this.TXT_PW = new System.Windows.Forms.Label();
            this.TXT_ID = new System.Windows.Forms.Label();
            this.TXT_TITLE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXTIN_ID
            // 
            this.TXTIN_ID.Location = new System.Drawing.Point(311, 175);
            this.TXTIN_ID.Name = "TXTIN_ID";
            this.TXTIN_ID.Size = new System.Drawing.Size(125, 27);
            this.TXTIN_ID.TabIndex = 1;
            this.TXTIN_ID.TextChanged += new System.EventHandler(this.TXTIN_ID_TextChanged);
            // 
            // TXTIN_PW
            // 
            this.TXTIN_PW.Location = new System.Drawing.Point(311, 208);
            this.TXTIN_PW.Name = "TXTIN_PW";
            this.TXTIN_PW.Size = new System.Drawing.Size(125, 27);
            this.TXTIN_PW.TabIndex = 2;
            this.TXTIN_PW.TextChanged += new System.EventHandler(this.TXTIN_PW_TextChanged);
            // 
            // BT_LOGIN
            // 
            this.BT_LOGIN.Location = new System.Drawing.Point(442, 175);
            this.BT_LOGIN.Name = "BT_LOGIN";
            this.BT_LOGIN.Size = new System.Drawing.Size(94, 62);
            this.BT_LOGIN.TabIndex = 3;
            this.BT_LOGIN.Text = "Login";
            this.BT_LOGIN.UseVisualStyleBackColor = true;
            this.BT_LOGIN.Click += new System.EventHandler(this.BT_LOGIN_Click);
            // 
            // BT_CK_IDPW
            // 
            this.BT_CK_IDPW.Location = new System.Drawing.Point(311, 251);
            this.BT_CK_IDPW.Name = "BT_CK_IDPW";
            this.BT_CK_IDPW.Size = new System.Drawing.Size(94, 29);
            this.BT_CK_IDPW.TabIndex = 4;
            this.BT_CK_IDPW.Text = "Find_ID/PW";
            this.BT_CK_IDPW.UseVisualStyleBackColor = true;
            // 
            // BT_REGISTER
            // 
            this.BT_REGISTER.Location = new System.Drawing.Point(442, 251);
            this.BT_REGISTER.Name = "BT_REGISTER";
            this.BT_REGISTER.Size = new System.Drawing.Size(94, 29);
            this.BT_REGISTER.TabIndex = 5;
            this.BT_REGISTER.Text = "Register";
            this.BT_REGISTER.UseVisualStyleBackColor = true;
            // 
            // TXT_PW
            // 
            this.TXT_PW.AutoSize = true;
            this.TXT_PW.Location = new System.Drawing.Point(233, 212);
            this.TXT_PW.Name = "TXT_PW";
            this.TXT_PW.Size = new System.Drawing.Size(72, 20);
            this.TXT_PW.TabIndex = 6;
            this.TXT_PW.Text = "password";
            this.TXT_PW.Click += new System.EventHandler(this.label1_Click);
            // 
            // TXT_ID
            // 
            this.TXT_ID.AutoSize = true;
            this.TXT_ID.Location = new System.Drawing.Point(256, 178);
            this.TXT_ID.Name = "TXT_ID";
            this.TXT_ID.Size = new System.Drawing.Size(24, 20);
            this.TXT_ID.TabIndex = 7;
            this.TXT_ID.Text = "ID";
            this.TXT_ID.Click += new System.EventHandler(this.label2_Click);
            // 
            // TXT_TITLE
            // 
            this.TXT_TITLE.AutoSize = true;
            this.TXT_TITLE.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXT_TITLE.Location = new System.Drawing.Point(335, 114);
            this.TXT_TITLE.Name = "TXT_TITLE";
            this.TXT_TITLE.Size = new System.Drawing.Size(122, 46);
            this.TXT_TITLE.TabIndex = 8;
            this.TXT_TITLE.Text = "로그인";
            this.TXT_TITLE.Click += new System.EventHandler(this.TXT_TITLE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TXT_TITLE);
            this.Controls.Add(this.TXT_ID);
            this.Controls.Add(this.TXT_PW);
            this.Controls.Add(this.BT_REGISTER);
            this.Controls.Add(this.BT_CK_IDPW);
            this.Controls.Add(this.BT_LOGIN);
            this.Controls.Add(this.TXTIN_PW);
            this.Controls.Add(this.TXTIN_ID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TXTIN_ID;
        private System.Windows.Forms.TextBox TXTIN_PW;
        private System.Windows.Forms.Button BT_LOGIN;
        private System.Windows.Forms.Button BT_CK_IDPW;
        private System.Windows.Forms.Button BT_REGISTER;
        private System.Windows.Forms.Label TXT_PW;
        private System.Windows.Forms.Label TXT_ID;
        private System.Windows.Forms.Label TXT_TITLE;
    }
}

