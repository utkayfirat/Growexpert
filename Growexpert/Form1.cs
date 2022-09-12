using ezOverLay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Growexpert
{
    public partial class Form1 : Form
    {
        int mov, movX, movY;
        private bool punchAllowed = true;
        private List<Process> farmerprocesses = new List<Process>();
        List<Form> forms = new List<Form>();
        int session = 0;
        ez ez = new ez();

        CheckBox checkbox;
        private bool selectAllChecked = false;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        static extern bool SetWindowText(IntPtr hWnd, string name);

        private System.Timers.Timer punchTimer;
        

        public Form1(){
            InitializeComponent();
        }
        private void closeButton_Click(object sender, EventArgs e){ Close(); }
        private void appBarLayer_MouseMove(object sender, MouseEventArgs e){
            if(mov == 1){
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
        private void appBarLayer_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
            movingMod = false;
        }
        private void appBarLayer_MouseDown(object sender, MouseEventArgs e){
            mov = 1;
            movX = e.X;
            movY = e.Y;
            movingMod = true;
        }

        private void Form1_Load(object sender, EventArgs e){
            punchTimer = new System.Timers.Timer(156);
            punchTimer.Elapsed += new System.Timers.ElapsedEventHandler(PunchClick);
            CheckForIllegalCrossThreadCalls = false;
            Process[] gtProcesses = Process.GetProcessesByName("Growtopia");
            Console.WriteLine(gtProcesses.Length);
            autoFarmerType.SelectedIndex = 0;

            checkbox = new CheckBox();
            checkbox.Size = new Size(15, 15);
            checkbox.BackColor = Color.Transparent;

            checkbox.Padding = new Padding(0);
            checkbox.Margin = new Padding(0);
            checkbox.Text = "";

            processListDataGridView.Controls.Add(checkbox);
            DataGridViewHeaderCell header = processListDataGridView.Columns["Checkbox"].HeaderCell;
            checkbox.Location = new Point(14, 3);
            checkbox.CheckedChanged += new EventHandler(SelectAll);
        }

        private void SelectAll(object sender, EventArgs e)
        {
            selectAllChecked = !selectAllChecked;

            foreach (DataGridViewRow row in processListDataGridView.Rows)
            {
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)row.Cells["Checkbox"];
                checkbox.Value = selectAllChecked;
                checkbox.Value = !selectAllChecked;
                checkbox.Value = selectAllChecked;
            }

            processListDataGridView.RefreshEdit();
        }

        private void getDataButton_Click(object sender, EventArgs e)
        {
            foreach(Form hook in forms){
                hook.Close();
            }
            forms = new List<Form>();
            Process[] gtProcesses = Process.GetProcessesByName("Growtopia");
            if (gtProcesses.Length == 0) { 
                MessageBox.Show("Please open Growtopia");
                return;
            }

            List<Process> gtProcessesFULL = new List<Process>();

            processListDataGridView.Rows.Clear();

            for (int i = 0; i < gtProcesses.Length; i++){
                gtProcessesFULL.Add(gtProcesses[i]);
            }

            
            foreach (Process p in gtProcessesFULL){
                session = processListDataGridView.Rows.Add();
                processListDataGridView.Rows[session].Cells["Number"].Value = session+1;
                string pname = (session+1) + ".exe";
                SetWindowText(p.MainWindowHandle, pname);
                Hook hook = new Hook();
                hook.Show();
                ez.SetInvi(hook);
                ez.StartLoop(10, p.MainWindowTitle, hook);
                forms.Add(hook);

                processListDataGridView.Rows[session].Cells["GrowtopiaID"].Value = pname;
                processListDataGridView.Rows[session].Cells["BotID"].Value = "None";
                processListDataGridView.Rows[session].Cells["PID"].Value = p.Id.ToString();
                processListDataGridView.Rows[session].Cells["TimeID"].Value = DateTime.Now.ToString("HH:mm");
            }
            myNormalize();

            gtProcesses = null;
        }

        private void toggleAutoFarmer_Click(object sender, EventArgs e){
            tafBool = !tafBool;
            toggleAutoFarmer.Text = tafBool ? "Bot: On" : "Bot: Off";
            punchTimer.Enabled = tafBool;
        }

        private void SendClick(Process process, int x, int y, int? dx = null, int? dy = null)
        {
            if (dx == null) dx = x;
            if (dy == null) dy = y;

            // Randomize coordinates
            Random r = new Random();
            x += r.Next(-3, 3);
            y += r.Next(-1, 1);
            if (dx == null && dy == null)
            {
                dx = x + r.Next(-2, 2);
                dy = y + r.Next(-2, 2);
            }
            else
            {
                dx += r.Next(-10, 10);
                dy += r.Next(-10, 10);
            }

            IntPtr handle = process.MainWindowHandle;
            SendMessage(handle, 0x201, new IntPtr(0x0001), (IntPtr)((y << 16) | (x & 0xffff)));
            SendMessage(handle, 0x202, new IntPtr(0x0001), (IntPtr)((dy << 16) | (dx & 0xffff)));
        }

        private void punchTimer_Tick(object sender, EventArgs e)
        {

        }

        private void updateBotButton_Click(object sender, EventArgs e){
            string selectedOption = autoFarmerType.SelectedItem.ToString();
            foreach (DataGridViewRow row in processListDataGridView.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Checkbox"].Value))
                {
                    row.Cells["BotID"].Value = selectedOption;
                }
            }
        }

        private bool tafBool = false;

        private void updateXYButton_Click(object sender, EventArgs e){
        }

        private void xLocationTextBoxONE_ValueChanged(object sender, EventArgs e)
        {
            foreach (Form hook in forms)
            {
                hook.Controls["clickOnePanel"].Location = new Point(Convert.ToInt32(xLocationTextBoxONE.Value), Convert.ToInt32(yLocationTextBoxONE.Value));
            }
        }

        private void xLocationTextBoxTWO_ValueChanged(object sender, EventArgs e)
        {
            foreach (Form hook in forms)
            {
                hook.Controls["clickTwoPanel"].Location = new Point(Convert.ToInt32(xLocationTextBoxTWO.Value), Convert.ToInt32(yLocationTextBoxTWO.Value));
            }
        }

        private void xLocationTextBoxTHREE_ValueChanged(object sender, EventArgs e)
        {
            foreach (Form hook in forms)
            {
                hook.Controls["clickThreePanel"].Location = new Point(Convert.ToInt32(xLocationTextBoxTHREE.Value), Convert.ToInt32(yLocationTextBoxTHREE.Value));
            }
        }

        private void myConfigLoad(){
            xLocationTextBoxONE.Value = 600;
            yLocationTextBoxONE.Value = 378;

            xLocationTextBoxTWO.Value = 680;
            yLocationTextBoxTWO.Value = 378;

            xLocationTextBoxTHREE.Value = 950;
            yLocationTextBoxTHREE.Value = 743;
        }

        private void myNormalize()
        {
            xLocationTextBoxONE.Value = 40;
            yLocationTextBoxONE.Value = 70;

            xLocationTextBoxTWO.Value = 40;
            yLocationTextBoxTWO.Value = 140;

            xLocationTextBoxTHREE.Value = 40;
            yLocationTextBoxTHREE.Value = 210;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myConfigLoad();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myNormalize();
        }

        private bool movingMod = false;

        private void PunchClick(object source, System.Timers.ElapsedEventArgs e)
        {
            if (punchAllowed && movingMod == false)
            {
                punchAllowed = false;
                foreach(DataGridViewRow row in processListDataGridView.Rows){
                    if(Convert.ToString(row.Cells["BotID"].Value) == "BFGMod") {
                        Process p = Process.GetProcessById(Convert.ToInt32(row.Cells["PID"].Value));
                        farmerprocesses.Add(p);
                    }
                }
                if(farmerprocesses.Count > 0) { 
                    System.Threading.Tasks.Parallel.ForEach(farmerprocesses, p => {
                        // Block
                        SendClick(p, Convert.ToInt32(xLocationTextBoxONE.Value), Convert.ToInt32(yLocationTextBoxONE.Value));
                        SendClick(p, Convert.ToInt32(xLocationTextBoxTWO.Value), Convert.ToInt32(yLocationTextBoxTWO.Value));
                        // Punch
                        SendClick(p, Convert.ToInt32(xLocationTextBoxTHREE.Value), Convert.ToInt32(yLocationTextBoxTHREE.Value));
                    });
                }else { Console.WriteLine("Debug: not have any proccess"); }
            }
            farmerprocesses = new List<Process>();
            punchAllowed = true;

        }

    }
}
