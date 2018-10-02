using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS.Project.View
{
    public class Aluno{

        public int idAluno { get; set; }
        public String nmAluno { get; set; }
        public String endAluno { get; set; }
        public String cepAluno { get; set; }
        public String emailAluno { get; set; }
        public String nmrAluno { get; set; }
        public String nmrFixoAluno { get; set; }
        public String estCivilAluno { get; set; }
        public DateTime dtaNascimento { get; set; }

        public Aluno(String nmAluno, String endAluno, String cepAluno, String emailAluno, String nmrAluno,
            String nmrFixoAluno, DateTime dtaNascimento){
                this.idAluno = idAluno;
                this.nmAluno = nmAluno;
                this.cepAluno = cepAluno;
                this.emailAluno = emailAluno;
                this.nmrAluno = nmrAluno;
                this.nmrFixoAluno = nmrFixoAluno;
                this.estCivilAluno = estCivilAluno;
                this.dtaNascimento = dtaNascimento;
        }

        public Aluno(
    }
}
