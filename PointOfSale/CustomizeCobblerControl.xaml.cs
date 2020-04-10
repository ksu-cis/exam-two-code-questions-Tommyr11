using System;
using System.Collections.Generic;
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
using ExamTwoCodeQuestions.Data;

namespace ExamTwoQuestions.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCobblerControl.xaml
    /// </summary>
    public partial class CustomizeCobblerControl : UserControl
    {
        public CustomizeCobblerControl()
        {
            InitializeComponent();
            SmallRadioButton.Checked += OnSize_Checked;
            MediumRadioButton.Checked += OnSize_Checked;
            LargeRadioButton.Checked += OnSize_Checked;
        }

        private void OnSize_Checked(object sender, RoutedEventArgs args)
        {
            
            FruitFilling s;
            if (DataContext is Cobbler c)
            {
                s = c.Fruit;
                if (sender is RadioButton rb)
                {
                    switch (rb.Tag)
                    {
                        case "c":
                            c.Fruit = FruitFilling.Cherry;
                            
                            break;
                        case "p":
                            c.Fruit = FruitFilling.Peach;
                            
                            break;
                        case "b":
                            c.Fruit = FruitFilling.Blueberry;
                            break;
                        default:
                            throw new NotImplementedException("Size not Avialable");
                    }
                }
            }
        }
    }
}
