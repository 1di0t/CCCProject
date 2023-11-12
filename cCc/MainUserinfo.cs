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
        }
        public static string getset_UserId { get;set; }
        private bool Is_String_NOT_NULL(string buffer)//받은 값이 널인지 확인하는 함수
        {
            if (buffer != null)
            {
                return true;
            }
            else
            {
                return false;
            }
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
        //차량 종류 콤보박스 (소형,중형,대형)//C_typeBox
        {
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //성별 콤보박스//genderCombo
        {

        }

        private void U_type1_CheckedChanged_1(object sender, EventArgs e)//type_soft//라디오버튼
        {
            drive_type = type_Soft.Text;
        }

        private void type_Normal_CheckedChanged(object sender, EventArgs e)//type_Normal//라디오버튼
        {
            drive_type = type_Normal.Text;
        }

        private void type_Hard_CheckedChanged(object sender, EventArgs e)//type_Hard//라디오버튼
        {
            drive_type = type_Hard.Text;          
        }

        private void Type_bt_Click(object sender, EventArgs e)
        //수정 버튼
        {
            if (genderCombo.SelectedItem != null)//성별 콤보박스가 빈칸인지 확인
            {//빈칸이 아닐경우
                gender = genderCombo.SelectedItem.ToString();//car_type변수에 차량타입 저장
            }//빈칸일 경우
            else
            {
                MessageBox.Show("차량 타입을 선택해 주세요");
            }

            if (C_typeBox.SelectedItem != null)//차량타입 콤보박스가 빈칸인지 확인
            {//빈칸이 아닐경우
                car_type = C_typeBox.SelectedItem.ToString();//car_type변수에 차량타입 저장
            }//빈칸일 경우
            else
            {
                MessageBox.Show("차량 타입을 선택해 주세요");
            }


            string insertQuery = "INSERT INTO MEMBER_INFO_TB VALUES (" 
                + user_id+",'" + Member_name.Text + "'," + Int32.Parse(Member_age.Text) + ",'" + gender+ "','" 
                + Member_add.Text + "','" + drive_type + "','" + car_type + "');";
            //회원정보 삽입 질의문

            try
            {

                connection.Open();//SQL서버와 연결;
                
                if(Is_String_NOT_NULL(Member_name.Text)&&Is_String_NOT_NULL(drive_type)) {//이름과 주행습관이 빈칸이 아닐 때 전송

                    command = new MySqlCommand(insertQuery, connection);//명령어를 전송
                }
                else if(Is_String_NOT_NULL(Member_name.Text))//이름이 빈칸일 경우
                {
                    MessageBox.Show("이름을 입력해주세요");
                }else if (Is_String_NOT_NULL(drive_type))//주행습관이 빈칸일 경우
                {
                    MessageBox.Show("주행습관을 선택해주세요");
                }
                else
                {
                    MessageBox.Show("입력에 실패했습니다");
                }
                if (command.ExecuteNonQuery() == 1)//쿼리가 보내졌을 경우
                {
                    MessageBox.Show("수정 완료");
                    //수정 완료 메세지
                    connection.Close();
                    //DB연결 종료
                }
                else
                {
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


    }
}
