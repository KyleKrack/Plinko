using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public int slotNumber;
    public int points; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log($"{other.name} entered slot {name}");
        Debug.Log($"Entered slot {slotNumber} and now gives the player {points} points");
    }
    
}
