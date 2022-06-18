int[]values={15,7,12,23,41,28,7,17,36};
Console.WriteLine("Using Break and Continue");
foreach(int val in values)
{
    if(val>=20 && val <= 29){
        continue;
    }
    Console.WriteLine ("val is currently {0}",val);
}