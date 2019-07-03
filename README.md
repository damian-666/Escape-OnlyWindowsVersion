# Escape-OnlyWindowsVersion


The state of this code was that the game worked but the fluid was commented out,  windows only was working with xna.

it was ported to android later branches.

Put back fluid, built vs monogame.

Issue with the data type, hidef is 4 packed floats, its not working.

With one tiny change to Monogame I could get game running but fluid shader not doing anything.

The velocity field remains at zero, and the debug code to draw arrows does work.

The Shaders compile and seem to load.

Some tests with realtime sliders or something to adjust general pixel shaders values was going to be my next step.

Theres just too much shader stages to expect to get it working in one go, getting any pixel shader to work would progress...


Ill provide suggested PR for monogame and dont mind buiding it.


NOTE.. monograme dev branch is currently in high flux, they are removing protobuild.

I was able to run protobuild and just build MG.  I can provide my branch of MG if it will save you any time.

It apprears the float shader data type is still not fixed in MG main branch.









