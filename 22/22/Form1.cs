namespace _22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] a =new int[3,3];
        int[,] b = new int[3, 3];
        int[,] c = new int[3, 3];

        private void button2_Click(object sender, EventArgs e)
        {
            int i, j;
            listBox2.Items.Clear();
            string sat;
            sat = " ";
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    a[i,j]=Convert.ToInt32(Microsoft.VisualBasic.Interaction
                        .InputBox((Convert.ToString(i)+Convert.ToString(",")+Convert.ToString(j)+Convert.ToString(". eleman")),
                        "A matrisi degerleri","0",50,50));
                    sat = sat + " " + Convert.ToString(b[i, j]);

                }
                listBox2.Items.Add(sat);
                sat = " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j;
            listBox1.Items.Clear();
            string sat;
            sat = " ";
            for ( i = 0; i < 3; i++)
            {
                for (j=0; j < 3; j++)
                {
                    b[i, j] = Convert.ToInt32(Microsoft.VisualBasic.Interaction
                        .InputBox((Convert.ToString(i) + Convert.ToString(",") + Convert.ToString(j) + Convert.ToString(". eleman")),
                        "B matrisi degerleri", "0", 50, 50));
                    sat=sat+" " + Convert.ToString(b[i,j]);

                }
                listBox1.Items.Add(sat);
                sat = " ";  
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i, j;
            listBox3.Items.Clear(); 
            string sat; 
            sat = " ";
            label4.Text = "A+B toplama";
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    c[i, j] = a[i, j] + a[i, j];
                    sat = sat + " " + Convert.ToString(c[i, j]);
                }
                listBox3.Items.Add(sat);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i, j;
            listBox3.Items.Clear();
            string sat;
            sat = " ";
            label4.Text = "A-B çýkarma";
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    c[i, j] = a[i, j] - a[i, j];
                }
                listBox3.Items.Add(sat);
            }
            
        }
    }
}
