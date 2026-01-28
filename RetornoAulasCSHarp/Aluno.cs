using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace RetornoAulasCSHarp
{
    public class Aluno
    {
        public int ID { get; set; }
        public string NOME { get; set; }
        public string EMAIL { get; set; }   
        public string TELEFONE { get; set; }
        public byte[] IMAGEM { get; set; }
    }
}
