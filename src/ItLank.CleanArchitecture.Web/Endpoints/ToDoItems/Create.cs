﻿using Ardalis.ApiEndpoints;
using ItLank.CleanArchitecture.Core.Entities;
using ItLank.CleanArchitecture.SharedKernel.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;

namespace ItLank.CleanArchitecture.Web.Endpoints.ToDoItems
{
    public class Create : BaseAsyncEndpoint<NewToDoItemRequest, ToDoItemResponse>
    {
        private readonly IRepository _repository;

        public Create(IRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("/ToDoItems")]
        [SwaggerOperation(
            Summary = "Creates a new ToDoItem",
            Description = "Creates a new ToDoItem",
            OperationId = "ToDoItem.Create",
            Tags = new[] { "ToDoItemEndpoints" })
        ]
        public override async Task<ActionResult<ToDoItemResponse>> HandleAsync(NewToDoItemRequest request)
        {
            var item = new ToDoItem
            {
                Title = request.Title,
                Description = request.Description
            };

            var createdItem = await _repository.AddAsync(item);

            return Ok(createdItem);
        }
    }
}
