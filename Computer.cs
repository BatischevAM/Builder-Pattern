using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_pattern
{
    public class Computer
    {
        public Processor CPU { get; set; }
        public Motherboard Motherboard { get; set; }
        public RAM RAM { get; set; }
        public Storage Storage { get; set; }
        public Storage2 Storage2 { get; set; }
        public Videocard VideoCard { get; set; }

        public override string ToString()
        {
            return $"Характеристики компьютера:\n" +
                   $"CPU: {CPU}\n" +
                   $"Motherboard: {Motherboard}\n" +
                   $"RAM: {RAM}\n" +
                   $"Storage: {Storage}\n" +
                   $"Storage: {Storage2}\n" +
                   $"Video Card: {VideoCard}";
        }
    }
}
