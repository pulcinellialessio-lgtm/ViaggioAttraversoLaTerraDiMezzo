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
        static void Azione(int scelta, int Vita, int Attacco, string personaggi, int pozioneCura, int cavalcatura, int fioreDiFuoco)
        {
            if(scelta == 1)
            {
                Console.WriteLine("Hai scelto di lanciare il dado e avanzare");
            }
            else if(scelta == 2)
            {
                Console.WriteLine("Hai scelto di mostrare lo status di Mario");
                StatusPersonaggio(Vita, Attacco, personaggi);
            }
            else if(scelta == 3)
            {
                Console.WriteLine("Hai scelto di mostrare l'inventario di Mario");
                InventarioPersonaggio(pozioneCura, cavalcatura, fioreDiFuoco);
            }
            else if(scelta == 4)
            {
                Console.WriteLine("Hai scelto di usare un oggetto");
                UsaOggetto(pozioneCura, Vita, Attacco, fioreDiFuoco, cavalcatura);
            }
            else if(scelta == 5)
            {
                Console.WriteLine("Hai scelto di uscire dal gioco");
                Environment.Exit(0);
            }
        }
        static void InventarioPersonaggio(int PozioneCura, int cavalcatura, int fioreDiFuoco) //Mostra l'inventario
        {
            Console.WriteLine(" ---------------------------");
            Console.WriteLine("|   Inventario di Mario:    |");
            Console.WriteLine("|   Pozione Cura: " + PozioneCura + "          |");
            Console.WriteLine("|   Pezzi di cavalcatura: " + cavalcatura + "   |");
            Console.WriteLine("|   Fiori di fuoco: " + fioreDiFuoco + "        |");
            Console.WriteLine(" ---------------------------");
        }
        static void UsaOggetto(int PozioneCura, int Vita, int Attacco, int fioreDiFuoco, int cavalcatura) //Usa un oggetto
        {
            Console.WriteLine("Quale oggetto vuoi usare?");
            Console.WriteLine("1: Pozione Cura");
            Console.WriteLine("2: Pezzo di cavalcatura");
            Console.WriteLine("3: Fiore di fuoco");
            int sceltaOggetto = Convert.ToInt32(Console.ReadLine());

            if(sceltaOggetto == 1)
            {
                if(PozioneCura > 0)
                {
                    Vita = Vita + 5;
                    PozioneCura--;
                    Console.WriteLine("Hai usato una Pozione Cura, la tua vita è aumentata di 5 punti!");
                }
                else
                {
                    Console.WriteLine("Non hai Pozioni Cura nell'inventario!");
                }
            }
            else if(sceltaOggetto == 2 && cavalcatura >= 2)
            {
                Console.WriteLine("Hai usato una cavalcatura, questa ti permette di avanzare più velocemente tra i vari mondi.");
                cavalcatura = cavalcatura - 2;
            }
            else if(sceltaOggetto == 3 && fioreDiFuoco > 0)
            {
                Console.WriteLine("Hai usato un Fiore di fuoco!");
                Attacco = Attacco + 3;
                fioreDiFuoco--;

            }
        }
        static void StatusPersonaggio(int Vita, int Attacco, string personaggi) //Mostra lo status di mario
        {
            Console.WriteLine(" ---------------------------");
            Console.WriteLine("|   Status di " + personaggi + ":        |");
            Console.WriteLine("|   Vita: " + Vita + "                |");
            Console.WriteLine("|   Attacco: " + Attacco + "              |");
            Console.WriteLine(" ---------------------------");
        }
        static void Fossilandia(string personaggi, int vita, int attacco, int PozioneCura, int cavalcatura) //Prima tappa del viaggio
        {
            string[] Fossilandia = { "Dinosauro", "ChainComp", "MadameBrode" };

            Random rand = new Random();
            Random Fuga = new Random();

            int DinosauroVita = 5, DinosauroAttacco = 2, ChainChompVita = 3, ChainChompAttacco = 1, MadameBroodeVita = 8, MadameBroodeAttacco = 2, p = 0, l = 0;

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

                            if (TiroDado <= 2)
                            {
                                Console.WriteLine("Valore tiro dado: " + TiroDado);
                                Console.WriteLine("Non sei riuscito ad attaccare il dinosauro, ora lui ti ha attaccato e ti ha inflitto " + DinosauroAttacco + " danni! Premi un tasto per continuare...");
                                Console.ReadLine();
                                vita -= DinosauroAttacco;
                                StatusPersonaggio(vita, attacco, personaggi);
                                Console.WriteLine("La vita del dinosauro è: " + DinosauroVita);

                                if (vita <= 0)
                                {
                                    Console.WriteLine("GAME OVER. Sei stato sconfitto dal dinosauro, il tuo viaggio finisce qui...                                     Riprovi?");
                                    Environment.Exit(0);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Valore tiro dado: " + TiroDado);
                                Console.WriteLine("Sei riuscito ad attaccare il dinosauro, gli hai inflitto " + attacco + " danni! Premi un tato per continuare...");
                                Console.ReadLine();
                                DinosauroVita -= attacco;
                                StatusPersonaggio(vita, attacco, personaggi);
                                Console.WriteLine("La vita del dinosauro è: " + DinosauroVita);

                                if (vita <= 0)
                                {
                                    Console.WriteLine("GAME OVER. Sei stato sconfitto dal dinosauro, il tuo viaggio finisce qui...                                     Riprovi?");
                                    Environment.Exit(0);
                                }
                            }
                        }

                        Console.WriteLine("Sei riuscito a stordire il dinosauro! Come ricompensa per la tua vittoria, ottieni una Pozione Cura!");

                        PozioneCura++;

                        Console.WriteLine("Ora che il dinosauro è stordito puoi usare cappy per possederlo e riuscire a distruggere ed oltrepassare il muro di roccia che ti ostacola");
                        p++;
                    }
                    else if (scelta == "2")//fuga dinosauro
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

                                if (TiroDado2 <= 2)
                                {
                                    Console.WriteLine("Valore tiro dado: " + TiroDado2);
                                    Console.WriteLine("Non sei riuscito ad attaccare il dinosauro, ora lui ti ha attaccato e ti ha inflitto " + DinosauroAttacco + " danni! Premi un tasto per continuare...");
                                    Console.ReadLine();
                                    vita -= DinosauroAttacco;
                                    StatusPersonaggio(vita, attacco, personaggi);
                                    Console.WriteLine("La vita del dinosauro è: " + DinosauroVita);

                                    if (vita <= 0)
                                    {
                                        Console.WriteLine("GAME OVER. Sei stato sconfitto dal dinosauro, il tuo viaggio finisce qui...                                     Riprovi?");
                                        Environment.Exit(0);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Valore tiro dado: " + TiroDado2);
                                    Console.WriteLine("Sei riuscito ad attaccare il dinosauro, gli hai inflitto " + attacco + " danni! Premi un tasto per continuare...");
                                    Console.ReadLine();
                                    DinosauroVita -= attacco;
                                    StatusPersonaggio(vita, attacco, personaggi);
                                    Console.WriteLine("La vita del dinosauro è: " + DinosauroVita);

                                    if (vita <= 0)
                                    {
                                        Console.WriteLine("GAME OVER. Sei stato sconfitto dal dinosauro, il tuo viaggio finisce qui...                                     Riprovi?");
                                        Environment.Exit(0);
                                    }
                                }
                            }

                            Console.WriteLine("Sei riuscito a stordire il dinosauro! Come ricompensa per la tua vittoria, ottieni una Pozione Cura!");

                            PozioneCura++;

                            Console.WriteLine("Ora che il dinosauro è stordito puoi usare cappy per possederlo e riuscire a distruggere ed oltrepassare il muro di roccia che ti ostacola");
                        }
                    }

                }
                else if (i == 1)//chainchomp
                {
                    if (p > 0)
                    {
                        Console.WriteLine("Proseguendo nel tuo cammino, vieni attaccato da una ChainComp, ma visto che sei un dinosauro ti basta fare solo un buon attacco per sconfiggerlo, ti basterà solamente totalizzare un puntaggio maggiore di 3 nel tiro di un dado per riuscire a sconfiggerlo");
                        Console.ReadLine();
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

                                if (TiroDado4 <= 2)
                                {
                                    Console.WriteLine("Valore tiro dado: " + TiroDado4);
                                    Console.WriteLine("Non sei riuscito ad attaccare Chain Chomp, ora lui ti ha attaccato e ti ha inflitto " + DinosauroAttacco + " danni! Premi un tasto per continuare...");
                                    Console.ReadLine();
                                    vita -= ChainChompAttacco;
                                    StatusPersonaggio(vita, attacco, personaggi);
                                    Console.WriteLine("La vita del ChainChomp è: " + ChainChompVita);

                                    if (vita <= 0)
                                    {
                                        Console.WriteLine("GAME OVER. Sei stato sconfitto da ChainChomp, il tuo viaggio finisce qui...                                     Riprovi?");
                                        Environment.Exit(0);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Valore tiro dado: " + TiroDado4);
                                    Console.WriteLine("Sei riuscito ad attaccare Chain Chomp, gli hai inflitto " + attacco + " danni! Premi un tato per continuare...");
                                    Console.ReadLine();
                                    ChainChompVita -= attacco;
                                    StatusPersonaggio(vita, attacco, personaggi);
                                    Console.WriteLine("La vita del ChainChomp è: " + ChainChompVita);

                                    if (vita <= 0)
                                    {
                                        Console.WriteLine("GAME OVER. Sei stato sconfitto da ChainChomp, il tuo viaggio finisce qui...                                     Riprovi?");
                                        Environment.Exit(0);
                                    }
                                }
                            }

                            Console.WriteLine("Sei riuscito a sconfiggere Chain Chomp! Come ricompensa per la tua vittoria, ottieni un pezzo di cavalcatura!");
                            cavalcatura++;
                        }
                        
                    }
                    else if(l > 0)
                    {
                        Console.WriteLine("Proseguendo nel tuo cammino, vieni attaccato da una ChainComp! Una palla di ferro legata a terra da una catena. Attaccala per continuare il viaggio.");

                        while (ChainChompVita > 0)
                        {
                            int TiroDado = rand.Next(1, 7);

                            if (TiroDado <= 2)
                            {
                                Console.WriteLine("Valore tiro dado: " + TiroDado);
                                Console.WriteLine("Non sei riuscito ad attaccare il ChainChomp, ora lui ti ha attaccato e ti ha inflitto " + ChainChompAttacco + " danni! Premi un tasto per continuare...");
                                Console.ReadLine();
                                vita -= ChainChompAttacco;
                                StatusPersonaggio(vita, attacco, personaggi);
                                Console.WriteLine("La vita del ChainChomp è: " + ChainChompVita);

                                if (vita <= 0)
                                {
                                    Console.WriteLine("GAME OVER. Sei stato sconfitto da ChainChomp, il tuo viaggio finisce qui...                                     Riprovi?");
                                    Environment.Exit(0);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Valore tiro dado: " + TiroDado);
                                Console.WriteLine("Sei riuscito ad attaccare il ChainChomp, gli hai inflitto " + attacco + " danni! Premi un tato per continuare...");
                                Console.ReadLine();
                                ChainChompVita -= attacco;
                                StatusPersonaggio(vita, attacco, personaggi);
                                Console.WriteLine("La vita del ChainChomp è: " + ChainChompVita);

                                if (vita <= 0)
                                {
                                    Console.WriteLine("GAME OVER. Sei stato sconfitto da ChainChomp, il tuo viaggio finisce qui...                                     Riprovi?");
                                    Environment.Exit(0);
                                }
                            }
                        }
                    }
                }
                else if (i == 2)//madamebrode
                {
                    Console.WriteLine("Dopo aver sconfitto la ChainComp, vieni fermato da MadameBrode!");
                    Console.WriteLine("MadameBrode è la madre dei broodals, gli scagnozzi di Bowser che cercano di rapire Peach.Ti accorgi che lei ha le chiavi della Odissey e le tiene strette, sconfiggila per riuscire a prendere le chiavi e poter viaggiare tra i mondi.");

                    while (MadameBroodeVita > 0)
                    {
                        int TiroDado5 = rand.Next(1, 7);

                        if (TiroDado5 <= 3)
                        {
                            while(MadameBroodeVita > 0)
                            {
                                Console.WriteLine("Valore tiro dado: " + TiroDado5);
                                Console.WriteLine("Non sei riuscito ad attaccare il MadameBroode, ora lei ti ha attaccato e ti ha inflitto " + MadameBroodeAttacco + " danni! Premi un tasto per continuare...");
                                Console.ReadLine();
                                vita -= MadameBroodeAttacco;
                                StatusPersonaggio(vita, attacco, personaggi);
                                Console.WriteLine("La vita del MadameBroode è: " + MadameBroodeVita);


                                if (vita <= 0)
                                {
                                    Console.WriteLine("GAME OVER. Sei stato sconfitto dal dinosauro, il tuo viaggio finisce qui...                                     Riprovi?");
                                    Environment.Exit(0);
                                }
                            }

                        }
                        else
                        {
                            while(MadameBroodeVita > 0)
                            {
                                Console.WriteLine("Valore tiro dado: " + TiroDado5);
                                Console.WriteLine("Sei riuscito ad attaccare MadameBroode, gli hai inflitto " + attacco + " danni! Premi un tato per continuare...");
                                Console.ReadLine();
                                MadameBroodeVita -= attacco;
                                StatusPersonaggio(vita, attacco, personaggi);
                                Console.WriteLine("La vita del MadameBroode è: " + MadameBroodeVita);

                                if (vita <= 0)
                                {
                                    Console.WriteLine("GAME OVER. Sei stato sconfitto dal MadameBroode, il tuo viaggio finisce qui...                                     Riprovi?");
                                    Environment.Exit(0);
                                }
                            }
                        }
                    }

                    Console.WriteLine("Sei riuscito a sconfiggere MadameBroode! Come ricompensa per la tua vittoria, ottieni le chiavi della Odissey! Pronto per la partenza parti verso un nuovo mondo...");
                }
            }
        }
        static void BoscoSolitario(string personaggio, int Vita, int Attacco, int PozioneCura)
        {
            Console.WriteLine("Dopo un viaggio abbastanza lungo, arrivi nel Regno del Bosco Solitario, un luogo dove la natura e la tecnologia si fondono in un modo sorprendente. Per continuare il viaggio la Odissey ha bisogno di energia, trova le tre lune di energia e potenzia la Odissey.");
            Console.WriteLine(personaggio + ": Mamma mia! Che posto! Sembra... una foresta in cui ha vissuto un robot gigante!");
            Console.WriteLine(personaggio + ": Guarda Cappy, gli alberi sono fatti di legno, ma anche di tubi! E che strano silenzio... meglio tenere gli occhi aperti. Non mi fido di una foresta così perfetta.");
            Console.WriteLine(personaggio + ": Dobbiamo trovare la Luna di Energia! Sento che è nascosta da qualche parte... tra le foglie o forse... sotto una di quelle piattaforme! Andiamo!");

            string[] BoscoSolitario = { "VermeElettrico", "Piranha", "Mega pianta Piranha" };

            Random rand = new Random();

            int VermeElettricoVita = 4, VermeElettricoAttacco = 1, PiranhaVita = 6, PiranhaAttacco = 1, MegaPiantaPiranhaVita = 8, MegaPiantaPiranhaAttacco = 2;

            for (int i = 0; i < BoscoSolitario.Length; i++)
            {
                if (i == 0) //VermeElettrico
                {
                    Console.WriteLine("Appena sceso dalla odissey ti devi scontrare con un Verme Elettrico che ti blocca la strada! Il Verme Elettrico è un nemico che incarna perfettamente la fusione tra natura e tecnologia tipica del Regno Bosco. Non è un essere organico né un robot puro, ma una strana combinazione di entrambi.");

                    while (VermeElettricoVita > 0)
                    {
                        int TiroDado = rand.Next(1, 7);

                        if (TiroDado <= 2)
                        {
                            Console.WriteLine("Valore tiro dado: " + TiroDado);
                            Console.WriteLine("Non sei riuscito ad attaccare il VermeElettrico, ora lui ti ha attaccato e ti ha inflitto " + VermeElettricoAttacco + " danni! Premi un tasto per continuare...");
                            Console.ReadLine();
                            Vita -= VermeElettricoAttacco;
                            StatusPersonaggio(Vita, Attacco, personaggio);
                            Console.WriteLine("La vita del VermeElettrico è: " + VermeElettricoVita);

                            if (Vita <= 0)
                            {
                                Console.WriteLine("GAME OVER. Sei stato sconfitto dal VermeElettrico, il tuo viaggio finisce qui...                                     Riprovi?");
                                Environment.Exit(0);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Valore tiro dado: " + TiroDado);
                            Console.WriteLine("Sei riuscito ad attaccare il VermeElettrico, gli hai inflitto " + Attacco + " danni! Premi un tato per continuare...");
                            Console.ReadLine();
                            VermeElettricoVita -= Attacco;
                            StatusPersonaggio(Vita, Attacco, personaggio);
                            Console.WriteLine("La vita del VermeElettrico è: " + VermeElettricoVita);

                            if (Vita <= 0)
                            {
                                Console.WriteLine("GAME OVER. Sei stato sconfitto dal dinosauro, il tuo viaggio finisce qui...                                     Riprovi?");
                                Environment.Exit(0);
                            }
                        }
                    }

                    Console.WriteLine("Sei riuscito a stordire il VermeElettrico! Come ricompensa per la tua vittoria, ottieni una Pozione Cura!");

                    PozioneCura++;

                    Console.WriteLine("Ora che il VermeElettrico è stordito puoi usare cappy per possederlo e riuscirai a passare inosservato inmezzo a tutti gli altri vermi elettrici");
                }
                else if (i == 1)//Piranha
                {

                }
                else if (i == 2)//Mega pianta Piranha
                {
                    Console.WriteLine("Dopo aver sconfitto il Piranha sali in cima all'osservatorio presente inmezzo alla mappa e incontri la Mega pianta Piranha che tiene custodite le lune di energia che propio ti servono. Sconfiggila in un duello e potrai ripartire per un nuovo mondo.");

                    while (MegaPiantaPiranhaVita > 0)
                    {
                        int TiroDado = rand.Next(1, 7);

                        if (TiroDado <= 2)
                        {
                            Console.WriteLine("Valore tiro dado: " + TiroDado);
                            Console.WriteLine("Non sei riuscito ad attaccare il VermeElettrico, ora lui ti ha attaccato e ti ha inflitto " + VermeElettricoAttacco + " danni! Premi un tasto per continuare...");
                            Console.ReadLine();
                            Vita -= MegaPiantaPiranhaAttacco;
                            StatusPersonaggio(Vita, Attacco, personaggio);
                            Console.WriteLine("La vita del VermeElettrico è: " + MegaPiantaPiranhaVita);

                            if (Vita <= 0)
                            {
                                Console.WriteLine("GAME OVER. Sei stato sconfitto dal VermeElettrico, il tuo viaggio finisce qui...                                     Riprovi?");
                                Environment.Exit(0);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Valore tiro dado: " + TiroDado);
                            Console.WriteLine("Sei riuscito ad attaccare il VermeElettrico, gli hai inflitto " + Attacco + " danni! Premi un tato per continuare...");
                            Console.ReadLine();
                            MegaPiantaPiranhaVita -= Attacco;
                            StatusPersonaggio(Vita, Attacco, personaggio);
                            Console.WriteLine("La vita del VermeElettrico è: " + MegaPiantaPiranhaVita);

                            if (Vita <= 0)
                            {
                                Console.WriteLine("GAME OVER. Sei stato sconfitto dal dinosauro, il tuo viaggio finisce qui...                                     Riprovi?");
                                Environment.Exit(0);
                            }
                        }
                    }

                    Console.WriteLine("Sei riuscito a sconfiggere la Mega pianta Piranha! Puoi andare tranquillamente a prenderere le lune di energia e tornare alla Odissey.");
                }
            }
            
        }
        static void Viaggio(string[] Mappa)
        {
            if(Mappa[1] == "viaggio")
            {
                Console.WriteLine("Mario dall'oblò della sua Odissey vede allontanarsi una terra preistorica, dove un'enorme cascata ruggisce su piattaforme rocciose e dove i resti fossilizzati di un T-Rex gigantesco giacciono tra l'erba. La terra è primitiva, ma allo stesso tempo rigogliosa e vivace.");
            }
            else if(Mappa[3] == "viaggio")
            {
                Console.WriteLine("L'Odyssey si alza in volo. Mario osserva il Regno Bosco Solitario che si trasforma rapidamente in un intricato tappeto. Vede il forte contrasto tra il verde brillante delle fitte foreste di alberi squadrati e il grigio-acciaio delle strutture meccaniche. Le torri sottili dei Legnamici e le vene metalliche dei ponti aerei si rimpiccioliscono, fondendosi in un unico, sorprendente mosaico di natura ed ingegneria. Il lago scuro e le cime rocciose, dove riposa il Boss Robo-Pianta, scompaiono nella nebbia mentre l'Odyssey punta al prossimo orizzonte.");
            }
            else if(Mappa[6] == "viaggio")
            {
                Console.WriteLine("L'Odyssey rompe il cielo, lasciando New Donk City sotto di sé. Mario vede un mare infinito di grattacieli lucidi che sembrano blocchi di LEGO futuristici. Le strade, fitte di taxi gialli e veicoli che si muovono come formiche, diventano sottili nastri di luce nel cemento.");
            }
            else if(Mappa[8] == "viaggio")
            {
                Console.WriteLine("L'Odyssey sale. Mario vede il Regno del Mare come una macchia scintillante di turchese e sabbia bianca. Dall'alto, il Palazzo Calice dorato brilla al centro. Sotto l'acqua cristallina, le formazioni di corallo rosa e arancione sono chiaramente visibili. L'intero regno si riduce a un gioiello abbagliante e tropicale che scompare rapidamente nell'azzurro.");
            }
            else if(Mappa[10] == "viaggio")
            {
                Console.WriteLine("L'Odyssey si allontana rapidamente. Mario guarda una terra di grigio metallico e scuro. Il paesaggio è un inferno industriale, dominato da una massiccia fortezza nera circondata da fiumi di lava arancione. Il regno si restringe, apparendo come un simbolo tetro e minaccioso che scompare rapidamente nell'oscurità.");
            }

        }
        static void Main(string[] args)
        {
            INTRO();

            string[] Mappa = { "Fossilandia", "viaggio", "viaggio", "viaggio", "Bosco solitario", "viaggio", "viaggio", "Imprevisto", "New Dowk city", "viaggio", "viaggio", "Bruma", "viaggio", "Tirannia", "viaggio", "viaggio", "viaggio", "viaggio", "Bowser's Kingdom", "Viaggio con Peach" };

            int Vita = 0, Attacco = 0, cavalcatura = 0, fioreDiFuoco = 0, PozioneCura = 0;

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

            for (int i = 0; i < Mappa.Length; i++)
            {
                if (i == 1)
                {
                    Fossilandia(Personaggi(Vita, Attacco), Vita, Attacco, PozioneCura, cavalcatura);
                }
                else if( i == 4)
                {

                }
            }
        }
    }
}

