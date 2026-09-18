// For loops
for (int fIndex = 0; fIndex < 5; fIndex++ )
{
    Console.WriteLine($"For Index: {fIndex}");
}
// While loops
int wIndex = 0;
while (wIndex < 5)
{
    Console.WriteLine($"While Index: {wIndex}");
    wIndex++;
}
// Loop over collections
string[] daysArray = {"Monday",  "Tuesday", "Wednesday", "Thursday", "Friday"};

Console.WriteLine($"Days Length: {daysArray.Length}");

foreach (string day in daysArray)
{
    Console.WriteLine($"Array Day: {day}");
}
// HashSet
HashSet<string> daysSet = new();
daysSet.Add("Monday");
daysSet.Add("Tuesday");
daysSet.Add("Wednesday");
daysSet.Add("Thursday");
daysSet.Add("Friday");

foreach (string day in daysSet)
{
    Console.WriteLine($"HashSet Day: {day}");
}

// Dictionary
Dictionary<string, string> DictDays = new();
DictDays.Add("mon", "Monday");
DictDays.Add("tue", "Tuesday");
DictDays.Add("wed", "Wednesday");
DictDays.Add("thur", "Thursday");
DictDays.Add("fri", "Friday");

foreach ((string key, string value) in DictDays)
{
    Console.WriteLine($"{key} stands for {value}");
}