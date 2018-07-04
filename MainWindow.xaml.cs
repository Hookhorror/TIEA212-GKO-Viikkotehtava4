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

namespace Viikkotehtava4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Alustaa File/Uusi -painikkeen
            CommandBinding newCmdBinding = new CommandBinding(
                ApplicationCommands.New,
                NewExecute,
                NewCanExecute);
            this.CommandBindings.Add(newCmdBinding);
        }


        /// <summary>
        /// Luo ja lisää uudet treenin näyttöön
        /// </summary>
        public void LisaaTreeni()
        {
            Treeni uusi = new Viikkotehtava4.Treeni();
            this.WrapPanelTreenit.Children.Add(uusi);
        }


        /// <summary>
        /// Käsittelee uusi -napin painalluksen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void NewExecute(object sender, ExecutedRoutedEventArgs e)
        {
            LisaaTreeni();
            // place Command execute logic here
        }


        /// <summary>
        /// Tarkistaa voidaanko uusi-toimintoa suorittaa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void NewCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            // place whatever logic you want to insure that the execute is valid for your scenario
            e.CanExecute = true;
        }


    }
}
