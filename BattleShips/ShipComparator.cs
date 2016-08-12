using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Battleships
{
    class ShipComparator : IComparer
    {
        /**
         * compare two ships to see if they are the same based on column, row and type
         * ignore emptysea
         * @param Object object one
         * @param Object object two
         * @return int the result of the comparison for emptysea this will be zero
         */
            
        int IComparer.Compare(Object o1, Object o2)
        {
            Ship p1 = (Ship)o1;
            Ship p2 = (Ship)o2;

            if (p1.getShipType() == "EmptySea")
                    return 0;
            if (p1.getBowRow() != p2.getBowRow())
                return p1.getBowRow().CompareTo(p2.getBowRow());
            else if (p1.getBowColumn() != p2.getBowColumn())
                return p1.getBowColumn().CompareTo(p2.getBowColumn());
            return p1.getShipType().CompareTo(p2.getShipType());
        }
       
        bool equals(Object obj) {
            return this.equals(obj);
        }
    }
}



