using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ASCOM.Utilities;
using System.IO;
using ASCOM.NanoOC;

namespace ASCOM.NanoOC
{
    [ComVisible(false)]					// Form not registered for COM!
    public partial class SetupOC : Form
    {
        TraceLogger tl; // Holder for a reference to the driver's trace logger

        public SetupOC(TraceLogger tlDriver)
        {
            InitializeComponent();

            // Save the provided trace logger for use within the setup dialogue
            tl = tlDriver;

            // Initialise current values of user settings from the ASCOM Profile
            InitUI();
        }

        private void cmdOK_Click(object sender, EventArgs e) // OK button event handler
        {
            ObservingConditions.comPort = (string)comboBoxComPort.SelectedItem;
            tl.Enabled = chkTrace.Checked;
            ObservingConditions.gain = (double)inputgain.Value;
            ObservingConditions.highT = (double)inputhighT.Value;
            ObservingConditions.offset = (double)inputoffset.Value;
            ObservingConditions.SQMAdjust = (double)inputSkyMag.Value;
            ObservingConditions.RainRatioThreshold = (double)inputRainAdj.Value;
            if (inputLL.Value > inputUL.Value)  // make defaults if limits are opposing
            {
                ObservingConditions.SkyLL = -20.0;
                ObservingConditions.SkyUL = 10.0;
            }
            ObservingConditions.SkyUL = (double)inputUL.Value;
            ObservingConditions.SkyLL = (double)inputLL.Value;
            ObservingConditions.pressuretrim = (double)inputPtrim.Value;
            ObservingConditions.humidtrim = (double)inputHtrim.Value;
            ObservingConditions.temptrim = (double)inputTtrim.Value;
            ObservingConditions.buzzer = chkBuzzer.Checked;
        }

        private void cmdCancel_Click(object sender, EventArgs e) // Cancel button event handler
        {
            Close();
        }

        private void BrowseToAscom(object sender, EventArgs e) // Click on ASCOM logo event handler
        {
            try
            {
                System.Diagnostics.Process.Start("http://ascom-standards.org/");
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void InitUI()
        {
            chkTrace.Checked = tl.Enabled;
            // set the list of com ports to those that are currently available
            comboBoxComPort.Items.Clear();
            comboBoxComPort.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());      // use System.IO because it's static
            // select the current port if possible
            if (comboBoxComPort.Items.Contains(ObservingConditions.comPort))
            {
                comboBoxComPort.SelectedItem = ObservingConditions.comPort;
            }
            inputgain.Value = (decimal)ObservingConditions.gain;
            inputhighT.Value = (decimal)ObservingConditions.highT;
            inputSkyMag.Value = (decimal)ObservingConditions.SQMAdjust;
            inputRainAdj.Value = (decimal)ObservingConditions.RainRatioThreshold;
            inputUL.Value = (decimal)ObservingConditions.SkyUL;
            inputLL.Value = (decimal)ObservingConditions.SkyLL;
            inputUL.Value = (decimal)ObservingConditions.SkyUL;
            inputHtrim.Value = (decimal)ObservingConditions.humidtrim;
            inputTtrim.Value = (decimal)ObservingConditions.temptrim;
            inputPtrim.Value = (decimal)ObservingConditions.pressuretrim;
            chkBuzzer.Checked = ObservingConditions.buzzer;
            inputoffset.Value = (decimal)ObservingConditions.offset;
        }
    }
}