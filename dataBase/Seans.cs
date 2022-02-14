using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tatoo_CRM.dataBase
{
    public class Seans
    {
        /// <summary>
        /// Номер
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Имя клиента
        /// </summary>
        public string client { get; set; }
        /// <summary>
        /// Себестоимость
        /// </summary>
        public double sebes { get; set; }
        /// <summary>
        /// Чистая прибыль
        /// </summary>
        public double cleenMony { get; set; }
        /// <summary>
        /// Стоимость для клиента
        /// </summary>
        public double price { get; set; }
        /// <summary>
        /// Дата сеанса
        /// </summary>
        public DateTime data { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime createData { get; set; }
        /// <summary>
        /// Материалы списком 
        /// </summary>
        public string descr { get; set; }
        /// <summary>
        /// Номер телефона
        /// </summary>
        public string phone { get; set; }
        /// <summary>
        /// Статус сеанса, маркетинговый или подтвержденный
        /// </summary>
        public bool status { get; set; }
    }
}
