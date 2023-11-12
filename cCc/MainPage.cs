using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cCc
{
    public partial class MainPage : Form
    {
        private string user_id;
        public string getset_UserId
        {
            get { return this.user_id; }//값을 가져오는 라인
            set { this.user_id = value; }//가져온 값 저장
        }


        public MainPage()
        //자동으로 생성되어 디자인에서 만든 요소와 코드를 연결하고 초기화 해주는 함수
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        //폼이 처음으로 표시되기 전에 발생하는 함수
        {

        }

        private void ExitBt_Click(object sender, EventArgs e)
        //화면 우측 상단 종료버튼
        {
            Application.Exit();
        }

        private void Home_bt_Click(object sender, EventArgs e)
        //화면 좌측 사이드바 1번째 해당하는 메인화면 버튼(클릭 시 메인화면 페이지로 이동)
        {

        }

        private void Car_bt_Click(object sender, EventArgs e)
        //화면 좌측 사이드바 2번째 해당하는 차량부품화면 버튼(클릭 시 차량부품화면 페이지로 이동)
        {
            this.Visible = false;

            Car_comp cc = new Car_comp();

            cc.ShowDialog();
        }

        private void Userinfo_bt_Click(object sender, EventArgs e)
        //화면 좌측 사이드바 3번째 해당하는 사용자 정보화면 버튼(클릭 시 사용자 정보화면 페이지로 이동)
        {
            this.Visible = false;

            MainUserinfo userinfo = new MainUserinfo();

            userinfo.ShowDialog();

        }

        private void M_date_TextChanged(object sender, EventArgs e)
        //미션오일 날짜 텍스트박스
        {

        }

        private void E_date_TextChanged(object sender, EventArgs e)
        //엔진오일 날짜 텍스트박스
        {

        }

        private void BF_date_TextChanged(object sender, EventArgs e)
        //브레이크 액 날짜 텍스트박스
        {

        }

        private void C_date_TextChanged(object sender, EventArgs e)
        //냉각수 날짜 텍스트박스
        {

        }

        private void T_date_TextChanged(object sender, EventArgs e)
        //타이어 날짜 텍스트박스
        {

        }

        private void W_date_TextChanged(object sender, EventArgs e)
        //와이퍼 날짜 텍스트박스
        {

        }

        private void BP_date_TextChanged(object sender, EventArgs e)
        //브레이크패드 날짜 텍스트박스
        {

        }
    }
}
