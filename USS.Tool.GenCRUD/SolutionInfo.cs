using System;
using System.Collections.Generic;
using System.Text;

namespace USS.Tool.GenCRUD
{
    public class SolutionInfo
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string File { get; set; }
        public List<ProjectInfo> Projects 
        {
            get
            {                
                return field ??= ProjectNames.Select(x => new ProjectInfo($"{Name}.{x}", SQLProj.ParentDir, x)).ToList();
            }
        } 

        private List<string> ProjectNames { get; set; } = new List<string>() { "Model", "Data.Interface","Data", "Business.Interface", "Business" , "Service", "ApiService", "Web" };

        public SolutionInfo(string Name)
        {
            this.Name = Name;
        }
    }
}
