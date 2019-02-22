using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Practice_1.Models;
using Practice_1.ViewModels;

namespace Practice_1.Views
{
    /// <summary>
    /// Логика взаимодействия для InputView.xaml
    /// </summary>
    public partial class InputView : UserControl
    {

        private InputViewModel _inputViewModel;
        public InputView(UserInfoModel userInfoModel)
        {
            InitializeComponent();
            InputViewModel _inputViewModel = new InputViewModel(userInfoModel);
        }
    }
}
