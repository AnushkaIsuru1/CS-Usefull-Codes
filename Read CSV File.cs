string path = "input.csv";
int index;
string[] inp_col = new string[12];
foreach(string inp_line in File.ReadLines(path))
{
    inp_col = inp_line.Split(',');
    if (inp_col[3] == "") { break; }
    index = int.Parse(inp_col[3]);
    Console.WriteLine(inp_col[0].ToString());
}            