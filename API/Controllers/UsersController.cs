using API.Data;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[Authorize]
public class UsersController : BaseApiController
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;
    public UsersController(IUserRepository userRepository, IMapper  mapper)
    {
        _mapper = mapper;
        _userRepository = userRepository;
    }

    //[AllowAnonymous] //questo vuol dire che non ha bisogno di autenticazione\token
    [HttpGet]
    public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
    {
        // var users = await _userRepository.GetUsersAsync();
        // var usersToReturn = _mapper.Map<IEnumerable<MemberDto>>(users);
        // return Ok(usersToReturn);
        return Ok(await _userRepository.GetMembersAsync()); 
    }

    // [Authorize] //aggiugendo questo attributo un utente portà fare questa chiamata solo se trasmette as serve API un token di autenticazione
    [HttpGet("{username}")] 
    public async Task<ActionResult<MemberDto>> GetUser(string username)
    {
        // var user = await _userRepository.GetUserByUsernameAsync(username);
        // return _mapper.Map<MemberDto>(user);
        return await _userRepository.GetMemberAsync(username);
    }
}

