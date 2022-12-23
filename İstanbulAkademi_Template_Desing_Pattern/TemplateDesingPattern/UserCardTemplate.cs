using İstanbulAkademi_Template_Desing_Pattern.DAL.Entities;
using System.Text;

namespace İstanbulAkademi_Template_Desing_Pattern.TemplateDesingPattern
{
    public abstract class UserCardTemplate
    {
        protected AppUser AppUser { get; set; }
        protected abstract string SetImage();
        protected abstract string SetFooter();
        public string Build()
        {
            var sb = new StringBuilder();
            sb.Append("<div class='card'>");
            sb.Append(SetImage());
            sb.Append(@$"<div class='card-body'>
                        <h5>{AppUser.Name + ' ' + AppUser.Surname}</h5>
                        <p>{AppUser.Description}</p>");
            sb.Append(SetFooter());
            sb.Append("</div>");
            sb.Append("</div>");
            return sb.ToString();
        }

    }
}
