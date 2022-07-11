using UnityEngine;

namespace PlatformGame
{
    public class Skin
    {
        public Texture Texture { get; }
        public string Name { get; }

        public Skin(Texture texture, string name)
        {
            Texture = texture;
            Name = name;
        }
    }
}
