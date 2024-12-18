//№2

int[] name = {89, 2, 23, 4, 88};

Array.Sort(name);

Console.WriteLine(name[^1]);

//или


int[] name1 = {1, 230, 17, 90 };

int max = name1[0];

for(int i = 0; i < name1.Length; i++)
{
    if(name1[i] > max)
    {
        max = name1[i];
    }
}

Console.WriteLine(max);