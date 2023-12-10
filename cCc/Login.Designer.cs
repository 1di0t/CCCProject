namespace cCc
{
    partial class Login
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.login_design = new System.Windows.Forms.Panel();
            this.login_logo = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.loginlogo2 = new System.Windows.Forms.Label();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.login_panel = new System.Windows.Forms.Panel();
            this.sgu_bt = new System.Windows.Forms.Button();
            this.sgi_bt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pw_textbox = new System.Windows.Forms.TextBox();
            this.login_design.SuspendLayout();
            this.login_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_design
            // 
            this.login_design.BackColor = System.Drawing.Color.Bisque;
            this.login_design.Controls.Add(this.login_logo);
            this.login_design.Controls.Add(this.exit);
            this.login_design.Dock = System.Windows.Forms.DockStyle.Top;
            this.login_design.Location = new System.Drawing.Point(0, 0);
            this.login_design.Name = "login_design";
            this.login_design.Size = new System.Drawing.Size(750, 56);
            this.login_design.TabIndex = 0;
            // 
            // login_logo
            // 
            this.login_logo.AutoSize = true;
            this.login_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_logo.Location = new System.Drawing.Point(8, 4);
            this.login_logo.Name = "login_logo";
            this.login_logo.Size = new System.Drawing.Size(94, 46);
            this.login_logo.TabIndex = 1;
            this.login_logo.Text = "cCc";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Bisque;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.Bisque;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(691, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(59, 56);
            this.exit.TabIndex = 1;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Exit_bt);
            // 
            // loginlogo2
            // 
            this.loginlogo2.AutoSize = true;
            this.loginlogo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlogo2.Location = new System.Drawing.Point(160, 55);
            this.loginlogo2.Name = "loginlogo2";
            this.loginlogo2.Size = new System.Drawing.Size(136, 69);
            this.loginlogo2.TabIndex = 1;
            this.loginlogo2.Text = "cCc";
            // 
            // id_textbox
            // 
            this.id_textbox.Location = new System.Drawing.Point(81, 200);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(285, 26);
            this.id_textbox.TabIndex = 2;
            this.id_textbox.TextChanged += new System.EventHandler(this.id_textbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(76, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // login_panel
            // 
            this.login_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_panel.Controls.Add(this.sgu_bt);
            this.login_panel.Controls.Add(this.sgi_bt);
            this.login_panel.Controls.Add(this.label3);
            this.login_panel.Controls.Add(this.label4);
            this.login_panel.Controls.Add(this.label2);
            this.login_panel.Controls.Add(this.pw_textbox);
            this.login_panel.Controls.Add(this.id_textbox);
            this.login_panel.Controls.Add(this.loginlogo2);
            this.login_panel.Location = new System.Drawing.Point(150, 100);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(450, 500);
            this.login_panel.TabIndex = 4;
            // 
            // sgu_bt
            // 
            this.sgu_bt.BackColor = System.Drawing.Color.Bisque;
            this.sgu_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sgu_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sgu_bt.Location = new System.Drawing.Point(230, 380);
            this.sgu_bt.Name = "sgu_bt";
            this.sgu_bt.Size = new System.Drawing.Size(135, 48);
            this.sgu_bt.TabIndex = 4;
            this.sgu_bt.Text = "회원가입";
            this.sgu_bt.UseVisualStyleBackColor = false;
            this.sgu_bt.Click += new System.EventHandler(this.SignUp_bt);
            // 
            // sgi_bt
            // 
            this.sgi_bt.BackColor = System.Drawing.Color.Bisque;
            this.sgi_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sgi_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sgi_bt.Location = new System.Drawing.Point(80, 380);
            this.sgi_bt.Name = "sgi_bt";
            this.sgi_bt.Size = new System.Drawing.Size(135, 48);
            this.sgi_bt.TabIndex = 4;
            this.sgi_bt.Text = "로그인";
            this.sgi_bt.UseVisualStyleBackColor = false;
            this.sgi_bt.Click += new System.EventHandler(this.Login_bt);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(50, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(75, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "PW";
            // 
            // pw_textbox
            // 
            this.pw_textbox.Location = new System.Drawing.Point(80, 290);
            this.pw_textbox.Name = "pw_textbox";
            this.pw_textbox.PasswordChar = '*';
            this.pw_textbox.Size = new System.Drawing.Size(285, 26);
            this.pw_textbox.TabIndex = 2;
            this.pw_textbox.TextChanged += new System.EventHandler(this.pw_textbox_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 650);
            this.Controls.Add(this.login_panel);
            this.Controls.Add(this.login_design);
            this.Font = new System.Drawing.Font("굴림", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            this.login_design.ResumeLayout(false);
            this.login_design.PerformLayout();
            this.login_panel.ResumeLayout(false);
            this.login_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel login_design;
        private System.Windows.Forms.Label loginlogo2;
        private System.Windows.Forms.Label login_logo;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel login_panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pw_textbox;
        private System.Windows.Forms.Button sgi_bt;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button sgu_bt;
    }
}

