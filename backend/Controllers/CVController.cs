using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;
using System.Threading.Tasks;
using myapp.Models;

[Route("/cv")]
[ApiController]
public class CVController : ControllerBase
{
    private readonly CVContext _dbContext;

    public CVController(CVContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpPost]
    public async Task<IActionResult> CreateCV([FromBody] CVData cvData)
    {
        if (cvData == null)
        {
            return BadRequest("Invalid data");
        }

        Console.WriteLine($"Name: {cvData.Name}");
        Console.WriteLine($"Surname: {cvData.Surname}");

        _dbContext.CV.Add(cvData);
        await _dbContext.SaveChangesAsync();

   
        string templatePath = "template.docx";
        string outputFilePath = $"cv.docx";

        using (FileStream fileStream = new FileStream(templatePath, FileMode.Open, FileAccess.Read))
        {
            using (MemoryStream outputStream = new MemoryStream())
            {
                await fileStream.CopyToAsync(outputStream);
                using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(outputStream, true))
                {
                    var body = wordDoc.MainDocumentPart.Document.Body;
                    foreach (var text in body.Descendants<Text>())
                    {
                        if (text.Text.Contains("«Name»")) text.Text = text.Text.Replace("«Name»", cvData.Name);
                        if (text.Text.Contains("«Surname»")) text.Text = text.Text.Replace("«Surname»", cvData.Surname);
                        if (text.Text.Contains("«Location»")) text.Text = text.Text.Replace("«Location»", cvData.Location);
                        if (text.Text.Contains("«Email»")) text.Text = text.Text.Replace("«Email»", cvData.Email);
                        if (text.Text.Contains("«Phone»")) text.Text = text.Text.Replace("«Phone»", cvData.PhoneNumber);
                        if (text.Text.Contains("«Summary»")) text.Text = text.Text.Replace("«Summary»", cvData.Summary);
                        if (text.Text.Contains("«School»")) text.Text = text.Text.Replace("«School»", cvData.School);
                        if (text.Text.Contains("«Department»")) text.Text = text.Text.Replace("«Department»", cvData.Department);
                        if (text.Text.Contains("«GPA»")) text.Text = text.Text.Replace("«GPA»", cvData.Gpa);
                        if (text.Text.Contains("«StartDate»")) text.Text = text.Text.Replace("«StartDate»", cvData.StartDate);
                        if (text.Text.Contains("«EndDate»")) text.Text = text.Text.Replace("«EndDate»", cvData.EndDate);
                        if (text.Text.Contains("«Experience»")) text.Text = text.Text.Replace("«Experience»", cvData.Experience);
                        if (text.Text.Contains("«Position»")) text.Text = text.Text.Replace("«Position»", cvData.Position);
                        if (text.Text.Contains("«ExStart»")) text.Text = text.Text.Replace("«ExStart»", cvData.ExperienceStartDate);
                        if (text.Text.Contains("«ExEnd»")) text.Text = text.Text.Replace("«ExEnd»", cvData.ExperienceEndDate);
                        if (text.Text.Contains("«KeySkill1»")) text.Text = text.Text.Replace("«KeySkill1»", cvData.KeySkill);
                        if (text.Text.Contains("«KeySkill2»")) text.Text = text.Text.Replace("«KeySkill2»", cvData.KeySkill2);
                        if (text.Text.Contains("«Experience2»")) text.Text = text.Text.Replace("«Experience2»", cvData.Experience2);
                        if (text.Text.Contains("«Position2»")) text.Text = text.Text.Replace("«Position2»", cvData.Position2);
                        if (text.Text.Contains("«ExStart2»")) text.Text = text.Text.Replace("«ExStart2»", cvData.ExperienceStartDate2);
                        if (text.Text.Contains("«ExEnd2»")) text.Text = text.Text.Replace("«ExEnd2»", cvData.ExperienceEndDate2);
                        if (text.Text.Contains("«KeySkill3»")) text.Text = text.Text.Replace("«KeySkill3»", cvData.KeySkill3);
                        if (text.Text.Contains("«KeySkill4»")) text.Text = text.Text.Replace("«KeySkill4»", cvData.KeySkill4);
                        if (text.Text.Contains("«Cert1»")) text.Text = text.Text.Replace("«Cert1»", cvData.Certificate1);
                        if (text.Text.Contains("«Cert2»")) text.Text = text.Text.Replace("«Cert2»", cvData.Certificate2);
                        if (text.Text.Contains("«Cert3»")) text.Text = text.Text.Replace("«Cert3»", cvData.Certificate3);
                        if (text.Text.Contains("«Cert4»")) text.Text = text.Text.Replace("«Cert4»", cvData.Certificate4);
                        if (text.Text.Contains("«LinkedIn»")) text.Text = text.Text.Replace("«LinkedIn»", cvData.LinkedIn);
                        if (text.Text.Contains("«GitHub»")) text.Text = text.Text.Replace("«GitHub»", cvData.GitHub);
                    }
                    wordDoc.MainDocumentPart.Document.Save();
                }
                using (FileStream outputFileStream = new FileStream(outputFilePath, FileMode.Create))
                {
                    outputStream.Seek(0, SeekOrigin.Begin);
                    await outputStream.CopyToAsync(outputFileStream);
                }
            }
        }


        var memory = new MemoryStream();
        using (var stream = new FileStream(outputFilePath, FileMode.Open))
        {
            await stream.CopyToAsync(memory);
        }
        memory.Position = 0;

        return File(memory, "application/vnd.openxmlformats-officedocument.wordprocessingml.document", "cv.docx");
    }
}