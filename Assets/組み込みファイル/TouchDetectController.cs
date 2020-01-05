using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Live2D.Cubism.Framework.Raycasting;
using Live2D.Cubism.Samples.LookAt;

public class TouchDetectController : MonoBehaviour
{

    Animator anim;
    CubismRaycaster raycaster;

    void Start()
    {
        anim = GetComponent<Animator>();
        raycaster = GetComponent<CubismRaycaster>();

    }

    void Update()
    {
        if (!Input.GetMouseButtonDown(0))
        {
            return;
        }

        var results = new CubismRaycastHit[4];
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        var hitCount = raycaster.Raycast(ray, results);

        for (int i = 0; i < hitCount; i++)
        {
            string hitID = results[i].Drawable.name;
            Debug.Log("クリックしたアートメッシュIDは" + hitID + "です。");

            if (hitID == "HitAreaBody")
            {
                anim.SetTrigger("touchBody");
            }

            if (hitID == "HitAreaHead")
            {
                anim.SetTrigger("touchHead");
            }
        }
    }
}
