using UnityEngine;

[System.Serializable]
public class test
{
    public string name;
    public int lives;
    public float health;

    public static test CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<test>(jsonString);
    }

    // Given JSON input:
    // {"name":"Dr Charles","lives":3,"health":0.8}
    // this example will return a PlayerInfo object with
    // name == "Dr Charles", lives == 3, and health == 0.8f.
}
