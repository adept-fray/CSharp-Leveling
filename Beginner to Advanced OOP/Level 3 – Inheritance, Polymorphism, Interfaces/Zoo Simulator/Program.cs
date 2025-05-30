Console.WriteLine("Zoo Simulator");
Console.WriteLine("Loop through list and call MakeSound() on each.");

List<Animal> list = new List<Animal>();

Elephant elephant = new Elephant();
list.Add(elephant);

Lion lion = new Lion();
list.Add(lion);

foreach(var animal in list)
{
    animal.MakeSound();
}
