using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NRM.Analytics;
using System.Runtime.InteropServices;

namespace NRM
{
    public partial class PlayListBuilder : Form
    {
        private FMOD.System     system = null;
        private FMOD.Sound      sound = null;
        private FMOD.Channel    channel = null;
        private FMOD.DSP        mydsp = null;

        private FMOD.DSP_DESCRIPTION    dspdesc = new FMOD.DSP_DESCRIPTION();
        private String                  dspname = "BPM Detection DSP                 ";
        private FMOD.DSP_READCALLBACK   dspreadcallback = new FMOD.DSP_READCALLBACK(READCALLBACK);
        private static StringBuilder    name = new StringBuilder(256);
        private static FMOD.DSP         thisdsp = new FMOD.DSP();

        private OpenFileDialog openFileDialog1;


        private static BPMDetection bpm = new BPMDetection();

        private System.Windows.Forms.Timer timer1;

        public PlayListBuilder()
        {
            InitializeComponent();
        }
        private void PlayListBuilder_Load(object sender, EventArgs e)
        {
            uint version = 0;
            FMOD.RESULT result;

            /*
                Create a System object and initialize.
            */
            result = FMOD.Factory.System_Create(ref system);
            ERRCHECK(result);

            result = system.getVersion(ref version);
            ERRCHECK(result);
            if (version < FMOD.VERSION.number)
            {
                MessageBox.Show("Error!  You are using an old version of FMOD " + version.ToString("X") + ".  This program requires " + FMOD.VERSION.number.ToString("X") + ".");
                Application.Exit();
            }

            system.setSoftwareFormat(44100, FMOD.SOUND_FORMAT.PCM16, 2, 0, FMOD.DSP_RESAMPLER.CUBIC);
            result = system.init(32, FMOD.INITFLAG.NORMAL, (IntPtr)null);
            ERRCHECK(result);

        }
        private void _buttonCalculate_Click(object sender, EventArgs e)
        {
            FMOD.RESULT result = FMOD.RESULT.OK;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (mydsp != null)
                {
                    mydsp.remove();
                }

                if (sound != null)
                {
                    result = sound.release();
                    ERRCHECK(result);
                }

                bpm.reset();

                result = system.createSound(openFileDialog1.FileName, FMOD.MODE.SOFTWARE | FMOD.MODE.CREATESTREAM, ref sound);
                ERRCHECK(result);

                result = system.playSound(FMOD.CHANNELINDEX.FREE, sound, true, ref channel);
                ERRCHECK(result);

                /*
                    Create DSP unit
                */
                dspdesc.name = dspname.ToCharArray(0, 32);
                dspdesc.channels = 0;
                dspdesc.read = dspreadcallback;

                result = system.createDSP(ref dspdesc, ref mydsp);
                ERRCHECK(result);

                result = system.addDSP(mydsp);
                ERRCHECK(result);

                result = mydsp.setActive(true);
                ERRCHECK(result);

                channel.setPaused(false);
                timer1.Start();
            }
        }
        /// <summary>
        /// timer tick event to update the interface
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            _textBoxBPM.Text = "BPM: " + bpm.getParameter(BPMDetection.BPMParam.BPMFOUNDBPM).ToString("0.00") +
                " | Accuracy: " + bpm.getParameter(BPMDetection.BPMParam.BPMNROFBEATS).ToString("00") +
                " | Accuracy: " + bpm.getParameter(BPMDetection.BPMParam.BPMBEATLOOP).ToString("0");

            system.update();
        }
        /// <summary>
        /// REadcallback
        /// </summary>
        /// <param name="dsp_state"></param>
        /// <param name="inbuf"></param>
        /// <param name="outbuf"></param>
        /// <param name="length"></param>
        /// <param name="inchannels"></param>
        /// <param name="outchannels"></param>
        /// <returns></returns>
        private static FMOD.RESULT READCALLBACK(ref FMOD.DSP_STATE dsp_state, IntPtr inbuf, IntPtr outbuf, uint length, int inchannels, int outchannels)
        {
            uint count = 0;
            int count2 = 0;
            IntPtr thisdspraw = dsp_state.instance;

            thisdsp.setRaw(thisdspraw);

            unsafe
            {
                float* inbuffer = (float*)inbuf.ToPointer();
                float* outbuffer = (float*)outbuf.ToPointer();

                for (count = 0; count < length; count++)
                {
                    for (count2 = 0; count2 < outchannels; count2++)
                    {
                        outbuffer[(count * outchannels) + count2] = inbuffer[(count * inchannels) + count2];
                    }
                    bpm.AddSample(inbuffer[(count * inchannels)] * 32767.0f);
                }
            }

            return FMOD.RESULT.OK;
        }
        /// <summary>
        /// Error check
        /// </summary>
        /// <param name="result"></param>
        private void ERRCHECK(FMOD.RESULT result)
        {
            if (result != FMOD.RESULT.OK)
            {
                timer1.Stop();
                MessageBox.Show("FMOD error! " + result + " - " + FMOD.Error.String(result));
                Environment.Exit(-1);
            }
        }


    }
}
