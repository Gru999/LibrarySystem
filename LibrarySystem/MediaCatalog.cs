using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class MediaCatalog
    {
        private List<Media> _mediaItem;


        public MediaCatalog()
        {
            _mediaItem = new List<Media>();
        }

        //Make check if media already exist in collection
        public void AddMedia(Media media) {
            if (media.Year >= 2000)
            {
                _mediaItem.Add(GetMedia(media.MediaID));
            }
            else {
                throw new Exception("The Media is from before 2010 and therefor not valid");
            }
        }

        //find bedre måde at gøre dette på
        public void PrintMediaList() {
            int i = 0;
            //foreach (var item in _mediaItem) {
            //    Console.WriteLine($"{i} \t {item}");
            //    i++;
            //} 
            while (i < _mediaItem.Count) {
                Console.WriteLine($"{i} \t {_mediaItem[i]}");
                i++;
            }
        }

        //gonna have trouble if Media has a null value
        public Media GetMedia(int mediaId) {
            foreach (Media item in _mediaItem) {
                if (item.MediaID.Equals(mediaId)) { 
                    return item;
                }
            }
            return null;
        }

        public List<Media> GetMediaByAuthor(string author) {
            List<Media> list = new List<Media>();
            int i = 0;
            //foreach (var item in _mediaItem) {
            //    if (item.Author.Equals(author)) {
            //        list.Add(item);
            //    }
            //    return list;
            //}
            //return null;

            while (i < _mediaItem.Count) {
                if (_mediaItem[i].Author.Equals(author)) {
                    list.Add(GetMedia(i));
                }
                i++;
            }
            if (list.Count > 0) {
                return list;
            } else {
                return null;
            }
        }
    }
}
