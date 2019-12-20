using System;
using System.Collections.Generic;
using System.Text;

namespace Boites
{
    class Box
    {
        private static int _compteur;
        public static int Compteur { get { return _compteur; } }
        public double Height { get; }
        public double Length { get; }
        public double Width { get; }
        public Colors Color { get; set; }
        public Matters Matter { get; }
        private Etiquette _etiquetteDest;
        private Etiquette _etiquetteFragile;


        public double Volume
        {
            get
            {
                return Height * Length * Width;
            }
        }

        public Box(double height, double length, double width)
        {
            _compteur++;
            Height = height;
            Length = length;
            Width = width;
        }
        public Box(double height, double length, double width, Matters matter)
            : this(height, length, width) => Matter = Matters.Carton;

        public bool Equals(Box box)
        {
            return (Height == box.Height
                && Length == box.Length
                && Width == box.Width
                && Matter == box.Matter);
            //return base.Equals(obj);
        }
        static public bool Compare(Box box, Box box2)
        {
            return (box2.Height == box.Height
                && box2.Length == box.Length
                && box2.Width == box.Width
                && box2.Matter == box.Matter);
        }

        public void Etiqueter(string destinataire)
        {
            _etiquetteDest = new Etiquette { Color = Colors.Blanc, Format = Formats.L, Text = destinataire };
        }

        public void Etiqueter(string destinataire, bool fragile)
        {
            if (fragile)
            {
                _etiquetteFragile = new Etiquette { Color = Colors.Rouge, Format = Formats.S, Text = "FRAGILE" };
            }
            Etiqueter(destinataire);
        }
        public void Etiqueter(Etiquette etiqD, Etiquette etiqF)
        {
            _etiquetteDest = etiqD;
            _etiquetteFragile = etiqF;
        }

        public override string ToString()
        {
            return @$"Cette boite a pour dimension {Height} par {Length} par {Width}cm, pour un total de {Volume} cm3, et est faite en {Matter} {Color}.
{_etiquetteDest.ToString()}
{_etiquetteFragile.ToString()}";
        }



    }
}
