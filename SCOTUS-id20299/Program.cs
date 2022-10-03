using SCOTUS_id20299;

var builder = WebApplication.CreateBuilder(args);
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

var chatSession = new ChatSession();

var app = builder.Build();
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHttpsRedirection();

    app.MapGet("/Messages", () => chatSession.Messages);
    app.MapPost("/Messages", (string name, string body) => chatSession.Messages.Add(new Message(name, body)));
    app.MapDelete("/Messages", () => chatSession.Messages = new List<Message>());
    app.MapGet("/", () => "This is cool");
    app.Run();

 