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
                if(field== null)
                {
                    field = new List<ProjectInfo>();
                    field.Add(new ProjectInfo(this, ProjectNames.Model));
                    field.Add(new ProjectInfo(this, ProjectNames.DataInterface));
                    field.Add(new ProjectInfo(this, ProjectNames.Data));
                    field.Add(new ProjectInfo(this, ProjectNames.BusinessInterface));
                    field.Add(new ProjectInfo(this, ProjectNames.Business));
                    field.Add(new ProjectInfo(this, ProjectNames.ApiService));
                    field.Add(new ProjectInfo(this, ProjectNames.Service));
                    field.Add(new ProjectInfo(this, ProjectNames.Web));
                    
                }
                return field;
            }
        } 

        

        public SolutionInfo(string Name)
        {
            this.Name = Name;
            this.Path = $"{SQLProj.ParentDir}";
        }
    }
}
