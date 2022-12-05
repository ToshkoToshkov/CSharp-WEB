namespace Warehouse.Core.Models
{
    /// Поръчка
    public class CustomerOrder
    {
        // Клиентски номер
        public string CustomerNumber { get; set; }

        
        // Списък с поръчки
        public List<ItemOrder> Items { get; set; } = new List<ItemOrder>();
    }
}