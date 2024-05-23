using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplom
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            this.Controls.Remove(listBox2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int znaq1, znaq2, znaq3;
            int a, b, c, d, x;
            double divid;
            string PLACEHOLDER;
            int counter;
            string pls2;
            int znaqs;
            
            
            if(radioButton1.Checked)
            {
                if(textBox1.Text == "")
                {
                    return;
                }
                counter = Convert.ToInt32(textBox1.Text);
                for(int i = 0; i < counter; i++)
                {
                    znaq1 = rnd.Next(3, 5);
                    znaq2 = rnd.Next(1, 4);

                    if (znaq1 == 3 && znaq2 == 1)
                    {
                        a = rnd.Next(1, 100);
                        x = rnd.Next(1, 100);
                        b = rnd.Next(0, 100);
                        d = a * (x + b);
                        while (d > 999)
                        {
                            x = rnd.Next(1, 100);
                            b = rnd.Next(0, 100);
                            d = a * (x + b);
                        }
                        
                        PLACEHOLDER = Convert.ToString(a) + "(x+" + Convert.ToString(b) + ")=" + Convert.ToString(d);
                        if (b == 0)
                        {
                            PLACEHOLDER = Convert.ToString(a) + "x" + "=" + Convert.ToString(d);
                        }
                        listBox1.Items.Add(PLACEHOLDER);
                        pls2 = Convert.ToString(x);
                        listBox2.Items.Add(pls2);
                    }
                    if (znaq1 == 3 && znaq2 == 2)
                    {
                        a = rnd.Next(1, 100);
                        x = rnd.Next(1, 100);
                        b = rnd.Next(0, x);
                        d = a * (x - b);
                        PLACEHOLDER = Convert.ToString(a) + "(x-" + Convert.ToString(b) + ")=" + Convert.ToString(d);
                        if (b == 0)
                        {
                            PLACEHOLDER = Convert.ToString(a) + "x" + "=" + Convert.ToString(d);
                        }
                        listBox1.Items.Add(PLACEHOLDER);
                        pls2 = Convert.ToString(x);
                        listBox2.Items.Add(pls2);

                    }
                    if (znaq1 == 3 && znaq2 == 3)
                    {
                        a = rnd.Next(1, 100);
                        x = rnd.Next(1, 100);
                        b = rnd.Next(1, 100);
                        if(b == a * x)
                        {
                            b = rnd.Next(1, 100);
                        }
                        divid = Convert.ToDouble(a * x) / Convert.ToDouble(b);



                        while (Convert.ToDouble(divid % 1) != 0)
                        {
                            x = rnd.Next(1, 100);
                            b = rnd.Next(1, 100);
                            divid = Convert.ToDouble(a * x) / Convert.ToDouble(b);
                        }


                        d = a * (x / b);
                        PLACEHOLDER = Convert.ToString(a) + "(x÷" + Convert.ToString(b) + ")=" + Convert.ToString(d);
                        if (b == 1)
                        {
                            PLACEHOLDER = Convert.ToString(a) + "x" + "=" + Convert.ToString(d);
                        }
                        listBox1.Items.Add(PLACEHOLDER);
                        pls2 = Convert.ToString(x);
                        listBox2.Items.Add(pls2);
                    }
                    if (znaq1 == 4 && znaq2 == 1)
                    {

                        d = rnd.Next(1, 100);
                        a = rnd.Next(1, 100);
                        
                        divid = Convert.ToDouble(a) / Convert.ToDouble(d);
                        while (Convert.ToDouble(divid % 1) != 0)
                        {
                            d = rnd.Next(1, 100);
                            a = rnd.Next(1, 100);
                            
                            divid = Convert.ToDouble(a) / Convert.ToDouble(d);
                        }

                        x = rnd.Next(1, (a / d));
                        b = (a / d) - x;
                        PLACEHOLDER = Convert.ToString(a) + "÷(x+" + Convert.ToString(b) + ")=" + Convert.ToString(d);
                        if (b == 0)
                        {
                            PLACEHOLDER = Convert.ToString(a) + "÷x" + "=" + Convert.ToString(d);
                        }
                        listBox1.Items.Add(PLACEHOLDER);
                        pls2 = Convert.ToString(x);
                        listBox2.Items.Add(pls2);
                    }
                    if (znaq1 == 4 && znaq2 == 2)
                    {
                        d = rnd.Next(1, 100);
                        a = rnd.Next(1, 100);
                        
                        divid = Convert.ToDouble(a) / Convert.ToDouble(d);
                        while (Convert.ToDouble(divid % 1) != 0)
                        {

                            a = rnd.Next(1, 100);
                            d = rnd.Next(1, 100);
                            divid = Convert.ToDouble(a) / Convert.ToDouble(d);
                        }

                        x = rnd.Next(((a / d) + 1), 100);
                        b = x - (a / d);
                        PLACEHOLDER = Convert.ToString(a) + "÷(x-" + Convert.ToString(b) + ")=" + Convert.ToString(d);
                        if (b == 0)
                        {
                            PLACEHOLDER = Convert.ToString(a) + "÷x" + "=" + Convert.ToString(d);
                        }
                        listBox1.Items.Add(PLACEHOLDER);
                        pls2 = Convert.ToString(x);
                        listBox2.Items.Add(pls2);
                    }
                    if (znaq1 == 4 && znaq2 == 3)
                    {
                        a = rnd.Next(1, 100);
                        b = rnd.Next(1, 100);
                        x = rnd.Next(1, 100);

                        divid = Convert.ToDouble(b) / Convert.ToDouble(x);



                        while (Convert.ToDouble(divid % 1) != 0)
                        {
                            b = rnd.Next(1, 100);
                            x = rnd.Next(1, 100);
                            divid = Convert.ToDouble(b) / Convert.ToDouble(x);
                        }


                        d = a * (b / x);
                        PLACEHOLDER = Convert.ToString(a) + "÷(x÷" + Convert.ToString(b) + ")=" + Convert.ToString(d);
                        if (b == 1)
                        {
                            PLACEHOLDER = Convert.ToString(a) + "÷x" + "=" + Convert.ToString(d);
                        }
                        listBox1.Items.Add(PLACEHOLDER);
                        pls2 = Convert.ToString(x);
                        listBox2.Items.Add(pls2);
                    }
                }
                

            }
            if (radioButton2.Checked)
            {
                if (textBox1.Text == "")
                {
                    return;
                }
                counter = Convert.ToInt32(textBox1.Text);
                for (int i = 0; i < counter; i++)
                {
                    znaq1 = rnd.Next(3, 5);
                    znaq2 = rnd.Next(1, 4);
                    znaq3 = rnd.Next(1, 3);
                    if (znaq1 == 3 && znaq2 == 1 && znaq3 == 1)
                    {
                        a = rnd.Next(1, 100);
                        x = rnd.Next(1, 100);
                        b = rnd.Next(0, 100);
                        c = rnd.Next(1, 100);
                        d = a * (x + b) + c;
                        while (d > 999)
                        {
                            x = rnd.Next(1, 100);
                            b = rnd.Next(0, 100);
                            c = rnd.Next(1, 100);
                            d = a * (x + b) + c;
                        }
                        PLACEHOLDER = Convert.ToString(a) + "(x+" + Convert.ToString(b) + ")" + "+" + Convert.ToString(c) + "=" + Convert.ToString(d);
                        if (b == 0)
                        {
                            PLACEHOLDER = Convert.ToString(a) + "x+" + Convert.ToString(c) + "=" + Convert.ToString(d);
                        }
                        listBox1.Items.Add(PLACEHOLDER);
                        pls2 = Convert.ToString(x);
                        listBox2.Items.Add(pls2);
                    }
                    if (znaq1 == 3 && znaq2 == 2 && znaq3 == 1)
                    {
                        a = rnd.Next(1, 100);
                        x = rnd.Next(1, 100);
                        b = rnd.Next(0, x);
                        c = rnd.Next(1, 100);
                        d = a * (x - b) + c;
                        while (d > 999)
                        {
                            x = rnd.Next(1, 100);
                            b = rnd.Next(0, x);
                            c = rnd.Next(1, 100);
                            d = a * (x - b) + c;
                        }
                        PLACEHOLDER = Convert.ToString(a) + "(x-" + Convert.ToString(b) + ")" + "+" + Convert.ToString(c) + "=" + Convert.ToString(d);
                        if (b == 0)
                        {
                            PLACEHOLDER = Convert.ToString(a) + "x+" + Convert.ToString(c) + "=" + Convert.ToString(d);
                        }
                        listBox1.Items.Add(PLACEHOLDER);
                        pls2 = Convert.ToString(x);
                        listBox2.Items.Add(pls2);

                    }
                    if (znaq1 == 3 && znaq2 == 3 && znaq3 == 1)
                    {
                        a = rnd.Next(1, 100);
                        x = rnd.Next(1, 100);
                        b = rnd.Next(1, 100);
                        c = rnd.Next(1, 100);
                        if (b == a * x)
                        {
                            b = rnd.Next(1, 100);
                        }
                        divid = Convert.ToDouble(a * x) / Convert.ToDouble(b);



                        while (Convert.ToDouble(divid % 1) != 0)
                        {
                            x = rnd.Next(1, 100);
                            b = rnd.Next(1, 100);
                            divid = Convert.ToDouble(a * x) / Convert.ToDouble(b);
                        }


                        d = a * (x / b) + c;
                        PLACEHOLDER = Convert.ToString(a) + "(x÷" + Convert.ToString(b) + ")" + "+" + Convert.ToString(c) + "=" + Convert.ToString(d);
                        if (b == 1)
                        {
                            PLACEHOLDER = Convert.ToString(a) + "x+" + Convert.ToString(c) + "=" + Convert.ToString(d);
                        }
                        listBox1.Items.Add(PLACEHOLDER);
                        pls2 = Convert.ToString(x);
                        listBox2.Items.Add(pls2);
                    }
                    if (znaq1 == 4 && znaq2 == 1 && znaq3 == 1)
                    {
                        d = rnd.Next(1, 100);
                        c = rnd.Next(1, d);
                        a = rnd.Next(1, 100);
                        divid = Convert.ToDouble(a) / Convert.ToDouble(d - c);
                        while (Convert.ToDouble(divid % 1) != 0)
                        {

                            d = rnd.Next(1, 100);
                            c = rnd.Next(1, d);
                            a = rnd.Next(1, 100);


                            divid = Convert.ToDouble(a) / Convert.ToDouble(d - c);
                        }

                        x = rnd.Next(1, (a / (d - c)));
                        b = (a / (d - c)) - x;
                        PLACEHOLDER = Convert.ToString(a) + "÷(x+" + Convert.ToString(b) + ")" + "+" + Convert.ToString(c) + "=" + Convert.ToString(d);
                        if (b == 0)
                        {
                            PLACEHOLDER = Convert.ToString(a) + "÷x+" + Convert.ToString(c) + "=" + Convert.ToString(d);
                        }
                        listBox1.Items.Add(PLACEHOLDER);
                        pls2 = Convert.ToString(x);
                        listBox2.Items.Add(pls2);
                    }
                    if (znaq1 == 4 && znaq2 == 2 && znaq3 == 1)
                    {
                        d = rnd.Next(1, 100);
                        a = rnd.Next(1, 100);
                        c = rnd.Next(1, d);

                        divid = Convert.ToDouble(a) / Convert.ToDouble(d - c);
                        while (Convert.ToDouble(divid % 1) != 0)
                        {

                            a = rnd.Next(1, 100);
                            c = rnd.Next(1, d);
                            d = rnd.Next(1, 100);
                            divid = Convert.ToDouble(a) / Convert.ToDouble(d - c);
                        }

                        x = rnd.Next(((a / (d - c)) + 1), 100);
                        b = x - (a / (d - c));
                        PLACEHOLDER = Convert.ToString(a) + "÷(x-" + Convert.ToString(b) + ")" + "+" + Convert.ToString(c) + "=" + Convert.ToString(d);
                        if (b == 0)
                        {
                            PLACEHOLDER = Convert.ToString(a) + "÷x+" + Convert.ToString(c) + "=" + Convert.ToString(d);
                        }
                        listBox1.Items.Add(PLACEHOLDER);
                        pls2 = Convert.ToString(x);
                        listBox2.Items.Add(pls2);
                    }
                    if (znaq1 == 4 && znaq2 == 3 && znaq3 == 1)
                    {
                        a = rnd.Next(1, 100);
                        b = rnd.Next(1, 100);
                        x = rnd.Next(1, 100);

                        divid = Convert.ToDouble(b) / Convert.ToDouble(x);



                        while (Convert.ToDouble(divid % 1) != 0)
                        {
                            b = rnd.Next(1, 100);
                            x = rnd.Next(1, 100);
                            divid = Convert.ToDouble(b) / Convert.ToDouble(x);
                        }
                        c = rnd.Next(1, 100);

                        d = a * (b / x) + c;
                        PLACEHOLDER = Convert.ToString(a) + "÷(x÷" + Convert.ToString(b) + ")" + "+" + Convert.ToString(c) + "=" + Convert.ToString(d);
                        if (b == 1)
                        {
                            PLACEHOLDER = Convert.ToString(a) + "÷x+" + Convert.ToString(c) + "=" + Convert.ToString(d);
                        }
                        listBox1.Items.Add(PLACEHOLDER);
                        pls2 = Convert.ToString(x);
                        listBox2.Items.Add(pls2);
                    }
                    if (znaq1 == 3 && znaq2 == 1 && znaq3 == 2)
                    {
                        a = rnd.Next(1, 100);
                        x = rnd.Next(1, 100);
                        b = rnd.Next(0, 100);
                        c = rnd.Next(1, (a * (x + b)));
                        d = a * (x + b) - c;
                        while (d > 999)
                        {
                            x = rnd.Next(1, 100);
                            b = rnd.Next(0, 100);
                            c = rnd.Next(1, (a * (x + b)));
                            d = a * (x + b) - c;
                        }
                        PLACEHOLDER = Convert.ToString(a) + "(x+" + Convert.ToString(b) + ")" + "-" + Convert.ToString(c) + "=" + Convert.ToString(d);
                        if (b == 0)
                        {
                            PLACEHOLDER = Convert.ToString(a) + "x-" + Convert.ToString(c) + "=" + Convert.ToString(d);
                        }
                        listBox1.Items.Add(PLACEHOLDER);
                        pls2 = Convert.ToString(x);
                        listBox2.Items.Add(pls2);
                    }
                    if (znaq1 == 3 && znaq2 == 2 && znaq3 == 2)
                    {
                        a = rnd.Next(1, 100);
                        x = rnd.Next(1, 100);
                        b = rnd.Next(0, x);
                        c = rnd.Next(1, (a * (x - b)));
                        d = a * (x - b) - c;
                        while (d > 999)
                        {
                            x = rnd.Next(1, 100);
                            b = rnd.Next(0, x);
                            c = rnd.Next(1, (a * (x - b)));
                            d = a * (x - b) - c;
                        }
                        PLACEHOLDER = Convert.ToString(a) + "(x-" + Convert.ToString(b) + ")" + "-" + Convert.ToString(c) + "=" + Convert.ToString(d);
                        if (b == 0)
                        {
                            PLACEHOLDER = Convert.ToString(a) + "x-" + Convert.ToString(c) + "=" + Convert.ToString(d);
                        }
                        listBox1.Items.Add(PLACEHOLDER);
                        pls2 = Convert.ToString(x);
                        listBox2.Items.Add(pls2);

                    }
                    if (znaq1 == 3 && znaq2 == 3 && znaq3 == 2)
                    {
                        a = rnd.Next(1, 100);
                        x = rnd.Next(1, 100);
                        b = rnd.Next(1, 100);

                        if (b == a * x)
                        {
                            b = rnd.Next(1, 100);
                        }
                        divid = Convert.ToDouble(a * x) / Convert.ToDouble(b);



                        while (Convert.ToDouble(divid % 1) != 0)
                        {
                            x = rnd.Next(1, 100);
                            b = rnd.Next(1, 100);
                            divid = Convert.ToDouble(a * x) / Convert.ToDouble(b);
                        }
                        

                        c = rnd.Next(0, (a * (x / b)));
                        d = a * (x / b) - c;
                        PLACEHOLDER = Convert.ToString(a) + "(x÷" + Convert.ToString(b) + ")" + "-" + Convert.ToString(c) + "=" + Convert.ToString(d);
                        if (b == 1)
                        {
                            PLACEHOLDER = Convert.ToString(a) + "x-" + Convert.ToString(c) + "=" + Convert.ToString(d);
                        }
                        listBox1.Items.Add(PLACEHOLDER);
                        pls2 = Convert.ToString(x);
                        listBox2.Items.Add(pls2);
                    }
                    if (znaq1 == 4 && znaq2 == 1 && znaq3 == 2)
                    {
                        d = rnd.Next(1, 100);
                        c = rnd.Next(1, 100);
                        a = rnd.Next(1, 100);
                        divid = Convert.ToDouble(a) / Convert.ToDouble(d + c);
                        while (Convert.ToDouble(divid % 1) != 0)
                        {

                            d = rnd.Next(1, 100);
                            c = rnd.Next(1, 100);
                            a = rnd.Next(1, 100);


                            divid = Convert.ToDouble(a) / Convert.ToDouble(d + c);
                        }

                        x = rnd.Next(1, (a / (d + c)));
                        b = (a / (d + c)) - x;
                        PLACEHOLDER = Convert.ToString(a) + "÷(x+" + Convert.ToString(b) + ")" + "-" + Convert.ToString(c) + "=" + Convert.ToString(d);
                        if (b == 0)
                        {
                            PLACEHOLDER = Convert.ToString(a) + "÷x-" + Convert.ToString(c) + "=" + Convert.ToString(d);
                        }
                        listBox1.Items.Add(PLACEHOLDER);
                        pls2 = Convert.ToString(x);
                        listBox2.Items.Add(pls2);
                    }
                    if (znaq1 == 4 && znaq2 == 2 && znaq3 == 1)
                    {
                        d = rnd.Next(1, 100);
                        a = rnd.Next(1, 100);
                        c = rnd.Next(1, 100);

                        divid = Convert.ToDouble(a) / Convert.ToDouble(d + c);
                        while (Convert.ToDouble(divid % 1) != 0)
                        {

                            a = rnd.Next(1, 100);
                            c = rnd.Next(1, 100);
                            d = rnd.Next(1, 100);
                            divid = Convert.ToDouble(a) / Convert.ToDouble(d + c);
                        }

                        x = rnd.Next(((a / (d + c)) + 1), 100);
                        b = x - (a / (d + c));
                        PLACEHOLDER = Convert.ToString(a) + "÷(x-" + Convert.ToString(b) + ")" + "-" + Convert.ToString(c) + "=" + Convert.ToString(d);
                        if (b == 0)
                        {
                            PLACEHOLDER = Convert.ToString(a) + "÷x-" + Convert.ToString(c) + "=" + Convert.ToString(d);
                        }
                        listBox1.Items.Add(PLACEHOLDER);
                        pls2 = Convert.ToString(x);
                        listBox2.Items.Add(pls2);
                    }
                    if (znaq1 == 4 && znaq2 == 3 && znaq3 == 2)
                    {
                        a = rnd.Next(1, 100);
                        b = rnd.Next(1, 100);
                        x = rnd.Next(1, 100);

                        divid = Convert.ToDouble(b) / Convert.ToDouble(x);



                        while (Convert.ToDouble(divid % 1) != 0)
                        {
                            b = rnd.Next(1, 100);
                            x = rnd.Next(1, 100);
                            divid = Convert.ToDouble(b) / Convert.ToDouble(x);
                        }
                        c = rnd.Next(1, (a * (b / x)));

                        d = a * (b / x) - c;
                        PLACEHOLDER = Convert.ToString(a) + "÷(x÷" + Convert.ToString(b) + ")" + "-" + Convert.ToString(c) + "=" + Convert.ToString(d);
                        if (b == 1)
                        {
                            PLACEHOLDER = Convert.ToString(a) + "÷x-" + Convert.ToString(c) + "=" + Convert.ToString(d);
                        }
                        listBox1.Items.Add(PLACEHOLDER);
                        pls2 = Convert.ToString(x);
                        listBox2.Items.Add(pls2);
                    }
                }
                
            }
            if (radioButton3.Checked)
            {
                if (textBox1.Text == "")
                {
                    return;
                }
                counter = Convert.ToInt32(textBox1.Text);
                for (int i = 0; i < counter; i++)
                {
                    znaqs = rnd.Next(2, 4);
                    if(znaqs == 2)
                    {
                        znaq1 = rnd.Next(3, 5);
                        znaq2 = rnd.Next(1, 4);

                        if (znaq1 == 3 && znaq2 == 1)
                        {
                            a = rnd.Next(1, 100);
                            x = rnd.Next(1, 100);
                            b = rnd.Next(0, 100);
                            d = a * (x + b);
                            while (d > 999)
                            {
                                x = rnd.Next(1, 100);
                                b = rnd.Next(0, 100);
                                d = a * (x + b);
                            }

                            PLACEHOLDER = Convert.ToString(a) + "(x+" + Convert.ToString(b) + ")=" + Convert.ToString(d);
                            if (b == 0)
                            {
                                PLACEHOLDER = Convert.ToString(a) + "x" + "=" + Convert.ToString(d);
                            }
                            listBox1.Items.Add(PLACEHOLDER);
                            pls2 = Convert.ToString(x);
                            listBox2.Items.Add(pls2);
                        }
                        if (znaq1 == 3 && znaq2 == 2)
                        {
                            a = rnd.Next(1, 100);
                            x = rnd.Next(1, 100);
                            b = rnd.Next(0, x);
                            d = a * (x - b);
                            PLACEHOLDER = Convert.ToString(a) + "(x-" + Convert.ToString(b) + ")=" + Convert.ToString(d);
                            if (b == 0)
                            {
                                PLACEHOLDER = Convert.ToString(a) + "x" + "=" + Convert.ToString(d);
                            }
                            listBox1.Items.Add(PLACEHOLDER);
                            pls2 = Convert.ToString(x);
                            listBox2.Items.Add(pls2);

                        }
                        if (znaq1 == 3 && znaq2 == 3)
                        {
                            a = rnd.Next(1, 100);
                            x = rnd.Next(1, 100);
                            b = rnd.Next(1, 100);
                            if (b == a * x)
                            {
                                b = rnd.Next(1, 100);
                            }
                            divid = Convert.ToDouble(a * x) / Convert.ToDouble(b);



                            while (Convert.ToDouble(divid % 1) != 0)
                            {
                                x = rnd.Next(1, 100);
                                b = rnd.Next(1, 100);
                                divid = Convert.ToDouble(a * x) / Convert.ToDouble(b);
                            }


                            d = a * (x / b);
                            PLACEHOLDER = Convert.ToString(a) + "(x÷" + Convert.ToString(b) + ")=" + Convert.ToString(d);
                            if (b == 1)
                            {
                                PLACEHOLDER = Convert.ToString(a) + "x" + "=" + Convert.ToString(d);
                            }
                            listBox1.Items.Add(PLACEHOLDER);
                            pls2 = Convert.ToString(x);
                            listBox2.Items.Add(pls2);
                        }
                        if (znaq1 == 4 && znaq2 == 1)
                        {

                            d = rnd.Next(1, 100);
                            a = rnd.Next(1, 100);

                            divid = Convert.ToDouble(a) / Convert.ToDouble(d);
                            while (Convert.ToDouble(divid % 1) != 0)
                            {
                                d = rnd.Next(1, 100);
                                a = rnd.Next(1, 100);

                                divid = Convert.ToDouble(a) / Convert.ToDouble(d);
                            }

                            x = rnd.Next(1, (a / d));
                            b = (a / d) - x;
                            PLACEHOLDER = Convert.ToString(a) + "÷(x+" + Convert.ToString(b) + ")=" + Convert.ToString(d);
                            if (b == 0)
                            {
                                PLACEHOLDER = Convert.ToString(a) + "÷x" + "=" + Convert.ToString(d);
                            }
                            listBox1.Items.Add(PLACEHOLDER);
                            pls2 = Convert.ToString(x);
                            listBox2.Items.Add(pls2);
                        }
                        if (znaq1 == 4 && znaq2 == 2)
                        {
                            d = rnd.Next(1, 100);
                            a = rnd.Next(1, 100);

                            divid = Convert.ToDouble(a) / Convert.ToDouble(d);
                            while (Convert.ToDouble(divid % 1) != 0)
                            {

                                a = rnd.Next(1, 100);
                                d = rnd.Next(1, 100);
                                divid = Convert.ToDouble(a) / Convert.ToDouble(d);
                            }

                            x = rnd.Next(((a / d) + 1), 100);
                            b = x - (a / d);
                            PLACEHOLDER = Convert.ToString(a) + "÷(x-" + Convert.ToString(b) + ")=" + Convert.ToString(d);
                            if (b == 0)
                            {
                                PLACEHOLDER = Convert.ToString(a) + "÷x" + "=" + Convert.ToString(d);
                            }
                            listBox1.Items.Add(PLACEHOLDER);
                            pls2 = Convert.ToString(x);
                            listBox2.Items.Add(pls2);
                        }
                        if (znaq1 == 4 && znaq2 == 3)
                        {
                            a = rnd.Next(1, 100);
                            b = rnd.Next(1, 100);
                            x = rnd.Next(1, 100);

                            divid = Convert.ToDouble(b) / Convert.ToDouble(x);



                            while (Convert.ToDouble(divid % 1) != 0)
                            {
                                b = rnd.Next(1, 100);
                                x = rnd.Next(1, 100);
                                divid = Convert.ToDouble(b) / Convert.ToDouble(x);
                            }


                            d = a * (b / x);
                            PLACEHOLDER = Convert.ToString(a) + "÷(x÷" + Convert.ToString(b) + ")=" + Convert.ToString(d);
                            if (b == 1)
                            {
                                PLACEHOLDER = Convert.ToString(a) + "÷x" + "=" + Convert.ToString(d);
                            }
                            listBox1.Items.Add(PLACEHOLDER);
                            pls2 = Convert.ToString(x);
                            listBox2.Items.Add(pls2);
                        }
                    }
                    if(znaqs == 3)
                    {
                        znaq1 = rnd.Next(3, 5);
                        znaq2 = rnd.Next(1, 4);
                        znaq3 = rnd.Next(1, 3);
                        if (znaq1 == 3 && znaq2 == 1 && znaq3 == 1)
                        {
                            a = rnd.Next(1, 100);
                            x = rnd.Next(1, 100);
                            b = rnd.Next(0, 100);
                            c = rnd.Next(1, 100);
                            d = a * (x + b) + c;
                            while (d > 999)
                            {
                                x = rnd.Next(1, 100);
                                b = rnd.Next(0, 100);
                                c = rnd.Next(1, 100);
                                d = a * (x + b) + c;
                            }
                            PLACEHOLDER = Convert.ToString(a) + "(x+" + Convert.ToString(b) + ")" + "+" + Convert.ToString(c) + "=" + Convert.ToString(d);
                            if (b == 0)
                            {
                                PLACEHOLDER = Convert.ToString(a) + "x+" + Convert.ToString(c) + "=" + Convert.ToString(d);
                            }
                            listBox1.Items.Add(PLACEHOLDER);
                            pls2 = Convert.ToString(x);
                            listBox2.Items.Add(pls2);
                        }
                        if (znaq1 == 3 && znaq2 == 2 && znaq3 == 1)
                        {
                            a = rnd.Next(1, 100);
                            x = rnd.Next(1, 100);
                            b = rnd.Next(0, x);
                            c = rnd.Next(1, 100);
                            d = a * (x - b) + c;
                            while (d > 999)
                            {
                                x = rnd.Next(1, 100);
                                b = rnd.Next(0, x);
                                c = rnd.Next(1, 100);
                                d = a * (x - b) + c;
                            }
                            PLACEHOLDER = Convert.ToString(a) + "(x-" + Convert.ToString(b) + ")" + "+" + Convert.ToString(c) + "=" + Convert.ToString(d);
                            if (b == 0)
                            {
                                PLACEHOLDER = Convert.ToString(a) + "x+" + Convert.ToString(c) + "=" + Convert.ToString(d);
                            }
                            listBox1.Items.Add(PLACEHOLDER);
                            pls2 = Convert.ToString(x);
                            listBox2.Items.Add(pls2);

                        }
                        if (znaq1 == 3 && znaq2 == 3 && znaq3 == 1)
                        {
                            a = rnd.Next(1, 100);
                            x = rnd.Next(1, 100);
                            b = rnd.Next(1, 100);
                            c = rnd.Next(1, 100);
                            if (b == a * x)
                            {
                                b = rnd.Next(1, 100);
                            }
                            divid = Convert.ToDouble(a * x) / Convert.ToDouble(b);



                            while (Convert.ToDouble(divid % 1) != 0)
                            {
                                x = rnd.Next(1, 100);
                                b = rnd.Next(1, 100);
                                divid = Convert.ToDouble(a * x) / Convert.ToDouble(b);
                            }


                            d = a * (x / b) + c;
                            PLACEHOLDER = Convert.ToString(a) + "(x÷" + Convert.ToString(b) + ")" + "+" + Convert.ToString(c) + "=" + Convert.ToString(d);
                            if (b == 1)
                            {
                                PLACEHOLDER = Convert.ToString(a) + "x+" + Convert.ToString(c) + "=" + Convert.ToString(d);
                            }
                            listBox1.Items.Add(PLACEHOLDER);
                            pls2 = Convert.ToString(x);
                            listBox2.Items.Add(pls2);
                        }
                        if (znaq1 == 4 && znaq2 == 1 && znaq3 == 1)
                        {
                            d = rnd.Next(1, 100);
                            c = rnd.Next(1, d);
                            a = rnd.Next(1, 100);
                            divid = Convert.ToDouble(a) / Convert.ToDouble(d - c);
                            while (Convert.ToDouble(divid % 1) != 0)
                            {

                                d = rnd.Next(1, 100);
                                c = rnd.Next(1, d);
                                a = rnd.Next(1, 100);


                                divid = Convert.ToDouble(a) / Convert.ToDouble(d - c);
                            }

                            x = rnd.Next(1, (a / (d - c)));
                            b = (a / (d - c)) - x;
                            PLACEHOLDER = Convert.ToString(a) + "÷(x+" + Convert.ToString(b) + ")" + "+" + Convert.ToString(c) + "=" + Convert.ToString(d);
                            if (b == 0)
                            {
                                PLACEHOLDER = Convert.ToString(a) + "÷x+" + Convert.ToString(c) + "=" + Convert.ToString(d);
                            }
                            listBox1.Items.Add(PLACEHOLDER);
                            pls2 = Convert.ToString(x);
                            listBox2.Items.Add(pls2);
                        }
                        if (znaq1 == 4 && znaq2 == 2 && znaq3 == 1)
                        {
                            d = rnd.Next(1, 100);
                            a = rnd.Next(1, 100);
                            c = rnd.Next(1, d);

                            divid = Convert.ToDouble(a) / Convert.ToDouble(d - c);
                            while (Convert.ToDouble(divid % 1) != 0)
                            {

                                a = rnd.Next(1, 100);
                                c = rnd.Next(1, d);
                                d = rnd.Next(1, 100);
                                divid = Convert.ToDouble(a) / Convert.ToDouble(d - c);
                            }

                            x = rnd.Next(((a / (d - c)) + 1), 100);
                            b = x - (a / (d - c));
                            PLACEHOLDER = Convert.ToString(a) + "÷(x-" + Convert.ToString(b) + ")" + "+" + Convert.ToString(c) + "=" + Convert.ToString(d);
                            if (b == 0)
                            {
                                PLACEHOLDER = Convert.ToString(a) + "÷x+" + Convert.ToString(c) + "=" + Convert.ToString(d);
                            }
                            listBox1.Items.Add(PLACEHOLDER);
                            pls2 = Convert.ToString(x);
                            listBox2.Items.Add(pls2);
                        }
                        if (znaq1 == 4 && znaq2 == 3 && znaq3 == 1)
                        {
                            a = rnd.Next(1, 100);
                            b = rnd.Next(1, 100);
                            x = rnd.Next(1, 100);

                            divid = Convert.ToDouble(b) / Convert.ToDouble(x);



                            while (Convert.ToDouble(divid % 1) != 0)
                            {
                                b = rnd.Next(1, 100);
                                x = rnd.Next(1, 100);
                                divid = Convert.ToDouble(b) / Convert.ToDouble(x);
                            }
                            c = rnd.Next(1, 100);

                            d = a * (b / x) + c;
                            PLACEHOLDER = Convert.ToString(a) + "÷(x÷" + Convert.ToString(b) + ")" + "+" + Convert.ToString(c) + "=" + Convert.ToString(d);
                            if (b == 1)
                            {
                                PLACEHOLDER = Convert.ToString(a) + "÷x+" + Convert.ToString(c) + "=" + Convert.ToString(d);
                            }
                            listBox1.Items.Add(PLACEHOLDER);
                            pls2 = Convert.ToString(x);
                            listBox2.Items.Add(pls2);
                        }
                        if (znaq1 == 3 && znaq2 == 1 && znaq3 == 2)
                        {
                            a = rnd.Next(1, 100);
                            x = rnd.Next(1, 100);
                            b = rnd.Next(0, 100);
                            c = rnd.Next(1, (a * (x + b)));
                            d = a * (x + b) - c;
                            while (d > 999)
                            {
                                x = rnd.Next(1, 100);
                                b = rnd.Next(0, 100);
                                c = rnd.Next(1, (a * (x + b)));
                                d = a * (x + b) - c;
                            }
                            PLACEHOLDER = Convert.ToString(a) + "(x+" + Convert.ToString(b) + ")" + "-" + Convert.ToString(c) + "=" + Convert.ToString(d);
                            if (b == 0)
                            {
                                PLACEHOLDER = Convert.ToString(a) + "x-" + Convert.ToString(c) + "=" + Convert.ToString(d);
                            }
                            listBox1.Items.Add(PLACEHOLDER);
                            pls2 = Convert.ToString(x);
                            listBox2.Items.Add(pls2);
                        }
                        if (znaq1 == 3 && znaq2 == 2 && znaq3 == 2)
                        {
                            a = rnd.Next(1, 100);
                            x = rnd.Next(1, 100);
                            b = rnd.Next(0, x);
                            c = rnd.Next(1, (a * (x - b)));
                            d = a * (x - b) - c;
                            while (d > 999)
                            {
                                x = rnd.Next(1, 100);
                                b = rnd.Next(0, x);
                                c = rnd.Next(1, (a * (x - b)));
                                d = a * (x - b) - c;
                            }
                            PLACEHOLDER = Convert.ToString(a) + "(x-" + Convert.ToString(b) + ")" + "-" + Convert.ToString(c) + "=" + Convert.ToString(d);
                            if (b == 0)
                            {
                                PLACEHOLDER = Convert.ToString(a) + "x-" + Convert.ToString(c) + "=" + Convert.ToString(d);
                            }
                            listBox1.Items.Add(PLACEHOLDER);
                            pls2 = Convert.ToString(x);
                            listBox2.Items.Add(pls2);

                        }
                        if (znaq1 == 3 && znaq2 == 3 && znaq3 == 2)
                        {
                            a = rnd.Next(1, 100);
                            x = rnd.Next(1, 100);
                            b = rnd.Next(1, 100);

                            if (b == a * x)
                            {
                                b = rnd.Next(1, 100);
                            }
                            divid = Convert.ToDouble(a * x) / Convert.ToDouble(b);



                            while (Convert.ToDouble(divid % 1) != 0)
                            {
                                x = rnd.Next(1, 100);
                                b = rnd.Next(1, 100);
                                divid = Convert.ToDouble(a * x) / Convert.ToDouble(b);
                            }


                            c = rnd.Next(0, (a * (x / b)));
                            d = a * (x / b) - c;
                            PLACEHOLDER = Convert.ToString(a) + "(x÷" + Convert.ToString(b) + ")" + "-" + Convert.ToString(c) + "=" + Convert.ToString(d);
                            if (b == 1)
                            {
                                PLACEHOLDER = Convert.ToString(a) + "x-" + Convert.ToString(c) + "=" + Convert.ToString(d);
                            }
                            listBox1.Items.Add(PLACEHOLDER);
                            pls2 = Convert.ToString(x);
                            listBox2.Items.Add(pls2);
                        }
                        if (znaq1 == 4 && znaq2 == 1 && znaq3 == 2)
                        {
                            d = rnd.Next(1, 100);
                            c = rnd.Next(1, 100);
                            a = rnd.Next(1, 100);
                            divid = Convert.ToDouble(a) / Convert.ToDouble(d + c);
                            while (Convert.ToDouble(divid % 1) != 0)
                            {

                                d = rnd.Next(1, 100);
                                c = rnd.Next(1, 100);
                                a = rnd.Next(1, 100);


                                divid = Convert.ToDouble(a) / Convert.ToDouble(d + c);
                            }

                            x = rnd.Next(1, (a / (d + c)));
                            b = (a / (d + c)) - x;
                            PLACEHOLDER = Convert.ToString(a) + "÷(x+" + Convert.ToString(b) + ")" + "-" + Convert.ToString(c) + "=" + Convert.ToString(d);
                            if (b == 0)
                            {
                                PLACEHOLDER = Convert.ToString(a) + "÷x-" + Convert.ToString(c) + "=" + Convert.ToString(d);
                            }
                            listBox1.Items.Add(PLACEHOLDER);
                            pls2 = Convert.ToString(x);
                            listBox2.Items.Add(pls2);
                        }
                        if (znaq1 == 4 && znaq2 == 2 && znaq3 == 1)
                        {
                            d = rnd.Next(1, 100);
                            a = rnd.Next(1, 100);
                            c = rnd.Next(1, 100);

                            divid = Convert.ToDouble(a) / Convert.ToDouble(d + c);
                            while (Convert.ToDouble(divid % 1) != 0)
                            {

                                a = rnd.Next(1, 100);
                                c = rnd.Next(1, 100);
                                d = rnd.Next(1, 100);
                                divid = Convert.ToDouble(a) / Convert.ToDouble(d + c);
                            }

                            x = rnd.Next(((a / (d + c)) + 1), 100);
                            b = x - (a / (d + c));
                            PLACEHOLDER = Convert.ToString(a) + "÷(x-" + Convert.ToString(b) + ")" + "-" + Convert.ToString(c) + "=" + Convert.ToString(d);
                            if (b == 0)
                            {
                                PLACEHOLDER = Convert.ToString(a) + "÷x-" + Convert.ToString(c) + "=" + Convert.ToString(d);
                            }
                            listBox1.Items.Add(PLACEHOLDER);
                            pls2 = Convert.ToString(x);
                            listBox2.Items.Add(pls2);
                        }
                        if (znaq1 == 4 && znaq2 == 3 && znaq3 == 2)
                        {
                            a = rnd.Next(1, 100);
                            b = rnd.Next(1, 100);
                            x = rnd.Next(1, 100);

                            divid = Convert.ToDouble(b) / Convert.ToDouble(x);



                            while (Convert.ToDouble(divid % 1) != 0)
                            {
                                b = rnd.Next(1, 100);
                                x = rnd.Next(1, 100);
                                divid = Convert.ToDouble(b) / Convert.ToDouble(x);
                            }
                            c = rnd.Next(1, (a * (b / x)));

                            d = a * (b / x) - c;
                            PLACEHOLDER = Convert.ToString(a) + "÷(x÷" + Convert.ToString(b) + ")" + "-" + Convert.ToString(c) + "=" + Convert.ToString(d);
                            if (b == 1)
                            {
                                PLACEHOLDER = Convert.ToString(a) + "÷x-" + Convert.ToString(c) + "=" + Convert.ToString(d);
                            }
                            listBox1.Items.Add(PLACEHOLDER);
                            pls2 = Convert.ToString(x);
                            listBox2.Items.Add(pls2);
                        }
                    }
                }

            }
        }
    
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' || e.KeyChar == '4' || e.KeyChar == '5' || e.KeyChar == '6' || e.KeyChar == '7' || e.KeyChar == '8' || e.KeyChar == '9' || e.KeyChar == '0')
            {
                return;
            }
            if(e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            e.KeyChar = (char)Keys.None;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Controls.Add(listBox2);
        }
    }
    }
