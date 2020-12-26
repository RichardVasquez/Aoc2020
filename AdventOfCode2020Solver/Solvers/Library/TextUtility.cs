using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace AdventOfCode.Library
{
    public static class TextUtility
    {
        ///     Generic separating characters
        private static char[] Separators => SeparatorList(Library.Separators.All, ',');

        /// <summary>
        /// Takes a flag value and generates a list of chars that will be used to
        /// separate text at a later point.
        /// </summary>
        /// <param name="flag">Enum value with flag bits for classes of chars</param>
        /// <returns>Array of stop characters</returns>
        private static List<char> ParseSeparatorFlags(Separators flag)
        {
            var separators = new List<char>();
            if ((flag & Library.Separators.WhiteSpace) == Library.Separators.WhiteSpace)
            {
                separators.AddRange(new[]{' ', '\t'});
            }
            
            if ((flag & Library.Separators.NewLines) == Library.Separators.NewLines)
            {
                separators.AddRange(new[]{'\r', '\n'});
            }

            return separators;
        }
        
        /// <summary>
        /// Generates an array of stop characters based on flag and single char
        /// </summary>
        /// <param name="flag">Enum value with flag bits for classes of chars<</param>
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
        /// <param name="flag">Enum value with flag bits for classes of chars<</param>
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

        /// <summary>
        /// Reads a file and returns a full list of separated words.
        ///
        /// Default is to read a file named 'input.txt', using the characters in
        /// <see cref="Separators"/> to separate them, and removes empty values
        /// between split characters.
        /// </summary>
        /// <param name="filename">Name of file to read</param>
        /// <param name="separators">array of char values to split text on</param>
        /// <param name="removeBlank">Whether or not to remove blank values resulting from two sequential separators</param>
        /// <returns>List of words from text file.</returns>
        public static List<string> ReadWords(string filename = "input.txt", char[] separators = null, bool removeBlank = true)
        {
            string text = File.ReadAllText(filename);
            separators ??= Separators;

            var option = removeBlank
                             ? StringSplitOptions.RemoveEmptyEntries
                             : StringSplitOptions.None;

            return text.Split(separators, option).ToList();
        }

        /// <summary>
        /// Reads a file and returns a full list of distinct lines, optionally
        /// with blank lines removed.
        /// </summary>
        /// <param name="filename">Name of file to read</param>
        /// <param name="removeBlank">Whether or not to remove blank lines based on the line being empty or solely white space</param>
        /// <returns>List of lines from text file.</returns>
        public static List<string> ReadLines(string filename = "input.txt", bool removeBlank = false)
        {
            var text = File.ReadAllLines(filename);
            return !removeBlank
                       ? text.ToList()
                       : text.Where(line => !string.IsNullOrEmpty(line.Trim())).ToList();
        }

        /// <summary>
        /// Reads a file and returns a list of distinct lines with defined character
        /// providing field separation for further processing after being separated
        /// by pre separators.
        /// </summary>
        /// <param name="filename">Name of file to read</param>
        /// <param name="separators">array of char values to split text on</param>
        /// <param name="removeBlank">Whether or not to remove blank lines based on the line being empty or solely white space</param>
        /// <param name="pasteChar">character to rejoin the tokens on each line</param>
        /// <returns>List of lines from text file reformatted for processing</returns>
        public static List<string> SplitPaste(
                string filename = "input.txt", char[] separators = null, bool removeBlank = true, char pasteChar = '|'
            )
        {
            var lines = ReadLines(filename, removeBlank);
            var option = removeBlank
                             ? StringSplitOptions.RemoveEmptyEntries
                             : StringSplitOptions.None;

            separators ??= Separators;

            return lines.Select(line => line.Split(separators, option))
                              .Select(parts => string.Join(pasteChar, parts)).ToList();
        }

        /// <summary>
        /// Reads text file and returns all words separated by separator list segregated by each line of text
        /// </summary>
        /// <param name="filename">file to read</param>
        /// <param name="separators">array of characters to separate tokens</param>
        /// <param name="removeBlankWords">Choice to save empty tokens contained within sequential separators</param>
        /// <param name="removeBlankLines">Choice to save blank lines with no tokens</param>
        /// <returns>collection of words contained on each line as a collection of lines</returns>
        public static List<List<string>> ReadJagged(
                string filename = "input.txt", char[] separators = null, bool removeBlankWords = true,
                bool removeBlankLines = true
            )
        {
            var lines = ReadLines(filename, removeBlankLines);
            var option = removeBlankWords
                             ? StringSplitOptions.RemoveEmptyEntries
                             : StringSplitOptions.None;

            var jagged = new List<List<string>>();

            separators ??= Separators;

            foreach (var tokens in lines.Select(line => line.Split(separators, option)))
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
        /// Reads text file and returns all words separated by separator list
        /// </summary>
        /// <param name="filename">file to read</param>
        /// <param name="separators">array of characters to separate tokens</param>
        /// <param name="removeBlankWords">Choice to save empty tokens contained within sequential separators</param>
        /// <returns>A list of strings representing individual tokens</returns>
        public static List<string> ReadTokens(
                string filename = "input.txt", char[] separators = null, bool removeBlankWords = true
            )
        {
            var lines = ReadLines(filename);
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
        /// <param name="filename">file to read</param>
        /// <param name="joinLines">boolean to indicate if lines in blob should be joined together</param>
        /// <returns>List of separated data blobs</returns>
        public static List<string> ReadBlobs(string filename = "input.txt", bool joinLines = true)
        {
            string text = File.ReadAllText(filename);
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
            
            var blobs = text.Split($"{separator}{separator}", StringSplitOptions.RemoveEmptyEntries);
            var result = blobs.Select
                               (
                                blob => joinLines
                                            ? string.Join(' ', blob.Split($"{separator}", StringSplitOptions.RemoveEmptyEntries))
                                            : blob
                               )
                              .ToList();
            return result;
        }

        /// <summary>
        /// Read text file as a single string.
        /// </summary>
        /// <param name="filename">file to read</param>
        /// <param name="doTrim">boolean to trim whitespace or not</param>
        /// <returns>Contents of text file</returns>
        public static string ReadFile(string filename = "input.txt", bool doTrim = true)
        {
            string text = File.ReadAllText(filename);
            if (doTrim)
            {
                text = text.Trim();
            }

            return text;
        }

    }
}

