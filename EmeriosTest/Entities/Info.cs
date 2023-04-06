namespace EmeriosTest.Entities
{
    public class Info
    {
        public string[,] Matriz;
        private int nroFilas;
        private int nroCol;

        public int NroFilas { get => nroFilas; set => nroFilas = value; }
        public int NroCol { get => nroCol; set => nroCol = value; }

        public Info(int rows, int lenght)
        {
            NroFilas = rows;
            nroCol = lenght;
            Matriz = new string[rows,lenght];
        }
    }
}
