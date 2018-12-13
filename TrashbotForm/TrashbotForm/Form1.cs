using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrashbotForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new PointLatLng(52.786435, 6.8894953);
            map.MinZoom = 5;
            map.MaxZoom = 1000;
            map.Zoom = 500; //current zoom
            map.MouseWheelZoomEnabled = true;
            map.DragButton = MouseButtons.Left;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            double lat = Convert.ToDouble(latitude_txt.Text);
            double lon = Convert.ToDouble(longitude_txt.Text);
            map.Position = new PointLatLng(lat, lon);
            map.Zoom = 10;
        }

        private void GMapControl1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
