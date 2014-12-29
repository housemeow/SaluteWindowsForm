using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salute
{
    public partial class SaluteForm : Form
    {
        enum SaluteState
        {
            WaitSalute,
            Salute,
            WaitLeave
        }

        SaluteState _state = SaluteState.WaitSalute;

        private Bitmap[] bitmap = new Bitmap[7];
        int _index;
        SerialPort _arduino;
        private double distance = 1000;
        private const double DISTANCE = 175;
        int counter;
        private int LEAVE_COUNT = 3;
        private int WAIT_SALUTE_COUNT = 3;

        public SaluteForm()
        {
            InitializeComponent();
        }

        private void LoadForm(object sender, EventArgs e)
        {
            bitmap[0] = new Bitmap(Properties.Resources.frame_000);
            bitmap[1] = new Bitmap(Properties.Resources.frame_001);
            bitmap[2] = new Bitmap(Properties.Resources.frame_002);
            bitmap[3] = new Bitmap(Properties.Resources.frame_003);
            bitmap[4] = new Bitmap(Properties.Resources.frame_004);
            bitmap[5] = new Bitmap(Properties.Resources.frame_005);
            bitmap[6] = new Bitmap(Properties.Resources.frame_006);
            Size = new Size(bitmap[0].Width, bitmap[0].Height);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            BackgroundImage = bitmap[0];
            DoubleBuffered = true;
            counter = 0;
        }

        private void InitArduino()
        {
            string comPortName = "COM" + _comportNumericUpDown.Value;
            try
            {
                _arduino = new SerialPort(comPortName, 9600, Parity.None, 8, StopBits.One);
                if ((_arduino != null) && (!_arduino.IsOpen))
                {
                    _arduino.Open();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _arduino = null;
            }
        }

        private void EndSulate()
        {
            _saluteTimer.Enabled = false;
            _index = 0;
            BackgroundImage = bitmap[_index];
        }

        private void ClickCloseButton(object sender, EventArgs e)
        {
            Close();
        }

        private void TickSaluteTimer(object sender, EventArgs e)
        {
            BackgroundImage = bitmap[_index++];
            if (_index == 7)
            {
                _saluteTimer.Enabled = false;
                //BackgroundImage = bitmap[0];
                _index = 0;
                _state = SaluteState.WaitLeave;
            }
        }

        private void ClickConnect(object sender, EventArgs e)
        {
            InitArduino();
            if (_arduino != null)
            {
                _arduino.DataReceived += new SerialDataReceivedEventHandler(HandleArduinoData);
                _connectButton.Enabled = false;
                _comportNumericUpDown.Enabled = false;
            }
        }

        private void HandleArduinoData(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            try
            {
                distance = double.Parse(indata);
            }
            catch (Exception)
            {
            }
        }

        private void HandleArduinoThreadSafe(object sender, EventArgs e)
        {
            ProcessState(distance);
        }

        private void ProcessState(double distance)
        {
            Console.WriteLine(Enum.GetName(typeof(SaluteState), _state));
            Console.WriteLine(counter);
            switch (_state)
            {
                case SaluteState.WaitSalute:
                    if (distance < DISTANCE)
                        counter++;
                    else
                        //counter = counter - 1 > 0 ? counter - 1 : 0;
                        counter = 0;
                    if (counter > WAIT_SALUTE_COUNT)
                    {
                        _index = 0;
                        _saluteTimer.Enabled = true;
                        _state = SaluteState.Salute;
                        counter = 0;
                    }
                    break;
                case SaluteState.Salute:
                    break;
                case SaluteState.WaitLeave:
                    if (distance >= DISTANCE)
                        counter++;
                    else
                        //counter = counter - 1 > 0 ? counter - 1 : 0;
                        counter = 0;
                    if (counter > LEAVE_COUNT)
                    {
                        _state = SaluteState.WaitSalute;
                        counter = 0;
                        BackgroundImage = bitmap[0];
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
