using System;

namespace shared
{
    public class News
    {
        //Identificador Unico por equipo y se genera de manera automatica.
        public Guid NewsId {get;set;} = Guid.NewGuid();

        public string Description {get;set;}

        public string Paragraph {get;set;}

        public string Image {get;set;}

        public string Url {get;set;}
    }
}
