using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WiimoteLib;
using NRM.ExportToFile;
using NRM.OO;

namespace NRM
{
    public partial class NRMWiiConnect : Form
    {
        private delegate void UpdateExtensionChangedDelegate(WiimoteExtensionChangedEventArgs args);
        /// <summary>
        /// Delegate that will handle the change event of the wiimote
        /// </summary>
        /// <param name="args"></param>
        private delegate void UpdateWiimoteStateDelegate(WiimoteChangedEventArgs args);
        /// <summary>
        /// field of the type Wiimote resposible for the interactions and handling 
        /// of the data of the wiimote
        /// </summary>
        Wiimote wm = new Wiimote();
        /// <summary>
        /// Field responsible for the storage of the data from the Wiimote
        /// </summary>
        private WiiDataColl _wiimoteAccelValues = new WiiDataColl();
        /// <summary>
        /// Field responsible for the storage of the data from the Nunchuk
        /// </summary>
        private WiiDataColl _nunchukAccelValues = new WiiDataColl();
        /// <summary>
        /// Field that controls weather the movements are registered or not
        /// </summary>
        private bool readFlag = false;
        /// <summary>
        /// Default constructor
        /// </summary>
        public NRMWiiConnect()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Method with the responsibility of initiating the connection with the wiimote and adding the event 
        /// responsible for the handling of the update event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NRMMain_Load(object sender, EventArgs e)
        {
            try
            {
                //adding the event to the changed event of the wiimote
                wm.WiimoteChanged += WiimoteChanged;
                wm.WiimoteExtensionChanged += WiimoteExtensionChanged;
                //Make the connection to the wiimote
                wm.Connect();

                wm.SetReportType(InputReport.IRExtensionAccel, IRSensitivity.Maximum, true);
                wm.SetLEDs(true, false, false, false);
            }
            catch (Exception)
            {
                MessageBox.Show("Please check to see if the wiimote is correctly connected to the system and try again",
                    "No wiimote found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }

        }
        /// <summary>
        /// Event handler for the wiimote changed event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void WiimoteChanged(object sender, WiimoteChangedEventArgs args)
        {
            UpdateState(args);
        }
        /// <summary>
        /// Event handler for the extensions changed event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void WiimoteExtensionChanged(object sender, WiimoteExtensionChangedEventArgs args)
        {
            if (args.Inserted)
                wm.SetReportType(InputReport.IRExtensionAccel, true);
            else
                wm.SetReportType(InputReport.IRAccel, true);
        }
        /// <summary>
        /// Method responsible for the calling of the delegate wich will treat each change in his thread
        /// </summary>
        /// <param name="args">Arguments containing the data from the wiimote</param>
        public void UpdateState(WiimoteChangedEventArgs args)
        {
            BeginInvoke(new UpdateWiimoteStateDelegate(UpdateWiimoteChanged), args);
        }
        /// <summary>
        /// Method that actually has access to the data from the wiimote and other extensions
        /// where we can handle the data provenient from the wii accessories
        /// </summary>
        /// <param name="args"></param>
        private void UpdateWiimoteChanged(WiimoteChangedEventArgs args)
        {
            WiimoteState ws = args.WiimoteState;

            //output Accelerometer data to the form
            _textBoxWiiData.Text = ws.AccelState.Values.ToString();
            if (ws.ExtensionType == ExtensionType.Nunchuk)
                _textBoxNunData.Text = ws.NunchukState.AccelState.Values.ToString();
            //record Accelerometer data
            if (readFlag)
            {
                _wiimoteAccelValues.Add
                    (
                        new WiiData(
                            ws.AccelState.Values.X,
                            ws.AccelState.Values.Y,
                            ws.AccelState.Values.Z)
                    );
                _textBoxWiimoteCount.Text = _wiimoteAccelValues.Count.ToString();
                if (ws.ExtensionType == ExtensionType.Nunchuk)
                {

                    _nunchukAccelValues.Add
                        (
                            new WiiData(
                                ws.NunchukState.AccelState.Values.X,
                                ws.NunchukState.AccelState.Values.Y,
                                ws.NunchukState.AccelState.Values.Z)
                        );
                    _textBoxNunchukCount.Text = _nunchukAccelValues.Count.ToString();
                }
            }
        }
        /// <summary>
        /// Method that handles the closing of the application
        /// Where we handle the disconnection of the wiimote from the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NRMMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Disconnect the wiimote
            wm.Disconnect();
        }
        /// <summary>
        /// Button that Exports the data aquired from the wii devices into a cvs file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _buttonExport_Click(object sender, EventArgs e)
        {
            try
            {
                ExportData.ExportDataToCSV(_textBoxExportPath.Text, _wiimoteAccelValues, _nunchukAccelValues);
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show("Invalid directory. Insert a valid directory in the Export Path text box.", "Directory not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("File opened. \nPlease close the file and export again or change the destination directory.", "Export file opened", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
         }
        /// <summary>
        /// Method that starts data readng from the wii devices
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _buttonStart_Click(object sender, EventArgs e)
        {
            readFlag = true;
        }

        /// <summary>
        /// Method that stops data readng from the wii devices
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _buttonStop_Click(object sender, EventArgs e)
        {
            readFlag = false;
        }

        private void _buttonClearData_Click(object sender, EventArgs e)
        {
            _wiimoteAccelValues.Clear();
            _nunchukAccelValues.Clear();
        }
    }
}
