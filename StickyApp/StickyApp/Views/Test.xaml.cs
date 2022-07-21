using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StickyApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Test : ContentPage
    {
        public Test()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            scrollmain.PropertyChanged += Scrollmain_PropertyChanged;
            _menucate.SizeChanged += _menucate_SizeChanged;
        }
        double _titleTextTop;
        private void _menucate_SizeChanged(object sender, EventArgs e)
        {
            _menucate.SizeChanged -= _menucate_SizeChanged;
            _titleTextTop = _menucate.Y;
        }

        
        private void Scrollmain_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals(Xamarin.Forms.ScrollView.ScrollYProperty.PropertyName))
            {
                var scrolled = ((Xamarin.Forms.ScrollView)sender).ScrollY;

                if (scrolled < _titleTextTop)
                    _menucate.TranslationY = (0 - scrolled);
                else
                    _menucate.TranslationY = (0 - _titleTextTop);
            }
        }

        private void scrollmain_Scrolled(object sender, ScrolledEventArgs e)
        {
            //Load more other
        }
    }
}