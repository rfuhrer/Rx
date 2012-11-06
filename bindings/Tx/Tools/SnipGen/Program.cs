﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;

namespace UpdateSnippets
{
    class Program
    {
        static string sourceRootDir; 

        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine(@"Usage: SnipGen sourceRootDir");
                return;
            }

            try
            {
                sourceRootDir = args[0];

                string[] snipgenFiles = Directory.GetFiles(".", "*.snipgen", SearchOption.AllDirectories);
                foreach (string fileName in snipgenFiles)
                {
                    GenerateSnippets(fileName);
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }

        static void GenerateSnippets(string fileName)
        {
            Console.WriteLine(fileName);
            TextReader reader = File.OpenText(fileName);

            XElement root = new XElement("examples");
            XDocument xd = new XDocument(root);

            XComment comment = new XComment("This file was generated by SnipGen.exe");
            xd.Root.Add(comment);

            while (true)
            {
                string line = reader.ReadLine();
                if (line == null)
                    break;

                if (String.IsNullOrWhiteSpace(line))
                    continue;

                string[] tokens = line.Split(',');
                if (tokens.Length != 3)
                    throw new Exception("Malformed line: + line");

                string id = tokens[0].Trim();
                Console.WriteLine("\t{0}", id);

                string source = Path.Combine(sourceRootDir,tokens[1].Trim());
                string start = tokens[2].Trim();

                XElement item = new XElement("item");
                item.SetAttributeValue("id", id);
                root.Add(item);

                XElement sampleCode = new XElement("sampleCode");
                sampleCode.SetAttributeValue("language", "CSharp"); 
                sampleCode.Value = GetCode(source, start) + "    ";
                item.Add(sampleCode);
            }

            xd.Save(Path.ChangeExtension(fileName,".snippets"));
        }

        static string GetCode(string source, string take)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            using (TextReader reader = File.OpenText(source))
            {
                string line;
                while (true)
                {
                    line = reader.ReadLine();
                    if (line == null)
                        throw new Exception("Could not find line starting with " + take + " in the file " + source);

                    if (line.TrimStart(' ', '\t').StartsWith(take))
                        break;
                }
                sb.AppendLine(line);

                line = reader.ReadLine();
                int startTab = line.IndexOf('{');
                sb.AppendLine(line);

                while (true)
                {
                    line = reader.ReadLine();
                    sb.AppendLine(line);
                    int tab = line.IndexOf('}');
                    if (tab == startTab)
                        break;
                }
            }
            
            return sb.ToString();
        }
    }
}
