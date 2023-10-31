using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureVanish : MonoBehaviour
{
    public GameObject creature;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Destroy(creature);
        }
    }




}
