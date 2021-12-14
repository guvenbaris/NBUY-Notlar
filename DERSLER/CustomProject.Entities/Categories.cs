using System;
using CustomProject.Common;

namespace CustomProject.Entities
{
    [Table(PrimaryColumn = "CategoryID",TableName = "Categories",IdentityColum = "CategoryID")]
    public class Categories
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
    }
}
