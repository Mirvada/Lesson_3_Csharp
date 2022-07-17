// Метод 1 - ничего не возвращает и ничего не принимает


// void Method1()
// {
//     Console.WriteLine("Автор..");
// }
//Method1(); //вызов метода


// Метод 2 - ничего не возвращают, но принимают какие то аргументы


// void Method2(string msg) // в скобках указан, аргумент, их может быть несколько
// {
//     COnsole.WriteLine(msg);
// }
//Method2(msg: "Текст сообщения"); // пример именнованого аргумента


// void Method21(string msg, int count) // 2 аргумента
// {
//     int i = 0;
//     while(i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// //Method21("Текст", 4); // В скобках тоже 2 аргумента, msg - Текст, count - 4
// Method21(count: 4, msg: "новый текст"); // еще один вариант записи аргументов


//Метод 3 - что то возвращают, но ничего не принимают


// int Method3() //ничего не принимает, тип данных ОБЯЗАТЕЛЬНО
// {
//     return DateTime.Now.Year; //return ОБЯЗАТЕЛЬНО
// }

// int year = Method3(); // переменная для метода, для дальнейшей работы с результатом
// Console.WriteLine(year); // Печать результата метода


//Метод 4 - что то принимают, и что то возвращают

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = string.Empty; // пустая строка (без значения)

//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "asdf");
// Console.WriteLine(res);