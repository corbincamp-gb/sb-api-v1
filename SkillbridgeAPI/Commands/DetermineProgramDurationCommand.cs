﻿using SkillBridgeAPI.Models.Db;
using Taku.Core;

namespace SkillBridgeAPI.Commands
{
    public interface IDetermineProgramDurationCommand :IRenderingCommand
    {
        void Execute(IProgram prog, out string result);
        void Execute(IEnumerable<int> indexes, string delimiter, out string result);
    }

    public class DetermineProgramDurationCommand : IDetermineProgramDurationCommand
    {
        private readonly Dictionary<int, string> _durations = new()
        {
            { 0, "1 - 30 days" },
            { 1, "31 - 60 days" },
            { 2, "61 - 90 days" },
            { 3, "91 - 120 days" },
            { 4, "121 - 150 days" },
            { 5, "151 - 180 days" },
            { 6, "Individually Developed – not to exceed 40 hours" },
            { 7, "Self-paced" }
        };

        private string Resolve(int idx)
        {
            return _durations.TryGetValue(idx, out var duration)
                ? duration
                : _durations[6];
        }

        public void Execute(IProgram prog, out string result)
        {
            result = Resolve(prog.ProgramDuration);
        }

        public void Execute(IEnumerable<int> indexes, string delimiter, out string result)
        {
            result = string.Join(delimiter, indexes.Select(Resolve).ToList());
        }
    }
}
