using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Text;

namespace XNAtut
{
    class Level : IDisposable
    {
        //Level structure
        private Texture2D[] layers;
        private const int EntityLayer = 1;

        //Level Content
        public ContentManager Content
        {
            get { return content; }
        }
        ContentManager content;

        public void Dispose()
        {
            Content.Unload();
        }

        public Level(IServiceProvider serviceProvider, Stream fileStream, int levelIndex)
        {
            content = new ContentManager(serviceProvider, "Content");

            layers = new Texture2D[1];
            layers[0] = Content.Load<Texture2D>("Backgrounds/bglayer");
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            //Draw background layers
            for (int i = 0; i < EntityLayer; i++)
            {
                spriteBatch.Draw(layers[i], Vector2.Zero, Color.White);
            }
        }
    }
}
