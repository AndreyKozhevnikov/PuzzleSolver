using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleSolver.Classes {
    /*Legend
   * Red - 1
   * Green - 10
   * Blue - 100
   * Yellow - 1000
   */

    [Flags]
    public enum Colors {
        Red = 0b_0000_0001,  // 1
        Green = 0b_0000_0010,  // 2
        Blue = 0b_0000_0100,  // 4
        Yellow = 0b_0000_1000,  // 8
    }

    public class Solver {

        Cube[] PrepareCubes() {
            var c0 = new Cube(new Colors[] { Colors.Red, Colors.Yellow, Colors.Blue, Colors.Green, Colors.Red, Colors.Green });
            var c1 = new Cube(new Colors[] { Colors.Red, Colors.Yellow, Colors.Green, Colors.Blue, Colors.Red, Colors.Yellow });
            var c2 = new Cube(new Colors[] { Colors.Red, Colors.Green, Colors.Blue, Colors.Yellow, Colors.Yellow, Colors.Yellow });
            var c3 = new Cube(new Colors[] { Colors.Red, Colors.Yellow, Colors.Blue, Colors.Blue, Colors.Green, Colors.Green });
            //var c0 = new Cube(new Colors[] { Colors.Red, Colors.Yellow, Colors.Blue, Colors.Green, Colors.Red, Colors.Green });
            //var c1 = new Cube(new Colors[] { Colors.Red, Colors.Yellow, Colors.Blue, Colors.Green, Colors.Red, Colors.Yellow });
            //var c2 = new Cube(new Colors[] { Colors.Red, Colors.Yellow, Colors.Blue, Colors.Green, Colors.Yellow, Colors.Yellow });
            //var c3 = new Cube(new Colors[] { Colors.Red, Colors.Yellow, Colors.Blue, Colors.Green, Colors.Green, Colors.Green });

            var res = new Cube[] { c0, c1, c2, c3 };
            return res;
        }

        public void Solve() {
            var cubes = PrepareCubes();
            //int[] position0 = new int[4];
            //int[] position1 = new int[4];
            //int[] position2 = new int[4];
            //int[] position3 = new int[4];

            Colors[][] positions = new Colors[4][];
            int k = 0;
            for(int li0 = 0; li0 < 3; li0++) { // lines 0st cube
                for(int si0 = 0; si0 < 4; si0++) { //sides 0st сube
                    positions[0] = cubes[0].GetPosition(li0, si0);
                    for(int li1 = 0; li1 < 3; li1++) {
                        for(int si1 = 0; si1 < 4; si1++) {
                            positions[1] = cubes[1].GetPosition(li1, si1);
                            for(int li2 = 0; li2 < 3; li2++) {
                                for(int si2 = 0; si2 < 4; si2++) {
                                    positions[2] = cubes[2].GetPosition(li2, si2);
                                    for(int li3 = 0; li3 < 3; li3++) {
                                        for(int si3 = 0; si3 < 4; si3++) {
                                            positions[3] = cubes[3].GetPosition(li3, si3);
                                            bool isSuccess = CalculateEnumPositions(positions);

                                            if(isSuccess) {
                                                var message = string.Format("success + {0} + {1} \\ {2} + {3} \\ {4} + {5} \\ {6} + {7}", li0, si0, li1, si1, li2, si2, li3, si3);
                                                Console.WriteLine(message);
                                                Console.ReadKey();
                                            }
                                            k++;
                                            if(k % 1000 == 0) {
                                                Console.WriteLine("k = " + k);
                                            }

                                            //   Console.ReadKey();

                                        }

                                    }
                                }

                            }
                        }
                    }
                }
            }
            Console.ReadKey();

        }
        bool CalculatePosition(int[][] positions) {
            bool res = true;
            for(int i = 0; i < 4; i++) {
                var resInt = positions[0][i] + positions[1][i] + positions[2][i] + positions[3][i];
                if(resInt != 1111) {
                    res = false;
                    //break;
                }
            }
            return res;
        }
        public bool CalculateEnumPositions(Colors[][] positions) {
            for(int i = 0; i < 4; i++) {
                var line = new Colors[] { positions[0][i], positions[1][i], positions[2][i], positions[3][i] };
                var res = CalculateEnumPosition(line);
                if(res != true) {
                    return false;
                }
            }
            return true;

        }
        public bool CalculateEnumPosition(Colors[] colors) {
            if(colors.Length != 4) {
                throw new Exception();
            }
            if(!colors.Contains(Colors.Red)) {
                return false;
            }
            if(!colors.Contains(Colors.Green)) {
                return false;
            }
            if(!colors.Contains(Colors.Blue)) {
                return false;
            }
            if(!colors.Contains(Colors.Yellow)) {
                return false;
            }

            return true;
        }

    }
}
