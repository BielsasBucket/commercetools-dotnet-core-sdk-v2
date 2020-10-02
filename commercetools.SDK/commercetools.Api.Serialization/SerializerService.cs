﻿using System.Text.Json;
using commercetools.Api.Models.Types;
using commercetools.Api.Registration;
using commercetools.Api.Serialization.JsonConverters;
using commercetools.Api.Serialization.MapperTypeRetrievers;
using Type = System.Type;

namespace commercetools.Api.Serialization
{
    public class SerializerService : ISerializerService
    {
        private readonly JsonSerializerOptions _serializerOptions;
       
        public SerializerService(
            ITypeRetriever typeRetriever, 
            IMapperTypeRetriever<FieldContainer> mapperTypeRetriever)
        {
            _serializerOptions = new JsonSerializerOptions
            {
                IgnoreNullValues = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };
            _serializerOptions.Converters.Add(new CustomDateTimeConverter());
            _serializerOptions.Converters.Add(new FieldContainerConverter(mapperTypeRetriever, this));
            _serializerOptions.Converters.Add(new AbstractClassConverterFactory(
                _serializerOptions.PropertyNamingPolicy, _serializerOptions, typeRetriever));
        }

        public T Deserialize<T>(string input)
        {
            return JsonSerializer.Deserialize<T>(input, _serializerOptions);
        }
        
        public object Deserialize(Type returnType,string input)
        {
            return JsonSerializer.Deserialize(input, returnType, _serializerOptions);
        }

        public string Serialize<T>(T input)
        {
            return JsonSerializer.Serialize<T>(input, _serializerOptions);
        }
    }
}
