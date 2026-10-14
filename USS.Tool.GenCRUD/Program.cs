using USS.Tool.GenCRUD;

foreach(var projModel in SolutionInfo.ProjectModels)
{
    Console.WriteLine(projModel.ModelClass);
}
