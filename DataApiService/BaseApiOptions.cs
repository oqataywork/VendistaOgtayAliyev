using System;
using System.Collections.Generic;
using System.Text;

namespace DataApiService
{
    public class BaseApiOptions
    {
        /// <summary>
        /// Токен сервиса
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Адрес веб-сервера (полный URL)
        /// </summary>
        /// <remarks>
        /// Свойство обределяется при старте сервера, значение берется из файла настроек
        /// appsettings.json
        /// ключ ApiWebAddress
        /// по умолчанию равен http://178.57.220.37:398, если в конфигурации нет настройки используется значение по умолчанию
        /// </remarks>
        public string BaseUrl { get; set; }

        /// <summary>
        /// Адрес точки с токеном
        /// </summary>
        /// <param name="controllerName">Контроллер точки</param>
        /// <returns>Строка URL</returns>
        public string GetUrlApiService(string controllerName)
        {
            if (string.IsNullOrEmpty(Token))
            {
                throw new ArgumentNullException("Token не получен");
            }

            return $"{BaseUrl}/{controllerName}/?token={Token}";
        }

    }
}
