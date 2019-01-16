﻿using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Collections;
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
        
        private static int SessionID;
        private string sql2;
        string con2 = "Data Source = 81.169.200.100,1433; Network Library = DBMSSOCN;" +
                  "Initial Catalog = Trashbot; User ID = CompanyUser; Password = Test123;";
        private float  y;
        private string CurrentUser;
        public home()
        {

            SessionID = Login.SID;

            ArrayList xcoords = new ArrayList();
            ArrayList ycoords = new ArrayList();

            sql2 = "SELECT * FROM Trash_Company, Robot WHERE Trash_Company.[Trash_Company_ID] = @ID AND Robot.[Trash_Company_ID]= @ID";
            
                using (SqlConnection cnn2 = new SqlConnection(con2))
                {

                    cnn2.Open();

                    using (SqlCommand cmd2 = new SqlCommand(sql2, cnn2))
                    {
                        cmd2.Parameters.AddWithValue("@ID", SessionID);
                        SqlDataReader Reader2 = cmd2.ExecuteReader();
                        while (Reader2.Read())
                        {

                            CurrentUser = Reader2["Name"].ToString();
                            xcoords.Add((float)Reader2["XCoord"]);
                            ycoords.Add((float)Reader2["YCoord"]);



                            
                        }
                        Reader2.Close();
                    }
                    cnn2.Close();


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
            
           
            foreach (float x in xcoords) {
                MessageBox.Show(x.ToString());
                
                    PointLatLng point = new PointLatLng(y, x);
                    // Put Sql Statement to select :)
                    GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);
                    // Create Overlay
                    GMapOverlay markers = new GMapOverlay("markers");
                    // Add Overlay
                    markers.Markers.Add(marker);

                    // Cover map
                    map.Overlays.Add(markers);
                
                

            }
            
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
            
            label3.Text ="Welcome, " + CurrentUser + "! X= Y= " + y;
           
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
