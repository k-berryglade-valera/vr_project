using UnityEngine;

namespace VRApp.Entities.Enemy
{
    [CreateAssetMenu(fileName = "Enemy", menuName = "Entities", order = 4)]
    public class EnemyData : ScriptableObject
    {
        [SerializeField] private string _name;
        [SerializeField] private string _tag;
        [SerializeField] private string _nickname;
        [SerializeField] private string _hashname;
        [SerializeField] private float _health;
        [SerializeField] private GameObject _prefab;
        
        public string Name
        {
            get => _name; set => _name = value;
        }

        public string Tag
        {
            get => _tag; set => _tag = value;
        }

        public string Nickname
        {
            get => _nickname; set => _nickname = value;
        }

        public string Hashname
        {
            get => _hashname; set => _hashname = value;
        }

        public float Health
        {
            get => _health; set => _health = value;
        }

        public GameObject Prefab
        {
            get => _prefab; set => _prefab = value;
        }
    }
}