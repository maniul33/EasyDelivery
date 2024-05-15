using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace EasyDelivery
{
    public static class DatabaseSettings
    {
        public static string ConnectionString { get; set; }
    }

    internal static class Program
    {
        internal static System.Timers.Timer chargeCalculationTimer;
        [STAThread]
        static void Main()
        {
            DatabaseSettings.ConnectionString = "Data Source=MANIUL\\SQLEXPRESS;Initial Catalog=EasyDelivery;Integrated Security=True;";

            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
            StartChargeCalculationTimer();
        }

        private static void StartChargeCalculationTimer()
        {
            chargeCalculationTimer = new System.Timers.Timer();
            chargeCalculationTimer.Interval = TimeSpan.FromSeconds(10).TotalMilliseconds;
            chargeCalculationTimer.Elapsed += ChargeCalculationTimerElapsed;
            chargeCalculationTimer.AutoReset = true;
            chargeCalculationTimer.Enabled = true;
        }
        private static void ChargeCalculationTimerElapsed(object sender, ElapsedEventArgs e)
        {
            ChargeCalculator.CalculateCharges();
        }
    }
}
