using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QLSV
{
    public partial class Form2 : Form
    {
        DataTable dtSV;
        string flag;
        int index;

        public Form2(string malop)
        {
            this.malop = malop;
            InitializeComponent();

        }
        private string malop;
       
        private void Form2_Load(object sender, EventArgs e)
        {
            blockButton();
            loadData();

        }
        public void loadData() // test danh sách mẫu cho 3 lớp
        {
            if (malop == "NLU0001 ")
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("MaSV");
                dt.Columns.Add("TenSV");
                dt.Columns.Add("SDT");
                StreamReader file = new StreamReader("NLU0001.txt");
                while (!file.EndOfStream)
                {
                    string[] str = file.ReadLine().Split(':');
                    DataRow dr = dt.NewRow();
                    dr["MaSV"] = str[0];
                    dr["TenSV"] = str[1];
                    dr["SDT"] = str[2];
                    dt.Rows.Add(dr);
                }
                dtSV = dt;
                dgvSinhVien.DataSource = dtSV;
                dgvSinhVien.RefreshEdit();
            }
            else if (malop == "NLU0002 ")
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("MaSV");
                dt.Columns.Add("TenSV");
                dt.Columns.Add("SDT");
                StreamReader file = new StreamReader("NLU0002.txt");
                while (!file.EndOfStream)
                {
                    string[] str = file.ReadLine().Split(':');
                    DataRow dr = dt.NewRow();
                    dr["MaSV"] = str[0];
                    dr["TenSV"] = str[1];
                    dr["SDT"] = str[2];
                    dt.Rows.Add(dr);
                }
                dtSV = dt;
                dgvSinhVien.DataSource = dtSV;
                dgvSinhVien.RefreshEdit();
            }
            else if (malop == "NLU0003 ")
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("MaSV");
                dt.Columns.Add("TenSV");
                dt.Columns.Add("SDT");
                StreamReader file = new StreamReader("NLU0003.txt");
                while (!file.EndOfStream)
                {
                    string[] str = file.ReadLine().Split(':');
                    DataRow dr = dt.NewRow();
                    dr["MaSV"] = str[0];
                    dr["TenSV"] = str[1];
                    dr["SDT"] = str[2];
                    dt.Rows.Add(dr);
                }
                dtSV = dt;
                dgvSinhVien.DataSource = dtSV;
                dgvSinhVien.RefreshEdit();
            }

        }
        public bool checkData()
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã số sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenSV.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return false;
            }
            return true;
        }
        public void blockButton()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnQuaylai.Enabled = true;
            txtMaSV.ReadOnly = true;
            txtTenSV.ReadOnly = true;
            txtSDT.ReadOnly = true;
            btnThem.Focus();

        }
        public void unlockButton()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnQuaylai.Enabled = true;
            txtMaSV.ReadOnly = false;
            txtTenSV.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtMaSV.Focus();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            unlockButton();
            flag = "add";
            txtMaSV.Text = "";
            txtTenSV.Text = "";
            txtSDT.Text = "";


        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            unlockButton();
            flag = "edit";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                if (checkData())
                {
                    dtSV.Rows.Add(txtMaSV.Text, txtTenSV.Text,txtSDT.Text);
                    dgvSinhVien.DataSource = dtSV;
                    dgvSinhVien.RefreshEdit();
                }


            }
            else if (flag == "edit")
            {
                if (checkData())
                {
                    dtSV.Rows[0][0] = txtMaSV.Text;
                    dtSV.Rows[0][1] = txtTenSV.Text;
                    dtSV.Rows[0][3] = txtSDT.Text;
                    dgvSinhVien.DataSource = dtSV;
                    dgvSinhVien.RefreshEdit();
                }
            }
            blockButton();

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            index = dgvSinhVien.CurrentCell.RowIndex;
            if (MessageBox.Show("Bạn có muốn xóa lớp này ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dtSV.Rows.RemoveAt(index);
                dgvSinhVien.DataSource = dtSV;
                dgvSinhVien.RefreshEdit();
            }
        }
    
        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn quay lại ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dgvSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            
                if (dgvSinhVien.SelectedRows.Count > 0)
                {
                    txtMaSV.Text = dgvSinhVien.SelectedRows[0].Cells["colMasv"].Value.ToString();
                    txtTenSV.Text = dgvSinhVien.SelectedRows[0].Cells["colTensv"].Value.ToString();
                    txtSDT.Text = dgvSinhVien.SelectedRows[0].Cells["colSodt"].Value.ToString();
            }
            
        }
    }
}
