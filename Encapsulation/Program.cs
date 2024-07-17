using System.Security.Principal;

internal class Program
{
    //Encapsulation,nesnelerimizde ki field'ların konrollü bir şekilde dışarıya açılmasıdır
    //Bir başka deyişle nesnelerimizi başkalarının yanlış kullanımlarından korumak için 
    //kontrolsüz değişime kapatmaktır 
    //Kısacası encapsulation field'ların kontrolünü sağlamaktır
    //Fİeld'lara direkt erişilmesini istemeyiz 



    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //eski encapsulation 
         MyClass m=new MyClass();
        m.ASet(15);
        Console.WriteLine(m.AGet());

        m.A = 123123; //set blogu tetiklenir
        Console.WriteLine(m.A);  //get blogu tetiklenir
    }

   
     class MyClass
    {
        int a; 
        //eskiden encapsulation gerçekleştirmek için 
        #region Eski encapsulation işlemi
        public int AGet() // a değerini okumak için
        {
            return this.a;
        }
        public void ASet(int value) // a değerine dışarıdan değer atamak için 
        {
            this.a = value;
        }
        #endregion
        #region Property ile Encapsulation


        public int A
        {
            get { return a; }
            set { a = value; }
        }



        #endregion

    }




}