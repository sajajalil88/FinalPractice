  using Microsoft.AspNetCore.Mvc; 
  using Microsoft.Azure.WebJobs; 
  using Microsoft.AspNetCore.Http; 
  using Microsoft.Extensions.Logging; 
  public static class Echo   {      
  //hii
[FunctionName("Echo")] 
public static IActionResult Run( 
[HttpTrigger("POST")] HttpRequest request, 
ILogger logger) 
{ 
} 
logger.LogInformation("Received a request"); 
return new OkObjectResult(request.Body); 
  }