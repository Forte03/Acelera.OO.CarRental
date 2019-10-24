
namespace Acelera.OO.CarRental.AdditionalItems
{
    public abstract class AdditionalItem
    {
        public string Description { get; private set; }

        public double Value { get; private set; }

        public AdditionalItem(string description, double value)
        {
            this.Description = description;
            this.Value = value;
        }
    }
}
