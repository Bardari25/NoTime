using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToPlayButton : MonoBehaviour
{
    public void ShowHowToPlayScene()
    {
        SceneManager.LoadScene("NasilOynanir"); // "Nas�l Oynan�r" sahnesini a�
    }
}
