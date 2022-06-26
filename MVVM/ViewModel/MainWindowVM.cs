using eduClient.Core;
using eduClient.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eduClient.MVVM.ViewModel
{
    internal class MainWindowVM : ObservableObject
    {

        public RelayCommand TestButtonCommand { get; set; }
        private string _textTest;

        public string TestText
        {
            get { return _textTest; }
            set { _textTest = value; NotifyPropertyChanged(); }
        }

        public MainWindowVM()
        {
            TestButtonCommand = new RelayCommand(o =>
            {
                MainWindowModel model = new MainWindowModel();

                TestText = model.HelloWorld();


            });
        }
    }
}
