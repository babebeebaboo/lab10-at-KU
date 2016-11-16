/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: countIdentifier.cs                
//DATE: 16 Nov 2016                          
/////////////////////////////////////////////
using System.Collections.Generic;
using System;
using System.IO;
class test
{
    static bool inComment = false, inSingleQuote = false, inDoubleQuote = false;
    static Dictionary<string, int> ReserveWord = new Dictionary<string, int>();
    static Dictionary<string, int> Identifier = new Dictionary<string, int>();
    static void Main(string[] args)
    {
        StreamReader SR = File.OpenText(args[0]);
        ReserveWord.Add("set", 0); ReserveWord.Add("value", 0); ReserveWord.Add("var", 0); ReserveWord.Add("where", 0); ReserveWord.Add("yeild", 0); ReserveWord.Add("abstract", 0); ReserveWord.Add("as", 0); ReserveWord.Add("base", 0); ReserveWord.Add("bool", 0); ReserveWord.Add("break", 0); ReserveWord.Add("byte", 0); ReserveWord.Add("case", 0); ReserveWord.Add("catch", 0); ReserveWord.Add("char", 0); ReserveWord.Add("checked", 0); ReserveWord.Add("class", 0); ReserveWord.Add("const", 0); ReserveWord.Add("continue", 0); ReserveWord.Add("decimal", 0); ReserveWord.Add("default", 0); ReserveWord.Add("delegate", 0); ReserveWord.Add("do", 0); ReserveWord.Add("double", 0); ReserveWord.Add("else", 0); ReserveWord.Add("enum", 0); ReserveWord.Add("event", 0); ReserveWord.Add("explicit", 0); ReserveWord.Add("extern", 0); ReserveWord.Add("false", 0); ReserveWord.Add("finally", 0); ReserveWord.Add("fixed", 0); ReserveWord.Add("float", 0); ReserveWord.Add("for", 0); ReserveWord.Add("foreach", 0); ReserveWord.Add("goto", 0); ReserveWord.Add("if", 0); ReserveWord.Add("implicit", 0); ReserveWord.Add("in", 0); ReserveWord.Add("int", 0); ReserveWord.Add("interface", 0); ReserveWord.Add("internal", 0); ReserveWord.Add("is", 0); ReserveWord.Add("lock", 0); ReserveWord.Add("long", 0); ReserveWord.Add("namespace", 0); ReserveWord.Add("new", 0); ReserveWord.Add("null", 0); ReserveWord.Add("object", 0); ReserveWord.Add("operator", 0); ReserveWord.Add("out", 0); ReserveWord.Add("override", 0); ReserveWord.Add("params", 0); ReserveWord.Add("private", 0); ReserveWord.Add("protected", 0); ReserveWord.Add("public", 0); ReserveWord.Add("readonly", 0); ReserveWord.Add("ref", 0); ReserveWord.Add("return", 0); ReserveWord.Add("sbyte", 0); ReserveWord.Add("sealed", 0); ReserveWord.Add("short", 0); ReserveWord.Add("sizeof", 0); ReserveWord.Add("stackalloc", 0); ReserveWord.Add("static", 0); ReserveWord.Add("string", 0); ReserveWord.Add("struct", 0); ReserveWord.Add("switch", 0); ReserveWord.Add("this", 0); ReserveWord.Add("throw", 0); ReserveWord.Add("true", 0); ReserveWord.Add("try", 0); ReserveWord.Add("typeof", 0); ReserveWord.Add("uint", 0); ReserveWord.Add("ulong", 0); ReserveWord.Add("unchecked", 0); ReserveWord.Add("unsafe", 0); ReserveWord.Add("ushort", 0); ReserveWord.Add("using", 0); ReserveWord.Add("virtual", 0); ReserveWord.Add("void", 0); ReserveWord.Add("volatile", 0); ReserveWord.Add("while", 0); ReserveWord.Add("add", 0); ReserveWord.Add("alias", 0); ReserveWord.Add("ascending", 0); ReserveWord.Add("descending", 0); ReserveWord.Add("dynamic", 0); ReserveWord.Add("from", 0); ReserveWord.Add("get", 0); ReserveWord.Add("global", 0); ReserveWord.Add("group", 0); ReserveWord.Add("into", 0); ReserveWord.Add("join", 0); ReserveWord.Add("let", 0); ReserveWord.Add("orderby", 0); ReserveWord.Add("partial", 0); ReserveWord.Add("remove", 0); ReserveWord.Add("select", 0);
        string s = SR.ReadLine();
        while (s != null)
        {
            string a = "", forCheck = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '/' && s[i + 1] == '/')
                    i = s.Length - 1;
                else if (s[i] == '*' && s[i + 1] == '/')
                {
                    i++;
                    inComment = false;
                }
                else if (s[i] == '/' && s[i + 1] == '*')
                {
                    i++;
                    inComment = true;
                }
                else if (s[i] == '"')
                    inDoubleQuote = !inDoubleQuote;
                else if (s[i] == '\'')
                    inSingleQuote = !inSingleQuote;
                else if (s[i] == '.') a += ' ';
                else if (s[i] == '(') a += ' ';
                else if (s[i] == ')') a += ' ';
                else if (s[i] == '{') a += ' ';
                else if (s[i] == '}') a += ' ';
                else if (s[i] == '[') a += ' ';
                else if (s[i] == ']') a += ' ';
                else if (s[i] == ':') a += ' ';
                else if (s[i] == ';') a += ' ';
                else if (s[i] == '<') a += ' ';
                else if (s[i] == '>') a += ' ';
                else if (s[i] == '=') a += ' ';
                else if (s[i] == '-') a += ' ';
                else if (s[i] == '+') a += ' ';
                else if (s[i] == '*') a += ' ';
                else if (s[i] == '|') a += ' ';
                else if (s[i] == '&') a += ' ';
                else if (s[i] == ',') a += ' ';
                else if (s[i] == '!') a += ' ';
                else
                {
                    int tmp;
                    if ((!inComment && !inDoubleQuote && !inSingleQuote && !int.TryParse(s[i].ToString(), out tmp)) || i == s.Length - 1)
                        a += s[i];
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == ' ')
                {
                    check(forCheck);
                    forCheck = "";
                }
                else forCheck += a[i];
                if (i == a.Length - 1)
                {
                    check(forCheck);
                    forCheck = "";
                }
            }
            s = SR.ReadLine();
        }
        foreach (KeyValuePair<string, int> i in Identifier)
            if (i.Value > 0)
                Console.Write("[{0}={1}] ", i.Key, i.Value);
        SR.Close();
    }
    static void check(string a)
    {
        int inn;
        if (Int32.TryParse(a, out inn)) return;
        if (inComment) return;
        else if (a == "") return;
        else if (ReserveWord.ContainsKey(a)) return;
        else if (Identifier.ContainsKey(a)) Identifier[a]++;
        else Identifier.Add(a, 1);
    }
}

