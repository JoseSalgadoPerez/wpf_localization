
#region [ Using ]
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using wpf_localization.Converters;
#endregion  [ Using ]

namespace wpf_localization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region [ Properties ]
        private UtilityArguments _utilityArguments;
       
        #endregion [ Properties ]

        #region [ Constructor ]
        public MainWindow()
        {
            string[] args = Environment.GetCommandLineArgs();
            this._utilityArguments = new UtilityArguments(args);
            InitializeComponent();
            CultureResources.ResourceProvider.DataChanged += new EventHandler(ResourceProvider_DataChanged);
            CultureResources.ChangeCulture(this._utilityArguments.Culture);           
            this._mainPanel.IsEnabled = !this._utilityArguments.UseBusyControl;
            this.Loaded += new RoutedEventHandler(this.MainWindow_Loaded);
           
        }
        #endregion [ Constructor ]

        #region [ Private Methods ]
        private void ResourceProvider_DataChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(string.Format("ObjectDataProvider.DataChanged event. fetching culturename property for new culture [{0}]", Properties.Resources.language));
        }      

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (this._utilityArguments.ShowMessageBox)
            {
                var result = MessageBox.Show(Properties.Resources.language, Properties.Resources.warningMessage, MessageBoxButton.OKCancel, MessageBoxImage.Warning);
                if (result != null)
                {
                    App.Current.Shutdown();
                }
            }
        }
        #endregion [ Private Methods ]

    }

   
}



