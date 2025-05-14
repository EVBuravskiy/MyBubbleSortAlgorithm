namespace Library
{
    /// <summary>
    /// Base class for Algorithms
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class AlgorithmBase<T> where T : IComparable
    {
        /// <summary>
        /// Collection of elements
        /// </summary>
        public List<T> Elements { get; set; }

        /// <summary>
        /// Base class constructor
        /// </summary>
        public AlgorithmBase()
        {
            Elements = new List<T>();
        }

        /// <summary>
        /// Swap of elements of collection
        /// </summary>
        /// <param name="firstPosition"></param>
        /// <param name="secondPosition"></param>
        protected void Swap(int firstPosition, int secondPosition)
        {
            if (firstPosition < Elements.Count && secondPosition < Elements.Count)
            {
                var temp = Elements[firstPosition];
                Elements[firstPosition] = Elements[secondPosition];
                Elements[secondPosition] = temp;
            }
        }

        /// <summary>
        /// Virtual Collection sort
        /// </summary>
        /// <returns>int</returns>
        public virtual int Sort()
        {
            Elements.Sort();
            return Elements.Count;
        }
    }
}