using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Shutdwn
{
    static class BLShutdwn
    {
        #region Events
        public static event EventHandler CountdownChanged;
        #endregion

        #region SystemCalls
        [DllImport("user32")]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);
        //[DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        //public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);
        #endregion

        #region Public Fields
        public static TimeSpan Countdown { get; private set; }
        public static bool StopCountdown { get; set; }
        public static bool PauseCountdown { get; set; }
        public static DateTime EndCountdown { get; set; }
        public static ActionType? Type { get; set; }
        public static int ProgressCountdown { get; private set; }
        #endregion

        #region Member Variables
        private static Timer tmr;
        private static int _time = 0;
        private static int _timeElapsed = 0;
        #endregion

        #region Public Methods
        public static void Action()
        {
            //Get Time in Seconds
            TimeSpan ts = EndCountdown - DateTime.Now;
            _time = Convert.ToInt32(ts.TotalSeconds);
            tmr = new Timer();
            //Set Interval to 1 Second
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Start();
        }
        public static void SaveSettings(bool UseInTime, int hour, int minute, ActionType? type)
        {
            if (type != null)
            {
                Properties.Settings.Default.UseInTime = UseInTime;
                Properties.Settings.Default.Hour = hour;
                Properties.Settings.Default.Minute = minute;
                Properties.Settings.Default.Action = type.ToString();
                Properties.Settings.Default.LastDate = DateTime.Now.ToString();
                Properties.Settings.Default.Save();
            }
        }
        public static void LoadSettings(ref bool UseInTime, ref int hour, ref int minute, ref ActionType? type, ref string lastDate)
        {
                UseInTime = Properties.Settings.Default.UseInTime;
                hour = Properties.Settings.Default.Hour;
                minute = Properties.Settings.Default.Minute;
                type = ActionTypeFromString(Properties.Settings.Default.Action);
                lastDate = Properties.Settings.Default.LastDate;
        }
        #endregion

        #region Private Methods
        private static void tmr_Tick(object sender, EventArgs e)
        {
            if (PauseCountdown == false)
            {
                if (_timeElapsed < _time)
                {
                    _timeElapsed++;
                    ChangeCountdownText(TimeSpan.FromSeconds(_time - _timeElapsed));
                    ProgressCountdown = _timeElapsed * 100 / _time;
                }
                else
                {
                    tmr.Stop();
                    PerformAction();
                }
            }
            if (StopCountdown == true)
            {
                ChangeCountdownText(TimeSpan.Zero);
                _timeElapsed = 0;
                tmr.Stop();
                PauseCountdown = false;
                StopCountdown = false;
            }
        }
        private static void PerformAction()
        {
            switch(Type)
            {
                case ActionType.Shutdown:
                    Process.Start("Shutdown", "/s /t 0 /f");
                    break;
                case ActionType.Restart:
                    Process.Start("Shutdown","/r /t 0 /f");
                    break;
                case ActionType.Logoff:
                    ExitWindowsEx(0, 0);
                    break;
                case ActionType.Sleep:
                    //Only works on Battery Mode on Test Machine
                    //bool retVal = Application.SetSuspendState(PowerState.Suspend, false, false);
                    //if (retVal == false)
                    //{
                    //    MessageBox.Show("Could not suspend the system.");
                    //}
                    //Application.SetSuspendState(PowerState.Suspend, true, true);
                    //SetSuspendState(false, true, true);
                    break;
            }
        }
        static void ChangeCountdownText(TimeSpan ts)
        {
            Countdown = ts;

            EventHandler handler = CountdownChanged;

            if (handler != null)
            {
                handler(null, EventArgs.Empty);
            }
        }
        private static ActionType? ActionTypeFromString(string at)
        {
            switch (at)
            {
                case "Shutdown":
                    return ActionType.Shutdown;
                case "Restart":
                    return ActionType.Restart;
                case "LogOff":
                    return ActionType.Logoff;
                case "Sleep":
                    return ActionType.Sleep;
                default:
                    return null;
            }
        }
        #endregion
    }
}
