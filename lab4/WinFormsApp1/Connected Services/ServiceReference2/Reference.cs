﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторного создания кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference2
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tav/", ConfigurationName="ServiceReference2.SimplexSoap")]
    public interface SimplexSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tav/sum_1", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference2.sum_11> AddAsync(ServiceReference2.sum_1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tav/sum_2", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference2.sum_21> ConcatAsync(ServiceReference2.sum_2 request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sum_1", WrapperNamespace="http://tav/", IsWrapped=true)]
    public partial class sum_1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tav/", Order=0)]
        public int x;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tav/", Order=1)]
        public int y;
        
        public sum_1()
        {
        }
        
        public sum_1(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sum_1Response", WrapperNamespace="http://tav/", IsWrapped=true)]
    public partial class sum_11
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tav/", Order=0)]
        public int sum_1Result;
        
        public sum_11()
        {
        }
        
        public sum_11(int sum_1Result)
        {
            this.sum_1Result = sum_1Result;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sum_2", WrapperNamespace="http://tav/", IsWrapped=true)]
    public partial class sum_2
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tav/", Order=0)]
        public string s;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tav/", Order=1)]
        public double d;
        
        public sum_2()
        {
        }
        
        public sum_2(string s, double d)
        {
            this.s = s;
            this.d = d;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sum_2Response", WrapperNamespace="http://tav/", IsWrapped=true)]
    public partial class sum_21
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tav/", Order=0)]
        public string sum_2Result;
        
        public sum_21()
        {
        }
        
        public sum_21(string sum_2Result)
        {
            this.sum_2Result = sum_2Result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface SimplexSoapChannel : ServiceReference2.SimplexSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class SimplexSoapClient : System.ServiceModel.ClientBase<ServiceReference2.SimplexSoap>, ServiceReference2.SimplexSoap
    {
        
        /// <summary>
        /// Реализуйте этот разделяемый метод для настройки конечной точки службы.
        /// </summary>
        /// <param name="serviceEndpoint">Настраиваемая конечная точка</param>
        /// <param name="clientCredentials">Учетные данные клиента.</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public SimplexSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(SimplexSoapClient.GetBindingForEndpoint(endpointConfiguration), SimplexSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SimplexSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SimplexSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SimplexSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SimplexSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SimplexSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }

        public SimplexSoapClient()
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference2.sum_11> ServiceReference2.SimplexSoap.AddAsync(ServiceReference2.sum_1 request)
        {
            return base.Channel.AddAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference2.sum_11> AddAsync(int x, int y)
        {
            ServiceReference2.sum_1 inValue = new ServiceReference2.sum_1();
            inValue.x = x;
            inValue.y = y;
            return ((ServiceReference2.SimplexSoap)(this)).AddAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference2.sum_21> ServiceReference2.SimplexSoap.ConcatAsync(ServiceReference2.sum_2 request)
        {
            return base.Channel.ConcatAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference2.sum_21> ConcatAsync(string s, double d)
        {
            ServiceReference2.sum_2 inValue = new ServiceReference2.sum_2();
            inValue.s = s;
            inValue.d = d;
            return ((ServiceReference2.SimplexSoap)(this)).ConcatAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.SimplexSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.SimplexSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpsTransportBindingElement httpsBindingElement = new System.ServiceModel.Channels.HttpsTransportBindingElement();
                httpsBindingElement.AllowCookies = true;
                httpsBindingElement.MaxBufferSize = int.MaxValue;
                httpsBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpsBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.SimplexSoap))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost:44349/Simplex.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.SimplexSoap12))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost:44349/Simplex.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            SimplexSoap,
            
            SimplexSoap12,
        }
    }
}