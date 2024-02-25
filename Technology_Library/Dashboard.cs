using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Technology_Library
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            timer1.Start();
        }

        // Button logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }

        // Dashboard Load
        private void Dashboard_Load(object sender, EventArgs e)
        {
            // An cac uc
            ucBookBorrow1.Visible = false;
            ucBookReturn1.Visible = false;
            ucBookOverDue1.Visible = false;
            ucBorrower1.Visible = false;
            ucStore1.Visible = false;
            ucBookCategory1.Visible = false;
            ucBooks1.Visible = false;
            ucUsers1.Visible = false;
            ucReport1.Visible = false;
            btnBookBorrow.PerformClick();
        }

        // Moc thoi gian
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timeLine.Text = DateTime.Now.ToLongTimeString() + " - " + DateTime.Now.ToShortDateString();
        }

        // Button Book Borrow: chuyen menu giao dien quan ly muon sach
        private void btnBookBorrow_Click(object sender, EventArgs e)
        {
            // Hien thi lua chon
            {
                pcbBorrow.Visible = true;
                pcbReturn.Visible = false;
                pcbOverDue.Visible = false;
                pcbBorrower.Visible = false;
                pcbStore.Visible = false;
                pcbCategory.Visible = false;
                pcbBooks.Visible = false;
                pcbUsers.Visible = false;
                pcbReport.Visible = false;
            }
            // Hien thi form ucBookBorrow
            ucBookBorrow1.Visible = true;
            ucBookBorrow1.BringToFront();
        }

        // Button Book Return: chuyen menu giao dien quan ly tra sach
        private void btnBookReturn_Click(object sender, EventArgs e)
        {
            // Hien thi lua chon
            {
                pcbBorrow.Visible = false;
                pcbReturn.Visible = true;
                pcbOverDue.Visible = false;
                pcbBorrower.Visible = false;
                pcbStore.Visible = false;
                pcbCategory.Visible = false;
                pcbBooks.Visible = false;
                pcbUsers.Visible = false;
                pcbReport.Visible = false;
            }

            // Hien thi form ucBookReturn
            ucBookReturn1.Visible = true;
            ucBookReturn1.BringToFront();
        }

        // Button Book Are Over Due: chuyen menu giao dien quan ly sach qua han
        private void btnBookOverDue_Click(object sender, EventArgs e)
        {
            // Hien thi lua chon
            {
                pcbBorrow.Visible = false;
                pcbReturn.Visible = false;
                pcbOverDue.Visible = true;
                pcbBorrower.Visible = false;
                pcbStore.Visible = false;
                pcbCategory.Visible = false;
                pcbBooks.Visible = false;
                pcbUsers.Visible = false;
                pcbReport.Visible = false;
            }

            // Hien thi form ucBookOverDue
            ucBookOverDue1.Visible = true;
            ucBookOverDue1.BringToFront();
        }

        // Button Borrower: chuyen menu giao dien quan ly nguoi muon
        private void btnBorrower_Click_1(object sender, EventArgs e)
        {
            // Hien thi lua chon
            {
                pcbBorrow.Visible = false;
                pcbReturn.Visible = false;
                pcbOverDue.Visible = false;
                pcbBorrower.Visible = true;
                pcbStore.Visible = false;
                pcbCategory.Visible = false;
                pcbBooks.Visible = false;
                pcbUsers.Visible = false;
                pcbReport.Visible = false;
            }
            // Hien thi form ucBorrower
            ucBorrower1.Visible = true;
            ucBorrower1.BringToFront();
        }

        // Button Store: chuyen menu giao dien quan ly kho
        private void btnStore_Click(object sender, EventArgs e)
        {
            // Hien thi lua chon
            {
                pcbBorrow.Visible = false;
                pcbReturn.Visible = false;
                pcbOverDue.Visible = false;
                pcbBorrower.Visible = false;
                pcbStore.Visible = true;
                pcbCategory.Visible = false;
                pcbBooks.Visible = false;
                pcbUsers.Visible = false;
                pcbReport.Visible = false;
            }
            // Hien thi form ucStore
            ucStore1.Visible = true;
            ucStore1.BringToFront();
        }

        // Button Book Category: chuyen menu giao dien quan ly the loai sach
        private void btnBookCategory_Click(object sender, EventArgs e)
        {
            // Hien thi lua chon
            {
                pcbBorrow.Visible = false;
                pcbReturn.Visible = false;
                pcbOverDue.Visible = false;
                pcbBorrower.Visible = false;
                pcbStore.Visible = false;
                pcbCategory.Visible = true;
                pcbBooks.Visible = false;
                pcbUsers.Visible = false;
                pcbReport.Visible = false;
            }
            // Hien thi form ucBookCategory
            ucBookCategory1.Visible = true;
            ucBookCategory1.BringToFront(); 
        }

        // Button Books: chuyen menu giao dien quan ly sach
        private void btnBooks_Click(object sender, EventArgs e)
        {
            // Hien thi lua chon
            {
                pcbBorrow.Visible = false;
                pcbReturn.Visible = false;
                pcbOverDue.Visible = false;
                pcbBorrower.Visible = false;
                pcbStore.Visible = false;
                pcbCategory.Visible = false;
                pcbBooks.Visible = true;
                pcbUsers.Visible = false;
                pcbReport.Visible = false;
            }
            // Hien thi form ucBooks
            ucBooks1.Visible = true;
            ucBooks1.BringToFront();    
        }

        // Button UserManagement: chuyen menu giao dien quan ly nguoi dung
        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            // Hien thi lua chon
            {
                pcbBorrow.Visible = false;
                pcbReturn.Visible = false;
                pcbOverDue.Visible = false;
                pcbBorrower.Visible = false;
                pcbStore.Visible = false;
                pcbCategory.Visible = false;
                pcbBooks.Visible = false;
                pcbUsers.Visible = true;
                pcbReport.Visible = false;
            }
            // Hien thi form ucUserManagement
            ucUsers1.Visible = true;
            ucUsers1.BringToFront();
        }

        // Button Report: chuyen menu giao dien quan ly báo cáo
        private void btnReport_Click(object sender, EventArgs e)
        {
            // Hien thi lua chon
            {
                pcbBorrow.Visible = false;
                pcbReturn.Visible = false;
                pcbOverDue.Visible = false;
                pcbBorrower.Visible = false;
                pcbStore.Visible = false;
                pcbCategory.Visible = false;
                pcbBooks.Visible = false;
                pcbUsers.Visible = false;
                pcbReport.Visible = true;
            }
            // Hien thi form ucReport
            ucReport1.Visible = true;
            ucReport1.BringToFront();   
        }

    }
}
