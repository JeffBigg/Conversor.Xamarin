using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void ConvertirPeso(object sender, EventArgs e)
        {
            if (double.TryParse(pesoEntry.Text, out double kg))
            {
                // Realiza la conversión de kg a libras (1 kg = 2.20462 libras)
                double libras = kg * 2.20462;
                resultadoPesoLabel.Text = $"Conversion de {kg} Kilos a Libras es: {libras:F2}";
                pesoEntry.Text = string.Empty;
            }
            else
            {
                resultadoPesoLabel.Text = "Ingrese un valor válido en kg.";
            }
        }
        private void ConvertirVolumen(object sender, EventArgs e)
        {
            if (double.TryParse(volumenEntry.Text, out double litros))
            {
                // Realiza la conversión de litros a galones (1 litro = 0.264172 galones)
                double galones = litros * 0.264172;
                resultadoVolumenLabel.Text = $"Conversion de {litros} litros a Galones es: {galones:F2}";
                volumenEntry.Text = string.Empty;
            }
            else
            {
                resultadoVolumenLabel.Text = "Ingrese un valor válido en litros.";
            }
        }

        // Método para convertir temperatura de grados Celsius a grados Fahrenheit
        private void ConvertirTemperatura(object sender, EventArgs e)
        {
            if (double.TryParse(temperaturaEntry.Text, out double celsius))
            {
                // Realiza la conversión de grados Celsius a grados Fahrenheit
                double fahrenheit = (celsius * 9 / 5) + 32;
                resultadoTemperaturaLabel.Text = $"Conversion de {celsius} Celsius a Farenheid es: {fahrenheit:F2}";
                temperaturaEntry.Text = string.Empty;
            }
            else
            {
                resultadoTemperaturaLabel.Text = "Ingrese un valor válido en °C.";
            }
        }
    }
}
