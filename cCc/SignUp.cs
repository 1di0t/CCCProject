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
    public partial class SignUp : Form
    {
        public SignUp()
        //자동으로 생성되어 디자인에서 만든 요소와 코드를 연결하고 초기화 해주는 함수
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        //폼이 처음으로 표시되기 전에 발생하는 함수
        {

        }

        private void SignUp_bt(object sender, EventArgs e)
        //회원가입 버튼(회원가입 성공 시 Login 페이지로 이동)
        {

            try
            {
                MySqlConnection connection = new MySqlConnection("Server = 219.248.39.216;Database=cccdb;Uid=root;Pwd=root;");//SQL서버 객체 생성
                MySqlCommand command = null;
                connection.Open();//SQL서버와 연결;


                string login_info_insertQuery = "INSERT INTO login_info_tb(login_id,login_pw,email) VALUES ('" 
                    + IdBox.Text + "','" + PwBox.Text + "','" + EmailBox.Text + "');";
                //유저정보 저장 INSERT구문

                if (!string.IsNullOrEmpty(IdBox.Text) && !string.IsNullOrEmpty(PwBox.Text) && !string.IsNullOrEmpty(RPwBox.Text))//빈칸 확인
                {
                    if (PwBox.Text == RPwBox.Text)//비밀번호와 비밀번호 확인란이 동일한지 체크
                    {//같다면
                        command = new MySqlCommand(login_info_insertQuery, connection);//명령어를 전송
                        if (command.ExecuteNonQuery() == 1)//쿼리가 보내졌을 경우
                        {
                            MessageBox.Show("회원가입 완료");
                            //회원가입 완료 메세지
                            connection.Close();
                            //DB연결 종료


                            //아래 설명 부탁==========================================================================================
                            this.Visible = false;

                            Login showForm2 = new Login();

                            showForm2.ShowDialog();
                            //=========================================================================================================
                        }
                    }
                    else
                    {//다르다면
                        MessageBox.Show("비밀번호가 다릅니다");
                    }
                }
                else
                {//빈칸이 있을 경우
                    MessageBox.Show("빈칸을 채워주세요");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Exit_bt(object sender, EventArgs e)
        //화면 우측 상단 종료버튼
        {
            Application.Exit();
        }

        private void IdBox_TextChanged(object sender, EventArgs e)
        //아이디 입력 텍스트박스
        {

        }

        private void overlapcheck_Click(object sender, EventArgs e)
        //아이디 중복확인
        {

        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        //이메일 입력 텍스트박스
        {

        }

        private void PwBox_TextChanged(object sender, EventArgs e)
        //비밀번호 입력 텍스트박스
        {

        }

        private void RPwBox_TextChanged(object sender, EventArgs e)
        //비밀번호 재입력 텍스트박스
        {

        }
    }
}
