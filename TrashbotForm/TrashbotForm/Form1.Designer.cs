namespace TrashbotForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.latitude = new System.Windows.Forms.Label();
            this.latitude_txt = new System.Windows.Forms.TextBox();
            this.longitude_txt = new System.Windows.Forms.TextBox();
            this.longitude = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(447, 342);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(21, 12);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(388, 318);
            this.map.TabIndex = 1;
            this.map.Zoom = 0D;
            this.map.Load += new System.EventHandler(this.GMapControl1_Load);
            // 
            // latitude
            // 
            this.latitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.latitude.AutoSize = true;
            this.latitude.Location = new System.Drawing.Point(520, 44);
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(41, 13);
            this.latitude.TabIndex = 2;
            this.latitude.Text = "latitude";
            this.latitude.Click += new System.EventHandler(this.label1_Click);
            // 
            // latitude_txt
            // 
            this.latitude_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.latitude_txt.Location = new System.Drawing.Point(596, 37);
            this.latitude_txt.Name = "latitude_txt";
            this.latitude_txt.Size = new System.Drawing.Size(100, 20);
            this.latitude_txt.TabIndex = 3;
            // 
            // longitude_txt
            // 
            this.longitude_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.longitude_txt.Location = new System.Drawing.Point(596, 76);
            this.longitude_txt.Name = "longitude_txt";
            this.longitude_txt.Size = new System.Drawing.Size(100, 20);
            this.longitude_txt.TabIndex = 4;
            // 
            // longitude
            // 
            this.longitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.longitude.AutoSize = true;
            this.longitude.Location = new System.Drawing.Point(511, 82);
            this.longitude.Name = "longitude";
            this.longitude.Size = new System.Drawing.Size(50, 13);
            this.longitude.TabIndex = 5;
            this.longitude.Text = "longitude";
            // 
            // search_button
            // 
            this.search_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_button.Location = new System.Drawing.Point(596, 125);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 23);
            this.search_button.TabIndex = 6;
            this.search_button.Text = "search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 342);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.longitude);
            this.Controls.Add(this.longitude_txt);
            this.Controls.Add(this.latitude_txt);
            this.Controls.Add(this.latitude);
            this.Controls.Add(this.map);
            this.Controls.Add(this.splitter1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Label latitude;
        private System.Windows.Forms.TextBox latitude_txt;
        private System.Windows.Forms.TextBox longitude_txt;
        private System.Windows.Forms.Label longitude;
        private System.Windows.Forms.Button search_button;
    }
}

