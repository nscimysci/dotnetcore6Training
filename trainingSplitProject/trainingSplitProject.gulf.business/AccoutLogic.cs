
using System;
using System.Collections.Generic;
// using training.gulf.services.Interfaces;
// using trainingSplitProject.gulf.model;
// using training.gulf.services.entities;


using System.IdentityModel.Tokens.Jwt;
// using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using trainingSplitProject.gulf.business.core;

namespace trainingSplitProject.gulf.business
{
    public class AccoutLogic : IAccoutLogic
    {
        // private readonly AZUREDBEBIDDINGDEVContext _context;

        // public AccoutLogic(AZUREDBEBIDDINGDEVContext context)
        // {
        //     _context = context;
        // }

        // public async Task<LoginRes> Authentication(LoginModel model)
        // {
        //     // Check User & Password not null
        //     if (string.IsNullOrEmpty(model.UserName) || string.IsNullOrEmpty(model.Password))
        //     {
        //         throw new Exception("Enter a valid username");
        //     }

        //     var account = new LoginRes
        //     {
        //         UserName = model.UserName,
        //         Token = GenerateJWTToken(model)
        //     };

        //     return account;
        // }

        // private string GenerateJWTToken(LoginModel loginReq)
        // {
        //     var tokenHandler = new JwtSecurityTokenHandler();
        //     var key = Encoding.UTF8.GetBytes("this is my Secret Key");
        //     var tokenDescriptor = new SecurityTokenDescriptor
        //     {
        //         Subject = new ClaimsIdentity(new Claim[]
        //         {
        //             new Claim(ClaimTypes.Name, loginReq.UserName),
        //             new Claim(ClaimTypes.NameIdentifier, loginReq.UserName),
        //             new Claim(ClaimTypes.PrimarySid, "1")
        //         }),
        //         Expires = DateTime.UtcNow.AddMinutes(1440),
        //         SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)
        //     };
        //     var token = tokenHandler.CreateToken(tokenDescriptor);

        //     return tokenHandler.WriteToken(token);
        // }

    }
}