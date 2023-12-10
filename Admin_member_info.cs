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
    public partial class Admin_member_info : Form
    {
        string connectionString = "Server = 219.248.39.216;Database=cccdb;Uid=root;Pwd=root;";
        private MySqlConnection connection;
        public Admin_member_info()
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
                    string query = "SELECT * FROM member_info_tb";

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
        private void Admin_member_info_Load(object sender, EventArgs e) //폼이 로드되면 테이블 조회
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
                txtUserId.Text = selectedRow.Cells["user_id"].Value.ToString();
                txtMemberName.Text = selectedRow.Cells["member_name"].Value.ToString();
                txtMemberAge.Text = selectedRow.Cells["member_age"].Value.ToString();
                txtMemberGender.Text = selectedRow.Cells["member_gender"].Value.ToString();
                txtMemberReg.Text = selectedRow.Cells["member_reg"].Value.ToString();
                txtDriveType.Text = selectedRow.Cells["drive_type"].Value.ToString();
                txtCarType.Text = selectedRow.Cells["car_type"].Value.ToString();
            }
        }
        private void exit_Click(object sender, EventArgs e) //종료버튼
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e) // 수정 버튼
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // DataGridView에서 선택한 첫 번째 행을 가져오기
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // 수정할 데이터를 텍스트 박스에서 가져와서 필요에 따라 수정
                string newMemberName = txtMemberName.Text;
                string newMemberAge = txtMemberAge.Text;
                string newMemberGender = txtMemberGender.Text;
                string newMemberReg = txtMemberReg.Text;
                string newDriveType = txtDriveType.Text;
                string newCarType = txtCarType.Text;

                // 현재 선택한 행의 user_id 값을 가져옴
                string userId = selectedRow.Cells["user_id"].Value.ToString();

                // 데이터베이스에 해당 user_id가 있는지 확인
                if (IsUserIdExists(userId))
                {
                    // 수정된 데이터를 MySQL에 반영하는 쿼리 실행
                    try
                    {
                        // 이미 클래스 레벨에 선언된 connection 사용
                        connection.Open();

                        // UPDATE 쿼리를 생성하고 실행
                        string query = $"UPDATE member_info_tb SET member_name = '{newMemberName}', member_age = '{newMemberAge}', member_gender = '{newMemberGender}', member_reg = '{newMemberReg}', drive_type = '{newDriveType}', car_type = '{newCarType}' WHERE user_id = '{userId}'";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();

                        // 수정 후 데이터 다시 로드
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating data: " + ex.Message);
                    }
                    finally
                    {
                        // 이미 클래스 레벨에 선언된 connection 사용
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("해당 user_id가 존재하지 않습니다.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void button3_Click(object sender, EventArgs e) // 추가 버튼
        {
            // 새로운 사용자 정보를 텍스트 박스에서 가져오기
            string newMemberName = txtMemberName.Text;
            string newMemberAge = txtMemberAge.Text;
            string newMemberGender = txtMemberGender.Text;
            string newMemberReg = txtMemberReg.Text;
            string newDriveType = txtDriveType.Text;
            string newCarType = txtCarType.Text;
            string userId = txtUserId.Text;

            // 데이터베이스에 해당 user_id가 있는지 확인
            if (IsUserIdExists(userId))
            {
                try
                {
                    // 이미 클래스 레벨에 선언된 connection 사용
                    connection.Open();

                    // INSERT 쿼리를 생성하고 실행
                    string insertQuery = $"INSERT INTO member_info_tb (user_id, member_name, member_age, member_gender, member_reg, drive_type, car_type) " +
                                        $"VALUES ('{userId}', '{newMemberName}', '{newMemberAge}', '{newMemberGender}', '{newMemberReg}', '{newDriveType}', '{newCarType}')";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection);
                    insertCmd.ExecuteNonQuery();

                    // 데이터 추가 후 텍스트 박스 비우기
                    txtMemberName.Text = "";
                    txtMemberAge.Text = "";
                    txtMemberGender.Text = "";
                    txtMemberReg.Text = "";
                    txtDriveType.Text = "";
                    txtCarType.Text = "";

                    MessageBox.Show("성공적으로 추가되었습니다.");

                    // 데이터 다시 로드
                    LoadData();
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
                MessageBox.Show("참조하는 user_id가 존재하지 않습니다. 먼저 해당 user_id를 추가하세요.");
            }
        }

        // 주어진 user_id가 데이터베이스에 존재하는지 확인하는 메서드
        private bool IsUserIdExists(string userId)
        {
            try
            {
                // 이미 클래스 레벨에 선언된 connection 사용
                connection.Open();

                // SELECT 쿼리를 생성하고 실행하여 user_id가 존재하는지 확인
                string query = $"SELECT COUNT(*) FROM login_info_tb WHERE user_id = '{userId}'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("에러 메시지: " + ex.Message);
                return false;
            }
            finally
            {
                // 이미 클래스 레벨에 선언된 connection 사용
                connection.Close();
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
                        string query = $"DELETE FROM member_info_tb WHERE user_id = '{selectedRow.Cells["user_id"].Value}'";
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

        private void Login_Info_BT_Click(object sender, EventArgs e)// 로그인 인포 버튼
        {
            this.Visible = false;

            Admin_login_info ali = new Admin_login_info();

            ali.ShowDialog();
        }

        private void Member_Info_BT_Click(object sender, EventArgs e)// 멤버 인포(새로고침) 버튼
        {
            LoadData();
        }

        private void Car_In_BT_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            car_in_part cip = new car_in_part();

            cip.ShowDialog();
        }

        private void Car_Ex_BT_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            car_ex_part cep = new car_ex_part();

            cep.ShowDialog();
        }

    }
}
