using System;
using Hangfire;

namespace BackgroundTaskWithHangfire.Job
{
    public class ContinuationsJob
    {
        public ContinuationsJob()
        {
            var parentJobId = "1534353453133";

            //Continuations job
            BackgroundJob.ContinueWith(parentJobId, () => ProcessContinuationsJob());
        }

        public void ProcessContinuationsJob()
        {
            Console.WriteLine("I am a Recurring Job !!");
        }
    }
}
