﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SamuraiApp.API.DTO;
using SamuraiApp.Domain;
using SamuraiAPP.Data.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SamuraiApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SamuraisController : ControllerBase
    {
        private readonly ISamurai _samurais;
        private readonly IMapper _mapper;

        public SamuraisController(ISamurai samurais, IMapper mapper)
        {
            _samurais = samurais;
            _mapper = mapper;
        }
        // GET: api/<SamuraisController>
        [HttpGet]
        public async Task<IEnumerable<SamuraiDTO>> Get()
        {
            /*List<SamuraiDTO> samuraiDTOs = new List<SamuraiDTO>();  
            var results = await _samurais.GetAll();
            foreach(var result in results)
            {
                samuraiDTOs.Add(new SamuraiDTO
                {
                    Id = result.Id,
                    Name = result.Name,
                });
            }*/
            var results = await _samurais.GetAll();
            var output = _mapper.Map<IEnumerable<SamuraiDTO>>(results);
            
            return output;
        }

        // GET api/<SamuraisController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SamuraiDTO>> GetById(int id)
        {
            var result = await _samurais.GetById(id);
            if(result == null)
                return NotFound();
           return Ok(_mapper.Map<SamuraiDTO>(result));
        }

        // POST api/<SamuraisController>
        [HttpPost]
        public async Task<ActionResult> Post(SamuraiCreateDTO samuraiCreateDTO)
        {
            try
            {
                var newSamurai = _mapper.Map<Samurai>(samuraiCreateDTO);    
                var result = await _samurais.Insert(newSamurai);
                var samuraiDto = _mapper.Map<SamuraiDTO>(result);   
                return CreatedAtAction("GetById", new { id = result.Id }, samuraiDto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<SamuraisController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<SamuraiDTO>> Put(int id, SamuraiCreateDTO samuraiCreateDTO)
        {
            try
            {
                var updateSamurai = _mapper.Map<Samurai>(samuraiCreateDTO);  
                var result = await _samurais.Update(id, updateSamurai);
              // var samuraiDTO = _mapper.Map<SamuraiDTO>(result);
                return Ok(result);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<SamuraisController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _samurais.Delete(id);
                return Ok($"Record {id} deleted");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
