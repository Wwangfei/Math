using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Math
{
    public partial class QuestionTwo : ContentPage
    {
        public QuestionTwo()
        {
            InitializeComponent();
        }

        private void CheckClicked(object sender, EventArgs e)
        {

        }

        private void NextClicked(object sender, EventArgs e)
        {
            Navigation.InsertPageBefore(new QuestionThree(), this);
            Navigation.PopAsync();
        }
    }
}
