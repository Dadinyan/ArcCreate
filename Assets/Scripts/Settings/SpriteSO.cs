// <auto-generated> to shut up linter
using UnityEngine;
using UnityEngine.Events;

namespace ArcCreate
{
    [CreateAssetMenu(fileName = "Sprite", menuName = "ScriptableObject/Sprite")]
    public class SpriteSO : ScriptableObject
    {
        private Sprite value;
        public Sprite Value
        {
            get => value;
            set
            {
                this.value = value;
                OnValueChange.Invoke(value);
            }
        }

        public OnChangeEvent OnValueChange { get; set; } = new OnChangeEvent();

        public class OnChangeEvent : UnityEvent<Sprite>
        {
        }
    }
}