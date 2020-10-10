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

    public class Cube {
        public Cube(int[] sides) {
            Sides = sides;
            Lines = CreateLines();
        }

        int[][] CreateLines() {
            var l0 = new int[] { Sides[0], Sides[1], Sides[2], Sides[3] };
            var l1 = new int[] { Sides[0], Sides[4], Sides[2], Sides[5] };
            var l2 = new int[] { Sides[1], Sides[4], Sides[3], Sides[5] };
            var res = new int[][] { l0, l1, l2 };
            return res;
        }

        public int[] GetPosition(int line, int index) {
            var currentTine = Lines[line];
            var res = new int[4];
            for(int i = 0; i < 4; i++) {
                res[i] = currentTine[index];
                index++;
                if(index > 3) {
                    index = 0;
                }
            }
            return res;
        }

        public int[] Sides { get; set; }
        public int[][] Lines { get; set; }

    }
}
