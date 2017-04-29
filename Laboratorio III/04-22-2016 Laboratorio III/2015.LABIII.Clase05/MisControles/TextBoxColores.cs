using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//EN PROYECTOS DE TIPO CLASS LIBRARY HAY QUE AGREGAR LA REFERENCIA A SYSTEM.WINDOWS.FORM
//OPCIONALMENTE SE AGREGA LA REFERENCIA A SYSTEM.DRAWING.

namespace MisControles
{
    public class TextBoxColores : System.Windows.Forms.TextBox
    {
        #region Constructores
        /// <summary>
        /// Agigna por defecto el color de fondo
        /// PaleGreen
        /// </summary>
        public TextBoxColores()
        {
            this.BackColor = System.Drawing.Color.PaleGreen;
        }
        /// <summary>
        /// Recibe el color de fondo del control
        /// </summary>
        /// <param name="queColor">El color a ser aplicado</param>
        public TextBoxColores(System.Drawing.Color queColor)
        {
            this.BackColor = queColor;
        }
        #endregion
    }
}
