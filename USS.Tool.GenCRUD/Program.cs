using USS.Tool.GenCRUD;

if (SQLProj.IsValid)
{
    var result = SQLProj.SQLRootNameSpace;


    Console.WriteLine("\n\nTables : ");
    foreach(var table in SQLProj.tables)
    {
        Console.WriteLine($"\n\nTable: {table.TableName}");
        Console.WriteLine("\n\nFields : ");
        foreach (var field in table.Fields)
        {
            Console.WriteLine($"  - {field.Name} ({field.DataType})");
            var refDisplay = field.GetReferenceDisplay(true);
            if (!string.IsNullOrEmpty(refDisplay))
            {
                Console.WriteLine("    Foreign Keys:");
                Console.WriteLine($"        Reference Table: {field.Reference.TableName}");
                Console.WriteLine($"        Reference Field: {field.Reference.FieldName}");
            }
        }
        
    }

    Console.WriteLine("Done");
}