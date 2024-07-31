using System.ComponentModel.DataAnnotations;

namespace RecruitmentApp.Api.Requests
{
    public class CreateCompanyRequest
    {

        [MaxLength(255)]
        public string Name { get; set; } = default!;

        [MaxLength(255)]
        public string Email { get; set; } = default!;

        [MaxLength(255)]
        public string Address { get; set; } = default!;

        [MaxLength(9)]
        public string TaxId { get; set; } = default!;
    }
}
