
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
        private ObservableCollection<Person> _PersonList;

        public ObservableCollection<Person> PersonList
        {
            get { return _PersonList; }
            set { _PersonList = value; }
        }
        #endregion [ Properties ]

        #region [ Constructor ]
        public MainWindow()
        {
            string[] args = Environment.GetCommandLineArgs();
            this._utilityArguments = new UtilityArguments(args);
            InitializeComponent();
            CultureResources.ResourceProvider.DataChanged += new EventHandler(ResourceProvider_DataChanged);
            CultureResources.ChangeCulture(this._utilityArguments.Culture);
            //this.cultureComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbLanguages_SelectionChanged);
            //this.cultureComboBox.SelectedItem = this._utilityArguments.Culture;
            //this._busyIndicator.IsBusy = this._utilityArguments.UseBusyControl;
            this._mainPanel.IsEnabled = !this._utilityArguments.UseBusyControl;
            this.Loaded += new RoutedEventHandler(this.MainWindow_Loaded);
            Person person = new Person();
            person.FirstName = "José";
            person.LastName = "Salgado";
            this.PersonList = new ObservableCollection<Person>();
            this.PersonList.Add(person);
        }
        #endregion [ Constructor ]

        #region [ Private Methods ]
        private void ResourceProvider_DataChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(string.Format("ObjectDataProvider.DataChanged event. fetching culturename property for new culture [{0}]", Properties.Resources.language));
        }

        private void cbLanguages_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //CultureInfo selected_culture = cultureComboBox.SelectedItem as CultureInfo;

            //if (Properties.Resources.Culture != null && !Properties.Resources.Culture.Equals(selected_culture))
            //{
            //    Debug.WriteLine(string.Format("Change Current Culture to [{0}]", selected_culture));
            //    CultureResources.ChangeCulture(selected_culture);
            //}
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //if (this._utilityArguments.ShowMessageBox)
            //{
            //    var result = MessageBox.Show(Properties.Resources.language, Properties.Resources.warningMessage, MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            //    if (result != null)
            //    {
            //        App.Current.Shutdown();
            //    }
            //}
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            //if (tbHideButton.IsChecked == true)
            //{
            //    this.btnOK.Visibility = Visibility.Hidden;
            //}
            //else
            //{
            //    this.btnOK.Visibility = Visibility.Visible;
            //}
        }
        #endregion [ Private Methods ]

    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}



