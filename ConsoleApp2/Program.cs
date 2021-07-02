using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Edificios con LINQ
            /*
            //se llenan los datos a las clase
            List<Inquilinos> listaALlenar = new List<Inquilinos>();

            Inquilinos inq = new Inquilinos("Irvin", 1);
            Inquilinos inq1 = new Inquilinos("Henry", 1);
            Inquilinos inq2 = new Inquilinos("Kimberly", 3);
            Inquilinos inq3 = new Inquilinos("Maria", 4);
            Inquilinos inq4 = new Inquilinos("Carmen", 5);
            Inquilinos inq5 = new Inquilinos("Kimberly", 5);

            listaALlenar.Add(inq);
            listaALlenar.Add(inq1);
            listaALlenar.Add(inq2);
            listaALlenar.Add(inq3);
            listaALlenar.Add(inq4);
            listaALlenar.Add(inq5);


            List<Edificios> lista = new List<Edificios>();
            Edificios edi = new Edificios("Trifami", listaALlenar);
            lista.Add(edi);



            List<Edificios> newList = lista.Select(m => new Edificios { Inquilinos = m.Inquilinos.
                                                   Where(u => u.numeroLocal == 1).ToList()}).ToList();

         

            //Impresiones

            Console.WriteLine("Lista Completa" );
            foreach (var item in listaALlenar )
            {
                Console.WriteLine("Nombre: " + item.nombre + ", Numero local: " + item.numeroLocal);
            }

            Console.WriteLine("Encontrados con 1");

            foreach (var item in newList)
            {
                foreach (var lis in item.Inquilinos)
                {
                    Console.WriteLine("Nombre: " + lis.nombre + ", Numero local: " + lis.numeroLocal);
                }
            }
            */
            #endregion

            #region Facturas con LINQ
            /*
            List<Facturas> listaFacturas = new List<Facturas>();
            List<DetFacturas> listaDetFacturas = new List<DetFacturas>();

            Facturas fac;
            listaFacturas.Add(fac = new Facturas(1, "Fac100"));
            listaFacturas.Add(fac = new Facturas(2, "Fac200"));
            listaFacturas.Add(fac = new Facturas(3, "Fac300"));
            listaFacturas.Add(fac = new Facturas(4, "Fac400"));

            DetFacturas detFac;
            listaDetFacturas.Add(detFac = new DetFacturas(1, 1, 1200));
            listaDetFacturas.Add(detFac = new DetFacturas(1, 3, 1200));
            listaDetFacturas.Add(detFac = new DetFacturas(1, 2, 1200));

            var listaMostrar = (
                                from det in listaDetFacturas
                                join facs in  listaFacturas on det.idFacturaPed equals facs.idFactura into prueba
                                from p in prueba.DefaultIfEmpty()
                                select new { det.idFacturaPed,det.idLineaPedido }
                                ).ToList()


            
              //var listaMostrar = (
              //                  from Facturas in listaFacturas.
              //                  join de in listaDetFacturas on Facturas.idFactura equals de.idFacturaPed into prueba
              //                  from p in prueba.DefaultIfEmpty()
              //                  select new { Facturas = Facturas, p.idLineaPedido }
              //                  ).ToList();
             
            
            foreach (var item in listaMostrar)
            {
                Console.WriteLine("Factura y linea del pedido" + item.idLineaPedido + " " + item.idFacturaPed);
            }
            */
            #endregion

            #region matriz transpuesta
            /*
                 int[,] matri= new int [,] {{5,6,2,1},{ 1,2,3,4}, { 6, 7, 8, 9 }, { 6,7,8,9},{ 1,2,3,4} };
                 int[,] mt= new int[4, 5];

            Console.WriteLine("Cantidad de Filas " + matri.GetLength(0));
            Console.WriteLine("\t");
            Console.WriteLine("Cantidad de Columnas " + matri.GetLength(1));

            Console.WriteLine("==================================================");

            Console.WriteLine("Matriz Original");

            for (int i = 0; i < matri.GetLength(0); i++)
            {
                for (int j = 0; j < matri.GetLength(1); j++)
                {
                    Console.Write("\t" + matri[i, j]);
                }
                Console.Write("\n");
            }

            Console.WriteLine("==================================================");


            Console.WriteLine("Matriz transpuesta");
            
            for (int i = 0; i < matri.GetLength(0); i++)
            {
                for (int j = 0; j < matri.GetLength(1); j++)
                {
                    mt[j, i] = matri[i, j];
                }
            }
            
            //se imprime

            for (int i = 0; i < mt.GetLength(0); i++)
            {
                for (int j = 0; j < mt.GetLength(1); j++)
                {
                    Console.Write("\t" + mt[i, j]);
                }
                Console.Write("\n");
            }
            */
            #endregion

            #region palabra con caracteres repetidos
            /*
            string palabraEntrante = "abcda";

            bool bandera = EncontrarRepetido(palabraEntrante);

            if (bandera)
            {
                Console.Write("Si contiene letras repetidas");
            }
            else
            {
                Console.WriteLine("No contiene letras repetidas");
            }
            */
            #endregion

            #region Permutacion
            /*
            char[] miChar = new char[] { 'a', 'b', 'c' ,'d'};

            List<string> listaSalida = new List<string>();

            listaSalida= Permutacion(miChar);


            foreach (var item in listaSalida)
            {
                Console.WriteLine(item);
            }
                */
            #endregion

            #region QUICKSORT
            /*
            int[] miChar = new int[] { 9, 5, 1, 3, 4,10,8,6,7};
            int[] miChar2 = new int[] { 9, 5, 1, 3, 4,10,8,6,7};

            QuickSort(miChar, 0, miChar.Length - 1);
            quicksortNuevo(ref miChar2, 0, miChar2.Length - 1);

            Console.WriteLine("QuickSort de Kim");
            Console.WriteLine(string.Join(",", miChar)); 

            
            int[] miChar3 = new int[] { 1,3,5,4,2};
            int[] miChar4 = new int[] { 10,20,30};
            int[] miChar5 = new int[] { 13,14};
            int n = 4;*/

            /* Console.WriteLine("QuickSorte de Google");
             Console.WriteLine(string.Join(",", miChar3));
             Console.WriteLine("Cantidad Maxima: " + CalcularMax(miChar5, n));
             Console.WriteLine("Cantidad Minima: " + CalcularMin(miChar5, n)); */

            /*
            quicksortNuevo(ref miChar3, 0, miChar3.Length - 1);
            Console.WriteLine("QuickSort nuevo " + string.Join(",", miChar3));
            Console.WriteLine("Cantidad Minimo: " + miChar3.ToList().GetRange(0, n).Sum());
            Console.WriteLine("Cantidad Maximo: " + miChar3.ToList().GetRange(miChar3.Length-n,n).Sum());
            */


            #endregion

            #region INVERTIR NUMERO
            /*
            List<int> listaA = new List<int>();
            int num = 943;

            //invertir(num, listaA);
            //int final=invertirNumeroM(num);
            //Console.Write($"El numero: {num} invertido seria:{ invertirNumeroM(num) }");
            invertirNumeroM(num);
            */
            #endregion

            #region HILERA LIMPIA
            /*
            string palabra = "aaabcbbdfddera"; //abcdfera

            Console.WriteLine(hileraLimpia(palabra));
            */
            #endregion

            #region CANDIDATOS
            // enfrentamientoCandidatos();
            #endregion

            #region buses
            //Console.WriteLine("La palabra en alerta es: " + rutas("ABDACB", "ADACX"));
            /* Imprimir_Rutas("ABDAC", "BD");
             Imprimir_Rutas("ABDAC", "BDX");
             Imprimir_Rutas("ABDACB", "ADACX");*/
            #endregion

            #region triangulos
            /*
            esTriangulo(100, 100, 100);
            */
            #endregion

            #region PalabrasAnagrama
            /*
            List<string> palabrasLista = new List<string>() { "RARO", "AMOR", "ROMA", "ORAR" };

            if (PalabrasAnagrama(palabrasLista))
            {
                Console.WriteLine("Si es anagrama");
            }
            else
            {
                Console.WriteLine("No es anagrama");
            }*/

            /*
            List<string> listaAnagrama = new List<string>() { "RARO", "AMOR", "ROMA", "ORAR" };
            if (PalabrasAnagrama(listaAnagrama))
            {
                Console.WriteLine("Es anagrama");

            }
            else
            {
                Console.WriteLine("No anagrama");

            }*/

            #endregion

            #region Cadena

            //Console.WriteLine(Cadena("HolaComoEstaBienUstedYoTodoBienSi"));
            /*
            Console.WriteLine(PalabrasEnCandena("Conertertertsinpemóvildígaleadiósalefectivo"));
            */
            #endregion

            #region MatrizExamen5
            /*
            int [,] matriz = MatrizExamen5();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("\t" + matriz[i,j]);
                }
                Console.Write("\n");
            }
            */
            #endregion

            #region Cantidad Consonantes
            /*
            int cantidad = CantidadConsonantesKim("papatrajocri");
            Console.WriteLine("Cantidad de Consonantes metodo de Kim: " + cantidad);
            Console.WriteLine("======================================================");
            int cantidadConso, cantidadVocales; 
            cantidadConsonantesPractica1("papatrajocri", out cantidadConso, out cantidadVocales);
            Console.WriteLine("Cantidad de Consonantes es: " + cantidadConso + " y la cantidad de vocales es: " + cantidadVocales);
            */
            #endregion

            #region ANAGRAMA EXAMEN 5

            /*
            List<string> listaAnagrama = new List<string>() { "AMOR", "MORA", "ARON", "ROMA" };
            List<string> listaAnagrama2 = new List<string>() { "JAMON", "MONJA" };
            List<string> listaAnagrama3 = new List<string>() { "ROMA", "AMOR" };

            if (AnagramaLista(listaAnagrama))
            {
                Console.WriteLine("Es un Anagrama");
            }
            else
            {
                Console.WriteLine("No es un Anagrama");
            }
            */

            #endregion

            #region LETRAS HEREDADAS
            /*
            W d = new W();
            Z a = d;
            Y b = d;
            X c = d;
             a.M();
             b.M();
             c.M();
             d.M();

            Y b1 = new Y();
            Z a1 = b;
            a1.P();
            b1.P();
            */
            #endregion

            #region Creciente y Decreciente
            /*
            int[] arreglo = new int[] { 5, 3, 1, 2, 4 };
            Creciente(arreglo);
            Decreciente(arreglo);
*/
            #endregion

            #region Binario

            //Binario("1010");
            // Console.Write($"Numero Binario a Decimal seria:{BinarioFinal("1010")}");

            #endregion

            #region Fibonnacci
            //Fibonnacci(10);
            #endregion

            #region Matriz transpuesta
            /*
            int[,] matri = new int[,] { { 5, 6, 2, 1 }, { 1, 2, 3, 4 }, { 6, 7, 8, 9 }, { 6, 7, 8, 9 }, { 1, 2, 3, 4 } };
            
            MatrizTranspuesta(ref matri);

            for (int i = 0; i < matri.GetLength(0); i++)
            {
                for (int j = 0; j < matri.GetLength(1); j++)
                {
                    Console.Write("\t" + matri[i, j]);
                }
                Console.Write("\n");
            }
            */
            #endregion

            #region Numero Invertido
            //NumeroInvertido(4020);
            #endregion

            #region Thread de Sleep
            /*
            ObtenerHora hora1 = new ObtenerHora();
            Console.Write($"La hora es {hora1.ObtenerFechaYHora()}");
            Thread.Sleep(1000);
            ObtenerHora hora2= new ObtenerHora();
            Console.WriteLine($"La hora es {hora2.ObtenerFechaYHora()}");
            Console.ReadKey();
            */
            #endregion

            #region Productos LINQ
            /*
            List<Producto> productos = new List<Producto>()
            {
            new Producto(1,"Producto1"),
            new Producto(2,"Maquinaria"),
            new Producto(3,"Producto2"),
            new Producto(4,"Producto3"),
            new Producto(5,"Maquinaria"),
            new Producto(6,"Producto4"),
            };

            var listaSaliente = productos.Where(x=> x.nombre != "Maquinaria").GroupBy(u=> u.nombre);

            var listaSalienteA = from lis in productos
                                 where lis.nombre != "Maquinaria"
                                 group lis by lis.nombre into p
                                 select p;

            Console.WriteLine("Listado Original");
            foreach (var item in productos)
            {
                Console.WriteLine($"ID: {item.id} con Nombre: {item.nombre}");
            }

            Console.WriteLine("Listado Filtrado con lambda");
            foreach (var itemB in listaSaliente)
            {
                foreach (var item in itemB)
                {
                    Console.WriteLine($"ID: {item.id} con Nombre: {item.nombre}");
                }
            }

            Console.WriteLine("Listado Filtrado normal");
            foreach (var itemB in listaSalienteA)
            {
                foreach (var itemC in itemB)
                {
                    Console.WriteLine($"ID: {itemC.id} con Nombre: {itemC.nombre}");
                }
            }
            
            #endregion

            #region Paises LINQ
            /*
            List<Pais> paises = new List<Pais>()
            {
            new Pais(1,"Estados Unidos"),
            new Pais(2,"Estados Unidos"),
            new Pais(3,"Costa Rica"),
            new Pais(4,"Ecuador"),
            new Pais(5,"Colombia"),
            new Pais(6,"Estados Unidos"),
            };

            var listaSalienteLambda = paises.Where(x => x.nombre != "Estados Unidos").GroupBy(u => u.nombre);

            var listaSalienteLinq = from lista in paises
                                 where lista.nombre != "Estados Unidos"
                                 group lista by lista.nombre into p
                                 select p;

            Console.WriteLine("Listado Original");
            foreach (var item in paises)
            {
                Console.WriteLine($"ID: {item.id} con Nombre: {item.nombre}");
            }

            Console.WriteLine("Listado Filtrado 1 con LAMBDA");
            foreach (var itemB in listaSalienteLambda)
            {
                foreach (var item in itemB)
                {
                    Console.WriteLine($"ID: {item.id} con Nombre: {item.nombre}");
                }
            }

            Console.WriteLine("Listado Filtrado 1 con LINQ");
            foreach (var itemB in listaSalienteLinq)
            {
                foreach (var itemC in itemB)
                {
                    Console.WriteLine($"ID: {itemC.id} con Nombre: {itemC.nombre}");
                }
            }
*/

            #endregion

            #region Principios de SOLID - Abierto/Cerrado - Carro
            /*
            //Con clase Interface
            List<ICarro> listaCarrosIn = new List<ICarro>() { new Carro(), new CarroElectronico()};
            Imprimir_carro(listaCarrosIn);
            */

            /*
            //Con clase Abstracta
            List<CarroAbstracto> listaCarrosIAbs = new List<CarroAbstracto>() { new Toyota(), new Mazda() };
            ImprimirCarro(listaCarrosIAbs);
            */
            #endregion

            #region Figura de traslape
            /*
            int[] figura1 = new int[] {0,7,3,4};
            int[] figura2 = new int[] {1,2,7,8};

            if (FiguraTraslape(figura1, figura2)==1)
            {
                Console.WriteLine("La figura si traslapa");
            }
            else
            {
                Console.WriteLine("La figura no traslapa");
            }*/
            #endregion


            #region PRUEBA TECNICA FINAL
            /*
            int[] miChar3 = new int[] { 1,3,5,4,2};
            int n = 4;
            QuickSortFinal(ref miChar3, 0, miChar3.Length - 1);
            Console.WriteLine("QuickSort ordenado: " + string.Join(",", miChar3));
            Console.WriteLine("Cantidad Maxima: " + SumaMaxFinal(miChar3, n));
            Console.WriteLine("Cantidad Minima: " + SumaMinFinal(miChar3, n));
            */

            //Con sinpe movil
            /*
            Console.WriteLine(CadenaPalabrasFinal("Conertertertsinpemovildigaleadiosalefectivo"));
            */

            //Hilera Limpia
            /*
            string palabra = "aaabcbbdfddera"; //abcbdfdera
            Console.WriteLine(HileraLimpiaFinal(palabra));
            */

            /*
            //Anagrama dos palabara
            Console.WriteLine($"La palabra AMOR es Anagrama de ROMA?: {EsAnagramaPalabrasFinal("AMOR", "RIOA")} ");
            //Anagrama dos palabara
            Console.WriteLine($"La palabra AMOR es Anagrama de ROMA a pie?: {EsAnagramaPalabrasInvertidaFinal("AMOR", "ROMA")} ");
            //Anagrama con lista
            List<string> listaPalabra = new List<string>() {"AMOR","AJNOM","ROJO","MONJA" };
            Console.WriteLine($"La lista de palabras es Anagrama?: {esAnagramaListasFinal(listaPalabra)} ");
            */

            //Recursivo
            /*
            Console.Write($"El numero 943 de forma recursiva: "); RecursivoEnteroFinal(943);
            */

            //Console.WriteLine("La palabra en alerta es: " + rutas("ABDACB", "ADACX"));
            /*Imprimir_Rutas("ABDAC", "BD");
            Imprimir_Rutas("ABDAC", "BDX");
            Imprimir_Rutas("ABDACB", "ADACX"); */

            //Fibonacci
            // FibonnaciFinal(10);

            //Palabras sobrantes
            /*
            Console.WriteLine("La palabra en alerta es: " + PalabrasSobrante("2111", "3d19e12ce1"));
            Imprimir_Alerta("ABC", "A");
            */

            //Cantidad Consonantes
            /*
            string palabra = "Tareas";
            Console.WriteLine($"La cantidad de Consonantes que hay en esta palabra barba seria: {EncontrarConsonantes(palabra)}");
            Console.WriteLine("===========================");
            Console.WriteLine($"La cantidad de Consonantes que hay a Pie en esta palabra barba seria: {EncontrarConsonantesAPie(palabra)}");
            */
            /*
            var fecha = new DateTime(2000, 6, 08, 0, 0, 0);
            Trabajador p = new Trabajador("Josan", 20, "77588260-Z", 100000, fecha);
            Console.WriteLine("Nombre=" + p.Nombre);
            Console.WriteLine("NIF=" + p.NIF);
            Console.WriteLine("Sueldo=" + p.Sueldo);

            if (fecha.ToString("MM")==DateTime.Now.ToString("MM") && fecha.ToString("dd") == DateTime.Now.ToString("dd"))
            {
                p.Cumpleaños();
                Console.WriteLine($"Feliz Cumpleaños # {p.Edad}" );
            }
            else
            {
                Console.WriteLine("Edad=" + p.Edad);
            }
           
            Console.ReadKey();
            */


            #endregion

            #region PRUEBA TECNICA FINAL 2
            /*
            Console.WriteLine("Hilera original Conertertertsinpemóvildígaleadiósalefectivo");
            Console.WriteLine(ObtenerHilera("Conertertertsinpemóvildígaleadiósalefectivo"));
            */
            /*
            var a1 = new { idProceso = 1};
            var a2 = new { idProceso = 2};
            var a3 = new { idProceso = 3};

            List<object> listaProcesos = new List<object>() {a1,a2,a3};
            List<object> listaPruebas = new List<object>() {a1,a2};
            Console.WriteLine(string.Join("", ListaTerceros(listaProcesos, listaPruebas)));
            */

            /*
            int numeroFinal = 39;
            Console.WriteLine($"El numero {numeroFinal} al reves seria:");
            RecursivoCliente(numeroFinal);
            */
            #endregion

            #region Practica
            /*
            InvertirNumeroPractica(4020);

            Console.WriteLine(PalabrasLimpias("aaabcbbdfddera")); //abcbdfdera

            int cantidad = ObtenerConsonantes("papatrajocri");
            Console.WriteLine($"Cantidad de consonantes: " + cantidad);
            

            bool bandera = EncontrarLetraRepetida("abcda");

            if (bandera)
            {
                Console.Write("Si contiene letras repetidas");
            }
            else
            {
                Console.WriteLine("No contiene letras repetidas");
            }

            FibonacciPractica(10);

            Console.Write($"Numero Binario a Decimal seria:{BinarioDecimalPractica("1010")}");

           Console.WriteLine(EsAnagramaPractica("I am Lord Voldemort", "Tom Marvolo Riddle"));

            int[] miChar = new int[] { 13,14 };
            QuickSortPractica(ref miChar, 0, miChar.Length - 1);
            int n = 1;
            Console.WriteLine("El arry ordenado seria: " + string.Join(",",miChar));
            Console.WriteLine("Maximo= " + SumaMaxPractica(miChar, n));
            Console.WriteLine("Minimo= " + SumaMaxMinPractica(miChar, n));

            
            char[] chars = new char[] { 'A', 'B', 'C','D' };

            foreach (var item in PermutacionPractica(chars).OrderBy(x=> x))
            {
                Console.WriteLine(item);
            }

            */


            #endregion


        }

        #region QuickSort
        public static void QuickSort(int[] vector, int inLow, int inHi)
        {
            int tmpLow = inLow;
            int tmpHi = inHi;
            int pivot;
            int tmpSwap;
            int mitadVector = (inHi + inLow) / 2;

            pivot = vector[mitadVector];

            while (tmpLow <= tmpHi)
            {
                while (vector[tmpLow] < pivot && tmpLow < inHi)
                {
                    tmpLow += 1;
                }

                while (pivot < vector[tmpHi] && tmpHi > inLow)
                {
                    tmpHi -= 1;
                }

                if (tmpLow <= tmpHi)
                {
                    tmpSwap = vector[tmpLow];
                    vector[tmpLow] = vector[tmpHi];
                    vector[tmpHi] = tmpSwap;
                    tmpLow += 1;
                    tmpHi -= 1;
                }

                if (inLow < tmpHi) { QuickSort(vector, inLow, tmpHi); }
                if (tmpLow < inHi) { QuickSort(vector, tmpLow, inHi); }
            }
        }

        public static void ArregloInverso(int[] arregloOriginal, ref int[] arregloAP, ref int[] arregloF)
        {
            //Opcion a pie
            int f = 0;

            for (int i = arregloOriginal.Length - 1; i >= 0; i--)
            {
                arregloAP[f] = arregloOriginal[i];
                f++;
            }

            //Opcion mas facil
            Array.Reverse(arregloF);

        }

        public static void QuickSortET(ref int [] arreglo)
        {
            Array.Sort(arreglo);
        }




        #endregion

        #region Encontrar una letra repetida
        public static bool EncontrarRepetido(string palabra)
        {
            char[] letras = palabra.ToLower().ToCharArray().OrderBy(x => x).ToArray();
            bool encontrado = false;
            char letraActual = char.MinValue;

            for (int i = 0; i < palabra.Length; i++)
            {
                if (letraActual == letras[i])
                {
                    encontrado = true;
                }
                else
                {
                    letraActual = letras[i];
                }
            }
            return encontrado;

        }
        #endregion

        #region Permutacion
        public static List<string> Permutacion(char[] chars)
        {
            List<string> ListaString = new List<string>();
            ListaString.Add(chars[0].ToString());

            for (int i = 1; i < chars.Length; ++i)
            {
                int currLen = ListaString.Count;
                for (int j = 0; j < currLen; ++j)
                {
                    string w = ListaString[j];
                    for (int k = 0; k <= w.Length; ++k)
                    {
                        string nstr = w.Insert(k, chars[i].ToString());
                        if (k == 0)
                        {
                            ListaString[j] = nstr;
                        }
                        else
                        {
                            ListaString.Add(nstr);
                        }
                    }
                }

            }

            return ListaString;
        }
        #endregion

        #region invertir numero
        public static void invertir(int n, List<int> invertido)
        {
            invertido.Add(n % 10);

            if (n > 10)
            {
                invertir(n / 10, invertido);

            }
            else
            {
                Console.WriteLine((string.Join("", invertido)));
            }
        }

        public static int invertirNumero( int num)
        {
            num = num % 10;
            if (num > 10)
            {
                invertirNumero(num/10);
            }
            return num;
        }

        public static void invertirNumeroM(int num)
        {
            Console.Write(num % 10);
            if (num > 10)
            {
                invertirNumeroM(num / 10);
            }
        }

        #endregion

        #region Fila sin repetidos
        public static string hileraLimpia(string palabra)
        {
            string palabraSaliente = string.Empty;
            string letraAnterior = string.Empty;

            for (int i = 0; i < palabra.Length; i++)
            {
                if (!(letraAnterior==palabra[i].ToString()))
                {
                    palabraSaliente += palabra[i].ToString();
                    letraAnterior = palabra[i].ToString();
                }
            }

            return palabraSaliente;

        }
        #endregion

        #region Candidatos
        public static List<Candidato> crearCandidatos()
        {
            List<Candidato> lista = new List<Candidato>();

            return new List<Candidato>()    { new Candidato() { nombre = "A" },
                                              new Candidato() { nombre = "B" },
                                              new Candidato() { nombre = "C" },
                                              new Candidato() { nombre = "D" },
                                              new Candidato() { nombre = "E" },
                                              new Candidato() { nombre = "F" },
                                              new Candidato() { nombre = "G" },
                                              new Candidato() { nombre = "H" },
                                              new Candidato() { nombre = "I" },
                                              new Candidato() { nombre = "J" },
                                              new Candidato() { nombre = "K" },
                                              new Candidato() { nombre = "L" },
                                              new Candidato() { nombre = "M" }
                                            };

        }
        public static void enfrentamientoCandidatos()
        {
            List<Candidato> listaCandidatos = crearCandidatos();
            var aleatorio = new Random();

            for (int posicionCandidato = 0; posicionCandidato < listaCandidatos.Count; posicionCandidato++)
            {
                for (int posicionRival = listaCandidatos.Count - 1; posicionRival >= 0; posicionRival--)
                {
                    if (aleatorio.Next(0, listaCandidatos.Count) > posicionRival)
                    {
                        listaCandidatos[posicionCandidato].cantidadVictorias = +1;
                    }
                    else
                    {
                        listaCandidatos[posicionRival].cantidadVictorias = +1;
                    }
                }

            }

            imprimirCandidatos(listaCandidatos);

        }
        public static void imprimirCandidatos(List<Candidato> listas)
        {
            foreach (var item in listas)
            {
                Console.WriteLine($"Candidato: {item.nombre} - Cant victorias: {item.cantidadVictorias}");
            }
        }
        #endregion

        #region Rutas de Bus
        /*
        public static string rutas(string rutasHabituales, string rutasxDia)
        {
            string alerta = string.Empty;
            string temp = string.Empty;

            if (rutasHabituales != string.Empty && rutasxDia != string.Empty)
            {
                for (int i = 0; i < rutasHabituales.Length-1; i++)
                {
                    if (rutasxDia.IndexOf(rutasHabituales[i]) > -1)
                    {
                        temp = string.Concat(temp, rutasHabituales[i]);
                    }
                    else
                    {
                        temp = string.Empty;
                    }

                    alerta = temp.Length > alerta.Length ? alerta = temp : string.Empty;
                }
            }
            return alerta;
        }

        public static void Imprimir_Rutas(string rutA, string rutB) 
        {
            string resultado = rutB.Replace(rutas(rutA, rutB), "");
            Console.WriteLine(resultado);
        }
        */

        #endregion

        #region detectar triangulos

        public static void esTriangulo(int lado1, int lado2, int lado3)
        {
            bool equilatero;
            bool isosceles;
            bool escaleno;

            int suma1, suma2, suma3;

            if (lado1 == lado2 && lado1 == lado3 && lado2 == lado3)
            {
                Console.WriteLine("El traingulo es equilatero");
            }
            else if ((lado1 != lado2) ^ (lado1 != lado3) ^ (lado2 != lado3))
            {
                Console.WriteLine("El triángulo es escaleno");
            }
            else
            {
                Console.WriteLine("El triángulo es isósceles");
            }


        }

        #endregion

        #region Cadena
        public static string Cadena(string oracion)
        {
            string oracionCorrecta = string.Empty;

           // List<string> listaDicc = new List<string>() { "Hola", "Como", "Esta", "Bien", "Usted" };
            List<string> listaDicc = new List<string>() { "Con", "sinpe", "móvil", "dígale", "adiós", "al", "efectivo" };
            for (int i = 0; i < listaDicc.Count; i++)
            {
                if (oracion.Contains(listaDicc[i]))
                {
                   // oracionCorrecta += " " + listaDicc[i] + " ";
                    oracionCorrecta += string.Concat(" ", listaDicc[i]);
                }
            }

            return oracionCorrecta;
        }

        public static string PalabrasEnCandena(string oracion) 
        {
            string nuevoPalabra = string.Empty;
            List<string> listaDicc = new List<string>() { "Con", "sinpe", "móvil", "dígale", "adiós", "al", "efectivo" };

            foreach (string item in listaDicc)
            {
                if (listaDicc.Contains(item))
                {
                    nuevoPalabra += string.Concat(" ", item);
                }
            }

            return nuevoPalabra;
        }

        #endregion

        #region MatrizExamen5
        /*
        public static int[,] MatrizExamen5() 
        {
            int numR = 0;
            int[,] ma = new int[,] { 
                                     { 5, 6, 2, 1 }, 
                                     { 1, 2, 0, 4 },
                                     { 6, 7, 8, 9 }, 
                                     { 6, 7, 8, 9 }, 
                                     { 1, 2, 3, 4 } 
                                   };

            int[,] maS = new int[ma.GetLength(0), ma.GetLength(1)];


            for (int i = 0; i < ma.GetLength(0); i++)
            {
                for (int j = 0; j < ma.GetLength(1); j++)
                {
                    if (ma[i,j] == 0)
                    {
                        ma[i, j] = 0;
                    }
                    else
                    {
                        maS[i, j] = ma[i, j];
                    }
                }
            }

            return maS;
        }
        */
        #endregion

        #region Cantidad Consonantes

        public static void cantidadConsonantesPractica1(string oracion, out int cantidadConsonantes, out int cantidadVocales)
        {
            string consonantes = "BCDFGHJKLMÑPQRSTVWXYZ";
            string vocales = "AEIOU";
            oracion = oracion.ToUpper();
            int cant1 = 0, cant2 = 0;

            for (int i = 0; i < oracion.Length; i++)
            {
                if (consonantes.Contains(oracion[i]))
                {
                    cant1 += 1;
                }
                if (vocales.Contains(oracion[i]))
                {
                    cant2 += 1;
                }
            }
            cantidadConsonantes = cant1;
            cantidadVocales = cant2;
        }
        public static string consonantesEncontradas(string oracion)
        {
            string oraFinal = string.Empty;
            string consonantes = "BCDFGHJKLMÑPQRSTVWXYZ";
            oracion = oracion.ToUpper();

            for (int i = 0; i < oracion.Length; i++)
            {
                if (consonantes.Contains(oracion[i]))
                {
                    oraFinal += oracion[i].ToString();
                }
            }
            return oraFinal;
        }
        public static int EncontrarConsonantes(string palabra)
        {
            string consonantes = "bcdfghjklmñpqrstvwxyz";
            int cantidad = 0;

            foreach (char item in palabra.ToLower())
            {
               cantidad += consonantes.Contains(item) ? +1 : -0;
            }

            return cantidad;
        }
        public static int EncontrarConsonantesAPie(string palabra)
        {
            string consonantes = "bcdfghjklmñpqrstvwxyz";
            int cantidad = 0;

            for (int pos = 0; pos < palabra.Length; pos++)
            {
                for (int posj = 0; posj < consonantes.Length; posj++)
                {
                    if (palabra[pos] == consonantes[posj])
                    {
                        cantidad++;
                    }
                }
            }

            return cantidad;
        }

        #endregion

        #region ANAGRAMA EXAMEN 
        /*
        public static bool PalabrasAnagrama(List<string> Palabras)
        {
            bool encontrado = false; int contador = 0;

            foreach (string item in Palabras)
            {
                char[] ch = item.ToCharArray();
                Array.Reverse(ch);
                string tmp = new string(ch);

                if (Palabras.Contains(tmp)) 
                { 
                    contador += 1; 
                }

            }

            if (contador >= 1)
            {
                if (contador == Palabras.Count)
                {
                    encontrado = true;
                }
                else
                {
                    encontrado = false;
                }
            }

            return encontrado;
        }
        public static bool Anagrama(string pal1, string pal2)
        {
            bool encontrado = false;

            if (pal1.Length == pal2.Length)
            {
                char[] ch = pal2.ToCharArray();
                Array.Reverse(ch);
                string palabra = new string(ch);

                if (pal1.Equals(palabra))
                {
                    encontrado = true;
                }
            }
            return encontrado;
        }

        public static bool AnagramaLargo(string pal1, string pal2)
        {
            bool encontrado = false;
            char[] nuevaString = pal2.ToCharArray();
            string palabraSaliente = string.Empty;

            if (pal1.Length == pal2.Length)
            {
                for (int i = pal2.Length - 1; i >= 0; --i)
                {
                    palabraSaliente += nuevaString[i];
                }

                if (pal1 == palabraSaliente)
                {
                    encontrado = true;
                }
            }
            return encontrado;
        }
        */
        public static bool AnagramaLista(List<string> lista) 
        {
            bool esAnagrama=false; int cant = 0;

            foreach (string palabra1 in lista)
            {
                char[] temp = palabra1.ToCharArray();
                Array.Reverse(temp);
                string palabra2 = new string(temp);
                
                if (lista.Contains(palabra2))
                {
                    cant++;
                }
            }

            esAnagrama = cant == lista.Count ? true : false;

            return esAnagrama;
        }

        public static string AnagramaEntreDosPalabras(string palabra1,string palabra2)
        {
            string msj = String.Empty;

            char[] nuevaPalabra = palabra2.ToCharArray();
            Array.Reverse(nuevaPalabra);
            string palabraFinal = new string(nuevaPalabra);

            msj = palabra1.Equals(palabraFinal) == true ? "Es Anagrama" : "No es Anagrama";

            return msj;
        }

        #endregion

        #region Creciente y Decreciente
        public static void Decreciente(int[] arreglo)
        {
            int temp = 0;

            for (int i = 1; i <= arreglo.Length; i++)
            {
                for (int j = 0; j < arreglo.Length - i; j++)
                {
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        temp = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join("", arreglo));
        }

        public static void Creciente(int[] arreglo)
        {
            int temp = 0;

            for (int i = 1; i <= arreglo.Length; i++)
            {
                for (int j = 0; j < arreglo.Length - i; j++)
                {
                    if (arreglo[j] < arreglo[j + 1])
                    {
                        temp = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join("", arreglo));
        }

        #endregion

        #region BINARIO

        public static void Binario(string binario)
        {
            int multi = 1, valor = 0;

            for (int i = binario.Length - 1; i >= 0; i--)
            {
                if (binario[i].ToString() != "0")
                {
                    valor = valor + multi;
                }
                multi = multi * 2;
            }

            Console.Write(valor);
        }

        #endregion

        #region Fibonacci
        public static void Fibonnacci(int cantMax)
        {
            int a = 0, b = 1, aux = 0;

            for (int i = 0; i < cantMax; i++)
            {
                aux = a;
                a = b;
                b = aux + a;
                Console.WriteLine(a);
            }
        }
        #endregion

        #region Matriz Transpuesta

        public static void MatrizTranspuesta(ref int[,] ma)
        {
            int[,] matri = new int[ma.GetLength(1), ma.GetLength(0)];

            for (int i = 0; i < ma.GetLength(0); i++)
            {
                for (int j = 0; j < ma.GetLength(1); j++)
                {
                    matri[j, i] = ma[i, j];
                }
            }

            ma = matri;

            //return matri;
        }
        #endregion

        #region Numero Invertido

        public static void NumeroInvertido(int n)
        {
            Console.Write(n % 10);
            if (n > 10)
            {
                NumeroInvertido(n / 10);
            }
        }


        #endregion

        #region Principios de SOLID - Abierto/Cerrado - Carro

        //Con clase Interface
        public static void Imprimir_carro (List<ICarro> carros)
        {
            foreach (ICarro car in carros)
            {
                car.acelerar();
               // car.detener();
            }
        }
        #endregion

        #region Figura de traslape
    
        public static int FiguraTraslape(int[] figura1, int [] figura2) 
        {
            int final = 0; 
            int cant=0;
            int cantidadList=0;
          
            if (figura1.Length== figura2.Length)
            {
                cantidadList = figura1.Length;

                for (int i = 0; i < cantidadList; i++)
                {                                  
                    if (figura1[i] == figura2[i])
                    {
                        cant++;
                    }
                }
            }

            final = cant >= 1 ? 1 : 0;
            
            return final;
        }
        #endregion

        #region PRUEBA TECNICA FINAL

        //QuickSorts
        public static void QuickSortFinal(ref int[] arreglo, int primero, int ultimo)
        {
            int i = primero, j = ultimo, central = (primero + ultimo) / 2;
            decimal pivot = arreglo[central];

            do
            {
                while (arreglo[i] < pivot) i++;
                while (arreglo[j] > pivot) j--;

                if (i <= j)
                {
                    int temp = arreglo[i];
                    arreglo[i] = arreglo[j];
                    arreglo[j] = temp;
                    i++; j--;
                }

            } while (i <= j);

            if (primero < j){QuickSortFinal(ref arreglo, primero, j);}
            if (i < ultimo){ QuickSortFinal(ref arreglo, i, ultimo);}

        }
        public static int SumaMaxFinal(int[] arreglo, int n)
        {
            int sumatoria = 0;

            for (int i = n; i >= 1; i--)
            {
                sumatoria += arreglo[i];
            }

            return sumatoria;
        }
        public static int SumaMinFinal(int[] arreglo, int n)
        {
            int resta = 0;

            for (int i = 0; i <= n - 1; i++)
            {
                resta += arreglo[i];
            }

            return resta;
        }

        //Binario a Decimal
        public static int BinarioFinal(string binario)
        {
            int valor = 0;
            int multi = 1;

            for (int i = binario.Length - 1; i >= 0; i--)
            {
                if (binario[i].ToString() != "0")
                {
                    valor = valor + multi;
                }
                multi = multi * 2;
            }

            return valor;
        }

        //Con sinpe movil
        public static string CadenaPalabrasFinal(string oracion) 
        {
            string oracionFinal = string.Empty;
            List<string> diccionario = new List<string>()
            {"Con", "sinpe", "movil", "digale", "adios", "al", "efectivo" };

            for (int i = 0; i < diccionario.Count; i++)
            {
                if (oracion.Contains(diccionario[i]))
                {
                    oracionFinal += string.Concat(" ", diccionario[i]);
                }
            }
            return oracionFinal;
        }

        //Regresar hilera limpia
        public static string HileraLimpiaFinal(string hilera) 
        {
            string palabraFinal = string.Empty;
            string letraAnterior = string.Empty;

            for (int i = 0; i < hilera.Length; i++)
            {
                if (!(letraAnterior==hilera[i].ToString()))
                {
                    palabraFinal += hilera[i].ToString();
                    //palabraFinal += string.Concat("", hilera[i]);
                    letraAnterior = hilera[i].ToString();
                }
            }
            return palabraFinal;
        }

        //Anagrama
        public static bool EsAnagramaPalabrasFinal(string palabra1, string palabra2) 
        {
            bool esAnagrama = false;

            if (palabra1.Length==palabra2.Length)
            {
                char[] temp = palabra2.ToCharArray();
                Array.Reverse(temp);
                string mismaPalabra = new string(temp);

                esAnagrama = palabra1.Equals(mismaPalabra) ? true : false;

            }
            return esAnagrama;
        }
        public static bool EsAnagramaPalabrasInvertidaFinal(string palabra1, string palabra2)
        {
            bool esAnagrama = false;

            if (palabra1.Length == palabra2.Length)
            {
                string palabraFinal = string.Empty;

                for (int i = palabra2.Length-1; i >=0; i--)
                {
                    palabraFinal += palabra2[i];
                }

                esAnagrama = palabra1.Equals(palabraFinal) ? true : false;

            }
            return esAnagrama;
        }
        public static bool esAnagramaListasFinal(List<string> listas) 
        {
            bool esAnagrama = false;
            int contador = 0;

            foreach (string palabra in listas)
            {
                char[] temp = palabra.ToCharArray();
                Array.Reverse(temp);
                string mismaPalabra = new string(temp);

                contador += listas.Contains(mismaPalabra) ? +1 : -1;
            }

            esAnagrama = contador == listas.Count ? true : false;

            return esAnagrama;
        }


        //Recursivo integer
        public static void RecursivoEntero(int num) 
        {
            Console.Write(num % 10);
            if (num>10)
            {
                RecursivoEntero(num / 10);
            }
        }

        //Rutas de buses
        public static string rutas(string rutA, string rutB)
        {
            string alerta = "";
            string temp = "";

            for (int posicion = 0; posicion < rutA.Length - 1; posicion++)
            {
                if (rutB.IndexOf(rutA[posicion]) > -1)
                {
                    temp = string.Concat(temp, rutA[posicion]);
                }
                else
                {
                    temp = "";
                }

                if (temp.Length > alerta.Length)
                {
                    alerta = temp;
                }
            }

            return alerta;
        }
        public static void Imprimir_Rutas(string rutA, string rutB)
        {
            string resultado = rutB.Replace(rutas(rutA, rutB), "");
            Console.WriteLine(resultado);
        }
        public static void FibonnaciFinal(int cantaMax) 
        {
            int a = 0;
            int b = 1;
            int temp;

            for (int i = 0; i < cantaMax; i++)
            {
                temp = a;
                a = b;
                b = temp + a;
                Console.WriteLine(a);
            }
           
        }

        #endregion


        #region PRUEBA TECNICA FINAL 2

        public static string ObtenerHilera(string oracion) 
        {
         List<string> diccionario = new List<string>() { "Con", "sinpe", "móvil", "dígale", "adiós", "al", "efectivo"};
         string nuevaOracion = string.Empty;

            foreach (string item in diccionario)
            {
                if (oracion.Contains(item))
                {
                    nuevaOracion += string.Concat(" ", item);
                }
            }

            return nuevaOracion;
        }

        public static List<string> PermutacionFinal(char [] arreglo) 
        {
            List<string> nuevaLista = new List<string>();
            nuevaLista.Add(arreglo[0].ToString());

            for (int i = 1; i < arreglo.Length; i++)
            {
                int inCurrLen = nuevaLista.Count;
                for (int j = 0; j < inCurrLen; j++)
                {
                    string w = nuevaLista[j];
                    for (int k = 0; k <= w.Length; k++)
                    {
                        string nstr = w.Insert(k,arreglo[i].ToString());

                        if (k==0)
                        {
                            nuevaLista[j]= nstr;
                        }
                        else
                        {
                            nuevaLista.Add(nstr);
                        }

                    }
                }
            }
            return nuevaLista;
        }

        public static void RecursivoCliente(int numero) 
        {
            Console.Write(numero % 10);
            if (numero>10)
            {
                RecursivoCliente(numero / 10);
            }
        }
        #endregion



    }
}



