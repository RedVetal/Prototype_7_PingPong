using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField NameInput; // ����������� TMP_InputField!

    public void StartGame()
    {
        // ��������� ��� � DataManager
        DataManager.Instance.PlayerName = NameInput.text;

        // ������ ��������� ����� (Main)
        SceneManager.LoadScene(1);
    }
}
