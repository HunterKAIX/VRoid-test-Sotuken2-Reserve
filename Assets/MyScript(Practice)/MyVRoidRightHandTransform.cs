using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyVRoidRightHandTransform : MonoBehaviour
{
    public GameObject headObject;
    public GameObject headTeacherObject;
    public GameObject rightHandTeacherObject;

    public GameObject RightSpeaker;

    // Start is called before the first frame update
    void Start()
    {
        headObject = GameObject.Find("MyVRoid/Root/J_Bip_C_Hips/J_Bip_C_Spine/J_Bip_C_Chest/J_Bip_C_UpperChest/J_Bip_C_Neck/J_Bip_C_Head");

        headTeacherObject = GameObject.Find("TeacherVRoid/Root/J_Bip_C_Hips/J_Bip_C_Spine/J_Bip_C_Chest/J_Bip_C_UpperChest/J_Bip_C_Neck/J_Bip_C_Head");
        rightHandTeacherObject = GameObject.Find("TeacherVRoid/Root/J_Bip_C_Hips/J_Bip_C_Spine/J_Bip_C_Chest/J_Bip_C_UpperChest/J_Bip_R_Shoulder/J_Bip_R_UpperArm/J_Bip_R_LowerArm/J_Bip_R_Hand");

        RightSpeaker = GameObject.Find("MyVRoid/Root/J_Bip_C_Hips/J_Bip_C_Spine/J_Bip_C_Chest/J_Bip_C_UpperChest/J_Bip_C_Neck/J_Bip_C_Head/R_Speaker");

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rightHandPos = transform.position;

        Transform headTransform = headObject.transform;
        Vector3 headPos = headTransform.position;

        Vector3 PlayerComparison = rightHandPos - headPos;
        //Debug.Log(PlayerComparison); 

        Transform headTeacherTransform = headTeacherObject.transform;
        Vector3 headTeacherPos = headTeacherTransform.position;

        Transform rightHandTeacherTransform = rightHandTeacherObject.transform;
        Vector3 rightHandTeacherPos = rightHandTeacherTransform.position;

        Vector3 TeacherComparison = rightHandTeacherPos - headTeacherPos;

        // ↓にPlayerComparisonとTeacherComparisonを比較するものを作る
        // if ((TeacherComparison - PlayerComparison).magnitude > 0.5)
        // {

        // }

        //↓のコードで音が鳴るのは確認
        //よって↑の条件を整えれば音はなる。
        if (Input.GetKey(KeyCode.RightArrow))
        {
            RightSpeaker.GetComponent<Speaker>().ComparisonSpeaker();
        }
    }
}
