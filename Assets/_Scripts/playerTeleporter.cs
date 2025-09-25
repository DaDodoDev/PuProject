using UnityEngine;

public class playerTeleporter : MonoBehaviour
{
    public int positionToTeleport;

    public GameObject[] level;
    public int howFarToTeleport;

    public int offset;

    public int whatLevel;

    public Transform cam;

    public int camOffset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        whatLevel = 0;

        for (int i = 1; i < level.Length; i++)
        {
            level[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > positionToTeleport)
        {
            whatLevel++;
            transform.position = new  Vector3(positionToTeleport + offset, 0, 0);
            cam.position = new   Vector3(transform.position.x + camOffset, 0, -10);
            positionToTeleport += howFarToTeleport + offset;
            level[whatLevel].SetActive(true);
            
        }
    }
}
