using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeiHeiZhang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calPath(int[,] f)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int packageCapacity = 800;
            int[] w = { 0, 200, 300, 400, 500 };
            int[] v = { 0, 301, 401, 602, 601 };
            int goodsNum = w.Length;
            int[,] f = new int[goodsNum, packageCapacity + 1];
            List<int> path = new List<int>();

            for (int i = 1; i < goodsNum; i++)
            {
                for (int j = 1; j <= packageCapacity; j++)
                {
                    if (w[i] > j)
                    {
                        f[i, j] = f[i - 1, j];
                    }
                    else
                    {
                        f[i, j] = f[i - 1, j] > f[i - 1, j - w[i]] + v[i] ? f[i - 1, j] : f[i - 1, j - w[i]] + v[i];
                    }
                }
            }

            int f0 = goodsNum-1;
            int f1 = packageCapacity;
            
            while (f0 > 0&&f1 > 0){
                if (w[f0] > f1)
                {
                    f0 = f0 - 1;
                  
                }
                else
                {

                    int noDry = f[f0 - 1, f1];
                    int dry = f[f0 - 1, f1 - w[f0]] + v[f0];
                    if (noDry > dry)
                    {
                        f0 = f0 - 1;
                    }
                    else
                    {
                        path.Add(f0);

                        f1 = f1 - w[f0];
                        f0 = f0 - 1;

                    }
                }
            }

           
            foreach (int str in path) Console.WriteLine(str);

            Console.WriteLine("f[{0},{1}]-{2} ", goodsNum - 1, packageCapacity, f[goodsNum - 1, packageCapacity]);
            /*打印*/
            for (int i = 1; i < goodsNum; i++)
            {
                for (int j = 1; j <= packageCapacity; j++)
                {
                    Console.Write("f[{0},{1}]-{2} ", i, j, f[i, j]);
                }
                Console.Write("\n");
            }
            //foreach (int str in f) {
            //   Console.WriteLine(str);
            //  }



        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
