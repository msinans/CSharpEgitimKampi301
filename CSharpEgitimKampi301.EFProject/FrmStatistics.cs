using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        EgitimKampiEFTravelDbEntities2 db = new EgitimKampiEFTravelDbEntities2();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString();
            lblSumCapacity.Text = db.Location.Sum(x=>x.Capacity).ToString();
            lblGuideCount.Text = db.Guide.Count().ToString();
            lblAverageCapacity.Text = db.Location.Average(x=>x.Capacity).ToString();
            lblAvgLocationPrice.Text = db.Location.Average(x=>x.Price)?.ToString("0.00") + " ₺";

            int lastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault();

            lblCappadociaTourCapacity.Text = db.Location.Where(x => x.City == "Kapadokya").Select(y=>y.Capacity).FirstOrDefault().ToString();

            lblTurkiyeCapacityAverage.Text = db.Location.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();
           


        }
    }
}
