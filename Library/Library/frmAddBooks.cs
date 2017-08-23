using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class frmAddBooks : Form
    {
        public frmAddBooks ()
        {
            InitializeComponent();
        }

        private void _CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddBooks_Load(object sender, EventArgs e)
        {
            string defaultImage;
            //application. startuppath gives the path of the bin
            defaultImage = Application.StartupPath + "\\default.jpg";
            picMember.ImageLocation = defaultImage;
        }
    }
}
