using System;
using System.Drawing;
using Autodesk.AutoCAD.Windows;

namespace PipePanel
{
    public static class PipePaletteSet
    {
        // Fixed GUID so AutoCAD remembers palette position between sessions
        private static readonly Guid PaletteSetGuid = new Guid("A1B2C3D4-E5F6-7890-ABCD-EF1234567890");

        private static PaletteSet _paletteSet;

        public static PaletteSet Instance
        {
            get { return _paletteSet; }
        }

        public static void Show()
        {
            if (_paletteSet == null)
                Create();

            _paletteSet.Visible = true;
        }

        public static void Hide()
        {
            if (_paletteSet != null)
                _paletteSet.Visible = false;
        }

        public static bool IsVisible
        {
            get { return _paletteSet != null && _paletteSet.Visible; }
        }

        public static bool IsCreated
        {
            get { return _paletteSet != null; }
        }

        private static void Create()
        {
            _paletteSet = new PaletteSet("Pipe Panel", PaletteSetGuid);

            _paletteSet.Style = PaletteSetStyles.ShowAutoHideButton
                              | PaletteSetStyles.ShowCloseButton
                              | PaletteSetStyles.Snappable;

            _paletteSet.Dock = DockSides.Left;
            _paletteSet.DockEnabled = DockSides.Left | DockSides.Right | DockSides.None;
            _paletteSet.Size = new Size(220, 300);

            _paletteSet.Add("Pipe Panel", new PipePaletteControl());
        }

        public static void Dispose()
        {
            if (_paletteSet != null)
            {
                _paletteSet.Dispose();
                _paletteSet = null;
            }
        }
    }
}
