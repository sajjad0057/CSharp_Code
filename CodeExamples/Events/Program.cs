﻿using Events;

Switch switch1 = new Switch();

switch1.On += Switch1_On;
switch1.Off += Switch1_Off;



void Switch1_On()
{
    Console.WriteLine("Switch being off Now");
}
void Switch1_Off()
{
    Console.WriteLine("Switch being On Now");
}


switch1.Toggle();
switch1.Toggle();
switch1.Toggle();

