﻿using ForceGetCase.Application.Models;
using ForceGetCase.Application.Models.TodoItem;

namespace ForceGetCase.Application.Services;

public interface ITodoItemService
{
    Task<CreateTodoItemResponseModel> CreateAsync(CreateTodoItemModel createTodoItemModel,
        CancellationToken cancellationToken = default);

    Task<BaseResponseModel> DeleteAsync(Guid id, CancellationToken cancellationToken = default);

    Task<IEnumerable<TodoItemResponseModel>>
        GetAllByListIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task<UpdateTodoItemResponseModel> UpdateAsync(Guid id, UpdateTodoItemModel updateTodoItemModel,
        CancellationToken cancellationToken = default);
}
