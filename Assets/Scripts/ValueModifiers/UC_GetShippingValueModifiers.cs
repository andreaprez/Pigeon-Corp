namespace PigeonCorp.ValueModifiers
{
    public class UC_GetShippingValueModifiers
    {
        private readonly ValueModifiersRepository _repository;

        public UC_GetShippingValueModifiers(ValueModifiersRepository repository)
        {
            _repository = repository;
        }
        
        public BaseValueModifiers Execute()
        {
            return _repository.Get<ShippingValueModifiers>();
        }
    }
}