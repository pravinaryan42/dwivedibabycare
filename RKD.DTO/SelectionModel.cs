using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Properties;
namespace RKD.DTO
{
    public class SelectionModel
    {

        public SelectionModel() {
            BlockDataList = new List<SelectListItem>();
        }
        public List<SelectListItem> BlockDataList { get; set; }
        public string SelectedBlock { get; set; }


    }
}
