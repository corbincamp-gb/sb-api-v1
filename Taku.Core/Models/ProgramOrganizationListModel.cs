using System.Text.Json.Serialization;

namespace Taku.Core.Models
{
    public class ProgramOrganizationListModel(ICollection<ProgramOrganizationListItemModel> data)
    {
        public int Draw { get; set; }
        public int RecordsFiltered { get; set; }
        public int RecordsTotal { get; set; }
        public ICollection<ProgramOrganizationListItemModel> Data { get; set; } = data;
    }
}