using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tatoo_CRM.views
{
    
    public partial class Materials : Form
    {
        private MainClass mc = Program.mainClass;
        private dataBase.DataBaseContext db;
       
        public Materials()
        {
            InitializeComponent();
            db = mc.db;
            table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            table.AllowUserToAddRows = true;
            
            setTabel(new object(), new EventArgs());

           
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void setTabel(object sender, EventArgs e) 
        {

            

            table.DataSource = db.material.ToList();          

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            dataBase.Material material = new dataBase.Material();
            db.material.Add(material);
            db.SaveChanges();
            setTabel(new object(), new EventArgs());
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            countPrice();
            db.SaveChanges();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            db.material.Remove((dataBase.Material) table.SelectedRows[0].DataBoundItem);
            db.SaveChanges();
            setTabel(new object(), new EventArgs());
        }
        private void countPrice() 
        {
            foreach (DataGridViewRow tempMat in table.Rows)
            {
                Console.WriteLine(tempMat.Cells[1].Value);
                double pricePac = double.Parse(tempMat.Cells[3].Value.ToString());
                //double price = double.Parse(tempMat.Cells[4].Value.ToString());
                int countPack = int.Parse(tempMat.Cells[2].Value.ToString());
                if (pricePac != 0)
                {
                    tempMat.Cells[4].Value = pricePac / countPack;
                }
            }
        }
    }
}
