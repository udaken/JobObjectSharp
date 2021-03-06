﻿using System;
using System.Diagnostics;
using System.Threading;
using JobObjectSharp;

namespace JobObjectSharp.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var process = Process.Start("notepad.exe");
            process.WaitForInputIdle();

            using (var job = JobObject.CreateAsKillOnJobClose())
            {
                job.AssignProcess(process);
                
            } // notepad.exe killed
        }
    }
}
