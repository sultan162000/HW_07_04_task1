using System;

namespace Class1
{

    public static class ArrayHelper{

        /////////////////// Метод Pop
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

        /////////////////// Метод Push
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
        public static int Push(ref double[] d, double newElement){
             var sizeArray = d.Length;
             double[] newArr = new double[d.Length+1];
             for (int a = 0; a < d.Length; a++)
             {
                 newArr[a] = d[a];
             }
             newArr[newArr.Length-1] = newElement;
             d = newArr;
             return ++sizeArray;

        }
        public static int Push(ref decimal[] de, decimal newElement){
             var sizeArray = de.Length;
             decimal[] newArr = new decimal[de.Length+1];
             for (int a = 0; a < de.Length; a++)
             {
                 newArr[a] = de[a];
             }
             newArr[newArr.Length-1] = newElement;
             de = newArr;
             return ++sizeArray;

        }
        public static int Push(ref float[] f, float newElement){
             var sizeArray = f.Length;
             float[] newArr = new float[f.Length+1];
             for (int a = 0; a < f.Length; a++)
             {
                 newArr[a] = f[a];
             }
             newArr[newArr.Length-1] = newElement;
             f = newArr;
             return ++sizeArray;

        }
        /////////////////// Метод Shift
        public static int Shift(ref int[] i){
            var firstElement = i[0];
            var tmp = new System.Collections.Generic.List<int>(i);
            tmp.RemoveAt(0);
            var newArr = tmp.ToArray();
            i = newArr;
            return firstElement;
        }
        
        public static string Shift(ref string[] s){
            var firstElement = s[0];
            var tmp = new System.Collections.Generic.List<String>(s);
            tmp.RemoveAt(0);
            var newArr = tmp.ToArray();
            s = newArr;
            return firstElement;
        }

        public static double Shift(ref double[] d){
            var firstElement = d[0];
            var tmp = new System.Collections.Generic.List<double>(d);
            tmp.RemoveAt(0);
            var newArr = tmp.ToArray();
            d = newArr;
            return firstElement;
        }

        public static decimal Shift(ref decimal[] de){
            var firstElement = de[0];
            var tmp = new System.Collections.Generic.List<decimal>(de);
            tmp.RemoveAt(0);
            var newArr = tmp.ToArray();
            de = newArr;
            return firstElement;
        }

        public static float Shift(ref float[] f){
            var firstElement = f[0];
            var tmp = new System.Collections.Generic.List<float>(f);
            tmp.RemoveAt(0);
            var newArr = tmp.ToArray();
            f = newArr;
            return firstElement;
        }

        //////////////////Метод Unshift

        public static int UnShift(ref int[] i, int newElement){
            var sizeArray = i.Length;
            int[] newArr = new int[i.Length+1];
            newArr[0] = newElement;
            for (int a = 0; a < i.Length; a++)
            {
                newArr[a+1]=i[a];
            }
            i = newArr;
            return ++sizeArray;
        }
        
        public static int UnShift(ref string[] i, string newElement){
            var sizeArray = i.Length;
            string[] newArr = new string[i.Length+1];
            newArr[0] = newElement;
            for (int a = 0; a < i.Length; a++)
            {
                newArr[a+1]=i[a];
            }
            i = newArr;
            return ++sizeArray;
        }
        public static int UnShift(ref double[] i, double newElement){
            var sizeArray = i.Length;
            double[] newArr = new double[i.Length+1];
            newArr[0] = newElement;
            for (int a = 0; a < i.Length; a++)
            {
                newArr[a+1]=i[a];
            }
            i = newArr;
            return ++sizeArray;
        }
        public static int UnShift(ref decimal[] i, decimal newElement){
            var sizeArray = i.Length;
            decimal[] newArr = new decimal[i.Length+1];
            newArr[0] = newElement;
            for (int a = 0; a < i.Length; a++)
            {
                newArr[a+1]=i[a];
            }
            i = newArr;
            return ++sizeArray;
        }

        public static int UnShift(ref float[] i, float newElement){
            var sizeArray = i.Length;
            float[] newArr = new float[i.Length+1];
            newArr[0] = newElement;
            for (int a = 0; a < i.Length; a++)
            {
                newArr[a+1]=i[a];
            }
            i = newArr;
            return ++sizeArray;
        }


    }
}
