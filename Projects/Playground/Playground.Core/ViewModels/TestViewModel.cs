using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.ViewModels;

namespace Playground.Core.ViewModels
{
    public class TestViewModel : MvxViewModel
    {
        public string MyTitle => "Binding Works!";
    }
}
