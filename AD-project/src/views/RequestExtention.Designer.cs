namespace AD_project.src.views
{
    partial class RequestExtention
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
            this.W = new System.Windows.Forms.Label();
            this.Aggrement = new System.Windows.Forms.Label();
            this.cbAggrement = new System.Windows.Forms.ComboBox();
            this.dtpNewDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvExtention = new System.Windows.Forms.DataGridView();
            this.btnRequest = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtention)).BeginInit();
            this.SuspendLayout();
            // 
            // W
            // 
            this.W.AutoSize = true;
            this.W.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.W.Location = new System.Drawing.Point(12, 9);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(225, 29);
            this.W.TabIndex = 6;
            this.W.Text = "Request Extention";
            // 
            // Aggrement
            // 
            this.Aggrement.AutoSize = true;
            this.Aggrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aggrement.Location = new System.Drawing.Point(12, 60);
            this.Aggrement.Name = "Aggrement";
            this.Aggrement.Size = new System.Drawing.Size(88, 20);
            this.Aggrement.TabIndex = 35;
            this.Aggrement.Text = "Aggrement";
            // 
            // cbAggrement
            // 
            this.cbAggrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAggrement.FormattingEnabled = true;
            this.cbAggrement.Items.AddRange(new object[] {
            "available",
            "occupied by an occupant",
            "reserved by a person",
            "unavailable "});
            this.cbAggrement.Location = new System.Drawing.Point(16, 83);
            this.cbAggrement.Name = "cbAggrement";
            this.cbAggrement.Size = new System.Drawing.Size(470, 28);
            this.cbAggrement.TabIndex = 34;
            // 
            // dtpNewDate
            // 
            this.dtpNewDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNewDate.Location = new System.Drawing.Point(533, 85);
            this.dtpNewDate.Name = "dtpNewDate";
            this.dtpNewDate.Size = new System.Drawing.Size(470, 26);
            this.dtpNewDate.TabIndex = 91;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(530, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 90;
            this.label2.Text = "New Date";
            // 
            // dgvExtention
            // 
            this.dgvExtention.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExtention.Location = new System.Drawing.Point(17, 189);
            this.dgvExtention.Name = "dgvExtention";
            this.dgvExtention.Size = new System.Drawing.Size(991, 511);
            this.dgvExtention.TabIndex = 92;
            // 
            // btnRequest
            // 
            this.btnRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.btnRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRequest.FlatAppearance.BorderSize = 0;
            this.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.ForeColor = System.Drawing.Color.White;
            this.btnRequest.Location = new System.Drawing.Point(908, 129);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(95, 39);
            this.btnRequest.TabIndex = 93;
            this.btnRequest.Text = "Request";
            this.btnRequest.UseVisualStyleBackColor = false;
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(17, 139);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(871, 26);
            this.txtNote.TabIndex = 95;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 20);
            this.label11.TabIndex = 94;
            this.label11.Text = "Note";
            // 
            // RequestExtention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 712);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.dgvExtention);
            this.Controls.Add(this.dtpNewDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Aggrement);
            this.Controls.Add(this.cbAggrement);
            this.Controls.Add(this.W);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RequestExtention";
            this.Text = "RequestExtention";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtention)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label W;
        private System.Windows.Forms.Label Aggrement;
        private System.Windows.Forms.ComboBox cbAggrement;
        private System.Windows.Forms.DateTimePicker dtpNewDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvExtention;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label11;
    }
}