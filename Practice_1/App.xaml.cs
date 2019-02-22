using System.Windows;
using Practice_1.Managers;
using Practice_1.Models;
using Practice_1.Windows;

namespace Practice_1
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            UserInfoModel userInfoModel = new UserInfoModel();
            ContentWindow contentWindow = new ContentWindow();
            NavigationModel navigationModel = new NavigationModel(contentWindow, userInfoModel);
            NavigationManager.Instance.Initialize(navigationModel);
            contentWindow.Show();
            navigationModel.Navigate(ViewsEnum.Start);
        }
    }
}
