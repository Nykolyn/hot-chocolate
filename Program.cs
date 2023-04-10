var builder = WebApplication.CreateBuilder(args);

// services
builder.Services.AddGraphQLServer().AddQueryType<Query>().AddMutationType<Mutation>();

var app = builder.Build();

app.MapGraphQL();

app.Run();
