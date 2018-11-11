
using GalaSoft.MvvmLight;

namespace CalculatorMVVM.ViewModel
{
    public class CalculatorButtonControlViewModel : ViewModelBase
    {
        public string CalculatorButtonContent
        {
            get => _calculatorButtonContent;
            set
            {
                _calculatorButtonContent = value;
                RaisePropertyChanged();
            }
        }

        private string _calculatorButtonContent;
    }
}
