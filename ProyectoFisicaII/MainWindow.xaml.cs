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

namespace ProyectoFisicaII
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String distancia = " mt(s)";

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void q1_carga_DropDownClosed(object sender, EventArgs e)
        {
            ComboBoxItem selected = (ComboBoxItem)q1_carga.SelectedValue;

            
            if (selected.Content.Equals("Positivo"))
            {
                q1_img.Source = new BitmapImage(new Uri("Content/assets/images/positiveChargeIcon.png", UriKind.Relative));
            }else
            {
                q1_img.Source = new BitmapImage(new Uri("Content/assets/images/negativeChargeIcon.png", UriKind.Relative));
            }
        }

        private void q2_carga_DropDownClosed(object sender, EventArgs e)
        {
            ComboBoxItem selected = (ComboBoxItem)q2_carga.SelectedValue;


            if (selected.Content.Equals("Positivo"))
            {
                q2_img.Source = new BitmapImage(new Uri("Content/assets/images/positiveChargeIcon.png", UriKind.Relative));
            }
            else
            {
                q2_img.Source = new BitmapImage(new Uri("Content/assets/images/negativeChargeIcon.png", UriKind.Relative));
            }

        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {

        }

        private void distanciaQ2QPrueba_TextChanged(object sender, TextChangedEventArgs e)
        {
            int newVal = 0;
            bool val = Int32.TryParse(distanciaQ2QPrueba.Text.ToString(), out newVal);

            distancia_q2_qprueba.Content = newVal + distancia;
            distanciaQ2QPrueba.Text = newVal.ToString();
        }

        private void distanciaQ1Q2_TextChanged(object sender, TextChangedEventArgs e)
        {
            int newVal = 0;
            bool val = Int32.TryParse(distanciaQ1Q2.Text.ToString(), out newVal);

            distancia_q1_q2.Content = newVal + distancia;
            distanciaQ1Q2.Text = newVal.ToString();
        }

        private void distanciaQ1QPrueba_TextChanged(object sender, TextChangedEventArgs e)
        {
            int newVal = 0;
            bool val = Int32.TryParse(distanciaQ1QPrueba.Text.ToString(), out newVal);
            
            distancia_q1_qprueba.Content = newVal + distancia;
            distanciaQ1QPrueba.Text = newVal.ToString();
        }

        private void unidadDistancia_DropDownClosed(object sender, EventArgs e)
        {
            ComboBoxItem selected = (ComboBoxItem)unidadDistancia.SelectedValue;


            if (selected.Content.Equals("Metros"))
            {
                distancia = " mt(s)";
            }
            else
            {
                distancia = " km(s)";
            }

        }

        private void q1_valor_TextChanged(object sender, TextChangedEventArgs e)
        {
            int newVal = 0;
            bool val = Int32.TryParse(q1_valor.Text.ToString(), out newVal);

            q1_valor.Text = newVal.ToString();

        }

        private void q2_valor_TextChanged(object sender, TextChangedEventArgs e)
        {
            int newVal = 0;
            bool val = Int32.TryParse(q2_valor.Text.ToString(), out newVal);

            q2_valor.Text = newVal.ToString();
        }
    }
}
