public static string AbbrevName(string name)
  {
   string[] names=name.ToUpper().Split(" ");
    string first=names[0];
    string sec=names[1];
    return first[0]+"."+sec[0];
  }
