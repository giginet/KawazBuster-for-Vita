using System;
using System.Collections.Generic;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.Core.Input;
using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;
namespace KawazBuster
{
	public class TitleScene : Scene
	{
		public TitleScene ()
		{
			this.Camera.SetViewFromViewport();

			// create a new TextureInfo object, used by sprite primitives
			var texture_info = new TextureInfo( new Texture2D("/Application/resources/images/title/title_background-hd.png", false ) );

			// create a new sprite
			var sprite = new SpriteUV() { TextureInfo = texture_info};

			// make the texture 1:1 on screen
			sprite.Quad.S = texture_info.TextureSizef; 

			// center the sprite around its own .Position 
			// (by default .Position is the lower left bit of the sprite)
			sprite.CenterSprite();
			
			// put the sprite at the center of the screen
			sprite.Position = this.Camera.CalcBounds().Center;
			this.AddChild(sprite);
		}
	}
}

