using System;
using System.Collections.Generic;
using System.Text;

namespace USS.Tool.GenCRUD
{
    public class ProjectModel
    {
        public static ProjectInfo project;
        public SQLTable Table { get; set; }
        public ProjectModel(SQLTable table)
        {
            this.Table = table;
        }
        public string FileName
        {
            get
            {
                if(field==null)
                {
                    field = $"{project.Path}\\{Table.TableName}.cs";
                }
                return field;
            }
        }
    }
}
