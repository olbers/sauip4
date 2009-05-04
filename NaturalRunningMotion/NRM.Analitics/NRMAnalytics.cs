using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NRM.OO;

namespace NRM.Analytics
{
    public static class NRMAnalytics
    {
        public static WiiData     _wiiData;
        public static BPMInterval   _bpmInterval;
        /// <summary>
        /// Method that returns and interval of the BPM that a song should have to help a person
        /// run a certain distance in a certain time
        /// </summary>
        /// <param name="distance">Distance to run</param>
        /// <param name="timeMinutes">Time to run</param>
        /// <returns>Interval of BPM's determined by a minimun and maximum BPM</returns>
        public static BPMInterval GetBPM(float distance, int timeMinutes)
        {
            float bpm = CalculateBPM(distance, timeMinutes);

            _bpmInterval = new BPMInterval() { MinBPM = (int)(bpm - 50), MaxBPM = (int)(bpm + 50) };

            return _bpmInterval;
        }
        /// <summary>
        /// Method that is responsible for calculating the optimal amount of bpm to make a certain 
        /// course in a predetermined time
        /// </summary>
        /// <param name="distance">Distance to run</param>
        /// <param name="timeMinutes">Time to do the run in minutes</param>
        /// <returns></returns>
        private static float CalculateBPM(float distance, int timeMinutes)
        {
            float bpm = distance / timeMinutes;
            return bpm;
        }
    }
}
