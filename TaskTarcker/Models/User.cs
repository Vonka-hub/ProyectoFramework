using System.ComponentModel.DataAnnotations;

namespace TaskTarcker.Models
{
    public class User
    {
        [Key]
        public int user_id { get; set; }
        public string email { get; set; }
        public string password_hash { get; set; }
        public string user_name { get; set; }
        public string user_lastname { get; set; }
        public string? profile_picture { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}


