using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Windows.Forms;
using tatoo_CRM.dataBase;


namespace tatoo_CRM
{
    public partial class Form1 : Form
    {
        MainClass mc;
        DataBaseContext db;
        public Form1()
        {
            InitializeComponent();
            mc = Program.mainClass;
            db = mc.db;

            lbInitialize(new object(), new EventArgs());

            date.DateSelected += lbInitialize;

            tp_calculate.Enter += initTPCalculate;

            dgw_calculete.AllowUserToAddRows = false;
            btn_save_tpCalculate.Enabled = false;
            

        }
        private void lbInitialize(object sender, EventArgs e)
        {
            //Console.WriteLine(" new data chose");

            var tempSeans = db.seans.Where(b => b.data >= date.SelectionStart &&
                                                b.data <= date.SelectionEnd).ToList();

            string temp_seanses = string.Empty;

            dgw_table.DataSource = tempSeans; ;

            if (tempSeans.Count == 0)
                lb_seans.Text = "Нет заказов на выбранную дату";
            else lb_seans.Text = "На выбранную дату: " + tempSeans.Count + " заказов";


        }

        private void materials_Click(object sender, EventArgs e)
        {
            var materialsForm = new views.Materials();
            materialsForm.Show();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            var calculateForm = new views.Settings();
            calculateForm.Show();
        }

        private void orders_Click(object sender, EventArgs e)
        {
            var ordersForm = new views.OrdersForm();
            ordersForm.Show();
        }

        private void money_Click(object sender, EventArgs e)
        {
            var moneyForm = new views.Money();
            moneyForm.Show();
        }

        /// <summary>
        /// Кнопка на панели расчет сеанса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_new_seans_Click(object sender, EventArgs e)
        {

            List<Material> temp = (List<Material>)dgw_calculate_materials.DataSource;

            double tempPrice = 0;

            foreach (Material m in temp)
            {
                tempPrice = tempPrice + (m.price * m.countSeans);
            }

            double priceForJobe = (Properties.Settings.Default.bonus_for_ + Properties.Settings.Default.dop_ + (Properties.Settings.Default.price_one_hour * (double)nud_count_hour_calc.Value));




            dgw_calculete.DataSource = new List<Seans> { new Seans() { sebes = tempPrice,
                                                                       createData = DateTime.Now,
                                                                       price = priceForJobe + tempPrice,
                                                                       cleenMony = priceForJobe,
                                                                       data = dtp_calculate.Value,
                                                                       descr = "Кочегар на жопе"
                                                                       } };

            btn_new_seans.Enabled = false;
            btn_save_tpCalculate.Enabled = true;

        }
        /// <summary>
        /// Метод который срабатывает по событию кли по панели расчета санса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void initTPCalculate(object sender, EventArgs e)
        {
            dgw_calculate_materials.DataSource = db.material.Where(b => b.countSeans > 0).ToList();
            dgw_calculete.DataSource = null;
            lb_info.Text = "Расчеты будут здесь";
        }

        private void btn_save_tpCalculate_Click(object sender, EventArgs e)
        {
            List<Seans> temp = (List<Seans>)dgw_calculete.DataSource;           

            db.seans.Add(temp[0]);
            Console.WriteLine(db.SaveChanges());

            //Console.WriteLine("db was saved");
            btn_save_tpCalculate.Enabled = false;
            btn_new_seans.Enabled = true;

        }

        private void settings_menue_Click(object sender, EventArgs e)
        {
            var set = new views.Settings();
            set.Show();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            List<Material> temp = (List<Material>)dgw_calculate_materials.DataSource;

            double tempPrice = 0;

            foreach (Material m in temp)
            {
                tempPrice = tempPrice + (m.price * m.countSeans);
            }

            double priceForJobe = (Properties.Settings.Default.bonus_for_ + Properties.Settings.Default.dop_ + (Properties.Settings.Default.price_one_hour * (double)nud_count_hour_calc.Value));
            lb_info.Text = "Себестоимость " + tempPrice + "р.\r\n  За работу " + priceForJobe + "р.\r\n" + "Итого " + (tempPrice + priceForJobe) + "р.";
        }

        private void btn_save_seans_list_Click(object sender, EventArgs e)
        {
            dgw_calculete.DataSource = null;
            dgw_calculate_materials.DataSource = null;
            db.SaveChanges();
        }
    }
}
