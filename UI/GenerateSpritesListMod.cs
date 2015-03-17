using System;
using ColossalFramework.UI;

namespace GenerateSpritesListMod
{
    public class GenerateSpritesListMod : IUserMod
    {
        public string Name { 
            get { return "GenerateSpritesListMod";  }
        }

        public string Description {
            get { return "Lorem ipsum - non sense description"; }
        }
    }

    public class ModLoad : LoadingExtensionBase
    {
    	public override void OnLevelLoaded(LoadMode mode) 
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"sprites.txt", false))
            {
            	UIView view = GameObject.FindObjectOfType<UIView>() as UIView;
            	
                // Print all sprites
                foreach (UITextureAtlas.SpriteInfo spriteInfo in view.defaultAtlas.sprites)
                {
                    //DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Message, spriteInfo.name);
                    file.WriteLine(spriteInfo.name);
                }
            }
        }
    }
}
