namespace POS.Domain.Entities
{
    public partial class UsersBranchOffice
    {
        public int UserBranchOfficeId { get; set; }
        public int? BranchOfficeId { get; set; }
        public int? UserId { get; set; }
        public int? State { get; set; }

        public virtual BranchOffice? BranchOffices { get; set; }
        public virtual UsersBranchOffice? UsersBranchOffices { get; set; }
        public virtual User? User { get; set; }
    }
}
