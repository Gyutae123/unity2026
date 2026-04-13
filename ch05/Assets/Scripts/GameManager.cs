using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Image hpGauge;

    public void DecreaseHP()
    {
        hpGauge.fillAmount = 0.1f;
    }
}
