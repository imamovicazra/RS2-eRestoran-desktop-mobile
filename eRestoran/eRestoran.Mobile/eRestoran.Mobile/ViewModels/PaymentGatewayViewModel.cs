using Prism.Commands;
using Prism.Mvvm;
using Stripe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Acr.UserDialogs;
using eRestoran.Model;
using eRestoran.Mobile.Views;

namespace eRestoran.Mobile.ViewModels
{
    public class PaymentGatewayViewModel : BindableBase
    {
        NarudzbaViewModel model = new NarudzbaViewModel();
        #region Variable

        private CreditCardModel _creditCardModel;
        private TokenService Tokenservice;
        private Token stripeToken;
        private bool _isCarcValid;
        private bool _isTransectionSuccess;
        private string _expMonth;
        private string _expYear;
        private string _title;

        #endregion Variable

        #region Public Property
        private string StripeTestApiKey = "pk_test_51JAIHuAhOmURCANf7yS5pzqL5zGL0Dr0FmP5rFYWioHiIOdHMUVmN2NdpSMHOWnfuWbREJek09JTE6Nl5sJOAknL00KRutWR0Q";
        private string StripeSecretApiKey = "sk_test_51JAIHuAhOmURCANfHgvhmGZgFmA1GG01rkQnC91s1GiPTYaHwMXZkyjDadtDRIGdJhzC0bFdZCVtrpC9yKDGk2Gr00Bku69iHS";
        public string ExpMonth
        {
            get { return _expMonth; }
            set { SetProperty(ref _expMonth, value); }
        }

        public bool IsCarcValid
        {
            get { return _isCarcValid; }
            set { SetProperty(ref _isCarcValid, value); }
        }

        public bool IsTransectionSuccess
        {
            get { return _isTransectionSuccess; }
            set { SetProperty(ref _isTransectionSuccess, value); }
        }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string ExpYear
        {
            get { return _expYear; }
            set { SetProperty(ref _expYear, value); }
        }
        decimal _amount = 0;
        public decimal Amount
        {
            get { return _amount; }
            set { SetProperty(ref _amount, value); }
        }

        public CreditCardModel CreditCardModel
        {
            get { return _creditCardModel; }
            set { SetProperty(ref _creditCardModel, value); }
        }

        #endregion Public Property

        #region Constructor

        public PaymentGatewayViewModel()
        {
            CreditCardModel = new CreditCardModel();
            Title = "Card Details";
        }

        #endregion Constructor

        #region Command

        public DelegateCommand SubmitCommand => new DelegateCommand(async () =>
        {
            CreditCardModel.ExpMonth = Convert.ToInt64(ExpMonth);
            CreditCardModel.ExpYear = Convert.ToInt64(ExpYear);
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            try
            {
                UserDialogs.Instance.ShowLoading("Payment processing..");
                await Task.Run(async () =>
                {

                    var Token = CreateToken();
                    Console.Write("Payment Gateway" + "Token :" + Token);
                    if (Token != null)
                    {
                        IsTransectionSuccess = MakePayment(Token);
                    }
                    else
                    {
                        UserDialogs.Instance.Alert("Bad card credentials", null, "OK");
                    }
                });
            }
            catch (Exception ex)
            {
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Alert(ex.Message, null, "OK");
                Console.Write("Payment Gatway" + ex.Message);

            }

            if (IsTransectionSuccess)
            {
                Console.Write("Payment Gateway" + "Plaćanje uspješno ");
                UserDialogs.Instance.Alert("Transakcija obavljena uspješno!", "Payment success", "OK");
                UserDialogs.Instance.HideLoading();
                model.Load();
                
            }
            else
            {

                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Alert("Došlo je do greške", "Payment failed", "OK");
                Console.Write("Payment Gateway" + "Payment Failure ");
            }


        });

        #endregion Command

        #region Method

        private string CreateToken()
        {
            try
            {
                StripeConfiguration.ApiKey = StripeTestApiKey;
                var service = new ChargeService();
                var Tokenoptions = new TokenCreateOptions
                {
                    Card = new TokenCardOptions
                    {
                        Number = CreditCardModel.Number,
                        ExpYear = CreditCardModel.ExpYear,
                        ExpMonth = CreditCardModel.ExpMonth,
                        Cvc = CreditCardModel.Cvc,
                        Name = "Korisnik Test",
                        AddressLine1 = "Adresa 1",
                        AddressLine2 = "Adresa 2",
                        AddressCity = "Mostar",
                        AddressZip = "88000",
                        AddressState = "HNK",
                        AddressCountry = "Bosnia and Herzegovina",
                        Currency = "BAM",
                    }
                };

                Tokenservice = new TokenService();
                stripeToken = Tokenservice.Create(Tokenoptions);
                return stripeToken.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool MakePayment(string token)
        {
            try
            {
                StripeConfiguration.ApiKey = StripeSecretApiKey;
                var options = new ChargeCreateOptions
                {
                    Amount = ((long)Amount) * 100,
                    Currency = "bam",
                    Description = "Charge for " + "test@gmail.com",
                    Source = stripeToken.Id,
                    StatementDescriptor = "Custom descriptor",
                    Capture = true,
                    ReceiptEmail = "random.person@gmail.com",
                };
                //Make Payment
                var service = new ChargeService();
                Charge charge = service.Create(options);
                return true;
            }
            catch (Exception ex)
            {
                Console.Write("Payment Gatway (CreateCharge)" + ex.Message);
                throw ex;
            }
        }

        private bool ValidateCard()
        {
            if (CreditCardModel.Number.Length == 16 && ExpMonth.Length == 2 && ExpYear.Length == 2 && CreditCardModel.Cvc.Length == 3)
            {
                return true;
            }
            return false;
        }

        #endregion Method
    }
}