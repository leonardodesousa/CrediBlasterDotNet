using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrediBlaster.Model
{
    class PessoaFisica
    {
        public long codigo { get; set; }
        public String Nome { get; set; }
        public String Cpf { get; set; }
        public String Email { get; set; }
        public String situacao { get; set; }
        public DateTime DtNasc { get; set; }
        public DateTime DtCadastro { get; set; }
        public DateTime DtUltAtualizacao { get; set; }

        public PessoaFisica(long codigo, string nome, string cpf, string email, string situacao, DateTime dtNasc, DateTime dtCadastro, DateTime dtUltAtualizacao)
        {
            this.codigo = codigo;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            this.situacao = situacao;
            DtNasc = dtNasc;
            DtCadastro = dtCadastro;
            DtUltAtualizacao = dtUltAtualizacao;
        }
    }


}
