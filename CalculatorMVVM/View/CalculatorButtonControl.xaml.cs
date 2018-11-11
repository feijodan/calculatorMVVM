using CalculatorMVVM.ViewModel;
using System.Windows.Controls;

namespace CalculatorMVVM.View
{
    /// <summary>
    /// Interaction logic for CalculatorButtonControl.xaml
    /// </summary>
    public partial class CalculatorButtonControl : UserControl
    {
        public string CalculatorButtonContent
        {
            get => _viewModel.CalculatorButtonContent;
            set
            {
                _viewModel.CalculatorButtonContent = value;
            }
        }

        private CalculatorButtonControlViewModel _viewModel;

        public CalculatorButtonControl()
        {
            InitializeComponent();
            _viewModel = new CalculatorButtonControlViewModel();
            DataContext = _viewModel;
        }
    }
}
