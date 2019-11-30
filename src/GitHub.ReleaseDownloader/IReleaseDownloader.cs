﻿namespace GitHub.ReleaseDownloader
{
    public interface IReleaseDownloader
    {
        bool IsLatestRelease(string version);
        bool DownloadLatestRelease();
        void DeInit();
    }
}