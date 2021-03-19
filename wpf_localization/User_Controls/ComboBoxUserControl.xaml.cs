namespace wpf_localization.User_Controls
{

    using System;
    using System.Diagnostics;
    using System.Globalization;
    using System.Windows.Controls;
    using wpf_localization.Converters;

    /// <summary>
    /// Interaction logic for ComboBoxUserControl.xaml
    /// </summary>
    public partial class ComboBoxUserControl : UserControl
    {

        private UtilityArguments _utilityArguments;
        public ComboBoxUserControl()
        {
            InitializeComponent();
            string[] args = Environment.GetCommandLineArgs();
            this._utilityArguments = new UtilityArguments(args);
            this.cultureComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbLanguages_SelectionChanged);
            this.cultureComboBox.SelectedItem = this._utilityArguments.Culture;
        }

        private void cbLanguages_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CultureInfo selected_culture = cultureComboBox.SelectedItem as CultureInfo;

            if (Properties.Resources.Culture != null && !Properties.Resources.Culture.Equals(selected_culture))
            {
                Debug.WriteLine(string.Format("Change Current Culture to [{0}]", selected_culture));
                CultureResources.ChangeCulture(selected_culture);
            }
        }
    }
}
