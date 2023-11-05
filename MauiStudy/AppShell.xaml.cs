using MauiStudy.Pages;

namespace MauiStudy
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // nameof를 쓰는 이유 : refactoring 용이성
            Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
        }
    }
}