// 1.  Создаю экземпляр класса StreamReader, которай считывает символы из потока байтов в определенной кодировке;
//    читаю файл по пути: C:\Users\Euheni\image.txt;
//    аргумент true - указывает на определение кодировки по порядковым меткам байтов (bool detectEncodingFromByteOrderMarks).
// 2.  Объявляю строку textReaderResult и присваиваю ей textReader, которая выполнит метод RearToEnd(),
//    который в свою очередь, читает все символы потока из текущей позиции до конца.
// 3.  Объявляю массив arrayOfTextResult и присваюваю ему textReaderResult с методом Split, который разбивает строку на
//    подстроки на основе указанного символа-разделителя и опций (опционально).
// 4.  Создаю экземпляр массива imageBytes типа byte и присваиваю ему размер длины массива arrayOfTextResult - 1.
// 5.  Создаю цикл for, в котором начальное значение для i = 0; условие выполнения i < arrayOfTextResult.Length - 1,
//    шаг цикла - инкремент i (i+1). Между шагом цикла и проверкой условия выполнения выполняется тело цикла, в котором:
//    объявляется переменная binary типа byte, выполняющая метод ToByte класса Convert, в которуюю передаются два аргумента
//    ( строка arrayOfTextResult, соответствующая порядковому номеру i, текущей итерации цикла и число типа Int fromBase).
// 6.  Объявляю статический метод WriteAllBytes класса File, который создает новый файл по пути C:\Users\Euheni\image.png, 
//    путем записи в него переданного массива imageBytes, в конце закрывая файл. Если файл уже существует, то он его перезаписывает.
// 7. У textReader вызываю метод Dispose, который освобождает все ресурсы, используемые объектом TextReader.

// code
StreamReader textReader = new StreamReader(@"C:\Users\Euheni\image.txt", true);

string textReaderResult = textReader.ReadToEnd();

string[] arrayOfTextResult = textReaderResult.Split(' ');

byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];

for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
{
    byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
    imageBytes[i] = binary;
}

File.WriteAllBytes(@"C:\Users\Euheni\image.png", imageBytes);

textReader.Dispose();