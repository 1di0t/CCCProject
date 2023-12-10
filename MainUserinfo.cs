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
    public partial class MainUserinfo : Form
    {
        private string user_id;//유저 고유번호 저장 변수
        private string drive_type;//주행습관 저장 변수
        private string car_type;//자동차 타입 저장 변수
        private string gender;//성별 저장 변수

        MySqlConnection connection = new MySqlConnection("Server = 219.248.39.216;Database=cccdb;Uid=root;Pwd=root;");//SQL서버 객체 생성
        MySqlCommand command = null;


        public MainUserinfo()
        {
            //자동으로 생성되어 디자인에서 만든 요소와 코드를 연결하고 초기화 해주는 함수
            InitializeComponent();
            
        }

        private void Main_Load(object sender, EventArgs e)
        //폼이 처음으로 표시되기 전에 발생하는 함수
        {
            user_id = getset_UserId;//Login 페이지에서 user_id를 가져오는 라인
            get_member_info();//멤버 테이블의 값을 가져와 박스마다 출력하는 함수
        }
        public static string getset_UserId { get;set; }
        //Login 페이지에서 user_id를 가져오는 라인

        private void get_member_info()
        {
            string name = null;//이름 저장 변수
            string driveType = null;//나이 저장 변수
            string carType = null;//성별 저장 변수
            string age = null;//나이 저장 변수
            string gender = null;//성별 저장 변수
            string region = null;//지역 저장 변수

            try
            {


                connection.Open();//SQL서버와 연결;
                string selectQuery = "SELECT * FROM member_info_tb WHERE user_id = '" + user_id + "';";

                MySqlCommand SelectCommand = new MySqlCommand(selectQuery, connection);
                //MySQL로 명령어를 보내는 클래스

                MySqlDataReader userAcount = SelectCommand.ExecuteReader();
                //아이디가 일치하는 값을 userAcount에 받는다

                while (userAcount.Read())//userAcount를 읽을 동안
                {
                    name = userAcount["member_name"].ToString();//이름값을 string으로 변환, 저장
                    age = userAcount["member_age"].ToString();//나이를 string으로 변환, 저장
                    gender = userAcount["member_gender"].ToString();//성별을 string으로 변환, 저장
                    region = userAcount["member_reg"].ToString();//지역을 string으로 변환, 저장
                    driveType = userAcount["drive_type"].ToString();//주행습관값을 string으로 변환, 저장
                    carType = userAcount["car_type"].ToString();//차량타입값을 string으로 변환, 저장                 
                }
                
                Member_name.Text = name;
                Member_age.Text = age;
                genderCombo.Text = gender;
                Member_add.Text = region;
                driveType_combo.Text = driveType;
                carType_combo.Text = carType;
                //박스에 저장된 값을 출력

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //멤버 테이블의 값을 가져오는 함수

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
        //화면 좌측 사이드바 2번째 해당하는 차량부품 버튼(클릭 시 차량부품 페이지로 이동)
        {
            this.Visible = false;

            Car_comp cc = new Car_comp();

            cc.ShowDialog();
        }

        private void Userinfo_bt_Click(object sender, EventArgs e)
        //화면 좌측 사이드바 3번째 해당하는 사용자 정보 버튼
        {

        }

        private void U_Type1_CheckedChanged(object sender, EventArgs e)
        //주행습관 체크박스(Soft 해당)
        {

        }

        private void U_Type2_CheckedChanged(object sender, EventArgs e)
        //주행습관 체크박스(Normal 해당)
        {

        }

        private void U_Type3_CheckedChanged(object sender, EventArgs e)
        //주행습관 체크박스(Hard 해당)
        {

        }
     
        private void Member_name_TextChanged(object sender, EventArgs e)
        //이름 텍스트 박스//Member_name
        {
            
        }

        private void Member_age_TextChanged(object sender, EventArgs e)
        //나이 텍스트 박스//Member_age
        {

        }

        private void Member_gender_TextChanged(object sender, EventArgs e)
        //성별 텍스트 박스//Member_gender
        {

        }

        private void Member_add_TextChanged(object sender, EventArgs e)
        //주소 텍스트 박스//Member_add
        {

        }

        private void C_type1_SelectedIndexChanged(object sender, EventArgs e)
        //차량 종류 콤보박스 (가솔린,디젤,LPG)//driveType_combo
        {
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //성별 콤보박스//genderCombo
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void Type_bt_Click(object sender, EventArgs e)
        //수정 버튼
        {
            
            if (genderCombo.SelectedItem != null)
            {//빈칸이 아닐경우
                gender = genderCombo.SelectedItem.ToString();//gender변수에 성별 저장
            }
            //성별 콤보박스가 빈칸인지 확인
            if (driveType_combo.SelectedItem != null)
            {//빈칸이 아닐경우
                drive_type = driveType_combo.SelectedItem.ToString();//drive_type변수에 성별 저장
            }
            //운전습관 콤보박스가 빈칸인지 확인
            if (carType_combo.SelectedItem != null)
            {//빈칸이 아닐경우
                car_type = carType_combo.SelectedItem.ToString();//car_type변수에 차량타입 저장
            }
            //차량타입 콤보박스가 빈칸인지 확인

            if (String.IsNullOrEmpty(Member_name.Text)){
                MessageBox.Show("이름을 입력해주세요");
                return;//버튼 클릭 종료
            }
            else if (String.IsNullOrEmpty(Member_age.Text))
            {
                MessageBox.Show("나이를 입력해주세요");
                return;//버튼 클릭 종료
            }
            else if (String.IsNullOrEmpty(gender))
            {
                MessageBox.Show("성별을 선택해주세요");
                return;//버튼 클릭 종료
            }
            else if (String.IsNullOrEmpty(Member_add.Text))
            {
                MessageBox.Show("주소를 입력해주세요");
                return;//버튼 클릭 종료
            }
            else if (String.IsNullOrEmpty(drive_type))
            {
                MessageBox.Show("주행습관을 선택해주세요");
                return;//버튼 클릭 종료
            }
            else if (String.IsNullOrEmpty(car_type))
            {
                MessageBox.Show("차량타입을 선택해주세요");
                return;//버튼 클릭 종료
            }
            //빈칸이 있는지 확인
            //빈칸이 있다면 버튼 클릭 함수 종료


            string updateQuery = "UPDATE MEMBER_INFO_TB " +
                "SET member_name='"+Member_name.Text + "',member_age=" + Int32.Parse(Member_age.Text)
                + ",member_gender='" + gender + "',member_reg='" + Member_add.Text + "',drive_type='" + drive_type
                + "',car_type='" + car_type+"' WHERE user_id="+user_id;
            //회원정보 수정 질의문

            try
            {

                connection.Open();//SQL서버와 연결;
                              
                command = new MySqlCommand(updateQuery, connection);//명령어를 전송
                

               
                if (command.ExecuteNonQuery() == 1)//쿼리가 보내졌을 경우
                {
                    MessageBox.Show("수정 완료");
                    //수정 완료 메세지
                    connection.Close();
                    //DB연결 종료
                }
                else
                {
                    connection.Close();
                    MessageBox.Show("수정 실패");
                }

                }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        private void Car_type_Click(object sender, EventArgs e)
        {

        }

        private void Member_name_LB_Click(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Login main = new Login();

            main.ShowDialog();

            this.Close();
        }
    }
}
