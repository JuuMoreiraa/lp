using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Ｐｒｏｊｅｔｏ Ｃ＃");
Console.WriteLine("Olá! Bem vindo ao bereta lanches");

//declaração de array
string[] lista = { "[1]", "[2]", "[3]", "[4]", "[5]", };
string[] lancho = { "x-dasala", "x-akon", "biglek", "rooper", "x-nóstodos" };
double[] valorL = { 12.0, 15.0, 10.0, 17.00, 20.00 };
string[] bebidas = { "Suco de acerola", "Suco de Laranja", "Suco de maracujá", "Refri lata", "Cerveja" };
double[] valorB = { 7.00, 6.00, 6.00, 5.00, 3.50 };



//void
void comprasuco(double soma){
    Console.WriteLine($"Você gostaria de alguma bebida para acompanhar?");
    string bebida = Console.ReadLine();

    if (bebida == "nao")
    {
        Console.WriteLine($"Certo! \n A soma total do seu pedido é de {soma.ToString("c")}");
        return;
    }
    else
    {
        repeatvoid:
        Console.WriteLine($"Escolha a opção de bebida desejada: \n{lista[0]} {bebidas[0]} - {valorB[0].ToString("c")}  \n{lista[1]} {bebidas[1]} - {valorB[1].ToString("c")} \n{lista[2]} {bebidas[2]} - {valorB[2].ToString("c")} \n{lista[3]} {bebidas[3]} - {valorB[3].ToString("c")} \n{lista[4]} {bebidas[4]} - {valorB[4].ToString("c")} \n[0] Sair");
        string escolhab = Console.ReadLine();
        switch (escolhab)
        {
            case "0":
                Console.WriteLine("Volte sempre! ;)");
                break;
            case "1":
                Console.WriteLine($"A bebida escolhida foi {bebidas[0]}, e seu valor é de {(valorB[0]).ToString("c")}.");
                double st = soma + valorB[0];
                Console.WriteLine($"A soma total do seu pedido foi de {st.ToString("c")}");
                break;
            case "2":
                Console.WriteLine($"A bebida escolhida foi {bebidas[1]}, e seu valor é de {(valorB[1]).ToString("c")}.");
                st = soma + valorB[1];
                Console.WriteLine($"A soma total do seu pedido foi de {st.ToString("c")}");
                break;
            case "3":
                Console.WriteLine($"A bebida escolhida foi {bebidas[2]}, e seu valor é de {(valorB[2]).ToString("c")}.");
                st = soma + valorB[2];
                Console.WriteLine($"A soma total do seu pedido foi de {st.ToString("c")}");
                break;
            case "4":
                Console.WriteLine($"A bebida escolhida foi {bebidas[3]}, e seu valor é de {(valorB[3]).ToString("c")}.");
                st = soma + valorB[3];
                Console.WriteLine($"A soma total do seu pedido foi de {st.ToString("c")}");
                break;
            case "5":
                Console.WriteLine($"A bebida escolhida foi {bebidas[4]}, e seu valor é de {(valorB[4]).ToString("c")}.");
                st = soma + valorB[4];
                Console.WriteLine($"A soma total do seu pedido foi de {st.ToString("c")}");
                break;
            default:
                Console.WriteLine("Opção selecionada não encontrada! \nEscolha outra bebid4!!");
                goto repeatvoid;
        }
    }
}


//imprimindo tabela de opções
repeat1:
Console.WriteLine($"Escolha a opção de lancho desejado: \n{lista[0]} {lancho[0]} - {valorL[0].ToString("c")}  \n{lista[1]} {lancho[1]} - {valorL[1].ToString("c")} \n{lista[2]} {lancho[2]} - {valorL[2].ToString("c")} \n{lista[3]} {lancho[3]} - {valorL[3].ToString("c")} \n{lista[4]} {lancho[4]} - {valorL[4].ToString("c")} \n[0] Sair");
string escolha = Console.ReadLine();

//saída

switch (escolha)
{
    case "0":
        Console.WriteLine("Volte sempre! ;)");
        break;
    case "1":
        Console.WriteLine($"O lancho escolhido foi o {lancho[0]}, e seu valor é de {(valorL[0]).ToString("c")}.");
        double soma = valorL[0];
        comprasuco(soma);
        break;
    case "2":
        Console.WriteLine($"O lancho escolhido foi o {lancho[1]}, e seu valor é de {(valorL[1]).ToString("c")}.");
        soma = valorL[1];
        comprasuco(soma);
        break;
    case "3":
        Console.WriteLine($"O lancho escolhido foi o {lancho[2]}, e seu valor é de {(valorL[2]).ToString("c")}.");
        soma = valorL[2];
        comprasuco(soma);
        break;
    case "4":
        Console.WriteLine($"O lancho escolhido foi o {lancho[3]}, e seu valor é de {(valorL[3]).ToString("c")}.");
        soma = valorL[3];
        comprasuco(soma);
        break;
    case "5":
        Console.WriteLine($"O lancho escolhido foi o {lancho[4]}, e seu valor é de {(valorL[4]).ToString("c")}.");
        soma = valorL[4];
        comprasuco(soma);
        break;
    default:
        Console.WriteLine("Opção selecionada não encontrada! \nEscolha outro lanch0!!");
        goto repeat1;
}

//
Console.ReadKey();



