using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace firstTempEmbedding.Models
{
	public class User
	{
		public int Id { get; set; }

		public string? email { get; set; }

		public string? pass { get; set; }

		public int role_id  { get; set; }
		
		public  Role? Role { get; set; }
	}
}
