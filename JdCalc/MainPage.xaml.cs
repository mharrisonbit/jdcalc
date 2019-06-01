using System.ComponentModel;
using Xamarin.Forms;
using System;

namespace JdCalc
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
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
            Console.WriteLine(LoanType.SelectedItem);
            switch (LoanType.SelectedItem.ToString())
            {
                case "FHA":
                    loanType = "test";
                    break;
                case "VA":
                    loanType = "test";
                    break;
                case "Conventional":
                    loanType = "test";
                    break;
            }

            await Application.Current.MainPage.DisplayAlert("", loanType, "Ok");
        }
    }
}
