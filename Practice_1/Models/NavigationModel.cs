using Practice_1.Windows;
using System;
using Practice_1.Views;

namespace Practice_1.Models
{

    public enum ViewsEnum
    {
        Start,
        Main
    }

    public class NavigationModel
    {
        private ContentWindow _contentWindow;
        private UserInfoModel _userInfoModel;
        private InputView _inputView;
        private MainView _mainView;

        public NavigationModel(ContentWindow contentWindow, UserInfoModel userInfoModel)
        {
            _contentWindow = contentWindow;
            _userInfoModel = userInfoModel;
            _inputView = new InputView(_userInfoModel);
        }

        public void Navigate(ViewsEnum view)
        {
            switch (view)
            {
                case ViewsEnum.Start:
                    _contentWindow.Content = _inputView;
                    break;
                case ViewsEnum.Main:
                    _contentWindow.Content = _mainView;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(view), view, null);
            }
        }


    }
}
