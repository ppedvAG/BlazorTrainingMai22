namespace BlazorTrainingMai22.Pages.Modul4
{
    public class ChatVM
    {
        public Action onAdd;
        public List<NachrichtModel> NachrichtenListe { get; set; } = new List<NachrichtModel>();
        public void Add(string msg)
        {
            NachrichtenListe.Add(new NachrichtModel { Text = msg });
            onAdd?.Invoke();
        } 

       
        
    }
}
