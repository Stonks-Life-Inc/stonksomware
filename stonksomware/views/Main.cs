using stonksomware.controllers;
using System.ComponentModel;
using System.Diagnostics;

namespace stonksomware
{
    public partial class Main : Form
    {
        // Background worker to run the progress bar animation in anothoer background thread
        BackgroundWorker bgw = new BackgroundWorker();
        DateTime today;
        DateTime terminalDate;

        public Main()
        {
            InitializeComponent();
            // Setting up some label to void at the moment.
            date_label.Text = "";
            timeLeft_label.Text = "";
        }

        // When one of these two buttons is clicked we call our displayRandomErrorMessages from our "static"
        // class ActionsController. This method display a msgBox with a random msg in it.
        private void button1_Click(object sender, EventArgs e)
        {
            ActionsController.displayRandomErrorMessages();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActionsController.displayRandomErrorMessages();
        }

        // When the window has fully loaded (on window load)
        // We : - start the timer
        //      - set the different label to their respective state (date, countdown, etc.)
        //      - We start a new thread for the loading bar.
        private void Main_Load(object sender, EventArgs e)
        {
            // Basic default setup
            DateTime today = DateTime.Today;
            DateTime terminalDate = today.AddMinutes(5);
            date_label.Text = today.ToString();

            timerProgress.Enabled = true;
            timerProgress.Interval = 100;

            timerProgress.Tick += new EventHandler(timerProgress_Tick);
            TimeSpan ts = today.Subtract(terminalDate);
            timeLeft_label.Text = ts.ToString("d' : 'h' : 'm' : 's' : 'ms");

            timerProgress.Start();


            // Worker load
            bgw.DoWork += new DoWorkEventHandler(bgw_DoWork);
            bgw.ProgressChanged += new ProgressChangedEventHandler(bgw_ProgressChanged);
            bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_RunWorkerCompleted);
            bgw.WorkerReportsProgress = true;
            bgw.RunWorkerAsync();
        }
        void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            int total = 1000; //some number (this is your variable to change)!!

            for (int i = 0; i <= total; i++) //some number (total)
            {
                System.Threading.Thread.Sleep(100);
                int percents = (i * 100) / total;
                bgw.ReportProgress(percents, i);
                //2 arguments:
                //1. procenteges (from 0 t0 100) - i do a calcumation 
                //2. some current value!
            }
        }

        void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            timeLeft_progressBar.Value = e.ProgressPercentage;
            
        }

        void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //do the code when bgv completes its work
        }

        private void timerProgress_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now.Subtract(terminalDate);
            timeLeft_label.Text = ts.ToString("d' : 'h' : 'm' : 's' : 'ms");
        }
    }
}