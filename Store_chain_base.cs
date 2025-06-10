using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd_3
{
    public class Store_chain_base
    {
        public string Name { get; set; }
        public string Adres { get; set; }

        static List<Store_chain_base> list_store;
        public int Count_sales {  get; set; }
        public int Mont_revenue { get; set; }

        public Store_chain_base(string name, string adres, int count_sal, int mont_rev)
        {
            Name = name;
            Adres = adres;
            Count_sales = count_sal;
            Mont_revenue = mont_rev;

            list_store.Add(this);
        }

        public double Profit()
        {
            return (double)(Mont_revenue / Count_sales);
        }

        public string Info()
        {
            return $"{Name} {Adres} {Count_sales.ToString()} {Mont_revenue.ToString()}";
        }

        public virtual List<Store_chain_base> ListStore()
        {
            return list_store;
        }
    }
}
