using System;
using System.Collections.Generic;

namespace MyWeather.Shared
{
    public class MyClass
    {
        Func<string, bool> whereClause = default;

        public MyClass()
        {
            HockeyApp.MetricsManager.TrackEvent(
                "Custom Event",
                new Dictionary<string, string> { { "property", "value" } },
                new Dictionary<string, double> { { "time", 1.0 } }
              );
            //Console.WriteLine(whereClause("Test").ToString());
        }
    }
}
