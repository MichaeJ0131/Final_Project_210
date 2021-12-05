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
            // Actor billboard = cast["environment"][0]; // There is only one
            Actor ship = cast["movers"][0]; // There is only one

            List<Actor> rocks = cast["stationary"]; // Get all the artifacts

            // billboard.SetText(Constants.DEFAULT_BILLBOARD_MESSAGE);

            foreach (Actor actor in rocks)
            {
                Rock rock = (Rock)actor;
                if (_physicsService.IsCollision(ship, rock))
                {
                    // Raylib_cs.Raylib.WindowShouldClose();
                    Raylib_cs.Raylib.CloseWindow();
                    Raylib.EndDrawing();

                }
            }
        }

    }
}
























































// {
//     /// <summary>
//     /// An action to move all actors forward according to their current velocities.
//     /// </summary>
//     public class handleCollisionsAction : Action
//     {

//         public override void Execute(Dictionary<string, List<Actor>> cast)
//         {
//             foreach (List<Actor> group in cast.Values)
//             {
//                 foreach (Actor actor in group)
//                 {
//                     MoveActor(actor);

//                 }
//             }
//         }
        
//         private void MoveActor(Actor actor)
//         {
//             int x = actor.GetX();
//             int y = actor.GetY();

//             int dx = actor.GetVelocity().GetX();
//             int dy = actor.GetVelocity().GetY();

//             int newX = (x + dx) % Constants.MAX_X;
//             int newY = (y + dy) % Constants.MAX_Y;

//             if (newX < 0)
//             {
//                 newX = Constants.MAX_X;
//             }

//             if (newY < 0)
//             {
//                 newY = Constants.MAX_Y;
//             }

//             actor.SetPosition(new Point(newX, newY));
//         }

//     }
// }