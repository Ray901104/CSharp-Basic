namespace CSharp
{
    public class Strings
    {
        static void Main(string[] args)
        {
            string name = "Harry Potter";
            
            // 1. 검색
            bool contains = name.Contains("Harry");
            int idx = name.IndexOf("P");
            
            // 2. 변형
            name = name + " Junior";
            string lowerCaseName = name.ToLower();
            string upperCaseName = name.ToUpper();

            string replacedName = name.Replace("r", "l");
            
            // 3. 분할
            string[] names = name.Split(new char[] { ' ' });
            string subName = name.Substring(6);
        }
    }
}