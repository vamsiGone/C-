public static int FindShort(string s)
  {
  //Dont forget to add the " using System.Linq;"
    string[] words=s.Split(" ");
    int l=words.Length;
    int[] n=new int[l];
    for(int i=0;i<l;i++){
      n[i]=words[i].Length;
    }
    return n.Min();
  }
