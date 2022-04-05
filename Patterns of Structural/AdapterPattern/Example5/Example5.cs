using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Example5
{
    interface IIO
    {
        void Copy(string source, string Destination);
        void CreateFolder(string path);
        void CreateTextFile(string path);
    }

    class Buffer : IIO
    {
        public void Copy(string source, string Destination)
        {
            Console.WriteLine(source + Destination + " copy from buffer");
        }

        public void CreateFolder(string path)
        {
            Console.WriteLine(path + " yaratıldı buffer");
        }

        public void CreateTextFile(string path)
        {
            Console.WriteLine(path + " yolunda bufffer text file");
        }
    }
    class NoBuffer : IIO
    {
        public void Copy(string source, string Destination)
        {
            Console.WriteLine(source + Destination + " copy from nobuffer");

        }

        public void CreateFolder(string path)
        {
            Console.WriteLine(path + " yaratıldı nobuffer");

        }

        public void CreateTextFile(string path)
        {
            Console.WriteLine(path + " yolunda nobufffer text file");

        }
    }

    class AdapterBatch : IIO
    {
        BatchIO _batch;

        public AdapterBatch()
        {
            _batch = new BatchIO();
        }

        public void Copy(string source, string Destination)
        {
            _batch.Kopyala(source, Destination);
        }

        public void CreateFolder(string path)
        {
            _batch.KlasorOlustur(path);
        }

        public void CreateTextFile(string path)
        {
            var DosyaAdi = "yeni Dosya";
            _batch.DosyaOlustur(path, DosyaAdi);
        }
    }

    class BatchIO
    {
        public void DosyaOlustur(string dosyaYolu, string DosyaAdi)
        {
            Console.WriteLine(dosyaYolu + "batch dosya oluştu" + DosyaAdi);
        }
        public void KlasorOlustur(string dosyaYolu)
        {
            Console.WriteLine(dosyaYolu + " klasör oluştu");
        }
        public void Kopyala(string kaynak, string hedef)
        {
            Console.WriteLine(kaynak + " tan" + hedef + " e kopyalandı");
        }
    }

}
