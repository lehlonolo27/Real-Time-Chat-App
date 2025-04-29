using System;

namespace API.DTOs;

public class MessageRequestDto
{
   public int Id { get; set; }
   public string? SenderId { get; set; }
   public string? RecieverId { get; set; }
   public string? Content { get; set; }

   public bool IsRead { get; set; }
   public DateTime CreatedDate { get; set; }
}
