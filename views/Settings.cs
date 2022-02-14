using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tatoo_CRM.views
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            
                 nud_price_one_hoer.Value = (decimal)Properties.Settings.Default.price_one_hour;

            
                nud_bonus.Value = (decimal)Properties.Settings.Default.bonus_for_;

            
                nud_dop_.Value = (decimal)Properties.Settings.Default.dop_;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.price_one_hour = (double)nud_price_one_hoer.Value;
            Properties.Settings.Default.bonus_for_ = (double)nud_bonus.Value;
            Properties.Settings.Default.dop_= (double)nud_dop_.Value;
            Properties.Settings.Default.Save();
            Close();
        }
    }
}
