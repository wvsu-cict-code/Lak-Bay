using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue //ginremove ang Monobehaviour para pwede macall ang class sa Dialogue Trigger nga file
{
    public string cname;

    [TextArea(3,10)] //3 minimum amount of lines and 10 max
    public string[] sentences;
    

    // private int index; //dugang


    
}
