using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Odbc;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace Timesheets.Helpers
{
    public class ODBCReaderToModel<T>
    {
        public virtual List<T> CreateList(string sql,string company)
        {
            var results = new List<T>();
            using (clsOdbcDataGetter dg = new clsOdbcDataGetter(company))
            {
                OdbcDataReader reader = dg.GetDataReader(sql);
                var NotMapped = new List<String>();

                var props = typeof(T).GetProperties().Where(x => Attribute.IsDefined(x, typeof(NotMappedAttribute)));
                foreach (var prop in props)
                {
                    NotMapped.Add(prop.Name);
                }

                while (reader.Read())
                {
                    var item = Activator.CreateInstance<T>();
                    foreach (var property in typeof(T).GetProperties())
                    {
                        if (!NotMapped.Contains(property.Name))
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(property.Name)))
                            {
                                Type convertTo = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
                                property.SetValue(item, Convert.ChangeType(reader[property.Name], convertTo), null);
                            }
                        }
                    }
                    results.Add(item);
                }
                dg.KillReader(reader);
            }
            return results;
        }

        public virtual T CreateModel(string sql, string company)
        {
            var results = new List<T>();
            using (clsOdbcDataGetter dg = new clsOdbcDataGetter(company))
            {
                OdbcDataReader reader = dg.GetDataReader(sql);
                var NotMapped = new List<String>();

                var props = typeof(T).GetProperties().Where(x => Attribute.IsDefined(x, typeof(NotMappedAttribute)));
                foreach (var prop in props)
                {
                    NotMapped.Add(prop.Name);
                }

                while (reader.Read())
                {
                    var item = Activator.CreateInstance<T>();
                    foreach (var property in typeof(T).GetProperties())
                    {
                        if (!NotMapped.Contains(property.Name))
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(property.Name)))
                            {
                                Type convertTo = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
                                property.SetValue(item, Convert.ChangeType(reader[property.Name], convertTo), null);
                            }
                        }
                    }
                    results.Add(item);
                }
                dg.KillReader(reader);
            }
            return results[0];
        }
    }
}
