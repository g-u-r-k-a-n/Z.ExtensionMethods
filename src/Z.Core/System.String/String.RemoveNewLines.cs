// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright � ZZZ Projects Inc. All rights reserved.

public static partial class Extensions {

    /// <summary>
    /// A string extension method that removes Carriage Return, Line Feed and End of Line
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// /// <param name="removeExcessWhiteSpaces">Send as 'true' if you want to remove unnecessary white spaces</param>
    /// <returns>A string.</returns>
    public static string RemoveNewLines(this string @this, bool removeExcessWhiteSpaces = default) {

        if(!removeExcessWhiteSpaces) {
            return @this.Replace("\r", "")
                        .Replace("\n", "");
        }

        return @this.Replace("\r", "")
                    .Replace("\n", "")
                    .RemoveExcessWhiteSpaces();
    }
}