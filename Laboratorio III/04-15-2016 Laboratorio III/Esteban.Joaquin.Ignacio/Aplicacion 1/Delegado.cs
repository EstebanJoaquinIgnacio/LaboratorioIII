using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Entidades;

namespace Delegado
{ 
    //declaro delegado
    public delegate void CambiarNombreDel(string cadena);
    public delegate void MostrarAlumnoPorDelegado(Alumno unAlumno, EventArgs e);
   
}

