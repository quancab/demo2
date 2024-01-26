using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace th1
{
    public partial class Form3 : Form
    {
        private void LoadDataIntoDataGridView()
        {
            try
            {
                string sqlStr = string.Format("SELECT *FROM GiangVien");
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtSinhVien = new DataTable();
                adapter.Fill(dtSinhVien);
                GiangVien.DataSource = dtSinhVien;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM GiangVien");
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtGIangVien = new DataTable();
                adapter.Fill(dtGIangVien);
                GiangVien.DataSource = dtGIangVien; /// gvHsinh = name cua data gridview
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }

        }
        private void btnthem_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Ket noi
                conn.Open();
                string sqlStr = string.Format("INSERT INTO GiangVien(Ten , Diachi , CMND, ngaysinh) VALUES ('{0}', '{1}' , '{2}','{3}')", txtname.Text, txtaddress.Text, txtCMND.Text, dtpdate.Value);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("them thanh cong");
                LoadDataIntoDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show("them that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
                try
                {
                    // Ket noi
                    conn.Open();
                    string sqlStr = string.Format("DELETE FROM GiangVien WHERE CMND = '{0}'", txtCMND.Text);
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("xoa thanh cong");
                    LoadDataIntoDataGridView();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("xoa that bai" + ex);
                }
                finally
                {
                    conn.Close();
                }
            }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                // Ket noi
                conn.Open();
                string sqlStr = string.Format("UPDATE GiangVien SET Ten = '{0}', Diachi = '{1}', NgaySinh = '{2}' WHERE Cmnd = {3}", txtname.Text, txtaddress.Text,  txtCMND.Text, dtpdate.Value);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("sua thanh cong");
                LoadDataIntoDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show("sua that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void gvHsinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                {
                    // Lấy thông tin từ dòng được chọn
                    DataGridViewRow selectedRow = GiangVien.Rows[e.RowIndex];

                    // Hiển thị thông tin lên các Label
                    txtname.Text = selectedRow.Cells["Ten"].Value.ToString();
                    txtaddress.Text = selectedRow.Cells["Diachi"].Value.ToString();
                    txtCMND.Text = selectedRow.Cells["CMND"].Value.ToString();
                    dtpdate.Value = Convert.ToDateTime(selectedRow.Cells["ngaysinh"].Value);
                }

            }

        private void GiangVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }
    }
    
    
}


