using ValueAndReferenceTypes;

var p1 = new ReferenceType()
{
    X = 1,
    Y = 2
};
var p2 = p1;

p2.X = 30;
Console.WriteLine($"{p1.X} {p1.Y}");
Console.WriteLine($"{p2.X} {p2.Y}");

var c1 = new ValueAndReferenceTypes.ValueType()
{
    X = 1,
    Y = 2
};
var c2 = c1;
c2.X = 10;

Console.WriteLine($"{c1.X} {c1.Y}");
Console.WriteLine($"{c2.X} {c2.Y}");