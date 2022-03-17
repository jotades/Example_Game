using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Exagon
{
    class exagon
    {
        private int direction; //field
        public List<int> SequencePosition = new List<int>();

        public exagon(/*int _direction*/) //constructor
        {
           // direction = _direction;
            //SequencePosition = new List<int>(); 
        }
        public int Direction //property
        {
            get
            {
                direction = Random.Range(0, 3);
                return direction;
            }
            set
            {
                direction = value;
            }
        }
        public void ShowList()
        {
            foreach (int direction in SequencePosition)
            {
                Debug.Log(Direction);
            }
        }
        
        
    }
}