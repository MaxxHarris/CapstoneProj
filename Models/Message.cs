using System;
using EmployeeMessageBoardNew.Models;
using System.ComponentModel.DataAnnotations;

public class Message
{
    public int Id { get; set; }

    [Required]
    public string? Title { get; set; }

    [Required]
    public string? Content { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    // Foreign key to ApplicationUser
    public string? UserId { get; set; }
    public ApplicationUser? User { get; set; }
}
