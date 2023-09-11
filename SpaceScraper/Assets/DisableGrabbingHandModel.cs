using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

//Script make hand prefab dissapear when you grab object with hand
public class DisableGrabbingHandModel : MonoBehaviour
{
    public GameObject leftHandModel;
    public GameObject rightHandModel;

    private void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.selectEntered.AddListener(HideGrabbingHand);
        grabInteractable.selectExited.AddListener(ShowGrabbingHand);
    }

    private void HideGrabbingHand(SelectEnterEventArgs args)
    {
        if (args.interactorObject.transform.tag =="LeftHand")
        {
            leftHandModel.SetActive(false);
        }
        else if (args.interactorObject.transform.tag == "RightHand")
        {
            rightHandModel.SetActive(false);
        }
    }

    private void ShowGrabbingHand(SelectExitEventArgs args)
    {
        if (args.interactorObject.transform.tag == "LeftHand")
        {
            leftHandModel.SetActive(true);
        }
        else if (args.interactorObject.transform.tag == "RightHand")
        {
            rightHandModel.SetActive(true);
        }
    }
}
