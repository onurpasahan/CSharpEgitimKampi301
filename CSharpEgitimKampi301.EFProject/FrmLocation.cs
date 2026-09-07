using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }
        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();
        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.Guide.Select(x => new
            {
                fullName =x.GuideName + " " + x.GuideSurname, x.GuideId
            }).ToList();

            cmbGuide.DisplayMember = ("fullName");
            cmbGuide.SelectedValue = ("GuideId");
            cmbGuide.DataSource = values;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Location.ToList();
            dataGridView1.DataSource = values;

            dataGridView1.Columns["Guide"].Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.City = txtCity.Text;
            location.Country = txtCountry.Text;
            location.Capacity = (byte)x.Value;
            location.Price = decimal.Parse(a.Text);
            location.DayNight = txtDayNight.Text;
            location.GuideId = int.Parse(cmbGuide.Text);

            db.SaveChanges();
            MessageBox.Show("Ekleme işlemi başarılı");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deletedvalue = db.Location.Find(id);
            db.Location.Remove(deletedvalue);

            db.SaveChanges();
            MessageBox.Show("Silme işlemi başarılı");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updatedvalues = db.Location.Find(id);

            updatedvalues.City = txtCity.Text;
            updatedvalues.Country = txtCountry.Text;
            updatedvalues.Capacity = (byte)x.Value;
            updatedvalues.Price = decimal.Parse(a.Text);
            updatedvalues.DayNight = txtDayNight.Text;
            updatedvalues.GuideId = int.Parse(cmbGuide.Text);

            db.SaveChanges();
            MessageBox.Show("Değiştirme işlemi başarılı");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void nudCapacity_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
    
