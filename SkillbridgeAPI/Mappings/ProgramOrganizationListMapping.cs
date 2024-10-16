using Taku.Core;
using Taku.Core.Models;

namespace SkillBridgeAPI.Mappings
{
    public interface IProgramOrganizationListMapping :IMapping
    {
        ProgramOrganizationListModel Map();
    }

    public class ProgramOrganizationListMapping: IProgramOrganizationListMapping
    {
        public ProgramOrganizationListModel Map()
        {

            return new ProgramOrganizationListModel([]);
            
        }
    }
}
