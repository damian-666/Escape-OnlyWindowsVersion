﻿using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Escape
{
    public class Game : Microsoft.Xna.Framework.Game
    {
        //------------------------------------------------------------------
        public Game()
        {
            GraphicsDeviceManager graphics = new GraphicsDeviceManager (this);
            
            graphics.PreferredBackBufferWidth = 480;
            graphics.PreferredBackBufferHeight = 800;

            graphics.SupportedOrientations = DisplayOrientation.Portrait;

            // Disable fixed framerate
            graphics.SynchronizeWithVerticalRetrace = false;
            IsFixedTimeStep = false;

            Content.RootDirectory = "Content";

            IsMouseVisible = true;

            //   graphics.GraphicsProfile = GraphicsProfile.Reach;
            graphics.GraphicsProfile = GraphicsProfile.HiDef; //for shader to compile, because it uses 16 bit floats

            //Window.SetPosition (new Point (600, 125));
        }

        //------------------------------------------------------------------
        protected override void Initialize()
        {
            Components.Add (new Traffic.Actions.Base.Manager (this));
            Components.Add (new Tools.Timers.Manager (this));
            Components.Add (new Traffic.Manager (this));
            Components.Add (new Tools.Markers.Manager (this));
            Components.Add (new Tools.Perfomance (this));

            base.Initialize();
        }

        //------------------------------------------------------------------
        protected override void Update (GameTime gameTime)
        {
            if (GamePad.GetState (PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown (Keys.Escape))
                Exit();
         

            ControlTimeScale();

            base.Update (gameTime);
        }

        //------------------------------------------------------------------
        private void ControlTimeScale()
        {
            float scale = 0.05f;

            if (Keyboard.GetState ().IsKeyDown(Keys.D1))
                Traffic.Settings.TimeScale -= scale;
            if (Keyboard.GetState ().IsKeyDown (Keys.D2))
                Traffic.Settings.TimeScale += scale;
        }

        //------------------------------------------------------------------
        protected override void Draw (GameTime gameTime)
        {
            GraphicsDevice.Clear (Color.HotPink);

            base.Draw (gameTime);
        }
    }
}