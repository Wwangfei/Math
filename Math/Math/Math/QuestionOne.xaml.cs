using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Math
{
    public partial class QuestionOne : ContentPage
    {
        public QuestionOne()
        {
            InitializeComponent();
        }

        private void CheckButtonClicked(object sender, EventArgs e)
        {

        }

        private void NextButtonClicked(object sender, EventArgs e)
        {
            Navigation.InsertPageBefore(new QuestionTwo(), this);
            Navigation.PopAsync();
        }
    }
}
