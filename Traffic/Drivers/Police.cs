﻿using System;
using Microsoft.Xna.Framework;
using Tools.Markers;
using Traffic.Actions;

namespace Traffic.Drivers
{
    internal class Police : Driver
    {
        //------------------------------------------------------------------
        public Police (Cars.Car car) : base (car)
        {
            Velocity = 400;
            ChangeLaneSpeed = 2;

            AddInLoop (new Shrink (this));
            AddInLoop (new Overtake (this, Car.Lane.Road.Player));
            AddInLoop (new Block (this, Car.Lane.Road.Player));
        }

        //------------------------------------------------------------------
        public override void Update (float elapsed)
        {
            base.Update (elapsed);

            Debug();
        }

        //------------------------------------------------------------------
        private void Debug()
        {
//            DrawSafeZone ();
//            DrawCheckLane (Car.Lane.Left);
//            DrawCheckLane (Car.Lane.Right);

//            DrawActions ();

//            new Text (Car.Lane.ToString (), Car.Position, Color.Red, true);
        }
    }
}