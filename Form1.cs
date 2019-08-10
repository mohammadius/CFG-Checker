using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrammarChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            resultLabel.Text = string.Empty;
        }

        bool flag = false;
        char lookAhead;
        int i = 0;
        string str;

        private void checkBtn_Click(object sender, EventArgs e)
        {
            resultLabel.Text = string.Empty;

            string[] separator = { "\n" };
            string[] inputs = inputTB.Text.Replace("\r\n", "\n").Replace("\r", string.Empty).Split(separator, StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < inputs.Length; j++)
            {
                flag = false;
                str = inputs[j].Replace(" ", string.Empty);
                i = 0;
                lookAhead = str[i++];
                
                CharCounter(str, '(', out int opc);
                CharCounter(str, ')', out int cpc);
                if (opc != cpc)
                    flag = true;

                if(!flag)
                    E();

                if (!flag)
                {
                    resultLabel.Text += "Input #" + (j + 1) + ": Accept\r\n";
                }
                else
                {
                    resultLabel.Text += "Input #" + (j + 1) + ": Reject\r\n";
                }
            }
        }

        void E()
        {
            if (flag) return;
            T();
            B();
            return;
        }

        void B()
        {
            if (flag) return;
            if ('+' == str[str.Length - 1])
            {
                flag = true;
                return;
            }
            if (lookAhead == '+')
            {
                Next();
                T();
                B();
            }
            return;
        }

        void T()
        {
            if (flag) return;
            F();
            C();
            return;
        }

        void C()
        {
            if (flag) return;
            if ('*' == str[str.Length - 1])
            {
                flag = true;
                return;
            }
            if (lookAhead == '*')
            {
                Next();
                F();
                C();
            }
            return;
        }

        void F()
        {
            if (flag) return;
            if ('(' == str[str.Length - 1] || 'i' == str[str.Length - 1])
            {
                flag = true;
                return;
            }
            if (lookAhead == '(')
            {
                Next();
                E();
                if (lookAhead == ')')
                {
                    Next();
                }
                else
                {
                    flag = true;
                }
            }
            else if (lookAhead == 'i')
            {
                Next();
                if (lookAhead == 'd')
                {
                    Next();
                }
                else
                {
                    flag = true;
                }
            }
            else
            {
                flag = true;
            }
            return;
        }

        void Next()
        {
            if (i < str.Length)
            {
                lookAhead = str[i++];
            }
            return;
        }

        void CharCounter(string str, char ch, out int count)
        {
            count = 0;
            foreach (char c in str)
            {
                if (c.Equals(ch))
                    count++;
            }
        }
    }
}
