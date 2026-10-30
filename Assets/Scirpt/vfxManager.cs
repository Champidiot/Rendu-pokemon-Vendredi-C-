using UnityEngine;

public class vfxManager : MonoBehaviour
{
    
    public void activateVfx(GameObject vfx)
    {
        GameObject.Instantiate(vfx, transform.position, Quaternion.identity);
    }
}
