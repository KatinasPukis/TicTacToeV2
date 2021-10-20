using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeV2.Classes;

namespace TicTacToeV2
{
    public partial class Form1 : Form
    {
        public static int set_value_of_X;
        public static int set_value_of_Y;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //patikrinimas ar ne tusti uzpildimai
            if (textbox_x_value.Text != null && textbox_y_value.Text != null && !string.IsNullOrWhiteSpace(textbox_x_value.Text) && !string.IsNullOrWhiteSpace(textbox_y_value.Text))
            {
                //nustatomi parametrai i kintamuosius
                set_value_of_X = (Int32.Parse(textbox_x_value.Text));
                set_value_of_Y = (Int32.Parse(textbox_y_value.Text));
                //patikrinimas kad butu vienodi X ir Y duomenys
                if(set_value_of_X==set_value_of_Y)
                {
                    if(choice_combobox.Text=="X")
                    {
                        lenta lenta = new lenta(set_value_of_X, set_value_of_Y, choice_combobox.Text);
                       
                        this.Hide();
                        lenta.ShowDialog();
                    }
                    if(choice_combobox.Text=="O")
                    {
                        lenta lenta = new lenta(set_value_of_X, set_value_of_Y, choice_combobox.Text);
                        this.Hide();
                        lenta.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Prasome pasirinkit kuris zenkliukas prades pirmas!");
                    }
                }
                else
                {
                    MessageBox.Show("Su "+set_value_of_X + " " +"ir"+ " "+ set_value_of_Y + " " +"negalima sukurti tic tac toe lentos" );
                }
                
            }
            else
            {
                MessageBox.Show("Uzpildykite visus duomenys!");
            }
        }
    }
}
