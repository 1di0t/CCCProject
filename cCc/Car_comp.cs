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
    public partial class Car_comp : Form
    {
        public Car_comp()
        //자동으로 생성되어 디자인에서 만든 요소와 코드를 연결하고 초기화 해주는 함수
        {
            InitializeComponent();
        }

        private void Car_comp_Load(object sender, EventArgs e)
        //폼이 처음으로 표시되기 전에 발생하는 함수
        {

        }

        private void exit_Click(object sender, EventArgs e)
        //화면 우측 상단 종료버튼
        {
            Application.Exit();
        }

        private void Home_bt_Click(object sender, EventArgs e)
        //화면 좌측 사이드바 1번째 해당하는 메인화면 버튼(클릭 시 메인화면 페이지로 이동)
        {
            this.Visible = false;

            MainPage main = new MainPage();

            main.ShowDialog();
        }

        private void Car_bt_Click(object sender, EventArgs e)
        //화면 좌측 사이드바 2번째 해당하는 차량부품화면 버튼(클릭 시 차량부품화면 페이지로 이동)
        {

        }
        private void Userinfo_bt_Click(object sender, EventArgs e)
        //화면 좌측 사이드바 3번째 해당하는 사용자 정보화면 버튼(클릭 시 사용자 정보화면 페이지로 이동)
        {
            this.Visible = false;

            MainUserinfo mui = new MainUserinfo();

            mui.ShowDialog();
        }

        private void inside_add_Click(object sender, EventArgs e)
        //차량 내부 추가 버튼
        {

        }

        private void outside_add_Click(object sender, EventArgs e)
        //차량 외부 추가 버튼
        {

        }
    }
}
