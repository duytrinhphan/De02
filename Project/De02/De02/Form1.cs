using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De02
{
    public partial class Form1 : Form
    {
        Model1 conn = new Model1();
        List<Sanpham> listsp;

        public Form1()
        {
            InitializeComponent();
        }

        public void ListCategory(List<LoaiSP> listcategory)
        {
            cb_Category.DataSource = listcategory;
            cb_Category.DisplayMember = "TenLoai";
            cb_Category.ValueMember = "MaLoai";
        }

        public void ListSP(List<Sanpham> listsp)
        {
            lsv_Show.Items.Clear();
            foreach (Sanpham item in listsp)
            {
                ListViewItem lv = new ListViewItem(item.MaSP);
                lv.SubItems.Add(item.TenSP);
                lv.SubItems.Add(item.Ngaynhap.ToString());
                lv.SubItems.Add(item.MaLoai);
                lv.Tag = item;
                lsv_Show.Items.Add(lv);
            }
        }

        public void Update(List<Sanpham> listSanPham)
        {
            lsv_Show.Items.Clear();
            foreach (Sanpham sp in listSanPham)
            {
                ListViewItem lv = new ListViewItem(sp.MaSP);
                lv.SubItems.Add(sp.TenSP);
                lv.SubItems.Add(sp.Ngaynhap.ToString());
                lv.SubItems.Add(sp.MaLoai);
                lsv_Show.Items.Add(lv);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listsp = conn.Sanphams.ToList();
            List<LoaiSP> listcategory = conn.LoaiSPs.ToList();
            ListCategory(listcategory);
            ListSP(listsp);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string masp = txt_ID.Text;
                Sanpham them = conn.Sanphams.FirstOrDefault(s => s.MaSP == masp);

                if (them == null)
                {
                    Sanpham sp = new Sanpham()
                    {
                        MaSP = txt_ID.Text,
                        TenSP = txt_Name.Text,
                        Ngaynhap = DateTime.Parse(dtpk_Date.Text),
                        MaLoai = cb_Category.SelectedValue.ToString(),
                    };
                    conn.Sanphams.Add(sp);
                    conn.SaveChanges();
                    ListSP(conn.Sanphams.ToList());
                    MessageBox.Show("Thêm dữ liệu thành công!");
                }
                else
                {
                    MessageBox.Show("Dữ liệu đã tồn tại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (lsv_Show.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = lsv_Show.SelectedItems[0];
                Sanpham delete = selectedRow.Tag as Sanpham;
                if (delete != null)
                {
                    conn.Sanphams.Remove(delete);
                    conn.SaveChanges();
                    lsv_Show.Items.Remove(selectedRow);
                    MessageBox.Show("Xóa thành công!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa!");
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                string masp = txt_ID.Text.Trim();
                if (string.IsNullOrEmpty(masp))
                {
                    MessageBox.Show("Vui lòng nhập mã sản phẩm!");
                    return;
                }

                Sanpham sp = conn.Sanphams.FirstOrDefault(s => s.MaSP == masp);

                if (sp != null)
                {
                    sp.TenSP = txt_Name.Text;
                    sp.Ngaynhap = DateTime.Parse(dtpk_Date.Text);
                    sp.MaLoai = cb_Category.SelectedValue.ToString();
                    conn.SaveChanges();
                    Update(conn.Sanphams.ToList());
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Dữ liệu không tồn tại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}