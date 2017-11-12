using UnityEngine;
using System.Collections;
using UnityEngine.PostProcessing;

public class Effects : MonoBehaviour {

    public PostProcessingProfile my_Profile;


    public float quantitativeDrunk = 0f;
    public float shutterModifier = 0f;

    public void Awake()
    {
        resetDrunk();
    }


    // Use this for initialization
    void OnEnable ()
    {
        //var behaviour = GetComponent<PostProcessingBehaviour>();

        //if (behaviour.profile = null)
        //{
        //    enabled = false;
        //    return;
        //}

        //my_Profile = Instantiate(behaviour.profile);
        //behaviour.profile = my_Profile;
	}

    // Update is called once per frame
    void Update()
    {
       // StartCoroutine("Drink");
        

        if (Input.GetKeyDown(KeyCode.E))
        {
            var vignette = my_Profile.vignette.settings;
            var motionBlur = my_Profile.motionBlur.settings;

            motionBlur.frameBlending = 0;
            motionBlur.shutterAngle = 0;
            vignette.intensity = 0;

            my_Profile.motionBlur.settings = motionBlur;
            my_Profile.vignette.settings = vignette;


        }
    }
       public void resetDrunk()
       {
            var vignette = my_Profile.vignette.settings;
            var motionBlur = my_Profile.motionBlur.settings;

            motionBlur.frameBlending = 0;
            motionBlur.shutterAngle = 0;
            vignette.intensity = 0;

            my_Profile.motionBlur.settings = motionBlur;
            my_Profile.vignette.settings = vignette;
        }
        //motionBlur.frameBlending = Mathf.Abs((Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.01f);
        
    IEnumerator Drink()
    {
        if (Drinking.isDrinking == true)
        {
            yield return new WaitForSeconds(10);
            var vignette = my_Profile.vignette.settings;
            var motionBlur = my_Profile.motionBlur.settings;

            motionBlur.frameBlending += quantitativeDrunk;
            motionBlur.shutterAngle += shutterModifier;

            vignette.intensity += quantitativeDrunk;

            my_Profile.motionBlur.settings = motionBlur;
            my_Profile.vignette.settings = vignette;
            Debug.Log("GET KRUNK");
        }

        

    }
	
}
