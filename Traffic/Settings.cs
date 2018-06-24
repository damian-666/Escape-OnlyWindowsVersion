﻿namespace Traffic
{
    public static class Settings
    {
        // Cars Generation
        public static bool NoCars;
        public static bool NoPolice;
        public static bool NoBlocks;
        public const int MaximumCarsOnLane = 4;
        public const int PoliceStartPosition = -300;

        // Player
        public static bool NoPlayerAdjustSpeed;

        //Traffic
        public static float TimeScale = 1.0f;
//        public static float TimeScale = 0.2f;
        public static bool NoChangeLaneAnimation;
        public static bool NoChangeLaneEvents;

        // Debug
        public static bool NoMarkersClear;


        //------------------------------------------------------------------
        static Settings()
        {
//            NoCars = true;
//            NoPolice = true;
            NoBlocks = true;

//            NoChangeLaneAnimation = true;
//            NoChangeLaneEvents = true;

            NoPlayerAdjustSpeed = true;

//            NoMarkersClear = true;
        }
    }
}