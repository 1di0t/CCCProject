using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace cCc
{
    public partial class MainPage : Form
    {
        private string user_id;
        private string drive_type;
        private string car_type;
        private string noneData = "데이터 없음";

        private bool checkInData_Exsist;
        private bool checkExData_Exsist;

        private DateTime mission_oil;
        private DateTime engine_oil;
        private DateTime break_fluid;
        private DateTime coolant;
        private DateTime tire;
        private DateTime wiper;
        private DateTime break_pad;

        private int mission_oil_Default;
        private int engine_oil_Default;
        private int break_fluid_Default;
        private int coolant_Default;
        private int tire_Default;
        private int wiper_Default;
        private int break_pad_Default;

        private DateTime currentDate = DateTime.Now;

        MySqlConnection connection = new MySqlConnection("Server = 219.248.39.216;Database=cccdb;Uid=root;Pwd=root;");//SQL서버 객체 생성
        MySqlCommand command = null;

        public static string getset_UserId{get;set;}


        public MainPage()
        //자동으로 생성되어 디자인에서 만든 요소와 코드를 연결하고 초기화 해주는 함수
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        //폼이 처음으로 표시되기 전에 발생하는 함수
        {
            user_id = getset_UserId;//Login 페이지에서 user_id를 가져오는 라인
            get_member_info();//멤버 테이블의 운전 습관, 차량 종류 값을 가져오는 함수
            get_DefaultAge();//차량 부품의 기본 교환 주기를 가져오는 함수
            get_In_Parts();//차량외부 부품의 교환주기를 가져오는 함수
            get_Ex_Parts();//차량내부 부품의 교환주기를 가져오는 함수
            set_In_Parts();            
            set_Out_Parts();

        }

        private void get_In_Parts() {
            try
            {
                connection.Open();
                string selectQuery = "SELECT * FROM car_in_part_tb WHERE user_id = '" + user_id + "';";
                command = new MySqlCommand(selectQuery, connection);
                //MySQL로 명령어를 보내는 클래스

                MySqlDataReader userParts = command.ExecuteReader();
                //아이디가 일치하는 값을 userAcount에 받는다
                checkInData_Exsist = false;
                while (userParts.Read())//userAcount내에 데이터가 있으면 실행
                {
                    mission_oil = userParts.GetDateTime("mission_oil");
                    engine_oil= userParts.GetDateTime("engine_oil");
                    break_fluid= userParts.GetDateTime("break_fluid");
                    coolant = userParts.GetDateTime("coolant");
                    checkInData_Exsist = true;
                }

            }
            catch{ }
            finally { command.Dispose(); connection.Close(); }
        }
        private void get_Ex_Parts() {
            try
            {
                connection.Open();
                string selectQuery = "SELECT * FROM car_ex_part_tb WHERE user_id = '" + user_id + "';";
                command = new MySqlCommand(selectQuery, connection);
                //MySQL로 명령어를 보내는 클래스

                MySqlDataReader userParts = command.ExecuteReader();
                //아이디가 일치하는 값을 userAcount에 받는다
                checkExData_Exsist = false;
                while (userParts.Read())//userAcount내에 데이터가 있으면 실행
                {
                    tire = userParts.GetDateTime("tire");
                    wiper = userParts.GetDateTime("wiper");
                    break_pad = userParts.GetDateTime("break_pad");
                    checkExData_Exsist = true;
                }
            }
            catch {  }
            finally { command.Dispose(); connection.Close(); }
        }

        private void get_member_info()//사용자 정보를 가져오는 함수//drive_type, car_type
        {

            try
            {


                connection.Open();//SQL서버와 연결;
                string selectQuery = "SELECT  drive_type, car_type FROM member_info_tb WHERE user_id = '"
                    + user_id + "';";

                command = new MySqlCommand(selectQuery, connection);
                //MySQL로 명령어를 보내는 클래스

                MySqlDataReader userAcount = command.ExecuteReader();
                //아이디가 일치하는 값을 userAcount에 받는다

                while (userAcount.Read())//userAcount를 읽을 동안
                {
                    drive_type = userAcount["drive_type"].ToString();//운전 습관값을 string으로 변환, 저장
                    car_type = userAcount["car_type"].ToString();//차량 종류값을 string으로 변환, 저장
                }
                userAcount.Dispose();
                command.Dispose();
            }
            catch
            {
                MessageBox.Show("유저 데이터 로딩 실패");
                return;
            }
            finally
            {
                connection.Close();
            }
        }

        private void get_DefaultAge()
        {
            string selectQuery = "SELECT * FROM CAR_PART_DEFAULT"
        + " WHERE car_type = '" + car_type + "' AND drive_type = '" + drive_type + "';";

            connection.Open();//SQL서버와 연결;

            command = new MySqlCommand(selectQuery, connection);
            //MySQL로 명령어를 보내는 클래스
            MySqlDataReader default_Age_Value = command.ExecuteReader();
            //차량타입과 운전습관에 맞는 기본 교환 주기를 가져온다

            while (default_Age_Value.Read())//default_Age_Value를 읽을 동안
            {
                mission_oil_Default = (int)default_Age_Value["mission_oil"];//미션오일 기본 교환 주기를 string으로 변환, 저장
                engine_oil_Default = (int)default_Age_Value["engine_oil"];//엔진오일 기본 교환 주기를 string으로 변환, 저장
                break_fluid_Default = (int)default_Age_Value["break_fluid"];//브레이크 액 기본 교환 주기를 string으로 변환, 저장
                coolant_Default = (int)default_Age_Value["coolant"];//냉각수 기본 교환 주기를 string으로 변환, 저장
                tire_Default = (int)default_Age_Value["tire"];//타이어 기본 교환 주기를 string으로 변환, 저장
                wiper_Default = (int)default_Age_Value["wiper"];//와이퍼 기본 교환 주기를 string으로 변환, 저장
                break_pad_Default = (int)default_Age_Value["break_pad"];//브레이크 패드 기본 교환 주기를 string으로 변환, 저장
            }
            default_Age_Value.Dispose();//default_Age_Value 정리
            command.Dispose();//SelectCommand 정리
            connection.Close();//MySQL과 연결 종료
        }

        private TimeSpan calculate_RemainDate(int defualtDate, DateTime userDate)
        {//남은 날짜를 계산하는 함수//사용자가 입력한 교환날짜에 기본주기를 더한후 현재 날짜를 뺀다
            return userDate.AddDays(defualtDate) - currentDate;
        }

        private void set_In_Parts() {
            if (mission_oil < currentDate.AddDays(-7200)) { missionOil_Date.Text = noneData; }//교환날짜가 20년보다 전이면 데이터 없음 출력
            else { missionOil_Date.Text = $"D-{calculate_RemainDate(mission_oil_Default, mission_oil).Days}"; }//아니면 교환날짜에 기본주기를 더한후 현재 날짜를 뺀다
            //타이어 날짜 표시

            if (engine_oil < currentDate.AddDays(-7200)) { engineOil_Date.Text = noneData; }
            else { engineOil_Date.Text = $"D-{calculate_RemainDate(engine_oil_Default, engine_oil).Days}"; }
            //엔진오일 날짜 표시

            if (break_fluid < currentDate.AddDays(-7200)) { breakFluid_Date.Text = noneData; }
            else { breakFluid_Date.Text = $"D-{calculate_RemainDate(break_fluid_Default, break_fluid).Days}"; }
            //브레이크 액 날짜 표시

            if (coolant < currentDate.AddDays(-7200)) { coolant_Date.Text = noneData; }
            else { coolant_Date.Text = $"D-{calculate_RemainDate(coolant_Default, coolant).Days}"; }
            //냉각수 날짜 표시   

        }
        private void set_Out_Parts() {
            if(tire < currentDate.AddDays(-7200)) { tire_Date.Text = noneData; }//교환날짜가 20년보다 전이면 데이터 없음 출력
            else{tire_Date.Text = $"D-{calculate_RemainDate(tire_Default, tire).Days}";}//아니면 교환날짜에 기본주기를 더한후 현재 날짜를 뺀다
            //타이어 날짜 표시
            if (wiper < currentDate.AddDays(-7200)) { wiper_Date.Text = noneData; }
            else { wiper_Date.Text = $"D-{calculate_RemainDate(wiper_Default, wiper).Days}"; }
            //와이퍼 날짜 표시
            if (break_pad < currentDate.AddDays(-7200)){ breakPad_Date.Text = noneData; }
            else { breakPad_Date.Text = $"D-{calculate_RemainDate(break_pad_Default, break_pad).Days}"; }
            //브레이크 패드 날짜 표시
        }

        //==================================================================================================

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
