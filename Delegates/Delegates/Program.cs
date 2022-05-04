using Delegates;

//create photo processor
var processor = new PhotoProcessor();
//get filters that can be applied to photo
var filters = new PhotoFilters();
//set delegate for filters that will be used
Action<Photo> filterHandler = filters.ApplyBrightness;
//apply other existing filters
filterHandler += filters.ApplyContrast;
filterHandler += filters.Resize;
//add custom filter
filterHandler += RemoveRedEyes;

//process photo with given delegate
processor.Process("photo.jpg", filterHandler);




//even though this method does not exist within the PhotoFilters class it can still be added to the delegate
static void RemoveRedEyes(Photo photo)
{
    Console.WriteLine("Apply RemoveRedEyes");
}
