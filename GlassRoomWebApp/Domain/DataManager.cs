using GlassRoomWebApp.Domain.Repositories.Abstract;

namespace GlassRoomWebApp.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }
        public ICityListRepository CitiesList { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, IServiceItemsRepository serviceItemsRepository, ICityListRepository cityListRepository)
        {
            TextFields = textFieldsRepository;
            ServiceItems = serviceItemsRepository;
            CitiesList = cityListRepository;
        }
    }
}
