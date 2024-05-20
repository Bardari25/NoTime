using UnityEngine;

//public class Diamond : MonoBehaviour
//{
//    void OnTriggerEnter(Collider other)
//    {
//        Debug.Log("OnTriggerEnter called with " + other.name); // OnTriggerEnter tetiklendi�inde konsolda g�r�necek

//        if (other.CompareTag("Player"))
//        {
//            Debug.Log("Player collided with diamond"); // Player tag'li nesne ile �arp��ma oldu�unda konsolda g�r�necek

//            GameManager.instance.AddDiamond(1); // GameManager'daki AddDiamond metodunu �a��r�n ve sayac� artt�r�n
//            Destroy(gameObject); // Elmas� yok edin
//        }
//    }
//}



public class Diamond : MonoBehaviour
{
    public int diamondValue = 1; // Her elmas�n ka� puan de�eri oldu�unu belirtir

    void OnTriggerEnter(Collider other)
    {
        // E�er elmas, oyuncunun collider'�yla temas ederse
        if (other.CompareTag("Player"))
        {
            CollectDiamond(); // Elmas� toplamak i�in fonksiyonu �a��r
        }
    }

    void CollectDiamond()
    {
        // Elmas�n toplanma efektini oynat (iste�e ba�l�)
        // Instantiate(diamondPickupEffect, transform.position, Quaternion.identity);

        // Elmas� sayaca ekle
        GameManager.instance.AddDiamond(diamondValue);

        // Elmas nesnesini yok et
        Destroy(gameObject);
    }
}
