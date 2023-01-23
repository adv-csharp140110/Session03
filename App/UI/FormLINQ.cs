using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UI
{
    public partial class FormLINQ : Form
    {
        public FormLINQ()
        {
            InitializeComponent();
        }

        List<Product> products = new List<Product>{
            new Product{Id = 1, Name = "PC 1", Price= 1000, InStock = false},
            new Product{Id = 2, Name = "PC 2", Price= 1500, InStock = true},
            new Product{Id = 3, Name = "Mouse", Price= 500, InStock = true},
            new Product{Id = 4, Name = "Keyboard", Price= 200, InStock = true},
            new Product{Id = 5, Name = "Monitor", Price= 800, InStock = false},
            };
        

        private void FormLINQ_Load(object sender, EventArgs e)
        {
            /*
             *  Linq syntax:
             *      1. query synatx
             *          sql -> c#
             *      2. method syntax
             *          lambda expression
             */

            int[] numbers = { 1, 2, 6, 87, 44, 75, 55, 79, 87, 9, 3, 52 };
            // select n from numbers where n % 2 = 0

            var evens = from n in numbers
                        where n % 2 == 0
                        select n;

            var evens_method = numbers.Where(x => x % 2 == 0);

            /**
             * 1. fard,
             * 2. 10 ta 50
             * 3. 3 va 5 bakshpazir bashan
             * 4. fard va tavan 2             
             */

            var a1 = (from n in numbers where n % 2 != 0 select n);
            var a2 = from n in numbers where n >= 10 && n <= 50 select n;
            var a3 = from n in numbers where n % 3 == 0 && n % 5 == 0 select n;
            var a3_ = from n in numbers where  n % 15 == 0 select n;
            var a4 = from n in numbers where n % 2 != 0 select Math.Pow(n, 2);


            
            var a1_method = numbers.Where(x => x % 2 != 0);

            var a2_method1 = numbers.Where(x => x >= 10 && x <= 50);
            var a2_method2 = numbers.Where(x => x >= 10).Where(x => x <= 50);

            var a2_method3_1= numbers.Where(x => x >= 10);
            var a2_method3_2 = a2_method3_1.Where(x => x >= 10);



            var a3_method = numbers.Where(x => x % 15 == 0);
            var a4_method = numbers.Where(x => x % 2 != 0).Select(x => x * x);



            /*
             *  1. sort price,
             *  2. sort price, inStock
             *  3. price < 1000
             *  4. name, price
             * 
             * */

        }

        private void buttonLinq1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from p in products orderby p.Price select p).ToList();
            dataGridView1.DataSource = products.OrderBy(x => x.Price).ToList();
        }

        private void buttonLinq2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from p in products orderby p.Price orderby p.InStock select p).ToList();
            dataGridView1.DataSource = products.OrderBy(x => x.Price).OrderBy(x=>x.InStock).ToList();

        }

        private void buttonLinq3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from p in products where p.Price < 1000 select p).ToList();
            dataGridView1.DataSource = products.Select(x => x.Price < 1000).ToList();

        }

        private void buttonLinq4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from p in products where p.Price < 1000 select new {ProductName = p.Name, p.Price} ).ToList();
            dataGridView1.DataSource = products.Where(x => x.Price < 1000).Select(x=> new { ProductName = x.Name, x.Price}).ToList();
        }

        /**
         *  Programming Paradigms
         *      1. Impretive
         *      2. Descrpitive
         *          sql
         *          Functional Programming
         *          
         *              Where=filter,  Select=map, 
         *              Map-Reduce
         *          
         */
    }


    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Price { get; set; }

        public bool InStock { get; set; }
    }
}
