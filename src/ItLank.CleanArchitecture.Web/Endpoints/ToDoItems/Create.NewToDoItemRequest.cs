﻿using System.ComponentModel.DataAnnotations;

namespace ItLank.CleanArchitecture.Web.Endpoints.ToDoItems
{
    public class NewToDoItemRequest
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}