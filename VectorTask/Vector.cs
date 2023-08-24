namespace VectorTask
{
    public class Vector
    {
        public double[] vector;
        public int N;

        public double this[int index]
        {
            get { return vector[index]; }
            set { vector[index] = value; }
        }

        public Vector(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Некорректное значение размерности вектора");
            }

            N = n;

            vector = new double[N];

            for (int i = 0; i < N; i++)
            {
                vector[i] = 0;
            }
        }

        public Vector(Vector vector) : this(vector.N)
        {
            for (int i = 0; i < N; i++)
            {
                this.vector[i] = vector.vector[i];
            }
        }

        public Vector(double[] array) : this(array.Length)
        {
            for (int i = 0; i < N; i++)
            {
                this.vector[i] = array[i];
            }
        }

        public Vector(int n, double[] array) : this(n)
        {
            N = n;

            if (array.Length > N)
            {
                ResizeVector(this.vector, N);
            }

            vector = new double[N];

            for (int i = 0; i < array.Length; i++)
            {
                this.vector[i] = array[i];
            }
        }

        public int GetSize()
        {
            return vector.Length;
        }

        public override string ToString()
        {
            return $"{"{"}{string.Join(", ", vector)}{"}"}";
        }

        public double GetVectorLength()
        {
            double vectorLength = 0;

            for (int i = 0; i < N; i++)
            {
                vectorLength += vector[i] * vector[i];
            }

            return Math.Abs(Math.Sqrt(vectorLength));
        }

        public void AddVector(Vector vector)
        {
            if (N < vector.N)
            {
                ResizeVector(this.vector, vector.N);
            }

            for (int i = 0; i < vector.N; i++)
            {
                this.vector[i] = this.vector[i] + vector.vector[i];
            }
        }

        public void SubtractVector(Vector vector)
        {
            if (N < vector.N)
            {
                ResizeVector(this.vector, vector.N);
            }

            for (int i = 0; i < N; i++)
            {
                this.vector[i] = this.vector[i] - vector.vector[i];
            }
        }

        private void ResizeVector(double[] vector, int newSize)
        {
            double[] tempArray = new double[newSize];

            for (int i = 0; i < N; i++)
            {
                tempArray[i] = vector[i];
            }

            for (int i = N; i < newSize; i++)
            {
                tempArray[i] = 0;
            }

            this.vector = tempArray;
            N = newSize;
        }

        public void ReverseVector()
        {
            for (int i = 0; i < N; i++)
            {
                vector[i] = vector[i] * (-1);
            }
        }

        public void MultiplyScalar(double scalar)
        {
            for (int i = 0; i < N; i++)
            {
                vector[i] = vector[i] * scalar;
            }
        }

        public double GetComponent(int index)
        {
            return vector[index];
        }

        public void SetComponent(int index, double component)
        {
            vector[index] = component;
        }

        public override bool Equals(object? o)
        {
            if (ReferenceEquals(o, this))
            {
                return true;
            }

            if (ReferenceEquals(o, null) || o.GetType() != GetType())
            {
                return false;
            }
            Vector newVector = (Vector)o;

            // return N == newVector.N && Enumerable.SequenceEqual(this.vector, newVector.vector);

            return N == newVector.N && ToString() == newVector.ToString();
        }

        public override int GetHashCode()
        {
            int prime = 37;
            int hash = 1;

            hash = prime * hash + N;

            foreach (double item in vector)
            {
                hash = prime * hash + item.GetHashCode();
            }

            return (int)hash;
        }

        public static Vector GetSumVectors(Vector vector1, Vector vector2)
        {
            int sizeNewVector = vector1.GetSize();
            int sizeOldVector = vector2.GetSize();

            if (sizeNewVector < sizeOldVector)
            {
                sizeNewVector = vector2.GetSize();
                sizeOldVector = vector1.GetSize();
            }

            Vector newVector = new Vector(sizeNewVector);

            for (int i = 0; i < sizeOldVector; i++)
            {
                newVector[i] = vector1[i] + vector2[i];
            }

            return newVector;
        }

        public static Vector GetDifferenceVectors(Vector vector1, Vector vector2)
        {
            int sizeNewVector = vector1.GetSize();
            int sizeOldVector = vector2.GetSize();

            if (sizeNewVector < sizeOldVector)
            {
                sizeNewVector = vector2.GetSize();
                sizeOldVector = vector1.GetSize();
            }

            Vector newVector = new Vector(sizeNewVector);

            for (int i = 0; i < sizeOldVector; i++)
            {
                newVector[i] = vector1[i] - vector2[i];
            }

            return newVector;
        }

        public static Vector GetProductVectors(Vector vector1, Vector vector2)
        {
            int sizeNewVector = vector1.GetSize();
            int sizeOldVector = vector2.GetSize();

            if (sizeNewVector < sizeOldVector)
            {
                sizeNewVector = vector2.GetSize();
                sizeOldVector = vector1.GetSize();
            }

            Vector newVector = new Vector(sizeNewVector);

            for (int i = 0; i < sizeOldVector; i++)
            {
                newVector[i] = vector1[i] * vector2[i];
            }

            return newVector;
        }
    }
}