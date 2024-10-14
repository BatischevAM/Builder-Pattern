using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_pattern
{
    public class ComputerBuilder
    {
        private Computer _computer;

        public ComputerBuilder()
        {
            _computer = new Computer();
        }

        public ComputerBuilder SetCPU(Processor cpu)
        {
            _computer.CPU = cpu;
            return this;
        }

        public ComputerBuilder SetMotherboard(Motherboard motherboard)
        {
            _computer.Motherboard = motherboard;
            return this;
        }

        public ComputerBuilder SetRAM(RAM ram)
        {
            _computer.RAM = ram;
            return this;
        }

        public ComputerBuilder SetStorage(Storage storage)
        {
            _computer.Storage = storage;
            return this;
        }
        public ComputerBuilder SetStorage2(Storage2 storage)
        {
            _computer.Storage2 = storage;
            return this;
        }
        public ComputerBuilder SetVideoCard(Videocard videoCard)
        {
            _computer.VideoCard = videoCard;
            return this;
        }

        public Computer Build()
        {
            return _computer;
        }
    }
}
