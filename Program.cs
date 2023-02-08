using System;

namespace HexToBinaryConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter 1 to convert hex to binary");
                Console.WriteLine("Enter 2 to convert binary to hex");
                Console.WriteLine("Enter 3 to exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Enter hexadecimal number: ");
                    string hex = Console.ReadLine();
                    Console.WriteLine("Binary: " + HexToBinary(hex));
                }
                else if (choice == 2)
                {
                    Console.Write("Enter binary number: ");
                    string binary = Console.ReadLine();
                    Console.WriteLine("Hexadecimal: " + BinaryToHex(binary));
                }
                else if (choice == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.WriteLine();
            }
        }

        static string HexToBinary(string hex)
        {
            string binary = "";
            foreach (char c in hex)
            {
                int value = Convert.ToInt32(c.ToString(), 16);
                binary += Convert.ToString(value, 2).PadLeft(4, '0');
            }
            return binary;
        }

        static string BinaryToHex(string binary)
        {
            string hex = "";
            for (int i = 0; i < binary.Length; i += 4)
            {
                int value = Convert.ToInt32(binary.Substring(i, 4), 2);
                hex += string.Format("{0:X}", value);
            }
            return hex;
        }
    }
}
