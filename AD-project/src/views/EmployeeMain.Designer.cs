namespace AD_project.src.views
{
    partial class EmployeeMain
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
            this.pnlSide = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnWaitingList = new System.Windows.Forms.Button();
            this.btnDependants = new System.Windows.Forms.Button();
            this.btnOccupent = new System.Windows.Forms.Button();
            this.btnLease = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlSide.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.White;
            this.pnlSide.Controls.Add(this.btnSearch);
            this.pnlSide.Controls.Add(this.btnWaitingList);
            this.pnlSide.Controls.Add(this.btnDependants);
            this.pnlSide.Controls.Add(this.btnOccupent);
            this.pnlSide.Controls.Add(this.btnLease);
            this.pnlSide.Controls.Add(this.panel2);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(278, 790);
            this.pnlSide.TabIndex = 0;
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
            this.btnSearch.Location = new System.Drawing.Point(-2, 492);
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
            this.btnWaitingList.Location = new System.Drawing.Point(0, 426);
            this.btnWaitingList.Name = "btnWaitingList";
            this.btnWaitingList.Size = new System.Drawing.Size(277, 60);
            this.btnWaitingList.TabIndex = 5;
            this.btnWaitingList.Text = "Waiting List";
            this.btnWaitingList.UseVisualStyleBackColor = true;
            this.btnWaitingList.Click += new System.EventHandler(this.btnWaitingList_Click);
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
            this.btnDependants.Location = new System.Drawing.Point(0, 360);
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
            this.btnOccupent.Location = new System.Drawing.Point(0, 294);
            this.btnOccupent.Name = "btnOccupent";
            this.btnOccupent.Size = new System.Drawing.Size(277, 60);
            this.btnOccupent.TabIndex = 2;
            this.btnOccupent.Text = "Occupent";
            this.btnOccupent.UseVisualStyleBackColor = true;
            this.btnOccupent.Click += new System.EventHandler(this.btnOccupent_Click);
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
            this.btnLease.Location = new System.Drawing.Point(1, 238);
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
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.btnLogout);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(278, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1052, 44);
            this.pnlTop.TabIndex = 1;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
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
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(278, 44);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1052, 746);
            this.pnlMain.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Image = global::AD_project.Properties.Resources._switch;
            this.btnLogout.Location = new System.Drawing.Point(965, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(33, 33);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // EmployeeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 790);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlSide.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLease;
        private System.Windows.Forms.Button btnOccupent;
        private System.Windows.Forms.Button btnDependants;
        private System.Windows.Forms.Button btnWaitingList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLogout;
    }
}