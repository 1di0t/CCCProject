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
        public static string MySQLIP = "Server = 219.248.39.216;Database=cccdb;Uid=root;Pwd=root;";
        private string user_id;//유저 고유번호 저장 변수
        private string drive_type;//주행습관 저장 변수
        private string car_type;//자동차 타입 저장 변수
        private bool login_access;//로그인 가능 여부 저장 변수



        MySqlConnection connection = new MySqlConnection(MySQLIP);//SQL서버 객체 생성
        MySqlCommand command = null;

        public SignUp()
        //자동으로 생성되어 디자인에서 만든 요소와 코드를 연결하고 초기화 해주는 함수
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        //폼이 처음으로 표시되기 전에 발생하는 함수
        {

        }

        private void get_UserID()
        {
            try
            {


                connection.Open();//SQL서버와 연결;
                string selectQuery = "SELECT user_id FROM login_info_tb WHERE login_id = '" + IdBox.Text + "';";

                MySqlCommand SelectCommand = new MySqlCommand(selectQuery, connection);
                //MySQL로 명령어를 보내는 클래스

                MySqlDataReader userAcount = SelectCommand.ExecuteReader();
                //아이디가 일치하는 값을 userAcount에 받는다

                while (userAcount.Read())//userAcount를 읽을 동안
                {
                    user_id = userAcount["user_id"].ToString();//user_id를 string으로 변환
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//user_id를 가져오는 함수
        public bool send_Query(string Query)
        {
            try
            {
                connection.Open();//SQL서버와 연결;
                command = new MySqlCommand(Query, connection);//명령어를 전송


                if (command.ExecuteNonQuery() == 1)//쿼리가 보내졌을 경우
                {
                    connection.Close();
                    return true;
                }
                else
                {
                    connection.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
                return false;
            }
        }//쿼리를 보내는 함수

        private void set_Dtype_Ftype()
        {
            if (drive_type_combo.SelectedItem != null)
            {
                drive_type = drive_type_combo.SelectedItem.ToString();//drive_type변수에 주행습관 저장
            }
            if (fuel_type_combo.SelectedItem != null)
            {
                car_type = fuel_type_combo.SelectedItem.ToString();//car_type변수에 차량타입 저장
            }
        }
        //drive_type과 car_type을 설정하는 함수

        private void compare_id()
        {
            try
            {
                connection.Open();//SQL서버와 연결;
                string selectQuery = "SELECT login_id FROM login_info_tb WHERE login_id = '" + IdBox.Text + "';";

                MySqlCommand SelectCommand = new MySqlCommand(selectQuery, connection);
                //MySQL로 명령어를 보내는 클래스

                MySqlDataReader userAcount = SelectCommand.ExecuteReader();
                //아이디가 일치하는 값을 userAcount에 받는다

                login_access = true;//로그인 가능 여부를 가능으로 설정한다
                while (userAcount.Read())//userAcount내에 데이터가 있으면 실행
                {
                        login_access = false;
                        break;
                }
                if (login_access == false)
                {
                    MessageBox.Show("중복된 아이디입니다");
                }
                else
                {
                    MessageBox.Show("사용가능한 아이디입니다");
                }
                userAcount.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//아이디 중복확인 함수

        private void SignUp_bt(object sender, EventArgs e)
        //회원가입 버튼(회원가입 성공 시 Login 페이지로 이동)
        {
            set_Dtype_Ftype();//drive_type과 car_type을 설정한다
            try
            {
                if (string.IsNullOrEmpty(IdBox.Text))
                {
                    MessageBox.Show("아이디를 입력하세요");
                    return;
                }
                else if (string.IsNullOrEmpty(EmailBox.Text))
                {
                    MessageBox.Show("이메일을 입력하세요");
                    return;
                }
                else if (string.IsNullOrEmpty(PwBox.Text))
                {
                    MessageBox.Show("비밀번호를 입력하세요");
                    return;
                }
                else if (string.IsNullOrEmpty(name_textBox.Text))
                {
                    MessageBox.Show("이름을 입력하세요");
                    return;
                }
                else if (string.IsNullOrEmpty(drive_type))
                {
                    MessageBox.Show("주행습관을 선택하세요");
                    return;
                }
                else if (string.IsNullOrEmpty(car_type))
                {
                    MessageBox.Show("차량타입을 선택하세요");
                    return;
                }
                //빈칸을 확인한다

                if (login_access == true)//아이디 중복확인
                {
                    if (PwBox.Text == RPwBox.Text)//비밀번호와 비밀번호 확인란이 동일한지 체크
                    {//같다면

                        string login_info_insertQuery = "INSERT INTO login_info_tb(login_id,login_pw,email) VALUES ('"
                        + IdBox.Text + "','" + PwBox.Text + "','" + EmailBox.Text + "');";
                        //유저정보 저장 INSERT구문
                        if (send_Query(login_info_insertQuery))//쿼리가 보내졌을 경우
                        {
                            get_UserID();//유저 고유번호를 가져온다
                            string member_info_insertQuery = "INSERT INTO MEMBER_INFO_TB VALUES (" + user_id + ",'" + name_textBox.Text
                            + "'," + 20 + ",'','','" + drive_type + "','" + car_type + "');";
                            //멤버 테이블 저장 INSERT구문
                            if (send_Query(member_info_insertQuery))
                            {//회원정보를 저장한다

                                MessageBox.Show("회원가입 완료");
                                //회원가입 완료 메세지



                                this.Visible = false;

                                Login showForm2 = new Login();

                                showForm2.ShowDialog();
                            }
                        }
                     
                    }
                    else
                    {//다르다면
                        MessageBox.Show("비밀번호가 다릅니다");
                    }
                }
                else
                {//아이디가 중복일 경우
                    MessageBox.Show("중복된 아이디입니다");
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
            compare_id();//아이디 중복확인 함수
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

        private void text_id_Click(object sender, EventArgs e)
        {

        }

        private void name_textBox_TextChanged(object sender, EventArgs e)
        //이름 텍스트박스//name_textBox
        {

        }

        private void drive_type_combo_SelectedIndexChanged(object sender, EventArgs e)
        //운전습관 콤보박스//drive_type_combo
        {

        }

        private void fuel_type_combo_SelectedIndexChanged(object sender, EventArgs e)
        //유종 콤보박스//fuel_type_combo
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        //홈버튼(클릭 시 메인화면 페이지로 이동)
        {
            this.Visible = false;

            Login main = new Login();

            main.ShowDialog();
        }

    }
}
