

namespace P06_Sneaking
{
    using System;

    public class Sneaking
    {
        static char[][] room;

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            room = new char[n][];

            GetRoom(room);

            var moves = Console.ReadLine().ToCharArray();
            var samPosition = FindSam(room);

            for (int i = 0; i < moves.Length; i++)
            {
                MovesEnemies(room);

                var getEnemy = GetEnemy(room, samPosition);

                if (CheckSamIsDead(room, getEnemy, samPosition))
                {
                    break;
                }

                MoveSam(room, samPosition, moves[i]);

                getEnemy = GetEnemy(room, samPosition);

                if (CheckNikladzeIsDead(getEnemy, samPosition, room))
                {
                    break;
                }
            }
        }

        private static bool CheckNikladzeIsDead(int[] getEnemy, int[] samPosition, char[][] c)
        {
            var nikoladzheIsdead = false;
            if (room[getEnemy[0]][getEnemy[1]] == 'N' && samPosition[0] == getEnemy[0])
            {
                nikoladzheIsdead = true;
                room[getEnemy[0]][getEnemy[1]] = 'X';
                Console.WriteLine("Nikoladze killed!");
                for (int row = 0; row < room.Length; row++)
                {
                    for (int col = 0; col < room[row].Length; col++)
                    {
                        Console.Write(room[row][col]);
                    }
                    Console.WriteLine();
                }

            }

            return nikoladzheIsdead;
        }

        private static void MoveSam(char[][] room, int[] samPosition, char move)
        {
            room[samPosition[0]][samPosition[1]] = '.';
            switch (move)
            {
                case 'U':
                    samPosition[0]--;
                    break;
                case 'D':
                    samPosition[0]++;
                    break;
                case 'L':
                    samPosition[1]--;
                    break;
                case 'R':
                    samPosition[1]++;
                    break;
                default:
                    break;
            }
            room[samPosition[0]][samPosition[1]] = 'S';
        }

        private static bool CheckSamIsDead(char[][] c, int[] getEnemy, int[] samPosition)
        {
            var samIsDead = false;
            if (samPosition[1] < getEnemy[1] && room[getEnemy[0]][getEnemy[1]] == 'd' && getEnemy[0] == samPosition[0])
            {
                samIsDead = true;
                room[samPosition[0]][samPosition[1]] = 'X';
                Console.WriteLine($"Sam died at {samPosition[0]}, {samPosition[1]}");
                for (int row = 0; row < room.Length; row++)
                {
                    for (int col = 0; col < room[row].Length; col++)
                    {
                        Console.Write(room[row][col]);
                    }
                    Console.WriteLine();
                }
            }

            else if (getEnemy[1] < samPosition[1] && room[getEnemy[0]][getEnemy[1]] == 'b' && getEnemy[0] == samPosition[0])
            {
                samIsDead = true;
                room[samPosition[0]][samPosition[1]] = 'X';
                Console.WriteLine($"Sam died at {samPosition[0]}, {samPosition[1]}");
                for (int row = 0; row < room.Length; row++)
                {
                    for (int col = 0; col < room[row].Length; col++)
                    {
                        Console.Write(room[row][col]);
                    }
                    Console.WriteLine();
                }
                Environment.Exit(0);
            }

            return samIsDead;
        }

        private static int[] GetEnemy(char[][] room, int[] samPosition)
        {
            var getEnemy = new int[2];
            for (int j = 0; j < room[samPosition[0]].Length; j++)
            {
                if (room[samPosition[0]][j] != '.' && room[samPosition[0]][j] != 'S')
                {
                    getEnemy[0] = samPosition[0];
                    getEnemy[1] = j;
                }
            }

            return getEnemy;
        }

        private static void MovesEnemies(char[][] room)
        {
            for (int row = 0; row < room.Length; row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    if (room[row][col] == 'b')
                    {
                        if (row >= 0 && row < room.Length && col + 1 >= 0 && col + 1 < room[row].Length)
                        {
                            room[row][col] = '.';
                            room[row][col + 1] = 'b';
                            col++;
                        }
                        else
                        {
                            room[row][col] = 'd';
                        }
                    }
                    else if (room[row][col] == 'd')
                    {
                        if (row >= 0 && row < room.Length && col - 1 >= 0 && col - 1 < room[row].Length)
                        {
                            room[row][col] = '.';
                            room[row][col - 1] = 'd';
                        }
                        else
                        {
                            room[row][col] = 'b';
                        }
                    }
                }
            }
        }

        private static int[] FindSam(char[][] room)
        {
            var samPosition = new int[2];
            for (int row = 0; row < room.Length; row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    if (room[row][col] == 'S')
                    {
                        samPosition[0] = row;
                        samPosition[1] = col;

                        return samPosition;
                    }
                }
            }

            return samPosition;
        }

        private static void GetRoom(char[][] room)
        {
            for (int row = 0; row < room.GetLength(0); row++)
            {
                var input = Console.ReadLine().ToCharArray();
                room[row] = new char[input.Length];
                for (int col = 0; col < input.Length; col++)
                {
                    room[row][col] = input[col];
                }
            }
        }
    }
}
