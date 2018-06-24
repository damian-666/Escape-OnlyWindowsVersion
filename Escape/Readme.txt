


Notes:


temp issue, only builds and runs wht mg and mg windowsdx.

issue building content.  must manuallly build the content with the MG tool GUI each fx build.

TODO CHECK DROID SHADER BASICS IN MONOGAME investing in this be sure it all works for droind.
sure it can be modified.

android might not have the float render for pixels.   //TODO before investing much, vertify if shader like this can work with droid.
//not sure if additive hdr blending is needed.

in sharpdx, teh hrdBlendable is a 4 16bit floats, that 

not sure if half vector is 32 bit float or 16

in Vector4 its for floats

see the cg fluid code for other gpu ways..



comments by the 
 return SharpDX.DXGI.Format.R16G16B16A16_Float;



In Fluid/Unit.cs:

> @@ -20,7 +20,7 @@ abstract public class Unit
      
case SurfaceFormat.HdrBlendable:
    // TODO: This needs to check the graphics device and
    // return the best hdr blendable format for the device.
    return SharpDX.DXGI.Format.R16G16B16A16_Float;
I realized just now the development was made with NVidia GeForce 750 Ti videocard
But a problem occured with it so I pulled out the videocard from my PC and use Intel integrated graphics now
Maybe it can be a reason for HdrBlendable crash

I suggest to verify if your videocard supports required format Float 16 bits per channel
As I know there are many restrictions with float format for GPU. Such restriction was a reason why I couldn't laucnh it on Android
