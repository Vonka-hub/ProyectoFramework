namespace TaskTarcker.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Task
    {
        [Key]
        [Column("task_id")]
        public int TaskId { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("description_task")]
        public string Description { get; set; }

        [Column("category_id")]
        public int TaskCategoryId { get; set; }

        [Column("priority_id")]
        public int PriorityId { get; set; }

        [Column("start_date")]
        public DateTime StartDate { get; set; }

        [Column("due_date")]
        public DateTime DueDate { get; set; }

        [Column("status_id")]
        public int StatusId { get; set; }

        [Column("progress")]
        public int Progress { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }

}
