using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PaletteController : MonoBehaviour
{
    private Object[] palette;
    private GameObject activePaletteElement;
    private Transform activePaletteElementTransform;
    private int activeElementCounter = 0;
    private void Awake()
    {
        //load palette
        palette = Resources.LoadAll("DefaultPalette/",typeof(GameObject));
        activePaletteElementTransform = gameObject.transform.GetChild(0).transform;
        if (palette.Length>0)
        {
            activePaletteElement = Instantiate(palette[activeElementCounter], gameObject.transform) as GameObject;
            activePaletteElement.transform.position = activePaletteElementTransform.position;
            activePaletteElement.transform.rotation = activePaletteElementTransform.rotation;
            activePaletteElement.transform.localScale = activePaletteElementTransform.localScale;
            activePaletteElement.transform.tag = "Untagged";
        }
    }


    public void RotatePalette(float direction)
    {
        activeElementCounter += (int)direction;
        if(activeElementCounter >= palette.Length)
        {
            activeElementCounter = 0;
        }
        if (activeElementCounter <0)
        {
            activeElementCounter = palette.Length-1;
        }
        Destroy(activePaletteElement);
        activePaletteElement = Instantiate(palette[activeElementCounter], gameObject.transform) as GameObject;
        activePaletteElement.transform.position = activePaletteElementTransform.position;
        activePaletteElement.transform.rotation = activePaletteElementTransform.rotation;
        activePaletteElement.transform.localScale = activePaletteElementTransform.localScale;
        activePaletteElement.transform.tag = "Untagged";
    }
    public GameObject GetCurrentActivePaletteElement()
    {
        return palette[activeElementCounter] as GameObject;
    }
    public Object[] GetPalette()
    {
        return palette as Object[];
    }
    public Object GetElementByID(int uuid)
    {
        foreach(GameObject blck in palette)
        {
            if (blck.GetComponent<BlockUUID>().UUID == uuid)
            {
                //Debug.Log("Got component " + uuid.ToString());
                return blck;
            }
        }
        return null;
    }
    public void LoadPalette()
    {
        palette = Resources.LoadAll("DefaultPalette/", typeof(GameObject));
    }

}
