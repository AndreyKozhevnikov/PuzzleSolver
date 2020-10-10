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
    public class Solver {

       Cube[]  PrepareCubes() {
            var c1 = new Cube(new int[]{1,1000,100,10,1,10 });
            var c2 = new Cube(new int[]{1,1000,10,100,1,1000 });
            var c3 = new Cube(new int[]{1,10,100,1000,1000,1000});
            var c4 = new Cube(new int[]{1,1000,100,100,10,10});

            var res = new Cube[] { c1, c2, c3, c4 };
            return res;
        }

        public void Solve() {
            var cubes = PrepareCubes();

            for(int i = 0; i < 4; i++) {
                
            }

        }

    }
}
