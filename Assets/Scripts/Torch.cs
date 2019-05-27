using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour
{


    [SerializeField] private Gradient fireColors;
    [Range(0, 1)]
    [SerializeField] float audioImportance = 0.5f;
    [SerializeField] private ParticleSystem ps;
    
    private float originalSpeed;
    private float previousSpeed;
    private float originalSize;
    private float previousSize;
    [SerializeField] private Light torchLight;
    private float originalIntensity;
    private float previousIntensity;
    // Start is called before the first frame update
    void Start()
    {
        var main = ps.main;
        originalSpeed = main.startSpeed.constant;
        originalSize = main.startSize.constant; ;
        var col = ps.colorOverLifetime;
        col.color = fireColors;

        originalIntensity = torchLight.intensity;
        previousIntensity = originalIntensity;
    }

    // Update is called once per frame
    void Update()
    {
        var col = ps.colorOverLifetime;
        col.color = fireColors;
        var main = ps.main;
        main.startSpeed = previousSpeed;
        previousSpeed = Mathf.Lerp(previousSpeed, originalSpeed + Mathf.Max(0, AudioPeer.spectrumIntensity - 0.08f) * 120 * audioImportance, 0.1f);
        main.startSize = previousSize;
        previousSize = Mathf.Lerp( previousSize, originalSize + Mathf.Max(0, AudioPeer.spectrumIntensity - 0.08f) * 120 * audioImportance, 0.1f);

        torchLight.intensity = previousIntensity;
        previousIntensity = Mathf.Lerp(previousIntensity, originalIntensity + (0.25f * Mathf.Sin(Time.time * 7)) + AudioPeer.spectrumIntensity * 14 * audioImportance, 0.1f);
        torchLight.color = fireColors.Evaluate(0.5f);

    }
}
