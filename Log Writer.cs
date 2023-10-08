    public static void log(string act = "-", string input = "-", string output = "-", string methodNm = "Main()", bool isExit = false)
    {
        string p = "Log.txt";
        using (StreamWriter w = new StreamWriter(p, true))
        {
            w.WriteLine($"{DateTime.Now} : {act} : [INP] {input} : [OUT] {output} : [MTHD] {methodNm} : [CLZ] Program");
        }
    }