namespace Solare.Models
{
    public class ServiceLocation
    {
        int _serviceLocationId;
        public int ServiceLocationId
        {
            get => _serviceLocationId;
            set => _serviceLocationId = value;
        }
        
        ServiceLocationType _type;
        public ServiceLocationType Type
        {
            get => _type;
            set => _type = value;
        }
    }
}