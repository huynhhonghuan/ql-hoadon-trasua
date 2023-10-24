using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmChinhSuaHoaDon : Form
    {
        private string id;
        private string id_bill;
        private string name_table;

        public event EventHandler OK_Click;
        public frmChinhSuaHoaDon(string id, string id_bill, string name_table)
        {
            InitializeComponent();
            this.id = id;
            this.id_bill = id_bill;
            this.name_table = name_table;
            B_chitiethoadon.Instance.Load(id_bill, name_table);
        }
        DataTable dt = B_chitiethoadon.Instance.Load_ComboBox();
        private void frmChinhSuaHoaDon_Load(object sender, EventArgs e)
        {

            cbbTenSP.DataSource = dt;
            cbbTenSP.DisplayMember = "name_product";
            cbbTenSP.ValueMember = "id_product";

            dataGridView1.DataSource = B_chitiethoadon.Instance.Load(id_bill, name_table);
            dataGridView1.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            if (name_table == "detail_bill")
            {
                dataGridView1.Columns["Id_bill"].Visible = false;
                dataGridView1.Columns["Id_detail_bill"].Visible = false;
                dataGridView1.Columns["STT"].Width = 30;
                dataGridView1.Columns["Name_product"].HeaderText = "Tên sản phẩm";
                dataGridView1.Columns["Name_product"].Width =130;
                dataGridView1.Columns["Quantity"].HeaderText = "Số lượng";
                dataGridView1.Columns["Id_discount"].HeaderText = "Giảm giá(%)";
                dataGridView1.Columns["Total"].HeaderText = "Đơn giá";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataRow dr = B_chitiethoadon.Instance.table(name_table).NewRow();
            dr["id_bill"] = id_bill;
            dr["id_product"] = cbbTenSP.SelectedValue;
            dr["quantity"] = txtSL.Texts;
            dr["id_discount"] = txtGiam.Texts;
            dr["total"] = txtDongia.Texts;
            B_chitiethoadon.Instance.table(name_table).Rows.Add(dr);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int dongchon = -1;
            dongchon = dataGridView1.CurrentRow.Index;
            if (dongchon >= 0)
            {
                string madongchon = dataGridView1.Rows[dongchon].Cells[id].Value.ToString();
                DataRow[] dr = B_chitiethoadon.Instance.table(name_table).Select("" + id + " ='" + madongchon + "'");
                dr[0]["id_bill"] = id_bill;
                dr[0]["id_product"] = cbbTenSP.SelectedValue;
                dr[0]["quantity"] = txtSL.Texts;
                dr[0]["id_discount"] = txtGiam.Texts;
                dr[0]["total"] = txtDongia.Texts;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int dongchon = -1;
            dongchon = dataGridView1.CurrentRow.Index;
            if (dongchon >= 0)
            {
                //kiểm tra nếu số lượng mã k đồng nhất số lượng
                B_chitiethoadon.Instance.table(name_table).PrimaryKey = new DataColumn[] { B_chitiethoadon.Instance.table(name_table).Columns[id] };
                DataRow drr = B_chitiethoadon.Instance.table(name_table).Rows.Find(dataGridView1.Rows[dongchon].Cells[id].Value.ToString());
                drr.Delete();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            B_chitiethoadon.Instance.Insert(name_table);
            B_chitiethoadon.Instance.Update(name_table, id);
            B_chitiethoadon.Instance.Delete(name_table, id);
            this.BindingContext[B_chitiethoadon.Instance.table(name_table)].EndCurrentEdit();
            if (B_chitiethoadon.Instance.dataset().HasChanges() == true)
            {
                try
                {
                    B_chitiethoadon.Instance.adapter().Update(B_chitiethoadon.Instance.table(name_table));
                    frmChinhSuaHoaDon_Load(sender, e);
                }
                catch (Exception x) { MessageBox.Show(x.Message); }
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
            OK_Click(sender, new EventArgs());
        }

        private void cbbTenSP_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["id_product"].ToString() == cbbTenSP.SelectedValue.ToString())
                {
                    txtDongia.Texts = string.Format("{0:d5}", dr["fare"].ToString());
                    return;
                }
            }
        }
        int vitri;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri= dataGridView1.CurrentRow.Index;
            DataGridViewRow dr = dataGridView1.Rows[vitri];
            foreach (DataRow dr2 in dt.Rows)
            {
                if (dr.Cells["id_product"].Value.ToString() == dr2["id_product"].ToString())
                {
                    cbbTenSP.Text = dr2["name_product"].ToString();
                    txtSL.Texts = dr.Cells["quantity"].Value.ToString();
                    txtGiam.Texts = dr.Cells["id_discount"].Value.ToString();
                    return;
                }
            }
        }
    }
}
