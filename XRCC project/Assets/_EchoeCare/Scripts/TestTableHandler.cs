using UnityEngine;

namespace ECHO
{

    public class TestTableHandler : MonoBehaviour
    {
        [Header("Prefabs for Table Items")]
        public GameObject applePrefab;
        public GameObject glassesPrefab;
        public GameObject keyPrefab;
        public GameObject potPrefab;
        public GameObject cupPrefab;

        [Header("Table Transform")]
        public Transform tableTransform;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // position table in front of user
        public void PositionTableInFrontOfUser()
        {
            Transform userTransform = Camera.main.transform;
            Vector3 forward = new Vector3(userTransform.forward.x, 0, userTransform.forward.z).normalized;
            Vector3 targetPosition = userTransform.position + forward * 1.5f; // 1.5 meters in front
            targetPosition.y = userTransform.position.y - 0.5f; // Slightly lower than eye level

            tableTransform.parent.position = targetPosition;
            //tableTransform.LookAt(new Vector3(userTransform.position.x, tableTransform.position.y, userTransform.position.z));

        }


    }
}
