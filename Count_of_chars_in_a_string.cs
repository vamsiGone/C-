using System;
using System.Linq;
public class HelloWorld
{
    public static void Main(string[] args)
    {
       var inputString="Hello world hi welcome ";   // input string
       char[] inp=inputString.ToCharArray();        //converting input to char array
    var uniqueCharArray = inputString.ToCharArray().Distinct().ToArray();  //removing duplicates from the array
    var resultString = new string(uniqueCharArray); //assigning the unique string to new variable
       
    char[] s=resultString.ToCharArray(); //converting result to char array
    int i;
    int count=0;
    foreach(char v in s){               //maping the unique occurences in the input string to know the count.
        for(i=0 ;i<inp.Length;i++){
            if(v==inp[i]){
                count++;
            } 
        }
        Console.WriteLine(v+"="+count);
        count=0;
    }
}
}
