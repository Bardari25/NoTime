using UnityEngine;

//public class Diamond : MonoBehaviour
//{
//    void OnTriggerEnter(Collider other)
//    {
//        Debug.Log("OnTriggerEnter called with " + other.name); // OnTriggerEnter tetiklendiðinde konsolda görünecek

//        if (other.CompareTag("Player"))
//        {
//            Debug.Log("Player collided with diamond"); // Player tag'li nesne ile çarpýþma olduðunda konsolda görünecek

//            GameManager.instance.AddDiamond(1); // GameManager'daki AddDiamond metodunu çaðýrýn ve sayacý arttýrýn
//            Destroy(gameObject); // Elmasý yok edin
//        }
//    }
//}



public class Diamond : MonoBehaviour
{
    public int diamondValue = 1; // Her elmasýn kaç puan deðeri olduðunu belirtir

    void OnTriggerEnter(Collider other)
    {
        // Eðer elmas, oyuncunun collider'ýyla temas ederse
        if (other.CompareTag("Player"))
        {
            CollectDiamond(); // Elmasý toplamak için fonksiyonu çaðýr
        }
    }

    void CollectDiamond()
    {
        // Elmasýn toplanma efektini oynat (isteðe baðlý)
        // Instantiate(diamondPickupEffect, transform.position, Quaternion.identity);

        // Elmasý sayaca ekle
        GameManager.instance.AddDiamond(diamondValue);

        // Elmas nesnesini yok et
        Destroy(gameObject);
    }
}
