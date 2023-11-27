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
            this.panel1 = new System.Windows.Forms.Panel();
            this.HomeButton = new System.Windows.Forms.Button();
            this.ExitBt = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.Userinfo_bt = new System.Windows.Forms.Button();
            this.Home_bt = new System.Windows.Forms.Button();
            this.Car_bt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.breakPad_Date = new System.Windows.Forms.TextBox();
            this.wiper_Date = new System.Windows.Forms.TextBox();
            this.tire_Date = new System.Windows.Forms.TextBox();
            this.coolant_Date = new System.Windows.Forms.TextBox();
            this.breakFluid_Date = new System.Windows.Forms.TextBox();
            this.engineOil_Date = new System.Windows.Forms.TextBox();
            this.missionOil_Date = new System.Windows.Forms.TextBox();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Controls.Add(this.ExitBt);
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
            // ExitBt
            // 
            this.ExitBt.BackColor = System.Drawing.Color.Bisque;
            this.ExitBt.FlatAppearance.BorderColor = System.Drawing.Color.Bisque;
            this.ExitBt.FlatAppearance.BorderSize = 0;
            this.ExitBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.ExitBt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.ExitBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBt.Image = ((System.Drawing.Image)(resources.GetObject("ExitBt.Image")));
            this.ExitBt.Location = new System.Drawing.Point(691, 0);
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
            this.panel10.Size = new System.Drawing.Size(100, 600);
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.breakPad_Date);
            this.panel2.Controls.Add(this.wiper_Date);
            this.panel2.Controls.Add(this.tire_Date);
            this.panel2.Controls.Add(this.coolant_Date);
            this.panel2.Controls.Add(this.breakFluid_Date);
            this.panel2.Controls.Add(this.engineOil_Date);
            this.panel2.Controls.Add(this.missionOil_Date);
            this.panel2.Controls.Add(this.car_Day);
            this.panel2.Controls.Add(this.car_part);
            this.panel2.Controls.Add(this.car_comp7);
            this.panel2.Controls.Add(this.car_comp4);
            this.panel2.Controls.Add(this.car_comp6);
            this.panel2.Controls.Add(this.car_comp5);
            this.panel2.Controls.Add(this.car_comp3);
            this.panel2.Controls.Add(this.car_comp2);
            this.panel2.Controls.Add(this.car_comp1);
            this.panel2.Location = new System.Drawing.Point(125, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 450);
            this.panel2.TabIndex = 5;
            // 
            // breakPad_Date
            // 
            this.breakPad_Date.Location = new System.Drawing.Point(176, 417);
            this.breakPad_Date.Name = "breakPad_Date";
            this.breakPad_Date.ReadOnly = true;
            this.breakPad_Date.Size = new System.Drawing.Size(70, 21);
            this.breakPad_Date.TabIndex = 16;
            this.breakPad_Date.Text = "D-XX";
            this.breakPad_Date.TextChanged += new System.EventHandler(this.BP_date_TextChanged);
            // 
            // wiper_Date
            // 
            this.wiper_Date.Location = new System.Drawing.Point(174, 360);
            this.wiper_Date.Name = "wiper_Date";
            this.wiper_Date.ReadOnly = true;
            this.wiper_Date.Size = new System.Drawing.Size(72, 21);
            this.wiper_Date.TabIndex = 17;
            this.wiper_Date.Text = "D-XX";
            this.wiper_Date.TextChanged += new System.EventHandler(this.W_date_TextChanged);
            // 
            // tire_Date
            // 
            this.tire_Date.Location = new System.Drawing.Point(174, 303);
            this.tire_Date.Name = "tire_Date";
            this.tire_Date.ReadOnly = true;
            this.tire_Date.Size = new System.Drawing.Size(72, 21);
            this.tire_Date.TabIndex = 18;
            this.tire_Date.Text = "D-XX";
            this.tire_Date.TextChanged += new System.EventHandler(this.T_date_TextChanged);
            // 
            // coolant_Date
            // 
            this.coolant_Date.Location = new System.Drawing.Point(174, 246);
            this.coolant_Date.Name = "coolant_Date";
            this.coolant_Date.ReadOnly = true;
            this.coolant_Date.Size = new System.Drawing.Size(72, 21);
            this.coolant_Date.TabIndex = 19;
            this.coolant_Date.Text = "D-XX";
            this.coolant_Date.TextChanged += new System.EventHandler(this.C_date_TextChanged);
            // 
            // breakFluid_Date
            // 
            this.breakFluid_Date.Location = new System.Drawing.Point(174, 189);
            this.breakFluid_Date.Name = "breakFluid_Date";
            this.breakFluid_Date.ReadOnly = true;
            this.breakFluid_Date.Size = new System.Drawing.Size(72, 21);
            this.breakFluid_Date.TabIndex = 20;
            this.breakFluid_Date.Text = "D-XX";
            this.breakFluid_Date.TextChanged += new System.EventHandler(this.BF_date_TextChanged);
            // 
            // engineOil_Date
            // 
            this.engineOil_Date.Location = new System.Drawing.Point(174, 132);
            this.engineOil_Date.Name = "engineOil_Date";
            this.engineOil_Date.ReadOnly = true;
            this.engineOil_Date.Size = new System.Drawing.Size(72, 21);
            this.engineOil_Date.TabIndex = 21;
            this.engineOil_Date.Text = "D-XX";
            this.engineOil_Date.TextChanged += new System.EventHandler(this.E_date_TextChanged);
            // 
            // missionOil_Date
            // 
            this.missionOil_Date.Location = new System.Drawing.Point(174, 75);
            this.missionOil_Date.Name = "missionOil_Date";
            this.missionOil_Date.ReadOnly = true;
            this.missionOil_Date.Size = new System.Drawing.Size(72, 21);
            this.missionOil_Date.TabIndex = 22;
            this.missionOil_Date.Text = "D-XX";
            this.missionOil_Date.TextChanged += new System.EventHandler(this.M_date_TextChanged);
            // 
            // car_Day
            // 
            this.car_Day.AutoSize = true;
            this.car_Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.car_Day.Location = new System.Drawing.Point(170, 15);
            this.car_Day.Name = "car_Day";
            this.car_Day.Size = new System.Drawing.Size(76, 24);
            this.car_Day.TabIndex = 7;
            this.car_Day.Text = "교체 시기";
            // 
            // car_part
            // 
            this.car_part.AutoSize = true;
            this.car_part.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.car_part.Location = new System.Drawing.Point(34, 15);
            this.car_part.Name = "car_part";
            this.car_part.Size = new System.Drawing.Size(40, 24);
            this.car_part.TabIndex = 8;
            this.car_part.Text = "부품";
            // 
            // car_comp7
            // 
            this.car_comp7.AutoSize = true;
            this.car_comp7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.car_comp7.Location = new System.Drawing.Point(35, 421);
            this.car_comp7.Name = "car_comp7";
            this.car_comp7.Size = new System.Drawing.Size(85, 17);
            this.car_comp7.TabIndex = 9;
            this.car_comp7.Text = "브레이크 패드";
            // 
            // car_comp4
            // 
            this.car_comp4.AutoSize = true;
            this.car_comp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.car_comp4.Location = new System.Drawing.Point(35, 250);
            this.car_comp4.Name = "car_comp4";
            this.car_comp4.Size = new System.Drawing.Size(44, 17);
            this.car_comp4.TabIndex = 10;
            this.car_comp4.Text = "냉각수";
            // 
            // car_comp6
            // 
            this.car_comp6.AutoSize = true;
            this.car_comp6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.car_comp6.Location = new System.Drawing.Point(35, 364);
            this.car_comp6.Name = "car_comp6";
            this.car_comp6.Size = new System.Drawing.Size(44, 17);
            this.car_comp6.TabIndex = 11;
            this.car_comp6.Text = "와이퍼";
            // 
            // car_comp5
            // 
            this.car_comp5.AutoSize = true;
            this.car_comp5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.car_comp5.Location = new System.Drawing.Point(35, 307);
            this.car_comp5.Name = "car_comp5";
            this.car_comp5.Size = new System.Drawing.Size(44, 17);
            this.car_comp5.TabIndex = 12;
            this.car_comp5.Text = "타이어";
            // 
            // car_comp3
            // 
            this.car_comp3.AutoSize = true;
            this.car_comp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.car_comp3.Location = new System.Drawing.Point(34, 193);
            this.car_comp3.Name = "car_comp3";
            this.car_comp3.Size = new System.Drawing.Size(73, 17);
            this.car_comp3.TabIndex = 13;
            this.car_comp3.Text = "브레이크 액";
            // 
            // car_comp2
            // 
            this.car_comp2.AutoSize = true;
            this.car_comp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.car_comp2.Location = new System.Drawing.Point(34, 136);
            this.car_comp2.Name = "car_comp2";
            this.car_comp2.Size = new System.Drawing.Size(61, 17);
            this.car_comp2.TabIndex = 14;
            this.car_comp2.Text = "엔진 오일";
            // 
            // car_comp1
            // 
            this.car_comp1.AutoSize = true;
            this.car_comp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.car_comp1.Location = new System.Drawing.Point(34, 79);
            this.car_comp1.Name = "car_comp1";
            this.car_comp1.Size = new System.Drawing.Size(61, 17);
            this.car_comp1.TabIndex = 15;
            this.car_comp1.Text = "미션 오일";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 650);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button Car_bt;
        private System.Windows.Forms.Button Userinfo_bt;
        private System.Windows.Forms.Button Home_bt;
        private System.Windows.Forms.Button ExitBt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox breakPad_Date;
        private System.Windows.Forms.TextBox wiper_Date;
        private System.Windows.Forms.TextBox tire_Date;
        private System.Windows.Forms.TextBox coolant_Date;
        private System.Windows.Forms.TextBox breakFluid_Date;
        private System.Windows.Forms.TextBox engineOil_Date;
        private System.Windows.Forms.TextBox missionOil_Date;
        private System.Windows.Forms.Label car_Day;
        private System.Windows.Forms.Label car_part;
        private System.Windows.Forms.Label car_comp7;
        private System.Windows.Forms.Label car_comp4;
        private System.Windows.Forms.Label car_comp6;
        private System.Windows.Forms.Label car_comp5;
        private System.Windows.Forms.Label car_comp3;
        private System.Windows.Forms.Label car_comp2;
        private System.Windows.Forms.Label car_comp1;
        private System.Windows.Forms.Button HomeButton;
    }
}

