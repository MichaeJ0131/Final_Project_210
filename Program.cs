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
        
            
            // add progam movers
            cast["movers"] = new List<Actor>();
            Ship ship = new Ship();
            cast["movers"].Add(ship);

            // start generating the rocks
            cast["stationary"] = new List<Actor>();
            RockGenerator generator = new RockGenerator();

            for (int i = 0; i < Constants.NUM_ROCKS; i++)
            {
                Rock rock = generator.Generate();
                cast["stationary"].Add(rock);
            }


            // make billboard
            // cast["environment"] = new List<Actor>();
            // Billboard billboard = new Billboard();
            // cast["environment"].Add(billboard);

            // Timer timer = new Timer();
            // cast["environment"].Add(timer)

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
            
            MoveActorsAction moveActorsAction = new MoveActorsAction();
            script["update"].Add(moveActorsAction);

            HandleCollisionsAction handleCollisionsAction = new HandleCollisionsAction(physicsService);
            script["update"].Add(handleCollisionsAction);

            ControlActorsAction controlActorsAction = new ControlActorsAction(inputService);
            script["input"].Add(controlActorsAction);

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
