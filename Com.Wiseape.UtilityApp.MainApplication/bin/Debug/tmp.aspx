using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.<% me.say(Project.ProjectName); %>.Data.Model;

namespace Com.Wiseape.<% me.say(Project.ProjectName); %>.<% me.say(Module.ModuleName); %>.Repository.Contract
{
    public interface I<% me.say(Module.Datasource.TableName); %>Repository
    {
<%
DataSourceTable dataSource = (DataSourceTable)Module.ModelType.Datasource;
foreach(UIColumn column  in dataSource.DataColumns)
{
   if(column.Key == false)
   {
       string type = DatabaseMapper.MapType(column.DataType);
       string colName = StrUtil.LowFirst(column.ColumnName);
       if(column.DataType == "date")
      {
%>
        List<<% me.say(Module.Datasource.TableName); %>> FindAllBy<% me.say(column.ColumnName); %>Between(<% me.say(type); %> <% me.say(colName); %>1, <% me.say(type); %> <% me.say(colName); %>2);
<%
      }
     else
     {
%>
        List<<% me.say(Module.Datasource.TableName); %>> FindAllBy<% me.say(column.ColumnName); %>(<% me.say(type); %> <% me.say(colName); %>);
<%
       }
   }
}
%>

    }
}
