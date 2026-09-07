using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();
        public FrmStatistics()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString();
            var numberOfLocation = db.Location.Count();
            lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();
            lblGuideCount.Text = db.Guide.Count().ToString();
            lblAverageCapacity.Text = db.Location.Average(x => x.Capacity).ToString();
            lblAverageTourPrice.Text = db.Location.Average(x=> (decimal?)x.Price)?.ToString("0.00") + "₺";
            int lastaddedlokasyonıd = db.Location.Max(x => x.LocationId);
            lblLastAddedCountry.Text = db.Location.Where(x => x.LocationId == lastaddedlokasyonıd).Select(y => y.Country).FirstOrDefault();
            lblAverageTourCapacityOfFrench.Text = db.Location.Where(x => x.Country == "Fransa").Average(y => y.Capacity).ToString();
            var romanınrehberininıd = db.Location.Where(x=>x.City=="Roma").Select(y => y.GuideId).FirstOrDefault();
            lblGuideOfRome.Text = db.Guide.Where(x=>x.GuideId==romanınrehberininıd).Select(y=>y.GuideName + " " + y.GuideSurname).FirstOrDefault();
            var maxcapacity = db.Location.Max(x=> x.Capacity);
            lblMaxCapacityTour.Text = db.Location.Where(x => x.Capacity == maxcapacity).Select(y => y.City).FirstOrDefault().ToString();
            var mostexpensivetour = db.Location.Max(x => x.Price);
            lblMostExpensiveTour.Text = db.Location.Where(x=>x.Price==mostexpensivetour).Select(y=>y.City).FirstOrDefault().ToString();
            lblNumberOfToursOfAysegul.Text = db.Location.Count(x=>x.GuideId==2).ToString();
            var guideid = db.Location.Where(x=>x.City == "İstanbul").Select(y=> y.GuideId).FirstOrDefault();
            lblSurnameOfIstanbulGuide.Text = db.Guide.Where(x => x.GuideId == guideid).Select(y=>y.GuideSurname).FirstOrDefault().ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void lblAverageTourPrice_Click(object sender, EventArgs e)
        {

        }

        private void lblAverageTourCapacityOfFrench_Click(object sender, EventArgs e)
        {

        }

        private void lblMaxCapacityTour_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void lblTourOfCountryFrench_Click(object sender, EventArgs e)
        {

        }
    }
}
