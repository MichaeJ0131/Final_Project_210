using System;
using cse210_batter_csharp.Services;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Scripting;
using System.Collections.Generic;

namespace cse210_batter_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
        // Create the cast
        Dictionary<string, List<Actor>> cast = new Dictionary<string, List<Actor>>();

        // cast["movers"] = new List<Actor>();

        // Ship ship = new Ship();
        // cast["movers"].Add(ship);

        // MoveActorsAction moveActorsAction = new MoveActorsAction();
        // script["update"].Add(moveActorsAction);        


        // ControlActorsAction controlActorsAction = new ControlActorsAction(inputService);
        // script["input"].Add(controlActorsAction);




        // ShipGenerator generator = new ShipGenerator();

        // // for (int i = 0; i < Constants.NUM_SHIPS; i++)
        // //     {
        //         Ship ship = generator.Generate();
        //         cast["Ships"].Add(ship);
        //     // }

        // Bricks
        //     cast["Ship"] = new List<Actor>();
        //     Point position = new Point(x,y);
        //     cast["Ship"].Add(new Ship(position));
            
        // cast["Ships"] = new List<Actor>();
        // Ship ship = new Ship(new Point(400,300));
        // cast["Ships"].Add(ship);

        cast["ships"] = new List<Actor>();
        Ship ship = new Ship(new Point(400,300));
        cast["ships"].Add(ship);

        // for (int y = 5; y < Constants.MAX_Y / 2.5;
        //     y += (Constants.SHIP_HEIGHT + Constants.SHIP_SPACE))
        // {
        //     for (int x = 0; x < (Constants.MAX_X - 5);
        //         x += (Constants.SHIP_WIDTH + Constants.SHIP_SPACE))
        //     {
        //         Point position = new Point(x,y);
        //         cast["ships"].Add(new Ship(position));
        //     }
                
        // }
        
            // The Ball (or balls if desired)
            // cast["balls"] = new List<Actor>();
            // Ball ball = new Ball(new Point(700,500));
            // cast["balls"].Add(ball()

            // The paddle
            // cast["paddle"] = new List<Actor>();
            // Paddle paddle = new Paddle(new Point(700,500));

            // TODO: Add your paddle here

            // Create the script
            Dictionary<string, List<Action>> script = new Dictionary<string, List<Action>>();

            OutputService outputService = new OutputService();
            InputService inputService = new InputService();
            PhysicsService physicsService = new PhysicsService();
            // AudioService audioService = new AudioService();

            script["output"] = new List<Action>();
            script["input"] = new List<Action>();
            script["update"] = new List<Action>();

            DrawActorsAction drawActorsAction = new DrawActorsAction(outputService);
            script["output"].Add(drawActorsAction);

            // TODO: Add additional actions here to handle the input, move the actors, handle collisions, etc.

            // Start up the game
            outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, "Batter", Constants.FRAME_RATE);
            // audioService.StartAudio();
            // audioService.PlaySound(Constants.SOUND_START);

            Director theDirector = new Director(cast, script);
            theDirector.Direct();

            // audioService.StopAudio();
        }
    }
}
