using Diablerie.Engine.IO.D2Formats;
using Diablerie.Engine.Utility;
using Diablerie.Engine.World;

namespace Diablerie.Game.World
{
    public class Act4 : Act
    {
        public Act4()
        {
            palette = Palette.GetPalette(PaletteType.Act4);
            
            var town = new LevelBuilder("Act 4 - Town", palette);
            root = town.Instantiate(new Vector2i(0, 0));
            entry = town.FindEntry();
        }
    }
}