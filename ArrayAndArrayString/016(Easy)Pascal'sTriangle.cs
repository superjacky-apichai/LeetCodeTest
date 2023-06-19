using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Array
{
    public class pascalsTriangle
    {

        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> layer1 = new List<IList<int>>();
            if (numRows < 2)
            {
                layer1.Add(new List<int> { 1 });
            }
            else
            {
                layer1.Add(new List<int> { 1 });
                layer1.Add(new List<int> { 1, 1 });
            }


            for (int i = 3; i <= numRows; i++)
            {
                IList<int> layer2 = new List<int>();
                layer2.Add(1);
                for (int j = 0; j < layer1[i - 2].Count - 1; j++)
                {
                    layer2.Add(layer1[i - 2][j] + layer1[i - 2][j + 1]);
                }
                layer2.Add(1);
                layer1.Add(layer2);

            }


            return layer1;
        }

    }
}