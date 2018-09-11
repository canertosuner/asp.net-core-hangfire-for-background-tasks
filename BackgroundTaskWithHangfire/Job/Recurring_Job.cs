using System;
using Hangfire;

namespace BackgroundTaskWithHangfire.Job
{
    public class Recurring_Job
    {
        public Recurring_Job()
        {
            //Recurring job
            RecurringJob.AddOrUpdate(() => ProcessRecurringJob(), Cron.Hourly);
        }

        public void ProcessRecurringJob()
        {
            Console.WriteLine("I am a Recurring Job !!");
        }
    }
}
