using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent2020.App.DayOne
{
    public class ReportRepair
    {
        public void RunFirstDemo()
        {
            int targetSum = 2020;
            int entry = 0,
                nextEntry = 0,
                currentSum = 0;

            for (int i = 0; i < expenseEntries.Length; i++)
            {
                entry = expenseEntries[i];

                for (int y = 0; y < expenseEntries.Length; y++)
                {
                    if (i != y)
                    {
                        nextEntry = expenseEntries[y];
                        currentSum = entry + nextEntry;

                        if (currentSum == targetSum)
                        {
                            var result = entry * nextEntry;

                            Console.WriteLine($"\nThe magic combination was found on row {i + 1} and {y + 1}. The result was {entry} * {nextEntry} = {result}");
                            Console.WriteLine("\nAdvent answer: \"That's the right answer! You are one gold star closer to saving your vacation.\"\n");

                            return;
                        }
                    }
                }


            }
        }

        public void RunSecondDemo()
        {
            int targetSum = 2020;
            int entry = 0,
                nextEntry = 0,
                thirdEntry = 0,
                currentSum = 0;

            for (int i = 0; i < expenseEntries.Length; i++)
            {
                entry = expenseEntries[i];

                for (int y = 0; y < expenseEntries.Length; y++)
                {
                    if (i != y)
                    {
                        nextEntry = expenseEntries[y];

                        for (int k = 0; k < expenseEntries.Length; k++)
                        {
                            if (i != k && y != k)
                            {
                                thirdEntry = expenseEntries[k];
                                currentSum = entry + nextEntry + thirdEntry;

                                if (currentSum == targetSum)
                                {
                                    var result = entry * nextEntry * thirdEntry;

                                    Console.WriteLine($"\nThe magic combination was found on row {i + 1}, {y + 1} and {k + 1}. The result was {entry} * {nextEntry} * {thirdEntry} = {result}");
                                    Console.WriteLine("\nAdvent answer: \"That's the right answer! You are one gold star closer to saving your vacation.\"\n");

                                    return;
                                }
                            }
                        }
                    }
                }


            }
        }

        private static int[] expenseEntries = new int[]
        {
            1981,
            1415,
            1767,
            1725,
            1656,
            1860,
            1272,
            1582,
            1668,
            1202,
            1360,
            1399,
            1517,
            1063,
            1773,
            1194,
            1104,
            1652,
            1316,
            1883,
            1117,
            522 ,
            1212,
            1081,
            1579,
            1571,
            1393,
            243 ,
            1334,
            1934,
            1912,
            1784,
            1648,
            1881,
            1362,
            1974,
            1592,
            1639,
            1578,
            1650,
            1771,
            1384,
            1374,
            1569,
            1785,
            1964,
            1910,
            1787,
            1865,
            1373,
            1678,
            1708,
            1147,
            1426,
            1323,
            855 ,
            1257,
            1497,
            1326,
            1764,
            1793,
            1993,
            1926,
            1387,
            1441,
            1332,
            1018,
            1949,
            1807,
            1431,
            1933,
            2009,
            1840,
            1628,
            475 ,
            1601,
            1903,
            1294,
            1942,
            1080,
            1817,
            1848,
            1097,
            1600,
            1833,
            1665,
            1919,
            1408,
            1963,
            1140,
            1558,
            1847,
            1491,
            1367,
            1826,
            1454,
            1714,
            2003,
            1378,
            1301,
            1520,
            1269,
            1820,
            1252,
            1760,
            1135,
            1893,
            1904,
            1956,
            1344,
            1743,
            1358,
            1489,
            1174,
            1675,
            1765,
            1093,
            1543,
            1940,
            1634,
            1778,
            1732,
            1423,
            1308,
            1855,
            962 ,
            1873,
            1692,
            1485,
            1766,
            1287,
            1388,
            1671,
            1002,
            1524,
            1891,
            1627,
            1155,
            1185,
            1122,
            1603,
            1989,
            1343,
            1745,
            1868,
            1166,
            1253,
            1136,
            1803,
            1733,
            1310,
            1762,
            1319,
            1930,
            1637,
            1726,
            1446,
            266 ,
            1121,
            1851,
            1819,
            1284,
            1959,
            1449,
            1965,
            1687,
            1079,
            1808,
            1839,
            1626,
            1359,
            1935,
            1247,
            1932,
            1951,
            1318,
            1597,
            1268,
            643 ,
            1938,
            1741,
            1721,
            1640,
            1238,
            1976,
            1237,
            1960,
            1805,
            1757,
            1990,
            1276,
            1157,
            1469,
            1794,
            1914,
            1982,
            1115,
            1907,
            1846,
            1674
        };
    }
}
