namespace LoginSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.userErr = new System.Windows.Forms.Label();
            this.passErr = new System.Windows.Forms.Label();
            this.piclock = new System.Windows.Forms.PictureBox();
            this.picperson = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PersonCheck = new System.Windows.Forms.RadioButton();
            this.CompanyCheck = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.piclock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picperson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(86, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 15);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Username";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(60, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 1);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(60, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 1);
            this.panel2.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(86, 254);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 15);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Password";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(191)))), ((int)(((byte)(170)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(60, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Log in";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(191)))), ((int)(((byte)(170)))));
            this.button2.Location = new System.Drawing.Point(60, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(191)))), ((int)(((byte)(170)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.Exit.Location = new System.Drawing.Point(293, -1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(45, 35);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "X";
            this.Exit.UseCompatibleTextRendering = true;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // userErr
            // 
            this.userErr.AutoSize = true;
            this.userErr.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userErr.ForeColor = System.Drawing.Color.Red;
            this.userErr.Location = new System.Drawing.Point(61, 221);
            this.userErr.Name = "userErr";
            this.userErr.Size = new System.Drawing.Size(0, 16);
            this.userErr.TabIndex = 14;
            // 
            // passErr
            // 
            this.passErr.AutoSize = true;
            this.passErr.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passErr.ForeColor = System.Drawing.Color.Red;
            this.passErr.Location = new System.Drawing.Point(61, 295);
            this.passErr.Name = "passErr";
            this.passErr.Size = new System.Drawing.Size(0, 16);
            this.passErr.TabIndex = 15;
            // 
            // piclock
            // 
            this.piclock.Image = global::LoginSystem.Properties.Resources.lock1;
            this.piclock.Location = new System.Drawing.Point(60, 252);
            this.piclock.Name = "piclock";
            this.piclock.Size = new System.Drawing.Size(20, 20);
            this.piclock.TabIndex = 12;
            this.piclock.TabStop = false;
            // 
            // picperson
            // 
            this.picperson.Image = global::LoginSystem.Properties.Resources.person1;
            this.picperson.Location = new System.Drawing.Point(60, 182);
            this.picperson.Name = "picperson";
            this.picperson.Size = new System.Drawing.Size(20, 20);
            this.picperson.TabIndex = 11;
            this.picperson.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(142, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // PersonCheck
            // 
            this.PersonCheck.AutoSize = true;
            this.PersonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonCheck.ForeColor = System.Drawing.Color.White;
            this.PersonCheck.Location = new System.Drawing.Point(150, 143);
            this.PersonCheck.Name = "PersonCheck";
            this.PersonCheck.Size = new System.Drawing.Size(65, 20);
            this.PersonCheck.TabIndex = 49;
            this.PersonCheck.Text = "Citizen";
            this.PersonCheck.UseVisualStyleBackColor = true;
            // 
            // CompanyCheck
            // 
            this.CompanyCheck.AutoSize = true;
            this.CompanyCheck.Checked = true;
            this.CompanyCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyCheck.ForeColor = System.Drawing.Color.White;
            this.CompanyCheck.Location = new System.Drawing.Point(60, 143);
            this.CompanyCheck.Name = "CompanyCheck";
            this.CompanyCheck.Size = new System.Drawing.Size(84, 20);
            this.CompanyCheck.TabIndex = 0;
            this.CompanyCheck.TabStop = true;
            this.CompanyCheck.Text = "Company";
            this.CompanyCheck.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(337, 503);
            this.Controls.Add(this.PersonCheck);
            this.Controls.Add(this.CompanyCheck);
            this.Controls.Add(this.passErr);
            this.Controls.Add(this.userErr);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.piclock);
            this.Controls.Add(this.picperson);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.piclock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picperson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox picperson;
        private System.Windows.Forms.PictureBox piclock;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label userErr;
        private System.Windows.Forms.Label passErr;
        private System.Windows.Forms.RadioButton PersonCheck;
        private System.Windows.Forms.RadioButton CompanyCheck;
    }
}

