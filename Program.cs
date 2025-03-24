namespace Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using the media adapter
            Imediaplayer mediaPlayer = new Media_adapter();

            mediaPlayer.Play("MP3", "song.mp3");
            mediaPlayer.Play("MP4", "video.mp4");
            mediaPlayer.Play("VLC", "movie.vlc");
            mediaPlayer.Play("AVI", "unsupported.avi");  // Unsupported format
        }
    }
}
