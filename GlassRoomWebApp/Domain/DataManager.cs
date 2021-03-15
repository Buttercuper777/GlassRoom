using GlassRoomWebApp.Domain.Repositories.Abstract;

namespace GlassRoomWebApp.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }
        public ICityListRepository CitiesOfList { get; set; }
        public IUserPhoneRepository UserPhones { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, IServiceItemsRepository serviceItemsRepository, ICityListRepository cityListRepository, IUserPhoneRepository userPhoneRepository)
        {
            TextFields = textFieldsRepository;
            ServiceItems = serviceItemsRepository;
            CitiesOfList = cityListRepository;
            UserPhones = userPhoneRepository;
        }
    }
}
