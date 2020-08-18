namespace Asg3_sxr190067
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblFlPath = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.lvResultData = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblNoOfRecs = new System.Windows.Forms.Label();
            this.lblMinEntryTime = new System.Windows.Forms.Label();
            this.lblMaxEntryTime = new System.Windows.Forms.Label();
            this.lblMaxIntRecTime = new System.Windows.Forms.Label();
            this.lblMinIntRecTime = new System.Windows.Forms.Label();
            this.lblAvgEntryTIme = new System.Windows.Forms.Label();
            this.lblBkSpcCount = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lblAvgIntRecTime = new System.Windows.Forms.Label();
            this.txtNoOfRec = new System.Windows.Forms.TextBox();
            this.txtMinEntryTIme = new System.Windows.Forms.TextBox();
            this.txtAvgEntryTime = new System.Windows.Forms.TextBox();
            this.txtMaxEntryTime = new System.Windows.Forms.TextBox();
            this.txtMaxIntRecTime = new System.Windows.Forms.TextBox();
            this.txtMinIntRecTime = new System.Windows.Forms.TextBox();
            this.txtTotalTime = new System.Windows.Forms.TextBox();
            this.txtAvgIntRecTime = new System.Windows.Forms.TextBox();
            this.txtBkSpcCount = new System.Windows.Forms.TextBox();
            this.btnClearData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(222, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(247, 24);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Rebate Form - Evaluation";
            // 
            // lblFlPath
            // 
            this.lblFlPath.AutoSize = true;
            this.lblFlPath.Location = new System.Drawing.Point(25, 63);
            this.lblFlPath.Name = "lblFlPath";
            this.lblFlPath.Size = new System.Drawing.Size(81, 13);
            this.lblFlPath.TabIndex = 1;
            this.lblFlPath.Text = "Select File Path";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(112, 60);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(357, 20);
            this.txtFilePath.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(486, 58);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(567, 58);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyze.TabIndex = 4;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // lvResultData
            // 
            this.lvResultData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colTime});
            this.lvResultData.HideSelection = false;
            this.lvResultData.Location = new System.Drawing.Point(28, 123);
            this.lvResultData.Name = "lvResultData";
            this.lvResultData.Size = new System.Drawing.Size(309, 324);
            this.lvResultData.TabIndex = 5;
            this.lvResultData.UseCompatibleStateImageBehavior = false;
            this.lvResultData.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 200;
            // 
            // colTime
            // 
            this.colTime.Text = "TimeTaken";
            this.colTime.Width = 100;
            // 
            // lblNoOfRecs
            // 
            this.lblNoOfRecs.AutoSize = true;
            this.lblNoOfRecs.Location = new System.Drawing.Point(456, 130);
            this.lblNoOfRecs.Name = "lblNoOfRecs";
            this.lblNoOfRecs.Size = new System.Drawing.Size(105, 13);
            this.lblNoOfRecs.TabIndex = 6;
            this.lblNoOfRecs.Text = "Number of Records :";
            // 
            // lblMinEntryTime
            // 
            this.lblMinEntryTime.AutoSize = true;
            this.lblMinEntryTime.Location = new System.Drawing.Point(454, 165);
            this.lblMinEntryTime.Name = "lblMinEntryTime";
            this.lblMinEntryTime.Size = new System.Drawing.Size(107, 13);
            this.lblMinEntryTime.TabIndex = 7;
            this.lblMinEntryTime.Text = "Minimum Entry Time :";
            this.lblMinEntryTime.Click += new System.EventHandler(this.lblMinEntryTime_Click);
            // 
            // lblMaxEntryTime
            // 
            this.lblMaxEntryTime.AutoSize = true;
            this.lblMaxEntryTime.Location = new System.Drawing.Point(451, 200);
            this.lblMaxEntryTime.Name = "lblMaxEntryTime";
            this.lblMaxEntryTime.Size = new System.Drawing.Size(110, 13);
            this.lblMaxEntryTime.TabIndex = 8;
            this.lblMaxEntryTime.Text = "Maximum Entry Time :";
            // 
            // lblMaxIntRecTime
            // 
            this.lblMaxIntRecTime.AutoSize = true;
            this.lblMaxIntRecTime.Location = new System.Drawing.Point(422, 298);
            this.lblMaxIntRecTime.Name = "lblMaxIntRecTime";
            this.lblMaxIntRecTime.Size = new System.Drawing.Size(139, 13);
            this.lblMaxIntRecTime.TabIndex = 11;
            this.lblMaxIntRecTime.Text = "Maximum inter-record Time :";
            // 
            // lblMinIntRecTime
            // 
            this.lblMinIntRecTime.AutoSize = true;
            this.lblMinIntRecTime.Location = new System.Drawing.Point(425, 265);
            this.lblMinIntRecTime.Name = "lblMinIntRecTime";
            this.lblMinIntRecTime.Size = new System.Drawing.Size(136, 13);
            this.lblMinIntRecTime.TabIndex = 10;
            this.lblMinIntRecTime.Text = "Minimum inter-record Time :";
            // 
            // lblAvgEntryTIme
            // 
            this.lblAvgEntryTIme.AutoSize = true;
            this.lblAvgEntryTIme.Location = new System.Drawing.Point(455, 233);
            this.lblAvgEntryTIme.Name = "lblAvgEntryTIme";
            this.lblAvgEntryTIme.Size = new System.Drawing.Size(106, 13);
            this.lblAvgEntryTIme.TabIndex = 9;
            this.lblAvgEntryTIme.Text = "Average Entry Time :";
            // 
            // lblBkSpcCount
            // 
            this.lblBkSpcCount.AutoSize = true;
            this.lblBkSpcCount.Location = new System.Drawing.Point(463, 400);
            this.lblBkSpcCount.Name = "lblBkSpcCount";
            this.lblBkSpcCount.Size = new System.Drawing.Size(98, 13);
            this.lblBkSpcCount.TabIndex = 14;
            this.lblBkSpcCount.Text = "Backspace Count :";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Location = new System.Drawing.Point(501, 365);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(60, 13);
            this.lblTotalTime.TabIndex = 13;
            this.lblTotalTime.Text = "TotalTime :";
            // 
            // lblAvgIntRecTime
            // 
            this.lblAvgIntRecTime.AutoSize = true;
            this.lblAvgIntRecTime.Location = new System.Drawing.Point(426, 330);
            this.lblAvgIntRecTime.Name = "lblAvgIntRecTime";
            this.lblAvgIntRecTime.Size = new System.Drawing.Size(135, 13);
            this.lblAvgIntRecTime.TabIndex = 12;
            this.lblAvgIntRecTime.Text = "Average inter-record Time :";
            // 
            // txtNoOfRec
            // 
            this.txtNoOfRec.Location = new System.Drawing.Point(567, 127);
            this.txtNoOfRec.Name = "txtNoOfRec";
            this.txtNoOfRec.ReadOnly = true;
            this.txtNoOfRec.Size = new System.Drawing.Size(37, 20);
            this.txtNoOfRec.TabIndex = 15;
            // 
            // txtMinEntryTIme
            // 
            this.txtMinEntryTIme.Location = new System.Drawing.Point(567, 162);
            this.txtMinEntryTIme.Name = "txtMinEntryTIme";
            this.txtMinEntryTIme.ReadOnly = true;
            this.txtMinEntryTIme.Size = new System.Drawing.Size(37, 20);
            this.txtMinEntryTIme.TabIndex = 16;
            // 
            // txtAvgEntryTime
            // 
            this.txtAvgEntryTime.Location = new System.Drawing.Point(567, 230);
            this.txtAvgEntryTime.Name = "txtAvgEntryTime";
            this.txtAvgEntryTime.ReadOnly = true;
            this.txtAvgEntryTime.Size = new System.Drawing.Size(37, 20);
            this.txtAvgEntryTime.TabIndex = 18;
            // 
            // txtMaxEntryTime
            // 
            this.txtMaxEntryTime.Location = new System.Drawing.Point(567, 197);
            this.txtMaxEntryTime.Name = "txtMaxEntryTime";
            this.txtMaxEntryTime.ReadOnly = true;
            this.txtMaxEntryTime.Size = new System.Drawing.Size(37, 20);
            this.txtMaxEntryTime.TabIndex = 17;
            // 
            // txtMaxIntRecTime
            // 
            this.txtMaxIntRecTime.Location = new System.Drawing.Point(567, 295);
            this.txtMaxIntRecTime.Name = "txtMaxIntRecTime";
            this.txtMaxIntRecTime.ReadOnly = true;
            this.txtMaxIntRecTime.Size = new System.Drawing.Size(37, 20);
            this.txtMaxIntRecTime.TabIndex = 20;
            // 
            // txtMinIntRecTime
            // 
            this.txtMinIntRecTime.Location = new System.Drawing.Point(567, 262);
            this.txtMinIntRecTime.Name = "txtMinIntRecTime";
            this.txtMinIntRecTime.ReadOnly = true;
            this.txtMinIntRecTime.Size = new System.Drawing.Size(37, 20);
            this.txtMinIntRecTime.TabIndex = 19;
            // 
            // txtTotalTime
            // 
            this.txtTotalTime.Location = new System.Drawing.Point(567, 362);
            this.txtTotalTime.Name = "txtTotalTime";
            this.txtTotalTime.ReadOnly = true;
            this.txtTotalTime.Size = new System.Drawing.Size(37, 20);
            this.txtTotalTime.TabIndex = 22;
            // 
            // txtAvgIntRecTime
            // 
            this.txtAvgIntRecTime.Location = new System.Drawing.Point(567, 327);
            this.txtAvgIntRecTime.Name = "txtAvgIntRecTime";
            this.txtAvgIntRecTime.ReadOnly = true;
            this.txtAvgIntRecTime.Size = new System.Drawing.Size(37, 20);
            this.txtAvgIntRecTime.TabIndex = 21;
            // 
            // txtBkSpcCount
            // 
            this.txtBkSpcCount.Location = new System.Drawing.Point(567, 397);
            this.txtBkSpcCount.Name = "txtBkSpcCount";
            this.txtBkSpcCount.ReadOnly = true;
            this.txtBkSpcCount.Size = new System.Drawing.Size(37, 20);
            this.txtBkSpcCount.TabIndex = 23;
            // 
            // btnClearData
            // 
            this.btnClearData.Location = new System.Drawing.Point(518, 439);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(75, 23);
            this.btnClearData.TabIndex = 24;
            this.btnClearData.Text = "Clear Data";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 510);
            this.Controls.Add(this.btnClearData);
            this.Controls.Add(this.txtBkSpcCount);
            this.Controls.Add(this.txtTotalTime);
            this.Controls.Add(this.txtAvgIntRecTime);
            this.Controls.Add(this.txtMaxIntRecTime);
            this.Controls.Add(this.txtMinIntRecTime);
            this.Controls.Add(this.txtAvgEntryTime);
            this.Controls.Add(this.txtMaxEntryTime);
            this.Controls.Add(this.txtMinEntryTIme);
            this.Controls.Add(this.txtNoOfRec);
            this.Controls.Add(this.lblBkSpcCount);
            this.Controls.Add(this.lblTotalTime);
            this.Controls.Add(this.lblAvgIntRecTime);
            this.Controls.Add(this.lblMaxIntRecTime);
            this.Controls.Add(this.lblMinIntRecTime);
            this.Controls.Add(this.lblAvgEntryTIme);
            this.Controls.Add(this.lblMaxEntryTime);
            this.Controls.Add(this.lblMinEntryTime);
            this.Controls.Add(this.lblNoOfRecs);
            this.Controls.Add(this.lvResultData);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.lblFlPath);
            this.Controls.Add(this.lblHeading);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblFlPath;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.ListView lvResultData;
        private System.Windows.Forms.Label lblNoOfRecs;
        private System.Windows.Forms.Label lblMinEntryTime;
        private System.Windows.Forms.Label lblMaxEntryTime;
        private System.Windows.Forms.Label lblMaxIntRecTime;
        private System.Windows.Forms.Label lblMinIntRecTime;
        private System.Windows.Forms.Label lblAvgEntryTIme;
        private System.Windows.Forms.Label lblBkSpcCount;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label lblAvgIntRecTime;
        private System.Windows.Forms.TextBox txtNoOfRec;
        private System.Windows.Forms.TextBox txtMinEntryTIme;
        private System.Windows.Forms.TextBox txtAvgEntryTime;
        private System.Windows.Forms.TextBox txtMaxEntryTime;
        private System.Windows.Forms.TextBox txtMaxIntRecTime;
        private System.Windows.Forms.TextBox txtMinIntRecTime;
        private System.Windows.Forms.TextBox txtTotalTime;
        private System.Windows.Forms.TextBox txtAvgIntRecTime;
        private System.Windows.Forms.TextBox txtBkSpcCount;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colTime;
    }
}

