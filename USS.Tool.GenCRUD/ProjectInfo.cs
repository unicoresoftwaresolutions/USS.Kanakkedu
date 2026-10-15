namespace USS.Tool.GenCRUD
{
    public class ProjectInfo
    {
        public string Name { get; set; }
        public string ProjectName { get; set; }
        public string Path { get; set; }
        public string RootPath { get; set; }
        public string File { get; set; }
        public string Namespace { get; set; }

        public ProjectInfo(string name)
        {
            this.Name = name;
            this.Namespace = SolutionInfo.Name;
            this.RootPath = SolutionInfo.Path;

            this.ProjectName = $"{SolutionInfo.Name}.{name}";
            this.Path = $"{SolutionInfo.Path}\\{this.ProjectName}";
            this.File = $"{this.Path}\\{this.ProjectName}.csproj";
        }
    }
}
