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
        public Cube(Colors[] sides) {
            Sides = sides;
            Lines = CreateLines();
        }

        Colors[][] CreateLines() {
            var l0 = new Colors[] { Sides[0], Sides[1], Sides[2], Sides[3] };
            var l1 = new Colors[] { Sides[0], Sides[5], Sides[2], Sides[4] };
            var l2 = new Colors[] { Sides[1], Sides[5], Sides[3], Sides[4] };
            var res = new Colors[][] { l0, l1, l2 };
            return res;
        }

        public Colors[] GetPosition(int line, int index) {
            var currentTine = Lines[line];
            var res = new Colors[4];
            for(int i = 0; i < 4; i++) {
                res[i] = currentTine[index];
                index++;
                if(index > 3) {
                    index = 0;
                }
            }
            return res;
        }

        public Colors[] Sides { get; set; }
        public Colors[][] Lines { get; set; }

    }
}
