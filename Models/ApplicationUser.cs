using Microsoft.AspNetCore.Identity;

namespace EmployeeMessageBoardNew.Models  
{
    public class ApplicationUser : IdentityUser
    {
        
        public string? DisplayName { get; set; }
        public DateTime RegisteredAt { get; set; } = DateTime.UtcNow;
    }
}
