using System;

namespace UnitTestAndDebug
{
    public class Person
    {
        public Person(string name, string id, int anio, int mes, int dia)
        {
            this.Name = name;
            this.ID = id;
            this.Anio= anio;
            this.Mes= mes;
            this.Dia=dia;

        }

        private string name;

        private string id;

        private int anio;
        private int mes;
        private int dia;

        public string Name
        {
            get
            {
                return this.name;
            }
            
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }
        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (IdUtils.IdIsValid(value))
                {
                    this.id = value;
                }
                else
                {
                    this.id="ID Falsa";
                }
            }
        }
        private int Anio
        {
            get
            {
                return this.anio;
            }
            set
            {
                this.anio=value;
               /* if (anioReal.anioReal(value))
                {
                    this.anio=value;
                }
                else
                {
                    this.anio=00000;
                }*/
            }

        }
        private int Mes
        {
            get
            {
                return this.mes;
            }
            set
            {
                this.mes=value;
               /* if (mesReal.mesReal(value))
                {
                    this.mes=value;
                }
                else
                {
                    this.mes=00000;
                }*/
            }
        
        }
        private int Dia
        {
            get
            {
                return this.dia;      
            }
            set 
            {
                this.dia=value;
                /*if (diaReal.diaReal(value))
                {
                    this.dia=value;
                }
                else
                {
                    this.dia=00000;
                }*/
            }
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"Soy {this.Name} y mi cédula es {this.ID}");
        }
    }
}
