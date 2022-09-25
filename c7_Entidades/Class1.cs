namespace c7_Entidades
{
    public static class Random1
    {   
        public static int GenerarNumeroAleatorio()
        {
            Random random = new Random();
            int numero=0;
            while (numero == 0)
            {
                numero=random.Next(-100, 100);
            }
            return numero;
        }
    }
}