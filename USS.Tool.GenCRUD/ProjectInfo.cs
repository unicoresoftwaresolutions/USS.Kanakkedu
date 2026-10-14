namespace USS.Tool.GenCRUD
{
    public class ProjectInfo
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string File { get; set; }

        public ProjectInfo(SolutionInfo solution, string name)
        {
            this.Name = $"{solution.Name}.{name}";
            this.Path = $"{solution.Path}\\{this.Name}";
            this.File = $"{this.Path}\\{this.Name}.csproj";
        }
    }
}
