using SkillBridgeAPI.Structs;
using Taku.Core;

namespace SkillBridgeAPI.Commands
{
    public interface IDetermineSkipTakeCommand :IRenderingCommand
    {
        void Execute(int? page, int? size, out TakeSizeStruct pageSize);
    }

    public class DetermineSkipTakeCommand : IDetermineSkipTakeCommand
    {
        public void Execute(int? page, int? size, out TakeSizeStruct pageSize)
        {
            page ??= 0;

            size ??= 10;

            var ret = new TakeSizeStruct
            {
                Skip = size.Value * page.Value,
                Take = size.Value
            };

            pageSize = ret;
        }
    }
}