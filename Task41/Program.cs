// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Задайте длину массива");
int size = int.Parse(Console.ReadLine());

int[] array = FillArray(size);



int Num = 0;
for(int i = 0; i < array.Length; i++){
      Num += array[i] > 0 ? 1 : 0; 
    }
Console.WriteLine("");

 Console.WriteLine ("Положительных чисел" + Num);

int[] FillArray(int size){
    int[] filledArray = new int[size];
    Console.WriteLine ("ВВедите элементы массива");
    for(int i = 0; i < filledArray.Length; i++){
       filledArray[i] = int.Parse(Console.ReadLine()); 
    }
    return filledArray;
}