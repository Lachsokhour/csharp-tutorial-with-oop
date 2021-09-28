namespace Practices_280921
{
    public class PhotoBook
    {
        protected int numPages;
        public PhotoBook() { 
            this.numPages = 16;
        }

        public PhotoBook(int numPages) { this.numPages = numPages;}
        
        public int GetNumPages(){
            return this.numPages;
        }
    }

    public class SuperPhotoBook : PhotoBook {
        public SuperPhotoBook() { numPages = 64;}
    }
}