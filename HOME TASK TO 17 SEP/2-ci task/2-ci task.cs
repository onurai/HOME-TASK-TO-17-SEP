using System;
using System.Collections.Generic;
using System.Text;

namespace _2_ci_task
{
    public class DelegateExercises
    {
        public delegate int MyDelegate(int intValue);

        public int Method1(int intMethod1)
        {
            return intMethod1 * 2;
        }

        public int Method2(int intMethod2)
        {
            return intMethod2 * 10;
        }

        public int Method3(int intMethod3)
        {
            return (intMethod3 * 100) /25 ;
        }

        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            int result1 = myDelegate(10);
            System.Console.WriteLine(result1);

            myDelegate = new MyDelegate(Method2);
            int result2 = myDelegate(10);
            System.Console.WriteLine(result2);

            myDelegate = new MyDelegate(Method3);
            int result3 = myDelegate(4);
            System.Console.WriteLine(result3);
        }
    }
    /// Umumi olaraq DelegateExercises classimiz var. MyDelegate adinda da delegatimiz var. 
    /// 
    /// 1-ci de int type indan integer verilir. Method1 ni "MyDelegate myDelegate = new MyDelegate(Method1);" buraya elave edirik. 
    /// Sonra Aldigimiz integer deyeri ora daxil edirik. En sonda 2*10=20 alaciyiq. Cunki return eliyeciyik.

    /// 2-ci de int type indan integer verilir. Method2 ni "myDelegate = new MyDelegate(Method2);" buraya elave edirik. 
    /// Sonra Aldigimiz integer deyeri ora daxil edirik. En sonda 10*10=100 alaciyiq. Cunki return eliyeciyik.
   
    /// 3-cu yeni sonuncu sadece ozumden sinaq meqsedile yazidigim bir numunedir.




}
