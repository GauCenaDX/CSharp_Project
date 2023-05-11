namespace InheritanceMiniProject.Interfaces
{
    public interface IRentable : IInventoryItem
    {
        public void Rent();
        public void ReturnRental();
    }
}
