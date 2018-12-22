﻿using ECS.Interfaces;

namespace Game.Components
{
    public class InputComponent : IComponent
    {
        public bool Forward;
        public bool Backward;
        public bool Left;
        public bool Right;
        public bool LeftMouse;
        public bool RightMouse;
    }
}
