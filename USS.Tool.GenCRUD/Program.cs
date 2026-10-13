using USS.Tool.GenCRUD;

if (SQLProj.IsValid)
{
    SolutionInfo solution = new SolutionInfo(SQLProj.RootNamespace);
    foreach (var project in solution.Projects)
    {
        Console.WriteLine($"Project: {project.Name}, Path: {project.Path}, File: {project.File}");
    }
    Console.WriteLine("Done");
}