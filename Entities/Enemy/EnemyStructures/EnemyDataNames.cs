using System;

namespace VRApp.Entities.Enemy
{
    [Serializable]
    public struct EnemyDataNames
    {
        
        private string _name;
        private string _tag;
        private string _nickname;
        private string _hashname;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Tag
        {
            get => _tag;
            set => _tag = value;
        }

        public string Nickname
        {
            get => _nickname;
            set => _nickname = value;
        }

        public string Hashname
        {
            get => _hashname;
            set => _hashname = value;
        }

        public EnemyDataNames( string defaultValue )
        {
            _name = defaultValue;
            _tag = defaultValue;
            _nickname = defaultValue;
            _hashname = defaultValue;
        }
    }
}