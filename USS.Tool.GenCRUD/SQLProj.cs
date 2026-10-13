using System.Xml.Linq;

namespace USS.Tool.GenCRUD
{
    internal static class SQLProj
    {
        private static readonly string[] args;

        static SQLProj()
        {
            args = Environment.GetCommandLineArgs().Skip(1).ToArray();
        }

        
        public static string SQLProjFile 
        { 
            get 
            {
                if(string.IsNullOrEmpty(field))
                {
                    field = args.FirstOrDefault(x => x.EndsWith(".sqlproj", StringComparison.OrdinalIgnoreCase));

                    if (field == null)
                    {
                        foreach (var file in Directory.GetFiles(Environment.CurrentDirectory, "*.sqlproj", SearchOption.AllDirectories))
                        {
                            field = file;
                            field = file;
                            break;
                        }
                    }

                }
                return field;
            }
        }

        public static string sqlProjFileDir
        {
            get
            {
                if (string.IsNullOrEmpty(field))
                {
                    field = Path.GetDirectoryName(SQLProjFile);
                }
                return field??"";
            }
        }

        public static List<string> SqlFiles
        {
            get
            {
                if (field == null)
                {
                    field = new List<string>();

                    var argSqlFiles = args.Where(x => x.EndsWith(".sql", StringComparison.OrdinalIgnoreCase)).ToList();

                    try
                    {
                        XDocument doc = XDocument.Load(SQLProjFile);
                        var projSqlFiles = doc.Descendants()
                                  .Where(e => e.Name.LocalName == "Build" || e.Name.LocalName == "None")
                                  .Select(e => e.Attribute("Include")?.Value)
                                  .Where(path => !string.IsNullOrWhiteSpace(path) && path.EndsWith(".sql", StringComparison.OrdinalIgnoreCase))
                                  .ToList();
                        if (argSqlFiles.Count == 0)
                        {
                            field = projSqlFiles.Select(sqlfile => Path.Combine(sqlProjFileDir, sqlfile)).ToList();
                        }
                        else
                        {
                            foreach (var sqlFile in argSqlFiles)
                            {
                                var sf = projSqlFiles.FirstOrDefault(x => x.EndsWith(sqlFile.Contains("\\") ? sqlFile : $"\\{sqlFile}"));

                                if (sf == null)
                                {
                                    Console.WriteLine($"Warning: The SQL file '{sqlFile}' is not included in the .sqlproj file.");
                                }
                                else
                                {
                                    field.Add(Path.Combine(sqlProjFileDir, sf));
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error loading .sqlproj file: {ex.Message}");
                    }

                }
                return field;
            }
        }

        public static bool IsValid
        {
            get
            {
                if (SQLProjFile == null)
                {
                    Console.WriteLine("No .sqlproj file found.");
                    return false;
                }
                else
                {
                    if (!File.Exists(SQLProjFile))
                    {
                        Console.WriteLine("Invalid file path. Please provide a valid .sqlproj file.");
                        return false;
                    }
                    Console.WriteLine($"SQL Project File: {SQLProjFile}");

                    List<String> SqlFiles = SQLProj.SqlFiles;
                    if(SqlFiles.Count == 0)
                    {
                        Console.WriteLine("No SQL files found in the .sqlproj file.");
                        return false;
                    }
                    Console.WriteLine($"SQL Files :");

                    foreach (var sqlFile in SqlFiles)
                    {
                        Console.WriteLine(sqlFile);
                    }
                }
                return true;
            }
        }
    }
}
