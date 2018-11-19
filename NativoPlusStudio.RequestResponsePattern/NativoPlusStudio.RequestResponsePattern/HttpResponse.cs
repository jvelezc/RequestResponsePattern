#region Assemblies
using System.Collections.Generic;
using System.Net;
using FluentValidation.Results;
using System.Linq;
#endregion
namespace NativoPlusStudio.RequestResponsePattern
{
    public partial class HttpResponse
    {
        public virtual string ErrorMessage { get; set; } = string.Empty;
        public virtual object Response { get; set; }
        public virtual HttpStatusCode HttpStatusCode { get; set; }
        public virtual IList<ValidationFailure> Error { get; set; } = new List<ValidationFailure>(); 
        public virtual  bool Succeeded =>!Error.Any();
    }
}
