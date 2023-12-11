using System;
using System.Globalization;
using System.Linq;
using RevisaoIntermediaria.Entities;
using RevisaoIntermediaria.Entities.Enums;
using RevisaoIntermediaria.Entities.Exceptions;
using RevisaoIntermediaria.Service;

namespace RevisaoIntermediaria {
    class Program{

        static void Main(string[] args){

            int resp;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("=============================================");
                Console.WriteLine("REVISÃO INTERMEDIÁRIA");
                Console.WriteLine("=============================================");

                Console.WriteLine("Opções: ");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("1 - Enumeração");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("2 - Herença");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("3 - Classes/Métodos Abstratos");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("4 - Tratamento de exceções");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("5 - Trabalhando com arquivos");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("6 - Interfaces");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("7 - Generics");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("8 - GetHashCode, Equals e HashSet");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("9 - Trabalhando com LINQ, Expressão Lambda e Delegates");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("10 - Sair");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine();
                Console.Write("Digite a opção escolhida: ");
                resp = int.Parse(Console.ReadLine());

                switch(resp){
                    case 1:
                        Enumeracao();
                    break;
                    case 2:
                        Herenca();
                    break;
                    case 3:
                        Abstracao();
                    break;
                    case 4:
                        Excecao();
                    break;
                    case 5:
                        Arquivos();
                    break;
                    case 6:
                        Interfaces();
                    break;
                    case 7:
                        Generics();
                    break;
                    case 8:
                        GetHashCode();
                    break;
                    case 9:
                        LINQ();
                    break;
                }

            } while (resp != 10);
            Console.Clear();
        }

        static void Enumeracao(){

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Enumeração");
            Console.WriteLine("-------------------------------------------------------");

            Order order = new Order{Id = 1020, Moment = DateTime.Now, Status = OrderStatus.PendingPayment};

            Console.WriteLine("");
            Console.WriteLine(order);
            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); 

            Console.WriteLine("");
            Console.WriteLine(txt);
            Console.WriteLine(os);

            Console.WriteLine("");
            Console.WriteLine("Clique enter para voltar ao menu");
            Console.ReadLine();
        }

        static void Herenca(){

            int op = 0, number;
            string holder;
            double balance, loanLimit, value, interest;
            Account account;
            BusinessAccount businessAccount;
            SavingsAccount savingsAccount;

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Herença");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine();
            
            Console.Write("Digite qual tipo de conta você deseja cadastrar (1 - Conta Normal/2 - Conta Empresarial/3 - Conta Poupança): ");
            op = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Digte o número da conta: ");
            number = int.Parse(Console.ReadLine());
            Console.Write("Digte o nome do titular da conta: ");
            holder = Console.ReadLine();
            Console.Write("Digte o saldo inicial da conta: ");
            balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            if(op == 1){

                account = new Account(number, holder, balance);
                
                do
                {

                    Console.WriteLine("0 - Sair ");
                    Console.WriteLine("1 - Adicionar saldo");
                    Console.WriteLine("2 - Remover saldo (-$5 da taxa)");
                    Console.Write("Digite a opção escolhida: ");
                    op = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if(op == 1){
                        Console.Write("Digite o valor a ser adicionado: ");
                        value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        account.Deposit(value);
                    }
                    else if(op == 2){
                        Console.Write("Digite o valor a ser removido: ");
                        value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        account.Withdraw(value);
                    }

                    Console.WriteLine(account);
                    Console.WriteLine();

                } while (op != 0);

            }
            else if(op == 2){

                Console.Write("Digte o limite de empréstimo inicial: ");
                loanLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                businessAccount = new BusinessAccount(number, holder, balance, loanLimit);
                Console.WriteLine();

                do
                {
                    Console.WriteLine("0 - Sair ");
                    Console.WriteLine("1 - Adicionar saldo");
                    Console.WriteLine("2 - Remover saldo (-$8 da taxa)");
                    Console.WriteLine("3 - Pegar empréstimo");
                    Console.Write("Digite a opção escolhida: ");
                    op = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if(op == 1){
                        Console.Write("Digite o valor a ser adicionado: ");
                        value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        businessAccount.Deposit(value);
                    }
                    else if(op == 2){
                        Console.Write("Digite o valor a ser removido: ");
                        value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        businessAccount.Withdraw(value);
                    }
                    else if(op == 3){
                        Console.Write("Digite o valor que deseja pegar: ");
                        value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        businessAccount.Loan(value);
                    }

                    Console.WriteLine(businessAccount);
                    Console.WriteLine();

                } while (op != 0);

            }

            else if(op == 3){

                Console.Write("Digte o valor do juros (ex: 0.10): ");
                interest = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                savingsAccount = new SavingsAccount(number, holder, balance, interest);
                Console.WriteLine();

                do
                {
                    Console.WriteLine("0 - Sair ");
                    Console.WriteLine("1 - Adicionar saldo");
                    Console.WriteLine("2 - Remover saldo");
                    Console.WriteLine("3 - Atualizar/Verificar o valor da poupança");
                    Console.Write("Digite a opção escolhida: ");
                    op = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if(op == 1){
                        Console.Write("Digite o valor a ser adicionado: ");
                        value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        savingsAccount.Deposit(value);
                    }
                    else if(op == 2){
                        Console.Write("Digite o valor a ser removido: ");
                        value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        savingsAccount.Withdraw(value);
                    }
                    else if(op == 3){
                        savingsAccount.UpdateBalance();
                        Console.WriteLine("Valor da poupança: "+savingsAccount.Balance.ToString("F2", CultureInfo.InvariantCulture));
                    }

                    Console.WriteLine(savingsAccount);
                    Console.WriteLine();

                } while (op != 0);

            }

            else{

                Console.WriteLine();
                Console.WriteLine("Opção inválida!");
            }

            Console.WriteLine("");
            Console.WriteLine("Clique enter para voltar ao menu");
            Console.ReadLine();

        }

        static void Abstracao(){

            int n;
            char op;
            double width, height, radius;
            Color color;
            List<Shapes> shapes = new List<Shapes>();

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Classes/Métodos Abstratos");
            Console.WriteLine("-------------------------------------------------------");

            Console.Write("Digite quantos formas serão digitadas: ");
            n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++){

                Console.WriteLine("Forma "+i+": ");
                Console.Write("É um retângulo ou círculo? (R/C)");
                op = char.Parse(Console.ReadLine());
                Console.Write("Digite a cor (Black/Blue/Red): ");
                color = Enum.Parse<Color>(Console.ReadLine()); 

                if(op == 'R' || op == 'r'){
                    
                    Console.Write("Digite a largura: ");
                    width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Digite a altura: ");
                    height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Rectangle(color, width, height));

                }

                if(op == 'C' || op == 'c'){

                    Console.Write("Digite o raio: ");
                    radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(color, radius));

                }

            }

            foreach (Shapes shape in shapes)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine(shape);
            }
            Console.WriteLine("------------------------");

            Console.WriteLine("");
            Console.WriteLine("Clique enter para voltar ao menu");
            Console.ReadLine();

        }

        static void Excecao(){

            int roomNumber;
            DateTime checkIn, checkOut, now = DateTime.Now;
            Reservation reservation;

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Exceção");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine();

            try{
                Console.WriteLine("----------Cadastrando os dados para a reserva do hotel----------");
                Console.Write("Digite o número do quarto: ");
                roomNumber = int.Parse(Console.ReadLine());
                Console.Write("Digite a data de checkIn: ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Digite a data de checkOut: ");
                checkOut = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine();

                reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine(reservation);
                Console.WriteLine();
                
                Console.WriteLine("----------Atualizando a reserva---------------------------------");
                Console.Write("Digite a data de checkIn: ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Digite a data de checkOut: ");
                checkOut = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine();

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine(reservation);
                Console.WriteLine();

            }
            catch(DomainException e){

                Console.WriteLine("Erro: "+e.Message);
                Console.WriteLine();

            }
            catch(FormatException e){
                Console.WriteLine();
                Console.WriteLine("Format error: "+e.Message);
                Console.WriteLine();
            }
            catch(Exception e){
                Console.WriteLine();
                Console.WriteLine("Erro inesperado: "+e.Message);
                Console.WriteLine();
            }

        }

        static void Arquivos(){

            string arqName;
            int op = 0;

            do
            {
                string path = @"C:\Users\alexa\Desktop\Cursos e derivados\Udemy\Curso - C# Completo POO\RevisaoIntermediaria\";
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("Trabalhando com arquivos");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine();

                Console.WriteLine("------------------------OPÇÕES------------------------");
                Console.WriteLine("1 - Ler arquivo");
                Console.WriteLine("2 - Acrescentar no arquivo");
                Console.WriteLine("3 - Criar novo arquivo");
                Console.WriteLine("4 - Deletar arquivo");
                Console.WriteLine("5 - Criar uma pasta");
                Console.WriteLine("6 - Listar todas as pastas dentro de outra pasta");
                Console.WriteLine("7 - Listar todos os arquivos dentro de uma pasta");
                Console.WriteLine("8 - Sair");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine();
                Console.Write("Digite a opção escolhida: ");
                op = int.Parse(Console.ReadLine());

                switch(op){

                    case 1:
                        Console.Clear();
                        Console.Write("Digite o nome do arquivo que deseja ler com o seu tipo (ex: 'Arquivo 1.txt'): ");
                        arqName = Console.ReadLine();
                        path += arqName;
                        Console.WriteLine();
                        
                        try{
                            Console.WriteLine("Conteúdo do arquivo: ");
                            using(StreamReader sr = File.OpenText(path)){
                                while(!sr.EndOfStream){
                                    string line = sr.ReadLine();
                                    Console.WriteLine(line);
                                }
                            }
                        }
                        catch(IOException e){
                            Console.WriteLine("Um erro ocorreu!");
                            Console.WriteLine(e.Message);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Clique 'enter' para continuar!");
                        Console.ReadLine();
                    break;

                    case 2:
                        Console.Clear();
                        Console.Write("Digite o nome do arquivo que deseja editar com o seu tipo (ex: 'Arquivo 1.txt'): ");
                        arqName = Console.ReadLine();
                        path += arqName;
                        Console.WriteLine();

                        try{
                            using(StreamWriter sw = File.AppendText(path)){
                                string text = " ";
                                Console.Write("Digite o texto que deseja acrescentar ao final do arquivo: ");
                                text += Console.ReadLine();
                                sw.WriteLine(text);
                            }

                            Console.WriteLine("Conteúdo novo do arquivo: ");
                            using(StreamReader sr = File.OpenText(path)){
                                while(!sr.EndOfStream){
                                    string line = sr.ReadLine();
                                    Console.WriteLine(line);
                                }
                            }
                        }
                        catch(IOException e){
                            Console.WriteLine("Um erro ocorreu!");
                            Console.WriteLine(e.Message);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Clique 'enter' para continuar!");
                        Console.ReadLine();
                    break;

                    case 3:

                        Console.Clear();
                        Console.Write("Digite o nome do novo arquivo com seu tipo no final (ex: 'Arquivo Novo.txt'): ");
                        arqName = Console.ReadLine();
                        path += arqName;
                        File.Create(path);
                        Console.WriteLine("Arquivo criado!");
                        Console.WriteLine();
                        Console.WriteLine("Clique 'enter' para continuar!");
                        Console.ReadLine();

                    break;

                    case 4:

                        Console.Clear();
                        Console.Write("Digite o nome do arquivo que sera deletado com seu tipo no final (ex: 'Arquivo Novo.txt'): ");
                        arqName = Console.ReadLine();
                        path += arqName;
                        File.Delete(path);
                        Console.WriteLine("Arquivo deletado!");
                        Console.WriteLine();
                        Console.WriteLine("Clique 'enter' para continuar!");
                        Console.ReadLine();

                    break;

                    case 5:

                        Console.Clear();
                        Console.Write("Digite o nome da pasta que deseja criar com uma barra invertida antes (ex: '"+Path.DirectorySeparatorChar+"Nova pasta'): ");
                        arqName = Console.ReadLine();
                        Directory.CreateDirectory(path + @arqName);
                        Console.WriteLine();
                        
                        try{
                            var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                            Console.WriteLine("Todas as pastas desse diretório ("+Path.GetDirectoryName(path)+"): ");
                            Console.WriteLine();
                            foreach (var folder in folders)
                            {
                                    Console.WriteLine(folder);
                            }
                        }
                        catch(IOException e){
                            Console.WriteLine("Um erro ocorreu!");
                            Console.WriteLine(e.Message);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Clique 'enter' para continuar!");
                        Console.ReadLine();

                    break;

                    case 6:
                        try{
                            var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                            Console.WriteLine("Todas as pastas desse diretório ("+Path.GetDirectoryName(path)+"): ");
                            Console.WriteLine();
                            foreach (var folder in folders)
                            {
                                    Console.WriteLine(folder);
                            }
                        }
                        catch(IOException e){
                            Console.WriteLine("Um erro ocorreu!");
                            Console.WriteLine(e.Message);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Clique 'enter' para continuar!");
                        Console.ReadLine();
                    break;

                    case 7:
                        try{
                            var folders = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                            Console.WriteLine("Todas os arquivos desse diretório ("+Path.GetDirectoryName(path)+"): ");
                            Console.WriteLine();
                            foreach (var folder in folders)
                            {
                                    Console.WriteLine(folder);
                            }
                        }
                        catch(IOException e){
                            Console.WriteLine("Um erro ocorreu!");
                            Console.WriteLine(e.Message);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Clique 'enter' para continuar!");
                        Console.ReadLine();
                    break;

                }
            } while (op != 8);
        }

        static void Interfaces(){

            string model;
            DateTime start, finish;
            double pricePerHour, pricePerDay;
            Vehicle vehicle;
            CarRental carRental;
            RentalService rentalService;

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Interfaces");
            Console.WriteLine("-------------------------------------------------------");

            Console.WriteLine("Insira os dados do aluguel: ");
            Console.Write("Digite o modelo: ");
            model = Console.ReadLine();
            Console.Write("Digite o momento da coleta (dd/MM/yyyy hh:mm): ");
            start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Digite o momento da devolução (dd/MM/yyyy hh:mm): ");
            finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            vehicle = new Vehicle(model);
            carRental = new CarRental(start, finish, vehicle);
            
            Console.Write("Digite o preço por hora alugada: ");
            pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o preço por dia alugado: ");
            pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            rentalService = new RentalService(pricePerHour, pricePerDay, new BrazilTaxService());
            rentalService.ProcessInvoice(carRental);

            Console.WriteLine();
            Console.WriteLine("FATURA");
            Console.WriteLine(carRental.Invoice);
            Console.WriteLine("");
            Console.WriteLine("Clique enter para voltar ao menu");
            Console.ReadLine();

        }

        static void Generics(){

            int n;
            string name;
            double value;
            List<Product> products = new List<Product>();
            CalculationService calculationService = new CalculationService();

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Generics");
            Console.WriteLine("-------------------------------------------------------");

            Console.Write("Digite quantos produtos serão adicionados na lista: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(int i = 1; i <= n; i++){
                Console.Write($"Digite o nome e preço do produto (separando por vírgula) da posição {i}: ");
                string[] vect = Console.ReadLine().Split(',');
                name = vect[0];
                value = double.Parse(vect[1], CultureInfo.InvariantCulture);
                products.Add(new Product(name, value));
            }

            Console.WriteLine();
            
            Product max = calculationService.Max(products);
            Console.WriteLine("Produto mais caro: " + max);
            Console.WriteLine("");
            Console.WriteLine("Clique enter para voltar ao menu");
            Console.ReadLine();

        }

        static void GetHashCode(){
            
            string path = @"C:\Users\alexa\Desktop\Cursos e derivados\Udemy\Curso - C# Completo POO\RevisaoIntermediaria\In.txt";
            string username;
            DateTime isntante;
            LogRecord logRecord;
            HashSet<LogRecord> logRecords = new HashSet<LogRecord>();

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("GetHashCode, Equals e HashSet");
            Console.WriteLine("-------------------------------------------------------");

            Console.WriteLine("Lendo o arquivo que contem os registros de navegação de usuários");
            
            try{
                using(StreamReader sr = new StreamReader(path)){
                    
                    while(!sr.EndOfStream){
                        string[] line = sr.ReadLine().Split(" ");
                        username = line[0];
                        isntante = DateTime.Parse(line[1]);
                        logRecord = new LogRecord(username, isntante);
                        logRecords.Add(logRecord);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Total de usuários: "+ logRecords.Count);

                }
            }
            catch(Exception e){
                Console.WriteLine("Erro ao ler o arquivo!");
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("");
            Console.WriteLine("Clique enter para voltar ao menu");
            Console.ReadLine();

        }

        static void LINQ(){

            int op;
            string name;
            double price;
            List<Product> products = new List<Product>();
            
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Trabalhando com LINQ, Expressão Lambda e Delegates");
            Console.WriteLine("-------------------------------------------------------");

            do
            {
                string path = @"C:\Users\alexa\Desktop\Cursos e derivados\Udemy\Curso - C# Completo POO\RevisaoIntermediaria\";
                Console.Clear();
                Console.WriteLine("1 - Criar um arquivo e adicionar os produtos!");
                Console.WriteLine("2 - Abrir um arquivo já existentente e realizar as operações!");
                Console.WriteLine("3 - Sair!");
                Console.Write("Escolha uma opção: ");
                op = int.Parse(Console.ReadLine());

                switch (op){

                    case 1:

                        Console.Clear();
                        Console.Write("Digite o nome do novo arquivo com a extensão 'csv' (ex: 'Novo Arquivo.csv'): ");
                        string newFileName = Console.ReadLine();
                        path += newFileName;
                        try{
                            using(StreamWriter sw = new StreamWriter(path)){
                                
                                int n = 0;
                                Console.WriteLine();
                                Console.Write("Digite quantos produtos serão adicionados ao arquivo: ");
                                n = int.Parse(Console.ReadLine());
                                for(int i = 1; i <= n; i++){
                                    Console.Write($"Digite o nome e o preço do novo produto {i}, separando por vírgula (ex: TV, 100.00): ");
                                    string line = Console.ReadLine();
                                    sw.WriteLine(line);
                                }

                            }
                        }
                        catch(IOException e){
                            Console.WriteLine("Ocorreu um erro ao criar o arquivo!");
                            Console.WriteLine(e.Message);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Arquivo criado com sucesso!");
                        Console.WriteLine("Clique enter para voltar ao menu");
                        Console.ReadLine();

                    break;

                    case 2:

                        Console.Clear();
                        try{
                            var folder = Directory.EnumerateFiles(path, "*.csv", SearchOption.AllDirectories);
                            Console.WriteLine("Arquivos 'csv' disponíveis nessa pasta:");
                            Console.WriteLine();
                            foreach(var file in folder){
                                Console.WriteLine(file);
                            }

                            Console.WriteLine();
                            Console.Write("Digite o nome do arquivo que deseja abrir com o seu tipo 'csv' (ex: 'Novo Arquivo.csv'): ");
                            string fileName = Console.ReadLine();
                            path += fileName;

                            using(StreamReader sr = new StreamReader(path)){
                                while(!sr.EndOfStream){
                                    string[] vect = sr.ReadLine().Split(',');
                                    name = vect[0];
                                    price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                                    products.Add(new Product(name, price));
                                }
                            }

                            Console.WriteLine();
                            // MEU JEITO: var avg = products.Average(p => p.Value);
                            var avg = products.Select(p => p.Value).DefaultIfEmpty(0.0).Average(); // Jeito do professor
                            Console.WriteLine("Média dos produtos deste arquivo: "+ avg.ToString("F2", CultureInfo.InvariantCulture));
                            
                            Console.WriteLine();
                            var producsNames = products.Where(p => p.Value < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
                            Console.WriteLine("Produtos com o valor abaixo da média em ordem decrescente: ");
                            foreach (var names in producsNames)
                            {
                                Console.WriteLine(names);
                            }

                        }
                        catch(IOException e){
                            Console.WriteLine("Ocorreu um erro!");
                            Console.WriteLine(e.Message);
                        }

                        Console.WriteLine();
                        Console.WriteLine("Clique enter para voltar ao menu");
                        Console.ReadLine();

                    break;

                }
            } while (op != 3);
                

        }

    }
}