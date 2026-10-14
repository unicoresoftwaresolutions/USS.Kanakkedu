using System;
using System.Collections.Generic;
using System.Text;

namespace USS.Tool.GenCRUD
{
    public static class SolutionInfo
    {
        public static string Name { get; set; } = SQLProj.RootNamespace;
        public static string Path { get; set; } = SQLProj.ParentDir;
        public static string File { get; set; }
        public static List<ProjectInfo> Projects 
        {
            get
            { 
                if(field== null)
                {
                    field = new List<ProjectInfo>();
                    field.Add(new ProjectInfo(ProjectNames.Model));
                    field.Add(new ProjectInfo(ProjectNames.DataInterface));
                    field.Add(new ProjectInfo(ProjectNames.Data));
                    field.Add(new ProjectInfo(ProjectNames.BusinessInterface));
                    field.Add(new ProjectInfo(ProjectNames.Business));
                    field.Add(new ProjectInfo(ProjectNames.ApiService));
                    field.Add(new ProjectInfo(ProjectNames.Service));
                    field.Add(new ProjectInfo(ProjectNames.Web));
                }
                return field;
            }
        } 

        public static List<ProjectModel> ProjectModels
        {
            get
            {
                if (field == null)
                {
                    ProjectModel.project = Projects.FirstOrDefault(x=> x.Name==ProjectNames.Model);
                    field = new List<ProjectModel>();
                    SQLProj.tables.ForEach(table =>
                    {
                        field.Add(new ProjectModel(table));
                    });                    
                }
                return field;
            }
        }
    }
}
