using RealmObjectVM;
using Realms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

namespace RealmObjectVMUWP
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Realm realm;

        public MainViewModel ViewModel { get; set; }

        public MainPage()
        {
            this.InitializeComponent();

            try
            {
                realm = Realm.GetInstance(new RealmConfiguration { ShouldDeleteIfMigrationNeeded = true });
                ViewModel = realm.All<MainViewModel>().FirstOrDefault();
                if (ViewModel == default(MainViewModel))
                {
                    realm.Write(() =>
                    {
                        ViewModel = new MainViewModel();
                        realm.Add(ViewModel);
                    });
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

        ~MainPage()
        {
            try
            {
                this.realm.Dispose();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
    }
}
