using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDoor : MonoBehaviour, IInteractable
{
    public GameObject panel;
    public void Action()
    {
        panel.SetActive(true);
    }

}
