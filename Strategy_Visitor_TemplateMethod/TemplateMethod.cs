abstract public class HouseBuilder
{
    abstract public void BuildWalls(int wallCount);
    abstract public void BuildWindows();
    abstract public void BuildRoof();

    public void CreatePool()
    { }

    public void CreateNewFloor()
    { }

    public void CreateCleverHomeSystem()
    { }
}

public class MainYasayisKompleksi : HouseBuilder
{
    public override void BuildRoof()
    {
        Console.WriteLine($"Roof Created");
    }

    public override void BuildWalls(int wallCount)
    {
        Console.WriteLine($"{wallCount} walls created");
    }

    public override void BuildWindows()
    {
        Console.WriteLine($"Windows created");
    }

    public MainYasayisKompleksi()
    {
        BuildRoof();
        BuildWalls(4);
        BuildWindows();
    }
}

public class SaglamHeyat : HouseBuilder
{
    public override void BuildRoof()
    {
        Console.WriteLine($"Roof Created");
    }

    public override void BuildWalls(int wallCount)
    {
        Console.WriteLine($"{wallCount} walls created");
    }
    public override void BuildWindows()
    {
        Console.WriteLine($"Windows created");
    }

    public void CreatePool()
    {
        Console.WriteLine("Pool Created!");
    }

    public SaglamHeyat()
    {
        BuildRoof();
        BuildWalls(4);
        BuildWindows();
        CreatePool();
    }
}

public class VarliHeyatTerziKompleks : HouseBuilder
{
    public override void BuildRoof()
    {
        Console.WriteLine($"Roof Created");
    }

    public override void BuildWalls(int wallCount)
    {
        Console.WriteLine($"{wallCount} walls created");
    }
    public override void BuildWindows()
    {
        Console.WriteLine($"Windows created");
    }

    public void CreatePool()
    {
        Console.WriteLine("Pool Created!");
    }

    public void CreateCleverHomeSystem()
    {
        Console.WriteLine("Clever System Added!");
    }


    public VarliHeyatTerziKompleks()
    {
        BuildRoof();
        BuildWalls(4);
        BuildWindows();
        CreatePool();
        CreateCleverHomeSystem();
    }
}


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("------- Saglam Heyat ------");
        SaglamHeyat house1 = new();
        Console.WriteLine("------- Main Yasayis Kompleksi ------");
        MainYasayisKompleksi house2 = new();
        Console.WriteLine("------- Varli Heyat Terzi Kompleksi ------");
        VarliHeyatTerziKompleks house3 = new();
    }
}


