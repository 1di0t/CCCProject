
namespace cCc
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.Logo1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitBt = new System.Windows.Forms.Button();
            this.text_repw = new System.Windows.Forms.Panel();
            this.overlapcheck = new System.Windows.Forms.Button();
            this.text_rpw = new System.Windows.Forms.Label();
            this.RPwBox = new System.Windows.Forms.TextBox();
            this.text_pw = new System.Windows.Forms.Label();
            this.PwBox = new System.Windows.Forms.TextBox();
            this.SignUpBt = new System.Windows.Forms.Button();
            this.text_email = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.drive_type_combo = new System.Windows.Forms.ComboBox();
            this.fuel_type_combo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.text_repw.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo1
            // 
            this.Logo1.AutoSize = true;
            this.Logo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.Logo1.Location = new System.Drawing.Point(8, 4);
            this.Logo1.Name = "Logo1";
            this.Logo1.Size = new System.Drawing.Size(94, 46);
            this.Logo1.TabIndex = 1;
            this.Logo1.Text = "cCc";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.ExitBt);
            this.panel1.Controls.Add(this.Logo1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 56);
            this.panel1.TabIndex = 5;
            // 
            // ExitBt
            // 
            this.ExitBt.BackColor = System.Drawing.Color.Bisque;
            this.ExitBt.FlatAppearance.BorderColor = System.Drawing.Color.Bisque;
            this.ExitBt.FlatAppearance.BorderSize = 0;
            this.ExitBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.ExitBt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.ExitBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBt.Image = ((System.Drawing.Image)(resources.GetObject("ExitBt.Image")));
            this.ExitBt.Location = new System.Drawing.Point(641, 0);
            this.ExitBt.Name = "ExitBt";
            this.ExitBt.Size = new System.Drawing.Size(59, 56);
            this.ExitBt.TabIndex = 2;
            this.ExitBt.UseVisualStyleBackColor = false;
            this.ExitBt.Click += new System.EventHandler(this.Exit_bt);
            // 
            // text_repw
            // 
            this.text_repw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_repw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_repw.Controls.Add(this.fuel_type_combo);
            this.text_repw.Controls.Add(this.drive_type_combo);
            this.text_repw.Controls.Add(this.label3);
            this.text_repw.Controls.Add(this.label2);
            this.text_repw.Controls.Add(this.name_textBox);
            this.text_repw.Controls.Add(this.label1);
            this.text_repw.Controls.Add(this.overlapcheck);
            this.text_repw.Controls.Add(this.text_rpw);
            this.text_repw.Controls.Add(this.RPwBox);
            this.text_repw.Controls.Add(this.text_pw);
            this.text_repw.Controls.Add(this.PwBox);
            this.text_repw.Controls.Add(this.SignUpBt);
            this.text_repw.Controls.Add(this.text_email);
            this.text_repw.Controls.Add(this.text_id);
            this.text_repw.Controls.Add(this.EmailBox);
            this.text_repw.Controls.Add(this.IdBox);
            this.text_repw.Location = new System.Drawing.Point(115, 81);
            this.text_repw.Name = "text_repw";
            this.text_repw.Size = new System.Drawing.Size(486, 423);
            this.text_repw.TabIndex = 6;
            // 
            // overlapcheck
            // 
            this.overlapcheck.BackColor = System.Drawing.Color.Bisque;
            this.overlapcheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.overlapcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.overlapcheck.Location = new System.Drawing.Point(393, 39);
            this.overlapcheck.Name = "overlapcheck";
            this.overlapcheck.Size = new System.Drawing.Size(65, 21);
            this.overlapcheck.TabIndex = 9;
            this.overlapcheck.Text = "중복확인";
            this.overlapcheck.UseVisualStyleBackColor = false;
            this.overlapcheck.Click += new System.EventHandler(this.overlapcheck_Click);
            // 
            // text_rpw
            // 
            this.text_rpw.AutoSize = true;
            this.text_rpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_rpw.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.text_rpw.Location = new System.Drawing.Point(98, 167);
            this.text_rpw.Name = "text_rpw";
            this.text_rpw.Size = new System.Drawing.Size(115, 25);
            this.text_rpw.TabIndex = 8;
            this.text_rpw.Text = "비밀번호 확인";
            // 
            // RPwBox
            // 
            this.RPwBox.Location = new System.Drawing.Point(102, 195);
            this.RPwBox.Name = "RPwBox";
            this.RPwBox.Size = new System.Drawing.Size(285, 21);
            this.RPwBox.TabIndex = 7;
            this.RPwBox.TextChanged += new System.EventHandler(this.RPwBox_TextChanged);
            // 
            // text_pw
            // 
            this.text_pw.AutoSize = true;
            this.text_pw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_pw.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.text_pw.Location = new System.Drawing.Point(97, 115);
            this.text_pw.Name = "text_pw";
            this.text_pw.Size = new System.Drawing.Size(83, 25);
            this.text_pw.TabIndex = 6;
            this.text_pw.Text = "비밀번호 ";
            // 
            // PwBox
            // 
            this.PwBox.Location = new System.Drawing.Point(102, 143);
            this.PwBox.Name = "PwBox";
            this.PwBox.Size = new System.Drawing.Size(285, 21);
            this.PwBox.TabIndex = 5;
            this.PwBox.TextChanged += new System.EventHandler(this.PwBox_TextChanged);
            // 
            // SignUpBt
            // 
            this.SignUpBt.BackColor = System.Drawing.Color.Bisque;
            this.SignUpBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SignUpBt.Location = new System.Drawing.Point(102, 340);
            this.SignUpBt.Name = "SignUpBt";
            this.SignUpBt.Size = new System.Drawing.Size(285, 48);
            this.SignUpBt.TabIndex = 4;
            this.SignUpBt.Text = "회원가입";
            this.SignUpBt.UseVisualStyleBackColor = false;
            this.SignUpBt.Click += new System.EventHandler(this.SignUp_bt);
            // 
            // text_email
            // 
            this.text_email.AutoSize = true;
            this.text_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_email.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.text_email.Location = new System.Drawing.Point(98, 63);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(60, 25);
            this.text_email.TabIndex = 3;
            this.text_email.Text = "이메일";
            // 
            // text_id
            // 
            this.text_id.AutoSize = true;
            this.text_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_id.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.text_id.Location = new System.Drawing.Point(98, 11);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(67, 25);
            this.text_id.TabIndex = 3;
            this.text_id.Text = "아이디 ";
            this.text_id.Click += new System.EventHandler(this.text_id_Click);
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(102, 91);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(285, 21);
            this.EmailBox.TabIndex = 2;
            this.EmailBox.TextChanged += new System.EventHandler(this.EmailBox_TextChanged);
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(102, 39);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(285, 21);
            this.IdBox.TabIndex = 2;
            this.IdBox.TextChanged += new System.EventHandler(this.IdBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(98, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "이름";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(102, 247);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(285, 21);
            this.name_textBox.TabIndex = 11;
            this.name_textBox.TextChanged += new System.EventHandler(this.name_textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(123, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "주행습관";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(285, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "차량종류";
            // 
            // drive_type_combo
            // 
            this.drive_type_combo.FormattingEnabled = true;
            this.drive_type_combo.Items.AddRange(new object[] {
            "SOFT",
            "NORMAL",
            "HARD"});
            this.drive_type_combo.Location = new System.Drawing.Point(103, 299);
            this.drive_type_combo.Name = "drive_type_combo";
            this.drive_type_combo.Size = new System.Drawing.Size(121, 23);
            this.drive_type_combo.TabIndex = 14;
            this.drive_type_combo.SelectedIndexChanged += new System.EventHandler(this.drive_type_combo_SelectedIndexChanged);
            // 
            // fuel_type_combo
            // 
            this.fuel_type_combo.FormattingEnabled = true;
            this.fuel_type_combo.Items.AddRange(new object[] {
            "가솔린",
            "디젤",
            "LPG"});
            this.fuel_type_combo.Location = new System.Drawing.Point(266, 299);
            this.fuel_type_combo.Name = "fuel_type_combo";
            this.fuel_type_combo.Size = new System.Drawing.Size(121, 23);
            this.fuel_type_combo.TabIndex = 15;
            this.fuel_type_combo.SelectedIndexChanged += new System.EventHandler(this.fuel_type_combo_SelectedIndexChanged);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 527);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.text_repw);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.text_repw.ResumeLayout(false);
            this.text_repw.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Logo1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel text_repw;
        private System.Windows.Forms.Button SignUpBt;
        private System.Windows.Forms.Label text_email;
        private System.Windows.Forms.Label text_id;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.Label text_rpw;
        private System.Windows.Forms.TextBox RPwBox;
        private System.Windows.Forms.Label text_pw;
        private System.Windows.Forms.TextBox PwBox;
        private System.Windows.Forms.Button overlapcheck;
        private System.Windows.Forms.Button ExitBt;
        private System.Windows.Forms.ComboBox fuel_type_combo;
        private System.Windows.Forms.ComboBox drive_type_combo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label label1;
    }
}

