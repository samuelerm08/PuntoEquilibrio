namespace App.Model
{
    //Enumeracion para Estado
    public enum Estado
    {
        Ganancia = 1,
        Equilibrio = 0,
        Perdida = -1
    }
    public class Barbijo
    {        
        public int codArt;
        public string? nombre;
        public double precioVenta;
        public double costoFijo;
        public double costoVariable;     
        
        public double PuntoEquilibrio()
        {
            return costoFijo / (precioVenta - costoVariable);

        } 

        public int CalculoEstado()
        {
            double puntoEquilibrio = PuntoEquilibrio();

            if (puntoEquilibrio < 0)
            {
                return -1;
            }

            else if (puntoEquilibrio > 0)
            {
                return 1;
            }

            else
            {
                return 0;
            }
        }               
    }
}
