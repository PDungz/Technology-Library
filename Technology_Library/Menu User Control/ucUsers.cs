using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Technology_Library.Menu_User_Control
{
    public partial class ucUsers : UserControl
    {
        public ucUsers()
        {
            InitializeComponent();
        }

        // Load Picture len pcbImage
        private void pcbImage_Click_1(object sender, EventArgs e)
        {
            // Tao doi tuong mo tep
            OpenFileDialog ofd = new OpenFileDialog();
            // Kiem tra ofd da duoc them anh hay chua
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Gan hinh anh vua them vao pcbImage
                pcbImage.Image = Image.FromFile(ofd.FileName);
                // Tieu de cua so duoc dat lam duong dan
                this.Text = ofd.FileName;
            }
        }
    }
}
