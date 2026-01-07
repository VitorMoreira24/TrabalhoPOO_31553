using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoAlojamentos.Exceptions
{
    public partial class ErroDerivadoException : Exception
    {
        public ErroDerivadoException(string acao, string mensagemOriginal)
            : base($"Falha ao {acao} os dados do sistema. Detalhes: {mensagemOriginal}") { }
    }

    public partial class FicheiroNaoEncontradoException : Exception
    {
        public FicheiroNaoEncontradoException(string nomeFicheiro)
            : base($"O ficheiro de dados '{nomeFicheiro}' não foi localizado.") { }
    }
}
