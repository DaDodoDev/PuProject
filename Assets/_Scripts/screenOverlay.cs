using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class screenOverlay : MonoBehaviour
{
    public float howFastTurnSolid;

    public bool turnSolid;
    
    public SpriteRenderer spriteRenderer;

    public Image[] image;

    public GameObject[] overlayButton;
    public TMP_Text[] text;
    public float floatNow;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < overlayButton.Length; i++)
        {
            overlayButton[i].SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (turnSolid)
        {
            floatNow += howFastTurnSolid* Time.deltaTime;
            for (int i = 0; i < overlayButton.Length; i++)
            {
                overlayButton[i].SetActive(true);
                image[i].color = Color.Lerp( Color.clear, Color.white, floatNow);
                text[i].color = Color.Lerp( Color.clear, Color.black, floatNow);
            }
            
            
            
            spriteRenderer.color = Color.Lerp( Color.clear,Color.white, floatNow);
            
        }
    }
}
