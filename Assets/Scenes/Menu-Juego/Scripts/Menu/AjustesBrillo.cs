using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AjustesBrillo : MonoBehaviour
{
    public Slider slider;
    public float sliderValue;
    public Image PanelBrillo;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("brillo", 0.5f);

        PanelBrillo.color = new Color(PanelBrillo.color.r, PanelBrillo.color.g, PanelBrillo.color.b, slider.value);
    }

    //Update is called once per frame
    void Update()
    {

    }

    public void ChangeSlider(float valor)
    {
        sliderValue = valor+5;
        PlayerPrefs.SetFloat("brillo", sliderValue);
        PanelBrillo.color = new Color(PanelBrillo.color.r, PanelBrillo.color.g, PanelBrillo.color.b, slider.value);
    }
}