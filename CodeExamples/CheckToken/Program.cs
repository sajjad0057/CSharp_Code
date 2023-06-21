
// See https://aka.ms/new-console-template for more information
using System.IdentityModel.Tokens.Jwt;

Console.WriteLine("Hello, World!");

var token = "Y1RPelpTSmNfSkZNYWhEcmpfRGdlV2xDRW85ZVdaYWFWSElkUHJ4TEgxN2dzOjE2ODczMzU3MDMxMDA6MTowOmF0OjE";

var jwtToken = new JwtSecurityToken(token);

Console.WriteLine();