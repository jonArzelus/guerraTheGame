using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guerra
{
    public partial class Form1 : Form
    {
        //tiempos
        int segundos;
        int minutos;
        int horas;
        int fase;

        //manos
        List<Carta> mazo;
        List<Carta> pilaA;
        List<Carta> pilaB;
        List<Carta> mazoA;
        List<Carta> mazoB;
        List<Carta> mesaA;
        List<Carta> mesaB;

        //contadores

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            btnPlay.Enabled = false;
            btnPause.Enabled = true;
            btnStop.Enabled = true;
            lstLog.Items.Add("Tiempo iniciado");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;
            //procesar la fase
            if (fase == 0)
            {
                if (mazoA.Count == 0)
                {
                    if (pilaA.Count > 0)
                    {
                        mazoA.AddRange(pilaA);
                        mazoA.Shuffle();
                        pilaA.Clear();
                    }
                    else
                    {
                        lstLog.Items.Add("A se ha quedado sin cartas");
                        lstLog.Items.Add("Gana A LA PARTIDA");
                        btnPlay.Enabled = false;
                        btnPause.Enabled = false;
                        btnStop.Enabled = true;
                        timer1.Enabled = false;
                    }
                }
                if (mazoA.Count > 0)
                {
                    mesaA.Add(mazoA.ElementAt(mazoA.Count - 1));
                    mazoA.RemoveAt(mazoA.Count - 1);
                    if (mazoA.Count == 0)
                        imgMazoA.Image = null;
                    else
                        imgMazoA.Image = Guerra.Properties.Resources.back;
                    imgA.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(mesaA.ElementAt(mesaA.Count - 1).img);
                }
                if (mazoB.Count == 0)
                {
                    if (pilaB.Count > 0)
                    {
                        mazoB.AddRange(pilaB);
                        mazoB.Shuffle();
                        pilaB.Clear();
                    }
                    else
                    {
                        lstLog.Items.Add("B se ha quedado sin cartas");
                        lstLog.Items.Add("Gana B LA PARTIDA");
                        btnPlay.Enabled = false;
                        btnPause.Enabled = false;
                        btnStop.Enabled = true;
                        timer1.Enabled = false;
                    }
                }
                if (mazoB.Count>0)
                {
                    mesaB.Add(mazoB.ElementAt(mazoB.Count - 1));
                    mazoB.RemoveAt(mazoB.Count - 1);
                    if (mazoB.Count == 0)
                        imgMazoB.Image = null;
                    else
                        imgMazoB.Image = Guerra.Properties.Resources.back;
                    imgB.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(mesaB.ElementAt(mesaB.Count - 1).img);
                }
                fase++;
                lstLog.Items.Add("Cartas echadas");
            }
            else if (fase == 1)
            {
                if (mesaA.ElementAt(mesaA.Count - 1).valor > mesaB.ElementAt(mesaB.Count - 1).valor)
                {
                    lstLog.Items.Add("Gana A");
                    pilaA.AddRange(mesaA);
                    pilaA.AddRange(mesaB);
                    imgA.Image = null;
                    imgB.Image = null;
                    mesaA.Clear();
                    mesaB.Clear();
                    if (mesaB.Count == 0)
                    {
                        lstLog.Items.Add("B se ha quedado SIN CARTAS");
                    }
                }
                else if (mesaA.ElementAt(mesaA.Count - 1).valor < mesaB.ElementAt(mesaB.Count - 1).valor)
                {
                    lstLog.Items.Add("Gana B");
                    pilaB.AddRange(mesaA);
                    pilaB.AddRange(mesaB);
                    /*for (int i = 0; i < mesaA.Count; i++)
                        pilaB.Add(mesaA.ElementAt(i));
                    mesaA.Clear();
                    imgA.Image.Dispose();
                    for (int i = 0; i < mesaB.Count; i++)
                        pilaB.Add(mesaB.ElementAt(i));
                    mesaB.Clear();
                    imgB.Image.Dispose();*/
                    imgA.Image = null;
                    imgB.Image = null;
                    mesaA.Clear();
                    mesaB.Clear();
                    if (mesaB.Count == 0)
                    {
                        lstLog.Items.Add("A se ha quedado SIN CARTAS");
                    }
                }
                else 
                {
                    fase = 0;
                    lstLog.Items.Add("Guerra"); //por mejorar
                }
                fase = 0;
            }

            //actualizar los contadores e imágenes
            try
            {
                if (pilaA.Count > 0)
                    imgPilaA.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(pilaA.ElementAt(pilaA.Count - 1).img);
                else
                    imgPilaA.Image = null;
                if (pilaB.Count > 0)
                    imgPilaB.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(pilaB.ElementAt(pilaB.Count - 1).img);
                else
                    imgPilaB.Image=null;
            }
            catch (Exception ex)
            {
                //none;
            }
            lblMazoA.Text = "Cartas en el mazo: " + mazoA.Count();
            lblMazoB.Text = "Cartas en el mazo: " + mazoB.Count();
            lblPilaA.Text = "Cartas en descarte: " + pilaA.Count();
            lblPilaB.Text = "Cartas en descarte: " + pilaB.Count();

            //poner el tiempo
            if (segundos >= 60)
            {
                segundos = 00;
                minutos++;
            }
            if (minutos >= 60)
            {
                minutos = 00;
                horas++;
            }
            if (horas < 10)
            {
                lblTimer.Text = "0" + horas.ToString() + ":";
            }
            else
            {
                lblTimer.Text = horas.ToString() + ":";
            }
            if (minutos < 10)
            {
                lblTimer.Text += "0"+minutos.ToString() + ":";
            }
            else
            {
                lblTimer.Text += minutos.ToString() + ":";
            }
            if(segundos<10)
            {
                lblTimer.Text += "0" + segundos.ToString();
            }
            else
            {
                lblTimer.Text += segundos.ToString();
            }
        }

        private void scrlTimer_Scroll(object sender, ScrollEventArgs e)
        {
            timer1.Interval = scrlTimer.Value;
            //lstLog.Items.Add("Intervalo del tiempo cambiado a "+scrlTimer.Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnPlay.Enabled = true;
            btnPause.Enabled = false;
            btnStop.Enabled = true;
            timer1.Enabled = false;
            lstLog.Items.Add("Tiempo pausado");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnPlay.Enabled = true;
            btnPause.Enabled = false;
            btnStop.Enabled = false;
            timer1.Enabled = false;
            segundos = 0;
            minutos = 0;
            horas = 0;
            lblTimer.Text = "00:00:00";
            inicializar();
            lstLog.Items.Add("Tiempo reiniciado");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inicializar();
            lstLog.Items.Add("Aplicacion iniciada");
        }

        private void inicializar()
        {
            segundos = 00;
            minutos = 00;
            horas = 00;
            btnPlay.Enabled = true;
            btnPause.Enabled = false;
            btnStop.Enabled = false;
            mazo = Baraja.newBaraja();
            mazo.Shuffle();
            mazoA = new List<Carta>();
            mazoB = new List<Carta>();
            pilaA = new List<Carta>();
            pilaB = new List<Carta>();
            mesaA = new List<Carta>();
            mesaB = new List<Carta>();
            for (int i = 0; i < 48; i++)
            {
                if (i % 2 == 0)
                {
                    mazoA.Add(mazo.ElementAt(i));
                }
                else
                {
                    mazoB.Add(mazo.ElementAt(i));
                }
            }
            imgMazoA.Image = Guerra.Properties.Resources.back;
            imgMazoB.Image = Guerra.Properties.Resources.back;
            lblMazoA.Text = "Cartas en el mazo: " + mazoA.Count();
            lblMazoB.Text = "Cartas en el mazo: " + mazoB.Count();
            lblPilaA.Text = "Cartas en descarte: " + pilaA.Count();
            lblPilaB.Text = "Cartas en descarte: " + pilaB.Count();
            fase = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lstLog.Items.Add("Saliendo...");
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstLog.Items.Clear();
        }
    }

    public static class ThreadSafeRandom
    {
        [ThreadStatic]
        private static Random Local;

        public static Random ThisThreadsRandom
        {
            get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
        }
    }

    static class MyExtensions
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
