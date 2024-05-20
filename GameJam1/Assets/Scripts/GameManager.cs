using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private int diamondCount;
    public int totalDiamonds = 9; // Toplam elmas sayýsý

    public TextMeshProUGUI diamondCountText; // Elmas sayýsýný gösteren metin bileþeni
    public GameObject congratsMessage; // Tebrik mesajý UI
    public GameObject restartButton; // Yeniden baþlat butonu

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
        UpdateDiamondCountText(); // Baþlangýçta elmas sayýsýný göster
        congratsMessage.SetActive(false); // Tebrik mesajýný baþta gizliyoruz
        restartButton.SetActive(false); // Yeniden baþlat butonunu baþta gizliyoruz
    }

    public void AddDiamond(int amount)
    {
        diamondCount += amount;
        Debug.Log("Toplam elmas: " + diamondCount);

        // Tüm elmaslar toplandýðýnda oyunu bitir
        if (diamondCount >= totalDiamonds)
        {
            EndGame();
        }
        else
        {
            UpdateDiamondCountText(); // Elmas sayýsýný güncelle
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
        // Tebrik mesajýný göster
        congratsMessage.SetActive(true);

        // Oyunu durdur
        Time.timeScale = 0;

        // Yeniden baþlat butonunu göster
        restartButton.SetActive(true);
    }
}
