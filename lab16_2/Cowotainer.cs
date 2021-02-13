using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab16_2
{
    class Cowotainer : HashSet<int>
    {
        public Cowotainer(int n)
        {
            for (int i = 0; i < n; i++)
            {
                this.Add(int.Parse(Console.ReadLine()));
            }
        }

        public Cowotainer(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    try
                    {
                        this.Add(int.Parse(line));
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }

        public Cowotainer(int n, int m)
        {
            Random random = new Random(DateTime.Today.Millisecond);
            for (int i = 0; i < n; i++)
            {
                this.Add(random.Next(1, m));
            }
        }

        public override string ToString()
        {
            string str = "";
            foreach (var item in this)
            {
                str += (item + " ");
            }
            return str;
        }

        public int this[int index]
        {
            get 
            {
                
                int i = 0;
                foreach (var item in this)
                {
                    i++;
                    if (i == index)
                    {
                        return item;
                    }
                }
                return 0;
            }
            
        }
        
        public static Cowotainer operator +(Cowotainer cowo,int n)
        {
            Random random = new Random(DateTime.Today.Millisecond);
            n += 2;
            for (int i = 0; i < n; i++)
            {
                cowo.Add(random.Next(100));
            }
            return cowo;
        }
        
        public int Length { get { return this.Count; } }
    }
}
