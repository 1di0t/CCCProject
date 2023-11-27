namespace cCc
{
    partial class MainUserinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUserinfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.HomeButton = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.Userinfo_bt = new System.Windows.Forms.Button();
            this.Home_bt = new System.Windows.Forms.Button();
            this.Car_bt = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.genderCombo = new System.Windows.Forms.ComboBox();
            this.Member_add_LB = new System.Windows.Forms.Label();
            this.Member_gender_LB = new System.Windows.Forms.Label();
            this.Member_age_LB = new System.Windows.Forms.Label();
            this.Member_name_LB = new System.Windows.Forms.Label();
            this.Member_add = new System.Windows.Forms.TextBox();
            this.Member_age = new System.Windows.Forms.TextBox();
            this.Member_name = new System.Windows.Forms.TextBox();
            this.User_type = new System.Windows.Forms.Label();
            this.carType_combo = new System.Windows.Forms.ComboBox();
            this.Type_bt = new System.Windows.Forms.Button();
            this.driveType_combo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 56);
            this.panel1.TabIndex = 1;
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HomeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.HomeButton.Location = new System.Drawing.Point(3, 3);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(105, 50);
            this.HomeButton.TabIndex = 8;
            this.HomeButton.Text = "cCc";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
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
            this.exit.TabIndex = 2;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Bisque;
            this.panel10.Controls.Add(this.Userinfo_bt);
            this.panel10.Controls.Add(this.Home_bt);
            this.panel10.Controls.Add(this.Car_bt);
            this.panel10.Location = new System.Drawing.Point(0, 55);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(100, 600);
            this.panel10.TabIndex = 5;
            // 
            // Userinfo_bt
            // 
            this.Userinfo_bt.BackColor = System.Drawing.Color.Bisque;
            this.Userinfo_bt.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.Userinfo_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Userinfo_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Userinfo_bt.Location = new System.Drawing.Point(0, 219);
            this.Userinfo_bt.Name = "Userinfo_bt";
            this.Userinfo_bt.Size = new System.Drawing.Size(100, 80);
            this.Userinfo_bt.TabIndex = 3;
            this.Userinfo_bt.Text = "사용자 정보";
            this.Userinfo_bt.UseVisualStyleBackColor = false;
            this.Userinfo_bt.Click += new System.EventHandler(this.Userinfo_bt_Click);
            // 
            // Home_bt
            // 
            this.Home_bt.BackColor = System.Drawing.Color.Bisque;
            this.Home_bt.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.Home_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Home_bt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Home_bt.Location = new System.Drawing.Point(0, 0);
            this.Home_bt.Name = "Home_bt";
            this.Home_bt.Size = new System.Drawing.Size(100, 80);
            this.Home_bt.TabIndex = 3;
            this.Home_bt.Text = "메인 화면";
            this.Home_bt.UseVisualStyleBackColor = false;
            this.Home_bt.Click += new System.EventHandler(this.Home_bt_Click);
            // 
            // Car_bt
            // 
            this.Car_bt.BackColor = System.Drawing.Color.Bisque;
            this.Car_bt.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.Car_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Car_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Car_bt.Location = new System.Drawing.Point(0, 110);
            this.Car_bt.Name = "Car_bt";
            this.Car_bt.Size = new System.Drawing.Size(100, 80);
            this.Car_bt.TabIndex = 3;
            this.Car_bt.Text = "차량 부품 ";
            this.Car_bt.UseVisualStyleBackColor = false;
            this.Car_bt.Click += new System.EventHandler(this.Car_bt_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.User_type);
            this.panel3.Controls.Add(this.Type_bt);
            this.panel3.Controls.Add(this.genderCombo);
            this.panel3.Controls.Add(this.driveType_combo);
            this.panel3.Controls.Add(this.Member_add_LB);
            this.panel3.Controls.Add(this.carType_combo);
            this.panel3.Controls.Add(this.Member_gender_LB);
            this.panel3.Controls.Add(this.Member_age_LB);
            this.panel3.Controls.Add(this.Member_name_LB);
            this.panel3.Controls.Add(this.Member_add);
            this.panel3.Controls.Add(this.Member_age);
            this.panel3.Controls.Add(this.Member_name);
            this.panel3.Location = new System.Drawing.Point(123, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 298);
            this.panel3.TabIndex = 11;
            // 
            // genderCombo
            // 
            this.genderCombo.FormattingEnabled = true;
            this.genderCombo.Items.AddRange(new object[] {
            "남",
            "여"});
            this.genderCombo.Location = new System.Drawing.Point(275, 93);
            this.genderCombo.Name = "genderCombo";
            this.genderCombo.Size = new System.Drawing.Size(50, 20);
            this.genderCombo.TabIndex = 16;
            this.genderCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Member_add_LB
            // 
            this.Member_add_LB.AutoSize = true;
            this.Member_add_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Member_add_LB.Location = new System.Drawing.Point(379, 52);
            this.Member_add_LB.Name = "Member_add_LB";
            this.Member_add_LB.Size = new System.Drawing.Size(40, 24);
            this.Member_add_LB.TabIndex = 12;
            this.Member_add_LB.Text = "주소";
            // 
            // Member_gender_LB
            // 
            this.Member_gender_LB.AutoSize = true;
            this.Member_gender_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Member_gender_LB.Location = new System.Drawing.Point(271, 52);
            this.Member_gender_LB.Name = "Member_gender_LB";
            this.Member_gender_LB.Size = new System.Drawing.Size(40, 24);
            this.Member_gender_LB.TabIndex = 13;
            this.Member_gender_LB.Text = "성별";
            // 
            // Member_age_LB
            // 
            this.Member_age_LB.AutoSize = true;
            this.Member_age_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Member_age_LB.Location = new System.Drawing.Point(163, 52);
            this.Member_age_LB.Name = "Member_age_LB";
            this.Member_age_LB.Size = new System.Drawing.Size(40, 24);
            this.Member_age_LB.TabIndex = 14;
            this.Member_age_LB.Text = "나이";
            // 
            // Member_name_LB
            // 
            this.Member_name_LB.AutoSize = true;
            this.Member_name_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Member_name_LB.Location = new System.Drawing.Point(25, 52);
            this.Member_name_LB.Name = "Member_name_LB";
            this.Member_name_LB.Size = new System.Drawing.Size(40, 24);
            this.Member_name_LB.TabIndex = 15;
            this.Member_name_LB.Text = "이름";
            this.Member_name_LB.Click += new System.EventHandler(this.Member_name_LB_Click);
            // 
            // Member_add
            // 
            this.Member_add.Location = new System.Drawing.Point(383, 93);
            this.Member_add.Name = "Member_add";
            this.Member_add.Size = new System.Drawing.Size(200, 21);
            this.Member_add.TabIndex = 8;
            this.Member_add.TextChanged += new System.EventHandler(this.Member_add_TextChanged);
            // 
            // Member_age
            // 
            this.Member_age.Location = new System.Drawing.Point(167, 93);
            this.Member_age.Name = "Member_age";
            this.Member_age.Size = new System.Drawing.Size(50, 21);
            this.Member_age.TabIndex = 10;
            this.Member_age.TextChanged += new System.EventHandler(this.Member_age_TextChanged);
            // 
            // Member_name
            // 
            this.Member_name.Location = new System.Drawing.Point(29, 93);
            this.Member_name.Name = "Member_name";
            this.Member_name.Size = new System.Drawing.Size(80, 21);
            this.Member_name.TabIndex = 11;
            this.Member_name.TextChanged += new System.EventHandler(this.Member_name_TextChanged);
            // 
            // User_type
            // 
            this.User_type.AutoSize = true;
            this.User_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.User_type.Location = new System.Drawing.Point(25, 153);
            this.User_type.Name = "User_type";
            this.User_type.Size = new System.Drawing.Size(70, 24);
            this.User_type.TabIndex = 11;
            this.User_type.Text = "주행습관";
            // 
            // carType_combo
            // 
            this.carType_combo.FormattingEnabled = true;
            this.carType_combo.Items.AddRange(new object[] {
            "가솔린",
            "디젤",
            "LPG"});
            this.carType_combo.Location = new System.Drawing.Point(204, 202);
            this.carType_combo.Name = "carType_combo";
            this.carType_combo.Size = new System.Drawing.Size(121, 20);
            this.carType_combo.TabIndex = 15;
            this.carType_combo.SelectedIndexChanged += new System.EventHandler(this.C_type1_SelectedIndexChanged);
            // 
            // Type_bt
            // 
            this.Type_bt.BackColor = System.Drawing.Color.Bisque;
            this.Type_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Type_bt.Location = new System.Drawing.Point(537, 271);
            this.Type_bt.Name = "Type_bt";
            this.Type_bt.Size = new System.Drawing.Size(62, 26);
            this.Type_bt.TabIndex = 16;
            this.Type_bt.Text = "수정";
            this.Type_bt.UseVisualStyleBackColor = false;
            this.Type_bt.Click += new System.EventHandler(this.Type_bt_Click);
            // 
            // driveType_combo
            // 
            this.driveType_combo.FormattingEnabled = true;
            this.driveType_combo.Items.AddRange(new object[] {
            "Soft",
            "Normal",
            "Hard"});
            this.driveType_combo.Location = new System.Drawing.Point(29, 204);
            this.driveType_combo.Name = "driveType_combo";
            this.driveType_combo.Size = new System.Drawing.Size(120, 20);
            this.driveType_combo.TabIndex = 17;
            this.driveType_combo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // MainUserinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 650);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainUserinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button Userinfo_bt;
        private System.Windows.Forms.Button Home_bt;
        private System.Windows.Forms.Button Car_bt;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Member_add_LB;
        private System.Windows.Forms.Label Member_gender_LB;
        private System.Windows.Forms.Label Member_age_LB;
        private System.Windows.Forms.Label Member_name_LB;
        private System.Windows.Forms.TextBox Member_add;
        private System.Windows.Forms.TextBox Member_age;
        private System.Windows.Forms.TextBox Member_name;
        private System.Windows.Forms.ComboBox genderCombo;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Label User_type;
        private System.Windows.Forms.ComboBox carType_combo;
        private System.Windows.Forms.Button Type_bt;
        private System.Windows.Forms.ComboBox driveType_combo;
    }
}

