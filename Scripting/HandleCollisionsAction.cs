using System.Collections.Generic;
using Raylib_cs;
using cse210_batter_csharp.Services;
using cse210_batter_csharp.Scripting;
using cse210_batter_csharp.Casting;



namespace cse210_batter_csharp.Scripting
{
    /// <summary>
    /// An action to appropriately handle any collisions in the game.
    /// </summary>
    public class HandleCollisionsAction : Action
    {
        PhysicsService _physicsService = new PhysicsService();

        public HandleCollisionsAction(PhysicsService physicsService)
        {
            _physicsService = physicsService;
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            Actor billboard = cast["environment"][0]; // There is only one
            Actor ship = cast["movers"][0]; // There is only one

            List<Actor> rocks = cast["stationary"];
            List<Actor> planets = cast["stationary1"];
            List<Actor> pizzas = cast["stationary2"];

            billboard.SetText(Constants.DEFAULT_BILLBOARD_MESSAGE);
            AudioService audioService = new AudioService();

            foreach (Actor actor in rocks)
            {
                Rock rock = (Rock)actor;
                if (_physicsService.IsCollision(ship, rock))
                {
                    // Raylib_cs.Raylib.WindowShouldClose();
                    audioService.PlaySound(Constants.SOUND_OVER);
                    Raylib_cs.Raylib.CloseWindow();
                    Raylib.EndDrawing();
                    break;

                }
            }
            
            foreach (Actor actor in planets)
            {  
                Planet planet = (Planet)actor;
                if (_physicsService.IsCollision(ship, planet))
                {
                    audioService.PlaySound(Constants.SOUND_OVER);
                    // audioService.PlaySound(Constants.PLANETC);
                    Raylib_cs.Raylib.CloseWindow();
                    Raylib.EndDrawing();
                    break;     
                        
                }
            }
            foreach (Actor actor in pizzas)
            {  
                Pizza pizza = (Pizza)actor;
                if (_physicsService.IsCollision(ship, pizza))
                {
                    audioService.PlaySound(Constants.GOOD);
                    Raylib_cs.Raylib.CloseWindow();
                    Raylib.EndDrawing();
                    break;

                    

                }

            }           
            
        }

    }
}