using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class boat : MonoBehaviour, IInteractable
{
    public GameObject panel;
    public void Action()
    {
        if (Inventory.instance.HasRaftParts())
        {
            panel.SetActive(true);
        }
    }
}
