using System;

class Helloworld

{

static void Main()

{
#if Debug Config
    Console.Writeline ("WE ARE IN DEBUG CONFIGURATION");

#endif
 
 Console.Writeline ("Hello, world!");


}
}