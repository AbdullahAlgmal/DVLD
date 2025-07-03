using System.Diagnostics.CodeAnalysis;

namespace DVLD_DataAccess.Models
{
    public class ApplicationTypeModel
    {
        public int Id { set; get; }
        public required string Title { set; get; }
        public decimal Fees { set; get; }
        [SetsRequiredMembers]
        public ApplicationTypeModel(int id, string title, decimal fees)
        {
            Id = id;
            Title = title;
            Fees = fees;
        }
    }
}
