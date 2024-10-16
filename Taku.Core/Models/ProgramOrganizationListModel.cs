namespace SkillBridgeAPI.Models
{
    public interface IProgramOrganizationList
    {
        int PageCount { get; set; }
        int RowCount { get; set; }
        IEnumerable<IProgramOrganizationListItem> Data { get; set; }
    }

    public class ProgramOrganizationListModel : IProgramOrganizationList
    {
        public int PageCount { get; set; }
        public int RowCount { get; set; }
        public IEnumerable<IProgramOrganizationListItem> Data { get; set; }
    }
}