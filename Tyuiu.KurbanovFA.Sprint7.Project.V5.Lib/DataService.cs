namespace Tyuiu.KurbanovFA.Sprint7.Project.V5.Lib
{
    public class DataService
    {
        static double[] RemoveLastElement(double[] array) //нужен для некоторых операций
        {
            // Проверка, чтобы массив не был пустым
            if (array.Length == 0)
            {
                return array;
            }

            // Создаем новый массив размером на 1 меньше
            double[] newArray = new double[array.Length - 1];

            // Копируем элементы из старого массива в новый (кроме последнего)
            Array.Copy(array, newArray, array.Length - 1);

            return newArray;
        }

        public double FindMiddleValue(double[] array) 
        {
            return Math.Round(array.Sum() / (array.Length - 1), 3);
        }
        
        public double FindTotalValue(double[] array)
        {
            array = RemoveLastElement(array);
            double result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }
            return Math.Round(result, 3);
        }

        public double FindMinValue(double[] array)
        {
            return array.Min();
        }
    }
}
