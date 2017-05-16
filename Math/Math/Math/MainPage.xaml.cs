using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Math
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void TryButtonClicked(object sender, EventArgs e)
        {
            Navigation.InsertPageBefore(new QuestionOne(), this);
            Navigation.PopAsync();
        }
    }
}
