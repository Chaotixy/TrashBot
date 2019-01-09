using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;

namespace TrashbotForm
{
    public partial class TrashBot : Form
    {
        public TrashBot()
        {
            InitializeComponent();
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new PointLatLng(52.786435, 6.8894953);
            map.MinZoom = 1;
            map.MaxZoom = 25;
            map.Zoom = 18; //current zoom
            map.MouseWheelZoomEnabled = true;
            map.DragButton = MouseButtons.Left;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double lat = Convert.ToDouble(latitude_txt.Text);
            double lon = Convert.ToDouble(longitude_txt.Text);
            map.Position = new PointLatLng(lat, lon);
            map.Zoom = 10;
        }
        private void TrashBot_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
