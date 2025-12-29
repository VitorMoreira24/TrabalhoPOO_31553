using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoAlojamentos.Exceptions
{
    public class ClienteInvalidoException : Exception
    {
        public ClienteInvalidoException(string mensagem) : base(mensagem) { }
    }

    public class ClienteDuplicadoException : Exception
    {
        public ClienteDuplicadoException(string nif) : base($"Já existe um cliente registado com o NIF {nif}.") { }
    }
}
