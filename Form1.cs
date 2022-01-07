using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace LEDSign
{
    public partial class Form1 : Form
    {
        SerialPort spLedSign = new SerialPort();
        
        List<ColourModel> colours;
        List<FontModel> fonts;
        List<TransitionModel> transitions;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            btnClearPages.Enabled = false;
            SetupComboboxes();
        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenSerialPort();
        }

        /// <summary>
        /// Setup Serial Port, assuming 9600 baud. Enable Buttons that send serial messages
        /// </summary>
        private void OpenSerialPort()
        {
            spLedSign.PortName = cmbCommPort.SelectedItem.ToString();
            spLedSign.BaudRate = 9600;
            spLedSign.Open();
            
            btnSend.Enabled = true;
            btnClearPages.Enabled = true;
        }

        /// <summary>
        /// Populate all combo boxes
        /// </summary>
        private void SetupComboboxes()
        {
            //Serial Comm Ports
            string[] ports = SerialPort.GetPortNames();

            foreach (var item in ports)
            {
                cmbCommPort.Items.Add(item);
            }

            cmbCommPort.SelectedIndex = 0;


            //Colours
            colours = Colour.GetColours();
            cmbColour.Items.Add("DEFAULT");

            foreach (var item in colours)
            {
                cmbColour.Items.Add(item.Description);
            }

            cmbColour.SelectedIndex = 0;


            //Fonts
            fonts = LEDSign.Font.GetFonts();
            cmbFonts.Items.Add("DEFAULT");

            foreach (var item in fonts)
            {
                cmbFonts.Items.Add(item.Description);
            }
            cmbFonts.SelectedIndex = 0;


            //Transitions
            transitions = Transitions.GetTransitions();
            cmbTransitions.Items.Add("DEFAULT");

            foreach (var item in transitions)
            {
                cmbTransitions.Items.Add(item.Description);
            }

            cmbTransitions.SelectedIndex = 0;

        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            PrintMessage();
        }

        /// <summary>
        /// Send string to messageboard
        /// </summary>
        private void PrintMessage()
        {
            //Make sign address string
            int signID = Convert.ToInt32(tbSignID.Text);
            string signAddress = "<ID";
            if (signID < 10)
            {
                signAddress += "0";
            }
            
            signAddress += signID;
            signAddress += ">";

            //Parse color font and transition codes
            ColourModel color = ParseColorCode();
            FontModel font = ParseFontCode();
            TransitionModel transition = ParseTransitionCode();

            //Create command and send to sign
            string command = $"{signAddress}<PA>{color.Code}{font.Code}{tbString.Text}{transition.Code}\r\n";
            lblCmdTxt.Text = command;

            spLedSign.Write(command);
        }

        /// <summary>
        /// Get selected colour code
        /// </summary>
        /// <returns></returns>
        private ColourModel ParseColorCode()
        {
            foreach (var item in colours)
            {
                if (item.Description == cmbColour.SelectedItem.ToString())
                {
                    return item;
                }
            }

            return new ColourModel { Description = "DEFAULT", Code = "" };

        }

        /// <summary>
        /// Get selected font code
        /// </summary>
        /// <returns></returns>
        private FontModel ParseFontCode()
        {
            foreach (var item in fonts)
            {
                if (item.Description == cmbFonts.SelectedItem.ToString())
                {
                    return item;
                }
            }

            return new FontModel { Description = "DEFAULT", Code = "" };

        }

        /// <summary>
        /// Get transition code
        /// </summary>
        /// <returns></returns>
        private TransitionModel ParseTransitionCode()
        {
            foreach (var item in transitions)
            {
                if (item.Description == cmbTransitions.SelectedItem.ToString())
                {
                    return item;
                }
            }

            return new TransitionModel { Description = "DEFAULT", Code = "" };

        }


        private void btnClearPages_Click(object sender, EventArgs e)
        {
            DeleteAllPages();
        }

        /// <summary>
        /// Clear page A-Z memory
        /// </summary>
        private void DeleteAllPages()
        {
            spLedSign.Write($"<ID01><DP*>\r\n");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (spLedSign.IsOpen)
            {
                spLedSign.Close();
            }
        }


    }
}
