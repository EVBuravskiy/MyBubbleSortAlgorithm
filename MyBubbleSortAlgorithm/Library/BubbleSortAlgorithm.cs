namespace Library
{
    /// <summary>
    /// Bubble Sort Algorithm Class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BubbleSortAlgorithm<T> : AlgorithmBase<T> where T : IComparable
    {
        /// <summary>
        /// Overridden sort method
        /// </summary>
        /// <returns></returns>
        public override int Sort()
        {
            int count = 0;
            var lenght = Elements.Count();
            for (int i = 0; i < lenght; i++)
            {
                bool fl = false;
                for (int j = 0; j < lenght - 1 - i; j++)
                {
                    if (Elements[j].CompareTo(Elements[j + 1]) > 0)
                    {
                        Swap(j, j + 1);
                        fl = true;
                    }
                    count++;
                }
                if (!fl)
                {
                    break;
                }
            }
            return count;
        }
    }
}
