//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RepositorioMagic
{
    using System;
    using System.Collections.Generic;
    
    public partial class CARD
    {
        public long CARDID { get; set; }
        public string NOME { get; set; }
        public string NOMEENG { get; set; }
        public string MANACOST { get; set; }
        public int CONVERTEDMANACOST { get; set; }
        public long TIPOID { get; set; }
        public long SUBTIPOID { get; set; }
        public string CARDTEXT { get; set; }
        public string FLAVORTEXT { get; set; }
        public Nullable<int> ATAQUE { get; set; }
        public Nullable<int> DEFESA { get; set; }
        public long EXPANSIONID { get; set; }
        public string RARIDADE { get; set; }
        public Nullable<int> NUMEROCARD { get; set; }
        public string ARTISTA { get; set; }
        public string REGRAS { get; set; }
    
        public virtual EXPANSION EXPANSION { get; set; }
        public virtual SUBTIPO SUBTIPO { get; set; }
        public virtual TIPO TIPO { get; set; }
    }
}
