using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        Random random = new Random();
        DispatcherTimer enemyTimer = new DispatcherTimer();
        DispatcherTimer targetTimer = new DispatcherTimer();
        bool humanCaptured = false;

        public MainWindow()
        {
            InitializeComponent();

            enemyTimer.Tick += EnemyTimer_Tick;
            enemyTimer.Interval = TimeSpan.FromSeconds(2);

            targetTimer.Tick += TargetTimer_Tick;
            targetTimer.Interval = TimeSpan.FromSeconds(1);
        }

        private void TargetTimer_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 1;
            if (progressBar.Value >= progressBar.Maximum)
                EndTheGame();
        }

        private void EndTheGame()
        {
            if(!PlayArea.Children.Contains(GameOverText))
            {
                enemyTimer.Stop();
                targetTimer.Stop();
                humanCaptured = false;
                StartButton.Visibility = Visibility.Visible;
                PlayArea.Children.Add(GameOverText);
            }
        }

        private void EnemyTimer_Tick(object sender, EventArgs e)
        {
            AddEnemy();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            StartGame();
        }

        private void StartGame()
        {
            humansp.IsHitTestVisible = true;
            humanCaptured = false;
            progressBar.Value = 0;
            StartButton.Visibility = Visibility.Collapsed;
            PlayArea.Children.Clear();
            PlayArea.Children.Add(target);
            PlayArea.Children.Add(humansp);
            enemyTimer.Start();
            targetTimer.Start();
        }

        private void AddEnemy()
        {
            ContentControl enemy = new ContentControl();
            enemy.Template = Resources["EnemyTemplate"] as ControlTemplate;
            AnimateEnemy(enemy, 0, PlayArea.ActualWidth +0, "(Canvas.Left)");
            AnimateEnemy(enemy, random.Next((int)PlayArea.ActualHeight +150),
                random.Next((int)PlayArea.ActualHeight +150), "(Canvas.Top)");
            PlayArea.Children.Add(enemy);

            enemy.MouseEnter += Enemy_MouseEnter;
        }

        private void Enemy_MouseEnter(object sender, MouseEventArgs e)
        {
           if(humanCaptured)
                EndTheGame();
        }

        private void AnimateEnemy(ContentControl enemy, double from, double to, string PropertyToAnimate)
        {
            Storyboard storyboard = new Storyboard() { AutoReverse = true, RepeatBehavior = RepeatBehavior.Forever };
            DoubleAnimation animation = new DoubleAnimation()
            {
                From = from,
                To = to,
                Duration = new Duration(TimeSpan.FromSeconds(random.Next(2, 3)))
            };
            Storyboard.SetTarget(animation, enemy);
            Storyboard.SetTargetProperty(animation, new PropertyPath(PropertyToAnimate));
            storyboard.Children.Add(animation);
            storyboard.Begin();

            }

        private void Humansp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(enemyTimer.IsEnabled)
            {
                humanCaptured = true;
                humansp.IsHitTestVisible = false;
            }
        }

        private void Target_MouseEnter(object sender, MouseEventArgs e)
        {
            if(targetTimer.IsEnabled && humanCaptured)
            {
                progressBar.Value = 0;
                Canvas.SetLeft(target, random.Next(100, (int)PlayArea.ActualWidth - 100));
                Canvas.SetTop(target, random.Next(100, (int)PlayArea.ActualHeight - 100));
                Canvas.SetLeft(humansp, random.Next(100, (int)PlayArea.ActualWidth - 100));
                Canvas.SetTop(humansp, random.Next(100, (int)PlayArea.ActualHeight - 100));
                humanCaptured = false;
                humansp.IsHitTestVisible = true;
            }
        }

        private void PlayArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (humanCaptured)
            { 
                Point pointerPosition = e.GetPosition(null);
                Point relativePosition = grid.TransformToVisual(PlayArea).Transform(pointerPosition);

            if ((Math.Abs(relativePosition.X - Canvas.GetLeft(humansp)) > humansp.ActualWidth * 3)
                || (Math.Abs(relativePosition.Y - Canvas.GetTop(humansp)) > humansp.ActualHeight * 3))
            {
                humanCaptured = false;
                humansp.IsHitTestVisible = true;
            }
            else
            {
                Canvas.SetLeft(humansp, relativePosition.X - humansp.ActualWidth / 2);
                Canvas.SetTop(humansp, relativePosition.Y - humansp.ActualHeight / 2);
            }
        }
        }

        private void PlayArea_MouseLeave(object sender, MouseEventArgs e)
        {
            if (humanCaptured)
                EndTheGame();       
        }
    }
    }

