using LaptopRCS.Laptop.Enum;
using LaptopRCS.Laptop.Iterfeys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopRCS.Laptop
{
    internal record LaptopR : ILaptop
    {
        private string model;
        public string Model
        {
            get { return model; }
            init { model = value; }
        }

        private string display;
        public string Display
        {
            get { return display; }
            init { display = value; }
        }

        private string cpu;
        public string CPU
        {
            get { return cpu; }
            init { cpu = value; }
        }

        private string videoAdapter;
        public string VideoAdapter
        {
            get { return videoAdapter; }
            init { videoAdapter = value; }
        }

        private byte ram;
        public byte Ram
        {
            get { return ram; }
            init { ram = value; }
        }

        private ushort ssd;
        public ushort SSD
        {
            get { return ssd; }
            set { ssd = value; }
        }

        private ushort hdd;
        public ushort HDD
        {
            get { return hdd; }
            set { hdd = value; }
        }

        private Colors color;
        public Colors Color
        {
            get { return color; }
            init { color = value; }
        }

        public string on()
        {
            return $"               {model}\n           W e l c o m e";
        }

        public string off()
        {
            return $"{model}:    Shutting down";
        }

        public string restart()
        {
            return $"{model}:    Restarting";
        }

        public override string ToString()
        {
            string h = hdd == 0 ? "No" : $"{hdd}GB";
            string s = ssd == 0 ? "No" : $"{ssd}GB";
            return $"->{model}\n->Ekran: {display}\n->Prosessor: {cpu}\n->Videokarta:{videoAdapter}\n->Operativka: {ram}GB" +
                $"\n->HDD: {h}\n->SSD: {s}\n->Rangi: {color}";
        }
    }
}
