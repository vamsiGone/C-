 public static int[] ReverseSeq(int n)
  {
    int[] r=new int[n];
    int j=0;
    for(int i=n;i>0;i--){
      r[j]=i;
      j++;
    }
   return r;
  }
