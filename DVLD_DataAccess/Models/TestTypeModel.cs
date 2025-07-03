using System.Diagnostics.CodeAnalysis;

namespace DVLD_DataAccess.Models
{
    public class TestTypeModel
    {
        public int Id { set; get; }
        public required string Title { set; get; }
        public required string Description { set; get; }
        public float Fees { set; get; }
        [SetsRequiredMembers]
        public TestTypeModel(int id, string title, string description, float fees)
        {
            Id = id;
            Title = title;
            Description = description;
            Fees = fees;
        }
    }
}
