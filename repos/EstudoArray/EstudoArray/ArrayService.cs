namespace EstudoArray
{
    public class ArrayService
    {
        public void Execute()
        {
            var meuArray = new int[15];
            meuArray[0] = 22;
            meuArray[1] = 27;
            meuArray[2] = 33;
            meuArray[3] = 18;
            meuArray[4] = 9;
            meuArray[5] = 15;
            meuArray[6] = 44;
            meuArray[7] = 54;
            meuArray[8] = 21;
            meuArray[9] = 13;
            meuArray[10] = 78;
            meuArray[11] = 12;
            meuArray[12] = 96;
            meuArray[13] = 61;
            meuArray[14] = 55;


            var nomesArray = new string[10];
            nomesArray[0] = "Jovana";
            nomesArray[1] = "William";
            nomesArray[2] = "Bille";
            nomesArray[3] = "Belina";
            nomesArray[4] = "Ione";
            nomesArray[5] = "Iolanda";
            nomesArray[6] = "Luiz";
            nomesArray[7] = "Eliseu";
            nomesArray[8] = "Nina";
            nomesArray[9] = "Lili";

            PrintandoLista(nomesArray);

            for (int i = 0; i < 10; i++)
            {
                if (nomesArray[i] == "Belina")
                {
                    nomesArray[i] = "";
                }
            }

            PrintandoLista(nomesArray);
        }

        public void PrintandoLista(string[] nomesArray)
        {
            Console.WriteLine("--------- printando array ---------");
            foreach (var nomes in nomesArray)
            {
                Console.WriteLine(nomes);
            }
        }
       
    }
}
