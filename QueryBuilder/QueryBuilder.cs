using System;
using System.Collections.Generic;
using System.Text;

class QueryBuilder
{
    private string query;
    public QueryBuilder Select(string columns)
    {
        query += $"SELECT {columns}";
        return this;
    }
    public QueryBuilder From(string table)
    {
        query += $"FROM {table}";
        return this;
    }
    public QueryBuilder Where(string condition)
    {
        query += $"WHERE {condition}";
        return this;
    }
    public QueryBuilder OrderBy(string column)
    {
        query += $"ORDER BY {column}";
        return this;
    }
    public string Build()
    {
        return query;
    }
}
