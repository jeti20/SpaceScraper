using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Script makes turn off the object when throwed to trash. 
public class TrashCan : MonoBehaviour
{
    private void Start()
    {
        GetComponent<TrashTriggerZone>().OnEnterEvent.AddListener(InsideTrash);
    }

    public void InsideTrash(GameObject go)
    {
        go.SetActive(false);
    }
}
