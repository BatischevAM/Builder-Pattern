using Builder_pattern;

public class Program
{
    public static void Main(string[] args)
    {
        Processor cpu = new Processor { Model = "13th Gen Intel(R) Core(TM) i5 13600KF", Cores = 14 };
        Motherboard motherboard = new Motherboard { Model = "GIGABYTE B760M DS#H AX DDR4" };
        RAM ram = new RAM { Size = "32GB" };
        Storage storage1 = new Storage { Type = "HDD", Size = "4TB" };
        Storage2 storage2 = new Storage2 { Type = "SSD", Size = "1TB" };
        Videocard videoCard = new Videocard { Model = "NVIDIA GeForce RTX 4060 Ti" };

        ComputerBuilder builder = new ComputerBuilder();
        Computer myComputer = builder.SetCPU(cpu)
            .SetMotherboard(motherboard)
            .SetRAM(ram)
            .SetStorage(storage1)
            .SetStorage2(storage2)
            .SetVideoCard(videoCard)
            .Build();
        Console.WriteLine(myComputer);
    }
}
