using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace dot_net_lab_12
{
    public partial class FormMain : Form
    {

        Bitmap DocumentSaver;
        public FormMain()
        {
            InitializeComponent();
            dataGridViewSportClub.Validating += dataGridViewSportClub_Validating;
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

        private void bindingNavigatorSportClub_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sportclubBindingSource.EndEdit();
            this.sport_clubTableAdapter.Update(this.sportDBDataSet.sport_club);
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(DocumentSaver, 0, 0);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            DocumentSaver = new Bitmap(splitContainer1.Panel2.Width + 10, splitContainer1.Panel2.Height + 10, g);
            Graphics g2 = Graphics.FromImage(DocumentSaver);
            g2.CopyFromScreen(Location.X + splitContainer1.Panel1.Width + 36, Location.Y + menuStrip1.Height + tabControl1.Height - 400, 50, 50, splitContainer1.Panel2.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void dataGridViewSportClub_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;
            Control edit = dataGridViewSportClub.EditingControl;
            if (edit == null) return;
            if (e.FormattedValue.ToString().Length < 2)
            {
                e.Cancel = true;
                errorProvider1.SetError(edit, "Слишком короткое название");
                errorProvider1.SetIconAlignment(edit, ErrorIconAlignment.MiddleLeft);
                errorProvider1.SetIconPadding(edit, -20);
            }
        }

        private void dataGridViewSportClub_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}


/*private void dataGridViewSportClub_Validating(object sender, CancelEventArgs e)
{
    if (dataGridViewSportClub.Rows[dataGridViewSportClub.CurrentCell.RowIndex].Cells["titleDataGridViewTextBoxColumn"].Value.ToString().Length < 2)
    {
        e.Cancel = true;
        errorProvider1.SetError(dataGridViewSportClub, "Не указано название!");
    }
    else
    {
        e.Cancel = false;
        errorProvider1.Clear();
    }
}*/