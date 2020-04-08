using System;

namespace Class1
{

    public static class ArrayHelper{
        public static int Pop(ref int[] a){
            var endElement = a[a.Length-1];
            var tmp = new System.Collections.Generic.List<int>(a);
            tmp.RemoveAt(tmp.Count-1);
            var newArr = tmp.ToArray();
            a = newArr;
            return endElement;
        }
        public static string Pop(ref string[] s){
            var endElement = s[s.Length-1];
            var tmp = new System.Collections.Generic.List<string>(s);
            tmp.RemoveAt(tmp.Count-1);
            var newArr = tmp.ToArray();
            s = newArr;
            return endElement;
        }
        public static double Pop(ref double[] d){
            var endElement = d[d.Length-1];
            var tmp = new System.Collections.Generic.List<double>(d);
            tmp.RemoveAt(tmp.Count-1);
            var newArr = tmp.ToArray();
            d = newArr;
            return endElement;
        }
        public static decimal Pop(ref decimal[] de){
            var endElement = de[de.Length-1];
            var tmp = new System.Collections.Generic.List<decimal>(de);
            tmp.RemoveAt(tmp.Count-1);
            var newArr = tmp.ToArray();
            de = newArr;
            return endElement;
        }
        public static float Pop(ref float[] f){
            var endElement = f[f.Length-1];
            var tmp = new System.Collections.Generic.List<float>(f);
            tmp.RemoveAt(tmp.Count-1);
            var newArr = tmp.ToArray();
            f = newArr;
            return endElement;
        }
        public static int Push(ref int[] i, int newElement){
             var sizeArray = i.Length;
             int[] newArr = new int[i.Length+1];
             for (int a = 0; a < i.Length; a++)
             {
                 newArr[a] = i[a];
             }
             newArr[newArr.Length-1] = newElement;
             i = newArr;
             return ++sizeArray;

        }
        public static int Push(ref string[] s, string newElement){
             var sizeArray = s.Length;
             string[] newArr = new string[s.Length+1];
             for (int a = 0; a < s.Length; a++)
             {
                 newArr[a] = s[a];
             }
             newArr[newArr.Length-1] = newElement;
             s = newArr;
             return ++sizeArray;

        }
    }
}
