/* This is not my code, this was used in a project I was given and this is used for darkui (I was given permission to use it)
 * I would link credits but I do not believe they have a github or I'm just unaware of it, but anyways, credits to MrVodka :)
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamWriter.Handler
{
    public class ColorTable
    {

        public static readonly Color ActiveTab = Color.FromArgb(64, 143, 231);
    }

    public class MenuColorTable : ProfessionalColorTable
    {
        public override Color ToolStripBorder => Color.FromArgb(49, 51, 53);
        public override Color ToolStripContentPanelGradientBegin => Color.FromArgb(49, 51, 53);
        public override Color ToolStripContentPanelGradientEnd => Color.FromArgb(49, 51, 53);
        public override Color ToolStripDropDownBackground => Color.FromArgb(49, 51, 53);
        public override Color ToolStripGradientBegin => Color.FromArgb(49, 51, 53);
        public override Color ToolStripGradientMiddle => Color.FromArgb(49, 51, 53);
        public override Color ToolStripGradientEnd => Color.FromArgb(49, 51, 53);
        public override Color ImageMarginGradientBegin => Color.FromArgb(49, 51, 53);
        public override Color ImageMarginGradientEnd => Color.FromArgb(49, 51, 53);
        public override Color ImageMarginGradientMiddle => Color.FromArgb(49, 51, 53);
        public override Color MenuBorder => Color.FromArgb(60, 60, 60);
        public override Color MenuItemBorder => Color.FromArgb(16, 255, 255, 255);
        public override Color MenuItemSelected => Color.FromArgb(10, 80, 130);
        public override Color MenuItemSelectedGradientBegin => Color.FromArgb(32, 255, 255, 255);
        public override Color MenuItemSelectedGradientEnd => Color.FromArgb(32, 255, 255, 255);
        public override Color MenuItemPressedGradientBegin => Color.FromArgb(32, 255, 255, 255);
        public override Color MenuItemPressedGradientMiddle => Color.FromArgb(32, 255, 255, 255);
        public override Color MenuItemPressedGradientEnd => Color.FromArgb(32, 255, 255, 255);
    }
}
