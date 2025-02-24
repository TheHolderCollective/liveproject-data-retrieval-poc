using System.Text;

namespace Gtc.Models
{
    public static class ListExtensions
    {
        public static string ListToString<T>(this IEnumerable<T> list) where T : class
        {
            StringBuilder listItems = new StringBuilder();

            foreach (T item in list)
            {
                listItems.AppendLine($"{item.ToString()}");
            }

            return listItems.ToString();
        }
    }
}
