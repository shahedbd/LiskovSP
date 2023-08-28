using LiskovSP;

Shape _Rectangle = new Rectangle { Width = 5, Height = 3 };
Shape _Circle = new Circle { Radius = 4 };

PrintArea(_Rectangle);
PrintArea(_Circle);


static void PrintArea(Shape _Shape)
{
    Console.WriteLine($"Area: {_Shape.CalculateArea()}");
}