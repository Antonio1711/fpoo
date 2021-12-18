// using System;

// namespace Cs
// {
//     class ex2
//     {
//         static void Main(string[] args)
//         {
//             int numero, aux1,aux2,aux3,aux4,aux5,aux6,aux7;
//             string d1, d2, d3, d4, d5, d6, d7, d8;

//             Console.WriteLine("informe o numero de 1 a 255:");
//             numero = Convert.ToInt32(Console.ReadLine());

//             if(numero > 255)
//             {

//                 Console.WriteLine("Número inválido");
//             }
//             else{

//              if(numero >= 128){
//               aux1 = 128;
//                d1 = "1";
//             }
//              else{
//                  aux1 = 0;
//                  d1 = "0";
//             }
//              if((numero -= aux1) >= 64){ 
//                  aux2 = 64;
//                   d2= "1";
//             }
//             else{
//                  aux2 = 0;
//                   d2 = "0";
//             }
//             if((numero-= aux2)>= 32){
//                  aux3 = 32;
//                  d3 = "1";
//             }
//             else{
//                   aux3 = 0;
//                  d3 = "0";
//             }
//             if((numero-=aux3) >= 16){
//                 aux4 = 16;
//                  d4 = "1";
//             }
//             else{
//                 aux4 = 0;
//                 d4 = "0";
//             }
//             if((numero -= aux4)>= 8){
//                 aux5 = 8;
//                 d5 = "1";
//             }
//             else{
//                 aux5 = 0;
//                 d5 = "0";
//             }
//             if((numero -= aux5) >= 4){
//                 aux6 = 4;
//                 d6 = "1";
//             }
//             else{
//                 aux6 = 0;
//                 d6 = "0";
//             }
//             if((numero -= aux6) >= 2){
//                 aux7 = 2;
//                 d7 = "1";
//             }
//             else{
//                 aux7 = 0;
//                 d7 = "0";
//             }
//             if((numero -= aux7) >= 1){
//                 d8 = "1";
//             }
//             else{
//                 d8 = "0";
//             }

//             Console.WriteLine($"Este número em binário é: {d1 + d2 + d3 + d4 + d5 + d6 +d7 + d8}");

//         }
//         }
//     }
// }