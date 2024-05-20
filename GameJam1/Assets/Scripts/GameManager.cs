using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private int diamondCount;
    public int totalDiamonds = 9; // Toplam elmas say�s�

    public TextMeshProUGUI diamondCountText; // Elmas say�s�n� g�steren metin bile�eni
    public GameObject congratsMessage; // Tebrik mesaj� UI
    public GameObject restartButton; // Yeniden ba�lat butonu

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        diamondCount = 0;
        UpdateDiamondCountText(); // Ba�lang��ta elmas say�s�n� g�ster
        congratsMessage.SetActive(false); // Tebrik mesaj�n� ba�ta gizliyoruz
        restartButton.SetActive(false); // Yeniden ba�lat butonunu ba�ta gizliyoruz
    }

    public void AddDiamond(int amount)
    {
        diamondCount += amount;
        Debug.Log("Toplam elmas: " + diamondCount);

        // T�m elmaslar topland���nda oyunu bitir
        if (diamondCount >= totalDiamonds)
        {
            EndGame();
        }
        else
        {
            UpdateDiamondCountText(); // Elmas say�s�n� g�ncelle
        }
    }

    void UpdateDiamondCountText()
    {
        if (diamondCountText != null)
        {
            diamondCountText.text = "Diamonds: " + diamondCount.ToString();
        }
    }

    void EndGame()
    {
        // Tebrik mesaj�n� g�ster
        congratsMessage.SetActive(true);

        // Oyunu durdur
        Time.timeScale = 0;

        // Yeniden ba�lat butonunu g�ster
        restartButton.SetActive(true);
    }
}
