using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tatoo_CRM.dataBase
{
    public class Material
    {
        /// <summary>
        /// Номер по порядку
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Название
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Количество в упаковке
        /// </summary>
        public int countPack { get; set; }
        /// <summary>
        /// Цена упаковки
        /// </summary>
        public double pricePack { get; set; }
        /// <summary>
        /// Цена за штуку
        /// </summary>
        public double price { get; set; }
        /// <summary>
        /// Штук тратится в сеанс
        /// </summary>
        public int countSeans { get; set; }



    }
}
