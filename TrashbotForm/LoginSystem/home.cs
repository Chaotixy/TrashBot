﻿using GMap.NET;
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
using System.Diagnostics;
using System.Data.Sql;
using System.Data.SqlClient;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
namespace LoginSystem
{
    public partial class home : Form
    {
        
        private int SessionID;
        private string con, sql2;
        private string CurrentUser;
        public home()
        {

            SessionID = Login.SessionUserID;
            con = "Data Source = 81.169.200.100,1433; Network Library = DBMSSOCN;" +
                  "Initial Catalog = Trashbot; User ID = CompanyUser; Password = Test123;";
            sql2 = "SELECT * FROM Trash_Company WHERE [Trash_Company_ID] = @ID";
            using (SqlConnection cnn = new SqlConnection(con))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql2, cnn))
                {
                    cmd.Parameters.AddWithValue("@ID", SessionID);
                    SqlDataReader Reader =  cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        
                        CurrentUser = Reader["Name"].ToString();
                    }
                    Reader.Close();
                }
                cnn.Close();
                
            }
            
            InitializeComponent();
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new PointLatLng(52.786435, 6.8894953);
            map.MinZoom = 5; //minimum
            map.MaxZoom = 100; //maximum zoom
            map.Zoom = 10; //current zoom
            map.MouseWheelZoomEnabled = true;
            map.DragButton = MouseButtons.Left;

            // Plot Marker
            PointLatLng point = new PointLatLng();// Put Sql Statement to select :)
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);

            // Create Overlay
            GMapOverlay markers = new GMapOverlay("markers");
            // Add Overlay
            markers.Markers.Add(marker);
            // Cover map
            map.Overlays.Add(markers);
        }

        // So you can move the form around
        private bool mouseDown;
        private Point lastLocation;

        

        private void home_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void home_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void home_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void home_Load(object sender, EventArgs e)
        {
            label3.Text ="Welcome, " + CurrentUser + "!";
        }

        private void Exit_Click(object sender, EventArgs e)
        {

            foreach (var process in Process.GetProcessesByName("LoginSystem"))
            {
                process.Kill();
            }
        }

    }
}
