using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bai10
{
    internal class VanBan
    {
        public string VBan {  get; set; }

        public VanBan() {
            VBan = "";
        }
        public VanBan(string VBan)
        {
            this.VBan = VBan;
        }

        public int countHWord()
        {
            int count = 0;
            string VBanLower = VBan.ToLower();

            foreach(char ch in VBanLower)
            {
                if(ch == 'h') count++;
            }

            return count;
        }

        public string chuanHoaVBan()
        {
            string s = VBan.Trim();
            s = Regex.Replace(s, @"\s+", " ");

            return s;
        }

        public int countWord()
        {
            string s = chuanHoaVBan();
            string[] ss = s.Split(' ');

            return ss.Length;
        }
    }
}
