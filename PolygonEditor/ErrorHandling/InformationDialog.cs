
namespace PolygonEditor
{
    public static class InformationDialog
    {
        public static void Show(string information)
        {
            InformationForm dialog = new InformationForm(information);
            dialog.ShowDialog();
        }
    }
}
