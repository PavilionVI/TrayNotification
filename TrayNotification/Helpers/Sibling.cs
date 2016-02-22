using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrayNotification.Helpers
{
    public class Sibling
    {
        public static Direction GetSiblingDirection(Direction direction)
        {
            switch(direction)
            {
                case Direction.Up:
                    return Direction.Down;
                case Direction.Down:
                    return Direction.Up;
                case Direction.Left:
                    return Direction.Right;
                default:
                    return Direction.Left;
            }
        }
    }
}
