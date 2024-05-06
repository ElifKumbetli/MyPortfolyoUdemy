namespace MyPortfolioUdemy.DAL.Entities
{
    public class ToDoList
    {
        public int ToDoListId { get; set; }

        public string Title { get; set; }

        public string ImagUrl { get; set; }

        public DateTime Date { get; set; } //Ne kadar süre önce

        public bool Status { get; set; }//Bildirimin durumu
    }
}
