using Microsoft.AspNetCore.HttpLogging;
using MinimalAPI.Models;
using System.Collections.Concurrent;


var builder = WebApplication.CreateBuilder(args);

// Logging middleware
builder.Services.AddHttpLogging(logging =>
{
    logging.LoggingFields = HttpLoggingFields.RequestMethod | HttpLoggingFields.RequestPath | HttpLoggingFields.ResponseStatusCode;
});

var app = builder.Build();

app.UseHttpLogging();

// Thread-safe in-memory storage
var todos = new ConcurrentDictionary<Guid, TodoItem>();

// GET /todos
app.MapGet("/todos", () => Results.Ok(todos.Values));

// GET /todos/{id}
app.MapGet("/todos/{id:guid}", (Guid id) =>
{
    return todos.TryGetValue(id, out var todo)
        ? Results.Ok(todo)
        : Results.NotFound();
});

// POST /todos
app.MapPost("/todos", (TodoCreateRequest request) =>
{
    var item = new TodoItem(Guid.NewGuid(), request.Text, false, DateTime.UtcNow);
    todos[item.Id] = item;
    return Results.Created($"/todos/{item.Id}", item);
});

// PUT /todos/{id}
app.MapPut("/todos/{id:guid}", (Guid id, TodoUpdateRequest update) =>
{
    if (!todos.TryGetValue(id, out var existing))
        return Results.NotFound();

    var updated = existing with { Text = update.Text, IsComplete = update.IsComplete };
    todos[id] = updated;
    return Results.Ok(updated);
});

// DELETE /todos/{id}
app.MapDelete("/todos/{id:guid}", (Guid id) =>
{
    return todos.TryRemove(id, out _) ? Results.NoContent() : Results.NotFound();
});

app.Run();

record TodoCreateRequest(string Text);
record TodoUpdateRequest(string Text, bool IsComplete);
