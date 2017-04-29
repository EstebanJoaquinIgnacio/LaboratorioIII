using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace _02_DataSet
{
    public enum ETabla
    {   
        Producto,
        Proveedor
    }

    public class Generadora
    {

        public static DataTable DefinirTabla(ETabla queTabla)
        {
            DataTable miTabla = new DataTable();

            switch (queTabla)
	        {
		        case ETabla.Producto:
                    miTabla.TableName = "Productos";
                    miTabla.Columns.Add("IdProducto", typeof(Int32));
                    miTabla.Columns.Add("Nombre", typeof(String));
                    miTabla.Columns.Add("IdProveedor", typeof(Int32));

                    miTabla.Columns["IdProducto"].AutoIncrement = true;
                    miTabla.Columns["IdProducto"].AutoIncrementSeed = 1;
                    miTabla.Columns["IdProducto"].AutoIncrementStep = 1;
                    miTabla.Columns["IdProducto"].Unique = true;

                    miTabla.PrimaryKey = new DataColumn[] {miTabla.Columns["IdProducto"]};

                    break;
                case ETabla.Proveedor:
                    miTabla.TableName = "Proveedores";
                    miTabla.Columns.Add("IdProveedor", typeof(Int32));
                    miTabla.Columns.Add("Nombre", typeof(String));
                    miTabla.PrimaryKey = new DataColumn[] {miTabla.Columns["IdProveedor"]};

                    break;
                default:
                    break;
            }

            return miTabla;
        }

        public static DataSet CargarDataSet(DataTable[] misTablas)
        {
            System.Data.DataSet miDataSet = new DataSet();

            foreach(DataTable tabla in misTablas)
            {
                miDataSet.Tables.Add(tabla);
            }

            return miDataSet;

        }

        public static DataSet EstablecerRelaciones(DataSet ds) 
        {
            DataRelation dstRelacion; 

            dstRelacion = new DataRelation("ProductosProveedor", 
                                            ds.Tables["Proveedores"].Columns["IdProveedor"], 
                                            ds.Tables["Productos"].Columns["IdProveedor"]);

            ds.Relations.Add(dstRelacion);

            return ds;

        }

        public static Boolean GuardarEsquemaXML(System.Data.DataSet ds)
        {
            Boolean todoOK = true;

            try
            {
                ds.WriteXmlSchema(AppDomain.CurrentDomain.BaseDirectory + 
                                    "\\XmlDataSetSchema.xml");
            }
            catch(Exception)
            {
                todoOK = false;
            }

            return todoOK;

        }
    }
}
