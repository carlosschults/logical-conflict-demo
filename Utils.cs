using System.Text;

namespace logical_conflict_demo
{
    public static class Utils
    {
        public static string GenerateMultiplicationTableFor(int number)
            {
                var result = new StringBuilder(10);
                for (var i = 1; i <= 10; i++)
                {
                    result.AppendLine($"{number} X {i} = {number * i}");
                }

                return result.ToString();
            }
    }
}
