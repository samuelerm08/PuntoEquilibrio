namespace App.Model
{
    public class Tabla
    {
        private List<Barbijo> tabla = new List<Barbijo>();

        public Tabla()
        {
            tabla.Add(new Barbijo()
            {
                codArt = 1,
                nombre = "Barbijo de Tela",
                precioVenta = 1000,
                costoFijo = 100,
                costoVariable = 500
            }); 

            tabla.Add(new Barbijo()
            {
                codArt = 2,
                nombre = "Barbijo deportivo",
                precioVenta = 500,
                costoFijo = 6200,
                costoVariable = 600
            });

            tabla.Add(new Barbijo()
            {
                codArt = 3,
                nombre = "Barbijo Descartable",
                precioVenta = 100,
                costoFijo = 500,
                costoVariable = 50
            });

            tabla.Add(new Barbijo()
            {
                codArt = 4,
                nombre = "Barbijo de Tela Regulable",
                precioVenta = 150,
                costoFijo = 9000,
                costoVariable = 500             
            });

            tabla.Add(new Barbijo()
            {
                codArt = 5,
                nombre = "Barbijo Deportivo Regulable",
                precioVenta = 1600,
                costoFijo = 9000,
                costoVariable = 1000               
            });
        }

        public List<Barbijo> Show()
        {
            return tabla;
        }

        public Barbijo? ShowOne(int codArt)
        {
            return tabla.FirstOrDefault(barbijo => barbijo.codArt == codArt);
        }
    }
}
