using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar
{
    class Vigenere
    {
        public static string nguon = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static char[] P = nguon.ToCharArray();
        public static int[] taokhoa(string vao, int[] key)//tạo khóa có chiều dài bằn chiều dài văn bản
        {
            char[] vanban = vao.ToCharArray();
            int l = vanban.Length;
            int[] plant = new int[l];
            int j = 0;
            for (int i = 0; i < l; i++)
            {
                if (j > key.Length - 1) j = 0;
                plant[i] = key[j];
                j++;
            }
            return plant;
        }
        public static int[] chuyenmakey(string s)//Tìm vị trí thứ tự của chữ cái
        {
            char[] vanban = s.ToCharArray();
            int l = vanban.Length;
            int[] tmp_local = new int[l];
            int j = 0;
            while (j < l)
            {
                for (int i = 0; i < P.Length; i++)
                {
                    if (P[i] == vanban[j])
                    {
                        tmp_local[j] = i;
                    }
                }
                j++;
            }
            return tmp_local;
        }
        public static string Mahoa(string s, int[] khoa)
        {
            char[] vanban = s.ToCharArray();
            int l = vanban.Length;
            int[] tmp_local = new int[l];
            char[] temp = new char[l];
            int maso;
            for (int j = 0; j < l; j++)
            {
                for (int i = 0; i < P.Length; i++)
                {
                    if (P[i] == vanban[j])
                    {
                        tmp_local[j] = i;
                        maso = (tmp_local[j] + khoa[j]) % P.Length;
                        temp[j] = P[maso];
                    }
                }
            }
            return new string(temp);
        }
        public static string Giaima(string s, int[] khoa)
        {
            char[] vanban = s.ToCharArray();
            int l = vanban.Length;
            int[] tmp_local = new int[l];
            char[] temp = new char[l];
            int maso;
            for (int j = 0; j < l; j++)
            {
                for (int i = 0; i < P.Length; i++)
                {
                    if (P[i] == vanban[j])
                    {
                        tmp_local[j] = i;
                        maso = ((tmp_local[j] + P.Length) - khoa[j]) % P.Length;
                        temp[j] = P[maso];
                    }
                }
            }
            return new string(temp);
        }
    }
}

