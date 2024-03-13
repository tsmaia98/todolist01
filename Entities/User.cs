using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Entities
{
    public class User
    {
        public User() { 
            this.TodoTasks = new List<TodoTask>();
        }
        [Key]
        [JsonPropertyName("Id")]
        public int Id { get; set; }
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        [JsonPropertyName("Email")]
        public string Email { get; set; }
        [JsonPropertyName("Password")]
        public string Password { get; set; }

        public ICollection<TodoTask> TodoTasks { get; set; }
    }
}
