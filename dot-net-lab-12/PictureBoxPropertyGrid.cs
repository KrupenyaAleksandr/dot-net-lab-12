using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dot_net_lab_12
{
    public partial class PictureBoxPropertyGrid : Form
    {
        private PictureBox pictureBox;
        public PictureBoxPropertyGrid(ref PictureBox picturebox)
        {
            InitializeComponent();
            pictureBox = picturebox;
            propertyGrid1.SelectedObject = pictureBox;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
