using Amf.Framework.ObjetosComuns;
using Amf.PeladaFC.DomainModel.Core;
using System.Collections.Generic;

namespace WSPeladaFC.Models
{
    public class ContaDTO
    {
        public string NomeCompletoPeladeiro { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public byte[] Foto { get; set; }
    }
}