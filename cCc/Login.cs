using MySql.Data.MySqlClient;
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
    public partial class Login : Form
    {
        public Login()
        //자동으로 생성되어 디자인에서 만든 요소와 코드를 연결하고 초기화 해주는 함수
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        //폼이 처음으로 표시되기 전에 발생하는 함수
        {

        }

        private void Exit_bt(object sender, EventArgs e)
        //화면 우측 상단 종료버튼
        {
            Application.Exit();
        }

        private void SignUp_bt(object sender, EventArgs e)
        //화면 회원가입 버튼(클릭 시 회원가입 페이지로 이동)
        {
            this.Visible = false;

            SignUp su = new SignUp();

            su.ShowDialog();
        }

        private void Login_bt(object sender, EventArgs e)
        //화면 로그인 버튼(로그인 성공 시 메인화면 페이지로 이동)
        {

            try
            {
                MySqlConnection connection = new MySqlConnection("Server = 219.248.39.216;Database=cccdb;Uid=root;Pwd=root;");//SQL서버 객체 생성
                MainPage mainPage = new MainPage();

                connection.Open();//SQL서버와 연결

                int login_status = 0;//로그인 상태 변수

                string login_id = id_textbox.Text;//아이디값 저장
                string login_pw = pw_textbox.Text;//비밀번호 저장

                string selectQuery = "SELECT user_id,login_id,login_pw FROM LOGIN_INFO_TB WHERE login_id =\'" + login_id + "\'";
                //id값이 같은 튜플을 선택하는 구문

                MySqlCommand SelectCommand = new MySqlCommand(selectQuery, connection);
                //MySQL로 명령어를 보내는 클래스
                MySqlDataReader userAcount = SelectCommand.ExecuteReader();
                //아이디가 일치하는 값을 userAcount에 받는다
                if (!string.IsNullOrEmpty(id_textbox.Text) && !string.IsNullOrEmpty(pw_textbox.Text))
                {
                    while (userAcount.Read())//userAcount를 읽을 동안
                    {
                        if (login_id == (string)userAcount["login_id"] && login_pw == (string)userAcount["login_pw"])
                        {
                            login_status = 1;//아이디,비밀번호가 일치할 시 상태를 1로 저장
                        }
                        string buff = userAcount["user_id"].ToString();
                        MainPage.getset_UserId = buff;//MainPage로 user_id값을 넘긴다
                        Car_comp.getset_UserId = buff;//Car_comp로 user_id값을 넘긴다
                        MainUserinfo.getset_UserId = buff;//MainUserInfo로 user_id값을 넘긴다
                        

                    }
                    
                    
                    connection.Close();//MySQL과 연결 종료

                    if (login_status == 1)//ID,PW가 맞으면
                    {

                        MessageBox.Show("로그인 성공");

                        this.Visible = false;

                        MainPage mi = new MainPage();

                        mi.ShowDialog();
                    }
                    else//ID,PW가 다르면
                    {
                        MessageBox.Show("아이디와 비밀번호를 확인해주세요");
                    }
                }
                else
                {//박스가 빈칸일 경우
                    MessageBox.Show("빈칸을 채워주세요");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void id_textbox_TextChanged(object sender, EventArgs e)
        //아이디 입력 텍스트 박스
        {

        }

        private void pw_textbox_TextChanged(object sender, EventArgs e)
        //비밀번호 입력 텍스트 박스
        {

        }
    }
}
