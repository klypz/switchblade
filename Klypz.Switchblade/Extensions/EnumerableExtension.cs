﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klypz.Switchblade.Extensions
{
    /// <summary>
    /// Extensão de funcionalidades da interface [IEnumerable]
    /// </summary>
    public static class EnumerableExtension
    {
        /// <summary>
        /// <para>Facilita a operação de paginar um IEnumerable.</para>
        /// <para>É necessário determinar a quantidade de registro por página e qual a página que deve ser retornada.</para>
        /// </summary>
        /// <example>
        /// <code>
        /// //Retorna uma lista de pessoa com no máximo 10 registro contanto a partir do registro de número 30
        /// //Quando se existe um Filtro (Where) é necessário um ordenamento (OrderBy)
        /// List&lt;Pessoa&gt; pessoa = context.Pessoas.Where(p =&gt; p.Nome.Contains("N") ).Pagination(10, 2).OrderBy(o =&gt; new { o.Nome }).ToList()
        /// </code>
        /// </example>
        /// <typeparam name="TSource">Classe que servirá como base do IEnumerable tratado</typeparam>
        /// <param name="self">IEnumerable a ser tratado</param>
        /// <param name="pageSize">Quantidade de registro por página</param>
        /// <param name="page">Número da página a ser retornado. O registro inicial da paginação é (pageSize * page)</param>
        /// <returns>IEnumerable paginado</returns>
        public static IEnumerable<TSource> Pagination<TSource>(this IEnumerable<TSource> self, int pageSize, int page)
        {
            int initial = page * pageSize;
            int final = initial + pageSize;

            if (final > self.Count())
            {
                final = self.Count();
            }

            return self.Skip(initial).Take(final);
        }
    }
}
