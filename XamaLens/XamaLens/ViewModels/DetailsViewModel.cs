using XamaLens.Models;

namespace XamaLens.ViewModels
{
    public class DetailsViewModel
    {
        public Monkey Monkey { get; set; }

        public DetailsViewModel(Monkey monkey)
        {
            Monkey = monkey;
        }
    }
}