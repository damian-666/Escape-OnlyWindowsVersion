The state of this code was that the game worked, car, sprites but the fluid was commented out, windows only was working with xna.

I think it was was attempted to be ported to android in later branches in Escape. I went to the Windows only one to get something I could work with.

I put back fluid, built vs monogame.

I put all the fx and content in the EXE project, trying to share it in DLL was too hard, i gave up. If you already know how to organize code that way, please do... then simpler test EXEs could run the fluid, but for now the fluid FX and all the content is in the EXE project.

So after organizing the code with content in the Escape.EXE i could play your game but w/o the gasses

Issue was with the data type, hidef is 4 packed floats, it was not working.

With one tiny change to Monogame I could get game running but fluid shader not doing anything. The change is at>>> PS in this readme...

The velocity field remains at zero, and the debug code to draw arrows does work.

The Shaders compile and seem to load.

I would suggest you add new Monogame windows project, with realtime sliders or something to adjust general pixel shaders values, was going to be my next step. If you have time, a similar new skeletal Monogame UWP project with the simplest possible pixel shader that has some UI to addjust the RGB and paint the screen with it. I'll can get it all working in UWP and android later, just keep in mind that its my goal, but for this it should not rely on any special platfrom behavior, just pure monogame and portable fx files.

Theres just too much shader stages to expect to get it working in one go, getting any similar HDRBlendable? pixel shader to work that I can use as a sanity test later.

NOTE.. monograme dev branch is currently in high flux, they are removing protobuild. If my change is agreeable I can submit PR to them later.

I was able to run protobuild and just build MG. I can provide my branch of MG if it will save you any time.

It apprears that HDRBlendable float shader data type im guessing we needed is still not supported in MG main branch.

( patch file added to this folder) added one line in Monogame.Framework\Graphics\GraphicsExtensions.cs GetSize public static int GetSize(this SurfaceFormat surfaceFormat) { switch (surfaceFormat) { ... case SurfaceFormat.HdrBlendable: //ADDED at line 817 in my branch to return 8 case SurfaceFormat.HalfVector4: case SurfaceFormat.Rgba64: case SurfaceFormat.Vector2:
return 8;

After gas works mabye with an emitter or for explosions, I 


