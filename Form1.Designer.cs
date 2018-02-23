namespace Scheduling
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lvDisplay = new System.Windows.Forms.ListView();
            this.chJob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chInterArrival = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chArrival = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chService = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chWaiting = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTimeInSystem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chIdle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblAWT = new System.Windows.Forms.Label();
            this.lblATS = new System.Windows.Forms.Label();
            this.lblUtilization = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(36, 24);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(207, 23);
            this.btnSchedule.TabIndex = 1;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(422, 24);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(217, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lvDisplay
            // 
            this.lvDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chJob,
            this.chInterArrival,
            this.chArrival,
            this.chStart,
            this.chService,
            this.chEnd,
            this.chWaiting,
            this.chTimeInSystem,
            this.chIdle});
            this.lvDisplay.Location = new System.Drawing.Point(36, 79);
            this.lvDisplay.Name = "lvDisplay";
            this.lvDisplay.Size = new System.Drawing.Size(657, 237);
            this.lvDisplay.TabIndex = 3;
            this.lvDisplay.UseCompatibleStateImageBehavior = false;
            this.lvDisplay.View = System.Windows.Forms.View.Details;
            // 
            // chJob
            // 
            this.chJob.Text = "Job";
            this.chJob.Width = 64;
            // 
            // chInterArrival
            // 
            this.chInterArrival.Text = "Inter Arrival";
            this.chInterArrival.Width = 83;
            // 
            // chArrival
            // 
            this.chArrival.Text = "Arrival";
            this.chArrival.Width = 73;
            // 
            // chStart
            // 
            this.chStart.Text = "Start";
            this.chStart.Width = 70;
            // 
            // chService
            // 
            this.chService.Text = "Service";
            this.chService.Width = 81;
            // 
            // chEnd
            // 
            this.chEnd.Text = "End";
            this.chEnd.Width = 71;
            // 
            // chWaiting
            // 
            this.chWaiting.Text = "Waiting";
            this.chWaiting.Width = 63;
            // 
            // chTimeInSystem
            // 
            this.chTimeInSystem.Text = "Time in System";
            this.chTimeInSystem.Width = 96;
            // 
            // chIdle
            // 
            this.chIdle.Text = "Idle";
            this.chIdle.Width = 52;
            // 
            // lblAWT
            // 
            this.lblAWT.AutoSize = true;
            this.lblAWT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAWT.Location = new System.Drawing.Point(46, 362);
            this.lblAWT.Name = "lblAWT";
            this.lblAWT.Size = new System.Drawing.Size(0, 25);
            this.lblAWT.TabIndex = 4;
            // 
            // lblATS
            // 
            this.lblATS.AutoSize = true;
            this.lblATS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblATS.Location = new System.Drawing.Point(46, 421);
            this.lblATS.Name = "lblATS";
            this.lblATS.Size = new System.Drawing.Size(0, 25);
            this.lblATS.TabIndex = 5;
            // 
            // lblUtilization
            // 
            this.lblUtilization.AutoSize = true;
            this.lblUtilization.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilization.Location = new System.Drawing.Point(46, 481);
            this.lblUtilization.Name = "lblUtilization";
            this.lblUtilization.Size = new System.Drawing.Size(0, 25);
            this.lblUtilization.TabIndex = 6;
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredits.Location = new System.Drawing.Point(46, 588);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(0, 24);
            this.lblCredits.TabIndex = 7;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(422, 338);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Jobs";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 663);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.lblUtilization);
            this.Controls.Add(this.lblATS);
            this.Controls.Add(this.lblAWT);
            this.Controls.Add(this.lvDisplay);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSchedule);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(600, 0);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Scheduling";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListView lvDisplay;
        private System.Windows.Forms.ColumnHeader chJob;
        private System.Windows.Forms.ColumnHeader chInterArrival;
        private System.Windows.Forms.ColumnHeader chArrival;
        private System.Windows.Forms.ColumnHeader chStart;
        private System.Windows.Forms.ColumnHeader chService;
        private System.Windows.Forms.ColumnHeader chEnd;
        private System.Windows.Forms.ColumnHeader chWaiting;
        private System.Windows.Forms.ColumnHeader chTimeInSystem;
        private System.Windows.Forms.ColumnHeader chIdle;
        private System.Windows.Forms.Label lblAWT;
        private System.Windows.Forms.Label lblATS;
        private System.Windows.Forms.Label lblUtilization;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

