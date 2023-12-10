using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace cCc

{
    public partial class Car_comp : Form
    {
        private string user_id;//유저 고유번호 저장 변수
        private string car_parts;//차량 부품 이름 저장 변수
        private string car_type;//차량 종류 저장 변수
        private string drive_type;//운전습관 저장 변수
        private string default_age;//기본 교환 주기 저장 변수
        private DateTime replacedDate;//날짜 저장 변수
        private DateTime TodayDate = DateTime.Now;
        bool date_Not_null;//개인 데이터베이스에 날짜 값이 있는지 확인하는 변수
        bool insert_access;

        MySqlConnection connection = new MySqlConnection("Server = 219.248.39.216;Database=cccdb;Uid=root;Pwd=root;");//SQL서버 객체 생성
        MySqlCommand command = null;

        public Car_comp()
        //자동으로 생성되어 디자인에서 만든 요소와 코드를 연결하고 초기화 해주는 함수
        {
            InitializeComponent();
        }

        private void Car_comp_Load(object sender, EventArgs e)
        //폼이 처음으로 표시되기 전에 발생하는 함수
        {
            user_id = getset_UserId;//Login 페이지에서 user_id를 가져오는 라인
            get_member_info();//멤버 테이블의 값을 가져와 이름을 출력하는 함수
        }

        public static string getset_UserId { get; set; }

        private void check_Dupl(string table)
        {
            try
            {
                connection.Open();//SQL서버와 연결;
                string selectQuery = "SELECT user_id FROM CAR_"+table+"_PART_TB WHERE user_id = '" + user_id + "';";

                MySqlCommand SelectCommand = new MySqlCommand(selectQuery, connection);
                //MySQL로 명령어를 보내는 클래스

                MySqlDataReader userAcount = SelectCommand.ExecuteReader();
                //아이디가 일치하는 값을 userAcount에 받는다

                insert_access = true;//로그인 가능 여부를 가능으로 설정한다
                while (userAcount.Read())//userAcount내에 데이터가 있으면 실행
                {
                    insert_access = false;
                    break;
                }
                
                userAcount.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//테이블 내에 컬럼이 있는지 확인하는 함수

        public bool send_Query(string Query)
        {
            try
            {
                connection.Open();//SQL서버와 연결;
                command = new MySqlCommand(Query, connection);//명령어를 전송

                if (command.ExecuteNonQuery() == 1)//쿼리가 보내졌을 경우
                {
                    MessageBox.Show("전송성공");
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

        private void get_member_info()
        {
            string name = null;//이름 저장 변수
           

            try
            {


                connection.Open();//SQL서버와 연결;
                string selectQuery = "SELECT member_name, drive_type, car_type FROM member_info_tb WHERE user_id = '" 
                    + user_id + "';";

                MySqlCommand SelectCommand = new MySqlCommand(selectQuery, connection);
                //MySQL로 명령어를 보내는 클래스

                MySqlDataReader userAcount = SelectCommand.ExecuteReader();
                //아이디가 일치하는 값을 userAcount에 받는다

                while (userAcount.Read())//userAcount를 읽을 동안
                {
                    name = userAcount["member_name"].ToString();//이름값을 string으로 변환, 저장
                    drive_type = userAcount["drive_type"].ToString();//운전 습관값을 string으로 변환, 저장
                    car_type = userAcount["car_type"].ToString();//차량 종류값을 string으로 변환, 저장
                }
                userAcount.Dispose();
                SelectCommand.Dispose();
                label_Name.Text = name;

                //박스에 저장된 값을 출력

            }
            catch
            {
                MessageBox.Show("유저 데이터 로딩 실패");
                return;
            }finally
            {
                connection.Close();
            }
        }
        //멤버 테이블의 값을 가져오는 함수

       private void set_Parts(string selected)
        {
            switch (selected)
            {//select_InCombo에서 선택한 항목에 따라 car_parts에 저장
                case "미션오일":
                    car_parts = "mission_oil";
                    break;
                case "엔진오일":
                    car_parts = "engine_oil";
                    break;
                case "브레이크액":
                    car_parts = "break_fluid";
                    break;
                case "냉각수":
                    car_parts = "coolant";
                    break;
                case "타이어":
                    car_parts = "tire";
                    break;
                case "와이퍼":
                    car_parts = "wiper";
                    break;
                case "브레이크패드":
                    car_parts = "break_pad";
                    break;
            }
        }

        private bool selected_Is_null(ComboBox comboBox)
        {
            if (comboBox.SelectedItem == null)
            {
                MessageBox.Show("부품을 선택해주세요");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void get_DefaultAge()
        {
            string selectQuery = "SELECT " + car_parts + " FROM CAR_PART_DEFAULT"
        + " WHERE car_type = '" + car_type + "' AND drive_type = '" + drive_type + "';";

            connection.Open();//SQL서버와 연결;

            command = new MySqlCommand(selectQuery, connection);
            //MySQL로 명령어를 보내는 클래스
            MySqlDataReader default_Age_Value = command.ExecuteReader();
            //차량타입과 운전습관에 맞는 기본 교환 주기를 가져온다

            while (default_Age_Value.Read())//default_Age_Value를 읽을 동안
            {
                default_age = default_Age_Value[car_parts].ToString();//기본 교환 주기값을 string으로 변환, 저장
            }
            default_Age_Value.Dispose();//default_Age_Value 정리
            command.Dispose();//SelectCommand 정리
            connection.Close();//MySQL과 연결 종료
        }

        private void get_Replaced_Date(string tb_Placed)
        {
            string selectAgeQuery = "SELECT " + car_parts + " FROM CAR_" + tb_Placed + "_PART_TB"
            + " WHERE user_id = '" + user_id + "';";

            connection.Open();//SQL서버와 연결;

            MySqlCommand SelectAgeCommand = new MySqlCommand(selectAgeQuery, connection);
            //MySQL로 명령어를 보내는 클래스
            MySqlDataReader select_Personal_Date = SelectAgeCommand.ExecuteReader();
            //차량타입과 운전습관에 맞는 기본 교환 주기를 가져온다
            date_Not_null = false;//아무 값이 없다고 가정

            while (select_Personal_Date.Read())//select_Personal_Date 읽을 동안
            {//데이터가 있을 경우

                if (select_Personal_Date[car_parts] == DBNull.Value)
                {
                    break;
                }
                replacedDate = (DateTime)select_Personal_Date[car_parts];//날짜값을 DateTime으로 변환, 저장
                date_Not_null = true;//날짜 값이 있다고 변경
            }
            select_Personal_Date.Dispose();//select_Personal_Date 정리
            SelectAgeCommand.Dispose();//SelectDefaultCommand 정리
            connection.Close();//MySQL과 연결 종료
        }

        //===================================================================================================
        //이벤트 함수 시작
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        //이름 라벨//label_Name
        {

        }

        private void parts_Text_Click(object sender, EventArgs e)
        //내부 부품명 라벨//inChanged_Date
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        //내부 부품날짜//
        //
        {

        }

        private void inRemains_Date_Click(object sender, EventArgs e)
        //내부 부품남은기간 라벨//inRemains_Date
        {

        }

        private void outChanged_Date_Click(object sender, EventArgs e)
        //외부 부품날짜 라벨//outChanged_Date
        {

        }

        private void textinChanged_DateBox_TextChanged(object sender, EventArgs e)
        //외부 부품날짜//outChanged_DateBox
        {

        }

        private void outRemains_Date_Click(object sender, EventArgs e)
        //외부 부품남은기간 라벨//outRemains_Date
        {

        }

        private void select_InCombo_SelectedIndexChanged(object sender, EventArgs e)
            //내부 부품 선택 콤보박스//select_InCombo
        {
            
            inParts_Text.Text = select_InCombo.SelectedItem.ToString();
            //부품명에 선택한 항목 출력

            if (selected_Is_null(select_InCombo))
            {
                return;
            }//선택한 항목이 없을 경우 종료
            else
            {//선택한 항목이 있을 경우
                set_Parts(select_InCombo.SelectedItem.ToString());
                //===================================================================================================
                //개인 데이터베이스에 저장된 교환 날짜를 가져온다

                get_Replaced_Date("IN");

                //===================================================================================================
                //날짜 값을 가져온다
                if (date_Not_null == false)//날짜 값이 없을 경우
                {
                    inChanged_DateBox.Value = TodayDate;//DateBox에 오늘 날짜를 출력
                    inRemains_Date.Text = "0일";//남은 기간을 0일로 출력
                    MessageBox.Show("부품 교환 이력이 없습니다");
                }
                else//날짜 값이 있을 경우
                {
                    get_DefaultAge();//기본 교환 주기를 가져온다
                    inChanged_DateBox.Value = replacedDate;//날짜값을 string으로 변환, 저장
                    inRemains_Date.Text = default_age + "일";//기본 교환 주기값을 string으로 변환, 저장
                    //TimeSpan timeSpan = replacedDate - TodayDate;//날짜 차이를 구한다
                    //inRemains_Date.Text = ((int)timeSpan.TotalDays).ToString();//날짜 차이를 int형으로 변환/다시 string으로 변환 후 출력
                }
            }
        }

        private void select_OutCombo_SelectedIndexChanged(object sender, EventArgs e)
            //외부 부품 선택 콤보박스//select_OutCombo
        {
            outParts_Text.Text = select_OutCombo.SelectedItem.ToString();
            //부품명에 선택한 항목 출력

            if (selected_Is_null(select_OutCombo))
            {
                return;
            }//선택한 항목이 없을 경우 종료
            else
            {//선택한 항목이 있을 경우
                set_Parts(select_OutCombo.SelectedItem.ToString());
                //===================================================================================================
                //개인 데이터베이스에 저장된 교환 날짜를 가져온다

                get_Replaced_Date("EX");

                //===================================================================================================
                if (date_Not_null == false)//날짜 값이 없을 경우
                {
                    outChanged_DateBox.Value = TodayDate;//DateBox에 오늘 날짜를 출력
                    outRemains_Date.Text = "0일";//남은 기간을 0일로 출력
                    MessageBox.Show("부품 교환 이력이 없습니다");
                }
                else//날짜 값이 있을 경우
                {
                    get_DefaultAge();//기본 교환 주기를 가져온다
                    outChanged_DateBox.Value = replacedDate;//날짜값을 string으로 변환, 저장
                    outRemains_Date.Text = default_age + "일";//기본 교환 주기값을 string으로 변환, 저장
                }
            }

        }

        private void select_InBtn_Click(object sender, EventArgs e)
            //내부 부품 조회 버튼//select_InBtn
        {

        }

        private void add_OutBtn_Click(object sender, EventArgs e)
            //내부 부품 추가 버튼//add_OutBtn
        {
            if (selected_Is_null(select_InCombo))
            {
                return;
            }else
            {
                set_Parts(select_InCombo.SelectedItem.ToString());
            }
            DateTime insertDate = inChanged_DateBox.Value;
            check_Dupl("IN");
            if (insert_access == true)//날짜 데이터가 없을 경우
            {
                
               string insertQuery = "INSERT INTO CAR_IN_PART_TB (user_id, " + car_parts + ") VALUES (" 
                    + user_id + ", '" + insertDate.ToString("yyyyMMdd") + "');";
                if (send_Query(insertQuery)) MessageBox.Show("교환 반영 완료");
                insert_access = false;
            }
            else//날짜 데이터가 있을 경우
            {
                string updateQuery = "UPDATE CAR_IN_PART_TB SET " + car_parts + " = "
                 + insertDate.ToString("yyyyMMdd") + " where user_id =" + user_id + ";";
                send_Query(updateQuery);
            }

        }

        private void select_OutBtn_Click(object sender, EventArgs e)
            //외부 부품 조회 버튼//select_OutBtn
        {
            
        }

        private void add_OuBtn_Click(object sender, EventArgs e)
            //외부 부품 추가 버튼//add_OuBtn
        {

            if (selected_Is_null(select_OutCombo))
            {
                return;
            }
            else
            {
                set_Parts(select_OutCombo.SelectedItem.ToString());
            }
            DateTime insertDate = outChanged_DateBox.Value;
            check_Dupl("EX");
            if (insert_access == true)//날짜 데이터가 없을 경우
            {

                string insertQuery = "INSERT INTO CAR_EX_PART_TB (user_id, " + car_parts + ") VALUES ("
                     + user_id + ", '" + insertDate.ToString("yyyyMMdd") + "');";
                if (send_Query(insertQuery)) MessageBox.Show("교환 반영 완료");//인서트 쿼리를 보내고 메시지 출력
                insert_access = false;
            }
            else//날짜 데이터가 있을 경우
            {
                string updateQuery = "UPDATE CAR_EX_PART_TB SET " + car_parts + " = "
                 + insertDate.ToString("yyyyMMdd") + " where user_id =" + user_id + ";";
                if(send_Query(updateQuery)) MessageBox.Show("수정 완료");//업데이트 쿼리를 보내고 메세지 출력
            }

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Login main = new Login();

            main.ShowDialog();

            this.Close();
        }
    }
}
