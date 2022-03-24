﻿using System.Diagnostics;
using System;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            string sProdName = "Widget";
            int iUnitQty = 100;
            double dUnitCost = 1.03;

            Debug.WriteLine("Debug: Iniciando depuracion de producto");
            Debug.Indent();

            Debug.WriteLine("El Nombre del producto es: " + sProdName);
            Debug.WriteLine("El numero de unidades es: " + iUnitQty.ToString());
            Debug.WriteLine("El valor por unidad es: " + dUnitCost.ToString());

            System.Xml.XmlDocument oxml = new System.Xml.XmlDocument();
            Debug.WriteLine(oxml);

            Debug.WriteLine("El Nombre del producto es: " + sProdName, "Categoria:");
            Debug.WriteLine("El numero de unidades es: " + iUnitQty.ToString(), "Categoria:");
            Debug.WriteLine("El valor por unidad es: " + dUnitCost.ToString(), "Categoria:");
            Debug.WriteLine("El Costo total es:" + (iUnitQty \*dUnitCost),"Calculo");

        }
    }
}

