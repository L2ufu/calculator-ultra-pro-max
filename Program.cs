using calculator_ultra_pro_max_super_edition;


string stop = "";
while(stop != "Нет") 
{
 
    Console.WriteLine("C чем вы будете работать?" + "\n" + "c двумя числам - \"twoN\"" + "\n" + "С массивом - \"arr\"");

    string choise1 = Console.ReadLine();

    switch (choise1) 
    {
        case "twoN":
            Console.WriteLine("Выберите операцию: \"+, -, *, /, !, %\"" + "\n" + "обратное от процента - \"d%\"" + "\n" + "вывод целочисленного деления и остатка - \"mod\"");

            break;


        case "arr":
            Console.WriteLine("Выберите операцию: Найти минимально число - \"min \"" + "\n" + " Найти минимальное число - \"max\"" + "\n" + "Посчитать ");


            break;
        

    }


    Console.WriteLine("Хотите посчитать новый пример? Да/Нет");
    stop = Console.ReadLine();
}