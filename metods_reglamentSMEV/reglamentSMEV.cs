using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

public class reglamentSMEV
{
    public static bool getRequest_file12(string file, List<clsConnections> link_connections, string[] folders, ReglamentLinker reglamentLinker, out string result_comments)
    {
        result_comments = "";
        string processing_comments = "";
        bool result = false;
        try
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(file);
            adapterSmev1_2.AdapterMessage adapterMessage = new adapterSmev1_2.AdapterMessage();
            adapterMessage = HelperXmlSmev.DeserializeFrom<adapterSmev1_2.AdapterMessage>(xmlDocument.DocumentElement);
            // Получаем метаданные 
            adapterSmev1_2.SmevMetadata smevMetadata = adapterMessage.smevMetadata;
            adapterSmev1_2.Message message = adapterMessage.Message;
            if (message != null)
            {
                string value = clsLibrary.string_Apostrophe(smevMetadata.MessageId) + "," +
                    ((smevMetadata.ReferenceMessageID != null) ?
                        clsLibrary.string_Apostrophe(smevMetadata.ReferenceMessageID) :
                        clsLibrary.string_Apostrophe(smevMetadata.MessageId)) + "," +
                    clsLibrary.string_Apostrophe(smevMetadata.TransactionCode);
                //logQueue.Enqueue(new clsLog(DateTime.Now, 1, "Adapter_SMEV", 0, 0, DateTime.Now, DateTime.Now, meta.MessageId + "  GET / " + message.GetType().Name));

                result_comments = message.GetType().Name;
                switch (message.GetType().Name)
                {
                    case "StatusMessage":
                        adapterSmev1_2.RequestMessageType requestMessageType = (adapterSmev1_2.RequestMessageType)message;
                        break;
                    case "ErrorMessage":
                        adapterSmev1_2.ErrorMessage errorMessage = (adapterSmev1_2.ErrorMessage)message;
                        break;
                    case "ResponseMessageType":
                        adapterSmev1_2.ResponseMessageType responseMessage = (adapterSmev1_2.ResponseMessageType)message;
                        break;
                    case "RequestMessageType":
                        adapterSmev1_2.RequestMessageType requestMessage = (adapterSmev1_2.RequestMessageType)message;
                        if (clsLibrary.execQuery_insert(ref link_connections, null, "srz3_00_adapter"
                            , "INSERT INTO SMEV_MESSAGES ([MESSAGEID],[REFERENCEMESSAGEID],[TRANSACTIONCODE]) VALUES "
                            , value)
                            )
                        {
                            result = processing_RequestMessage(ref link_connections, ref folders, smevMetadata.MessageId, requestMessage.RequestContent.content.MessagePrimaryContent, out processing_comments);
                        }
                        break;
                    default: //unknown messageType
                        break;
                }
                if (!result)
                    throw new Exception("...");
                else
                    result_comments += " - handled";
            }
        }
        catch (Exception ss)
        {
            result_comments = " error! in metod " + processing_comments;
        }
        return result;
    }
    public static bool getRequest_file13(string file, List<clsConnections> link_connections, string[] folders, ReglamentLinker reglamentLinker, out string result_comments)
    {
        result_comments = "";
        string processing_comments = "";
        bool result = false;
        try
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(file);
            adapterSmev1_3.AdapterMessage adapterMessage = new adapterSmev1_3.AdapterMessage();
            adapterMessage = HelperXmlSmev.DeserializeFrom<adapterSmev1_3.AdapterMessage>(xmlDocument.DocumentElement);
            // Получаем метаданные 
            adapterSmev1_3.SmevMetadata smevMetadata = adapterMessage.smevMetadata;
            adapterSmev1_3.Message message = adapterMessage.Message;
            if (message != null)
            {
                result_comments = message.GetType().Name;
                switch (message.GetType().Name)
                {
                    case "ResponseMessageType":
                        adapterSmev1_3.ResponseMessageType responseMessage = (adapterSmev1_3.ResponseMessageType)message;
                        result_comments += " : " + message.messageType;
                        switch (message.messageType)
                        {
                            case "StatusMessage":
                                result = clsLibrary.execQuery(ref link_connections, null, "srz3_00_adapter"
                                    , string.Format(@"update [SMEV_MESSAGES] set ACKRESPONSE ='{0}' where RESPONSE.value('(/clientId)[1]', 'varchar(max)') = '{1}'",
                                    HelperXmlSmev.SerializeTo(responseMessage.ResponseContent, false, 2),
                                    responseMessage.ResponseMetadata.replyToClientId)
                                );
                                break;
                            case "ErrorMessage":
                                adapterSmev1_3.ErrorMessage errorMessage = (adapterSmev1_3.ErrorMessage)message;
                                break;
                        }
                        break;
                    case "RequestMessageType":
                        adapterSmev1_3.RequestMessageType requestMessage = (adapterSmev1_3.RequestMessageType)message;
                        string value = clsLibrary.string_Apostrophe(requestMessage.RequestMetadata.clientId) + "," +
                            ((smevMetadata.ReferenceMessageID != null) ? clsLibrary.string_Apostrophe(smevMetadata.ReferenceMessageID) : clsLibrary.string_Apostrophe(smevMetadata.MessageId)) + "," +
                            clsLibrary.string_Apostrophe(smevMetadata.TransactionCode);
                        if (clsLibrary.execQuery_insert(ref link_connections, null, "srz3_00_adapter", "INSERT INTO SMEV_MESSAGES ([MESSAGEID],[REFERENCEMESSAGEID],[TRANSACTIONCODE]) VALUES ", value)
                            )
                        {
                            result = processing_RequestMessage(ref link_connections, ref folders, requestMessage.RequestMetadata.clientId, requestMessage.RequestContent.content.MessagePrimaryContent, out processing_comments, file);
                        }
                        else
                        {
                            processing_comments = " ошибка вставки данных, возможно повторная обработка запроса (messageId)";
                        }
                        break;
                    default: //unknown messageType
                        break;
                }
                if (!result)
                    throw new Exception("...");
                else
                    result_comments += " - обработан";
            }
        }
        catch (Exception ss)
        {
            result_comments = " ошибка! в методе : " + processing_comments;
        }
        return result;
    }
    public static bool processing_RequestMessage(ref List<clsConnections> link_connections, ref string[] folders, string messageId, XmlElement xmlElement, out string comments, string file = "")
    {
        comments = String.Empty;
        bool result = false;
        ReglamentLinker reglamentLinker = new ReglamentLinker();
        try
        {
            reglamentLinker.getLink(ref xmlElement);
            //Указываем тип данных
            switch (reglamentLinker.link.schemaClassRoot.Name) 
            {
                case "VS00648v001_PFR001":
                case "VS01112v001_TABL00":
                case "VS01113v001_TABL00":
                case "VS01285v001_TABL00":
                case "VS01287v001_TABL00":
                case "VS01284v001_TABL00":
                    result = clsLibrary.execQuery(ref link_connections, null, "srz3_00_adapter",String.Format("update SMEV_MESSAGES set TipData = '{0}' where MessageID = '{1}'", reglamentLinker.link.prefixFile, messageId));
                    break;
                default: //unknown schema
                    clsLibrary.execQuery(ref link_connections, null, "srz3_00_adapter",String.Format("update SMEV_MESSAGES set TipData = '{0}' where MessageID = '{1}'", "UNKNONE", messageId));
                    break;
            }
            if(result)
            {
                //Записываем данные в базу
                switch (reglamentLinker.link.schemaClassRoot.Name)
                {
                    case "VS00648v001_PFR001": //Сведения ПФР о СНИЛСе
                                               //processing_VS00648v001_PFR001(messageId, xmlElement, out result);
                                               /*HelperXmlSmev.execQueryUpdate(
                                                        "uid=sa;pwd=Cvbqwe2!;server=server-r;database=srz3_00_adapter;",
                                                        String.Format("update SMEV_MESSAGES set TipData = '{0}' where MessageID = '{1}'", "SNILS", messageId)
                                                   );
                                               result = true;*/
                        break;
                    case "VS01112v001_TABL00": //Прием заявления о выборе СМО в ТФОМС
                                               //processing_VS01112v001_TABL00(messageId, xmlElement, out result);        
                        break;
                    case "VS01113v001_TABL00": //Сведения ТФОМС об оказанных медицинских услугах и их стоимости
                        result = processing_VS01113v001_TABL00(ref link_connections, messageId, xmlElement, out comments);
                        break;
                    case "VS01285v001_TABL00": //Сведения из ЕГР ЗАГС о государственной регистрации смерти
                        result = processing_VS01285v001_TABL00(ref link_connections, messageId, xmlElement, out comments);
                        break;
                    case "VS01287v001_TABL00": //Сведения и ЕГР ЗАГС о государственной регистрации рождения  
                        result = processing_VS01287v001_TABL00(ref link_connections, messageId, xmlElement, out comments);
                        break;
                    case "VS01284v001_TABL00": //Сведения из ЕГР ЗАГС о государственной регистрации перемены имени        
                        result = processing_VS01284v001_TABL00(ref link_connections, messageId, xmlElement, out comments);
                        break;
                }
                if (!result) throw new Exception("Ошибка записи контента в базу");
                else
                {
                    //Для данных ЗАГСА готовим пакеты для ручной загрузки в СРЗ
                    switch (reglamentLinker.link.schemaClassRoot.Name)
                    {
                        case "VS01285v001_TABL00": //Сведения из ЕГР ЗАГС о государственной регистрации смерти
                        case "VS01287v001_TABL00": //Сведения и ЕГР ЗАГС о государственной регистрации рождения                
                        case "VS01284v001_TABL00": //Сведения из ЕГР ЗАГС о государственной регистрации перемены имени
                            try
                            {
                                File.Copy(file, Path.Combine(folders[0], String.Format("{0}-{1}.xml", reglamentLinker.link.prefixFile, messageId)), true);
                            }
                            catch
                            {
                                comments = "Ошибка создания файла по сведениям ЗАГС, для загрузки в СРЗ";
                                result = false;
                            }
                            break;
                    }
                    clsLibrary.execQuery(ref link_connections, null, "srz3_00_adapter",String.Format("update SMEV_MESSAGES set state = 0 where MessageID = '{0}'", messageId));
                }


            }

        }
        catch
        {
            result = false;
        }
        return result;
    }
    private static bool processing_VS01113v001_TABL00(ref List<clsConnections> link_connections, string messageId, XmlElement xmlElement, out string comments)
    /* VS01113v001_TABL00
     * Сведения ТФОМС об оказанных медицинских услугах и их стоимости
     */
    {
        comments = string.Empty;
        string value;
        try
        {
            var inputData = HelperXmlSmev.DeserializeFrom<VS01113v001_TABL00.InputData>(xmlElement);
            if (inputData.InsuredRenderingListRequest == null) throw new System.ArgumentException("неверная схема");
            var data = inputData.InsuredRenderingListRequest;

            string message_admin =
                messageId + " | " +
                data.UnitedPolicyNumber + " | " +
                data.FamilyName + " | " +
                data.DateFrom + " | " +
                data.DateTo;
            clsLibrary.SendMail(
                            "192.168.1.2",
                            "AOFOMS Gateware server-shrk@aofoms.tsl.ru",
                            "A3z4y5",
                            "sa.gate.aofoms@yandex.ru",
                            "Запрос сведений о МП",
                            message_admin);

            string idMessage =
                clsLibrary.execQuery_getString(
                    ref link_connections, null, "srz3_00_adapter"
                    ,String.Format("select id from SMEV_MESSAGES where MessageID = '{0}'", messageId)
                );
            value =
                    clsLibrary.string_Apostrophe(idMessage) + "," +
                    clsLibrary.string_Apostrophe(data.RegionCode) + "," +
                    clsLibrary.string_Apostrophe(data.FamilyName) + "," +
                    clsLibrary.string_Apostrophe(data.FirstName) + "," +
                    clsLibrary.string_Apostrophe(data.Patronymic) + "," +
                    clsLibrary.string_Apostrophe(data.BirthDate) + "," +
                    clsLibrary.string_Apostrophe(data.UnitedPolicyNumber) + "," +
                    clsLibrary.string_Apostrophe(data.DateFrom) + "," +
                    clsLibrary.string_Apostrophe(data.DateTo);
        }
        catch (Exception exception)
        {
            comments = exception.Message;
            return false;
        }
        if (clsLibrary.execQuery_insert(ref link_connections, null, "srz3_00_adapter"
                ,"INSERT INTO KUTFOMS_USLUGI (IDMESSAGE,OKATO,FAM,IM,OT,DR,ENP,DATEFROM,DATETO) VALUES "
                ,value))
        {
            return true;
        }
        else
        {
            comments = "ошибка вставки данных";
            return false;
        }
    }
    private static bool processing_VS01285v001_TABL00(ref List<clsConnections> link_connections, string messageId, XmlElement xmlElement, out string comments)
    /* 
     * Сведения из ЕГР ЗАГС о государственной регистрации смерти 
     */
    {
        comments = string.Empty;
        XmlDocument ИдСведений = new XmlDocument();
        try
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xmlElement.InnerXml);
            var inputData = HelperXmlSmev.DeserializeFrom<adapterSmev1_3_smev_message_exchange_directive.Registry>((XmlElement)xmlElement.FirstChild);
            if (inputData == null) throw new System.ArgumentException("неверная схема");
            XmlElement root = ИдСведений.DocumentElement;
            XmlElement element1 = ИдСведений.CreateElement(string.Empty, "ИдСведений", string.Empty);
            ИдСведений.AppendChild(element1);
            foreach (adapterSmev1_3_smev_message_exchange_directive.RegistryRecord registryRecord in inputData.RegistryRecord)
            {
                var ROGDZPRequest = HelperXmlSmev.DeserializeFrom<VS01285v001_TABL00.FATALZPRequest>(registryRecord.Record.RecordContent.Any);
                XmlElement element2 = ИдСведений.CreateElement(string.Empty, "ИдСвед", string.Empty);
                element1.AppendChild(element2);
                element2.AppendChild(ИдСведений.CreateTextNode(ROGDZPRequest.ИдСвед));
            }
        }
        catch (Exception exception)
        {
            comments = exception.Message;
            return false;
        }
        if (clsLibrary.execQuery(ref link_connections, null, "srz3_00_adapter",
                string.Format("UPDATE SMEV_MESSAGES set request = '{0}' where MessageID = '{1}'", ИдСведений.InnerXml, messageId)))
        {
            return true;
        }
        else
        {
            comments = "ошибка вставки данных";
            return false;
        }
    }
    private static bool processing_VS01287v001_TABL00(ref List<clsConnections> link_connections, string messageId, XmlElement xmlElement, out string comments)
    /* 
     * Сведения и ЕГР ЗАГС о государственной регистрации рождения 
     */
    {
        comments = string.Empty;
        XmlDocument ИдСведений = new XmlDocument();
        try
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xmlElement.InnerXml);
            var inputData = HelperXmlSmev.DeserializeFrom<adapterSmev1_3_smev_message_exchange_directive.Registry>((XmlElement)xmlElement.FirstChild);
            if (inputData == null) throw new System.ArgumentException("неверная схема");
            XmlElement root = ИдСведений.DocumentElement;
            XmlElement element1 = ИдСведений.CreateElement(string.Empty, "ИдСведений", string.Empty);
            ИдСведений.AppendChild(element1);
            foreach (adapterSmev1_3_smev_message_exchange_directive.RegistryRecord registryRecord in inputData.RegistryRecord)
            {
                var ROGDZPRequest = HelperXmlSmev.DeserializeFrom<VS01287v001_TABL00.ROGDZPRequest>(registryRecord.Record.RecordContent.Any);
                XmlElement element2 = ИдСведений.CreateElement(string.Empty, "ИдСвед", string.Empty);
                element1.AppendChild(element2);
                element2.AppendChild(ИдСведений.CreateTextNode(ROGDZPRequest.ИдСвед));
            }
        }
        catch (Exception exception)
        {
            comments = exception.Message;
            return false;
        }
        if (clsLibrary.execQuery(ref link_connections, null, "srz3_00_adapter",
                string.Format("UPDATE SMEV_MESSAGES set request = '{0}' where MessageID = '{1}'", ИдСведений.InnerXml, messageId)))
        {
            return true;
        }
        else
        {
            comments = "ошибка вставки данных";
            return false;
        }
    }
    private static bool processing_VS01284v001_TABL00(ref List<clsConnections> link_connections, string messageId, XmlElement xmlElement, out string comments)
    /* 
     * Сведения из ЕГР ЗАГС о государственной регистрации перемены имени 
     */
    {
        comments = string.Empty;
        XmlDocument ИдСведений = new XmlDocument();
        try
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xmlElement.InnerXml);
            var inputData = HelperXmlSmev.DeserializeFrom<adapterSmev1_3_smev_message_exchange_directive.Registry>((XmlElement)xmlElement.FirstChild);
            if (inputData == null) throw new System.ArgumentException("неверная схема");
            XmlElement root = ИдСведений.DocumentElement;
            XmlElement element1 = ИдСведений.CreateElement(string.Empty, "ИдСведений", string.Empty);
            ИдСведений.AppendChild(element1);
            foreach (adapterSmev1_3_smev_message_exchange_directive.RegistryRecord registryRecord in inputData.RegistryRecord)
            {
                var ROGDZPRequest = HelperXmlSmev.DeserializeFrom<VS01284v001_TABL00.PERNAMEZPRequest>(registryRecord.Record.RecordContent.Any);
                XmlElement element2 = ИдСведений.CreateElement(string.Empty, "ИдСвед", string.Empty);
                element1.AppendChild(element2);
                element2.AppendChild(ИдСведений.CreateTextNode(ROGDZPRequest.ИдСвед));
            }
        }
        catch (Exception exception)
        {
            comments = exception.Message;
            return false;
        }
        if (clsLibrary.execQuery(ref link_connections, null, "srz3_00_adapter",
                string.Format("UPDATE SMEV_MESSAGES set request = '{0}' where MessageID = '{1}'", ИдСведений.InnerXml, messageId)))
        {
            return true;
        }
        else
        {
            comments = "ошибка вставки данных";
            return false;
        }
    }
    //Response USLUGI   
    public static bool sendResponse_USLUGI(string[] request, List<clsConnections> link_connections, string[] folders, out string comments)
    /*
     * Ответ по схеме VS01113v001_TABL00
     */
    {
        bool result = false;
        comments = String.Empty;
        try
        {
            //Получаем данные запроса
            List<string[]> response_content = new List<string[]>();
            // Получение контента

            clsLibrary.ExecQurey_GetListStrings(link_connections, null, "srz3_00_adapter"
                    ,String.Format("select top 1 FAM,IM,OT,convert(varchar(10),DR,120) ,ENP,convert(varchar(10), DATEFROM,120), convert(varchar(10), DATETO,120) from KUTFOMS_USLUGI where idmessage = '{0}'", request[0]),
                ref response_content);

            // Получаем pid
            string PID =
                clsLibrary.execQuery_getString(ref link_connections, null, "srz3_00"
                    ,String.Format("select top 1 id from people where isnull(fam,'') = '{0}' and isnull(im,'') = '{1}' and isnull(ot,'') = '{2}' and dr = '{3}' and ENP = '{4}' order by id desc", response_content[0][0], response_content[0][1], response_content[0][2], response_content[0][3], response_content[0][4])
                );

            if (PID == String.Empty)
            {
                //не найден человек
                throw new System.ArgumentException("не найдено ЗЛ");
            }
            List<string[]> response = new List<string[]>();
            // Получение данных реестров
            if (clsLibrary.ExecQurey_PGR_GetListStrings(ref link_connections, null, "main_db",
                    String.Format(
                        "select request.MessageId, coalesce(ppl.id_pac,'0') id, usl.sumv_usl, to_char(z_sl.date_z_1,'YYYY-MM-DD'), to_char(z_sl.date_z_1,'YYYY-MM-DD'), z_sl.vidpom, z_sl.usl_ok, usl.code_usl, z_sl.lpu " +
                        "from (select '{0}' as MessageId, {1} as pid) request " +
                        "left outer join public.personal_info ppl on ppl.reg_id = request.pid " +
                        "join public.z_sl z_sl on z_sl.id_pac = ppl.id_pac " +
                        "join public.usl usl on usl.z_sl_id = z_sl.idcase where z_sl.date_z_2>='{2}' and z_sl.date_z_2<='{3}' " +
                        "order by date_z_1",
                    request[1], PID, response_content[0][5], response_content[0][6]),
                    ref response, 60000)
                )
            {
                XmlElement xmlElement = null;
                if (response.Count != 0)
                {
                    List<VS01113v001_TABL00.InsuredRenderingInfo> insuredRenderingList = new List<VS01113v001_TABL00.InsuredRenderingInfo>();
                    for (int i = 0; i < response.Count(); i++)
                    {
                        VS01113v001_TABL00.InsuredRenderingInfo respone_data = new VS01113v001_TABL00.InsuredRenderingInfo();
                        respone_data = new VS01113v001_TABL00.InsuredRenderingInfo
                        {
                            MedServicesSum = Convert.ToDecimal(response[i][2]),
                            DateRenderingFrom = response[i][3], //. "2017-06-16",//DateTime. Now.AddDays(-2).Date,
                            DateRenderingTo = response[i][4], //"2017-07-16",//DateTime.Now.AddDays(-2).Date,
                            CareRegimen = HelperXmlSmev.getName_fromLibraies(ref link_connections, "VMPNAME", "libV008", "IDVMP", response[i][5]), //"первичная медико-санитарная помощь",
                            CareType = HelperXmlSmev.getName_fromLibraies(ref link_connections, "UMPNAME", "libV006", "IDUMP", response[i][6]), //"Амбулаторно (в условиях, не предусматривающих круглосуточного медицинского наблюдения и лечения), в том числе на дому при вызове медицинского работника",
                            Name = HelperXmlSmev.getName_fromLibraies(ref link_connections, "name", "libSp_usl", "code", response[i][7]), //"Тра-та-та"
                            ClinicName = HelperXmlSmev.getName_fromLibraies(ref link_connections, "nam_mok", "libMo", "mcod", @response[i][8]), //"Ойля-ля"
                            RegionName = "Амурская область"
                        };
                        insuredRenderingList.Add(respone_data);
                    }
                    xmlElement = (new XmlDocument()
                    {
                        InnerXml = HelperXmlSmev.SerializeTo(
                            new VS01113v001_TABL00.OutputDataType()
                            {
                                InsuredRenderingList = insuredRenderingList.ToArray()
                            })
                    }).DocumentElement;
                } 
                SendResponseMessage_VS01113v001_TABL00(ref folders, xmlElement, request[1], false);
                result = true;
            }
            else // Ошибка получения сведений
            {
                throw new System.ArgumentException("ошибка получения сведений МП " );
            }
            //проставляем дату отправки
        }
        catch (Exception exception)
        {
            comments = exception.Message;
            switch (exception.Message)
            {
                case "не найдено ЗЛ":
                    SendResponseMessage_VS01113v001_TABL00(ref folders, null, request[1], false);
                    result = true;
                    break;
                default:
                    break;
            }
        }
        // Изменяем статус запроса
        //string state;
        /*if (comments == String.Empty || comments == "не найдено ЗЛ")
        {
            state = "99";
            result = true;
        }
        else state = "5";
        clsLibrary.execQuery(ref link_connections, null, "srz3_00_adapter",
            String.Format("update SMEV_MESSAGES set STATE = '{0}' where ID = '{1}'", state, request[0]));*/
        return result;
    }
    public static bool SendResponseMessage_VS01113v001_TABL00(ref string[] folders, XmlElement body, string _clientId, bool isTestMessage = true)
    {
        try
        {
            adapterSmev1_2.ResponseMessageType response = new adapterSmev1_2.ResponseMessageType()
            {
                messageType = "RESPONSE",
                ResponseMetadata = new adapterSmev1_2.ResponseMetadataType()
                {
                    replyToClientId = _clientId,
                    clientId = Guid.NewGuid().ToString()
                },
                ResponseContent = new adapterSmev1_2.ResponseContentType()
                {
                    content = (body != null) ? new adapterSmev1_2.Content() { MessagePrimaryContent = body }: null,
                    rejects = (body != null) ? null : new adapterSmev1_2.Reject[] { new adapterSmev1_2.Reject() { code = adapterSmev1_2.RejectCode.NO_DATA, description = "Нет данных" } }
                }
            };

            adapterSmev1_2.ClientMessage clientMessage = new adapterSmev1_2.ClientMessage()
            {
                itSystem = "ServiceSRZ",
                RequestMessage = null,
                ResponseMessage = response
            };
            return saveXML_toFile2<adapterSmev1_2.ClientMessage>(clientMessage, Path.Combine(folders[1], string.Format("smev12-response-{0}.xml", _clientId)), Encoding.UTF8);
        }
        catch
        {
            return false;
        }
    }

    public static bool sendResponse(string[] request, ref List<clsConnections> link_connections, ref string[] folders, out string comments)
    {
        bool result = false;
        comments = string.Empty;
        XmlElement xmlElement = null;
        //в зависимости от типа данных получаем соответствующий контент
        {
            switch (request[2])
            {
                case "POLIS":
                    //sendResponse_Polis(request_row);
                    break;
                case "USLUGI": //пока работает по старой ветке, контролируется в сервисе
                    xmlElement = responseContent_VS01113v001_TABL00(ref link_connections, request[1], out comments);
                    break;
                case "FATALZP"://VS01285v001_TABL00
                    xmlElement = responseContent_VS01285v001_TABL00(ref link_connections, request[1], out comments);
                    break;
                case "ROGDZP"://VS01287v001_TABL00
                    xmlElement = responseContent_VS01287v001_TABL00(ref link_connections, request[1], out comments);
                    break;
                case "PERNAMEZP"://VS01284v001_TABL00
                    xmlElement = responseContent_VS01284v001_TABL00(ref link_connections, request[1], out comments);
                    break;
            }            
        }
        if (comments == string.Empty)
        {
            object response = null;
            string clientId = string.Empty;
            ReglamentLinker reglamentLinker = new ReglamentLinker();
            //в зависимости от версии схемы Адаптера
            {                
                reglamentLinker.getLink(null, null, null, null, request[2]);
                switch (reglamentLinker.link.reglament_owner)
                {
                    case Reglament_owner.SMEV13:
                        response = request_adapter1_3(null, xmlElement, request[1], out clientId, out comments);
                        break;
                    case Reglament_owner.SMEV12:
                        response = request_adapter1_2(null, xmlElement, request[1], out clientId, out comments);
                        break;
                }                
            }
            if (comments == string.Empty)
            {
                clsLibrary.execQuery(ref link_connections, null, "srz3_00_adapter"
                     , String.Format("update SMEV_MESSAGES set RESPONSE = '<clientId>{0}</clientId>' where MessageID = '{1}'", clientId, request[1]));
                saveXML_toFile2<adapterSmev1_3.SendRequest>(response, Path.Combine(folders[1], string.Format("{0}-response-{1}.xml", reglamentLinker.link.reglament_owner.ToString(), request[1])), Encoding.UTF8);
                result = true;
            }
        }
        return result;
    }
    public static object request_adapter1_3(XmlElement requestContent, XmlElement responseContent, string replyClientId, out string _clientId, out string comments)
    {
        comments = string.Empty;
        _clientId = Guid.NewGuid().ToString();
        try
        {
            //Принимаем пока что Request не бывает, только Response
            adapterSmev1_3.RequestMessageType requestMessage = null; // new adapterSmev1_3.RequestMessageType();
            adapterSmev1_3.ResponseMessageType responseMessage = new adapterSmev1_3.ResponseMessageType()
            {
                messageType = "RESPONSE",
                ResponseMetadata = new adapterSmev1_3.ResponseMetadataType()
                {
                    replyToClientId = replyClientId,
                    clientId = _clientId
                },
                ResponseContent = new adapterSmev1_3.ResponseContentType()
                {
                    content = (responseContent != null) ? new adapterSmev1_3.Content() { MessagePrimaryContent = responseContent } : null,
                    rejects = (responseContent != null) ? null : new adapterSmev1_3.Reject[] { new adapterSmev1_3.Reject() { code = adapterSmev1_3.RejectCode.NO_DATA, description = "Нет данных" } }
                }
            };
            return new adapterSmev1_3.SendRequest()
            {
                itSystem = "ServiceSRZ",
                RequestMessage = requestMessage,
                ResponseMessage = responseMessage
            };
        }
        catch
        {
            comments = "Ошибка формирования requestAdapter";
            return null;
        }
    }
    public static object request_adapter1_2(XmlElement requestContent, XmlElement responseContent, string replyClientId, out string _clientId, out string comments)
    {
        comments = string.Empty;
        _clientId = Guid.NewGuid().ToString();
        try
        {
            //Принимаем пока что Request не бывает, только Response
            adapterSmev1_2.RequestMessageType requestMessage = null; // new adapterSmev1_3.RequestMessageType();
            adapterSmev1_2.ResponseMessageType responseMessage = new adapterSmev1_2.ResponseMessageType()
            {
                messageType = "RESPONSE",
                ResponseMetadata = new adapterSmev1_2.ResponseMetadataType()
                {
                    replyToClientId = replyClientId,
                    clientId = _clientId
                },
                ResponseContent = new adapterSmev1_2.ResponseContentType()
                {
                    content = (responseContent != null) ? new adapterSmev1_2.Content() { MessagePrimaryContent = responseContent } : null,
                    rejects = (responseContent != null) ? null : new adapterSmev1_2.Reject[] { new adapterSmev1_2.Reject() { code = adapterSmev1_2.RejectCode.NO_DATA, description = "Нет данных" } }
                }
            };
            return new adapterSmev1_2.SendRequest()
            {
                itSystem = "ServiceSRZ",
                RequestMessage = requestMessage,
                ResponseMessage = responseMessage
            };
        }
        catch
        {
            comments = "Ошибка формирования requestAdapter";
            return null;
        }
    }
    public static XmlElement responseContent_VS01113v001_TABL00(ref List<clsConnections> link_connections, string messageId, out string comments)
    {
        comments = messageId;// String.Empty;
        try
        {
            XmlElement xmlElement = null;
            List<string[]> response_content = new List<string[]>();
            clsLibrary.ExecQurey_GetListStrings(link_connections, null, "srz3_00_adapter"
                    , String.Format("select top 1 FAM,IM,OT,convert(varchar(10),DR,120) ,ENP,convert(varchar(10), DATEFROM,120), convert(varchar(10), DATETO,120) from KUTFOMS_USLUGI where idmessage = '{0}'", messageId),
                ref response_content);
            comments = response_content.Count.ToString();
            string PID = clsLibrary.execQuery_getString(ref link_connections, null, "srz3_00"
                    , String.Format("select top 1 id from people where isnull(fam,'') = '{0}' and isnull(im,'') = '{1}' and isnull(ot,'') = '{2}' and dr = '{3}' and ENP = '{4}' order by id desc", response_content[0][0], response_content[0][1], response_content[0][2], response_content[0][3], response_content[0][4])
                );
            if (PID != String.Empty)
            {
                comments = PID;
                List<string[]> response = new List<string[]>();
                // Получение данных реестров
                if (clsLibrary.ExecQurey_PGR_GetListStrings(ref link_connections, null, "main_db",
                        String.Format(
                            "select request.MessageId, coalesce(ppl.id_pac,'0') id, usl.sumv_usl, to_char(z_sl.date_z_1,'YYYY-MM-DD'), to_char(z_sl.date_z_1,'YYYY-MM-DD'), z_sl.vidpom, z_sl.usl_ok, usl.code_usl, z_sl.lpu " +
                            "from (select '{0}' as MessageId, {1} as pid) request " +
                            "left outer join public.personal_info ppl on ppl.reg_id = request.pid " +
                            "join public.z_sl z_sl on z_sl.id_pac = ppl.id_pac " +
                            "join public.usl usl on usl.z_sl_id = z_sl.idcase where z_sl.date_z_2>='{2}' and z_sl.date_z_2<='{3}' " +
                            "order by date_z_1",
                        messageId, PID, response_content[0][5], response_content[0][6]),
                        ref response, 60000)
                    )
                {
                    if (response.Count != 0)
                    {
                        List<VS01113v001_TABL00.InsuredRenderingInfo> insuredRenderingList = new List<VS01113v001_TABL00.InsuredRenderingInfo>();
                        for (int i = 0; i < response.Count(); i++)
                        {
                            VS01113v001_TABL00.InsuredRenderingInfo respone_data = new VS01113v001_TABL00.InsuredRenderingInfo();
                            respone_data = new VS01113v001_TABL00.InsuredRenderingInfo
                            {
                                MedServicesSum = Convert.ToDecimal(response[i][2]),
                                DateRenderingFrom = response[i][3], //. "2017-06-16",//DateTime. Now.AddDays(-2).Date,
                                DateRenderingTo = response[i][4], //"2017-07-16",//DateTime.Now.AddDays(-2).Date,
                                CareRegimen = HelperXmlSmev.getName_fromLibraies(ref link_connections, "VMPNAME", "libV008", "IDVMP", response[i][5]), //"первичная медико-санитарная помощь",
                                CareType = HelperXmlSmev.getName_fromLibraies(ref link_connections, "UMPNAME", "libV006", "IDUMP", response[i][6]), //"Амбулаторно (в условиях, не предусматривающих круглосуточного медицинского наблюдения и лечения), в том числе на дому при вызове медицинского работника",
                                Name = HelperXmlSmev.getName_fromLibraies(ref link_connections, "name", "libSp_usl", "code", response[i][7]), //"Тра-та-та"
                                ClinicName = HelperXmlSmev.getName_fromLibraies(ref link_connections, "nam_mok", "libMo", "mcod", @response[i][8]), //"Ойля-ля"
                                RegionName = "Амурская область"
                            };
                            insuredRenderingList.Add(respone_data);
                        }
                        xmlElement = (new XmlDocument(){
                            InnerXml = HelperXmlSmev.SerializeTo(
                                new VS01113v001_TABL00.OutputDataType()
                                {
                                    InsuredRenderingList = insuredRenderingList.ToArray()
                                })
                        }).DocumentElement;
                    }                    
                }
                else // Ошибка получения сведений
                {
                    throw new System.ArgumentException("ошибка получения сведений МП ");
                }
            }
            return xmlElement;
        }
        catch (Exception exception)
        {
            comments += " : Ошибка формирования InsuredRenderingInfo : " + exception.Message;
            return null;
        }
    }
    public static XmlElement responseContent_VS01285v001_TABL00(ref List<clsConnections> link_connections, string messageId, out string comments)
    {
        comments = string.Empty;
        try
        {//string txt = //"<ИдСведений><ИдСвед>123-123-123-123</ИдСвед></ИдСведений>";    
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(
                    clsLibrary.execQuery_getString(
                     ref link_connections, null, "srz3_00_adapter"
                     , String.Format("select REQUEST from SMEV_MESSAGES where MessageID = '{0}'", messageId)
                 ));
            XmlNodeList xmlNodeList = (xmlDocument.FirstChild).ChildNodes;            
            return (//из-за не уточненного варианта ответа на множественный контент ЗАГСА, указывается только единственный ID
                new XmlDocument()
                {
                    InnerXml = HelperXmlSmev.SerializeTo(
                            new VS01285v001_TABL00.FATALZPResponse()
                            {
                                ИдСвед = xmlNodeList[0].InnerText,
                                КодОбр = VS01285v001_TABL00.FATALZPResponseКодОбр.Item1
                            })
                }).DocumentElement;
        }
        catch
        {
            comments = "Ошибка формирования FATALZPResponse";
            return null;
        }
    }
    public static XmlElement responseContent_VS01287v001_TABL00(ref List<clsConnections> link_connections, string messageId, out string comments)
    {
        comments = string.Empty;
        try
        {//string txt = //"<ИдСведений><ИдСвед>123-123-123-123</ИдСвед></ИдСведений>";    
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(
                    clsLibrary.execQuery_getString(
                     ref link_connections, null, "srz3_00_adapter"
                     , String.Format("select REQUEST from SMEV_MESSAGES where MessageID = '{0}'", messageId)
                 ));
            XmlNodeList xmlNodeList = (xmlDocument.FirstChild).ChildNodes;
            return (//из-за не уточненного варианта ответа на множественный контент ЗАГСА, указывается только единственный ID
                new XmlDocument()
                {
                    InnerXml = HelperXmlSmev.SerializeTo(
                            new VS01287v001_TABL00.ROGDZPResponse()
                            {
                                ИдСвед = xmlNodeList[0].InnerText,
                                КодОбр = VS01287v001_TABL00.ROGDZPResponseКодОбр.Item1
                            })
                }).DocumentElement;
        }
        catch
        {
            comments = "Ошибка формирования ROGDZPResponse";
            return null;
        }
    }
    public static XmlElement responseContent_VS01284v001_TABL00(ref List<clsConnections> link_connections, string messageId, out string comments)
    {
        comments = string.Empty;
        try
        {//string txt = //"<ИдСведений><ИдСвед>123-123-123-123</ИдСвед></ИдСведений>";    
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(
                    clsLibrary.execQuery_getString(
                     ref link_connections, null, "srz3_00_adapter"
                     , String.Format("select REQUEST from SMEV_MESSAGES where MessageID = '{0}'", messageId)
                 ));
            XmlNodeList xmlNodeList = (xmlDocument.FirstChild).ChildNodes;
            return (//из-за не уточненного варианта ответа на множественный контент ЗАГСА, указывается только единственный ID
                new XmlDocument()
                {
                    InnerXml = HelperXmlSmev.SerializeTo(
                            new VS01284v001_TABL00.PERNAMEZPResponse()
                            {
                                ИдСвед = xmlNodeList[0].InnerText,
                                КодОбр = VS01284v001_TABL00.PERNAMEZPResponseКодОбр.Item1
                            })
                }).DocumentElement;
        }
        catch
        {
            comments = "Ошибка формирования PERNAMEZPResponse";
            return null;
        }
    }
    public static bool saveXML_toFile1(ref XmlElement xmlElement, string file, Encoding encoding = null) // string messageId, string prefix)
    {
        bool result = false;
        FileStream fileStream = new FileStream(file, FileMode.Create);
        StreamWriter streamWriter = new StreamWriter(fileStream, (encoding == null) ? Encoding.GetEncoding(1251) : encoding);
        try
        {
            if (File.Exists(file)) File.Delete(file);
            streamWriter.Write(xmlElement.InnerXml);
            streamWriter.Close();
            result = true;
        }
        catch { }
        fileStream.Close();
        streamWriter.Close();
        return result;
    }
    public static bool saveXML_toFile2<T>(object xmlElement, string file, Encoding encoding = null)
    {
        bool result = false;
        FileStream fileStream = null;
        StreamWriter streamWriter = null;
        try
        {
            fileStream = new FileStream(file, FileMode.Create);
            streamWriter = new StreamWriter(fileStream, (encoding == null) ? Encoding.GetEncoding(1251) : encoding);
            XmlSerializer writer = new XmlSerializer(typeof(T));
            XmlSerializerNamespaces nameSpaces = new XmlSerializerNamespaces();
            writer.Serialize(streamWriter, xmlElement);
            result = true;
        }
        catch { }
        if (fileStream != null)
        {

            streamWriter.Close();
            fileStream.Close();
        }
        return result;
    }

}

//Вспомогательные

public static class HelperXmlSmev
{
    public static readonly XmlSerializerNamespaces Namespaces = new XmlSerializerNamespaces();
    static HelperXmlSmev()
    {
        Namespaces.Add("ns1", "http://ffoms.ru/GetInsuredRenderedMedicalServices/1.0.0");
        Namespaces.Add("q1", "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2");
        //xmlns: ns2 = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types/faults" xmlns = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types" >
    }

    public static string SerializeTo<T>(this T xmlObject, bool useNamespaces = true, int type = 1)
    {
        if (type == 1)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            MemoryStream memoryStream = new MemoryStream();
            XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);
            xmlTextWriter.Formatting = Formatting.Indented;

            if (useNamespaces)
            {
                xmlSerializer.Serialize(xmlTextWriter, xmlObject, Namespaces);
            }
            else
                xmlSerializer.Serialize(xmlTextWriter, xmlObject);

            string output = Encoding.UTF8.GetString(memoryStream.ToArray());
            string _byteOrderMarkUtf8 = Encoding.UTF8.GetString(Encoding.UTF8.GetPreamble());
            if (output.StartsWith(_byteOrderMarkUtf8))
            {
                output = output.Remove(0, _byteOrderMarkUtf8.Length);
            }

            return output;
        }
        else if (type == 2)
        {
            var emptyNamespaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            var serializer = new XmlSerializer(xmlObject.GetType());
            var settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;

            using (var stream = new StringWriter())
            using (var writer = XmlWriter.Create(stream, settings))
            {
                serializer.Serialize(writer, xmlObject, emptyNamespaces);
                return stream.ToString();
            }
        }
        else return null;
    }

public static T DeserializeFrom<T>(this XmlElement xml) where T : new()
    {
        T xmlObject = new T();
        try
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            StringReader stringReader = new StringReader(xml.OuterXml);
            xmlObject = (T)xmlSerializer.Deserialize(stringReader);
        }
        catch (Exception e)
        {

        }
        return xmlObject;
    }
    public static string getName_fromLibraies(ref List<clsConnections> link_connections, string nameField, string table, string fieldCode, string code)
    //получение имени МО по коду
    {
        string result = null;
        if (fieldCode != null) 
            result = clsLibrary.execQuery_getString(
                 ref link_connections, null, "libraries",
                 String.Format("SELECT top 1 {0} FROM {1} where {2} = '{3}'", nameField, table, fieldCode, code)
                 );
        if (result == null)
            return string.Empty;
        else
            return result;
    }
}