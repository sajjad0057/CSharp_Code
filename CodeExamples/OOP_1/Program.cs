using OOP_1;

WaterBottle bottle1 = new WaterBottle();
bottle1.AddWater(300);
Console.WriteLine(bottle1.Color);

WaterBottle bottle2 = new WaterBottle("rad",2000,605);
Console.WriteLine(bottle2.Color);

Console.WriteLine("----------------------------------------------------");

DrawingBoard board1 = new DrawingBoard();
board1.BackgroundColor = "green";
Console.WriteLine(board1.BackgroundColor);


Console.WriteLine("----------------------------------------------------");

EightSideDice eightSidesDice = new EightSideDice();
eightSidesDice.Roll();
