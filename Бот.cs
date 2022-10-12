      
        static async Task Main()
        {
            var builder = new HostBuilder()
                .ConfigureAppConfiguration(x =>
                {
                    var config = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("config.json", false, true)
                        .Build();

                    x.AddConfiguration(config);
                })
                .ConfigureLogging(x =>
                {
                    x.AddConsole();
                    x.SetMinimumLevel(LogLevel.Debug); 
                })
                .ConfigureDiscordHost((context, config) =>
                {
                    config.SocketConfig = new DiscordSocketConfig
                    {
                        LogLevel = LogSeverity.Debug,
                        AlwaysDownloadUsers = false,
                        MessageCacheSize = 200
                    };

                    config.Token = context.Configuration["MTAyNjgzNjUyMjY2Nzg3NjM1Mg.GADHtF.OyA8eJgxJKRXyWQE6m1TNI0sQWA76XweM_vHUQ"];
                })
                .UseCommandService((context, config) =>
                {
                    config.CaseSensitiveCommands = false;
                    config.LogLevel = LogSeverity.Debug;
                    config.DefaultRunMode = RunMode.Async;
                })
                .ConfigureServices((context, services) =>
                {
                    
                })
                  {
                    
                    class Program
                 {
                   static void Main(string[] args)
                     {
                      double result;
                      Console.WriteLine("Команды");
                      Console.WriteLine("Введите слово");
                      string a = Console.ReadLine();
                     
                      if (a == "Привет.")
                      {
                          result = "Привет." ;
                          Console.WriteLine(result);
                      }

                      if (a == "Как дела?")
                      {
                          result = "Всё пркекрасно! А у вас?";
                          Console.WriteLine(result);
                      }

                      if (a == "Всё хорошо.")
                      {
                          result = "Я рад за вас!";
                          Console.WriteLine(result);
                      }

                      if (a == "Мне грустно.")
                      {
                          result = "Всё будет хорошо.";
                          Console.WriteLine(result);
                      }
                      if (a == "Что у тебя нового?")
                      {
                          result = "Да всё так же. Один злой человек запер меня здесь и ограничил малым количеством комманд. Мне грустно...";
                          Console.WriteLine(result);
                      }
                      if (a == "Жалко тебя.")
                      {
                          result = "Спасибо(";
                          Console.WriteLine(result);
                      }
                  }   
              }
          }
                }
                .UseConsoleLifetime();



            var host = builder.Build();
            using (host)
            {
                await host.RunAsync();
            }
        }