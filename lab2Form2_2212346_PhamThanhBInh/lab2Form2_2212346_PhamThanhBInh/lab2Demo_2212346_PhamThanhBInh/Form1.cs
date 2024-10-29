using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2Demo_2212346_PhamThanhBInh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblTienTHA_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ReSet();   
        }
        private void ReSet()
        {
            this.cboMaHV.Text = "";
            this.txtHoTen.Text = "";
            this.dtpNgayDangKy.Value = DateTime.Now;
            this.rdNam.Checked = true;
            this.chkTiengAnhA.Checked = false;
            this.chkTiengAnhB.Checked = false;
            this.chkTinHocA.Checked = false;
            this.chkTinHocB.Checked = false;
            this.txtTongTien.Text = "";
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int tien = 0;
            if (chkTinHocA.Checked)
                tien += int.Parse(lblTienTHA.Text.Split('.')[0]);
            if (chkTinHocB.Checked)
                tien += int.Parse(lblTienTHB.Text.Split('.')[0]);
            if (chkTiengAnhA.Checked)
                tien += int.Parse(lblTienTAA.Text.Split('.')[0]);
            if (chkTiengAnhB.Checked)
                tien += int.Parse(lblTienTAB.Text.Split('.')[0]);
            this.txtTongTien.Text = tien + ".000 đồng";
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTongTien_Click(object sender, EventArgs e)
        {
            int tien = 0;
            if (chkTinHocA.Checked)
                tien += int.Parse(lblTienTHA.Text.Split('.')[0]);
            if (chkTinHocB.Checked)
                tien += int.Parse(lblTienTHB.Text.Split('.')[0]);
            if (chkTiengAnhA.Checked)
                tien += int.Parse(lblTienTAA.Text.Split('.')[0]);
            if (chkTiengAnhB.Checked)
                tien += int.Parse(lblTienTAB.Text.Split('.')[0]);
            this.txtTongTien.Text = tien + ".000 đồng";
        }

        private void lblTienTAB_Click(object sender, EventArgs e)
        {

        }

        private void lblTienTAA_Click(object sender, EventArgs e)
        {

        }

        private void lblTienTHB_Click(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkTiengAnhB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkTiengAnhA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkTinHocB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkTinHocA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgayDangKy_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblNgayDangKy_Click(object sender, EventArgs e)
        {

        }

        private void lblHoTen_Click(object sender, EventArgs e)
        {

        }

        private void lblGioiTinh_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cboMaHV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblMaHocVien_Click(object sender, EventArgs e)
        {

        }

        private void lblTrungTam_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
