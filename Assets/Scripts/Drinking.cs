using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.PostProcessing;

public class Drinking : MonoBehaviour
{

    public static int drunkScore = 0;
    public Text drunkText;
    private AudioSource gulp;
    public static bool isDrinking;
    public static bool isDrunk;
    public GameObject mouth;

    public float quantitativeDrunk = 0f;
    public float shutterModifier = 0f;

    public PostProcessingProfile my_Profile;

    float timer = 0.0f;
    public float timeToSip = 0.0f;

    bool royMcGill = true;

    public GameObject gameRig;


    public int scoreAdded;

    // Use this for initialization
    void Start()
    {
        isDrunk = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Drink" && Grab.isGrabbed == true)
        {
            Debug.Log("Chug Chug Chug");
            drunkScore = drunkScore + 1;
            if(drunkScore > 1000)
            {
                drunkScore = 1000;
                AudioSource gulp = mouth.GetComponent<AudioSource>();
                gulp.enabled = false;
                AudioSource puke = gameRig.GetComponent<AudioSource>();
                puke.Play();
                Debug.Log("PUKE");
                isDrunk = true;
            }
            

            drunkText.text = "Drunk Level: " + (drunkScore /10).ToString();
            Debug.Log(drunkScore);

            if (royMcGill)
            {
                StartCoroutine(applyDrunk());
                applyDrunk();
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (Grab.isGrabbed == true)
        {
            gulp = GetComponent<AudioSource>();
            gulp.enabled = true;
            gulp.Play();


        gulp.loop = true;
        isDrinking = true;
        Debug.Log("GULP");

            gulp.loop = true;
            isDrinking = true;
            Debug.Log("GULP");
        }
        


    }

    public void OnTriggerExit(Collider other)
    {
        


            gulp.loop = false;
            gulp.enabled = false;
            isDrinking = false;
        
    }

    private IEnumerator applyDrunk()
    {
        royMcGill = false;

        var vignette = my_Profile.vignette.settings;
        var motionBlur = my_Profile.motionBlur.settings;

        motionBlur.frameBlending += quantitativeDrunk;
        motionBlur.shutterAngle += shutterModifier;

        vignette.intensity += quantitativeDrunk;

        my_Profile.motionBlur.settings = motionBlur;
        my_Profile.vignette.settings = vignette;

        print("Getting Turnt");
        yield return new WaitForSeconds(1.25f);
        royMcGill = true;
    }
}
