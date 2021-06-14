using System;
using System.Timers;
using System.Text;
using WiproWebApp.Models;
using System.IO;

namespace WiproConsole
{
    class Program
    {
        private static System.Timers.Timer aTimer;
        public static string Terminou = "S";

        static void Main(string[] args)
        {
            SetTempo();
//            Console.WriteLine("A aplicação foi iniciada em: {0:HH:mm:ss}", DateTime.Now + " Presione enter para finalizar");
            Console.WriteLine("A aplicação será iniciada em 2 minutos, por favor aguarde ou presione enter para finalizar");
            Console.ReadLine();
            aTimer.Stop();
            aTimer.Dispose();

            Console.WriteLine("Termino da aplicação.....");
        }

        private static void SetTempo()
        {
            aTimer = new System.Timers.Timer(1000 * 120);
            aTimer.Elapsed += DisparaProcesso;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private static void DisparaProcesso(Object source, ElapsedEventArgs e)
        {
            while (Terminou == "S")
            {
                Terminou = "N";
                //                Console.WriteLine("A aplicação foi repetida em: {0:HH:mm:ss}", e.SignalTime + " Pressione Enter para finalizar");
                Console.WriteLine("A consulta foi iniciada em: {0:HH:mm:ss}", e.SignalTime + " Pressione Enter para finalizar");
                var DataHoraIni = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
                DataHoraIni = DataHoraIni.Replace(":", "");
                DataHoraIni = DataHoraIni.Replace("/", "");
                DataHoraIni = DataHoraIni.Replace(" ", "_");

                var nomeArqASerGerado = "Resultado_" + DataHoraIni + ".csv";

                Moeda objMoeda = new Moeda();
                var item = objMoeda.GetItemFila();
                var dsMoedaTab = item.DsMoeda;

                if (dsMoedaTab == "Moeda não Cadastrada")
                {
                    Console.WriteLine("ATENÇÃO! Nenhuma moeda foi localizada no cadastro - Tecle enter para finalizar");
                    Console.ReadLine();
                }
                var dtInicioTab = Convert.ToDateTime(item.DtInicio);
                var dtFimTab = Convert.ToDateTime(item.DtFim);
                var cont = 0;

                var arquivo = @"../../../DadosMoeda.csv";
                using (TextReader tr = new StreamReader(arquivo, Encoding.UTF8, true))
                {
                    while (true)
                    {
                        var linha = tr.ReadLine();
                        if (linha == null) break;
                        var campos = linha.Split(';');
                        var dsMoedaArq = campos[0];
                        var dtRef = campos[1];
                        var cdMoeda = 0;
                        switch (dsMoedaArq)
                        {
                            case "AFN":
                                cdMoeda = 66;
                                break;
                            case "ALL":
                                cdMoeda = 49;
                                break;
                            case "ANG":
                                cdMoeda = 33;
                                break;
                            case "ARS":
                                cdMoeda = 3;
                                break;
                            case "AWG":
                                cdMoeda = 6;
                                break;
                            case "BOB":
                                cdMoeda = 56;
                                break;
                            case "BYN":
                                cdMoeda = 64;
                                break;
                            case "CAD":
                                cdMoeda = 25;
                                break;
                            case "CDF":
                                cdMoeda = 58;
                                break;
                            case "CLP":
                                cdMoeda = 16;
                                break;
                            case "COP":
                                cdMoeda = 37;
                                break;
                            case "CRC":
                                cdMoeda = 52;
                                break;
                            case "CUP":
                                cdMoeda = 8;
                                break;
                            case "CVE":
                                cdMoeda = 51;
                                break;
                            case "CZK":
                                cdMoeda = 29;
                                break;
                            case "DJF":
                                cdMoeda = 36;
                                break;
                            case "DZD":
                                cdMoeda = 54;
                                break;
                            case "EGP":
                                cdMoeda = 12;
                                break;
                            case "EUR":
                                cdMoeda = 20;
                                break;
                            case "FJD":
                                cdMoeda = 38;
                                break;
                            case "GBP":
                                cdMoeda = 22;
                                break;
                            case "GEL":
                                cdMoeda = 48;
                                break;
                            case "GIP":
                                cdMoeda = 18;
                                break;
                            case "HTG":
                                cdMoeda = 63;
                                break;
                            case "ILS":
                                cdMoeda = 40;
                               break;
                            case "IRR":
                                cdMoeda = 17;
                                break;
                            case "ISK":
                                cdMoeda = 11;
                                break;
                            case "JPY":
                                cdMoeda = 9;
                                break;
                            case "KES":
                                cdMoeda = 21;
                                break;
                            case "KMF":
                                cdMoeda = 19;
                                break;
                            case "LBP":
                                cdMoeda = 42;
                                break;
                            case "LSL":
                                cdMoeda = 4;
                                break;
                            case "MGA":
                                cdMoeda = 35;
                                break;
                            case "MGB":
                                cdMoeda = 26;
                                break;
                            case "MMK":
                                cdMoeda = 69;
                                break;
                            case "MRO":
                                cdMoeda = 53;
                                break;
                            case "MRU":
                                cdMoeda = 15;
                                break;
                           case "MUR":
                                cdMoeda = 7;
                                break;
                            case "MXN":
                                cdMoeda = 41;
                                break;
                            case "MZN":
                                cdMoeda = 43;
                                break;
                            case "NIO":
                                cdMoeda = 23;
                                break;
                            case "NOK":
                                cdMoeda = 62;
                                break;
                            case "OMR":
                                cdMoeda = 34;
                                break;
                            case "PEN":
                                cdMoeda = 45;
                                break;
                            case "PGK":
                                cdMoeda = 2;
                            break;
                            case "PHP":
                                cdMoeda = 24;
                                break;
                            case "RON":
                                cdMoeda = 5;
                                break;
                            case "SAR":
                                cdMoeda = 44;
                                break;
                            case "SBD":
                                cdMoeda = 32;
                                break;
                            case "SGD":
                                cdMoeda = 70;
                                break;
                            case "SLL":
                                cdMoeda = 10;
                                break;
                            case "SOS":
                                cdMoeda = 61;
                                break;
                            case "SSP":
                                cdMoeda = 47;
                               break;
                            case "SZL":
                                cdMoeda = 55;
                                break;
                            case "THB":
                                cdMoeda = 39;
                                break;
                            case "TRY":
                                cdMoeda = 13;
                                break;
                            case "TTD":
                                cdMoeda = 67;
                                break;
                            case "UGX":
                                cdMoeda = 59;
                                break;
                            case "USD":
                                cdMoeda = 1;
                                break;
                            case "UYU":
                                cdMoeda = 46;
                                break;
                            case "VES":
                                cdMoeda = 68;
                                break;
                            case "VUV":
                                cdMoeda = 57;
                                break;
                            case "WST":
                                cdMoeda = 28;
                                break;
                            case "XAF":
                                cdMoeda = 30;
                                break;
                            case "XAU":
                                cdMoeda = 60;
                                break;
                            case "XDR":
                                cdMoeda = 27;
                                break;
                            case "XOF":
                                cdMoeda = 14;
                                break;
                            case "XPF":
                                cdMoeda = 50;
                                break;
                            case "ZAR":
                                cdMoeda = 65;
                                break;
                            case "ZWL":
                                cdMoeda = 3;
                                break;
                            default:
                                cdMoeda = 0;
                                break;
                        }
                        if (cdMoeda > 0)
                        {
                            var dtReferencia = Convert.ToDateTime(dtRef);
                            if (dtReferencia >= dtInicioTab && dtReferencia <= dtFimTab)
                            {
                                var arqCotacao = @"../../../DadosCotacao.csv";
                                using (TextReader trCot = new StreamReader(arqCotacao, Encoding.UTF8, true))
                                {
                                    while (true)
                                    {
                                        var linhaCot = trCot.ReadLine();
                                        if (linhaCot == null) break;
                                        var camposCot = linhaCot.Split(';');
                                        if (camposCot[0] != "vlr_cotacao")
                                        {
                                            var cdCotacao = Convert.ToInt32(camposCot[1]);
                                            if (cdMoeda == cdCotacao)
                                            {
                                                if (Convert.ToDateTime(camposCot[2]) >= dtInicioTab && Convert.ToDateTime(camposCot[2]) <= dtFimTab)
                                                {
                                                    var registro = "";
                                                    if (cont == 0)
                                                    {
                                                        registro = "ID_MOEDA; DATA_REF; VL_COTACAO";
                                                        cont++;
                                                    }
                                                    else
                                                    {
                                                        registro = dsMoedaTab + ";" + dtReferencia + ";" + camposCot[0];
                                                    }
                                                    using (TextWriter tw = new StreamWriter("../../../" + nomeArqASerGerado, true, Encoding.UTF8))
                                                    {
                                                        tw.WriteLine(registro);
                                                        tw.Close();
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Terminou = "S";
        }
    }
}
