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

        // Bricks
            cast["bricks"] = new List<Actor>();

        // Add Bricks Here
        // Brick brick = new Brick(new Point(10,10));
           
        //    cast["bricks"].Add(brick);
           for (int y = 5; y < Constants.MAX_Y / 2.5;
                y += (Constants.BRICK_HEIGHT + Constants.BRICK_SPACE))
            {
                for (int x = 5; x < (Constants.MAX_X - 5);
                    x += (Constants.BRICK_WIDTH + Constants.BRICK_SPACE))
                {
                    Point position = new Point(x,y);
                    cast["bricks"].Add(new Brick(position));

                }
                
            }
        
            // The Ball (or balls if desired)
            cast["balls"] = new List<Actor>();
            Ball ball = new Ball(new Point(700,500));
            // cast["balls"].Add(ball()

            // The paddle
            cast["paddle"] = new List<Actor>();
            Paddle paddle = new Paddle(new Point(700,500));

            // TODO: Add your paddle here

            // Create the script
            Dictionary<string, List<Action>> script = new Dictionary<string, List<Action>>();

            OutputService outputService = new OutputService();
            InputService inputService = new InputService();
            PhysicsService physicsService = new PhysicsService();
            AudioService audioService = new AudioService();

            script["output"] = new List<Action>();
            script["input"] = new List<Action>();
            script["update"] = new List<Action>();

            DrawActorsAction drawActorsAction = new DrawActorsAction(outputService);
            script["output"].Add(drawActorsAction);

            // TODO: Add additional actions here to handle the input, move the actors, handle collisions, etc.

            // Start up the game
            outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, "Batter", Constants.FRAME_RATE);
            audioService.StartAudio();
            audioService.PlaySound(Constants.SOUND_START);

            Director theDirector = new Director(cast, script);
            theDirector.Direct();

            audioService.StopAudio();
        }
    }
}
