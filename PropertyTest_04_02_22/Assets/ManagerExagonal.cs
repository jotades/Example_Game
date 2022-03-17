using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Exagon
{
    public class ManagerExagonal : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // Display the number of command line arguments.
            exagon myExagon = new exagon();
            int j = 0;
            while (true)
            {
                j++;
                myExagon.SequencePosition.Add(myExagon.Direction);
                myExagon.ShowList();
                if (j > 9)
                break;               
            }
             

        }

    }
}
