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
using wpf_localization.Converters;

namespace wpf_localization.User_Controls
{
    /// <summary>
    /// Interaction logic for MainViewUserControl.xaml
    /// </summary>
    public partial class MainViewUserControl : UserControl
    {
        #region [ Properties ]
        private UtilityArguments _utilityArguments;
        #endregion [ Properties ]

        public MainViewUserControl()
        {
            string[] args = Environment.GetCommandLineArgs();
            this._utilityArguments = new UtilityArguments(args);
            InitializeComponent();
            this._mainPanel.IsEnabled = !this._utilityArguments.UseBusyControl;
        }        
    }
}
