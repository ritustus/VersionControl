using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week05.Entities;
using Week05.MNBServiceReference;

namespace Week05
{
    public partial class Form1 : Form
    {

        BindingList<RateData> Rates = new BindingList<RateData>();
        

        public Form1()
        {
            InitializeComponent();

            dataGridView1.DataSource = Rates;

        }

        private void GetExchangeRates() 
        {
            var mnbService = new MNBArfolyamServiceSoapClient();
            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = "EUR",
                startDate = "2020-01-01",
                endDate = "2020-06-30"
            };

           

            var response = mnbService.GetExchangeRates(request);
            var result = response.GetExchangeRatesResult;
        }

       
        

       
    }
}
