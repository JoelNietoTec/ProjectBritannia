using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ProjectModels;
using ProjectModels.Models;
using System.Data.Entity;
using System.Data.EntityClient;

public class FirmService : FirmInterfaceService
{
	public List<ClientsData> GetClients() 
    {
        FirmDBEntities ContextDB;

        using(ContextDB = new FirmDBEntities())
        {
            List<ClientsData> myClients = new List<ClientsData>();

            foreach(var c in ContextDB.Clients)
            {
                ClientsData cData = new ClientsData();
                cData.Id = c.Id;
                cData.FullName = c.FullName;
                cData.FirstName = c.FirstName;
                cData.LastName = c.LastName;
                cData.ClientTypeId = c.ClientTypeId;
                cData.ClientType = c.ClientType.Name;
                cData.Email = c.Email;
                cData.PhoneNumber = c.PhoneNumber;
                cData.MobileNumber = c.MobileNumber;
                cData.BirthDate = c.BirthDate;
                cData.LawyerId = c.LawyerId;
                cData.LawyerName = c.Lawyer.Name;
                cData.CreatedDate = c.CreatedDate;
                cData.ModifyDate = c.ModifyDate;
                myClients.Add(cData);
            }
            return myClients;
        }
    }

    public int NewClient(ClientsData client)
    {
        FirmDBEntities ContextDB;
        using(ContextDB = new FirmDBEntities())
        {
            Client cli = new Client
            {
                FullName = client.FullName,
                FirstName = client.FirstName,
                LastName = client.LastName,
                ClientTypeId = client.ClientTypeId,
                Email = client.Email,
                PhoneNumber = client.PhoneNumber,
                MobileNumber = client.MobileNumber,
                BirthDate = client.BirthDate,
                LawyerId = client.LawyerId,
                CreatedDate = DateTime.Today,
                ModifyDate = null
            };
            try
            {
                ContextDB.Clients.Add(cli);
                ContextDB.SaveChanges();
            } catch
            {
                return 0;
            }
            return cli.Id;
        }
    }

	
}
