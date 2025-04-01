using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private List<GameObject> allObjects;

    private void OnCollisionEnter(Collision collision)
    {
        for (int i = 0; i < allObjects.Count; ++i)
        {
            allObjects[i].GetComponent<Collider>().enabled = false;
        }
    }
}
