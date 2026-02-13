using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Resimdeğişim : MonoBehaviour
{
    public Sprite[] kediler;
    public Image değişecekimage;
    private int resimsayacı = 0;

    public void ResimDegiş()
    {
        resimsayacı++;
        if (resimsayacı < kediler.Length)
        {
            değişecekimage.sprite = kediler[resimsayacı];
        }

        // Eğer hedef sayıya ulaşıldıysa (Örn: 12. tıklama)
        if (resimsayacı >= 13)
        {
            StartCoroutine(SahneGecisSureci());
        }
    }
    IEnumerator SahneGecisSureci()
    {
        // 1. Ekranın kararmasını başlat ve BİTMESİNİ BEKLE
        yield return StartCoroutine(SceneFader.instance.Fade(2f));

        // 2. Kararma bitti (buraya ancak 2 saniye sonra gelir)
        int mevcutSahneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(mevcutSahneIndex + 1);
    }

}
