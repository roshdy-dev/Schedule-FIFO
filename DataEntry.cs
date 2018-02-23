using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling
{
    public partial class DataEntry : Form
    {
        Form1 scheduleForm;
        Schedule scheduler;
       public int index = 1;
        public DataEntry()
        {
            InitializeComponent();
            scheduleForm = new Form1();
            scheduleForm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (index == 1)
            {
                SchedulesList.totalArrival = 0;
                scheduler = new Schedule(index, 0, (int)txtService.Value);
                SchedulesList.schedules.Add(scheduler);
                scheduler.setSchedule();
                index++;
                txtArrival.Minimum = txtArrival.Value + 1;
            }
            else if (index > 1)
            {
                SchedulesList.totalArrival += Convert.ToInt32(txtArrival.Value);
                scheduler = new Schedule(index, Convert.ToInt32(txtArrival.Value), (int)txtService.Value);
                SchedulesList.schedules.Add(scheduler);
                scheduler.setSchedule();
                index++;
                txtArrival.Minimum = txtArrival.Value+1;
            }


        }
    }
    public static class SchedulesList
    {
        public static List<Schedule> schedules = new List<Schedule>();
        public static int totalArrival { get; set; }
        public static int lastEnd { get; set; }
    }
    public class Schedule
    {
        public Schedule(int jobNumber, int arrival, int service)
        {
            this.JobNumber = jobNumber;
            this.InterArrival = arrival;
            this.Service = service;
            this.Arrival = SchedulesList.totalArrival;
//            this.setArrival();
            //this.setSchedule();
        }

        public int JobNumber { get; set; }
        public int InterArrival { get; set; }
        public int Arrival { get; set; }
        public int Service { get; set; }
        public int Start { get; set; }
        public int End { get; set; }
        public int Waiting { get; set; }
        public int Idle { get; set; }
        public int TimeInSystem { get; set; }

      
       public void setSchedule()
        {
            if (this.JobNumber == 1)
            {
                this.Start = 0;
                this.End = this.Service;
                SchedulesList.lastEnd = this.End;
                this.TimeInSystem = this.End - this.Arrival;
                this.Waiting = 0;
                this.Idle = 0;
            }
            else
            {
             if (this.Arrival == SchedulesList.lastEnd)
            {
                this.Start = SchedulesList.lastEnd;
                this.End = this.Start + this.Service;
                SchedulesList.lastEnd = this.End;
                this.TimeInSystem = this.End - this.Arrival;
                this.Waiting = 0;
                this.Idle = 0;
            }
            else if (this.Arrival < SchedulesList.lastEnd)
            {
                this.Start = SchedulesList.lastEnd;
                this.End = this.Start + this.Service;
                SchedulesList.lastEnd = this.End;
                this.TimeInSystem = this.End - this.Arrival;
                this.Waiting = this.Start - this.Arrival;
                this.Idle = 0;
            }
            else if (this.Arrival > SchedulesList.lastEnd)
            {
                this.Start = this.Arrival;
                this.End = this.Start + this.Service;
                this.Idle = this.Arrival - SchedulesList.lastEnd;
                    SchedulesList.lastEnd = this.End;
                this.TimeInSystem = this.End - this.Arrival;
                this.Waiting = 0;
              
            }
            }
        }
    }

}
