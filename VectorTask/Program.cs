namespace VectorTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector vector1 = new Vector(5);

            Vector vector2 = new Vector(vector1);

            double[] array = { 1, 2, 3, 4, 5 };

            Vector vector3 = new Vector(array);

            Vector vector4 = new Vector(10, array);

            Console.WriteLine("Вектор 1:{0} Размерность:{1}", vector1, vector1.GetSize());
            Console.WriteLine("Вектор 2:{0} Размерность:{1}", vector2, vector2.GetSize());
            Console.WriteLine("Вектор 3:{0} Размерность:{1}", vector3, vector3.GetSize());
            Console.WriteLine("Вектор 4:{0} Размерность:{1}", vector4, vector4.GetSize());

            Console.WriteLine();
            Console.WriteLine("Прибавляем к вектору 3 вектор 4");

            vector3.AddVector(vector4);

            Console.WriteLine("Вектор 3:{0} Размерность:{1}", vector3, vector3.GetSize());

            Console.WriteLine();
            Console.WriteLine("Отнимаем от вектора 3 вектор 4");

            vector3.SubtractVector(vector4);

            Console.WriteLine("Вектор 3:{0} Размерность:{1}", vector3, vector3.GetSize());

            Console.WriteLine();
            Console.WriteLine("Умножаем вектор 3 на скаляр равный 4");

            vector3.MultiplyScalar(4);

            Console.WriteLine("Вектор 3:{0}", vector3);

            Console.WriteLine();
            Console.WriteLine("Разворачиваем вектор 3");

            vector3.ReverseVector();

            Console.WriteLine("Вектор 3:{0}", vector3);

            Console.WriteLine();
            Console.WriteLine("Длина вектора 3 равна:{0: 0.00}", vector3.GetVectorLength());

            Console.WriteLine();
            Console.WriteLine("Компонента вектора 3 по индексу 2 равна:{0}", vector3.GetComponent(2));

            Console.WriteLine();
            Console.WriteLine("Поменяем компоненту вектора 3 по индексу 0 на 100");

            vector3.SetComponent(0, 100);

            Console.WriteLine("Вектор 3:{0}", vector3);

            Console.WriteLine();
            Console.WriteLine("Сравним вектор 3 и вектор 4");
            Console.WriteLine("Вектор 3:{0}", vector3);
            Console.WriteLine("Вектор 4:{0}", vector4);

            if (vector3.Equals(vector4))
            {
                Console.WriteLine("Векторы равны");
            }
            else
            {
                Console.WriteLine("Векторы не равны");
            }

            Console.WriteLine();
            Console.WriteLine("Клонируем вектор 3 и сравним");

            Vector vector5 = new Vector(vector3);

            Console.WriteLine("Вектор 3:{0}", vector3);
            Console.WriteLine("Вектор 5:{0}", vector5);

            if (vector3.Equals(vector5))
            {
                Console.WriteLine("Векторы равны");
            }
            else
            {
                Console.WriteLine("Векторы не равны");
            }

            Console.WriteLine();
            Console.WriteLine("Вычислим хэшкод для вектора 3, вектора 5 и вектора 4");

            Console.WriteLine("Хэшкод вектор 3:{0}", vector3.GetHashCode());
            Console.WriteLine("Хэшкод вектор 5:{0}", vector5.GetHashCode());
            Console.WriteLine("Хэшкод вектор 4:{0}", vector4.GetHashCode());

            Console.WriteLine();
            Console.WriteLine("Сложим вектор 3 и вектор 5, получим вектор 6");

            Vector vector6 = Vector.GetSumVectors(vector3, vector5);

            Console.WriteLine("Вектор 6:{0}", vector6);

            Console.WriteLine();
            Console.WriteLine("Вычтем из вектора 6 вектор 4, получим вектор 7");

            Vector vector7 = Vector.GetDifferenceVectors(vector6, vector4);

            Console.WriteLine("Вектор 7:{0}", vector7);

            Console.WriteLine();
            Console.WriteLine("Умножим вектор 7 на вектор 6, получим вектор 8");

            Vector vector8 = Vector.GetProductVectors(vector7, vector6);

            Console.WriteLine("Вектор 8:{0}", vector8);
        }
    }
}