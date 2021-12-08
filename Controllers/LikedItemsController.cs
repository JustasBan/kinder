using kinder_app.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kinder_app.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class LikedItemsController : Controller
    {
        public static List<LikedItemGetDTO> database = new();

        [HttpGet]
        public async Task<ActionResult> GetLikedItems()
        {
            var LikedItem1 = new LikedItemGetDTO
            {
                ID = 1,
                UserID = 1
            };
            var LikedItem2 = new LikedItemGetDTO
            {
                ID = 2,
                UserID = 1
            };
            var LikedItem3 = new LikedItemGetDTO
            {
                ID = 3,
                UserID = 2
            };
            var LikedItem4 = new LikedItemGetDTO
            {
                ID = 4,
                UserID = 3
            };

            var LikedItemList = new List<LikedItemGetDTO>();
            LikedItemList.Add(LikedItem1);
            LikedItemList.Add(LikedItem2);
            LikedItemList.Add(LikedItem3);
            LikedItemList.Add(LikedItem4);

            return Ok(new GetListDTO<LikedItemGetDTO>(LikedItemList));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetLikedItem(int id)
        {
            var item = database.FirstOrDefault(li => li.ID == id);

            return Ok(item);
        }

        [HttpPost]
        public async Task<ActionResult> UploadData([FromBody] LikedItemGetDTO item)
        {
            database.Add(item);

            return StatusCode(201);
        }
    }
}
