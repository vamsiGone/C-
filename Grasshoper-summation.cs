 public static int summation(int num)
    {
      //Code here
      int sum=0;
      if(num==1){
        return 1;
      }else{
        for(int i=1;i<=num;i++){
          sum+=i;
        }
        return sum;
      }
  }
