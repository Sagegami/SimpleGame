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

namespace SimpleGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int WinCondition = 9;
        Style activeStyle;
        Style inactiveStyle;
        public MainWindow()
        {
            InitializeComponent();
            activeStyle = (Style)this.Resources["StyleActive"];
            inactiveStyle = (Style)this.Resources["StyleInactive"];
            InitializeGame();
        }
        private void InitializeGame()
        {
            VeryEasyGame();
        }
        private void NewGame()
        {
            //for (int i = 0; i < GameTiles; i++)
            //{
            //TextBlock newText = new TextBlock();
            //newText.Text = ("Big Button " + i);
            //Button newButton = new Button();
            //newButton.Content = newText;
            //GameGrid.Children.Add(newButton);
            //}
            //foreach (Button child in GameGrid.Children)
            //{
            //    //Make an routed eventhandler for the button
            //}
            TextBlock newText = new TextBlock();
            newText.Text = "";
            foreach (var item in collection)
            {
                
            }
        }

        private void VeryEasyGame()
        {
            ButtonVeryEasy.IsEnabled = false;
            ButtonEasy.IsEnabled = true;
            ButtonMedium.IsEnabled = true;
            ButtonHard.IsEnabled = true;
            ButtonVeryHard.IsEnabled = true;
            WinCondition = 9;
            DisableEasy();
            NewGame();
        }
        private void EasyGame()
        {
            ButtonVeryEasy.IsEnabled = true;
            ButtonEasy.IsEnabled = false;
            ButtonMedium.IsEnabled = true;
            ButtonHard.IsEnabled = true;
            ButtonVeryHard.IsEnabled = true;
            WinCondition = 16;
            EnableEasy();
            DisableMedium();
            NewGame();
        }
        private void MediumGame()
        {
            ButtonVeryEasy.IsEnabled = true;
            ButtonEasy.IsEnabled = true;
            ButtonMedium.IsEnabled = false;
            ButtonHard.IsEnabled = true;
            ButtonVeryHard.IsEnabled = true;
            WinCondition = 25;
            EnableMedium();
            DisableHard();
            NewGame();
        }
        private void HardGame()
        {
            ButtonVeryEasy.IsEnabled = true;
            ButtonEasy.IsEnabled = true;
            ButtonMedium.IsEnabled = true;
            ButtonHard.IsEnabled = false;
            ButtonVeryHard.IsEnabled = true;
            WinCondition = 36;
            EnableHard();
            DisableVeryHard();
            NewGame();
        }
        private void VeryHardGame()
        {
            ButtonVeryEasy.IsEnabled = true;
            ButtonEasy.IsEnabled = true;
            ButtonMedium.IsEnabled = true;
            ButtonHard.IsEnabled = true;
            ButtonVeryHard.IsEnabled = false;
            WinCondition = 49;
            EnableVeryHard();
            NewGame();
        }
        private void DisableEasy()
        {
            DisableMedium();
            Button03.Style = inactiveStyle;
            Button13.Style = inactiveStyle;
            Button23.Style = inactiveStyle;
            Button30.Style = inactiveStyle;
            Button31.Style = inactiveStyle;
            Button32.Style = inactiveStyle;
            Button33.Style = inactiveStyle;
        }
        private void DisableMedium()
        {
            DisableHard();
            Button04.Style = inactiveStyle;
            Button14.Style = inactiveStyle;
            Button24.Style = inactiveStyle;
            Button34.Style = inactiveStyle;
            Button40.Style = inactiveStyle;
            Button41.Style = inactiveStyle;
            Button42.Style = inactiveStyle;
            Button43.Style = inactiveStyle;
            Button44.Style = inactiveStyle;
        }
        private void DisableHard()
        {
            DisableVeryHard();
            Button05.Style = inactiveStyle;
            Button15.Style = inactiveStyle;
            Button25.Style = inactiveStyle;
            Button35.Style = inactiveStyle;
            Button45.Style = inactiveStyle;
            Button50.Style = inactiveStyle;
            Button51.Style = inactiveStyle;
            Button52.Style = inactiveStyle;
            Button53.Style = inactiveStyle;
            Button54.Style = inactiveStyle;
            Button55.Style = inactiveStyle;
        }
        private void DisableVeryHard()
        {
            Button06.Style = inactiveStyle;
            Button16.Style = inactiveStyle;
            Button26.Style = inactiveStyle;
            Button36.Style = inactiveStyle;
            Button46.Style = inactiveStyle;
            Button56.Style = inactiveStyle;
            Button60.Style = inactiveStyle;
            Button61.Style = inactiveStyle;
            Button62.Style = inactiveStyle;
            Button63.Style = inactiveStyle;
            Button64.Style = inactiveStyle;
            Button65.Style = inactiveStyle;
            Button66.Style = inactiveStyle;
        }
        private void EnableEasy()
        {
            Button03.Style = activeStyle;
            Button13.Style = activeStyle;
            Button23.Style = activeStyle;
            Button30.Style = activeStyle;
            Button31.Style = activeStyle;
            Button32.Style = activeStyle;
            Button33.Style = activeStyle;
        }
        private void EnableMedium()
        {
            EnableEasy();
            Button04.Style = activeStyle;
            Button14.Style = activeStyle;
            Button24.Style = activeStyle;
            Button34.Style = activeStyle;
            Button40.Style = activeStyle;
            Button41.Style = activeStyle;
            Button42.Style = activeStyle;
            Button43.Style = activeStyle;
            Button44.Style = activeStyle;
        }
        private void EnableHard()
        {
            EnableMedium();
            Button05.Style = activeStyle;
            Button15.Style = activeStyle;
            Button25.Style = activeStyle;
            Button35.Style = activeStyle;
            Button45.Style = activeStyle;
            Button50.Style = activeStyle;
            Button51.Style = activeStyle;
            Button52.Style = activeStyle;
            Button53.Style = activeStyle;
            Button54.Style = activeStyle;
            Button55.Style = activeStyle;
        }
        private void EnableVeryHard()
        {
            EnableHard();
            Button06.Style = activeStyle;
            Button16.Style = activeStyle;
            Button26.Style = activeStyle;
            Button36.Style = activeStyle;
            Button46.Style = activeStyle;
            Button56.Style = activeStyle;
            Button60.Style = activeStyle;
            Button61.Style = activeStyle;
            Button62.Style = activeStyle;
            Button63.Style = activeStyle;
            Button64.Style = activeStyle;
            Button65.Style = activeStyle;
            Button66.Style = activeStyle;
        }
    }
}
