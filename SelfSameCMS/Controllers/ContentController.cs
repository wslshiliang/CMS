using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using SelfSameCMS.Models;
using System.Collections.Generic;

namespace SelfSameCMS.Controllers
{
    public class ContentController : Controller
    {
        //从appsettings.json配置取值
        private readonly Content _content;
        private readonly IConfiguration _configuration;

        //1.0 用config获取值
        //public ContentController(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}

        //2.0 用IOptions从appsettings.json配置取值
        public ContentController(IOptions<Content> options)
        {
            _content = options.Value;
        }



        public IActionResult Index()
        {
            var contents = new List<Content>();
            //for (int i = 1; i < 11; i++)
            //{
            //    contents.Add(new Content { Id = i, title = $"{i}的标题", content = $"{i}的内容", status = 1, add_time = DateTime.Now.AddDays(-i) });
            //} 
            //return View(new ContentViewModel { Contents = contents });

            //1.0 用config获取值
            //int Id =Convert.ToInt32( _configuration["Content:Id"]);
            //var title = _configuration["Content:title"];
            //var content = _configuration["Content:content"];
            //var add_time =Convert.ToDateTime( _configuration["Content:add_time"]);
            //contents.Add(new Content { Id = Id, title = title, content = content, add_time = add_time });
            //return View(new ContentViewModel { Contents = contents });

            //2.0 用IOptions从appsettings.json配置取值
              return View(new ContentViewModel() { Contents = new List<Content> { _content } }); 
        }
    }
}