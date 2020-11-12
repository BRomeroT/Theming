using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinTheming.Views.Themes;

namespace XamarinTheming
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var darkTheme = (sender as Picker).SelectedIndex != 0;
            var mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            if (mergedDictionaries != null)
            {
                mergedDictionaries.Clear();
                if (darkTheme) mergedDictionaries.Add(new DarkTheme());
                else mergedDictionaries.Add(new LightTheme());
            }
        }
    }
}
