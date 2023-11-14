namespace cCc
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitBt = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.Userinfo_bt = new System.Windows.Forms.Button();
            this.Home_bt = new System.Windows.Forms.Button();
            this.Car_bt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BP_date = new System.Windows.Forms.TextBox();
            this.W_date = new System.Windows.Forms.TextBox();
            this.T_date = new System.Windows.Forms.TextBox();
            this.C_date = new System.Windows.Forms.TextBox();
            this.BF_date = new System.Windows.Forms.TextBox();
            this.E_date = new System.Windows.Forms.TextBox();
            this.M_date = new System.Windows.Forms.TextBox();
            this.car_Day = new System.Windows.Forms.Label();
            this.car_part = new System.Windows.Forms.Label();
            this.car_comp7 = new System.Windows.Forms.Label();
            this.car_comp4 = new System.Windows.Forms.Label();
            this.car_comp6 = new System.Windows.Forms.Label();
            this.car_comp5 = new System.Windows.Forms.Label();
            this.car_comp3 = new System.Windows.Forms.Label();
            this.car_comp2 = new System.Windows.Forms.Label();
            this.car_comp1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "cCc";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.ExitBt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 56);
            this.panel1.TabIndex = 1;
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
            this.ExitBt.Location = new System.Drawing.Point(673, 0);
            this.ExitBt.Name = "ExitBt";
            this.ExitBt.Size = new System.Drawing.Size(59, 56);
            this.ExitBt.TabIndex = 3;
            this.ExitBt.UseVisualStyleBackColor = false;
            this.ExitBt.Click += new System.EventHandler(this.ExitBt_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Bisque;
            this.panel10.Controls.Add(this.Userinfo_bt);
            this.panel10.Controls.Add(this.Home_bt);
            this.panel10.Controls.Add(this.Car_bt);
            this.panel10.Location = new System.Drawing.Point(0, 56);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(93, 639);
            this.panel10.TabIndex = 4;
            // 
            // Userinfo_bt
            // 
            this.Userinfo_bt.BackColor = System.Drawing.Color.Bisque;
            this.Userinfo_bt.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.Userinfo_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Userinfo_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Userinfo_bt.Location = new System.Drawing.Point(0, 219);
            this.Userinfo_bt.Name = "Userinfo_bt";
            this.Userinfo_bt.Size = new System.Drawing.Size(93, 76);
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
            this.Home_bt.Size = new System.Drawing.Size(93, 76);
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
            this.Car_bt.Size = new System.Drawing.Size(93, 76);
            this.Car_bt.TabIndex = 3;
            this.Car_bt.Text = "차량 부품 ";
            this.Car_bt.UseVisualStyleBackColor = false;
            this.Car_bt.Click += new System.EventHandler(this.Car_bt_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BP_date);
            this.panel2.Controls.Add(this.W_date);
            this.panel2.Controls.Add(this.T_date);
            this.panel2.Controls.Add(this.C_date);
            this.panel2.Controls.Add(this.BF_date);
            this.panel2.Controls.Add(this.E_date);
            this.panel2.Controls.Add(this.M_date);
            this.panel2.Controls.Add(this.car_Day);
            this.panel2.Controls.Add(this.car_part);
            this.panel2.Controls.Add(this.car_comp7);
            this.panel2.Controls.Add(this.car_comp4);
            this.panel2.Controls.Add(this.car_comp6);
            this.panel2.Controls.Add(this.car_comp5);
            this.panel2.Controls.Add(this.car_comp3);
            this.panel2.Controls.Add(this.car_comp2);
            this.panel2.Controls.Add(this.car_comp1);
            this.panel2.Location = new System.Drawing.Point(184, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 279);
            this.panel2.TabIndex = 5;
            // 
            // BP_date
            // 
            this.BP_date.Location = new System.Drawing.Point(276, 245);
            this.BP_date.Name = "BP_date";
            this.BP_date.ReadOnly = true;
            this.BP_date.Size = new System.Drawing.Size(53, 21);
            this.BP_date.TabIndex = 16;
            this.BP_date.Text = "D-XX";
            this.BP_date.TextChanged += new System.EventHandler(this.BP_date_TextChanged);
            // 
            // W_date
            // 
            this.W_date.Location = new System.Drawing.Point(276, 219);
            this.W_date.Name = "W_date";
            this.W_date.ReadOnly = true;
            this.W_date.Size = new System.Drawing.Size(53, 21);
            this.W_date.TabIndex = 17;
            this.W_date.Text = "D-XX";
            this.W_date.TextChanged += new System.EventHandler(this.W_date_TextChanged);
            // 
            // T_date
            // 
            this.T_date.Location = new System.Drawing.Point(276, 194);
            this.T_date.Name = "T_date";
            this.T_date.ReadOnly = true;
            this.T_date.Size = new System.Drawing.Size(53, 21);
            this.T_date.TabIndex = 18;
            this.T_date.Text = "D-XX";
            this.T_date.TextChanged += new System.EventHandler(this.T_date_TextChanged);
            // 
            // C_date
            // 
            this.C_date.Location = new System.Drawing.Point(276, 131);
            this.C_date.Name = "C_date";
            this.C_date.ReadOnly = true;
            this.C_date.Size = new System.Drawing.Size(53, 21);
            this.C_date.TabIndex = 19;
            this.C_date.Text = "D-XX";
            this.C_date.TextChanged += new System.EventHandler(this.C_date_TextChanged);
            // 
            // BF_date
            // 
            this.BF_date.Location = new System.Drawing.Point(276, 104);
            this.BF_date.Name = "BF_date";
            this.BF_date.ReadOnly = true;
            this.BF_date.Size = new System.Drawing.Size(53, 21);
            this.BF_date.TabIndex = 20;
            this.BF_date.Text = "D-XX";
            this.BF_date.TextChanged += new System.EventHandler(this.BF_date_TextChanged);
            // 
            // E_date
            // 
            this.E_date.Location = new System.Drawing.Point(276, 79);
            this.E_date.Name = "E_date";
            this.E_date.ReadOnly = true;
            this.E_date.Size = new System.Drawing.Size(53, 21);
            this.E_date.TabIndex = 21;
            this.E_date.Text = "D-XX";
            this.E_date.TextChanged += new System.EventHandler(this.E_date_TextChanged);
            // 
            // M_date
            // 
            this.M_date.Location = new System.Drawing.Point(276, 55);
            this.M_date.Name = "M_date";
            this.M_date.ReadOnly = true;
            this.M_date.Size = new System.Drawing.Size(53, 21);
            this.M_date.TabIndex = 22;
            this.M_date.Text = "D-XX";
            this.M_date.TextChanged += new System.EventHandler(this.M_date_TextChanged);
            // 
            // car_Day
            // 
            this.car_Day.AutoSize = true;
            this.car_Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.car_Day.Location = new System.Drawing.Point(274, 15);
            this.car_Day.Name = "car_Day";
            this.car_Day.Size = new System.Drawing.Size(76, 24);
            this.car_Day.TabIndex = 7;
            this.car_Day.Text = "교체 시기";
            // 
            // car_part
            // 
            this.car_part.AutoSize = true;
            this.car_part.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.car_part.Location = new System.Drawing.Point(106, 15);
            this.car_part.Name = "car_part";
            this.car_part.Size = new System.Drawing.Size(40, 24);
            this.car_part.TabIndex = 8;
            this.car_part.Text = "부품";
            // 
            // car_comp7
            // 
            this.car_comp7.AutoSize = true;
            this.car_comp7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.car_comp7.Location = new System.Drawing.Point(108, 250);
            this.car_comp7.Name = "car_comp7";
            this.car_comp7.Size = new System.Drawing.Size(85, 17);
            this.car_comp7.TabIndex = 9;
            this.car_comp7.Text = "브레이크 패드";
            // 
            // car_comp4
            // 
            this.car_comp4.AutoSize = true;
            this.car_comp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.car_comp4.Location = new System.Drawing.Point(107, 135);
            this.car_comp4.Name = "car_comp4";
            this.car_comp4.Size = new System.Drawing.Size(44, 17);
            this.car_comp4.TabIndex = 10;
            this.car_comp4.Text = "냉각수";
            // 
            // car_comp6
            // 
            this.car_comp6.AutoSize = true;
            this.car_comp6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.car_comp6.Location = new System.Drawing.Point(107, 224);
            this.car_comp6.Name = "car_comp6";
            this.car_comp6.Size = new System.Drawing.Size(44, 17);
            this.car_comp6.TabIndex = 11;
            this.car_comp6.Text = "와이퍼";
            // 
            // car_comp5
            // 
            this.car_comp5.AutoSize = true;
            this.car_comp5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.car_comp5.Location = new System.Drawing.Point(107, 199);
            this.car_comp5.Name = "car_comp5";
            this.car_comp5.Size = new System.Drawing.Size(44, 17);
            this.car_comp5.TabIndex = 12;
            this.car_comp5.Text = "타이어";
            // 
            // car_comp3
            // 
            this.car_comp3.AutoSize = true;
            this.car_comp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.car_comp3.Location = new System.Drawing.Point(106, 109);
            this.car_comp3.Name = "car_comp3";
            this.car_comp3.Size = new System.Drawing.Size(73, 17);
            this.car_comp3.TabIndex = 13;
            this.car_comp3.Text = "브레이크 액";
            // 
            // car_comp2
            // 
            this.car_comp2.AutoSize = true;
            this.car_comp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.car_comp2.Location = new System.Drawing.Point(106, 84);
            this.car_comp2.Name = "car_comp2";
            this.car_comp2.Size = new System.Drawing.Size(61, 17);
            this.car_comp2.TabIndex = 14;
            this.car_comp2.Text = "엔진 오일";
            // 
            // car_comp1
            // 
            this.car_comp1.AutoSize = true;
            this.car_comp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.car_comp1.Location = new System.Drawing.Point(106, 60);
            this.car_comp1.Name = "car_comp1";
            this.car_comp1.Size = new System.Drawing.Size(61, 17);
            this.car_comp1.TabIndex = 15;
            this.car_comp1.Text = "미션 오일";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 635);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button Car_bt;
        private System.Windows.Forms.Button Userinfo_bt;
        private System.Windows.Forms.Button Home_bt;
        private System.Windows.Forms.Button ExitBt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox BP_date;
        private System.Windows.Forms.TextBox W_date;
        private System.Windows.Forms.TextBox T_date;
        private System.Windows.Forms.TextBox C_date;
        private System.Windows.Forms.TextBox BF_date;
        private System.Windows.Forms.TextBox E_date;
        private System.Windows.Forms.TextBox M_date;
        private System.Windows.Forms.Label car_Day;
        private System.Windows.Forms.Label car_part;
        private System.Windows.Forms.Label car_comp7;
        private System.Windows.Forms.Label car_comp4;
        private System.Windows.Forms.Label car_comp6;
        private System.Windows.Forms.Label car_comp5;
        private System.Windows.Forms.Label car_comp3;
        private System.Windows.Forms.Label car_comp2;
        private System.Windows.Forms.Label car_comp1;
    }
}

