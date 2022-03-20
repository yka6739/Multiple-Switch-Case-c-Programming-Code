int choice,choice1,price,Dis,FAmount;
Console.WriteLine("Press 1 for TV\n Press 2 for Ac\n Press 3 for Computer");
choice = Convert.ToInt32(Console.ReadLine());  
switch(choice)
{
    case 1:
        {
            Console.WriteLine("You Choose TV\n");
            Console.WriteLine("Press 1 for 32 inch TV\n Press 2 for 64 inch TV\n Press 3 for 44 inch TV");
            choice1 = Convert.ToInt32(Console.ReadLine());

            switch (choice1)
            {
                case 1:
                    {
                        Console.WriteLine("Enter Your Price");
                        price = Convert.ToInt32(Console.ReadLine());
                       if(price>20000)
                        {
                            Dis = (price * 20) / 100;
                            FAmount = price - Dis;
                            Console.WriteLine("Price is " + price + "\n Total Dis is " + Dis + "Final Amount Need to be pay is" + FAmount);
                        }
                       else if(price>15000)
                        {
                            Dis = (price * 15) / 100;
                            FAmount = price - Dis;
                            Console.WriteLine("Price is " + price + "\n Total Dis is " + Dis + "Final Amount Need to be pay is" + FAmount);
                        }
                       else
                        {
                            Dis = (price * 5) / 100;
                            FAmount = price - Dis;
                            Console.WriteLine("Price is " + price + "\n Total Dis is " + Dis + "Final Amount Need to be pay is" + FAmount);
                        }

                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter Your Price");
                        price = Convert.ToInt32(Console.ReadLine());
                        if (price > 20000)
                        {
                            Dis = (price * 20) / 100;
                            FAmount = price - Dis;
                            Console.WriteLine("Price is " + price + "\n Total Dis is " + Dis + "Final Amount Need to be pay is" + FAmount);
                        }
                        else if (price > 15000)
                        {
                            Dis = (price * 15) / 100;
                            FAmount = price - Dis;
                            Console.WriteLine("Price is " + price + "\n Total Dis is " + Dis + "Final Amount Need to be pay is" + FAmount);
                        }
                        else
                        {
                            Dis = (price * 5) / 100;
                            FAmount = price - Dis;
                            Console.WriteLine("Price is " + price + "\n Total Dis is " + Dis + "Final Amount Need to be pay is" + FAmount);
                        }

                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter Your Price");
                        price = Convert.ToInt32(Console.ReadLine());
                        if (price > 20000)
                        {
                            Dis = (price * 20) / 100;
                            FAmount = price - Dis;
                            Console.WriteLine("Price is " + price + "\n Total Dis is " + Dis + "Final Amount Need to be pay is" + FAmount);
                        }
                        else if (price > 15000)
                        {
                            Dis = (price * 15) / 100;
                            FAmount = price - Dis;
                            Console.WriteLine("Price is " + price + "\n Total Dis is " + Dis + "Final Amount Need to be pay is" + FAmount);
                        }
                        else
                        {
                            Dis = (price * 5) / 100;
                            FAmount = price - Dis;
                            Console.WriteLine("Price is " + price + "\n Total Dis is " + Dis + "Final Amount Need to be pay is" + FAmount);
                        }
                        break;
                    }

                default:
                    {
                        Console.WriteLine("iNVALID CHOICE");
                        break;
                    }
            }

        break;
        }
   case 2:
        {
            Console.WriteLine("You Choose AC\n");
            Console.WriteLine("Press 1 for Split AC\n Press 2 for Window AC");
            choice1 = Convert.ToInt32(Console.ReadLine());
            switch(choice1)
            {
                case 1:
                    {
                        Console.WriteLine("Enter Your Price");
                        price = Convert.ToInt32(Console.ReadLine());
                        if(price>25000)
                        {
                            Dis = (price * 25) / 100;
                            FAmount = price - Dis;
                            Console.WriteLine("Price is " + price + "\n Total Dis is " + Dis + "Final Amount Need to be pay is" + FAmount);

                        }
                        else if (price > 15000)
                        {
                            Dis = (price * 15) / 100;
                            FAmount = price - Dis;
                            Console.WriteLine("Price is " + price + "\n Total Dis is " + Dis + "Final Amount Need to be pay is" + FAmount);
                        }
                        else
                        {
                            Dis = (price * 5) / 100;
                            FAmount = price - Dis;
                            Console.WriteLine("Price is " + price + "\n Total Dis is " + Dis + "Final Amount Need to be pay is" + FAmount);
                        }


                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter Your Price");
                        price = Convert.ToInt32(Console.ReadLine());
                        if (price > 25000)
                        {
                            Dis = (price * 15) / 100;
                            FAmount = price - Dis;
                            Console.WriteLine("Price is " + price + "\n Total Dis is " + Dis + "Final Amount Need to be pay is" + FAmount);

                        }
                        else if (price > 15000)
                        {
                            Dis = (price * 10) / 100;
                            FAmount = price - Dis;
                            Console.WriteLine("Price is " + price + "\n Total Dis is " + Dis + "Final Amount Need to be pay is" + FAmount);
                        }
                        else
                        {
                            Dis = (price * 5) / 100;
                            FAmount = price - Dis;
                            Console.WriteLine("Price is " + price + "\n Total Dis is " + Dis + "Final Amount Need to be pay is" + FAmount);
                        }

                        break;
                    }
                default :
                    {
                        Console.WriteLine("iNVALID CHOICE");
                        break;
                    }
            }
            break;
        }
    case 3:
        {
            Console.WriteLine("You Choose Computer\n");
            Console.WriteLine("Press 1 for Desktop Computer\n Press 2 for Laptop Computer\n Press 3 for Tablets");
            choice1 = Convert.ToInt32(Console.ReadLine());
            switch(choice1)
            {
                case 1:
                    {
                        Console.WriteLine("Enter Your Price");
                        price = Convert.ToInt32(Console.ReadLine());
                        if (price > 25000)
                        {
                            Dis = (price * 15) / 100;
                            FAmount = price - Dis;
                            Console.WriteLine("Price is " + price + "\n Total Dis is " + Dis + "Final Amount Need to be pay is" + FAmount);

                        }
                        else if (price > 15000)
                        {
                            Dis = (price * 10) / 100;
                            FAmount = price - Dis;
                            Console.WriteLine("Price is " + price + "\n Total Dis is " + Dis + "Final Amount Need to be pay is" + FAmount);
                        }
                        else
                        {
                            Dis = (price * 5) / 100;
                            FAmount = price - Dis;
                            Console.WriteLine("Price is " + price + "\n Total Dis is " + Dis + "Final Amount Need to be pay is" + FAmount);
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter Your Price");
                        price = Convert.ToInt32(Console.ReadLine());
                        if (price > 25000)
                        {
                            Dis = (price * 15) / 100;
                            FAmount = price - Dis;
                            Console.WriteLine("Price is " + price + "\n Total Dis is " + Dis + "Final Amount Need to be pay is" + FAmount);

                        }
                        else if (price > 15000)
                        {
                            Dis = (price * 10) / 100;
                            FAmount = price - Dis;
                            Console.WriteLine("Price is " + price + "\n Total Dis is " + Dis + "Final Amount Need to be pay is" + FAmount);
                        }
                        else
                        {
                            Dis = (price * 5) / 100;
                            FAmount = price - Dis;
                            Console.WriteLine("Price is " + price + "\n Total Dis is " + Dis + "\nFinal Amount Need to be pay is" + FAmount);
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter Your Price");
                        price = Convert.ToInt32(Console.ReadLine());
                        if (price > 25000)
                        {
                            Dis = (price * 15) / 100;
                            FAmount = price - Dis;
                            Console.WriteLine("Price is " + price + "\n Total Dis is " + Dis + "Final Amount Need to be pay is" + FAmount);

                        }
                        else if (price > 15000)
                        {
                            Dis = (price * 10) / 100;
                            FAmount = price - Dis;
                            Console.WriteLine("Price is " + price + "\n Total Dis is " + Dis + "Final Amount Need to be pay is" + FAmount);
                        }
                        else
                        {
                            Dis = (price * 5) / 100;
                            FAmount = price - Dis;
                            Console.WriteLine("Price is " + price + "\n Total Dis is " + Dis + "Final Amount Need to be pay is" + FAmount);
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Choice");
                        break;
                    }

            }
            break;
        }
    default:
        {
            Console.WriteLine("Item Not Available");
            break;
        }
}