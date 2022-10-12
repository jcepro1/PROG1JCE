using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENPRO1SIVECTORES
{
    class vector
    {
        const int MAX = 100;
        private int[] v;
        private int n;
        public vector()
        {
            n = 0;
            v = new int[MAX];
        }


        //public void cargardato(int nele)
        //{
        //    n = nele;//JCE
        //    int num = n;
        //    for (int i = 1; i <= num; i = checked(i + 1))
        //    {//JCE
        //        v[i] = Conversions.ToInteger(Interaction.InputBox("ingrese elemento", "elemento"));
        //    }
        //}



        public void Cargar_rnd(int n1, int a, int b)
        {
            Random r;
            r = new Random();
            int i;
            n = n1;
            for (i = 1; i <= n; i++)
            {
                v[i] = r.Next(a, b);
            }

        }


        public string descargar()
        {
            string s;
            int i;
            s = "";
            for (i = 1; i <= n; i++)
            {
                s = s + v[i] + "  |  ";
            }
            return s;
        }
        //
        public int Elem_Masfrec_seg(int a, int b)
        {
            int i = a;
            int fr = Frecuencia(v[i]);
            int ele = v[i];
            i = a;
            while (true)
            {
                int num = i;
                int num2 = b;
                if (num > num2)
                {
                    break;
                }
                //if (Frecuencia(v[i]) > fr)
                    if (Frecuencia(v[i]) < fr)
                    {
                    fr = Frecuencia(v[i]);
                    ele = v[i];
                }
                i = checked(i + 1);
            }
            return ele;
        }

        //


        public int Frecuencia(int ele)
        {
            int num = n;
            int i = 1;
            checked
            {
                int fr = default(int);
                while (true)
                {
                    int num2 = i;
                    int num3 = num;
                    if (num2 > num3)
                    {
                        break;
                    }
                    if (ele == v[i])
                    {
                        fr++;
                    }
                    i++;
                }
                return fr;
            }
        }

        public int frecuenciaAB(int ele, int a, int b)
        {
            int c = 0;
            int i = a;
            checked
            {
                while (true)
                {
                    int num = i;
                    int num2 = b;
                    if (num > num2)
                    {
                        break;
                    }
                    if (v[i] == ele)
                    {
                        c++;
                    }
                    i++;
                }
                return c;
            }
        }






    }
}
