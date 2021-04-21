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

namespace App8
{
    /*
    Создайте программу секундомер. Требуется выводить показания
    секундомера в окне. Окно имеет кнопки запуска, останова и сброса секундомера. 
    Для реализации секундомера используйте события. Нельзя использовать компонент Timer в WindowsForm.
    https://www.youtube.com/watch?v=6vP9FsWJ2IM

     */
    public partial class Form1 : Form
    {
        private int endSecondTime { get; set; }
        private static int TimerStart { get; set; }
        private Thread myThread;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        private void StartTimer_Click(object sender, EventArgs e)
        {
            TimerStart = 1;
            if (myThread == null || TimerStart == 1)
            {
                myThread = new Thread(new ThreadStart(
                () =>
                {
                    int  SecondTime = endSecondTime;
                    while (TimerStart == 1)
                    {
                        Thread.Sleep(1000);
                        SecondTime++;

                        Label1Set($"Значение секундомера: {SecondTime} сек.");
                    }
                    if (TimerStart == 2)
                    {
                        Label1Set($"Секунодомер приостановлен на значении: {SecondTime} сек.");
                        endSecondTime = SecondTime;
                    }
                    if (TimerStart == 3)
                    {
                        Label1Set($"Секунодомер остановлен на значении: {SecondTime} сек.");
                        endSecondTime = 0;
                    }
                }));
                myThread.IsBackground = false;
                myThread.Start();
            }
        }

        private void Label1Set(string textLabel) 
        {
            this.label1.BeginInvoke((MethodInvoker)(() =>
                            this.label1.Text = textLabel));
        }
        private void PauseTimer_Click(object sender, EventArgs e)
        {
            TimerStart = 2;
        }

        private void StopTimer_Click(object sender, EventArgs e)
        {
            TimerStart = 3;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            TimerStart = 3;
        }
    }
}
