using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace PlantsVsZombieTrainer
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        private Mem mem = new Mem();
        private Thread checkGameThread;
        private bool isWrite = false;
        private int pID = 0;
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Trainer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            } else
            {
                return;
            }
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private bool checkNumber(string input)
        {
            Regex regex = new Regex("^[0-9]+$");
            return regex.IsMatch(input);
        }

        private void writeSun(object sun)
        {
            while (true)
            {
                mem.WriteMemory("base+00329670,320,18,0,8,5578", "int", (string)sun);
                Thread.Sleep(1000);
            }
        }

        private void btnApplySun_Click(object sender, EventArgs e)
        {
            string sun = txtSun.Text;
            if (checkNumber(sun))
            {
                if (!isWrite)
                {
                    Thread thread = new Thread(new ParameterizedThreadStart(writeSun));
                    thread.Start(sun);
                }                
            } else
            {
                MessageBox.Show("Vui lòng kiểm tra lại giá trị nhập vào.", "Trainer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void checkGame()
        {
            while (true)
            {
                int pID = mem.GetProcIdFromName("popcapgame1.exe");
                if (pID == 0)
                {
                    MessageBox.Show("Vui lòng chạy game!", "Trainer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Environment.Exit(0);
                }
                Thread.Sleep(3000);
            }            
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            checkGameThread = new Thread(new ThreadStart(checkGame));
            checkGameThread.Start();
            pID = mem.GetProcIdFromName("popcapgame1.exe");
            mem.OpenProcess(pID);
        }

        private void cbInstantCharger_CheckedChanged(object sender, EventArgs e)
        {
            if (cbInstantCharger.Checked)
            {
                mem.WriteMemory("base+91E4C", "bytes", "FF 47 48");
            } else
            {
                mem.WriteMemory("base+91E4C", "bytes", "FF 47 24");
            }
        }

        private void cbGodMode_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGodMode.Checked)
            {
                mem.WriteMemory("base+140680", "bytes", "90 90 90 90");
            }
            else
            {
                mem.WriteMemory("base+140680", "bytes", "83 46 40 FC");
            }
        }

        private void cbRapidFire_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGodMode.Checked)
            {
                mem.WriteMemory("base+684E4", "bytes", "90 90 90 90 90 90");
            }
            else
            {
                mem.WriteMemory("base+684E4", "bytes", "0F 85 98 FE FF FF");
            }
        }
    }
}
