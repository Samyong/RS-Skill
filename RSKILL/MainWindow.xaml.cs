using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

namespace RSKILL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //Declare Variables
            try
            {
                decimal xpRemainder = decimal.Parse(INremainXP.Text), xpPerKill = decimal.Parse(INxpPerKill.Text);
                killsOut.Text = (xpRemainder / xpPerKill).ToString();
            }
            catch
            {

            }
            //calculate
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int atk = int.Parse(inATK.Text), str = int.Parse(inSTR.Text), def = int.Parse(inDEF.Text), con = int.Parse(inCON.Text), mag = int.Parse(inMAG.Text), rng = int.Parse(inRNG.Text), pray = int.Parse(inPRAY.Text), sum = int.Parse(inSUMM.Text);
                player Player = new player(atk,str,def,con,mag,rng,pray,sum);
                double combatlvl = Player.combatLevel();                
                combatLvlOut.Text = combatlvl.ToString();
            }
            catch
            {
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                int atk = int.Parse(inATK.Text), str = int.Parse(inSTR.Text), def = int.Parse(inDEF.Text), con = int.Parse(inCON.Text), mag = int.Parse(inMAG.Text), rng = int.Parse(inRNG.Text), pray = int.Parse(inPRAY.Text), sum = int.Parse(inSUMM.Text);
                player Player = new player(atk,str,def,con,mag,rng,pray,sum);
                Player.Save();
            }
            catch
            {
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                player Player = player.LoadFromFile();
                inATK.Text = Player.atk.ToString();
                inSTR.Text = Player.str.ToString();
                inDEF.Text = Player.def.ToString();
                inCON.Text = Player.con.ToString();
                inMAG.Text = Player.mag.ToString();
                inRNG.Text = Player.rng.ToString();
                inPRAY.Text = Player.pray.ToString();
                inSUMM.Text = Player.sum.ToString();                
            }
            catch
            {
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            inATK.Text = "";
            inSTR.Text = "";
            inDEF.Text = "";
            inCON.Text = "";
            inMAG.Text = "";
            inRNG.Text = "";
            inPRAY.Text = "";
            inSUMM.Text = "";
            combatLvlOut.Text = "";
        }

    }
}
