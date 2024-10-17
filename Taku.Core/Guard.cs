﻿namespace SkillBridgeAPI.Utils
{
    public static class Guard
    {
        public static void Against(bool condition, string msg)
        {
            if (condition)
            {
                throw new Exception(msg);
            }
        }

        public static void AgainstNull(object? obj, string msg)
        {
            Against(obj == null, msg);

        }

        public static void AgainstInvalidOperation(string msg)
        {
            throw new InvalidOperationException(msg);
        }


    }
}
