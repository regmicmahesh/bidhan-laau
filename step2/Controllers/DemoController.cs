using Microsoft.AspNetCore.Mvc;

public class DemoController: Controller {

    private readonly UserContext _usersContext;

    public DemoController(UserContext uc){
        _usersContext = uc;
    }

    public IActionResult Index(string greeting="Wow") {
        
        var cookie = new CookieOptions();

        cookie.Expires = DateTime.Now.AddDays(30);

        HttpContext.Response.Cookies.Append("ram", "shyam",cookie);

        return Content("ola");
    }

    [HttpPost]
    public IActionResult Insert(User user){

        if(ModelState.IsValid){
            // existing id -> find -> update
            // create new
                if(user.CourseID != 0){
                this._usersContext.Update(user);
                }else{
                this._usersContext.Add(user);
                }
                this._usersContext.SaveChanges();
                return Content("Accepted");
        }
                        return Content("Rejected");

    }

    [HttpGet("/Demo/delete")]
    public IActionResult Asdf(){
        return Content("OK");
    }


    

    [HttpGet]
    public IActionResult Insert(int? id){


        User returnedUser;
         if(id != null){

             returnedUser = this._usersContext.Users.Find(id);

        }else{
             returnedUser = new User();
        }

        return View(returnedUser);

        // var user = new User();
        // user.CourseID = 100;

        // this._usersContext.Add(user);

        // this._usersContext.SaveChanges();

        // return StatusCode(201);

       
    }
    public IActionResult Ola(){
        // var greeting = HttpContext.Session.GetString("Greeting") ?? "Ola";

        // return Content(greeting);

       


        var user = new User();
        user.CourseID = 100;

        var users = this._usersContext.Users.ToList();
        return View( );

    }

    

}