using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyVRoidLeftHandTransform : MonoBehaviour
{
    public GameObject headObject;
    public GameObject headTeacherObject;
    public GameObject leftHandTeacherObject;

    public GameObject leftSpeaker;

    [SerializeField] GameObject leftHandQuad;

    // Start is called before the first frame update
    void Start()
    {
      headObject = GameObject.Find("MyVRoid/Root/J_Bip_C_Hips/J_Bip_C_Spine/J_Bip_C_Chest/J_Bip_C_UpperChest/J_Bip_C_Neck/J_Bip_C_Head");

      headTeacherObject = GameObject.Find("TeacherVRoid/Root/J_Bip_C_Hips/J_Bip_C_Spine/J_Bip_C_Chest/J_Bip_C_UpperChest/J_Bip_C_Neck/J_Bip_C_Head");
      leftHandTeacherObject = GameObject.Find("TeacherVRoid/Root/J_Bip_C_Hips/J_Bip_C_Spine/J_Bip_C_Chest/J_Bip_C_UpperChest/J_Bip_L_Shoulder/J_Bip_L_UpperArm/J_Bip_L_LowerArm/J_Bip_L_Hand");

      leftSpeaker = GameObject.Find("MyVRoid/Root/J_Bip_C_Hips/J_Bip_C_Spine/J_Bip_C_Chest/J_Bip_C_UpperChest/J_Bip_C_Neck/J_Bip_C_Head/L_Speaker");

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 leftHandPos = transform.position;

        Transform headTransform = headObject.transform;
        Vector3 headPos = headTransform.position;

        Vector3 PlayerComparison = leftHandPos - headPos;
        //Debug.Log(PlayerComparison); 

        Transform headTeacherTransform = headTeacherObject.transform;
        Vector3 headTeacherPos = headTeacherTransform.position;

        Transform leftHandTeacherTransform = leftHandTeacherObject.transform;
        Vector3 leftHandTeacherPos = leftHandTeacherTransform.position;

        Vector3 TeacherComparison = leftHandTeacherPos - headTeacherPos;

        // ↓PlayerComparisonとTeacherComparisonを比較する
        if ((TeacherComparison - PlayerComparison).magnitude > 0.15)
        {
         leftSpeaker.GetComponent<Speaker>().ComparisonSpeaker();
         leftHandQuad.SetActive(true);
        }
        else
        {
         leftHandQuad.SetActive(false);
        }

        //↓のコードで音が鳴るのは確認
        //よって↑の条件を整えれば音はなる。
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    leftSpeaker.GetComponent<Speaker>().ComparisonSpeaker();
        //}
    }
}
