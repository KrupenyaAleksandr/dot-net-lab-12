using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dot_net_lab_12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sportDBDataSet.sport_club". При необходимости она может быть перемещена или удалена.
            this.sport_clubTableAdapter.Fill(this.sportDBDataSet.sport_club);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sportDBDataSet.sportsman". При необходимости она может быть перемещена или удалена.
            this.sportsmanTableAdapter.Fill(this.sportDBDataSet.sportsman);
            photoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void bindingNavigatorSaveSportsman_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sportsmanBindingSource.EndEdit();
            this.sportsmanTableAdapter.Update(this.sportDBDataSet.sportsman);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRowView drw = (DataRowView)sportsmanBindingSource.Current;
            SportDBDataSet.sportsmanRow sportsman = (SportDBDataSet.sportsmanRow)(drw.Row);
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Files|*.jpg;*.jpeg;*.png;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                photoPictureBox.Image = Image.FromFile(ofd.FileName);
                toolStripStatusLabel1.Text = "Фотография загружена успешно";
            }
        }

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRowView drw = (DataRowView)sportsmanBindingSource.Current;
            SportDBDataSet.sportsmanRow sportsman = (SportDBDataSet.sportsmanRow)(drw.Row);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Files|*.jpg;*.jpeg;*.png;";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (photoPictureBox.Image != null)
                {
                    FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
                    photoPictureBox.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                    fs.Close();
                    toolStripStatusLabel1.Text = "Фотография успешно сохранена";
                }
            }
        }

        private void loadTableSportsmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.sportsmanTableAdapter.Fill(this.sportDBDataSet.sportsman);
        }

        private void loadTableSportClubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.sport_clubTableAdapter.Fill(this.sportDBDataSet.sport_club);
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBoxPropertyGrid pictureBoxPropertyGrid = new PictureBoxPropertyGrid(ref photoPictureBox);
            try
            {
                pictureBoxPropertyGrid.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
