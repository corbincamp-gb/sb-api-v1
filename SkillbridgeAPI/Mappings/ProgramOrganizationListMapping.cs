using Taku.Core;
using Taku.Core.Models;

namespace SkillBridgeAPI.Mappings
{
    public interface IProgramOrganizationListMapping :IMapping
    {
        ProgramOrganizationListModel Map();

        ProgramOrganizationListModel Map(int draw, int size, ProgramOrganizationListModel data);
    }

    public class ProgramOrganizationListMapping: IProgramOrganizationListMapping
    {
        public ProgramOrganizationListModel Map()
        {
            return new ProgramOrganizationListModel([]);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="size"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public ProgramOrganizationListModel Map(int draw, int size, ProgramOrganizationListModel list)
        {
            return new ProgramOrganizationListModel(list.Data.Take(size).ToArray())
            {
                Draw = draw,
                RecordsFiltered = list.RecordsFiltered,
                RecordsTotal = list.RecordsTotal
            };

        }
    }
}
