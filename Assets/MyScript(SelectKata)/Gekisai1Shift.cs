using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gekisai1Shift : MonoBehaviour
{
    [SerializeField] Toggle Switch;


    public void OnClickGekisai1ShiftButton()
    {
        if (Switch.isOn)
        {
            SceneManager.LoadScene("Gekisai1 mirror");
        }
        else
        {
            SceneManager.LoadScene("Gekisai1");
        }
    }

}
