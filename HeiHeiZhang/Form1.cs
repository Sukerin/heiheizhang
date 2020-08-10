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
        private float packageCapacity;
        private List<Food> foodList = new List<Food>();

        public Form1()
        {
            InitializeComponent();

        }

        private void calPath(int[,] f)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (foodList.Count == 0)
            {
                MessageBox.Show("请输入数据");
                return;
            }
            //int packageCapacity = 800;
            //int[] w = { 0, 200, 300, 400, 500 };
            //int[] v = { 0, 301, 401, 602, 601 };
            int packageCapacity;
            try
            {
                packageCapacity = Convert.ToInt32((float.Parse(text_long_length.Text) * 100));

            }
            catch (Exception ex)
            {
                MessageBox.Show("长度请输入数字（最多支持2位小数）");
                return;
            }



            int[] w = new int[foodList.Count + 1];
            int[] v = new int[foodList.Count + 1];
            foodList.OrderBy(p => p.value).ToList();
            w[0] = 0;
            v[0] = 0;
            int index = 1;
            foreach (var item in foodList)
            {
                w[index] = Convert.ToInt32((item.weight * 100));
                v[index] = Convert.ToInt32((item.value * 100));
                index++;
            }


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

            int f0 = goodsNum - 1;
            int f1 = packageCapacity;

            while (f0 > 0 && f1 > 0)
            {
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


            float total = f[goodsNum - 1, packageCapacity]/100f;
            float remain = (packageCapacity - f[goodsNum - 1, packageCapacity])/100f;
           
            List<string> pathWeight = new List<string>(); 
            foreach(int p in path)
            {
                pathWeight.Add(foodList[p-1].weight.ToString()+"短棒*1");
            }
            pathWeight.Insert(0, "耗材如下:");
            string pathNote = string.Join("\n", pathWeight.ToArray());

            MessageBox.Show(string.Format("总计耗费{0}\n剩余{1}\n{2}", total,remain,pathNote));

            //foreach (int str in path) Console.WriteLine(str);

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



        private void Button_push_Click(object sender, EventArgs e)
        {
            //float long_length = float.Parse(text_long_length.Text);
            try
            {
                float short_length = float.Parse(float.Parse(text_short_length.Text).ToString("f2"));
                int short_num = int.Parse(text_shortNum.Text);
                ListViewItem item = new ListViewItem();
                item.Text = text_short_length.Text;
                item.SubItems.Add(text_shortNum.Text);
              

                listView1.Items.Add(item);
                for (int i = 0; i < short_num; i++)
                {
                    foodList.Add(new Food(short_length, short_length));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("长度请填写数字（最多支持2位小数），数量请填写整数");
            }

        }
        private void Button_clean_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foodList.Clear();
        }
        public class Food

        {
            public float weight;
            public float value;

            public Food(float weight, float value)
            {
                this.weight = weight;
                this.value = value;
            }
        }

      
    }
}
