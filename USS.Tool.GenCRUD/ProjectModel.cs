using USS.Tool.GenCRUD.Templates;

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
        public string FilePath
        {
            get
            {
                if (field == null)
                {
                    field = $"{project.Path}\\Models";
                }
                return field;
            }
        }
        public string FileName
        {
            get
            {
                if(field==null)
                {
                    field = $"{FilePath}\\{Table.TableName}.cs";
                }
                return field;
            }
        }

        public string Namespace
        {
            get
            {
                if (field == null)
                {
                    field = $"{project.ProjectName}";
                }
                return field;
            }
        }

        public string ClassName
        {
            get
            {
                if (field == null)
                {
                    field = $"{Table.TableName}";
                }
                return field;
            }
        }

        public List<SQLFieldInfo> Fields
        {
            get
            {
                if (field == null)
                {
                    field = Table.Fields.Where(x=> x.Name != "Id").ToList();
                }
                foreach (var fieldType in SolutionInfo.FieldTypes.Where(x=> field.Any(f => f.DataType == x.DataType)).ToList())
                {
                    foreach (var item in field.Where(x => x.DataType == fieldType.DataType).ToList())
                    {
                        item.DataType = fieldType.FieldType;
                    }
                }
                return field;
            }
        }

        public List<SQLFieldInfo> References
        {
            get
            {
                return Fields.Where(x => x.HasForeignKey).ToList();
            }
        }

        public List<SQLTable> LookUpTables { get; set; } = new List<SQLTable>();

        public string ModelClass
        {
            get
            {
                if (field == null)
                {
                    ModelTemplate model = new ModelTemplate(this);
                    field = model.TransformText();
                }
                return field;
            }
        }

        public bool GenerateModel(bool IsOverRide = true)
        {
            if (!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }
            if (File.Exists(FileName) && !IsOverRide)
            {
                return false;
            }
            File.WriteAllText(FileName, ModelClass);
            return true;
        }
    }
}
