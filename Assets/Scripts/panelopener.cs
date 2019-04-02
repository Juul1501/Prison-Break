using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelopener : MonoBehaviour
{
    public GameObject panel;
    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController fps;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (panel.activeInHierarchy == true)
        {
            fps.enabled = false;
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = (true);
        }
        else
        {
            fps.enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = (false);
        }
    }
}
