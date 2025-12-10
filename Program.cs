using System;
using System.ComponentModel.Design;
using System.Data;

namespace ViaggioControBowser
{
    internal class Program
    {
        static void INTRO() //Introduzione al gioco
        {
            Console.WriteLine("SUPER MARIO ODYSSEY");

            Console.WriteLine("Bowser:Troppo tardi, Mario! Ti ho battuto sul tempo! Non importa quanti salti e capriole fai, non potrai mai raggiungere questo aereo.\r\n\r\nMario:Bowser! Lascia andare Peach, immediatamente! La tua pazzia deve finire!\r\n\r\nPeach: Mario, non preoccuparti per me! Lui ha barato!\r\n\r\nBowser: Barato? Io la chiamo preparazione meticolosa, cara Principessa. E questa volta, non è un rapimento come gli altri. Questo è... un matrimonio!\r\n\r\nMario: Mamma mia! Un... un cappello da sposa?!\r\n\r\nBowser: Esatto! Ho radunato gli oggetti più sfarzosi e i cuochi migliori dell'intero universo per rendere questo il matrimonio più grandioso che il Regno dei Funghi non vedrà mai! E tu, insignificante idraulico, sei in prima fila... come spettatore della mia vittoria!\r\n\r\nMario: Non accadrà mai! Io ti fermerò! (Mario si lancia verso Bowser, ma una barriera di fuoco Koopa lo respinge.)\r\n\r\nBowser: Ah ah ah! Sei stanco e senza forze. E, cosa più importante... sei senza cappello! Senza il tuo cappello portafortuna, sei solo un tipo baffuto in salopette. Addio, Mario! Divertiti a guardare le mie nozze da sotto!\r\n\r\nMario:Non ho ancora finito, Bowser! Tornerò!");

            Console.WriteLine("\r\n\r\n");

        }
        static string Personaggi(int vita, int attacco) //Scelta personaggio
        {
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine("| Scegli il potagonista della vicenda:     |");
            Console.WriteLine("|                                          |");
            Console.WriteLine("| 1: MARIO.  Punti vita = 10 / Attacco = 2 |");
            Console.WriteLine("|                                          |");
            Console.WriteLine("| 2: LUIGI.  Punti vita = 6 / Attaco = 4   |");
            Console.WriteLine("|                                          |");
            Console.WriteLine(" ------------------------------------------");

            string personaggi = Console.ReadLine();

            Console.WriteLine("Sei nei panni di " + personaggi + ", devi riuscire ad arrivare alla fortezza di Bowser (Bowser's kingdom) e salvare la principessa Peach. Qusto viaggio non sarà facile, ci saranno imprevisti nel mezzo del viaggio che potranno cambiare le sorti dell'avventura, ad accompagnarti c'è cappy, un'alleato di mario che permette a lui di possedere personaggi, nemici e oggetti. Quindi detto ciò buona fortuna...");

            return personaggi;
        }
        static int TurnoDiGioco() //Menu delle azioni
        {
            Console.WriteLine(" -------------------------------------");
            Console.WriteLine("|   Cosa vuoi fare?                   |");
            Console.WriteLine("|   1. Lancia il dado e avanza        |");
            Console.WriteLine("|   2. Mostra stutus di Mario         |");
            Console.WriteLine("|   3. Mostra inventario di Mario     |");
            Console.WriteLine("|   4. Usa oggetto                    |");
            Console.WriteLine("|   5. Esci dal gioco                 |");
            Console.WriteLine(" -------------------------------------");

            int scelta = Convert.ToInt32(Console.ReadLine());

            return scelta;
        }
        static void StatusPersonaggio(int Vita, int Attacco, string personaggi) //Mostra lo status di mario
        {
            Console.WriteLine(" ---------------------------");
            Console.WriteLine("|   Status di " + personaggi + " :        |");
            Console.WriteLine("|   Vita: " + Vita + "       |");
            Console.WriteLine("|   Attacco: " + Attacco + "        |");
            Console.WriteLine(" ---------------------------");
        }
        static void Fossilandia(string personaggi, int vita, int attacco, string[] inventario) //Prima tappa del viaggio
        {
            string[] Fossilandia = { "Dinosauro", "ChainComp", "MadameBrode" };

            Random rand = new Random();
            Random Fuga = new Random();

            int DinosauroVita = 10, DinosauroAttacco = 2, ChainChompVita = 5, ChainChompAttacco = 1, MadameBroodeVita = 20, MadameBroodeAttacco = 2, p = 0, l = 0;

            for (int i = 0; i < Fossilandia.Length; i++)
            {
                if (i == 0) //Dinosauro
                {
                    Console.WriteLine("Sei entrato in Fossilandia, all'improvviso un Dinosauro ti blocca la strada ma noti una via di fuga!");

                    Console.WriteLine(" Cosa scegli di fare? ");
                    Console.WriteLine(" 1: Affrontare il Dinosauro, con possibile ricompensa ");
                    Console.WriteLine(" 2: Fuggire via dalla via di fuga senza prendere rischi ");
                    string scelta = Console.ReadLine();

                    if (scelta == "1")
                    {
                        Console.WriteLine("Hai deciso di affrontare il Dinosauro!");

                        while (DinosauroVita > 0)
                        {
                            int TiroDado = rand.Next(1, 7);

                            if (TiroDado <= 3)
                            {
                                Console.WriteLine("Valore tiro dado: " + TiroDado);
                                Console.WriteLine("Non sei riuscito ad attaccare il dinosauro, ora lui ti ha attaccato e ti ha inflitto " + DinosauroAttacco + " danni! Premi un tasto per continuare...");
                                Console.ReadLine();
                                vita -= DinosauroAttacco;
                            }
                            else
                            {
                                Console.WriteLine("Valore tiro dado: " + TiroDado);
                                Console.WriteLine("Sei riuscito ad attaccare il dinosauro, gli hai inflitto " + attacco + " danni! Premi un tato per continuare...");
                                Console.ReadLine();
                                DinosauroVita -= attacco;
                            }
                        }

                        Console.WriteLine("Sei riuscito a stordire il dinosauro! Come ricompensa per la tua vittoria, ottieni una Pozione Cura!");

                        ////////////////////////////inventario

                        Console.WriteLine("Ora che il dinosauro è stordito puoi usare cappy per possederlo e riuscire a distruggere ed oltrepassare il muro di roccia che ti ostacola");
                        p++;
                    }
                    else if (scelta == "2")
                    {
                        Console.WriteLine("Hai deciso di fuggire via dalla via di fuga!");
                        Console.WriteLine("Puoi fuggire via solo se otterrai un valore superiore a 80 nel tiro del dado!");

                        int TiroDadoFuga = Fuga.Next(1, 101);

                        if (TiroDadoFuga > 80)
                        {
                            Console.WriteLine("Valore tiro dado fuga: " + TiroDadoFuga);
                            Console.WriteLine("Sei riuscito a fuggire via dal dinosauro utilizzando la via di fuga!");
                            l++;
                        }
                        else
                        {
                            Console.WriteLine("Valore tiro dado fuga: " + TiroDadoFuga);
                            Console.WriteLine("Non sei riuscito a fuggire via dal dinosauro, prova ad attaccarlo!");
                            p++;

                            while (DinosauroVita > 0)
                            {
                                int TiroDado2 = rand.Next(1, 7);

                                if (TiroDado2 <= 3)
                                {
                                    Console.WriteLine("Valore tiro dado: " + TiroDado2);
                                    Console.WriteLine("Non sei riuscito ad attaccare il dinosauro, ora lui ti ha attaccato e ti ha inflitto " + DinosauroAttacco + " danni! Premi un tasto per continuare...");
                                    Console.ReadLine();
                                    vita -= DinosauroAttacco;
                                }
                                else
                                {
                                    Console.WriteLine("Valore tiro dado: " + TiroDado2);
                                    Console.WriteLine("Sei riuscito ad attaccare il dinosauro, gli hai inflitto " + attacco + " danni! Premi un tasto per continuare...");
                                    Console.ReadLine();
                                    DinosauroVita -= attacco;
                                }
                            }

                            Console.WriteLine("Sei riuscito a stordire il dinosauro! Come ricompensa per la tua vittoria, ottieni una Pozione Cura!");

                            ///////////////////////////

                            Console.WriteLine("Ora che il dinosauro è stordito puoi usare cappy per possederlo e riuscire a distruggere ed oltrepassare il muro di roccia che ti ostacola");
                        }
                    }

                }
                else if (i == 1)
                {
                    if (p > 0)
                    {
                        Console.WriteLine("Proseguendo nel tuo cammino, vieni attaccato da una ChainComp, ma visto che sei un dinosauro ti basta fare solo un buon attacco per sconfiggerlo, ti basterà solamente totalizzare un puntaggio maggiore di 3 nel tiro di un dado per riuscire a sconfiggerlo");
                        int TiroDado3 = rand.Next(1, 7);

                        if (TiroDado3 > 3)
                        {
                            Console.WriteLine("Valore tiro dado: " + TiroDado3);
                            Console.WriteLine("Sei riuscito a sconfiggere Chain Chomp! Come ricompensa per la tua vittoria, ottieni un pezzo di cavalcatura!");
                        }
                        else
                        {
                            Console.WriteLine("Valore tiro dado: " + TiroDado3);
                            Console.WriteLine("Non sei riuscito a sconfiggere la ChainComp, ora lui ti ha colpito e sei tornato di nuovo nel corpo di " + personaggi + "! Prova a sconfiggerlo.");

                            while (ChainChompVita > 0)
                            {
                                int TiroDado4 = rand.Next(1, 7);

                                if (TiroDado4 <= 3)
                                {
                                    Console.WriteLine("Valore tiro dado: " + TiroDado4);
                                    Console.WriteLine("Non sei riuscito ad attaccare Chain Chomp, ora lui ti ha attaccato e ti ha inflitto " + DinosauroAttacco + " danni! Premi un tasto per continuare...");
                                    Console.ReadLine();
                                    vita -= ChainChompAttacco;
                                }
                                else
                                {
                                    Console.WriteLine("Valore tiro dado: " + TiroDado4);
                                    Console.WriteLine("Sei riuscito ad attaccare Chain Chomp, gli hai inflitto " + attacco + " danni! Premi un tato per continuare...");
                                    Console.ReadLine();
                                    ChainChompVita -= attacco;
                                }
                            }

                            Console.WriteLine("Sei riuscito a sconfiggere Chain Chomp! Come ricompensa per la tua vittoria, ottieni un pezzo di cavalcatura!");
                        }
                        
                    }
                    else if(l > 0)
                    {
                        Console.WriteLine("Proseguendo nel tuo cammino, vieni attaccato da una ChainComp! Una palla di ferro legata a terra da una catena. Attaccala per continuare il viaggio.");

                        while (ChainChompVita > 0)
                        {
                            int TiroDado = rand.Next(1, 7);

                            if (TiroDado <= 3)
                            {
                                Console.WriteLine("Valore tiro dado: " + TiroDado);
                                Console.WriteLine("Non sei riuscito ad attaccare il dinosauro, ora lui ti ha attaccato e ti ha inflitto " + ChainChompAttacco + " danni! Premi un tasto per continuare...");
                                Console.ReadLine();
                                vita -= ChainChompAttacco;
                            }
                            else
                            {
                                Console.WriteLine("Valore tiro dado: " + TiroDado);
                                Console.WriteLine("Sei riuscito ad attaccare il dinosauro, gli hai inflitto " + attacco + " danni! Premi un tato per continuare...");
                                Console.ReadLine();
                                ChainChompVita -= attacco;
                            }
                        }
                    }
                }
                else if (i == 2)
                {
                    Console.WriteLine("Dopo aver sconfitto la ChainComp, vieni fermato da MadameBrode!");
                    Console.WriteLine("MadameBrode è la madre dei broodals, gli scagnozzi di Bowser che cercano di rapire Peach.Ti accorgi che lei ha le chiavi della Odissey e le tiene strette, sconfiggila per riuscire a prendere le chiavi e poter viaggiare tra i mondi.");

                    while (MadameBroodeVita > 0)
                    {
                        int TiroDado5 = rand.Next(1, 7);

                        if (TiroDado5 <= 3)
                        {
                            Console.WriteLine("Valore tiro dado: " + TiroDado5);
                            Console.WriteLine("Non sei riuscito ad attaccare il MadameBroode, ora lei ti ha attaccato e ti ha inflitto " + MadameBroodeAttacco + " danni! Premi un tasto per continuare...");
                            Console.ReadLine();
                            vita -= MadameBroodeAttacco;

                            if (MadameBroodeVita <= 10)
                            {
                                Console.WriteLine("MadameBroode si è infuriata, ora lei fa 4 di danno e ha usato una pozione di cura che le restituisce 1 di vita ad ogni turno");
                                MadameBroodeAttacco = 4;
                                MadameBroodeVita++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Valore tiro dado: " + TiroDado5);
                            Console.WriteLine("Sei riuscito ad attaccare MadameBroode, gli hai inflitto " + attacco + " danni! Premi un tato per continuare...");
                            Console.ReadLine();
                            MadameBroodeVita -= attacco;

                            if (MadameBroodeVita <= 10)
                            {
                                Console.WriteLine("MadameBroode si è infuriata, ora lei fa 4 di danno e ha usato una pozione di cura che le restituisce 1 di vita ad ogni turno");
                                MadameBroodeAttacco = 4;
                                MadameBroodeVita++;
                            }
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            INTRO();

            string[] Mappa = { "Fossilandia", "Bosco solitario", "New Dowk city", "Bruma", "Tirannia", "Bowser's Kingdom" };

            string[] Inventario = { };

            int Vita = 0, Attacco = 0;

            if (Personaggi(Vita, Attacco) == "Mario")
            {
                Vita = 10;
                Attacco = 2;
                Console.WriteLine("Hai scelto Mario come protagonista!");
            }
            else if (Personaggi(Vita, Attacco) == "Luigi")
            {
                Vita = 6;
                Attacco = 4;
                Console.WriteLine("Hai scelto Luigi come protagonista!");
            }

            Fossilandia(Personaggi(Vita, Attacco), Vita, Attacco, Inventario);

            for (int i = 0; i < Mappa.Length; i++)
            {


            }
        }
    }
}

