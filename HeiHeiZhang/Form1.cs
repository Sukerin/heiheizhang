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

        private void Button1_Click(object sender, EventArgs e)
        {
            int packageCapacity = 800;
            int[] w = { 0, 200, 300, 400, 500 };
            int[] v = { 0, 3, 4, 5, 8 };
            int goodsNum = w.Length;
            int[,] f = new int[goodsNum, packageCapacity+1];
            

            for (int i = 1; i < goodsNum; i++)
            {
                for (int j = 1; j <= packageCapacity; j++)
                {
                    if (w[i] > j)
                    {
                        f[i,j] = f[i - 1,j];
                    }
                    else
                    {
                        f[i,j]= f[i-1,j] > f[i-1,j-w[i]]+v[i] ? f[i - 1, j] : f[i - 1, j - w[i]] + v[i];
                    }
                }
            }
            /*打印*/
            for (int i = 1; i < goodsNum; i++)
            {
                for (int j = 1; j <= packageCapacity; j++)
                {
                    Console.Write("f[{0},{1}]-{2} ",i,j ,f[i, j]);
                }
                Console.Write("\n");
            }
            //foreach (int str in f) {
            //   Console.WriteLine(str);
            //  }



        }
    }
}
