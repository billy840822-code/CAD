using Autodesk.AutoCAD.Runtime;

[assembly: ExtensionApplication(typeof(PipePanel.PipePanelApp))]

namespace PipePanel
{
    public class PipePanelApp : IExtensionApplication
    {
        public void Initialize()
        {
            // Lazy load — palette is created on first PPANEL call
        }

        public void Terminate()
        {
            PipePaletteSet.Dispose();
        }
    }
}
