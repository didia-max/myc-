using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace 梁若为_3
{

    public partial class MainWindow : Window
    {
        bool isRun = true;
        bool isRun2 = true;
        bool isRun3 = true;


        public MainWindow()
        {
            InitializeComponent();
            this.Closing += MainWindow_Closing;
            Thread t = new Thread(Move);
            Thread t2 = new Thread(Move2);
            Thread t3 = new Thread(Move3);
            t.Start();
            t2.Start();
            t3.Start();
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            isRun = false;
            isRun2 = false;
            isRun3 = false;
        }


        void Move()
        {
            while (isRun)
            {
                e1.Dispatcher.Invoke(() =>
                {
                    Random rnd = new Random();
                    e1.SetValue(Canvas.LeftProperty, (double)rnd.Next(0, (int)canvas.Width));
                    e1.SetValue(Canvas.TopProperty, (double)rnd.Next(0, (int)canvas.Height));
                });
               
            Thread.Sleep(600);
            }
        }
        void Move2()
        {

            while (isRun2)
            {
                e2.Dispatcher.Invoke(() =>
                {
                    Random rnd = new Random();
                    e2.SetValue(Canvas.LeftProperty, (double)rnd.Next(0, (int)canvas.Width));
                    e2.SetValue(Canvas.TopProperty, (double)rnd.Next(0, (int)canvas.Height));
                });

                Thread.Sleep(600);
            }
        }
        void Move3()
        {

            while (isRun3)
            {
                e3.Dispatcher.Invoke(() =>
                {
                    Random rnd = new Random();
                    e3.SetValue(Canvas.LeftProperty, (double)rnd.Next(0, (int)canvas.Width));
                    e3.SetValue(Canvas.TopProperty, (double)rnd.Next(0, (int)canvas.Height));
                });

                Thread.Sleep(600);
            }
        }
    }
}
