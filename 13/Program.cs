int num =new Random().Next(25,100000);
Console.WriteLine(num);
if(num<100)
Console.WriteLine(" Третьего числа нет");
if(num<1000 && num>=100) 
   num=num%10;
Console.WriteLine($"Третье число -> {num}");
if(num>=1000)
{ while(num>999)
  {
   num=num/10;
  };
  num=num%10;
     Console.WriteLine($"Третье число -> {num} ");
     }


   
