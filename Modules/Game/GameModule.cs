using RockPaperScissorsAPI.Modules.Game.Services;
using RockPaperScissorsAPI.Utills;

namespace RockPaperScissorsAPI.Modules.Game
{
    public class GameModule: IModule
{
        public IServiceCollection RegisterModule(IServiceCollection services)
        {
            services.AddSingleton<IGameServices, GameServices>();
            return services;
        }

        public IEndpointRouteBuilder MapEndpoints(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapPost("/games", CreateGame);
            endpoints.MapGet("/games/{id}", GetGame);
            endpoints.MapPost("/games/{id}/join", JoinGame);
            endpoints.MapPost("/games/{id}/move", MakeMove);

            return endpoints;
        }

        internal static IResult CreateGame()
        {
            return Results.Ok();
        }

        internal static IResult GetGame()
        {
            return Results.Ok();
        }

        internal static IResult JoinGame()
        {
            return Results.Ok();
        }

        internal static IResult MakeMove()
        {
            return Results.Ok();
        }
    }
   
}
