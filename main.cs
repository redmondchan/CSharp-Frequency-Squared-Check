using System;
using System.Collections.Generic;

class MainClass {

   static bool frequency(List<int> list1, List<int> list2){
     if(list1.Count != list2.Count){
       return false;
     } 
     for(int i = 0; i < list1.Count; i++) {
       int positiveIndex = list2.IndexOf(list1[i] * list1[i]);
       if(positiveIndex == -1){
         return false;
       }
       list2.RemoveAt(positiveIndex);
     }
     return true;
   }

  public static void Main (string[] args) {

    //example 1
    List<int> list1 = new List<int>(){
      1,2,3
    };

    List<int> list2 = new List<int>(){
      1,9,4
    };

    //example 2
    List<int> list3 = new List<int>(){
      1,2,3,4,5,9
    };

    List<int> list4 = new List<int>(){
      1,9,4,25,16,81
    };

    //example 3
    List<int> list5 = new List<int>(){
      1,2,3,4
    };

    List<int> list6 = new List<int>(){
      1,9,6
    };

    //example 4
    List<int> list7 = new List<int>(){
      1,2,3
    };

    List<int> list8 = new List<int>(){
      1,9,6
    };
  
    Console.WriteLine($"Example 1: {frequency(list1, list2).ToString()}");
    Console.WriteLine($"Example 2: {frequency(list3, list4).ToString()}");
    Console.WriteLine($"Example 3: {frequency(list5, list6).ToString()}");
    Console.WriteLine($"Example 4: {frequency(list7, list8).ToString()}");
 

    


  }
}