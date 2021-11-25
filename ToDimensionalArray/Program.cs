using TwoDimensionalArray;

//1
//int[,] Array1 = new int[3, 6];
//for (int i = 0; i < Array1.GetLength(0); i++)
//{
//    Console.WriteLine(i);
//}
////2
//for (int j = 0; j < Array1.GetLength(1); j++)
//{
//    Console.WriteLine(j);
//}
////3//4
//void GetArray(int[,] Array1)
//{

//    for (int i = 0; i < Array1.GetLength(0); i++)
//    {

//        Console.Write(i);
//        for (int j = 0; j < Array1.GetLength(1); j++)
//        {
//            Console.Write(j);

//        }

//        Console.WriteLine();
//    }
//}
//GetArray(Array1);
////5//6
////void getArray1(int[,] Array1)
////{
////    for (int i = 0; i < Array1.GetLength(0); i++)
////    {
////        for (int j = 0; j < Array1.GetLength(1); j++)
////        {
////            Array1[i,j] = j;
////            Console.Write(Array1[j, i]);

////        }

////        Console.WriteLine();
////    }
////}
////getArray1(Array1);

////7

//void getArray2(int[,] Array1)
//{
//    for (int i = 0; i < Array1.GetLength(0); i++)
//    {
//        for (int j = 0; j < Array1.GetLength(1); j++)
//        {
//            Array1[i, j] = j * i;
//            Console.Write(Array1[i, j]);

//        }

//        Console.WriteLine();
//    }
//}
//getArray2(Array1);


//void getArray3(int[,] Array1)
//{
//    for (int i = 0; i < Array1.GetLength(0); i++)
//    {
//        for (int j = 0; j < Array1.GetLength(1); j++)
//        {
//            Random random = new Random();
//            int randomNum = random.Next(0, 100);
//            Array1[i, j] = randomNum;
//            Console.Write(Array1[i, j]);

//        }

//        Console.WriteLine();
//    }
//}
//getArray3(Array1);

//void getArray4(int[,] Array1)
//{
//    for (int i = 0; i < Array1.GetLength(0); i++)
//    {
//        Console.Write(i);
//        for (int j = 0; j < Array1.GetLength(1); j++)
//        {

//            Console.Write(j);

//        }

//        Console.WriteLine();
//    }
//}
//getArray4(Array1);

//void getArray5(int[,] Array1)
//{
//    for (int i = 0; i < Array1.GetLength(0); i++)
//    {

//        for (int j = 0; j < Array1.GetLength(1); j++)
//        {
//            if (Array1[i, j] % 2 == 0)
//            {
//                Console.Write(Array1[i, j]);
//            }


//        }

//        Console.WriteLine();
//    }
//}
//getArray5(Array1);





//string[,] namesArray = new string[,]
//   {
//       {"haim", "marcos", "aschalow"},
//       { "ermias","matan","lior"}
//    };
//void getArray6(string[,] namesArray)
//{
//    for (int i = 0; i < namesArray.GetLength(0); i++)
//    {

//        for (int j = 0; j < namesArray.GetLength(1); j++)
//        {
//            if (namesArray[i, j].Length > 4)
//            {
//                Console.Write(namesArray[i, j]);
//            }


//        }

//        Console.WriteLine();
//    }
//}
//getArray6(namesArray);

Teacher Teacher1 = new Teacher(30);
Teacher Teacher2 = new Teacher(35);
Teacher Teacher3 = new Teacher(40);
Teacher Teacher4 = new Teacher(14);

Teacher[,] TeachersArray = new Teacher[,]
   {
       {Teacher1, Teacher2},
       { Teacher3,Teacher4}
    };

//for(int i = 0; i < TeachersArray.GetLength(0); i++)
//{
//    for(int j=0;j< TeachersArray.GetLength(1); j++)
//    {
//        if (TeachersArray[i, j].age > 25)
//        {
//            Console.WriteLine(TeachersArray[i, j].age);
//        }
//    }
//};



int[,] Array = new int[6, 4];

Array[5, 3] = 8;
//for(int i = 0;i< Array.GetLength(0); i++)
//{
//    for(int j=0;j< Array.GetLength(1); j++)
//    {
//        Console.WriteLine(Array[i, j]);
//    }
//};

Random NumRandom = new Random();
for(int i = 0;i<Array.GetLength(0); i++)
{
    for(int j=0;j<Array.GetLength(1); j++)
    {
        Array[i, j] = NumRandom.Next(100);
    }
};

for(int i = 0;i<Array.GetLength(0); i++)
{
    Console.Write($"Line:-");
    for(int j = 0; j < Array.GetLength(1); j++)
    {
        Console.Write($"|{Array[i, j]}|,");
    }
    Console.WriteLine();
}

int[,] Building = new int[4, 3];

Random random = new Random();
for(int i = 0; i < Building.GetLength(0); i++)
{
for(int j = 0; j < Building.GetLength(1); j++)
    {
        Building[i, j] = random.Next(10);
    }
};


for (int i = 0; i < Building.GetLength(0); i++)
{
    for (int j = 0; j < Building.GetLength(1); j++)
    {
        Console.WriteLine(Building[i, j]);
    }
};

for (int i = 0; i < Building.GetLength(0); i++)
{
    for (int j = 0; j < Building.GetLength(1); j++)
    {
      if(Building[i,j] % 2 == 0)
        {
            Console.WriteLine(Building[i, j]);
        }
        else { Console.WriteLine("odd"); }
    }
};


Chocolate ChocolateBox1 = new Chocolate(5, 10);

ChocolateBox1.ChocolateBox();

ChocolateBox1.ChocolateBox55();


