using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
        private int GridSize = 3;
        private int MaxSize = 7;
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
            foreach (Button child in GameGrid.Children)
            {
                TextBlock tempBlock = (TextBlock)child.Content;
                tempBlock.Text = "";
            }
            GameStatus.Text = ("0/" + WinCondition);
        }

        private void VeryEasyGame()
        {
            ButtonVeryEasy.IsEnabled = false;
            ButtonEasy.IsEnabled = true;
            ButtonMedium.IsEnabled = true;
            ButtonHard.IsEnabled = true;
            ButtonVeryHard.IsEnabled = true;
            GridSize = 3;
            WinCondition = GridSize*GridSize;
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
            GridSize = 4;
            WinCondition = GridSize * GridSize;
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
            GridSize = 5;
            WinCondition = GridSize * GridSize;
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
            GridSize = 6;
            WinCondition = GridSize * GridSize;
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
            GridSize = 7;
            WinCondition = GridSize * GridSize;
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
        private void ChangeTextBlock(int x, int y)
        {
            Button tempButton = (Button)GameGrid.Children[(y * MaxSize + x)];
            TextBlock tempText = (TextBlock)tempButton.Content;
            if (tempText.Text == "")
                tempText.Text = "x";
            else
                tempText.Text = "";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void Grid_Button_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            UniformGrid tempGrid = (UniformGrid)sender;
            object orgObject = e.OriginalSource;
            int sourceButton = -1;
            int x, y = -1;
            for (int i = 0; i < tempGrid.Children.Count; i++)
            {
                if ((object)tempGrid.Children[i] == orgObject)
                {
                    sourceButton = i;
                    break;
                }
            }
            //y = sourceButton / GridSize;
            //x = sourceButton % GridSize;
            y = sourceButton / MaxSize;
            x = sourceButton % MaxSize;
            ChangeTextBlock(x, y);
            if (x != 0) ChangeTextBlock(x - 1, y);
            if (x != GridSize - 1) ChangeTextBlock(x + 1, y);
            if (y != 0) ChangeTextBlock(x, y - 1);
            if (y != GridSize - 1) ChangeTextBlock(x, y + 1);
            //if (x != 0) ChangeTextBlock(x - 1, y);
            //if (x != MaxSize - 1) ChangeTextBlock(x + 1, y);
            //if (y != 0) ChangeTextBlock(x, y - 1);
            //if (y != MaxSize - 1) ChangeTextBlock(x, y + 1);
            Win();
        }

        private void Win()
        {
            int i = 0;
            foreach (Button tempButton in GameGrid.Children)
            {
                TextBlock tempBlock = (TextBlock)tempButton.Content;
                if (tempBlock.Text == "x") i++;
            }
            GameStatus.Text = i.ToString() + "/"+ WinCondition;
            if (i == WinCondition)
            {
                MessageBox.Show("You won");
                
                
            }
        }
        private void ButtonVeryEasy_Click(object sender, RoutedEventArgs e)
        {
            VeryEasyGame();
        }

        private void ButtonEasy_Click(object sender, RoutedEventArgs e)
        {
            EasyGame();
        }

        private void ButtonMedium_Click(object sender, RoutedEventArgs e)
        {
            MediumGame();
        }

        private void ButtonHard_Click(object sender, RoutedEventArgs e)
        {
            HardGame();
        }

        private void ButtonVeryHard_Click(object sender, RoutedEventArgs e)
        {
            VeryHardGame();
        }
        
    }
}
