string path = "input.csv";
if (File.Exists(path)) { File.Delete(path); }
File.AppendAllText(path, "Attemp,gen\n");
