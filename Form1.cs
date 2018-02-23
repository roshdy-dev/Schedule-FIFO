using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Scheduling
{

    public partial class Form1 : Form
    {
        ListViewItem lvItem;


        public Form1()
        {
            InitializeComponent();
            lblCredits.Text = "Name: Student Name \n Student ID: Student's ID";
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            lvDisplay.Items.Clear();
            chart1.Series.Clear();
            chart1.Series.Add("Jobs");
            float totalWaiting=0;
            float totalTimeInSystem =0;
            float totalService = 0;
            foreach (var item in SchedulesList.schedules)
            {
                lvItem = new ListViewItem();
                lvItem.Text = item.JobNumber.ToString();
                lvItem.SubItems.Add(item.InterArrival.ToString());
                lvItem.SubItems.Add(item.Arrival.ToString());
                lvItem.SubItems.Add(item.Start.ToString());
                lvItem.SubItems.Add(item.Service.ToString());
                totalService += item.Service;
                lvItem.SubItems.Add(item.End.ToString());
                lvItem.SubItems.Add(item.Waiting.ToString());
                totalWaiting += item.Waiting;
                lvItem.SubItems.Add(item.TimeInSystem.ToString());
                totalTimeInSystem += item.TimeInSystem;
                lvItem.SubItems.Add(item.Idle.ToString());
                lvDisplay.Items.Add(lvItem);
                chart1.Series["Jobs"].Points.AddXY(item.JobNumber, item.End);
            }
            try
            {

           
            chart1.Series["Jobs"].ChartType =
                        SeriesChartType.Column;
            chart1.Series["Jobs"].Color = System.Drawing.Color.Red;
            totalWaiting /= SchedulesList.schedules.Count;
            totalTimeInSystem /= SchedulesList.schedules.Count;
            totalService /= SchedulesList.schedules[SchedulesList.schedules.Count - 1].End;

            lblAWT.Text = "Average Waiting Time= " + totalWaiting.ToString("n2");
            lblATS.Text = "Average Time in System= " + totalTimeInSystem.ToString("n2");
            lblUtilization.Text = "Utilization is " + totalService.ToString("p2");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please do some jobs assigning before clicking Schedule\n");
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            lvDisplay.Items.Clear();
            chart1.Series.Clear();
            lblATS.Text = "";
            lblAWT.Text = "";
            lblUtilization.Text = "";
            chart1.Series.Clear();
            
            SchedulesList.schedules.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }


}
