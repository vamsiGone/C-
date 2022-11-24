 public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
  {
    //Insert brain here
    
    //Dont forget to add "using System.Linq;" in your Code to use Sum()...OK..!
    int c=ClassPoints.Sum();
    int avg=c/ClassPoints.Length;
    if(avg>YourPoints){
      return false;
    }else return true;
  }
