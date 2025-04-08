using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoversionDeMonedas : MonoBehaviour
{
    //1.Declaracion de variables
    public float montoAConvertir;
    public string codigoMoneda;

    float montoConvertido;
    float cotizacionMonedaElegida;

    float montoMinimoAConvertir;
    float cotizacionDolar = 134.5f;
    // Start is called before the first frame update
    void Start()
    {
        //2. Ingreso y validacion de datos
        if(montoAConvertir < montoMinimoAConvertir)
        {
            Debug.Log("El monto mínimo es $1000");
            return;
        }
        if (codigoMoneda == "D")
        {
            cotizacionMonedaElegida = cotizacionDolar;
        } else if(codigoMoneda == "E")
        {
            cotizacionMonedaElegida = 1397.16f; 
        }else if(codigoMoneda == "R")
        {
            cotizacionMonedaElegida = 211.1f;
        }
        else
        {
            Debug.Log("Opcion de moneda no valida");
            return;
        } 

        //3. Operaciones y procesamiento de datos

        montoConvertido = montoAConvertir / cotizacionMonedaElegida;

        //4. Salida de datos
        Debug.Log("Monto convertido: " + montoConvertido);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
