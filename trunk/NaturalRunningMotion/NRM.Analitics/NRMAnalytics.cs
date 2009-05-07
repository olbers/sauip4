using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NRM.OO;

namespace NRM.Analytics
{
    public static class NRMAnalytics
    {
        public static Dictionary<int, int>  _bpm = new Dictionary<int, int>();
        public static WiiData               _wiiData;
        public static BPMInterval           _bpmInterval;
        public static bool                  _initialized = false;
        /// <summary>
        /// Initialize bpm dictionary
        /// </summary>
        public static void InitializeBPMs()
        {
            //With our reference table we pick the SPM and correspondently BPM
            // Time per km         SPM/BPM
            //      10               150
            //       9               153
            //       8               156
            //       7               160
            //       6               163
            //       5               166
            //       4               171
            _bpm.Add(10,150);
            _bpm.Add(9, 153);
            _bpm.Add(8, 156);
            _bpm.Add(7, 160);
            _bpm.Add(6, 163);
            _bpm.Add(5, 166);
            _initialized = true;
        }
        /// <summary>
        /// Method that returns and interval of the BPM that a song should have to help a person
        /// run a certain distance in a certain time
        /// </summary>
        /// <param name="distance">Distance to run</param>
        /// <param name="timeMinutes">Time to run</param>
        /// <returns>Interval of BPM's determined by a minimun and maximum BPM</returns>
        public static BPMInterval GetBPM(int distance, int timeMinutes)
        {
            float bpm = CalculateBPM(distance, timeMinutes);

            _bpmInterval = new BPMInterval() { MinBPM = (int)(bpm - 15), MaxBPM = (int)(bpm + 15), Value = (int) Math.Round(bpm,0) };

            return _bpmInterval;
        }
        /// <summary>
        /// Method that is responsible for calculating the optimal amount of bpm to make a certain 
        /// course in a predetermined time
        /// </summary>
        /// <param name="distance">Distance to run</param>
        /// <param name="timeMinutes">Time to do the run in minutes</param>
        /// <returns></returns>
        private static float CalculateBPM(int distance, int timeMinutes)
        {
            if(!_initialized)
                InitializeBPMs();
            //calculate time per km
            int tpk = (int) Math.Round((decimal) (timeMinutes * 1000 / distance), 0);
             
            //get bpm trough reference table
            int bpm = 0;
            if(_bpm.ContainsKey(tpk))
            {
                bpm= _bpm[tpk];
            }
            return bpm;
        }
    }
}
