using System;
namespace New
{
   public class Calcule
    {
      public int Sum(int x,int y)
       { 
        int ans;
        ans=x+y;
        return ans; 
       } 
      public int Diff(int x,int y)
       {
        int ans;
        ans=x-y;
        return ans;
       } 
      public int Prod(int x,int y)
       {
        int ans;
        ans=x*y;
        return ans;
       } 
      public double Quot(double x,double y)
       {
        double ans;
        ans=x/y;
        return ans;
       } 
      public double Avg(double x,double y)
       {
        double ans;
        ans=((x=y)/2);
        return ans;
       } 
    }   
}
 