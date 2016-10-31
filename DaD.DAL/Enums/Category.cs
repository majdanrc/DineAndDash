using System.ComponentModel.DataAnnotations;

namespace DaD.DAL.Enums
{
    public enum Category
    {
        [Display(ResourceType = typeof(Resources), Name = "MainDish")]
        Main = 1,
        [Display(ResourceType = typeof(Resources), Name = "Pizza")]
        Pizza,
        [Display(ResourceType = typeof(Resources), Name = "Soups")]
        Soup,
        [Display(ResourceType = typeof(Resources), Name = "Drinks")]
        Drink
    }
}
