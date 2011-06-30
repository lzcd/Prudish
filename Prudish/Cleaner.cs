using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prudish
{
    public class Cleaner
    {

        Dictionary<string, string> characterByLeetCode;

        public Cleaner()
        {
            LoadLeetCodes();
        }

        public string Simplify(string text)
        {
            var translations = from pair in characterByLeetCode
                                   orderby pair.Key.Length descending
                                   select new { LeetCode = pair.Key, Character = pair.Value };

            var deLeetedText = new StringBuilder(text.ToLower());
            foreach (var translation in translations)
            {
                deLeetedText = deLeetedText.Replace(translation.LeetCode, translation.Character);
            }
        
            return WhiteListClean(deLeetedText.ToString());
        }

        private static string WhiteListClean(string originalText)
        {
            var cleanText = new StringBuilder();

            foreach (var c in originalText)
            {
                switch (c)
                {
                    case 'a':
                    case 'b':
                    case 'c':
                    case 'd':
                    case 'e':
                    case 'f':
                    case 'g':
                    case 'h':
                    case 'i':
                    case 'j':
                    case 'k':
                    case 'l':
                    case 'm':
                    case 'n':
                    case 'o':
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                    case 't':
                    case 'u':
                    case 'v':
                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case '0':
                        cleanText.Append(c);
                        break;
                }
            }
            return cleanText.ToString();
        }


        private void LoadLeetCodes()
        {
            characterByLeetCode = new Dictionary<string, string>();
            characterByLeetCode[@"4"] = @"a";
            characterByLeetCode[@"|\"] = @"a";
            characterByLeetCode[@"^"] = @"a";
            characterByLeetCode[@"/\"] = @"a";
            characterByLeetCode[@"/-\"] = @"a";
            characterByLeetCode[@"|3"] = @"b";
            characterByLeetCode[@"8"] = @"b";
            characterByLeetCode[@"ß"] = @"b";
            characterByLeetCode[@"]3"] = @"b";
            characterByLeetCode[@"|:"] = @"b";
            characterByLeetCode[@"("] = @"c";
            characterByLeetCode[@"<"] = @"c";
            characterByLeetCode[@"©"] = @"c";
            characterByLeetCode[@"¢"] = @"c";
            characterByLeetCode[@"|)"] = @"d";
            characterByLeetCode[@"|}"] = @"d";
            characterByLeetCode[@"|>"] = @"d";
            characterByLeetCode[@"])"] = @"d";
            characterByLeetCode[@"]}"] = @"d";
            characterByLeetCode[@">"] = @"d";
            characterByLeetCode[@"3"] = @"e";
            characterByLeetCode[@"£"] = @"e";
            characterByLeetCode[@"|="] = @"f";
            characterByLeetCode[@"ƒ"] = @"f";
            characterByLeetCode[@"6"] = @"g";
            characterByLeetCode[@"9"] = @"g";
            characterByLeetCode[@"(_>"] = @"g";
            characterByLeetCode[@"#"] = @"h";
            characterByLeetCode[@"|-|"] = @"h";
            characterByLeetCode[@"(-)"] = @"h";
            characterByLeetCode[@"!-!"] = @"h";
            characterByLeetCode[@"}-{"] = @"h";
            characterByLeetCode[@"}{"] = @"h";
            characterByLeetCode[@"|+|"] = @"h";
            characterByLeetCode[@")+("] = @"h";
            characterByLeetCode[@"!+!"] = @"h";
            characterByLeetCode[@"}+{"] = @"h";
            characterByLeetCode[@"/-/"] = @"h";
            characterByLeetCode[@"\-\"] = @"h";
            characterByLeetCode[@"1"] = @"l";
            characterByLeetCode[@"!"] = @"l";
            characterByLeetCode[@"]"] = @"l";
            characterByLeetCode[@"|"] = @"l";
            characterByLeetCode[@"|\/|"] = @"m";
            characterByLeetCode[@"/\/\"] = @"m";
            characterByLeetCode[@"|\|\"] = @"m";
            characterByLeetCode[@"^^"] = @"m";
            characterByLeetCode[@"|\|"] = @"n";
            characterByLeetCode[@"|/|"] = @"n";
            characterByLeetCode[@"/\/"] = @"n";
            characterByLeetCode[@"0"] = @"o";
            characterByLeetCode[@"()"] = @"o";
            characterByLeetCode[@"<>"] = @"o";
            characterByLeetCode[@"*"] = @"o";
            characterByLeetCode[@"ø"] = @"o";
            characterByLeetCode[@"Ó"] = @"o";
            characterByLeetCode[@"°"] = @"o";
            characterByLeetCode[@"l*"] = @"p";
            characterByLeetCode[@"|>"] = @"p";
            characterByLeetCode[@"|D"] = @"p";
            characterByLeetCode[@"|^"] = @"p";
            characterByLeetCode[@"|+"] = @"p";
            characterByLeetCode[@"&"] = @"q";
            characterByLeetCode[@"(\)"] = @"q";
            characterByLeetCode[@"¶"] = @"q";
            characterByLeetCode[@"|2"] = @"r";
            characterByLeetCode[@"|?"] = @"r";
            characterByLeetCode[@"|-"] = @"r";
            characterByLeetCode[@"®"] = @"r";
            characterByLeetCode[@"5"] = @"s";
            characterByLeetCode[@"$"] = @"s";
            characterByLeetCode[@"§"] = @"s";
            characterByLeetCode[@"+"] = @"t";
            characterByLeetCode[@"7"] = @"t";
            characterByLeetCode[@"']'"] = @"t";
            characterByLeetCode[@"|_|"] = @"u";
            characterByLeetCode[@"/_/"] = @"u";
            characterByLeetCode[@"\/"] = @"v";
            characterByLeetCode[@"|/\|"] = @"w";
            characterByLeetCode[@"\/\/"] = @"w";
            characterByLeetCode[@"|/\/"] = @"w";
            characterByLeetCode[@"\/\|"] = @"w";
            characterByLeetCode[@"><"] = @"x";
            characterByLeetCode[@"}{"] = @"x";
            characterByLeetCode[@":-:"] = @"x";
            characterByLeetCode[@"¥"] = @"y";
            characterByLeetCode[@"2"] = @"z";
        }



    }
}
