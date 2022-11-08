namespace PixisAir_Team5
{
    partial class OskarForm1
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
            this.lstRecords = new System.Windows.Forms.ListBox();
            this.btnEmployeeInRegion = new System.Windows.Forms.Button();
            this.txtAirport = new System.Windows.Forms.TextBox();
            this.lblAirportName = new System.Windows.Forms.Label();
            this.txtPlaneNo = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAirplane = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstRecords
            // 
            this.lstRecords.FormattingEnabled = true;
            this.lstRecords.Location = new System.Drawing.Point(13, 13);
            this.lstRecords.Name = "lstRecords";
            this.lstRecords.Size = new System.Drawing.Size(532, 342);
            this.lstRecords.TabIndex = 0;
            // 
            // btnEmployeeInRegion
            // 
            this.btnEmployeeInRegion.Location = new System.Drawing.Point(576, 62);
            this.btnEmployeeInRegion.Name = "btnEmployeeInRegion";
            this.btnEmployeeInRegion.Size = new System.Drawing.Size(159, 51);
            this.btnEmployeeInRegion.TabIndex = 1;
            this.btnEmployeeInRegion.Text = "Display Employees In Region";
            this.btnEmployeeInRegion.UseVisualStyleBackColor = true;
            this.btnEmployeeInRegion.Click += new System.EventHandler(this.btnEmployeeInRegion_Click);
            // 
            // txtAirport
            // 
            this.txtAirport.Location = new System.Drawing.Point(576, 36);
            this.txtAirport.Name = "txtAirport";
            this.txtAirport.Size = new System.Drawing.Size(159, 20);
            this.txtAirport.TabIndex = 2;
            // 
            // lblAirportName
            // 
            this.lblAirportName.AutoSize = true;
            this.lblAirportName.Location = new System.Drawing.Point(576, 17);
            this.lblAirportName.Name = "lblAirportName";
            this.lblAirportName.Size = new System.Drawing.Size(71, 13);
            this.lblAirportName.TabIndex = 3;
            this.lblAirportName.Text = "Airport Name:";
            // 
            // txtPlaneNo
            // 
            this.txtPlaneNo.Location = new System.Drawing.Point(579, 234);
            this.txtPlaneNo.Name = "txtPlaneNo";
            this.txtPlaneNo.Size = new System.Drawing.Size(156, 20);
            this.txtPlaneNo.TabIndex = 4;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(579, 279);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(156, 20);
            this.txtMake.TabIndex = 5;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(579, 324);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(156, 20);
            this.txtModel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(576, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Airplane Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "New Make:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "New Model:";
            // 
            // btnAirplane
            // 
            this.btnAirplane.Location = new System.Drawing.Point(576, 120);
            this.btnAirplane.Name = "btnAirplane";
            this.btnAirplane.Size = new System.Drawing.Size(159, 48);
            this.btnAirplane.TabIndex = 10;
            this.btnAirplane.Text = "Display Airplanes";
            this.btnAirplane.UseVisualStyleBackColor = true;
            this.btnAirplane.Click += new System.EventHandler(this.btnAirplane_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(576, 175);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(159, 37);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update Airplane";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // OskarForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 384);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAirplane);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtPlaneNo);
            this.Controls.Add(this.lblAirportName);
            this.Controls.Add(this.txtAirport);
            this.Controls.Add(this.btnEmployeeInRegion);
            this.Controls.Add(this.lstRecords);
            this.Name = "OskarForm1";
            this.Text = "OskarForm1";
            this.Load += new System.EventHandler(this.OskarForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRecords;
        private System.Windows.Forms.Button btnEmployeeInRegion;
        private System.Windows.Forms.TextBox txtAirport;
        private System.Windows.Forms.Label lblAirportName;
        private System.Windows.Forms.TextBox txtPlaneNo;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAirplane;
        private System.Windows.Forms.Button btnUpdate;
    }
}