using System;
namespace ObsoleteScripts
{
    [Obsolete]
    public static class ScriptsHelper
    {
        public static void TryOrSkip(Action action)
        {
            try
            {
                action();
            }
            catch
            {
                // ignored
            }
        }
    }
}
