using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Net;
using System.Net.NetworkInformation;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Revisao {
    class Program{

        static void Main(string[] args){

            int resp = 0;

            Console.WriteLine("");
            Console.WriteLine("=============================================");
            Console.WriteLine("REVISANDO O BASICO");
            Console.WriteLine("=============================================");

            while(resp != 11){
                Console.WriteLine("Opções: ");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("1 - Trabalhando com impressões na tela");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("2 - Trabalhando com variaveis e leitura de variaveis");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("3 - Trabalhando com funções");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("4 - Trabalhando com estrutura de repetição for");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("5 - Trabalhando com classes");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("6 - Trabalhando com classes e construtores");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("7 - Trabalhando com métodos estáticos");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("8 - Trabalhando com vetores e classes");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("9 - Trabalhando com listas");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("10 - Trabalhando com matrizes");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("12 - Sair");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("");
                Console.Write("Digite a opção escolhida: ");
                resp = int.Parse(Console.ReadLine());

                if (resp == 1){

                    string produto1 = "Computador", produto2 = "Mesa de Escritório";
                    byte idade = 30;
                    int codigo = 5290;
                    char genero = 'M';
                    double preco1 = 2100.0, preco2 = 650.50, medida = 53.234567;

                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("Trabalhando com impressões na tela");
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("Produtos:");
                    Console.WriteLine(produto1 + ", cujo preco e $ " + preco1);
                    Console.WriteLine(produto2 + ", cujo preco e $ " + preco2);
                    Console.WriteLine("");
                    Console.WriteLine("Registro: "+ idade +" anos de idade, codigo "+ codigo +" e genero: "+ genero);
                    Console.WriteLine("");
                    Console.WriteLine("Medida com 8 casas decimais: "+ medida.ToString("f8"));
                    Console.WriteLine("Arredondado (tres casas decimais): "+ medida.ToString("f3"));
                    Console.WriteLine("Separador decimal invariant culture: "+ medida.ToString("f3", CultureInfo.InvariantCulture));
                    Console.WriteLine("");
                    Console.WriteLine("Clique 'enter' para voltar ao menu.");
                    Console.ReadLine();
                }

                else if (resp == 2){

                    string nome, ultNome;
                    int quartos, idade;
                    double preco, altura;
                    string[] vet;

                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("Trabalhando com variaveis e leitura de variaveis");
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("Entre com seu nome completo: ");
                    nome = Console.ReadLine();

                    Console.WriteLine("Quantos quartos tem na sua casa? ");
                    quartos = int.Parse(Console.ReadLine());

                    Console.WriteLine("Entre com o preço do produto: ");
                    preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("Entre com seu ultimo nome, idade e altura: ");
                    vet = Console.ReadLine().Split(' ');

                    ultNome = vet[0];
                    idade = int.Parse(vet[1]);
                    altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

                    Console.WriteLine("");
                    Console.WriteLine("Nome: "+ nome);
                    Console.WriteLine("Quartos: "+ quartos);
                    Console.WriteLine("Preço: "+ preco.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("Nome/Idade/Altura: "+ ultNome + ", " + idade + " e " + altura.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("");
                    Console.WriteLine("Clique 'enter' para voltar ao menu.");
                    Console.ReadLine();
                }

                else if (resp == 3){
                    
                    double preco;

                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("Trabalhando com funções");
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("Digiete o preço de um produto: ");
                    preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    double valFinal = Promocao(preco);
                    Console.WriteLine("O preço -20% é: " + valFinal.ToString("f2", CultureInfo.InvariantCulture));
                    Console.WriteLine("");
                    Console.WriteLine("Clique 'enter' para voltar ao menu.");
                    Console.ReadLine();
                }

                else if (resp == 4){

                    int n;
                    int[] vet;

                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("Trabalhando com estrutura de repetição for");
                    Console.WriteLine("-------------------------------------------------------");
                    Console.Write("Digite quantos números inteiros você vai digitar: ");
                    n = int.Parse(Console.ReadLine());
                    vet = new int[n];
                    Console.WriteLine("");

                    for (int i = 0; i < n; i++ ){
                        Console.Write("Digite o número da posição "+ i + ": ");
                        vet[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("");
                    for (int i = 0; i < n; i++ ){
                        Console.WriteLine("O número da posição "+ i + " é: "+ vet[i]);
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Clique 'enter' para voltar ao menu.");
                    Console.ReadLine();

                }

                else if (resp == 5){

                    Triangulo X, Y;
                    double p, areaX, areaY;

                    X = new Triangulo();
                    Y = new Triangulo();

                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("Trabalhando com classes");
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("Entre com as medidas do triângulo X");
                    Console.Write("Primeira medida: ");
                    X.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Segunda medida: ");
                    X.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Terceira medida: ");
                    X.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("");

                    Console.WriteLine("Entre com as medidas do triângulo Y");
                    Console.Write("Primeira medida: ");
                    Y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Segunda medida: ");
                    Y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Terceira medida: ");
                    Y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("");

                    areaX = X.Area();
                    areaY = Y.Area();

                    Console.WriteLine("A área do triângulo X é: "+ areaX.ToString("f4", CultureInfo.InvariantCulture));
                    Console.WriteLine("A área do triângulo Y é: "+ areaY.ToString("f4", CultureInfo.InvariantCulture));

                    if (areaX > areaX){
                        Console.WriteLine("O triângulo com a maior área é: Triângulo X");
                    }

                    else{
                        Console.WriteLine("O triângulo com a maior área é: Triângulo Y");
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Clique 'enter' para voltar ao menu.");
                    Console.ReadLine();

                }

                else if (resp == 6){

                    int qtd, id;

                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("Trabalhando com classes, construtores e encapsulamento");
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("Entre com os dados do produto: ");
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Preço: ");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Quantidade em estoque: ");
                    int qtdEstoque = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Produto produto = new Produto(nome, preco, qtdEstoque);
                    
                    Console.WriteLine("Dados do produto: " + produto);
                    Console.WriteLine("Referência do produto: " + produto.ReferenciaProduto);
                    Console.WriteLine("ID do produto: " + produto.IdProduto);
                    Console.WriteLine("");

                    Console.Write("Digite a quantidade a ser adicionada no estoque: ");
                    qtd = int.Parse(Console.ReadLine());
                    produto.AdicionarProdutos(qtd);
                    Console.Write("Digite a nova referência do produto: ");
                    produto.ReferenciaProduto = int.Parse(Console.ReadLine());
                    Console.WriteLine("Dados do produto atualizados: " + produto);
                    Console.WriteLine("A nova referência é: " + produto.ReferenciaProduto);
                    Console.WriteLine("");

                    Console.Write("Digite a quantidade a ser retirada do estoque: ");
                    qtd = int.Parse(Console.ReadLine());
                    produto.RetirarProdutos(qtd);
                    Console.Write("Digite a nova referência do produto: ");
                    produto.ReferenciaProduto = int.Parse(Console.ReadLine());
                    Console.WriteLine("Dados do produto atualizados: " + produto);
                    Console.WriteLine("A nova refrência é: " + produto.ReferenciaProduto);
                    Console.WriteLine("");

                    Console.WriteLine("");
                    Console.WriteLine("Clique 'enter' para voltar ao menu.");
                    Console.ReadLine();
                    

                }

                else if (resp == 7){

                    double raio, circ, volume;

                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("Trabalhando com métodos estáticos");
                    Console.WriteLine("-------------------------------------------------------");
                    Console.Write("Entre com o valor do raio: ");
                    raio = double.Parse(Console.ReadLine());
                    Console.Write("");

                    circ = Calculadora.Circuferenia(raio);
                    volume = Calculadora.Volume(raio);

                    Console.WriteLine("Circuferenia: "+ circ.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("Volume: "+ volume.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("Valor de PI: "+ Calculadora.pi.ToString(CultureInfo.InvariantCulture));

                    Console.WriteLine("");
                    Console.WriteLine("Clique 'enter' para voltar ao menu.");
                    Console.ReadLine();

                }

                else if (resp == 8){

                    Produto[] vetProduto;
                    double valor, media, soma = 0;
                    int n;
                    string nome;

                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("Trabalhando com vetores e classes");
                    Console.WriteLine("-------------------------------------------------------");
                    Console.Write("Digite quantos produtos vão ser inseridos: ");
                    n = int.Parse(Console.ReadLine());
                    vetProduto = new Produto[n];
                    Console.Write("");

                    for (int i = 0; i < n; i++){
                        Console.Write("Entre com o nome do produto da posição "+ i +": ");
                        nome = Console.ReadLine();
                        Console.Write("Entre com o valor do produto da posição "+ i +": ");
                        valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        vetProduto[i] =  new Produto(nome, valor); 
                        soma += vetProduto[i].Preco;
                    }

                    media = soma / n;

                    for (int i = 0; i < n; i++){
                        Console.WriteLine("");
                        Console.WriteLine("Produto da posição "+ i +": "+ vetProduto[i]);
                    }
                    Console.WriteLine("");
                    Console.WriteLine("A média dos valores é: " + media.ToString("F2", CultureInfo.InvariantCulture));

                    Console.WriteLine("");
                    Console.WriteLine("Clique 'enter' para voltar ao menu.");
                    Console.ReadLine();

                }

                else if (resp == 9){

                    List<string> list = new List<string>();
                    int posicao, numLetras;
                    string nome;
                    char letra;

                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("Trabalhando com listas");
                    Console.WriteLine("-------------------------------------------------------");

                    list.Add("Alexandre");
                    list.Add("Rick");
                    list.Add("Mateus");
                    list.Add("Paulo");
                    list.Insert(2, "Guilherme");

                    foreach(string obj in list){
                        Console.WriteLine("Nome: " + obj);
                    }

                    Console.WriteLine("");
                    Console.Write("Digite a posição em que sera adicionada um novo nome: ");
                    posicao = int.Parse(Console.ReadLine());
                    Console.Write("Digite o novo nome: ");
                    nome = Console.ReadLine();
                    list.Insert(posicao, nome);

                    Console.WriteLine("");
                    Console.WriteLine("Lista atualizada: ");
                    foreach(string obj in list){
                        Console.WriteLine("Nome: " + obj);
                    }

                    Console.WriteLine("");
                    Console.Write("Digite a letra inicial do nome que deseja encontrar (primeiro nome): ");
                    letra = char.Parse(Console.ReadLine());
                    string s1 = list.Find(x => x[0] == letra);
                    Console.Write("Digite a letra inicial do nome que deseja encontrar (último nome): ");
                    letra = char.Parse(Console.ReadLine());
                    string s2 = list.FindLast(x => x[0] == letra);
                    Console.WriteLine("Primeiro nome com a letra inicial "+ letra +": " + s1);
                    Console.WriteLine("Último nome com a letra inicial "+ letra +": " + s2);

                    Console.WriteLine("");
                    Console.Write("Digite a letra inicial do nome que deseja encontrar (posição do primeiro nome): ");
                    letra = char.Parse(Console.ReadLine());
                    int p1 = list.FindIndex(x => x[0] == letra);
                    Console.Write("Digite a letra inicial do nome que deseja encontrar (posição do último nome): ");
                    letra = char.Parse(Console.ReadLine());
                    int p2 = list.FindLastIndex(x => x[0] == letra);
                    Console.WriteLine("A posição do primeiro nome com a letra inicial "+ letra +" é: " + p1);
                    Console.WriteLine("A posição do último nome com a letra inicial "+ letra +" é: " + p2);

                    Console.WriteLine("");
                    Console.Write("Você quer que apareça os nomes com quantas letras? insira a quntidade: ");
                    numLetras = int.Parse(Console.ReadLine());
                    List<string> list2 = list.FindAll(x => x.Length == numLetras);

                    Console.WriteLine("");
                    Console.WriteLine("Lista filtrada: ");
                    foreach(string obj in list2){
                        Console.WriteLine("Nome: " + obj);
                    }

                    Console.WriteLine("");
                    Console.Write("Digite o nome que será removido: ");
                    nome = Console.ReadLine();
                    list.Remove(nome);

                    Console.WriteLine("");
                    Console.Write("Digite a letra inicial dos nome que serão removidos: ");
                    letra = char.Parse(Console.ReadLine());
                    list.RemoveAll(x => x[0] == letra);

                    Console.WriteLine("");
                    Console.WriteLine("Lista atualizada: ");
                    foreach(string obj in list){
                        Console.WriteLine("Nome: " + obj);
                    }

                    Console.WriteLine("");
                    Console.Write("Digite a posição do nome que sera removido: ");
                    posicao = int.Parse(Console.ReadLine());
                    list.RemoveAt(posicao);

                    //A cada 2 posições, remove 2 elementos.
                    //list.RemoveRange(2,2);

                    Console.WriteLine("");
                    Console.WriteLine("Lista atualizada: ");
                    foreach(string obj in list){
                        Console.WriteLine("Nome: " + obj);
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Clique 'enter' para voltar ao menu.");
                    Console.ReadLine();

                }

                else if (resp == 10){

                    double [,] matriz;
                    int linhas, colunas, count = 0, n;
                    char op;

                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("Trabalhando com matrizes");
                    Console.WriteLine("-------------------------------------------------------");
                    Console.Write("Digite a quantidade de linhas da matriz: ");
                    linhas = int.Parse(Console.ReadLine());
                    Console.Write("Digite a quantidade de colunas da matriz: ");
                    colunas = int.Parse(Console.ReadLine());
                    matriz = new double[linhas, colunas];
                    Console.WriteLine("");

                    for(int i = 0; i < linhas; i++){
                        for(int j = 0; j < colunas; j++){

                            Console.Write("Digite um número para a linha "+ i +", coluna " + j + " da matriz: ");
                            matriz[i,j] = int.Parse(Console.ReadLine());

                        }
                        Console.WriteLine("");
                    }

                    for(int i = 0; i < linhas; i++){
                        Console.Write("Linha "+ i +": ");
                        for(int j = 0; j < colunas; j++){
                            
                            Console.Write(""+ matriz[i,j] + " | ");

                        }
                        Console.WriteLine("");
                    }
                    Console.Write("Coluna   ");
                        while(count < colunas){
                        Console.Write(""+ count +" | ");
                        count++;
                    }
                    Console.WriteLine("");
                    Console.WriteLine("");
                    
                    Console.WriteLine("A quantidade de itens da matriz é: "+ matriz.Length);
                    Console.WriteLine("");
                    Console.WriteLine("A primeira dimensão da matriz (quantidade de linhas) é: "+ matriz.Rank);
                    Console.WriteLine("");
                    Console.WriteLine("A primeira dimensão da matriz (dimensão 0, quantidade de linhas) é: "+ matriz.GetLength(0));
                    Console.WriteLine("");
                    Console.WriteLine("A segunda dimensão da matriz (dimensão 1, quantidade de colunas) é: "+ matriz.GetLength(1));
                    Console.WriteLine("");

                    Console.Write("Deseja ver o exemplo dois? (S/N): ");
                    op = char.Parse(Console.ReadLine());
                    if(op == 'S' || op == 's'){

                        double[,] matriz2;
                        string[] vet;
                        count = 0;

                        Console.WriteLine("");
                        Console.Write("Digite quantas linhas e colunas tera a matriz quadrada: ");
                        n = int.Parse(Console.ReadLine());
                        matriz2 = new double[n,n];
                        Console.WriteLine("");

                        for(int i = 0; i < n; i++){

                            Console.Write("Digite um número para a linha "+ i +" da matriz: ");
                            vet = Console.ReadLine().Split(' ');

                            for(int j = 0; j < n; j++){

                                matriz2[i,j] = int.Parse(vet[j]);

                            }
                            Console.WriteLine("");
                        }

                        for(int i = 0; i < n; i++){
                            Console.Write("Linha "+ i +": ");
                            for(int j = 0; j < n; j++){
                                        
                                Console.Write(""+ matriz2[i,j] + " | ");

                            }
                            Console.WriteLine("");
                        }
                        Console.Write("Coluna   ");
                        while(count < n){
                            Console.Write(""+ count +" | ");
                            count++;
                        }

                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.Write("Diagonal principal: ");
                        for(int i = 0; i < n; i++){

                            Console.Write(matriz2[i,i] + " ");

                        }

                        count = 0;
                        for(int i = 0; i < n; i++){
                            for(int j = 0; j < n; j++){
                                        
                                if(matriz2[i,j] < 0){
                                    count++;
                                }

                            }
                        }

                        Console.WriteLine("");
                        Console.Write("A matriz tem "+ count +" números negativos");
                        Console.WriteLine("");
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Clique 'enter' para voltar ao menu.");
                    Console.ReadLine();

                }

                else if(resp == 12){
                    break;
                }

            }
        }

        //Função
        static double Promocao(double x){

            double val, porcentagem;
            
            porcentagem = x * 0.2;
            val = x - porcentagem;

            return val;

        }

    }

}