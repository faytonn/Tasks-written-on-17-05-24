using _24_06;

MyList list = new MyList();

list.Add(48723);
list.Add(23487);
list.Add(34324);




foreach (var item in list)
{
    Console.WriteLine(item);
}
    Console.WriteLine(list.Contains(48723));