namespace USS.Tool.GenCRUD
{
    public class ProjectInfo
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string File { get; set; }

        public ProjectInfo(string name, string path, string file)
        {
            this.Name = name;
            this.Path = path;
            this.File = file;
        }
    }
}
