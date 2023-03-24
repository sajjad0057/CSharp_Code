
using DownloadImageByUrl;

string imgUrl = @"https://3.bp.blogspot.com/-5ssCcG_F1UM/VzW7LKgVJkI/AAAAAAAAB18/gnyJ0K00NTU57MafNK-xeOO_CD5BBDCIwCLcB/s1600/How%2Bto%2Bdownload%2Bimage%2Bfrom%2Burl%2Bwith%2BPHP.png";


DownloadImage downloadImage = new DownloadImage(imgUrl);

//downloadImage.download();

IEnumerable<string> imgUrls = new List<string>()
{
 @"https://3.bp.blogspot.com/-5ssCcG_F1UM/VzW7LKgVJkI/AAAAAAAAB18/gnyJ0K00NTU57MafNK-xeOO_CD5BBDCIwCLcB/s1600/How%2Bto%2Bdownload%2Bimage%2Bfrom%2Burl%2Bwith%2BPHP.png",
 @"https://media.wired.com/photos/5b8999943667562d3024c321/master/w_2560%2Cc_limit/trash2-01.jpg",
 @"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR807WzVyUt4KpAm3ngJpl1UlkEz6ehBaKAzAHY8_rWKZrDrlAX0_4Z-j42uuKdOM3JCZg&usqp=CAU"
};


await downloadImage.DownloadImagesAsync(imgUrls);


