int[] myArray = new int[10];

Random rand = new Random();
for (int x = 0; x < myArray.Length; x++)
      {
          myArray[x] = rand.Next(30);
          Console.Write(myArray[x] + " ");
      }
      Console.WriteLine();
for (int x = 0; x < myArray.Length; x++)
      {
          if (myArray[x] % 2 == 0) {
        Console.Write(myArray[x] + " ");
        }
      }


