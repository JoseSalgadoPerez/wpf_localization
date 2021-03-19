using System.Globalization;

namespace wpf_localization.Converters
{
    public class UtilityArguments : InputArguments
    {
        public bool UseBusyControl
        {
            get { return GetBoolValue("isBusy"); }
        }

        public CultureInfo Culture
        {
            get { return GetCultureValue("culture"); }
        }

        public bool ShowMessageBox
        {
            get { return GetBoolValue("showMessageBox"); }
        }

        public UtilityArguments(string[] args) : base(args)
        {
        }

        protected bool GetBoolValue(string key)
        {
            string adjustedKey;
            if (ContainsKey(key, out adjustedKey))
            {
                bool res;
                bool.TryParse(_parsedArguments[adjustedKey], out res);
                return res;
            }
            return false;
        }
    }
}
