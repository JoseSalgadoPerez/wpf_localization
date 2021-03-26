using System.Threading.Tasks;

namespace wpf_localization.ViewModels
{
    public class MainViewModel : BaseViewModel
    {      
       
        public MainViewModel() {   
            Progress = 0; 
        }  
        
        public async Task BeBusyAsync()
        {
            try
            {
                Progress = 0;
                IsBusy = true;

                await Task.Run(async () =>
                {
                    int progress = 0;

                    while (progress < 100)
                    {
                        await Task.Delay(250);

                        progress += 10;
                        Progress = progress;
                    }
                });
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
