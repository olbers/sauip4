using System;
using System.Text;
using System.Windows.Forms;
using NRM.Analytics;
using NRM.OO;
using NRM.ExportToFile;
using System.Windows.Media;
using System.Threading;
using System.Windows;
using System.IO;

namespace NRM
{
    public partial class PlayListBuilder : Form
    {
        /// <summary>
        /// fields related to the song play
        /// </summary>
        private bool                    disposedSound   = false;
        private FMOD.System             system          = null;
        private FMOD.Sound              sound           = null;
        private FMOD.Channel            channel         = null;
        private FMOD.DSP                mydsp           = null;
        private FMOD.DSP_DESCRIPTION    dspdesc         = new FMOD.DSP_DESCRIPTION();
        private String                  dspname         = "BPM Detection DSP                 ";
        private FMOD.DSP_READCALLBACK   dspreadcallback = new FMOD.DSP_READCALLBACK(READCALLBACK);
        private static StringBuilder    name            = new StringBuilder(256);
        private static FMOD.DSP         thisdsp         = new FMOD.DSP();
        private static BPMDetection     bpm             = new BPMDetection();
        
        /// <summary>
        /// fields to handle data
        /// </summary>
        private SongDataColl            _songCollection = new SongDataColl();
        private SongData                _currentSong    = null;

        private SongDataColl            _newSongCollection = new SongDataColl();
        private int                     _currentPosition   = 0;

        /// <summary>
        /// Default constructor
        /// </summary>
        public PlayListBuilder()
        {
            InitializeComponent();
            _songCollection = LoadPlaylist(@"c:\playlist.xml");
            InitializeBindings();
        }
        /// <summary>
        /// Load Playlist from previously created xml file
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private SongDataColl LoadPlaylist(string path)
        {
            if (!File.Exists(path))
            {
                PlaylistToXML.ExportPlaylist(new SongDataColl(), path);
            }
            return PlaylistToXML.ImportPlaylist(path);
        }
        /// <summary>
        /// Bindings Initialization
        /// </summary>
        private void InitializeBindings()
        {
            _dgPlaylist.AutoGenerateColumns = false;
            _bindingSourcePlaylist.DataSource = _songCollection;
            _dgPlaylist.Columns[0].Width = 200;
            _dgPlaylist.Columns[1].Width = 50;
            _dgPlaylist.Columns[2].Width = 40;
            _dgPlaylist.DataSource = _bindingSourcePlaylist;
            
        }
        /// <summary>
        /// Initialize variable 
        /// </summary>
        private void InitializeSound()
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
        /// <summary>
        /// Button open
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _buttonCalculate_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (var filename in openFileDialog1.FileNames)
                {
                    _currentSong = new SongData() { FullName = filename };
                    bool exists = false;
                    foreach (var item in _songCollection)
                    {
                        if (item.FullName == _currentSong.FullName)
                        {
                            exists = true;
                            break;
                        }
                    }

                    if (!exists)
                        _newSongCollection.Add(_currentSong);
                }
                if(_newSongCollection.Count > 0)
                {
                    MoveNextSong();
                }
                else
                {
                    MessageBox.Show("This song is already in the playlist.",
                     "Song already in the playlist.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }
        /// <summary>
        /// Method responsible for getting the file and playing the song
        /// </summary>
        private void PlayMusic()
        {
            InitializeSound();

            FMOD.RESULT result = FMOD.RESULT.OK;

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

            result = system.createSound(_currentSong.FullName, FMOD.MODE.SOFTWARE | FMOD.MODE.CREATESTREAM, ref sound);
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
            channel.setVolume(0.1f);
        }
        /// <summary>
        /// Method responsible for disposing the variables that play the songs
        /// </summary>
        private void DisposeSound()
        {
            timer1.Stop();
            FMOD.RESULT result;

            if (sound != null)
            {
                result = sound.release();
                ERRCHECK(result);
            }
            sound = null;

            if (system != null)
            {
                result = system.close();
                ERRCHECK(result);

                result = system.release();
                ERRCHECK(result);
            }
            mydsp = null;
        }

        /// <summary>
        /// timer tick event to update the interface
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            _textboxSongPlaying.Text = _currentSong.Name; 
            _textBoxBPM.Text =
                "BPM: " + bpm.getParameter(BPMDetection.BPMParam.BPMFOUNDBPM).ToString("0.00") +
                " | Accuracy: " + bpm.getParameter(BPMDetection.BPMParam.BPMNROFBEATS).ToString("00") +
                " | Accuracy: " + bpm.getParameter(BPMDetection.BPMParam.BPMBEATLOOP).ToString("0");
            
            //Adicionar musica à playlist após detecção dos BPM's
            if (
                Convert.ToInt32(
                            bpm.getParameter(BPMDetection.BPMParam.BPMNROFBEATS).ToString("00")
                            ) >= 5)
            {
                DisposeSound();
                disposedSound = true;
                
                _textboxSongPlaying.Text = _textBoxBPM.Text = "";

                AddMusicToCollection();
                _currentPosition++;
                MoveNextSong();
            }   
            system.update();
        }
        /// <summary>
        /// Get BPMs from the next song 
        /// </summary>
        private void MoveNextSong()
        {
            if (_currentPosition == _newSongCollection.Count) return;
            _currentSong = _newSongCollection[_currentPosition];
            PlayMusic();
            timer1.Start();
        }
        /// <summary>
        /// Method that adds a song to the collection through the databind
        /// </summary>
        private void AddMusicToCollection()
        {
            string songLength = "0";
            _currentSong.BPM    = 
                Convert.ToInt32(bpm.getParameter(BPMDetection.BPMParam.BPMFOUNDBPM).ToString("00"));
            _currentSong.LengthSeconds = GetMp3Length(_currentSong.FullName, ref songLength);
            _currentSong.Length = songLength;
            _bindingSourcePlaylist.Add(_currentSong);
            
        }
        /// <summary>
        /// Readcallback
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
        /// <summary>
        /// Event handler of the Export Playlist button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _buttonExportPlaylist_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_textBoxDistance.Text) || string.IsNullOrEmpty(_textBoxDuration.Text))
            {
                MessageBox.Show("Please insert the distance and duration of your run.", "Build Playlist.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (string.IsNullOrEmpty(_textBoxDistance.Text)) _textBoxDistance.Focus();
                else _textBoxDuration.Focus();
                return;
            }
            int intValidation1;
            int intValidation2;
            int.TryParse(_textBoxDistance.Text, out intValidation1);
            int.TryParse(_textBoxDuration.Text, out intValidation2);
            if ( intValidation1 == 0 || intValidation2 == 0  )
            {
                MessageBox.Show("Please insert valid distance and duration of your run.", "Build Playlist.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (intValidation1 == 0) _textBoxDistance.Focus();
                else _textBoxDuration.Focus();
                return;
            }
            BPMInterval bpm = NRMAnalytics.GetBPM(int.Parse(_textBoxDistance.Text), int.Parse(_textBoxDuration.Text));

            lBPM.Text = "" + (bpm.Value * int.Parse(_textBoxDuration.Text));
 


        }

        private void ExportPlaylist()
        {
            BPMInterval bpmInterval = new BPMInterval();
            bpmInterval = NRMAnalytics.GetBPM(
                Convert.ToInt32(_textBoxDistance.Text),
                Convert.ToInt32(_textBoxDuration.Text));
            //TODO:Remove this code and determine the calculator formula
            //bpmInterval.MinBPM = 0;
            //bpmInterval.MaxBPM = 200;

            SongDataColl playlist = GetSongsWithBPM(bpmInterval);
            string path = "c:\\";
            PlaylistToXML.ExportPlaylist(playlist, path);
            
            MessageBox.Show("Playlist exported to the folder: " + path, "Export Playlist.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Method that will filter the current playlist and return the songs that are acording to the correct BPM Interval
        /// </summary>
        /// <param name="bpmInterval"> Interval of BPM's allowed in the playlist</param>
        /// <returns>Playlist of songs with the beats per minute acording to the passed interval</returns>
        private SongDataColl GetSongsWithBPM(BPMInterval bpmInterval)
        {
            SongDataColl playlist = new SongDataColl();
            foreach (var song in _songCollection)
            {
                if( song.BPM <= bpmInterval.MaxBPM && song.BPM >= bpmInterval.MinBPM )
                    playlist.Add(song);
            }
            return playlist;
        }
        /// <summary>
        /// Get song's length
        /// </summary>
        /// <param name="filename">Path to the file</param>
        /// <returns>string with the number of </returns>
        private int GetMp3Length(string filename, ref string length)
        {
            int totalSeconds = 0;
            MediaPlayer player = new MediaPlayer();
            Uri path = new Uri(@filename);
            player.Open(path);
           
            Thread.Sleep(3000);
            Duration duration = player.NaturalDuration;

            if (duration.HasTimeSpan)
            {
                length = player.NaturalDuration.TimeSpan.Minutes.ToString() + ":";
                if (player.NaturalDuration.TimeSpan.Seconds < 10)
                    length += "0";
                length += player.NaturalDuration.TimeSpan.Seconds.ToString();
                totalSeconds = (int)Math.Round(player.NaturalDuration.TimeSpan.TotalSeconds, 0);
            }
            player.Close();
            return totalSeconds;
        }
    }
}
