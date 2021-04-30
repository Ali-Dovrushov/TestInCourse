using System;

namespace Test
{
    class Program
    {
        static public int resultForFirstString = 0;
        static public int resultForSecondString = 0;
        static public int resultForThirdString = 0;
        static public int resultForFourthString = 0;
        static public int resultForFifthString = 0;

        static void Main(string[] args)
        {
            string firstString, secondString, thirdString, fourthString, fifthString;
            firstString = "Второе предубеждение, стоящее за установкой, что в любви нечему учиться, – это допущение, что проблема любви есть проблема объекта, а не проблема способности.";
            secondString = "Принято думать, что любить просто, а найти достойный объект для любви или для того, чтобы быть любимым, – вот это трудно.";
            thirdString = "Прежде всего сыграло роль резкое изменение отношения к выбору «объекта любви», происшедшее в XX столетии. В викторианскую эпоху, как и во многих культурах, приверженных традициям, любовь не была непосредственным личным переживанием, которое могло привести затем к браку.";
            fourthString = "Напротив, браки заключались по договору – или при посредничестве каких-либо почтенных семейств либо брачного маклера, или без посредников.";
            fifthString = "Они заключались из соображений, социальных по своей природе. Что же касается любви, то предполагалось, что она появится и будет крепнуть после заключения брака. Однако за время жизни нескольких последних поколений в западном мире почти окончательно восторжествовала концепция романтической любви.";

            string[] arr = new string[5] { firstString, secondString, thirdString, fourthString, fifthString };

            for (int i = 0; i < firstString.Length; i++)
            {
                resultForFirstString++;
            }
            Console.WriteLine(resultForFirstString);

            for (int i = 0; i < secondString.Length; i++)
            {
                resultForSecondString++;
            }
            Console.WriteLine(resultForSecondString);

            for (int i = 0; i < thirdString.Length; i++)
            {
                resultForThirdString++;
            }
            Console.WriteLine(resultForThirdString);

            for (int i = 0; i < fourthString.Length; i++)
            {
                resultForFourthString++;
            }
            Console.WriteLine(resultForFourthString);

            for (int i = 0; i < fifthString.Length; i++)
            {
                resultForFifthString++;
            }
            Console.WriteLine(resultForFifthString);

            //Max
            if (resultForFirstString > resultForSecondString && resultForFirstString > resultForThirdString && resultForFirstString > resultForFourthString &&resultForFirstString > resultForFifthString)
            {
                Console.WriteLine($"First array longer than another arrays, total symbols in first array = {resultForFirstString}");
            }

            else if (resultForFirstString < resultForSecondString && resultForSecondString > resultForThirdString && resultForSecondString > resultForFourthString && resultForSecondString > resultForFifthString)
            {
                Console.WriteLine($"Second array longer than another arrays, total symbols in second array = {resultForSecondString}");
            }

            else if (resultForThirdString > resultForSecondString && resultForFirstString < resultForThirdString && resultForThirdString > resultForFourthString && resultForThirdString > resultForFifthString)
            {
                Console.WriteLine($"Third array longer than another arrays, total symbols in third array = {resultForThirdString}");
            }

            else if (resultForFourthString > resultForSecondString && resultForFourthString > resultForThirdString && resultForFirstString < resultForFourthString && resultForFourthString > resultForFifthString)
            {
                Console.WriteLine($"Fourth array longer than another arrays, total symbols in fourth array = {resultForFourthString}");
            }

            else if (resultForFifthString > resultForSecondString && resultForFifthString > resultForThirdString && resultForFifthString > resultForFourthString && resultForFirstString < resultForFifthString)
            {
                Console.WriteLine($"Fifth array longer than another arrays, total symbols in fifth array = {resultForFifthString}");
            }

            //Min
            if (resultForFirstString < resultForSecondString && resultForFirstString < resultForThirdString && resultForFirstString < resultForFourthString && resultForFirstString < resultForFifthString)
            {
                Console.WriteLine($"First array short than another arrays, total symbols in first array = {resultForFirstString}");
            }

            else if (resultForFirstString > resultForSecondString && resultForSecondString < resultForThirdString && resultForSecondString < resultForFourthString && resultForSecondString < resultForFifthString)
            {
                Console.WriteLine($"Second array short than another arrays, total symbols in second array = {resultForSecondString}");
            }

            else if (resultForThirdString < resultForSecondString && resultForFirstString > resultForThirdString && resultForThirdString < resultForFourthString && resultForThirdString < resultForFifthString)
            {
                Console.WriteLine($"Third array short than another arrays, total symbols in third array = {resultForThirdString}");
            }

            else if (resultForFourthString < resultForSecondString && resultForFourthString < resultForThirdString && resultForFirstString > resultForFourthString && resultForFourthString < resultForFifthString)
            {
                Console.WriteLine($"Fourth array short than another arrays, total symbols in fourth array = {resultForFourthString}");
            }

            else if (resultForFifthString < resultForSecondString && resultForFifthString < resultForThirdString && resultForFifthString < resultForFourthString && resultForFirstString > resultForFifthString)
            {
                Console.WriteLine($"Fifth array short than another arrays, total symbols in fifth array = {resultForFifthString}");
            }


            Console.ReadKey();
        }
    }
}
