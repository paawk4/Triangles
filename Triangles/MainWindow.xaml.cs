using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Triangles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int VAB1, VBC1, VCA1;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                TextBlock textBlock = new TextBlock();
                textBlock.Text = Type.Text;
                VAB1 = Convert.ToInt32(AB_input.Text);
                VBC1 = Convert.ToInt32(BC_input.Text);
                VCA1 = Convert.ToInt32(CA_input.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Проверьте введенные данные");
            }
            if (VAB1 == VBC1 && VBC1 == VCA1 && VCA1 == VAB1)
            {
                if (VAB1 <= 0 || VBC1 <= 0 || VCA1 <= 0)
                {
                    MessageBox.Show("Треугольника не существует");
                    MessageBox.Show("Введите положительное целочисленное значение не равное 0");
                }
                else if (VAB1 + VBC1 <= VCA1 || VAB1 + VCA1 <= VBC1 || VBC1 + VCA1 <= VAB1)
                {
                    MessageBox.Show("Треугольника не существует");
                    MessageBox.Show("Cумма длин каждых двух сторон должна быть больше длины третьей стороны");
                }
                else
                {
                    Type.Text = "Равносторонний";
                }
            }
            else if (VAB1 == VBC1 || VBC1 == VCA1 || VCA1 == VAB1)
            {
                if (VAB1 <= 0 || VBC1 <= 0 || VCA1 <= 0)
                {
                    MessageBox.Show("Треугольника не существует");
                    MessageBox.Show("Введите положительное целочисленное значение не равное 0");
                }
                else if (VAB1 + VBC1 <= VCA1 || VAB1 + VCA1 <= VBC1 || VBC1 + VCA1 <= VAB1)
                {
                    MessageBox.Show("Треугольника не существует");
                    MessageBox.Show("Cумма длин каждых двух сторон должна быть больше длины третьей стороны");
                }
                else
                {
                    Type.Text = "Равнобедренный";
                }
            }
            else if (VAB1 != VBC1 && VBC1 != VCA1 && VCA1 != VAB1)
            {
                if (VAB1 <= 0 || VBC1 <= 0 || VCA1 <= 0)
                {
                    MessageBox.Show("Треугольника не существует");
                    MessageBox.Show("Введите положительное целочисленное значение не равное 0");
                }
                else if (VAB1 + VBC1 <= VCA1 || VAB1 + VCA1 <= VBC1 || VBC1 + VCA1 <= VAB1)
                {
                    MessageBox.Show("Треугольника не существует");
                    MessageBox.Show("Cумма длин каждых двух сторон должна быть больше длины третьей стороны");
                }
                else
                {
                    Type.Text = "Разносторонний";
                }
            }
        }
    }
}
