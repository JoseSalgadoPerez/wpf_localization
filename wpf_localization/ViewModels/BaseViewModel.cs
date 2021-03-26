using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using System;
using wpf_localization.Converters;

namespace wpf_localization.ViewModels
{
    public class BaseViewModel: ViewModelBase
    {
        #region [ Properties ]
        private UtilityArguments _utilityArguments;      
        
        public bool IsBusy
        {
            get { return GetProperty(() => IsBusy); }
            set { SetProperty(() => IsBusy, value); }
        }

        public int Progress
        {
            get { return GetProperty(() => Progress); }
            set { SetProperty(() => Progress, value); }
        }
        #endregion [ Properties ]

        #region [ Constructor ]
        public BaseViewModel() {
            string[] args = Environment.GetCommandLineArgs();
            this._utilityArguments = new UtilityArguments(args);
            this.IsBusy = this._utilityArguments.UseBusyControl;
        }

        #endregion [ Constructor ]

    }
}
