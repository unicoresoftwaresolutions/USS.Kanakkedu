namespace USS.Tool.GenCRUD
{
    public class ProjectInfo
    {
        public string Name { get; set; }
        public string ProjectName { get; set; }
        public string Path { get; set; }
        public string File { get; set; }

        public ProjectInfo(string name)
        {
            this.Name = name;
            this.ProjectName = $"{SolutionInfo.Name}.{name}";
            this.Path = $"{SolutionInfo.Path}\\{this.ProjectName}";
            this.File = $"{this.Path}\\{this.ProjectName}.csproj";
        }
    }
}
