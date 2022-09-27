namespace DS.ViewModel.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException() : base()
        {
            Errors = new List<string>();
        }
        public List<string> Errors { get; }
        public NotFoundException(params string[] errors)
            : this()
        {
            foreach (var error in errors)
            {
                Errors.Add(error);
            }
        }
    }
}
