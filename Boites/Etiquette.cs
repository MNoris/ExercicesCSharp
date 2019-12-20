using System;
using System.Collections.Generic;
using System.Text;

namespace Boites
{
    class Etiquette
    {
        public string Text { get; set; }
        public Colors Color { get; set; }
        public Formats Format { get; set; }

        public override string ToString()
        {
            return $"Couleur = {Color} ; Format = {Format} ; Texte = \"{Text}\"";
        }
    }
}
