using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace cCc
{
    public partial class Admin_login_info : Form
    {
        string connectionString = "Server = 219.248.39.216;Database=cccdb;Uid=root;Pwd=root;";
        private MySqlConnection connection;

        public Admin_login_info()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }
        private void LoadData() //테이블 로드
        {
            try
            {
                // MySqlConnection을 using 문을 통해 선언하고 초기화하여 자동으로 리소스를 해제할 수 있도록 함
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // 데이터베이스 연결 열기
                    connection.Open();

                    // 데이터베이스에서 모든 레코드를 선택하는 쿼리 문자열
                    string query = "SELECT * FROM login_info_tb";

                    // MySqlCommand를 사용하여 쿼리와 연결을 설정
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    // 데이터를 채우기 위한 MySqlDataAdapter 선언
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

                    // 데이터를 담을 DataTable을 생성
                    DataTable dataTable = new DataTable();

                    // 데이터 어댑터를 사용하여 데이터베이스에서 데이터를 가져와 DataTable에 채움
                    dataAdapter.Fill(dataTable);

                    // DataGridView에 DataTable을 데이터 소스로 설정하여 화면에 데이터를 표시
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                // 오류 발생 시 메시지 박스에 오류 메시지 출력
                MessageBox.Show("오류: " + ex.Message);
            }
        }
        private void Admin_login_info_Load(object sender, EventArgs e) //폼이 로드되면 테이블 조회
        {
            LoadData();
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e) //테이블의 데이터가 선택 되었을때
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // DataGridView에서 선택한 첫 번째 행을 가져오기
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // 선택한 행의 각 열의 값을 텍스트 박스에 설정
                labelUserId.Text = selectedRow.Cells["user_id"].Value.ToString();
                txtLoginId.Text = selectedRow.Cells["login_id"].Value.ToString();
                txtLoginPw.Text = selectedRow.Cells["login_pw"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["email"].Value.ToString();
            }
        }

        private bool IsLoginId(string loginId, string userIdToExclude) // 로그인 아이디 중복 확인
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // 중복된 로그인 ID를 검색하는 쿼리 문자열
                    string query = $"SELECT COUNT(*) FROM login_info_tb WHERE login_id = '{loginId}' AND user_id != '{userIdToExclude}'";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    // 중복된 로그인 ID가 존재하는지 확인
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count == 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류: " + ex.Message);
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e) // 수정 버튼
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // DataGridView에서 선택한 첫 번째 행을 가져오기
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // 수정할 데이터를 텍스트 박스에서 가져와서 필요에 따라 수정
                string newLoginId = txtLoginId.Text;
                string newLoginPw = txtLoginPw.Text;
                string newEmail = txtEmail.Text;

                // Check for duplicate login_id before updating
                if (IsLoginId(newLoginId, selectedRow.Cells["user_id"].Value.ToString()))
                {
                    // 현재 선택한 행의 각 열에 대해 새로운 값을 설정
                    selectedRow.Cells["login_id"].Value = newLoginId;
                    selectedRow.Cells["login_pw"].Value = newLoginPw;
                    selectedRow.Cells["email"].Value = newEmail;

                    // 수정된 데이터를 MySQL에 반영하는 쿼리 실행
                    try
                    {
                        // 이미 클래스 레벨에 선언된 connection 사용
                        connection.Open();

                        // UPDATE 쿼리를 생성하고 실행
                        string query = $"UPDATE login_info_tb SET login_id = '{newLoginId}', login_pw = '{newLoginPw}', email = '{newEmail}' WHERE user_id = '{selectedRow.Cells["user_id"].Value}'";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();

                        // 수정 후 데이터 다시 로드
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("오류 메시지 : " + ex.Message);
                    }
                    finally
                    {
                        // 이미 클래스 레벨에 선언된 connection 사용
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("이미 존재하는 로그인 ID입니다. 다른 값을 시도하세요.");
                }
            }
            else
            {
                MessageBox.Show("다시 한번 확인해주세요.");
            }
        }

        private void button2_Click(object sender, EventArgs e) //삭제 버튼
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // 사용자에게 삭제 여부를 확인하는 메시지 표시
                DialogResult result = MessageBox.Show("데이터를 삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // DataGridView에서 선택한 행을 가져오기
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    try
                    {
                        // 이미 클래스 레벨에 선언된 connection 사용
                        connection.Open();

                        // DELETE 쿼리를 생성하고 실행 (user_id는 명시하지 않음)
                        string query = $"DELETE FROM login_info_tb WHERE user_id = '{selectedRow.Cells["user_id"].Value}'";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();

                        // 선택된 행을 DataGridView에서 제거
                        dataGridView1.Rows.Remove(selectedRow);

                        MessageBox.Show("삭제 완료");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("삭제 오류: " + ex.Message);
                    }
                    finally
                    {
                        // 이미 클래스 레벨에 선언된 connection 사용
                        connection.Close();
                    }
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)// 추가 버튼
        {
            // 새로운 사용자 정보를 텍스트 박스에서 가져오기
            string newLoginId = txtLoginId.Text;
            string newLoginPw = txtLoginPw.Text;
            string newEmail = txtEmail.Text;

            // Check for duplicate login_id before inserting
            if (IsLoginId(newLoginId, ""))
            {
                // 데이터베이스에 레코드 추가
                try
                {
                    // 이미 클래스 레벨에 선언된 connection 사용
                    connection.Open();

                    if (!string.IsNullOrEmpty(newLoginId) && !string.IsNullOrEmpty(newLoginPw)) //로그인아이디와 로그인패스워드가 널값이 아니면
                    {
                        // INSERT 쿼리를 생성하고 실행
                        string query = $"INSERT INTO login_info_tb (login_id, login_pw, email) VALUES ('{newLoginId}', '{newLoginPw}', '{newEmail}')";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();

                        // 데이터 추가 후 텍스트 박스 비우기
                        txtLoginId.Text = "";
                        txtLoginPw.Text = "";
                        txtEmail.Text = "";

                        MessageBox.Show("성공적으로 추가되었습니다.");

                        // 데이터 다시 로드
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("값을 다시 확인해주세요.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("에러 메시지: " + ex.Message);
                }
                finally
                {
                    // 이미 클래스 레벨에 선언된 connection 사용
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("이미 존재하는 로그인 ID입니다. 다른 값을 시도하세요.");
            }
        }

        private void exit_Click(object sender, EventArgs e) //종료버튼
        {
            Application.Exit();
        }

        private void Login_Info_BT_Click(object sender, EventArgs e) // 로그인 인포(새로고침) 버튼
        {
            LoadData();
        }

        private void Member_Info_BT_Click(object sender, EventArgs e) // 멤버 인포 버튼
        {
            Admin_member_info ami = new Admin_member_info();

            ami.Show();

            this.Close();
        }

        private void Car_In_BT_Click(object sender, EventArgs e) // 차량 내부 부품 버튼
        {
            car_in_part cip = new car_in_part();

            cip.Show();

            this.Close();
        }

        private void Car_Ex_BT_Click(object sender, EventArgs e) // 차량 외부 부품 버튼
        {
            car_ex_part cep = new car_ex_part();

            cep.Show();

            this.Close();
        }

        private void HomeButton_Click(object sender, EventArgs e) // 로그인 화면 돌아가기 버튼
        {
            Login main = new Login();

            main.Show();

            this.Close();
        }
    }
}
