using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

[ServiceContract]
public interface FirmInterfaceService
{
    [OperationContract(), WebGet(UriTemplate ="/Clients", RequestFormat = WebMessageFormat.Json, ResponseFormat =WebMessageFormat.Json)]
    List<ClientsData> GetClients();
    [OperationContract()]
    [WebInvoke(Method = "POST", UriTemplate ="NewClient", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare )]
    int NewClient(ClientsData client);
}

[DataContract]
public class ClientsData
{
    [DataMember]
    public int Id { get; set; }
    [DataMember]
    public string FullName { get; set; }
    [DataMember]
    public string FirstName { get; set; }
    [DataMember]
    public string LastName { get; set; }
    [DataMember]
    public int ClientTypeId { get; set; }
    [DataMember]
    public string ClientType { get; set; }
    [DataMember]
    public string Email { get; set; }
    [DataMember]
    public string PhoneNumber { get; set; }
    [DataMember]
    public string MobileNumber { get; set; }
    [DataMember]
    public DateTime? BirthDate { get; set; }
    [DataMember]
    public int LawyerId { get; set; }
    [DataMember]
    public string LawyerName { get; set; }
    [DataMember]
    public DateTime CreatedDate { get; set; }
    [DataMember]
    public DateTime? ModifyDate { get; set; }
}