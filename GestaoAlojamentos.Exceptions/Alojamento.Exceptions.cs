using System;

namespace GestaoAlojamentos.Exceptions
{
    public class AlojamentoOcupadoException : Exception
    {
        public AlojamentoOcupadoException() : base("O alojamento já se encontra alugado.") { }
        public AlojamentoOcupadoException(int id) : base($"O alojamento com ID {id} já se encontra alugado.") { }
    }

    public class AlojamentoNaoEncontradoException : Exception
    {
        public AlojamentoNaoEncontradoException(int id) : base($"O alojamento com ID {id} não foi encontrado no sistema.") { }
    }
}
