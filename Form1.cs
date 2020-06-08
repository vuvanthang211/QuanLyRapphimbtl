using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using COMExcel = Microsoft.Office.Interop.Excel;
using QuanLyRapPhim;

namespace QuanLyRapPhim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillDataToCombo2();
            LoadDataToGridView();
          
        }
      
        private void LoadDataToGridView()
        {
            DAO.OpenConnection();
            
            string sql = "select a.TenPhim, b.TenRap from tblPhim a join tblLichChieu c on a.MaPhim = c.MaPhim join tblRap b on c.MaRap = b.MaRap "
                + " where a.MaPhim = N'" + cboTenbophim.SelectedValue + "'and b.MaRap = N'" + cboTenrapphim.SelectedValue +"'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            gridviewDoanhthubanhang.DataSource = table;
        }

        private void FillDataToCombo2()
        {
            DAO.OpenConnection();

            DAO.FillDataToCombo("SELECT MaPhim,TenPhim FROM tblPhim ", cboTenbophim, "MaPhim", "TenPhim");
            cboTenbophim.SelectedIndex = -1;


            DAO.FillDataToCombo("SELECT MaRap, TenRap  FROM tblRap ", cboTenrapphim, "MaRap", "TenRap");

            cboTenrapphim.SelectedIndex = -1;

            DAO.CloseConnection();
        }


        private void indoanhthu_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblPhim;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:D1"].Font.Size = 13;
            exRange.Range["A1:D1"].Font.Name = "Times new roman";
            exRange.Range["A1:D1"].Font.Bold = true;
            exRange.Range["A1:D1"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:D1"].MergeCells = true;
            exRange.Range["A1:D1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:D1"].Value = "Học Viện Ngân Hàng";

            exRange.Range["F4:I5"].Font.Size = 24;
            exRange.Range["F4:I5"].Font.Name = "Times new roman";
            exRange.Range["F4:I5"].Font.Bold = true;
            exRange.Range["F4:I5"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["F4:I5"].MergeCells = true;
            exRange.Range["F4:I5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["F4:I5"].Value = "DOANH THU PHIM";
            sql = "SELECT sum(TongThu)  " +
                  "FROM tblPhim WHERE TenPhim = '" +
                  cboTenbophim.Text + "'  ";
            tblPhim = DAO.GetDataToTable(sql);

            exRange.Range["B7:B7"].Value = "Doanh thu";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblPhim.Rows[0][2].ToString();

            

            for (hang = 0; hang <= tblPhim.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 4 từ dòng 8
                exSheet.Cells[4][hang + 8] = hang + 1;
                for (cot = 0; cot <= tblPhim.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 5, dòng 8
                    exSheet.Cells[cot + 5][hang + 8] = tblPhim.Rows[hang][cot].ToString();
            }

            exApp.Visible = true;
        }

        /*private void txtDTPhim_TextChanged(object sender, EventArgs e)
        {
            string sql = "select sum(TongThu) from tblPhim where MaPhim = N'" + cboTenbophim.SelectedValue +"'";
        }*/

       private void doanhthuphim()

        {
            string sql1 = "select sum(TongThu) as TongThu from tblPhim where MaPhim = N'" + cboTenbophim.SelectedValue + "'"; 
            SqlCommand cmd = new SqlCommand(sql1, DAO.conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtDTPhim.Text = dr["TongThu"].ToString();
            }
            dr.Close();
        }
        private void doanhthurap()

        {
            string sql2 = "select sum(TongThu) as DoanhThuRap from tblPhim a join tblLichChieu b on a.MaPhim = b.MaPhim group by (MaRap)"
                + "b.MaRap = N'" + cboTenrapphim.SelectedValue +"'";
            SqlCommand cmd2 = new SqlCommand(sql2, DAO.conn);
            SqlDataReader dr2;
            dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                txtDTRap.Text = dr2["DoanhThuRap"].ToString();
            }
            dr2.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
              string sql1 = "select sum(TongThu) as DTPhim from tblPhim where MaPhim = N'" + cboTenbophim.SelectedValue + "'";
            SqlCommand cmd = new SqlCommand(sql1, DAO.conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtDTPhim.Text = dr["DTPhim"].ToString();
            }
            dr.Close();
            
            string sql2 = "select sum(TongTien) as DTRap from  tblLichChieu group by(MaRap) where MaRap = N'"
                + cboTenrapphim.SelectedValue + "'";
            SqlCommand cmd2 = new SqlCommand(sql2, DAO.conn);
            SqlDataReader dr2;
            dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                txtDTRap.Text = dr2["DTRap"].ToString();
            }
            dr2.Close();

        }
    }
}
