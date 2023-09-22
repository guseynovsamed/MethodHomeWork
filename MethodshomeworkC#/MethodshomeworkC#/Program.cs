
// Task 1

//Parametr olaraq string qebul eden metod yazmalisiz. Hemin metod qebul etdiyi stringi tersine formada ekranda gostersin. (Cavid gelirse , ekranda divaC gorsensin)


//static void Reverse(string name)
//{


//    char[] name1 = name.ToCharArray();

//    for (int i = name1.Length - 1; i >= 0; i--)
//    {
//        Console.WriteLine(name[i]);
//    }



//}

//string name = "Semed";

//Reverse(name);

//-------------------------------------------------------------------------------------------------------------------------------------------------------------------



//Tapsiriq 1


//Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.



//static void Number(int a)
//{
//    if(a%3 == 0 && a % 7 == 0)
//    {
//        Console.WriteLine("Bolunur");
//    }
//    else
//    {
//        Console.WriteLine("Bolunmur");
//    }


//}

//int a = 2;

//Number(a);

//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------


// Tapsiriq 2

// n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.


//static int SumNumber(int n , int m)
//{
//    int count = 0;

//    if(n%2 == 0 && m%2==0)
//    {
//        count = n + m;
//    }
//    return count;
//}

//int n = 7;
//int m = 12;

//Console.WriteLine(SumNumber(n, m));


//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------


//Tapsiriq 3

//Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.

//static void OddNumber(int n , int m)
//{
//    int count = 0;

//   for(int i = n; i < m; i++)
//    {
//        if (i % 2 == 1)
//        {
//            count++;
//        }
//    }
//    Console.WriteLine(count);
//}

//int n = 3;
//int m = 9;

//OddNumber(n , m);



//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------


//Tapsiriq 4

//Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.

//static void SumNumberOdd(int n , int m)
//{
//    int count = 0;

//    for (int i = n; i < m; i++)
//    {
//        if(i%2 == 1)
//        {
//            count+= i;
//        }
//    }
//    Console.WriteLine(count);
//}


//int n = 7;

//int m = 13;

//SumNumberOdd(n, m);


//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


// Tapsiriq 5


//Verilmish arrayin icindeki tek ededlerin cemini tapin.


//static void OddSumArr(int[] number)
//{
//    int count = 0;

//    for( int i = 0; i < number.Length; i++)
//    {
//        if(number[i] % 2 == 1)
//        {

//            count += number[i];
//        }
//    }

//    Console.WriteLine(count);
//}

//int[] number = { 3, 4, 5, 6, 4, 3 };

//OddSumArr(number);




//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



//Tapsiriq 6 


//Verilmish arrayin icindeki cut ededlerin sayini tapin.


//static void OddSumArr(int[] number)
//{
//    int count = 0;

//    for (int i = 0; i < number.Length; i++)
//    {
//        if (number[i] % 2 == 0)
//        {

//            count ++;
//        }
//    }

//    Console.WriteLine(count);
//}

//int[] number = { 33, 4, 45, 26, 34, 3 , 18 };

//OddSumArr(number);



//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

//Tapsiriq 7



//Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.


//static void Result(int a)
//{
//    int count = 0;

//    for (int i = 1; i <= a; i++)
//    {
//        if(a%i == 0)
//        {
//            count++;
//        }
//    }
//   - if (count == 2)
//    {
//        Console.WriteLine("Sade");
//    }
//    else
//    {
//        Console.WriteLine("Murekkeb");
//    }
//}


//int a = 11;

//Result(a);



//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

//Tapsiriq 8



//n ededi gelir. 2-ni hansisa quvvete yukseltdikde n-in alinan cavaba beraber olub-olmamasını tapın.


//static void Result(int n)
//{


//    while (n % 2 == 0)
//    {
//        n = n / 2;
        
//    }
//    if (n == 1)
//    {
//        Console.WriteLine("Quvvetidir");
//    }
//    else
//    {
//        Console.WriteLine("Quvveti deil");

//    }



//}

//int n = 8;

//Result(n);







//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


//Tapsiriq 9

//Verilmish arrayin-in elementlerinin icinden 1-20 arasinda olanlarinin hasilini tapmaq.Mes ([1,3,55,6,33], cavab: 18).


//static void MultiNum(int[] nums)
//{

//    int multiply = 1;

//    for (int i = 0; i < nums.Length; i++)
//    {
//        if (nums[i] >= 1 && nums[i] < 20)
//        {
//            multiply *= nums[i];
//        }
//    }

//    Console.WriteLine(multiply);

//}

//int[] nums = { 2, 3, 4, 5, 6, 23, 56, 43, 12, 45, 13 };

//MultiNum( nums);


//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


//Tapsiriq 10 


//Verilmish arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.


//static void Result(int[] num)
//{

//    int count = 0;

//    int squares = 1;

//    for (int i = 0; i < num.Length; i++)
//    {
//        if (num[i] % 2 == 0)
//        {
//            count += num[i];

//        }
//    }


//    squares = count * count;


//    Console.WriteLine(squares);
//}


//int[] num = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 12 };


//Result(num);