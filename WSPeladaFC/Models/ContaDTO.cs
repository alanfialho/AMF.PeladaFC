using Amf.Framework.ObjetosComuns;
using Amf.PeladaFC.DomainModel.Core;
using System.Collections.Generic;

namespace WSPeladaFC.Models
{
    public class ContaDTO
    {
        public string NomeCompletoPeladeiro { get; set; }
        public ICollection<Posicao> PosicoesPeladeiro { get; set; }
        public Endereco Referencia { get; set; }
    }
}