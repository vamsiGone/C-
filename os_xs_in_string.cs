 public static bool XO (string input)
  {
    int n=input.Length;
    char[] s=input.ToLower().ToCharArray();
    int ocount=0,xcount=0;
    foreach(char v in s){
      if(v=='o'){
        ocount++;
      }else if(v=='x'){
        xcount++;
      }
    }
    if((ocount==0 && xcount==0) ||(ocount==xcount)){
      return true;
    }else  return false;
     
  }
