using System.ComponentModel;
using Xamarin.Forms;
using System;

namespace JdCalc
{
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void CalcBtnClickedAsync(object sender, EventArgs e)
        {
            string loanType = "";
            switch (LoanType.SelectedItem.ToString())
            {
                case "FHA":
                    loanType = "FHA";
                    break;
                case "VA":
                    loanType = "VA";
                    break;
                case "Conventional":
                    loanType = "Conventional";
                    break;
            }

            await Application.Current.MainPage.DisplayAlert("", loanType, "Ok");
        }
    }
}
