using System.Text;
Console.OutputEncoding = Encoding.UTF8;
//1
const int MAX_SIGRDZE = 100;
//2
Console.WriteLine("enter text");
string text = Console.ReadLine();
//3
StringBuilder sb = new StringBuilder();
for (int i = text.Length -1; i >= 0; i--)
{
        sb.Append(text[i]);
}
//4
int xmovnebi = 0;
foreach(char c in sb.ToString())
{
    if (!new char[5] { 'ა', 'ე', 'ი', 'ო', 'უ' }.Contains(c))
    {
        continue;
    }sdasdas
    xmovnebi++;
}
Console.WriteLine($"xmovnebis raodenoba: {xmovnebi}");
//5
for (int i = 0; i < 10; i++)
{
    sb.Replace(i.ToString(), "*");
}
//6
foreach (string word in sb.ToString().Split(" "))
{
    if (word[0] == word.ToUpper()[0])
    {
        Console.WriteLine(word);
    }
}
//7
if(sb.Length > MAX_SIGRDZE)
{
    sb.Append($"5468{sb.ToString().Substring(0, MAX_SIGRDZE)}");
    sb.Replace(sb.ToString().Split("5468")[0], "");
    sb.Replace("5468", "");
    sb.Append("...");
}
//8
//int[] lengthArray = new int[sb.ToString().Split(" ").Length];
List<int> list = new List<int>();
foreach(string word in sb.ToString().Split(" "))
{
    list.Add(word.Length);
}
string biggestWord = sb.ToString().Split(" ")[list.IndexOf(list.Max())];
Console.WriteLine(biggestWord);
System.IO.File.WriteAllText("output.txt", sb.ToString(), Encoding.UTF8);
