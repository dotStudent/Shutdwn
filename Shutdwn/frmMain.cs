using System;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Taskbar;

namespace Shutdwn
{
    public partial class frmMain : Form
    {
        TaskbarManager windowsTaskbar = TaskbarManager.Instance;
        
        public frmMain()
        {
            InitializeComponent();
            InitializeControls();
        }

        #region Initialize
        private void InitializeControls()
        {
            nUPHour.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.ScrollHandlerFunction);
            nUPMinute.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.ScrollHandlerFunction);
            nUPHour.Minimum = 0;
            nUPHour.Maximum = 23;
            nUPMinute.Minimum = 0;
            nUPMinute.Maximum = 59;
 
            lbCountdown.Text = "";
            rBSD.Checked = true;
            rBIn.Checked = true;
            btnStop.Enabled = false;
        }
        private void SetControls(bool enabled)
        {
            rbAt.Enabled = enabled;
            rBIn.Enabled = enabled;
            rBLO.Enabled = enabled;
            rBRS.Enabled = enabled;
            rBSD.Enabled = enabled;
            nUPHour.Enabled = enabled;
            nUPMinute.Enabled = enabled;
            btnLoad.Enabled = enabled;
        }
        #endregion

        #region Buttons
        private void btnStart_Click(object sender, EventArgs e)
        {
            SetControls(false);

            if (btnStart.Text == "Start")
            {
                ActionType? at = GetActionType();
                bool doit = true;
                if (nUPHour.Value == 0 && nUPMinute.Value == 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure to perform Action immediatly?", at.ToString(), MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        doit = false;
                    }
                }
                if (doit == true)
                {
                    if (at != null)
                    {
                        BLShutdwn.CountdownChanged += (sender1, e1) => lbCountdown.Text = BLShutdwn.Countdown.ToString();
                        BLShutdwn.CountdownChanged += (sender1, e1) => windowsTaskbar.SetProgressValue(BLShutdwn.ProgressCountdown, 100);

                        BLShutdwn.EndCountdown = ActionTime(rBIn.Checked, Convert.ToInt32(nUPHour.Value), Convert.ToInt32(nUPMinute.Value));
                        BLShutdwn.Type = at;
                        BLShutdwn.SaveSettings(rBIn.Checked, Convert.ToInt32(nUPHour.Value), Convert.ToInt32(nUPMinute.Value), at);
                        BLShutdwn.Action();

                        btnStart.Text = "Pause";
                        btnStop.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("You have not choosen an Action");
                    }
                }
            }
            else if (btnStart.Text == "Pause")
            {
                BLShutdwn.PauseCountdown = true;
                btnStart.Text = "Resume";
            }
            else if (btnStart.Text == "Resume")
            {
                BLShutdwn.PauseCountdown = false;
                btnStart.Text = "Pause";
            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            BLShutdwn.StopCountdown = true;
            btnStart.Text = "Start";
            lbCountdown.Text = "";
            SetControls(true);
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            bool UseInTime = false;
            int hour = 0;
            int minute = 0;
            ActionType? at = new ActionType();
            string LastDate = "";
            BLShutdwn.LoadSettings(ref UseInTime, ref hour, ref minute, ref at, ref LastDate);
            if (LastDate != "")
            {
                if (UseInTime == true)
                {
                    rBIn.Checked = true;
                }
                else
                {
                    rbAt.Checked = true;
                }

                nUPHour.Value = hour;
                nUPMinute.Value = minute;

                switch (at)
                {
                    case ActionType.Shutdown:
                        rBSD.Checked = true;
                        break;
                    case ActionType.Logoff:
                        rBLO.Checked = true;
                        break;
                    case ActionType.Restart:
                        rBRS.Checked = true;
                        break;
                    default:
                        break;
                }
            }

        }
        #endregion

        #region Events
        private void ScrollHandlerFunction(object sender, MouseEventArgs e)
        {
            NumericUpDown control = (NumericUpDown)sender;
            ((HandledMouseEventArgs)e).Handled = true;
            
            decimal value = control.Value;

            if (e.Delta > 0 == true)
            {
                if (value == control.Maximum)
                {
                    value = control.Minimum;
                }
                else
                {
                    value += control.Increment;
                }
            }
            else
            {
                if (value == control.Minimum)
                {
                    value = control.Maximum;
                }
                else
                {
                    value += -control.Increment;
                }
            }
            control.Value = value;
        }
        private void lbHour_DoubleClick(object sender, EventArgs e)
        {
            nUPHour.Value = DateTime.Now.Hour;
        }
        private void lbMinute_DoubleClick(object sender, EventArgs e)
        {
            nUPMinute.Value = DateTime.Now.Minute;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Alarm_Clock;
        }
        #endregion

        #region Helper
        private ActionType? GetActionType()
        {
            if (rBSD.Checked == true)
            {
                return ActionType.Shutdown;
            }
            else if (rBRS.Checked == true)
            {
                return ActionType.Restart;
            }
            else if (rBLO.Checked == true)
            {
                return ActionType.Logoff;
            }
            else
            {
                return null;
            }
        }
        private DateTime ActionTime(bool In, int hours, int minutes)
        {
            DateTime dtAction;

            if (In == true)
            {
                hours = Convert.ToInt32(nUPHour.Value);
                minutes = Convert.ToInt32(nUPMinute.Value);
                dtAction = (DateTime.Now.AddMinutes(hours * 60 + minutes));
            }
            else
            {
                int diffMinutes = (hours * 60 - DateTime.Now.Hour * 60) + (minutes - DateTime.Now.Minute);
                if (diffMinutes > 0)
                {
                    //Day is Today
                    dtAction = DateTime.Now + TimeSpan.FromMinutes(diffMinutes);
                }
                else
                {
                    dtAction = DateTime.Now.AddDays(1) + TimeSpan.FromMinutes(diffMinutes);
                }
            }
            return dtAction;
        }
        #endregion

        
    }
}
