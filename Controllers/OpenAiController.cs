using Microsoft.AspNetCore.Mvc;
using openaiapp.Services;

namespace openaiapp.Controllers;

[ApiController]
[Route("[controller]")]
public class OpenAiController : ControllerBase 
{
    private readonly ILogger<OpenAiController> _logger;
    private readonly IOpenAiService _openAiService;
    public OpenAiController(ILogger<OpenAiController> logger,IOpenAiService openAiService)
    {
        _logger = logger;
        _openAiService = openAiService;
    } 

    [HttpPost]
    [Route("CompleteSentence")]
    public async Task<IActionResult> CompleteSentence(string text)
    {
        var result = await _openAiService.CompleteSentenceAdvance(text);
        return Ok(result);
    }

    [HttpPost]
    [Route("AskQuestion")]
    public async Task<IActionResult> AskQuestion(string text)
    {
        var result = await _openAiService.CheckProgramingLanguage(text);
        return Ok(result);
    }
}