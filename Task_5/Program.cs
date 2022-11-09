using System.Text.RegularExpressions;
string [,] ArreyCourseRUB = new string [,] { { "USD", "61,3589" ,"доллар США"}, {"EUR", "61,5718", "евро" }, {"CAD", "45,2332", "канадский доллар" }, { "KZT", "0,130185","тенге" } , {"UZS", "0,00550051", "узбекские сумы"}, { "RUB", "1", "рубль" }};
// *курс перевода валют в рубль значение с идексом 1 рублей можно получить за продажу валюты ,указанной в идексе 0. индекс 2 для красоты- информативное название валюты/
bool Exit= false;
while(!Exit)
{
  Console.WriteLine("Введите команду Start для начала работы или команду Exit для завершения. Help-полный список комманд ");
  string Сommands=Console.ReadLine();
  Сommands=Сommands.ToLower();
  switch (Сommands)
  {
    case   "exit":
      Exit=!Exit;
    break;
    case "help":
      Console.WriteLine("Список команд: ");
      Console.WriteLine("Start-начало работы");
      Console.WriteLine("Exit - завершение работы");
      Console.WriteLine("CurrencyList - список доступных для конвертации валют");
      Console.WriteLine("Help - полный список комманд");
    break;
    case "currencylist":
      Console.WriteLine("Cписок доступных для конвертации валют");
      for (int i = 0; i < (ArreyCourseRUB.Length/3); i++)
        {
        Console.WriteLine(ArreyCourseRUB[i,0]+ "=>"+ ArreyCourseRUB[i,2]);
        }
    break;
    case "start":                       //основное тело программы
      Console.WriteLine("Через разделитель ';' введите сумму и буквенный код валюты, которую конвертируете");// блок валюта, которую переводят
      string TempCurrency=Console.ReadLine();
      float NumberStart=0;
      sbyte IndexStartCurrency=0;
      sbyte IndexFinishCurrency=0;
      bool CurrencyNameCheckStart=false;
      var TempNumberStart = Regex.Matches(TempCurrency, @"-?\d+(\,\d+)?")                // через массив верятно избыточно,скорее задел на будущее,чтобы можно было одновременно несколько операций делать
      .Cast<Match>()
      .Select(m => m.Value)
      .ToArray();
      try
      {
        NumberStart = float.Parse(TempNumberStart[0]);
      }
      catch
      {
        Console.WriteLine("некорректный ввод. отсутсвуют цифры");
        break;
      }
      sbyte Length=0;
      sbyte Pozition=0;
      try
      {
        Length = (sbyte) TempCurrency.Length;
      }
      catch
      {
        Console.WriteLine("некорректный ввод. слишком большая строка");
        break;
      }
      try
      {
        Pozition =(sbyte)TempCurrency.IndexOf(';');
      }
      catch
      {
          Console.WriteLine("некорректный ввод. не найден разделитель");
          break;
      }
      string CurrencyNameStart = TempCurrency.Substring(Pozition+1, Length-Pozition-1);
      for (int i = 0; i < (ArreyCourseRUB.Length/3); i++)
        {
          if(CurrencyNameStart==(ArreyCourseRUB[i,0]))
          {
            CurrencyNameCheckStart=true;
            IndexStartCurrency=(sbyte) i;
            break;
          }
        }
      if(!CurrencyNameCheckStart)
        {
            Console.WriteLine("некорректный ввод. такой валюты нет. введите CurrencyList для вывода списка доступных валют");
            break;
        }
        Console.WriteLine("введите буквенный код валюты, в которую конвертируете");// блок валюта целевая
        TempCurrency=Console.ReadLine();
        bool CurrencyNameCheckFinish=false;

        string CurrencyNameFinish = TempCurrency;
        for (int i = 0; i < (ArreyCourseRUB.Length/3); i++)
          {
            if(CurrencyNameFinish==(ArreyCourseRUB[i,0]))
            {
              CurrencyNameCheckFinish=true;
              IndexFinishCurrency=(sbyte) i;
              break;
            }
          }
        if(!CurrencyNameCheckFinish)
          {
              Console.WriteLine("некорректный ввод. такой валюты нет. введите CurrencyList для вывода списка доступных валют");
              break;
          }

      //обработка и вывод результата//

      Console.WriteLine(NumberStart);
      Console.WriteLine(CurrencyNameStart);
      Console.WriteLine(CurrencyNameFinish);
      Console.WriteLine("инекс первой валюты "+ );
    break;


    default:
      Console.WriteLine("команда не распознана. Введите команду Help для вывода списка всех комманд");
    break;
  }
}
