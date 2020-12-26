using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode.Library;

namespace AdventOfCode2020Solver.Solvers.Library
{
    public static class StringOperations
    {
#region Separators
    private static string[] newLines => new[] {"\r\n", "\r", "\n"};
    
        ///     Generic separating characters
        private static char[] Separators => SeparatorList(AdventOfCode.Library.Separators.All, ',');

        /// <summary>
        /// Takes a flag value and generates a list of chars that will be used to
        /// separate text at a later point.
        /// </summary>
        /// <param name="flag">Enum value with flag bits for classes of chars</param>
        /// <returns>Array of stop characters</returns>
        private static List<char> ParseSeparatorFlags(Separators flag)
        {
            var separators = new List<char>();
            if ((flag & AdventOfCode.Library.Separators.WhiteSpace) == AdventOfCode.Library.Separators.WhiteSpace)
            {
                separators.AddRange(new[]{' ', '\t'});
            }
            
            if ((flag & AdventOfCode.Library.Separators.NewLines) == AdventOfCode.Library.Separators.NewLines)
            {
                separators.AddRange(new[]{'\r', '\n'});
            }

            return separators;
        }
        
        /// <summary>
        /// Generates an array of stop characters based on flag and single char
        /// </summary>
        /// <param name="flag">Enum value with flag bits for classes of chars</param>
        /// <param name="c">Additional character</param>
        /// <returns>Array of stop characters</returns>
        public static char[] SeparatorList(Separators flag, char c)
        {
            var seps = ParseSeparatorFlags(flag);
            if (!seps.Contains(c))
            {
                seps.Add(c);
            }

            return seps.ToArray();
        }

        /// <summary>
        /// Generates an array of stop characters based on flag and string
        /// </summary>
        /// <param name="flag">Enum value with flag bits for classes of chars</param>
        /// <param name="s">String with additional chars</param>
        /// <returns>Array of stop characters</returns>
        public static char[] SeparatorList(Separators flag, string s)
        {
            var seps = ParseSeparatorFlags(flag);
            foreach (char c in s.Where(c => !seps.Contains(c)))
            {
                seps.Add(c);
            }

            return seps.ToArray();
        }

        /// <summary>
        /// Generates a basic stop list based on one character
        /// </summary>
        /// <param name="c">character to separate string with</param>
        /// <returns>Array with <see cref="c"/></returns>
        public static char[] SeparatorList(char c)
        {
            return new[] {c};
        }

        /// <summary>
        /// Generates a basic stop list based on unique chars in a string
        /// </summary>
        /// <param name="s">String composed of stop chars</param>
        /// <returns>Array with stop characters</returns>
        public static char[] SeparatorList(string s)
        {
            var seps = new List<char>();
            foreach (char c in s.Where(c => !seps.Contains(c)))
            {
                seps.Add(c);
            }

            return seps.ToArray();
        }
#endregion

        /// <summary>
        /// Converts a string to a full list of distinct lines,
        /// optionally with blank lines removed.
        /// </summary>
        /// <param name="text">text that is being processed</param>
        /// <param name="removeBlank">Whether or not to remove blank lines based on the line being empty or solely white space</param>
        /// <returns>List of lines from text file.</returns>
        public static List<string> ToLines(this string text, bool removeBlank = false)
        {
            var lines = text.Split(newLines, StringSplitOptions.None).Select(s => s.Trim());
            return removeBlank
                       ? lines.Where(line => !string.IsNullOrEmpty(line.Trim())).ToList()
                       : lines.ToList();
        }

        /// <summary>
        /// Reads a file and returns a list of distinct lines with defined character
        /// providing field separation for further processing after being separated
        /// by pre separators.
        /// </summary>
        /// <param name="text">string to parse</param>
        /// <param name="separators">array of char values to split text on</param>
        /// <param name="removeBlank">Whether or not to remove blank lines based on the line being empty or solely white space</param>
        /// <param name="pasteChar">character to rejoin the tokens on each line</param>
        /// <returns>List of lines from string reformatted for processing</returns>
        public static List<string> ToTokenLines(
                this string text, char[] separators = null, bool removeBlank = true, char pasteChar = '|'
            )
        {
            var lines = text.ToLines(removeBlank);
            var option = removeBlank
                             ? StringSplitOptions.RemoveEmptyEntries
                             : StringSplitOptions.None;

            separators ??= Separators;

            return lines.Select(line => line.Split(separators, option))
                              .Select(parts => string.Join(pasteChar, parts)).ToList();
        }

        /// <summary>
        /// Parses string and returns all words separated by separator list segregated by each line of text
        /// </summary>
        /// <param name="text">string to parse</param>
        /// <param name="separators">array of characters to separate tokens</param>
        /// <param name="removeBlankWords">Choice to save empty tokens contained within sequential separators</param>
        /// <param name="removeBlankLines">Choice to save blank lines with no tokens</param>
        /// <returns>collection of words contained on each line as a collection of lines</returns>
        public static List<List<string>> ToJaggedLines(
                this string text, char[] separators = null, bool removeBlankWords = true,
                bool removeBlankLines = true
            )
        {
            var lines = text.ToLines(removeBlankLines);
            var option = removeBlankWords
                             ? StringSplitOptions.RemoveEmptyEntries
                             : StringSplitOptions.None;

            var jagged = new List<List<string>>();

            separators ??= Separators;

            foreach (string[] tokens in lines.Select(line => line.Split(separators, option)))
            {
                if (!removeBlankLines)
                {
                    jagged.Add(tokens.ToList());
                }
                else
                {
                    if (tokens.Length > 0)
                    {
                        jagged.Add(tokens.ToList());
                    }
                }
            }

            return jagged;
        }

        /// <summary>
        /// Reads string and returns all words separated by separator list
        /// </summary>
        /// <param name="text">string to parse</param>
        /// <param name="separators">array of characters to separate tokens</param>
        /// <param name="removeBlankWords">Choice to save empty tokens contained within sequential separators</param>
        /// <returns>A list of strings representing individual tokens</returns>
        public static List<string> ToTokens(
                this string text, char[] separators = null, bool removeBlankWords = true
            )
        {
            var lines = text.ToLines();
            var option = removeBlankWords
                             ? StringSplitOptions.RemoveEmptyEntries
                             : StringSplitOptions.None;
            var tokens = new List<string>();
            separators ??= Separators;

            foreach (var lineTokens in lines.Select(line => line.Split(separators, option)))
            {
                tokens.AddRange(lineTokens);
            }

            return tokens;
        }

        /// <summary>
        /// Read text file with blobs of data separated by blank lines.
        /// </summary>
        /// <param name="text">string to parse</param>
        /// <param name="joinLines">boolean to indicate if lines in blob should be joined together</param>
        /// <returns>List of separated data blobs</returns>
        public static List<string> ToBlobs(this string text, bool joinLines = true)
        {
            string separator;
            if (text.Contains("\r\n"))
            {
                separator = "\r\n";
            }
            else
            {
                separator = text.Contains("\n")
                                ? "\n"
                                : "\r";
            }
            
            string[] blobs = text.Split($"{separator}{separator}", StringSplitOptions.RemoveEmptyEntries);
            var result = blobs.Select
                               (
                                blob => joinLines
                                            ? string.Join(' ', blob.Split($"{separator}", StringSplitOptions.RemoveEmptyEntries))
                                            : blob
                               )
                              .ToList();
            return result;
        }
    }
}
