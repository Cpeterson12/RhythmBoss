
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class healthBarBehaviour : MonoBehaviour
{
    //http://gyanendushekhar.com/2019/11/17/create-health-bar-unity-3d/
    private static Image HealthBarImage;
    public static UnityEvent ZeroLife;
 
    
    public static void UpdateHealthBarValue(float value)
    {
        HealthBarImage.fillAmount += value;

        if (HealthBarImage.fillAmount <= 0f)
        {
            ZeroLife.Invoke();
        }
        else if(HealthBarImage.fillAmount < 0.2f)
        {
            SetHealthBarColor(Color.red);
        }
        else if(HealthBarImage.fillAmount < 0.4f)
        {
            SetHealthBarColor(Color.yellow);
        }
        else
        {
            SetHealthBarColor(Color.green);
        }
    }
 
    public static float GetHealthBarValue()
    {
        return HealthBarImage.fillAmount;
    }
 
   
    public static void SetHealthBarColor(Color healthColor)
    {
        HealthBarImage.color = healthColor;
    }
 
    
    private void Start()
    {
        HealthBarImage = GetComponent<Image>();
    }
   
    public static void SetHealthBarValue(float value)
    {
        HealthBarImage.fillAmount = value;
        if(HealthBarImage.fillAmount < 0.2f)
        {
            SetHealthBarColor(Color.red);
        }
        else if(HealthBarImage.fillAmount < 0.4f)
        {
            SetHealthBarColor(Color.yellow);
        }
        else
        {
            SetHealthBarColor(Color.green);
        }
    }
}