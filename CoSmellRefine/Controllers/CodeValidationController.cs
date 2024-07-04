using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace CoSmellRefine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CodeValidationController : ControllerBase
    {
        [HttpPost]
        [Route("ValidateCSharp")]
        public IActionResult ValidateCSharp([FromBody] CodeSnippetRequest request)
        {
            var syntaxTree = CSharpSyntaxTree.ParseText(request.CodeSnippet);
            var diagnostics = syntaxTree.GetDiagnostics();

            if (diagnostics.Any(d => d.Severity == DiagnosticSeverity.Error))
            {
                return BadRequest("The code snippet is not valid C#.");
            }

            return Ok("The code snippet is valid C#.");
        }
    }

    public class CodeSnippetRequest
    { 
        public string CodeSnippet { get; set; }
    }
}
