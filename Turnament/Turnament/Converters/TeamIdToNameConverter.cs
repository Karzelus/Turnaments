using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Turnaments.Models;
using System.Windows.Markup;

namespace Turnament.Converters
{
    public class TeamIdToNameConverter : MarkupExtension,IValueConverter
    {
        public static List<Turnaments.Models.Team> Teams
        {
            get; set;
        }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int teamId = (int)value;
            Turnaments.Models.Team team = Teams?.FirstOrDefault(t => t.Id == teamId);
            return team?.Name;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
