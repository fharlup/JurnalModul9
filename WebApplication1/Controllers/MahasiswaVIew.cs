using Microsoft.AspNetCore.Mvc;
using System.Text.Json;


[Route("api/[controller]")]
[ApiController]
public class MahasiswaController
{

    static List<string> tes = ["pbo","kpl"];
    static public List<Mahasiswa> listMhs = new List<Mahasiswa> {
            new Mahasiswa("arga", "13022223038",2003,tes),
              new Mahasiswa("fajar", "13022223032",2003,tes),
               new Mahasiswa("indra", "13022220067",2003,tes),


            };

    [HttpGet]
    public IEnumerable<Mahasiswa> Get()
    {
        return listMhs;
    }

    [HttpGet("{id}")]
    public Mahasiswa Get(int id)
    {
        return listMhs[id];
    }

    [HttpPost]
    public void Post([FromBody] Mahasiswa value)
    {
        listMhs.Add(value);
    }


    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        listMhs.RemoveAt(id);
    }
}