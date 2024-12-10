namespace MVPBooksForm
{
    public interface IView
    {
        public void GetAllInfo();
        public Book BookObj { get; set; }
        public void DisplaySaved();
        public void DisplayDeleted();
        public void DisplayError(string message);
        public DialogResult DisplayWarning(string message);
        public bool AreFieldsEmpty();
        public void ClearFields();
        public void ShowBooks(List<Book> books);
        public void ClearTextBox();
        public bool IsDelInputEmpty();
        public string GetDelInputText();
        public void CloseForm();

        event EventHandler<EventArgs> SaveToFileClicked;
        event EventHandler<EventArgs> DeleteFromFileClicked;
        event EventHandler<EventArgs> DeleteAllClicked;
        event EventHandler<EventArgs> ReturnFirstClicked;
        event EventHandler<EventArgs> ExitButtonClicked;
    }

}
