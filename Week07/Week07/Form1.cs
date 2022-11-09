using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week07.Entities;

namespace Week07
{
    public partial class Form1 : Form
    {
        List<Tick> Ticks;
        PortfolioEntities context = new PortfolioEntities();
        List<PortfolioItem> Portfolio = new List<PortfolioItem>();
        List<decimal> Gainings = new List<decimal>();

      
        public Form1()
        {
            InitializeComponent();
            Ticks = context.Ticks.ToList();
            dataGridView1.DataSource = Ticks;
            CreatePortfolio();

            int interval = 30;
            DateTime startDate = (from x in Ticks
                                   select x.TradingDay).Min();
            DateTime endDate = new DateTime(2016, 12, 30);
            TimeSpan z = endDate - startDate;
            for (int i = 0; i < z.Days; i++)
            {
                decimal g = GetPortfolioValue(startDate.AddDays(i + interval)) - GetPortfolioValue(startDate.AddDays(i));
                Gainings.Add(g);
                Console.WriteLine(i + " " + g);

            }

            var orderedGainings = (from x in Gainings
                                   orderby x
                                   select x).ToList();
            MessageBox.Show(orderedGainings[orderedGainings.Count() / 5].ToString());
        }

        private void CreatePortfolio()
        {
            Portfolio.Add(new PortfolioItem() { Index = "OTP", Volume = 10 });
            Portfolio.Add(new PortfolioItem() { Index = "ZWACK", Volume = 10 });
            Portfolio.Add(new PortfolioItem() { Index = "ELMU", Volume = 10 });

            dataGridView2.DataSource = Portfolio;
        }

        private decimal GetPortfolioValue(DateTime date) 
        {
            decimal value = 0;
            foreach (var item in Portfolio)
            {
                var last = (from x in Ticks
                            where item.Index == x.Index.Trim() //a Trim()-el levágjuk a felesleges karaktereket amikkel fel van töltve az index mező
                            && date <= x.TradingDay
                            select x).First();
                value += (decimal)last.Price * item.Volume;
            }

            return value;
        }




    }
}
