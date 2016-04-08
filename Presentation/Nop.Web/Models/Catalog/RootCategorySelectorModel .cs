using System.Collections.Generic;
using Nop.Web.Framework.Mvc;

namespace Nop.Web.Models.Catalog
{
    public class RootCategorySelectorModel : BaseNopEntityModel
    {
        public RootCategorySelectorModel()
        {
            AvailableRootCategories = new List<CategoryModel>();
        }

        public IList<CategoryModel> AvailableRootCategories { get; set; }

        public int CurrentCategoryId { get; set; }
    }
}
