using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeator.ObjectModel
{
    /// <summary>
    /// Handles the whole repeator process
    /// </summary>
    public class RepeatorEngine
    {

        /// <summary>
        /// Repeats a template against a json array data source
        /// Ex: 
        /// datasource = [1, 4, -3];
        /// template = { id: $item, index: $i, name: "Amen$i"},\n
        /// output = 
        /// { id: 1, index: 0, name: "Amen0"},
        /// { id: 4, index: 1, name: "Amen1"},
        /// { id: -3, index: 2, name: "Amen2"},
        /// </summary>
        /// <param name="dataSource">
        /// Option1: 
        ///     An integer so the template will be repeated an equals times to this integer
        /// 
        /// Option2:
        ///     A json array like [{ data: 'a'}, { data: 'b'}, { data: 'c'}]</param>
        /// <param name="template">A text with repeator keywords: 
        /// $i as index
        /// $item as json array item
        /// </param>
        public string Repeat(string dataSource, string template)
        {

            if (string.IsNullOrWhiteSpace(dataSource) || string.IsNullOrWhiteSpace(template))
            {
                return string.Empty;
            }

            var result = string.Empty;

            int count;

            if (int.TryParse(dataSource, out count))
            {
                result = RepeatByCount(count, template);
            }

            return result;
        }

        private string RepeatByCount(int count, string template)
        {

            if (count <= 0 || string.IsNullOrWhiteSpace(template))
            {
                return string.Empty;

            }

            var result = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                result.Append(template.Replace("$i", i.ToString().Replace("$b", (i % 2).ToString())));
            }

            return result.ToString();

        }
    }
}
