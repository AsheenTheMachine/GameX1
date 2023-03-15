namespace GameX1.Api.Controllers;

using System.Threading.Tasks;
using GameX1.Api.Helpers;
using GameX1.Model;
using GameX1.Repository.Helpers;
using GameX1.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using GameX1.Domain;
using AutoMapper;
using System.Net;

[Route("api/[controller]")]
[ApiController]
public class PictureController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public PictureController(IUnitOfWork unitOfWork,
        IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }


    [HttpGet]
    public IActionResult Index()
    {
        return Ok(HttpStatusCode.NotImplemented);
    }


    /// <summary>
    /// All functionss reladted to the management of pictures in the database. CRUD Functions
    /// </summary>
    #region Admin Functions

    /// <summary>
    /// Create New Picture
    /// </summary>
    /// <param name="PictureModel"></param>
    /// <returns></returns>
    [HttpPost("new")]
    public async Task<IActionResult> CreatePicture([FromBody] PictureModel model)
    {
        #region Validation
        if (!ModelState.IsValid)
            return BadRequest(new { message = GetErrors() });
        #endregion

        var picture = _mapper.Map<Picture>(model);

        // add customer object for inserting
        await _unitOfWork.Picture.Add(picture);
        int complete = await _unitOfWork.Complete();

        return Ok(complete);
    }

    /// <summary>
    /// Fetch Picture by Id
    /// </summary>
    /// <param name="id">id of picture in database</param>
    /// <returns>PictureModel</returns>
    [HttpGet("{id}")]
    public async Task<IActionResult> GetPictureById(long id)
    {
        #region Validation
        if (id <= 0)
            return BadRequest(new { message = "Id must be greater than 0!" });
        #endregion

        //fetch picture by id
        var picture = await _unitOfWork.Picture.Get(id);
        await _unitOfWork.Complete();

        if (picture == null)
            return BadRequest(new { message = "Customer does not exist!" });

        var pictureModel = _mapper.Map<PictureModel>(picture);

        return Ok(pictureModel);
    }


    /// <summary>
    /// Edit a Picture
    /// </summary>
    /// <param name="id">Id of the Picture to update</param>
    /// <param name="PictureModel">Model of data to update</param>
    /// <returns></returns>
    [HttpPut("edit/{id}")]
    public async Task<IActionResult> UpdatePicture([FromBody] PictureModel model, long id)
    {
        #region Validation
        if (!ModelState.IsValid)
            return BadRequest(new { message = GetErrors() });
        if (id <= 0)
            return BadRequest(new { message = "Id must be greater than 0" });
        #endregion

        //fetch the picture for updating
        Picture picture = await _unitOfWork.Picture.Get(id);
        await _unitOfWork.Complete();

        //fill the picture domain with values from model
        picture.Url = model.Url;

        // add picture object for updating
        _unitOfWork.Picture.Update(picture);
        return Ok(await _unitOfWork.Complete());
    }


    /// <summary>
    /// Delete a Picture
    /// </summary>
    /// <param name="Id">Picture Id</param>
    /// <returns></returns>
    [HttpDelete("remove/{id}")]
    public async Task<IActionResult> RemovePicture(long id)
    {
        #region Validation
        if (id <= 0)
            return BadRequest(new { message = "Id must be greater than 0" });
        #endregion

        var picture = await _unitOfWork.Picture.Get(id);
        _unitOfWork.Picture.Delete(picture);

        return Ok(await _unitOfWork.Complete());
    }

    /// <summary>
    /// Fetch Picture List
    /// </summary>
    /// <returns>A list of Pictures</returns>
    [HttpGet("list")]
    public async Task<IActionResult> GetAll()
    {
        var pictureList = await _unitOfWork.Picture.GetAll();
        await _unitOfWork.Complete();
        return Ok(pictureList);
    }

    #endregion
}
