namespace ExpenseIt
{
    public partial class ExpenseItHome
    {
        public ExpenseItHome()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            // View Expense Report
            NavigationService?.Navigate(new ExpenseReportPage());
        }
    }
}