using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField NameInput; // ќЅя«ј“≈Ћ№Ќќ TMP_InputField!

    public void StartGame()
    {
        // сохран€ем им€ в DataManager
        DataManager.Instance.PlayerName = NameInput.text;

        // грузим следующую сцену (Main)
        SceneManager.LoadScene(1);
    }
}
