namespace InjecaoDependenciaTeste
{
    public class Operacao : IOperacao
    {
        public Guid Id { get; set; }

        public Operacao()
        {
            Id = Guid.NewGuid();
        }

    }

    public interface IOperacao
    {
        Guid Id { get; set; }
    }

    public interface IoperacaoTransient : IOperacao { }
    public interface IoperacaoSccoped   : IOperacao { }
    public interface IoperacaoSingleton : IOperacao { }

}



