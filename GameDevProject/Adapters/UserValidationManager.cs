using GameDevProject.Abstract;
using GameDevProject.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDevProject.Adapters
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == new DateTime(1988) && gamer.FirstName == "ETHEM ANIL" && gamer.LastName == "SANDALCI" && gamer.IdentityNumber == 12345)
            {
                return true;
            }
            else
            {
                return false;
            }

            //KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            //return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(gamer.IdentityNumber), gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(),
            //gamer.BirthYear.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
