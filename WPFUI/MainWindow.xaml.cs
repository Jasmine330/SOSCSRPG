﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Engine.ViewModels;
namespace WPFUI;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private GameSession _gameSession;
    public MainWindow()
    {
        InitializeComponent();
        _gameSession = new GameSession();
        DataContext = _gameSession;
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        _gameSession.CurrentPlayer.ExperiencePoints = _gameSession.CurrentPlayer.ExperiencePoints + 10;
    }
}