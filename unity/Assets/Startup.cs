using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

[RequireComponent(typeof(PostProcessingBehaviour))]

public class Startup : MonoBehaviour {


   PostProcessingProfile m_Profile;

	// Use this for initialization
	void Start () {
        var behaviour = GetComponent<PostProcessingBehaviour>();

        if (behaviour.profile == null)
        {
            enabled = false;
            return;
        }

        m_Profile = Instantiate(behaviour.profile);
        behaviour.profile = m_Profile;

		if (enabled) {
			int qualityLevel = QualitySettings.GetQualityLevel();		
			behaviour.profile.vignette.enabled = qualityLevel >= 5;
			behaviour.profile.depthOfField.enabled = qualityLevel >= 5;
			behaviour.profile.chromaticAberration.enabled = qualityLevel >= 5;
			behaviour.profile.grain.enabled = qualityLevel >= 5;
		}
	}
	
	// Update is called once per frame
	void Update () {
        //var vignette = m_Profile.vignette.settings;
        //vignette.smoothness = Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.01f;
        //m_Profile.vignette.settings = vignette;
	}
}
