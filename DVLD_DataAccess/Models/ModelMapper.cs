using System.Reflection;

namespace DVLD_DataAccess.Models
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class ColumnAttribute : Attribute
    {
        public string Name { get; }

        public ColumnAttribute(string name)
        {
            Name = name;
        }
    }
    public static class DataReaderMapper
    {
        public static T MapToModel<T>(SqlDataReader reader) where T : new()
        {
            var model = new T();
            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                      .Where(p => (p.PropertyType == typeof(string) || p.PropertyType.IsValueType));
            var columnNames = Enumerable.Range(0, reader.FieldCount)
                .Select(i => reader.GetName(i))
                .ToList();

            foreach (var prop in properties)
            {
                var columnName = prop.GetCustomAttribute<ColumnAttribute>()?.Name ?? prop.Name;
                var isRequired = prop.GetCustomAttribute<System.Runtime.CompilerServices.RequiredMemberAttribute>() != null;

                if (columnNames.Contains(columnName, StringComparer.OrdinalIgnoreCase))
                {
                    try
                    {
                        if (!reader.IsDBNull(columnName))
                        {
                            var convertedValue = Convert.ChangeType(reader[columnName],
                                                                    Nullable.GetUnderlyingType(prop.PropertyType)
                                                                    ?? prop.PropertyType);
                            prop.SetValue(model, convertedValue);
                        }
                        else if (isRequired)
                        {
                            if (prop.PropertyType == typeof(string))
                                prop.SetValue(model, string.Empty);
                            else
                                throw new Exception( $"Required property {prop.Name} (column {columnName}) cannot be null in the database.");
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Failed to map column {columnName} to property {prop.Name}", ex);
                    }
                }
                else if (isRequired)
                {
                    if (prop.PropertyType == typeof(string))
                        prop.SetValue(model, string.Empty);
                    else
                        throw new Exception($"Required property {prop.Name} (expected column {columnName}) not found in the result set.");
                }
            }
            foreach (var prop in properties.Where(p => p.GetCustomAttribute<System.Runtime.CompilerServices.RequiredMemberAttribute>() != null))
            {
                if (prop.GetValue(model) == null)
                    throw new Exception($"Required property {prop.Name} was not set after mapping.");
            }

            return model;
        }
    }
}
