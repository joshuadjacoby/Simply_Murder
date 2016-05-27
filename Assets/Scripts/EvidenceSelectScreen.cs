using UnityEngine;
using System.Collections;

public class EvidenceSelectScreen : MonoBehaviour {
    private GameManager gameManagerControls;
    public GameObject blood, body, wallet, shoeprint, reciept, particles, location, nextGameObject;
    public int addToJury;
    // Use this for initialization
    void Start()
    {
        Vector3 center = new Vector3(0, 0, 0);
        this.gameObject.transform.position = center;
        gameManagerControls = GameObject.Find("Main Camera").GetComponent<GameManager>();

        blood.SetActive(false);
        body.SetActive(false);
        wallet.SetActive(false);
        shoeprint.SetActive(false);
        reciept.SetActive(false);
        particles.SetActive(false);
        if (gameManagerControls.currentEvidenceCount == 3)
        {
           
            Instantiate(nextGameObject, location.transform.position, location.transform.rotation);
            Destroy(this.gameObject); 
        }
        if (gameManagerControls.blood == true)
        {
            blood.SetActive(true);
        }
        if (gameManagerControls.body == true)
        {
            body.SetActive(true);
        }
        if (gameManagerControls.wallet == true)
        {
            wallet.SetActive(true);
        }

        if (gameManagerControls.shoeprint == true)
        {
            shoeprint.SetActive(true);
        }
        if (gameManagerControls.receipt == true)
        {
            reciept.SetActive(true);
        }
        if (gameManagerControls.particles== true)
        {
            particles.SetActive(true);
        }

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
