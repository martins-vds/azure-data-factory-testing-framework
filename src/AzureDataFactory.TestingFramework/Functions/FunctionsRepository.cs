// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Text.Json;
using System.Text.Json.Nodes;

namespace AzureDataFactory.TestingFramework.Functions;

public static class FunctionsRepository
{
    internal static readonly Dictionary<string, Delegate> Functions = new()
    {
        { "concat", (IEnumerable<string> arguments) => string.Concat(arguments) },
        { "trim", Trim },
        { "equals", FuncEquals },
        { "json", Json },
        { "contains", Contains },
        { "replace",  (string input, string pattern, string replacement) => input.Replace(pattern, replacement) },
        { "string", (string input) => input },
        { "union" , (string arg0, string arg1) => JsonSerializer.Serialize(JsonSerializer.Deserialize<JsonArray>(arg0).Union(JsonSerializer.Deserialize<JsonArray>((arg1)))) },
        { "coalesce", (IEnumerable<string> args) => args.FirstOrDefault(arg => !string.IsNullOrEmpty(arg)) },
        { "or", (bool a, bool b) => a || b },
        { "utcnow", () => DateTime.UtcNow.ToString("o") },
        { "utcNow", () => DateTime.UtcNow.ToString("o") },
        { "ticks", (string dateTime) => DateTime.Parse(dateTime).Ticks },
        { "sub", (long a, long b) => a - b },
        { "div", (long a, long b) => a / b },
        { "greaterOrEquals", (long a, long b) => a >= b },
        { "not", (bool value) => !value },
        { "empty", (object[] array) => array.Length == 0 },
        { "split", (string input, string delimiter) => input.Split(delimiter).ToList() }
    };

    /// <summary>
    /// Registers a function to be used to evaluate ADF expressions.
    /// </summary>
    /// <param name="functionName">The name of the function</param>
    /// <param name="function">The delegate that takes the expected arguments and evaluates them in C#.</param>
    public static void Register(string functionName, Delegate function)
    {
        Functions[functionName] = function;
    }

    private static object FuncEquals(string argument0, string argument1)
    {
        if (argument0.GetType() != argument1.GetType())
            throw new ArgumentException("Equals function requires arguments of the same type.");

        return argument0.Equals(argument1);
    }

    private static string Trim(string text, string trimArgument)
    {
        return text.Trim(trimArgument[0]);
    }

    private static string Json(string argument)
    {
        return argument;
    }

    private static bool Contains(object obj, string value)
    {
        if (obj is Dictionary<string, string> dictionary)
            return dictionary.ContainsKey(value);

        if (obj is IEnumerable<object> enumerable)
            return enumerable.Contains(value);

        if (obj is string text)
            return text.Contains(value);

        throw new ArgumentException("Contains function requires an object of type Dictionary, IEnumerable or string.");
    }
}