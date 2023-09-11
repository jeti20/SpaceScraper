using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


//script checking if any object entered the trash
public class TrashTriggerZone : MonoBehaviour
{
    public string targetTag;
    public UnityEvent<GameObject> OnEnterEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == targetTag)
        {
            OnEnterEvent.Invoke(other.gameObject);
        }
    }
}
