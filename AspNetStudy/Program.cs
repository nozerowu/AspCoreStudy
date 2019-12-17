using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AspNetStudy
{
    /// <summary>
    /// EF6.0 
    /// 1.EFCore3.0 ���ַ�ʽӦ��
    /// 2.EF ����EFcore������ݲ�ѯ
    /// 3.�ֲ��װ autofac �����������,����
    /// EF6 4��ģʽ 
    /// CodeFirst 
    /// DbFirst 
    /// ModelFirst
    /// CodeFirst from DB
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
