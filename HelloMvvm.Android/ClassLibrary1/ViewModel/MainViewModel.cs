using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace HelloMvvm.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public const string MessageTemplate = "Button was clicked {0} times";
        private int _count;
        
        private string _title = "Nothing";

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                Set(ref _title, value);
            }
        }

        private RelayCommand _updateCommand;

        public RelayCommand UpdateCommand
        {
            get
            {
                return _updateCommand
                    ?? (_updateCommand = new RelayCommand(
                    () =>
                    {
                        Title = string.Format(MessageTemplate, ++_count);
                    }));
            }
        }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }
    }
}