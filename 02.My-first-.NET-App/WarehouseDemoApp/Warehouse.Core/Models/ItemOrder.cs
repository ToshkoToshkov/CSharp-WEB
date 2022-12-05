namespace Warehouse.Core.Models
{
    // Поръчан продукт
    public class ItemOrder
    {
        // Баркод на продукта
        public string Barcode { get; set; }

        // Брой поръчани продукти
        public int Count { get; set; }
    }
}