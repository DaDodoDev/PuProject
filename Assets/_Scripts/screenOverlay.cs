using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class screenOverlay : MonoBehaviour
{
    public float howFastTurnSolid;

    public bool turnSolid;
    
    public SpriteRenderer spriteRenderer;

    public Image image;

    public GameObject overlayButton;
    public TMP_Text text;
    public float floatNow;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        overlayButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (turnSolid)
        {
            overlayButton.SetActive(true);
            floatNow += howFastTurnSolid* Time.deltaTime;
            
            spriteRenderer.color = Color.Lerp( Color.clear,Color.white, floatNow);
            image.color = Color.Lerp( Color.clear, Color.white, floatNow);
            text.color = Color.Lerp( Color.clear, Color.black, floatNow);
        }
    }
}
