namespace AD_project.src.views
{
    partial class AdminMain
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnWaitingList = new System.Windows.Forms.Button();
            this.btnParking = new System.Windows.Forms.Button();
            this.btnDependants = new System.Windows.Forms.Button();
            this.btnOccupent = new System.Windows.Forms.Button();
            this.btnApartment = new System.Windows.Forms.Button();
            this.btnLease = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            this.pnlSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(278, 44);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1052, 746);
            this.pnlMain.TabIndex = 5;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.btnLogout);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(278, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1052, 44);
            this.pnlTop.TabIndex = 4;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.White;
            this.pnlSide.Controls.Add(this.btnApprove);
            this.pnlSide.Controls.Add(this.btnDashboard);
            this.pnlSide.Controls.Add(this.btnSearch);
            this.pnlSide.Controls.Add(this.btnWaitingList);
            this.pnlSide.Controls.Add(this.btnParking);
            this.pnlSide.Controls.Add(this.btnDependants);
            this.pnlSide.Controls.Add(this.btnOccupent);
            this.pnlSide.Controls.Add(this.btnApartment);
            this.pnlSide.Controls.Add(this.btnLease);
            this.pnlSide.Controls.Add(this.panel2);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(278, 790);
            this.pnlSide.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Image = global::AD_project.Properties.Resources._switch;
            this.btnLogout.Location = new System.Drawing.Point(961, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(33, 33);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::AD_project.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnClose.Location = new System.Drawing.Point(1016, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 33);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApprove.FlatAppearance.BorderSize = 0;
            this.btnApprove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(179)))), ((int)(((byte)(250)))));
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.Image = global::AD_project.Properties.Resources.quality;
            this.btnApprove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApprove.Location = new System.Drawing.Point(0, 718);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(277, 60);
            this.btnApprove.TabIndex = 1;
            this.btnApprove.Text = "Approve extention";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(179)))), ((int)(((byte)(250)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Image = global::AD_project.Properties.Resources.dashboard;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(-1, 208);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(277, 60);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(179)))), ((int)(((byte)(250)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::AD_project.Properties.Resources.search;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(0, 664);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(277, 60);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnWaitingList
            // 
            this.btnWaitingList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWaitingList.FlatAppearance.BorderSize = 0;
            this.btnWaitingList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(179)))), ((int)(((byte)(250)))));
            this.btnWaitingList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWaitingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWaitingList.Image = global::AD_project.Properties.Resources.time_left;
            this.btnWaitingList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWaitingList.Location = new System.Drawing.Point(0, 598);
            this.btnWaitingList.Name = "btnWaitingList";
            this.btnWaitingList.Size = new System.Drawing.Size(277, 60);
            this.btnWaitingList.TabIndex = 5;
            this.btnWaitingList.Text = "Waiting List";
            this.btnWaitingList.UseVisualStyleBackColor = true;
            this.btnWaitingList.Click += new System.EventHandler(this.btnWaitingList_Click);
            // 
            // btnParking
            // 
            this.btnParking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParking.FlatAppearance.BorderSize = 0;
            this.btnParking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(179)))), ((int)(((byte)(250)))));
            this.btnParking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParking.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParking.Image = global::AD_project.Properties.Resources.parking_sign;
            this.btnParking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParking.Location = new System.Drawing.Point(0, 532);
            this.btnParking.Name = "btnParking";
            this.btnParking.Size = new System.Drawing.Size(277, 60);
            this.btnParking.TabIndex = 4;
            this.btnParking.Text = "Parking";
            this.btnParking.UseVisualStyleBackColor = true;
            this.btnParking.Click += new System.EventHandler(this.btnParking_Click);
            // 
            // btnDependants
            // 
            this.btnDependants.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDependants.FlatAppearance.BorderSize = 0;
            this.btnDependants.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(179)))), ((int)(((byte)(250)))));
            this.btnDependants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDependants.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDependants.Image = global::AD_project.Properties.Resources.customer;
            this.btnDependants.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDependants.Location = new System.Drawing.Point(0, 466);
            this.btnDependants.Name = "btnDependants";
            this.btnDependants.Size = new System.Drawing.Size(277, 60);
            this.btnDependants.TabIndex = 3;
            this.btnDependants.Text = "Dependants";
            this.btnDependants.UseVisualStyleBackColor = true;
            this.btnDependants.Click += new System.EventHandler(this.btnDependants_Click);
            // 
            // btnOccupent
            // 
            this.btnOccupent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOccupent.FlatAppearance.BorderSize = 0;
            this.btnOccupent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(179)))), ((int)(((byte)(250)))));
            this.btnOccupent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOccupent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOccupent.Image = global::AD_project.Properties.Resources.client;
            this.btnOccupent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOccupent.Location = new System.Drawing.Point(-1, 400);
            this.btnOccupent.Name = "btnOccupent";
            this.btnOccupent.Size = new System.Drawing.Size(277, 60);
            this.btnOccupent.TabIndex = 2;
            this.btnOccupent.Text = "Occupent";
            this.btnOccupent.UseVisualStyleBackColor = true;
            this.btnOccupent.Click += new System.EventHandler(this.btnOccupent_Click);
            // 
            // btnApartment
            // 
            this.btnApartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApartment.FlatAppearance.BorderSize = 0;
            this.btnApartment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(179)))), ((int)(((byte)(250)))));
            this.btnApartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApartment.Image = global::AD_project.Properties.Resources.apartment;
            this.btnApartment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApartment.Location = new System.Drawing.Point(0, 334);
            this.btnApartment.Name = "btnApartment";
            this.btnApartment.Size = new System.Drawing.Size(277, 60);
            this.btnApartment.TabIndex = 1;
            this.btnApartment.Text = "Apartment";
            this.btnApartment.UseVisualStyleBackColor = true;
            this.btnApartment.Click += new System.EventHandler(this.btnApartment_Click);
            // 
            // btnLease
            // 
            this.btnLease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLease.FlatAppearance.BorderSize = 0;
            this.btnLease.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(179)))), ((int)(((byte)(250)))));
            this.btnLease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLease.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLease.Image = global::AD_project.Properties.Resources.home;
            this.btnLease.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLease.Location = new System.Drawing.Point(0, 268);
            this.btnLease.Name = "btnLease";
            this.btnLease.Size = new System.Drawing.Size(277, 60);
            this.btnLease.TabIndex = 0;
            this.btnLease.Text = "Lease";
            this.btnLease.UseVisualStyleBackColor = true;
            this.btnLease.Click += new System.EventHandler(this.btnLease_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::AD_project.Properties.Resources._20945169;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(27, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 190);
            this.panel2.TabIndex = 0;
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 790);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMain";
            this.Load += new System.EventHandler(this.AdminMain_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlSide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnWaitingList;
        private System.Windows.Forms.Button btnParking;
        private System.Windows.Forms.Button btnDependants;
        private System.Windows.Forms.Button btnOccupent;
        private System.Windows.Forms.Button btnApartment;
        private System.Windows.Forms.Button btnLease;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnLogout;
    }
}