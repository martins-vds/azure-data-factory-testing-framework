// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace AzureDataFactory.TestingFramework.Models
{
    internal static partial class DataFactoryDayOfWeekExtensions
    {
        public static string ToSerialString(this DataFactoryDayOfWeek value) => value switch
        {
            DataFactoryDayOfWeek.Sunday => "Sunday",
            DataFactoryDayOfWeek.Monday => "Monday",
            DataFactoryDayOfWeek.Tuesday => "Tuesday",
            DataFactoryDayOfWeek.Wednesday => "Wednesday",
            DataFactoryDayOfWeek.Thursday => "Thursday",
            DataFactoryDayOfWeek.Friday => "Friday",
            DataFactoryDayOfWeek.Saturday => "Saturday",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DataFactoryDayOfWeek value.")
        };

        public static DataFactoryDayOfWeek ToDataFactoryDayOfWeek(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Sunday")) return DataFactoryDayOfWeek.Sunday;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Monday")) return DataFactoryDayOfWeek.Monday;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Tuesday")) return DataFactoryDayOfWeek.Tuesday;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Wednesday")) return DataFactoryDayOfWeek.Wednesday;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Thursday")) return DataFactoryDayOfWeek.Thursday;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Friday")) return DataFactoryDayOfWeek.Friday;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Saturday")) return DataFactoryDayOfWeek.Saturday;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DataFactoryDayOfWeek value.");
        }
    }
}
