using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.ViewModels;
using Playground.Core.ViewModels;

namespace Playground.Wpf.Views
{
    [MvxContentPresentation]
    [MvxViewFor(typeof(TestViewModel))]
    /// <summary>
    /// Interaction logic for TestView.xaml
    /// </summary>
    public partial class TestView : MvxWpfView
    {
        public TestView()
        {
            InitializeComponent();

            Loaded += TestView_Loaded;
        }

        private void TestView_Loaded(object sender, RoutedEventArgs e)
        {
            using (var set = this.CreateBindingSet<TestView, TestViewModel>())
            {
                set.Bind(TitleLabel).For(v => v.Content).To(vm => vm.MyTitle);
            }
        }
    }
}
