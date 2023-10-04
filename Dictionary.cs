using System.Collections.Generic;

IDictionary<int, string> name= new Dictionary<int, string>();
name.Add(1, "sdsd");//Append item

string n = name[1]//Retrive by key

int index;

foreach(KeyValuePair<int,string> pair in name)
{
    index = pair.Key;
    n = pair.Value;
}    

string[] nemes = name.Values;