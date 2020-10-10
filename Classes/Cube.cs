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
            var l0= new int[] { Sides[0], Sides[1], Sides[2], Sides[3] };
            var l1= new int[] { Sides[0], Sides[5], Sides[2], Sides[6] };
            var l2= new int[] { Sides[2], Sides[5], Sides[3], Sides[6] };
            var res = new int[][] { l0, l1, l2 };
            return res;
        }

        public int[] Sides { get; set; }
        public int[][] Lines{ get; set; }
       
    }
}
