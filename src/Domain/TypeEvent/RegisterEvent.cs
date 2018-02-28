namespace Domain.TypeEvent
{
    /// <summary>
    /// Representa o tipo de evento disparado
    /// </summary>
    public class RegisterEvent
    {
        public long Id { get; set; }

        public string Nome { get; set; }
    }
}
