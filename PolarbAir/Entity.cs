using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace PolarbAir {
    public class Entity : DrawableGameComponent {
        public Vector2 Position { get; set; }
        public Vector2 Velocity { get; set; }
        public float Rotation { get; set; }

        public List<Entity> Children = new List<Entity>();

        public Entity(Game game) : base(game) {
            
        }

        public Entity(Entity parent) : base(parent.Game) {
            
        }

        ~Entity() {
            foreach (var child in Children) {
                child.Dispose();
            }
        }
    }
}
