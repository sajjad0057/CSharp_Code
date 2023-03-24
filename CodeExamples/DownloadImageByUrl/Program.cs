
using DownloadImageByUrl;

string imgUrl = @"https://3.bp.blogspot.com/-5ssCcG_F1UM/VzW7LKgVJkI/AAAAAAAAB18/gnyJ0K00NTU57MafNK-xeOO_CD5BBDCIwCLcB/s1600/How%2Bto%2Bdownload%2Bimage%2Bfrom%2Burl%2Bwith%2BPHP.png";


DownloadImage downloadImage = new DownloadImage(imgUrl);

downloadImage.download();