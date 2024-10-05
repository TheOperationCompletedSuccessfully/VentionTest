using System.Text;

var test = Console.ReadLine();

var result = Transform(test);
Console.WriteLine(result);

    static string Transform(string value)
    {
        var data = value.ToCharArray();
        var builder = new StringBuilder();
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] >= 97 && data[i] <= 122)
            {
                if (data[i] == 122)
                {
                    builder.Append(97);
                }
                else
                {
                    builder.Append((char)(data[i] + 1));
                }
            }
            else
            {
                builder.Append(data[i]);
            }
        }
        return builder.ToString();
    }

