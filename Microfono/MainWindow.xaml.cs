﻿using System;
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

using NAudio;
using NAudio.Wave;
using NAudio.Dsp;

namespace Microfono
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WaveIn waveIn; // Conexion con Microfono
        WaveFormat formato; //Fornato de audio

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, RoutedEventArgs e)
        {
            //Inicializar la conexión
            waveIn = new WaveIn();

            //Establecer el formato
            waveIn.WaveFormat = new WaveFormat(44100,16,1);
            formato = waveIn.WaveFormat;

            //Duración del Buffer
            waveIn.BufferMilliseconds = 500;

            //Con que funcion respondemos cuando se llena el buffer
            waveIn.DataAvailable += WaveIn_DataAvailable;
            waveIn.StartRecording();

        }

        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
