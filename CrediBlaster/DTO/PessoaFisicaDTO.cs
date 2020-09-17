using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrediBlaster
{
    class PessoaFisicaDTO
    {
        public long codigo { set; get; }
        public String nome { set; get;  }
        public String cpf { set; get;  }
        public String email { set; get;  }
        public String situacao { set; get;  }
        public DateTime dtNasc { set; get;  }
        public DateTime dtCadastro { set; get;  }
        public DateTime dtUltAtualizacao { set; get;  }

        public PessoaFisicaDTO(long codigo, string nome, string cpf, string email, string situacao, DateTime dtNasc, DateTime dtCadastro, DateTime dtUltAtualizacao)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
            this.situacao = situacao;
            this.dtNasc = dtNasc;
            this.dtCadastro = dtCadastro;
            this.dtUltAtualizacao = dtUltAtualizacao;
        }

        public PessoaFisicaDTO()
        {
        }
    }


}
