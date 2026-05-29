using Autodesk.AutoCAD.Runtime;

[assembly: CommandClass(typeof(PipePanel.PipePanelCommand))]

namespace PipePanel
{
    public class PipePanelCommand
    {
        [CommandMethod("PPANEL")]
        public void TogglePipePanel()
        {
            if (!PipePaletteSet.IsCreated)
            {
                PipePaletteSet.Show();
                return;
            }

            if (PipePaletteSet.IsVisible)
                PipePaletteSet.Hide();
            else
                PipePaletteSet.Show();
        }
    }
}
