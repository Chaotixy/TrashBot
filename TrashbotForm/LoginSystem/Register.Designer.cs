namespace LoginSystem
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.label1 = new System.Windows.Forms.Label();
            this.boxUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.boxEmail = new System.Windows.Forms.TextBox();
            this.boxPass = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picemail = new System.Windows.Forms.PictureBox();
            this.piclock = new System.Windows.Forms.PictureBox();
            this.picuser = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.Button();
            this.passErr = new System.Windows.Forms.Label();
            this.emailErr = new System.Windows.Forms.Label();
            this.userErr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picemail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // boxUser
            // 
            this.boxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.boxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxUser.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.boxUser.Location = new System.Drawing.Point(81, 130);
            this.boxUser.Name = "boxUser";
            this.boxUser.Size = new System.Drawing.Size(161, 15);
            this.boxUser.TabIndex = 7;
            this.boxUser.Text = "Pick a username";
            this.boxUser.Click += new System.EventHandler(this.boxUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(191)))), ((int)(((byte)(170)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(54, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(61, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Already have an account?";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(191)))), ((int)(((byte)(170)))));
            this.button2.Location = new System.Drawing.Point(54, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "Log in";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // boxEmail
            // 
            this.boxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.boxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxEmail.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.boxEmail.Location = new System.Drawing.Point(81, 211);
            this.boxEmail.Name = "boxEmail";
            this.boxEmail.Size = new System.Drawing.Size(161, 15);
            this.boxEmail.TabIndex = 18;
            this.boxEmail.Text = "You@example.com";
            this.boxEmail.Click += new System.EventHandler(this.boxEmail_Click_1);
            // 
            // boxPass
            // 
            this.boxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.boxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPass.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.boxPass.Location = new System.Drawing.Point(81, 293);
            this.boxPass.Name = "boxPass";
            this.boxPass.Size = new System.Drawing.Size(161, 15);
            this.boxPass.TabIndex = 19;
            this.boxPass.Text = "Create a password";
            this.boxPass.Click += new System.EventHandler(this.boxPass_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(53, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 1);
            this.panel2.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(52, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 1);
            this.panel1.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(52, 318);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 1);
            this.panel3.TabIndex = 21;
            // 
            // picemail
            // 
            this.picemail.Image = global::LoginSystem.Properties.Resources.email1;
            this.picemail.Location = new System.Drawing.Point(52, 208);
            this.picemail.Name = "picemail";
            this.picemail.Size = new System.Drawing.Size(20, 20);
            this.picemail.TabIndex = 17;
            this.picemail.TabStop = false;
            // 
            // piclock
            // 
            this.piclock.Image = global::LoginSystem.Properties.Resources.lock1;
            this.piclock.Location = new System.Drawing.Point(52, 290);
            this.piclock.Name = "piclock";
            this.piclock.Size = new System.Drawing.Size(20, 20);
            this.piclock.TabIndex = 16;
            this.piclock.TabStop = false;
            // 
            // picuser
            // 
            this.picuser.Image = global::LoginSystem.Properties.Resources.person1;
            this.picuser.Location = new System.Drawing.Point(52, 127);
            this.picuser.Name = "picuser";
            this.picuser.Size = new System.Drawing.Size(20, 20);
            this.picuser.TabIndex = 15;
            this.picuser.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(139, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
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
            this.Exit.TabIndex = 22;
            this.Exit.Text = "X";
            this.Exit.UseCompatibleTextRendering = true;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // passErr
            // 
            this.passErr.AutoSize = true;
            this.passErr.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passErr.ForeColor = System.Drawing.Color.Red;
            this.passErr.Location = new System.Drawing.Point(54, 325);
            this.passErr.Name = "passErr";
            this.passErr.Size = new System.Drawing.Size(0, 16);
            this.passErr.TabIndex = 23;
            // 
            // emailErr
            // 
            this.emailErr.AutoSize = true;
            this.emailErr.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailErr.ForeColor = System.Drawing.Color.Red;
            this.emailErr.Location = new System.Drawing.Point(54, 244);
            this.emailErr.Name = "emailErr";
            this.emailErr.Size = new System.Drawing.Size(0, 16);
            this.emailErr.TabIndex = 24;
            // 
            // userErr
            // 
            this.userErr.AutoSize = true;
            this.userErr.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userErr.ForeColor = System.Drawing.Color.Red;
            this.userErr.Location = new System.Drawing.Point(54, 164);
            this.userErr.Name = "userErr";
            this.userErr.Size = new System.Drawing.Size(0, 16);
            this.userErr.TabIndex = 25;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(337, 503);
            this.Controls.Add(this.userErr);
            this.Controls.Add(this.emailErr);
            this.Controls.Add(this.passErr);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.boxPass);
            this.Controls.Add(this.boxEmail);
            this.Controls.Add(this.picemail);
            this.Controls.Add(this.piclock);
            this.Controls.Add(this.picuser);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picemail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox picuser;
        private System.Windows.Forms.PictureBox piclock;
        private System.Windows.Forms.PictureBox picemail;
        private System.Windows.Forms.TextBox boxEmail;
        private System.Windows.Forms.TextBox boxPass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label passErr;
        private System.Windows.Forms.Label emailErr;
        private System.Windows.Forms.Label userErr;
    }
}