 public static int[] minMax(int[] lst) 
    {
      
      int i, max, min, n;
      // size of the array
      n = lst.Length;
      max = lst[0];
      min = lst[0];
      for(i=1; i<n; i++) {
         if(lst[i]>max) {
            max = lst[i];
         }
         if(lst[i]<min) {
            min = lst[i];
         }
      }
      int[] c= new int[2]{min,max};
      return c;
      
    }
