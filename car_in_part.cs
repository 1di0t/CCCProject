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
    public partial class car_in_part : Form
    {
        string connectionString = "Server = 219.248.39.216;Database=cccdb;Uid=root;Pwd=root;";
        private MySqlConnection connection;
        public car_in_part()
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
                    string query = "SELECT * FROM car_in_part_tb";

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

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 주어진 user_id가 데이터베이스에 존재하는지 확인하는 메서드
        private bool IsUserIdExists(string userId)
        {
            try
            {
                // 이미 클래스 레벨에 선언된 connection 사용
                connection.Open();

                // SELECT 쿼리를 생성하고 실행하여 user_id가 존재하는지 확인
                string query = $"SELECT COUNT(*) FROM member_info_tb WHERE user_id = '{userId}'";
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
        private void dataGridView1_SelectionChanged(object sender, EventArgs e) //셀이 선택되었을때
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                txtUserId.Text = selectedRow.Cells["user_id"].Value.ToString();

                if (DateTime.TryParse(selectedRow.Cells["mission_oil"].Value.ToString(), out DateTime missionOilDate))
                {
                    dateTimePicker1.Value = missionOilDate;
                }

                if (DateTime.TryParse(selectedRow.Cells["engine_oil"].Value.ToString(), out DateTime engineOilDate))
                {
                    dateTimePicker2.Value = engineOilDate;
                }

                if (DateTime.TryParse(selectedRow.Cells["break_fluid"].Value.ToString(), out DateTime breakFluidDate))
                {
                    dateTimePicker3.Value = breakFluidDate;
                }

                if (DateTime.TryParse(selectedRow.Cells["coolant"].Value.ToString(), out DateTime coolantDate))
                {
                    dateTimePicker4.Value = coolantDate;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            Admin_login_info ali = new Admin_login_info();

            ali.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) // 수정 버튼
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string newMissionOilDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string newEngineOilDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                string newBreakFluidDate = dateTimePicker3.Value.ToString("yyyy-MM-dd");
                string newCoolantDate = dateTimePicker4.Value.ToString("yyyy-MM-dd");

                string userId = selectedRow.Cells["user_id"].Value.ToString();

                if (IsUserIdExists(userId))
                {
                    try
                    {
                        connection.Open();

                        string query = $"UPDATE car_in_part SET mission_oil = '{newMissionOilDate}', engine_oil = '{newEngineOilDate}', break_fluid = '{newBreakFluidDate}', coolant = '{newCoolantDate}' WHERE user_id = '{userId}'";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();

                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("데이터 업데이트 오류: " + ex.Message);
                    }
                    finally
                    {
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
                MessageBox.Show("수정할 행을 선택하세요.");
            }
        }

        private void button2_Click(object sender, EventArgs e) // 삭제 버튼
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // 사용자에게 삭제 여부를 확인하는 메시지 표시
                DialogResult result = MessageBox.Show("데이터를 삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // DataGridView에서 선택한 행을 가져오기
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // 현재 선택한 행의 user_id 값을 가져옴
                    string userId = selectedRow.Cells["user_id"].Value.ToString();

                    try
                    {
                        // 이미 클래스 레벨에 선언된 connection 사용
                        connection.Open();

                        // DELETE 쿼리를 생성하고 실행 (user_id는 명시하지 않음)
                        string query = $"DELETE FROM car_in_part_tb WHERE user_id = '{userId}'";
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

        private void button3_Click(object sender, EventArgs e) // 추가 버튼
        {
            DateTime newMissionOilDate = dateTimePicker1.Value;
            DateTime newEngineOilDate = dateTimePicker2.Value;
            DateTime newBreakFluidDate = dateTimePicker3.Value;
            DateTime newCoolantDate = dateTimePicker4.Value;
            string userId = txtUserId.Text;

            if (IsUserIdExists(userId))
            {
                try
                {
                    connection.Open();

                    string insertQuery = $"INSERT INTO car_in_part (user_id, mission_oil, engine_oil, break_fluid, coolant) " +
                                        $"VALUES ('{userId}', '{newMissionOilDate.ToString("yyyy-MM-dd")}', '{newEngineOilDate.ToString("yyyy-MM-dd")}', '{newBreakFluidDate.ToString("yyyy-MM-dd")}', '{newCoolantDate.ToString("yyyy-MM-dd")}')";

                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection);
                    insertCmd.ExecuteNonQuery();

                    txtUserId.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                    dateTimePicker2.Value = DateTime.Now;
                    dateTimePicker3.Value = DateTime.Now;
                    dateTimePicker4.Value = DateTime.Now;

                    MessageBox.Show("성공적으로 추가되었습니다.");

                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("에러 메시지: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("참조하는 user_id가 존재하지 않습니다. 먼저 해당 user_id를 추가하세요.");
            }
        }

        private void button4_Click(object sender, EventArgs e) // 부품 추가 버튼
        {
            // 텍스트박스에서 부품 이름을 가져오기
            string newPartName = txtPartName.Text.Trim();

            if (!string.IsNullOrEmpty(newPartName))
            {
                try
                {
                    // 이미 클래스 레벨에 선언된 connection 사용
                    connection.Open();

                    // ALTER TABLE 쿼리를 사용하여 새로운 열을 추가
                    string query = $"ALTER TABLE car_in_part_tb ADD COLUMN {newPartName} DATE";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                    // 부품 추가 후 데이터 다시 로드
                    LoadData();

                    // 텍스트박스 비우기
                    txtPartName.Text = "";

                    MessageBox.Show($"부품 '{newPartName}'을(를) 성공적으로 추가했습니다.");
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
                MessageBox.Show("부품 이름을 입력하세요.");
            }
        }

        private void button6_Click(object sender, EventArgs e) // 부품 삭제 버튼
        {
            // 텍스트박스에서 부품 이름을 가져오기
            string partToRemove = txtPartName.Text.Trim();

            if (!string.IsNullOrEmpty(partToRemove))
            {
                try
                {
                    // 이미 클래스 레벨에 선언된 connection 사용
                    connection.Open();

                    // ALTER TABLE 쿼리를 사용하여 열 삭제
                    string query = $"ALTER TABLE car_in_part_tb DROP COLUMN {partToRemove}";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                    // 부품 삭제 후 데이터 다시 로드
                    LoadData();

                    // 텍스트박스 비우기
                    txtPartName.Text = "";

                    MessageBox.Show($"부품 '{partToRemove}'을(를) 성공적으로 삭제했습니다.");
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
                MessageBox.Show("부품 이름을 입력하세요.");
            }
        }

        private void car_in_part_Load(object sender, EventArgs e) // 폼이 로드되었을 때
        {
            LoadData();
        }
    }
}
