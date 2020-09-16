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

        public string Name => _name;

        public string Tag => _tag;

        public string Nickname => _nickname;

        public string Hashname => _hashname;
        
        public EnemyDataNames( string defaultValue )
        {
            _name = defaultValue;
            _tag = defaultValue;
            _nickname = defaultValue;
            _hashname = defaultValue;
        }
    }
}