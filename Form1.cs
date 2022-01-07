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
        SerialPort LedSign;
        
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
            SetupComboboxes();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            LedSign.Close();
        }

        private void DeleteAllPages()
        {
            LedSign.Write($"<ID01><DP*>\r\n");
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenSerialPort();
        }

        private void OpenSerialPort()
        {
            LedSign = new SerialPort();
            LedSign.PortName = cmbCommPort.SelectedItem.ToString();
            LedSign.BaudRate = 9600;
            LedSign.Open();
            btnSend.Enabled = true;
        }

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

        private void PrintMessage()
        {
            ColourModel color = ParseColorCode();
            FontModel font = ParseFontCode();
            TransitionModel transition = ParseTransitionCode();

            string command = $"<ID01><PA>{color.Code}{font.Code}{tbString.Text}{transition.Code}\r\n";
            lblCmdTxt.Text = command;

            LedSign.Write(command);
        }

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


    }
}
