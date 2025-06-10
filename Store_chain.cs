using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd_3
{
    internal class Store_chain: Store_chain_base
    {
        public string Name { get; set; }
        public string Adres { get; set; }
        public int Count_sales { get; set; }
        public int Mont_revenue { get; set; }
        public int Count_buyer { get; set; }

        public Store_chain(string name, string adres, int count_sal, int mont_rev, int count_buyer) : base (name, adres, count_sal, mont_rev)
        {
            Name = name;
            Adres = adres;
            Count_sales = count_sal;
            Mont_revenue = mont_rev;
            Count_buyer = count_buyer;
        }

        public double Profit()
        {
            if (Count_sales > 50000) return 2*base.Profit();
            return 0.5*base.Profit();
        }

        public string Info()
        {
            return base.Info() + $" {Count_buyer.ToString()}";
        }

        public override List<Store_chain_base> ListStore()
        {
            return base.ListStore();
        }

        public List<Store_chain_base> SortList()
        {
            return base.ListStore().OrderBy(x => x.Name).ToList();
        }

        public List<Store_chain_base> SortList(ModeSort mod)
        {
            return mod switch
            {
                ModeSort.Name => base.ListStore().OrderBy(x => x.Name).ToList(),
                ModeSort.Adres => base.ListStore().OrderBy(x => x.Adres).ToList(),
                ModeSort.Count_sales => base.ListStore().OrderBy(x => x.Count_sales).ToList(),
                ModeSort.Mont_revenue => base.ListStore().OrderBy(x => x.Mont_revenue).ToList(),
                ModeSort.Count_buyer => base.ListStore().OrderBy(x => x.Count_sales).ToList()
            };
            
        }
    }
}
