using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using SimpleJSON;

public class web : MonoBehaviour
{
    public InputField enterNameField;
    public int minKills = 0;
    public GameObject panel;
    public Animator dooranimator;
    IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            webRequest.SetRequestHeader("TRN-Api-Key", "ab450e48-ae4d-4460-88be-bcd39f4f9150");
            yield return webRequest.SendWebRequest();

            if (webRequest.isNetworkError)
            {
                Debug.Log(webRequest.error);
            }
            else
            {
                JSONNode data = JSON.Parse(webRequest.downloadHandler.text);
                string kills = data["data"]["stats"][1]["value"].Value;
                int killsValue;
                if (int.TryParse(kills, out killsValue))
                {
                    killsValue = int.Parse(kills);
                }
                Debug.Log("Amount of kills: " + killsValue);
                if(killsValue > minKills)
                {
                    dooranimator.SetBool("Open", true);
                }
            }
            panel.SetActive(false);
        }
    }

    public void CheckName()
    {
        Debug.Log("click");
        string name = enterNameField.text;
        string fullUri = "https://public-api.tracker.gg/apex/v1/standard/profile/5/" + name;
        StartCoroutine(GetRequest(fullUri));
    }
}
