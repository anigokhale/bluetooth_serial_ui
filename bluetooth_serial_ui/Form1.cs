using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace bluetooth_serial_ui
{
    public partial class Form1 : Form
    {
        Command command = Command.Stop;
        char send;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                command = Command.Forward;
            }
            else if (e.KeyCode == Keys.S)
            {
                command = Command.Backward;
            }
            else if (e.KeyCode == Keys.A)
            {
                command = Command.Left;
            }
            else if (e.KeyCode == Keys.D)
            {
                command = Command.Right;
            }
            else if (e.KeyCode == Keys.J)
            {
                command = Command.ArmUp;
            }
            else if (e.KeyCode == Keys.L)
            {
                command = Command.ArmDown;
            }
            else if (e.KeyCode == Keys.Z)
            {
                command = Command.StartAuto;
                label4.Text = "Auto Started";
            }
            else if (e.KeyCode == Keys.X)
            {
                command = Command.StopAuto;
                label4.Text = "Auto Stopped";
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            command = Command.Stop;
        }

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (command == Command.Forward)
            {
                fwd_image.Height = 200;
                fwd_image.Top = 0;
            }
            else if (command == Command.Backward)
            {
                bwd_image.Height = 200;
            }
            if (command == Command.Left)
            {
                left_image.Width = 200;
                left_image.Left = 0;
            }
            else if (command == Command.Right)
            {
                right_image.Width = 200;
            }
            if (command == Command.ArmUp)
            {
                arm.Top = 100;
            }
            else if (command == Command.ArmDown)
            {
                arm.Top = 200;
            }
            if (command == Command.Stop)
            {
                fwd_image.Height = 150;
                fwd_image.Top = 50;
                bwd_image.Height = 150;
                left_image.Width = 150;
                left_image.Left = 50;
                right_image.Width = 150;
                arm.Top = 150;
            }

            send = SendingCommand(command);
            label2.Text = "Command sent: " + command.ToString();
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.WriteLine(send.ToString());
                    //label4.Text = serialPort1.ReadLine();
                }
                catch (Exception ex)
                {
                    if (ex is System.IO.IOException)
                    {
                        _ = MessageBox.Show("Device is not connected");
                    }
                    if (ex is System.TimeoutException)
                    {
                        serialPort1.Close();
                        button1.Text = "Connect";
                        _ = MessageBox.Show("Took too long to respond");
                    }
                }
                label3.Text = "Status: Connected";
            }
            else
            {
                label3.Text = "Status: Not Connected";
            }
        }

        private char SendingCommand(Command c)
        {
            char s;
            if (c == Command.Forward)
            {
                s = 'F';
            }
            else if (c == Command.Backward)
            {
                s = 'B';
            }
            else if (c == Command.Left)
            {
                s = 'L';
            }
            else if (c == Command.Right)
            {
                s = 'R';
            }
            else if (c == Command.ArmUp)
            {
                s = 'Q';
            }
            else if (c == Command.ArmDown)
            {
                s = 'A';
            }
            else if (c == Command.StartAuto)
            {
                s = 'Z';
            }
            else if (c == Command.StopAuto)
            {
                s = 'X';
            }
            else
            {
                return 'N';
            }

            return s;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1 = new SerialPort(comboBox1.SelectedItem.ToString())
                    {
                        BaudRate = 9600
                    };
                    serialPort1.ReadTimeout = 1000;
                    serialPort1.WriteTimeout = 1000;
                    serialPort1.Open();
                }
                catch (Exception ex)
                {
                    if (ex is InvalidOperationException)
                    {
                        button1.Text = "Connect";
                        _ = MessageBox.Show("Port is already open");
                    }
                    else if (ex is System.IO.IOException)
                    {
                        serialPort1.Close();
                        button1.Text = "Connect";
                        _ = MessageBox.Show("Device cannot be found");
                    }
                    else if (ex is NullReferenceException)
                    {
                        button1.Text = "Connect";
                        _ = MessageBox.Show("No port selected");
                    }
                    else if (ex is System.TimeoutException)
                    {
                        serialPort1.Close();
                        button1.Text = "Connect";
                        _ = MessageBox.Show("Took too long to connect");
                    }
                }
                if (serialPort1.IsOpen)
                {
                    button1.Text = "Disconnect";
                }
            }
            else
            {
                serialPort1.Close();
                button1.Text = "Connect";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = SerialPort.GetPortNames();
        }
    }
}
