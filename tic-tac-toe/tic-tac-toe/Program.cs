using System;

namespace tic_tac_toe
{
    class Program
    {

        static char[,] board = new char[3, 3]
        {
            {'1','2','3'},
            {'4','5','6'},
            {'7','8','9'}
        };
        static int turns = 0;
        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            char key = 'y';
            while(true)
            {
                setField();
                int result = checkwinner(key);
                if (result == -1)
                {
                    Console.WriteLine("Tie !");
                    Console.WriteLine("Press any key to reset game!!!");
                    Console.ReadKey();
                    resetBoard();
                    player = 2;
                    continue;
                }
                else if (result == 1)
                {
                    Console.WriteLine("Player 1 is the winner!!!!");
                    Console.WriteLine("Press any key to reset game!!!");
                    Console.ReadKey();
                    resetBoard();
                    player = 2;
                    continue;
                }
                else if (result == 2)
                {
                    Console.WriteLine("Player 2 is the winner!!!!");
                    Console.WriteLine("Press any key to reset game!!!");
                    Console.ReadKey();
                    resetBoard();
                    player = 2;
                    continue;
                }



                if (player == 2)
                {
                    player = 1;
                }
                else if(player == 1)
                {
                    player = 2;
                }

                Console.Write("\nPlayer number {0} enter the position: ", player);
                while(true)
                {
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Input entered should be a number and within range!!!");
                    }
                }
               
                

                switch(player)
                {
                    case 1:
                        while(true)
                        {
                            if (checkifalreadyoccupied(input) == true)
                            {
                                Console.Write("Position already occupied!!! Select a vacant position: ");
                                while (true)
                                {
                                    try
                                    {
                                        input = Convert.ToInt32(Console.ReadLine());
                                        break;
                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine("Input entered should be a number and within range!!!");
                                    }
                                }
                                continue;
                            }
                            else
                            {
                                key = 'X';
                                setValue(input,key);
                                break;
                            }
                        }
                        
                        break;
                    case 2:
                        while (true)
                        {
                            if (checkifalreadyoccupied(input) == true)
                            {
                                Console.Write("Position already occupied!!! Select a vacant position: ");
                                while (true)
                                {
                                    try
                                    {
                                        input = Convert.ToInt32(Console.ReadLine());
                                        break;
                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine("Input entered should be a number and within range!!!");
                                    }
                                }
                                continue;
                            }
                            else
                            {
                                key = 'O';
                                setValue(input, key);
                                break;
                            }
                        }
                        break;

                }
                turns++;
                
                
                Console.Clear();
            }
        }

        


        public static void setField()
        {
            Console.WriteLine("     |     |    ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ",board[0,0],board[0,1], board[0,2]);
            Console.WriteLine("_____|_____|____");
            Console.WriteLine("     |     |    ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ",board[1, 0], board[1, 1], board[1, 2]);
            Console.WriteLine("_____|_____|____");
            Console.WriteLine("     |     |    ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[2, 0], board[2, 1], board[2, 2]);

        }

        public static void setValue(int pos,char key)
        {
            if(pos == 1)
            {
                board[0, 0] = key;
            }
            else if(pos == 2)
            {
                board[0, 1] = key;
            }
            else if(pos == 3)
            {
                board[0, 2] = key;
            }
            else if(pos == 4)
            {
                board[1, 0] = key;
            }
            else if(pos == 5)
            {
                board[1, 1] = key;
            }
            else if(pos == 6)
            {
                board[1, 2] = key;
            }
            else if(pos == 7)
            {
                board[2, 0] = key;
            }
            else if(pos == 8)
            {
                board[2, 1] = key;
            }
            else if(pos == 9)
            {
                board[2, 2] = key;
            }
        }

        public static bool checkifalreadyoccupied(int input)
        {
            if((input == 1) && (board[0,0] == 'X' || board[0,0] == 'O'))
            {
                return true;
            }
            else if((input == 2) && (board[0, 1] == 'X' || board[0, 1] == 'O'))
            {
                return true;
            }
            else if((input == 3) && (board[0, 2] == 'X' || board[0, 2] == 'O'))
            {
                return true;
            }
            else if((input == 4) && (board[1, 0] == 'X' || board[1, 0] == 'O'))
            {
                return true;
            }
            else if((input == 5) && (board[1, 1] == 'X' || board[1, 1] == 'O'))
            {
                return true;
            }
            else if((input == 6) && (board[1, 2] == 'X' || board[1, 2] == 'O'))
            {
                return true;
            }
            else if((input == 7) && (board[2, 0] == 'X' || board[2, 0] == 'O'))
            {
                return true;
            }
            else if((input == 8) && (board[2, 1] == 'X' || board[2, 1] == 'O'))
            {
                return true;
            }
            else if((input == 9) && (board[2, 2] == 'X' || board[2, 2] == 'O'))
            {
                return true;
            }

            return false;
        }

        public static int checkwinner(char c)
        {
            if((board[0,0] == c && board[0,1] == c && board[0,2] == c) ||
                (board[1, 0] == c && board[1, 1] == c && board[1, 2] == c) ||
                (board[2, 0] == c && board[2, 1] == c && board[2, 2] == c) ||
                (board[0, 0] == c && board[1, 1] == c && board[2, 2] == c) ||
                (board[0, 2] == c && board[1, 1] == c && board[2, 0] == c) ||
                (board[0, 0] == c && board[1, 0] == c && board[2, 0] == c) ||
                (board[0, 1] == c && board[1, 1] == c && board[2, 1] == c) ||
                (board[0, 2] == c && board[1, 2] == c && board[2, 2] == c))
            {
                if(c == 'X')
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else if(turns == 9)
            {
                return -1;
            }
            else
            {
                return 0;
            }
            
        }

        public static void resetBoard()
        {
            board[0, 0] = '1';
            board[0, 1] = '2';
            board[0, 2] = '3';
            board[1, 0] = '4';
            board[1, 1] = '5';
            board[1, 2] = '6';
            board[2, 0] = '7';
            board[2, 1] = '8';
            board[2, 2] = '9';
            turns = 0;
            Console.Clear();
            

        }
    }
}
