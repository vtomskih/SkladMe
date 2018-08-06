﻿// <auto-generated />

using SkServ.Model.RequestParams;

namespace SkServ.Utils
{
    partial class RequestParameters
    {
		/// <summary>
        /// Преобразование класса <see cref="CommonRequestParams"/> в RequestParameters
        /// </summary>
        /// <param name="p">Параметр.</param>
        /// <returns>
        /// Результат преобразования.
        /// </returns> 
		public static implicit operator RequestParameters(CommonRequestParams p)
		{
            return CommonRequestParams.ToRequestParameters(p);
        }

	}
}