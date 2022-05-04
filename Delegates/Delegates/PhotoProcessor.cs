using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //photo processor
    public class PhotoProcessor
    {

        //process a photo using a delegate
        //a delegate calls a group of methods
        //.net default delegates are Action and Func
        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            //apply delegates
            filterHandler(photo);

            photo.Save();
        }
    }
}
