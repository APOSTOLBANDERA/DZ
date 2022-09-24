using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class FileALALA
    {
        public string Name { get; set; }
        public string Extension { get; set; }
        public int Size { get; set; }
        public DateTime Date { get; set; }


        public FileALALA(string name, string extension, int size, DateTime date)
        {
            Name = name;
            Extension = extension;
            Size = size;
            Date = date;
        }


        public string NextSize()
        {
            string[] arr = new string[5] { "b", "kb", "mb", "gb", "tb" };
            int i;
            for (i = 0; Size > 1024;)
            {
                i++;
                Size = Size / 1024;
            }
            return ($"{Size} {arr[i]}");
        }

        public override string ToString()
        {
            return $"Name:{Name}, Extension:{Extension}, Size:{Size}, Date:{Date}";
        }
    }
}

