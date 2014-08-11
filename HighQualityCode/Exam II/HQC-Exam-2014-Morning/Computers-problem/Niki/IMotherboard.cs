namespace ComputersApplication
{
    public interface IMotherboard
    {
        /// <summary>
        /// Can load values from the RAM when excuted
        /// </summary>
        /// <returns></returns>
        int LoadRamValue(); 

        /// <summary>
        /// Can save values to the RAM when excuted
        /// </summary>
        /// <param name="value"></param>
        void SaveRamValue(int value); 

        /// <summary>
        /// Can draw on the video card when excuted
        /// </summary>
        /// <param name="data">Info to be send to the video-card</param>
        void DrawOnVideoCard(string data);
    }
}
