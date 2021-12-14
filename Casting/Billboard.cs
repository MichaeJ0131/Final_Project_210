
using System;
using Raylib_cs;
using cse210_batter_csharp.Casting;

namespace cse210_batter_csharp.Casting
{
    /// <summary>
    /// Defines the Billboard that displays the description of the artifacts.
    /// </summary>
    public class Billboard : Actor
    {
        public Billboard()
        {
            SetText(Constants.DEFAULT_BILLBOARD_MESSAGE);

            Point position = new Point(0, 0);
            SetPosition(position);
        }
    }
}

// {
//     /// <summary>
//     /// Defines the Billboard that displays the description of the artifacts.
//     /// </summary>
//     public class Timer : Actor
//     {
//         public Timer()
//         {
//             SetText(Constants.DEFAULT_BILLBOARD_MESSAGE);

//             Point position = new Point(0, 0);
//             SetPosition(position);

//             SetWidth(Constants.TIMER_WIDTH);
//             SetHeight(Constants.TIMER_HEIGHT);
           
//         }
//     }
// }