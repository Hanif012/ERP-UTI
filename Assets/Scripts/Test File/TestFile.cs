using UnityEngine;
using TMPro;

public class TestFile : MonoBehaviour
{
    public TMP_Text text;

    private void Start() {
        text.text = Application.persistentDataPath + "/saveData.save";
    }
}
