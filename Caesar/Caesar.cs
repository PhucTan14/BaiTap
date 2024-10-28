using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar
{
    class Caesar
    {
        //public static string nguon ="aáàạảãăắằặẳẵâấầậẩẫbcdđeéèẹẻẽêếềệểễfghiíìịỉĩjklmnoóòọỏõôốồộổỗơớờợởỡpqrstuúùụủũưứừựửữvwxyAÁÀẠẢÃĂẮẰẶẲẴÂẤẦẬẨẪBCDĐEÉÈẸẺẼÊẾỀỆỂỄFGHIÍÌỊỈĨJKLMNOÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠPQRSTUÚÙỤỦŨƯỨỪỰỬỮVWXY0123456789~`!@#$%^&*()-_.:';,/?<>[]{}=+ ";
public static string nguon = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static char[] P = nguon.ToCharArray();
        public static string Mahoa(string s, int k)
        {
            int mahoa_local = 0;
            char[] vanban = s.ToCharArray();
            int l = vanban.Length;
            char[] tmp_text = new char[l];
            int[] tmp_local = new int[l];
            int j = 0;
            while (j < l)
            {
                for (int i = 0; i < P.Length; i++)
                {
                    if (P[i] == vanban[j])
                    {
                        tmp_local[j] = i;
                        mahoa_local = tmp_local[j] + k;
                        if (mahoa_local >= P.Length) mahoa_local = mahoa_local -
                        P.Length;
                        tmp_text[j] = P[mahoa_local];
                    }
                }
                j++;
            }
            return new string(tmp_text);
        }
        public static string GiaiMa(string s, int k)
        {
            int mahoa_local = 0;
            char[] vanban = s.ToCharArray();
            int l = vanban.Length;
            char[] tmp_text = new char[l];
            int[] tmp_local = new int[l];
            int j = 0;
            while (j < l)
            {
                for (int i = 0; i < P.Length; i++)
                {
                    if (P[i] == vanban[j])
                    {
                        tmp_local[j] = i;
                        mahoa_local = tmp_local[j] - k; if (mahoa_local < 0) mahoa_local = mahoa_local + P.Length;
                        tmp_text[j] = P[mahoa_local];
                    }
                }
                j++;
            }
            return new string(tmp_text);
        }
    }
}

