
using System.Reflection;
using System.Security.Cryptography;
using System.Xml.Linq;

var sqlProjFile = args.FirstOrDefault(x => x.EndsWith(".sqlproj", StringComparison.OrdinalIgnoreCase));

if(sqlProjFile == null)
{
    foreach (var file in Directory.GetFiles(Environment.CurrentDirectory, "*.sqlproj", SearchOption.AllDirectories))
    {
        sqlProjFile = file;
        break;
    }
}

if(sqlProjFile == null)
{
    Console.WriteLine("No .sqlproj file found.");
    return;
}
else
{
    if (!File.Exists(sqlProjFile))
    {
        Console.WriteLine("Invalid file path. Please provide a valid .sqlproj file.");
        return;
    }
    var sqlProjFileDir = Path.GetDirectoryName(sqlProjFile);
    List<String> SqlFiles = new List<string>();

    var argSqlFiles = args.Where(x => x.EndsWith(".sql", StringComparison.OrdinalIgnoreCase)).ToList();

   
    try
    {
        XDocument doc = XDocument.Load(sqlProjFile);
        var projSqlFiles = doc.Descendants()
                  .Where(e => e.Name.LocalName == "Build" || e.Name.LocalName == "None")
                  .Select(e => e.Attribute("Include")?.Value)
                  .Where(path => !string.IsNullOrWhiteSpace(path) && path.EndsWith(".sql", StringComparison.OrdinalIgnoreCase))
                  .ToList();
        if (argSqlFiles.Count == 0)
        {
             SqlFiles = projSqlFiles.Select(sqlfile => Path.Combine(sqlProjFileDir, sqlfile)).ToList();
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
                    SqlFiles.Add(Path.Combine(sqlProjFileDir, sf));
                }
            }
        }
        
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error loading .sqlproj file: {ex.Message}");
        return;
    }


    Console.WriteLine($"SQL Project File: {sqlProjFile}");
    Console.WriteLine($"SQL File: {string.Join(", \n", SqlFiles)}");
}